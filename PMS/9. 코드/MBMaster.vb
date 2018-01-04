Imports System
Imports System.Collections
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace ModbusTCP

    Public Class Master

        ' ------------------------------------------------------------------------
        ' Constants for access
        Private Const fctReadCoil As Byte = 1

        Private Const fctReadDiscreteInputs As Byte = 2

        Private Const fctReadHoldingRegister As Byte = 3

        Private Const fctReadInputRegister As Byte = 4

        Private Const fctWriteSingleCoil As Byte = 5

        Private Const fctWriteSingleRegister As Byte = 6

        Private Const fctWriteMultipleCoils As Byte = 15

        Private Const fctWriteMultipleRegister As Byte = 16

        Private Const fctReadWriteMultipleRegister As Byte = 23

        ''' <summary>Constant for exception illegal function.</summary>
        Public Const excIllegalFunction As Byte = 1

        ''' <summary>Constant for exception illegal data address.</summary>
        Public Const excIllegalDataAdr As Byte = 2

        ''' <summary>Constant for exception illegal data value.</summary>
        Public Const excIllegalDataVal As Byte = 3

        ''' <summary>Constant for exception slave device failure.</summary>
        Public Const excSlaveDeviceFailure As Byte = 4

        ''' <summary>Constant for exception acknowledge.</summary>
        Public Const excAck As Byte = 5

        ''' <summary>Constant for exception slave is busy/booting up.</summary>
        Public Const excSlaveIsBusy As Byte = 6

        ''' <summary>Constant for exception gate path unavailable.</summary>
        Public Const excGatePathUnavailable As Byte = 10

        ''' <summary>Constant for exception not connected.</summary>
        Public Const excExceptionNotConnected As Byte = 253

        ''' <summary>Constant for exception connection lost.</summary>
        Public Const excExceptionConnectionLost As Byte = 254

        ''' <summary>Constant for exception response timeout.</summary>
        Public Const excExceptionTimeout As Byte = 255

        ''' <summary>Constant for exception wrong offset.</summary>
        Private Const excExceptionOffset As Byte = 128

        ''' <summary>Constant for exception send failt.</summary>
        Private Const excSendFailt As Byte = 100

        ' ------------------------------------------------------------------------
        ' Private declarations
        Private Shared _timeout As Integer = 500

        Private Shared _refresh As Integer = 10

        Private Shared _connected As Boolean = False

        Private tcpAsyCl As Socket

        Private tcpAsyClBuffer() As Byte = New Byte((2048) - 1) {}

        Private tcpSynCl As Socket

        Private tcpSynClBuffer() As Byte = New Byte((2048) - 1) {}

        ' ------------------------------------------------------------------------
        ''' <summary>Response data event. This event is called when new data arrives</summary>
        Public Delegate Sub ResponseData(ByVal ids As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal data() As Byte)

        ''' <summary>Response data event. This event is called when new data arrives</summary>
        Public Event OnResponseData As ResponseData

        ''' <summary>Exception data event. This event is called when the data is incorrect</summary>
        Public Delegate Sub ExceptionData(ByVal ids As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal exception As Byte)

        ''' <summary>Exception data event. This event is called when the data is incorrect</summary>
        Public Event OnException As ExceptionData

        ' ------------------------------------------------------------------------
        ''' <summary>Response timeout. If the slave didn't answers within in this time an exception is called.</summary>
        ''' <value>The default value is 500ms.</value>
        Public Property timeout() As Integer
            Get
                Return _timeout
            End Get
            Set(ByVal value As Integer)
                _timeout = value
            End Set
        End Property

        ' ------------------------------------------------------------------------
        ''' <summary>Refresh timer for slave answer. The class is polling for answer every X ms.</summary>
        ''' <value>The default value is 10ms.</value>
        Public Property refresh() As Integer
            Get
                Return _refresh
            End Get
            Set(ByVal value As Integer)
                _refresh = value
            End Set
        End Property

        ' ------------------------------------------------------------------------
        ''' <summary>Shows if a connection is active.</summary>
        Public ReadOnly Property connected() As Boolean
            Get
                Return _connected
            End Get
        End Property


        ' ------------------------------------------------------------------------
        ''' <summary>Create master instance with parameters.</summary>
        ''' <param name="ip">IP adress of modbus slave.</param>
        ''' <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
        Public Sub New(ByVal ip As String, ByVal port As Integer)
            MyBase.New()
            Me.connect(ip, port)
        End Sub

        ' ------------------------------------------------------------------------
        ''' <summary>Start connection to slave.</summary>
        ''' <param name="ip">IP adress of modbus slave.</param>
        ''' <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
        Public Sub connect(ByVal ip As String, ByVal port As Integer)
            Try

                ' ----------------------------------------------------------------
                ' Connect asynchronous client
                Me.tcpAsyCl = New Socket(IPAddress.Parse(ip).AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                Me.tcpAsyCl.Connect(New IPEndPoint(IPAddress.Parse(ip), port))
                Me.tcpAsyCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, _timeout)
                Me.tcpAsyCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, _timeout)
                Me.tcpAsyCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1)
                ' ----------------------------------------------------------------
                ' Connect synchronous client
                Me.tcpSynCl = New Socket(IPAddress.Parse(ip).AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                Me.tcpSynCl.Connect(New IPEndPoint(IPAddress.Parse(ip), port))
                Me.tcpSynCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, _timeout)
                Me.tcpSynCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, _timeout)
                Me.tcpSynCl.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1)
                _connected = True
            Catch err As System.IO.IOException
                _connected = False
                Throw
            End Try

        End Sub

        ' ------------------------------------------------------------------------
        ''' <summary>Stop connection to slave.</summary>
        Public Sub disconnect()
            Me.Dispose()
        End Sub

        ' ------------------------------------------------------------------------
        ''' <summary>Destroy master instance.</summary>
        Private Sub New()
            MyBase.New()
            Me.Dispose()
        End Sub

        ' ------------------------------------------------------------------------
        ''' <summary>Destroy master instance</summary>
        Public Sub Dispose()
            If (Not (Me.tcpAsyCl) Is Nothing) Then
                If Me.tcpAsyCl.Connected Then
                    Try
                        Me.tcpAsyCl.Shutdown(SocketShutdown.Both)
                    Catch err As System.Exception

                    End Try

                    Me.tcpAsyCl.Close()
                End If

                Me.tcpAsyCl = Nothing
            End If

            If (Not (Me.tcpSynCl) Is Nothing) Then
                If Me.tcpSynCl.Connected Then
                    Try
                        Me.tcpSynCl.Shutdown(SocketShutdown.Both)
                    Catch err As System.Exception

                    End Try

                    Me.tcpSynCl.Close()
                End If

                Me.tcpSynCl = Nothing
            End If

        End Sub

        Friend Sub CallException(ByVal id As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal exception As Byte)
            If ((Me.tcpAsyCl Is Nothing) _
                        OrElse (Me.tcpSynCl Is Nothing)) Then
                Return
            End If

            If (exception = excExceptionConnectionLost) Then
                Me.tcpSynCl = Nothing
                Me.tcpAsyCl = Nothing
            End If

            'If (Not (OnException) Is Nothing) Then
            'RaiseEvent OnException(id, unit, func, exception)
            'End If

        End Sub

        Friend Shared Function SwapUInt16(ByVal inValue As UInt16) As UInt16
            Return CType((((inValue And 65280) _
                        + 8) _
                        Or ((inValue And 255) _
                        + 8)), UInt16)
        End Function

        Public Overloads Sub ReadCoils(ByVal ids As Integer, ByVal unit As Byte, ByRef startAddress As Integer, ByVal numInputs As Integer)
            Me.WriteAsyncData(Me.CreateReadHeader(ids, unit, startAddress, numInputs, fctReadCoil), ids)
        End Sub



        Public Overloads Sub ReadDiscreteInputs(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal numInputs As Integer)
            Me.WriteAsyncData(Me.CreateReadHeader(ids, unit, startAddress, numInputs, fctReadDiscreteInputs), ids)
        End Sub



        Public Overloads Sub ReadHoldingRegister(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal numInputs As Integer)
            Me.WriteAsyncData(Me.CreateReadHeader(ids, unit, startAddress, numInputs, fctReadHoldingRegister), ids)
        End Sub



        Public Overloads Sub ReadInputRegister(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal numInputs As Integer)
            Me.WriteAsyncData(Me.CreateReadHeader(ids, unit, startAddress, numInputs, fctReadInputRegister), ids)
        End Sub


        Public Overloads Sub WriteSingleCoils(ByVal ids As Integer, ByVal unit As Byte, ByRef startAddress As Integer, ByVal OnOff As Boolean)
            Dim data() As Byte
            data = Me.CreateWriteHeader(ids, unit, startAddress, 1, 1, fctWriteSingleCoil)
            If (OnOff = True) Then
                data(10) = 255
            Else
                data(10) = 0
            End If

            Me.WriteAsyncData(data, ids)
        End Sub


        Public Overloads Sub WriteMultipleCoils(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal numBits As Integer, ByVal values() As Byte)
            Dim numBytes As Byte = Convert.ToByte(values.Length)
            Dim data() As Byte
            data = Me.CreateWriteHeader(ids, unit, startAddress, numBits, CType((numBytes + 2), Byte), fctWriteMultipleCoils)
            Array.Copy(values, 0, data, 13, numBytes)
            Me.WriteAsyncData(data, ids)
        End Sub




        Public Overloads Sub WriteSingleRegister(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal values() As Byte)
            Dim data() As Byte
            data = Me.CreateWriteHeader(ids, unit, startAddress, 1, 1, fctWriteSingleRegister)
            data(10) = values(0)
            data(11) = values(1)
            Me.WriteAsyncData(data, ids)
        End Sub


        Public Overloads Sub WriteMultipleRegister(ByVal ids As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal values() As Byte)
            Dim numBytes As Integer = Convert.ToUInt16(values.Length)
            If ((numBytes Mod 2) _
                        > 0) Then
                numBytes = (numBytes + 1)
            End If

            Dim data() As Byte
            data = Me.CreateWriteHeader(ids, unit, startAddress, Convert.ToUInt16((numBytes / 2)), Convert.ToUInt16((numBytes + 2)), fctWriteMultipleRegister)
            Array.Copy(values, 0, data, 13, values.Length)
            Me.WriteAsyncData(data, ids)
        End Sub




        ' ------------------------------------------------------------------------
        ' Create modbus header for read action
        Private Function CreateReadHeader(ByVal id As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal length As Integer, ByVal func As Byte) As Byte()
            Dim data() As Byte = New Byte((12) - 1) {}
            Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
            data(0) = _id(1)
            ' Slave id high byte
            data(1) = _id(0)
            ' Slave id low byte
            data(5) = 6
            ' Message size
            data(6) = unit
            ' Slave address
            data(7) = func
            ' Function code
            Dim _adr() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startAddress, Short)), Short))
            data(8) = _adr(0)
            ' Start address
            data(9) = _adr(1)
            ' Start address
            Dim _length() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(length, Short)), Short))
            data(10) = _length(0)
            ' Number of data to read
            data(11) = _length(1)
            ' Number of data to read
            Return data
        End Function

        ' ------------------------------------------------------------------------
        ' Create modbus header for write action
        Private Function CreateWriteHeader(ByVal id As Integer, ByVal unit As Byte, ByVal startAddress As Integer, ByVal numData As Integer, ByVal numBytes As Integer, ByVal func As Byte) As Byte()
            Dim data() As Byte = New Byte(((numBytes + 11)) - 1) {}
            Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
            data(0) = _id(1)
            ' Slave id high byte
            data(1) = _id(0)
            ' Slave id low byte
            Dim _size() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType((5 + numBytes), Short)), Short))
            data(4) = _size(0)
            ' Complete message size in bytes
            data(5) = _size(1)
            ' Complete message size in bytes
            data(6) = unit
            ' Slave address
            data(7) = func
            ' Function code
            Dim _adr() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startAddress, Short)), Short))
            data(8) = _adr(0)
            ' Start address
            data(9) = _adr(1)
            ' Start address
            If (func >= fctWriteMultipleCoils) Then
                Dim _cnt() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(numData, Short)), Short))
                data(10) = _cnt(0)
                ' Number of bytes
                data(11) = _cnt(1)
                ' Number of bytes
                data(12) = CType((numBytes - 2), Byte)
            End If

            Return data
        End Function

        ' ------------------------------------------------------------------------
        ' Create modbus header for read/write action
        Private Function CreateReadWriteHeader(ByVal id As Integer, ByVal unit As Byte, ByVal startReadAddress As Integer, ByVal numRead As Integer, ByVal startWriteAddress As Integer, ByVal numWrite As Integer) As Byte()
            Dim data() As Byte = New Byte((((numWrite * 2) _
                        + 17)) - 1) {}
            Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
            data(0) = _id(1)
            ' Slave id high byte
            data(1) = _id(0)
            ' Slave id low byte
            Dim _size() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType((11 _
                                + (numWrite * 2)), Short)), Short))
            data(4) = _size(0)
            ' Complete message size in bytes
            data(5) = _size(1)
            ' Complete message size in bytes
            data(6) = unit
            ' Slave address
            data(7) = fctReadWriteMultipleRegister
            ' Function code
            Dim _adr_read() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startReadAddress, Short)), Short))
            data(8) = _adr_read(0)
            ' Start read address
            data(9) = _adr_read(1)
            ' Start read address
            Dim _cnt_read() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(numRead, Short)), Short))
            data(10) = _cnt_read(0)
            ' Number of bytes to read
            data(11) = _cnt_read(1)
            ' Number of bytes to read
            Dim _adr_write() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startWriteAddress, Short)), Short))
            data(12) = _adr_write(0)
            ' Start write address
            data(13) = _adr_write(1)
            ' Start write address
            Dim _cnt_write() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(numWrite, Short)), Short))
            data(14) = _cnt_write(0)
            ' Number of bytes to write
            data(15) = _cnt_write(1)
            ' Number of bytes to write
            data(16) = CType((numWrite * 2), Byte)
            Return data
        End Function

        ' ------------------------------------------------------------------------
        ' Write asynchronous data
        Private Sub WriteAsyncData(ByVal write_data() As Byte, ByVal id As Integer)
            If ((Not (Me.tcpAsyCl) Is Nothing) _
                        AndAlso Me.tcpAsyCl.Connected) Then
                Try
                    Me.tcpAsyCl.BeginSend(write_data, 0, write_data.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), Nothing)
                    Me.tcpAsyCl.BeginReceive(Me.tcpAsyClBuffer, 0, Me.tcpAsyClBuffer.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Me.tcpAsyCl)
                Catch a As SystemException
                    'Me.CallException(id, write_data(6), write_data(7), excExceptionConnectionLost)
                End Try

            Else
                'Me.CallException(id, write_data(6), write_data(7), excExceptionConnectionLost)
            End If

        End Sub

        ' ------------------------------------------------------------------------
        ' Write asynchronous data acknowledge
        Private Sub OnSend(ByVal result As System.IAsyncResult)
            If (result.IsCompleted = False) Then
                Me.CallException(65535, 255, 255, excSendFailt)
            End If

        End Sub

        ' ------------------------------------------------------------------------
        ' Write asynchronous data response
        Private Sub OnReceive(ByVal result As System.IAsyncResult)
            If (result.IsCompleted = False) Then
                Me.CallException(255, 255, 255, excExceptionConnectionLost)
            End If

            Dim id As Integer = Master.SwapUInt16(BitConverter.ToUInt16(Me.tcpAsyClBuffer, 0))
            Dim unit As Byte = Me.tcpAsyClBuffer(6)
            Dim func As Byte = Me.tcpAsyClBuffer(7)
            Dim data() As Byte
            ' ------------------------------------------------------------
            ' Write response data
            If ((func >= fctWriteSingleCoil) _
                        AndAlso (func <> fctReadWriteMultipleRegister)) Then
                data = New Byte((2) - 1) {}
                Array.Copy(Me.tcpAsyClBuffer, 10, data, 0, 2)
            End If

            ' ------------------------------------------------------------
            ' Read response data
            data = New Byte((Me.tcpAsyClBuffer(8)) - 1) {}
            Array.Copy(Me.tcpAsyClBuffer, 9, data, 0, Me.tcpAsyClBuffer(8))
            ' ------------------------------------------------------------
            ' Response data is slave exception
            If (func > excExceptionOffset) Then
                func = (func - excExceptionOffset)
                Me.CallException(id, unit, func, Me.tcpAsyClBuffer(8))
            End If

            ' ------------------------------------------------------------
            ' Response data is regular data
            ' If (Not (OnResponseData) Is Nothing) Then
            'RaiseEvent OnResponseData(id, unit, func, data)
            'End If

        End Sub

        
    End Class
End Namespace