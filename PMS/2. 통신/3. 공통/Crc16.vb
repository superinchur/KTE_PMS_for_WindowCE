Public Class Crc16
    Private Shared CrcTable As UShort() = {&H0, &HC0C1, &HC181, &H140, &HC301, &H3C0, _
          &H280, &HC241, &HC601, &H6C0, &H780, &HC741, _
          &H500, &HC5C1, &HC481, &H440, &HCC01, &HCC0, _
          &HD80, &HCD41, &HF00, &HCFC1, &HCE81, &HE40, _
          &HA00, &HCAC1, &HCB81, &HB40, &HC901, &H9C0, _
          &H880, &HC841, &HD801, &H18C0, &H1980, &HD941, _
          &H1B00, &HDBC1, &HDA81, &H1A40, &H1E00, &HDEC1, _
          &HDF81, &H1F40, &HDD01, &H1DC0, &H1C80, &HDC41, _
          &H1400, &HD4C1, &HD581, &H1540, &HD701, &H17C0, _
          &H1680, &HD641, &HD201, &H12C0, &H1380, &HD341, _
          &H1100, &HD1C1, &HD081, &H1040, &HF001, &H30C0, _
          &H3180, &HF141, &H3300, &HF3C1, &HF281, &H3240, _
          &H3600, &HF6C1, &HF781, &H3740, &HF501, &H35C0, _
          &H3480, &HF441, &H3C00, &HFCC1, &HFD81, &H3D40, _
          &HFF01, &H3FC0, &H3E80, &HFE41, &HFA01, &H3AC0, _
          &H3B80, &HFB41, &H3900, &HF9C1, &HF881, &H3840, _
          &H2800, &HE8C1, &HE981, &H2940, &HEB01, &H2BC0, _
          &H2A80, &HEA41, &HEE01, &H2EC0, &H2F80, &HEF41, _
          &H2D00, &HEDC1, &HEC81, &H2C40, &HE401, &H24C0, _
          &H2580, &HE541, &H2700, &HE7C1, &HE681, &H2640, _
          &H2200, &HE2C1, &HE381, &H2340, &HE101, &H21C0, _
          &H2080, &HE041, &HA001, &H60C0, &H6180, &HA141, _
          &H6300, &HA3C1, &HA281, &H6240, &H6600, &HA6C1, _
          &HA781, &H6740, &HA501, &H65C0, &H6480, &HA441, _
          &H6C00, &HACC1, &HAD81, &H6D40, &HAF01, &H6FC0, _
          &H6E80, &HAE41, &HAA01, &H6AC0, &H6B80, &HAB41, _
          &H6900, &HA9C1, &HA881, &H6840, &H7800, &HB8C1, _
          &HB981, &H7940, &HBB01, &H7BC0, &H7A80, &HBA41, _
          &HBE01, &H7EC0, &H7F80, &HBF41, &H7D00, &HBDC1, _
          &HBC81, &H7C40, &HB401, &H74C0, &H7580, &HB541, _
          &H7700, &HB7C1, &HB681, &H7640, &H7200, &HB2C1, _
          &HB381, &H7340, &HB101, &H71C0, &H7080, &HB041, _
          &H5000, &H90C1, &H9181, &H5140, &H9301, &H53C0, _
          &H5280, &H9241, &H9601, &H56C0, &H5780, &H9741, _
          &H5500, &H95C1, &H9481, &H5440, &H9C01, &H5CC0, _
          &H5D80, &H9D41, &H5F00, &H9FC1, &H9E81, &H5E40, _
          &H5A00, &H9AC1, &H9B81, &H5B40, &H9901, &H59C0, _
          &H5880, &H9841, &H8801, &H48C0, &H4980, &H8941, _
          &H4B00, &H8BC1, &H8A81, &H4A40, &H4E00, &H8EC1, _
          &H8F81, &H4F40, &H8D01, &H4DC0, &H4C80, &H8C41, _
          &H4400, &H84C1, &H8581, &H4540, &H8701, &H47C0, _
          &H4680, &H8641, &H8201, &H42C0, &H4380, &H8341, _
          &H4100, &H81C1, &H8081, &H4040}

    Public Function CalcCRC(ByVal btFrameData() As Byte, ByVal nOffset As Integer, ByVal nLength As Integer) As Integer
        Dim crc As UShort = &HFFFF

        For i As Integer = 0 To nLength - 1
            crc = CUShort((crc >> 8) Xor CrcTable((crc Xor btFrameData(nOffset + i)) And &HFF))
        Next

        Return crc
    End Function

End Class
