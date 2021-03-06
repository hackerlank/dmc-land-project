'Ngày hiệu chỉnh gần nhất: 200807
'Danh sách người thực hiện: Vũ Lê Thành,
'Mô tả:
'Khai bao mang tham so
Imports DMC.Database
Public Class clsThongTinThuaTuNhien

    'Khai báo biến nhận chuỗi kết nối Database
    Private strConnnection As String = ""
    'Khai báo biến kiểm tra lỗi
    Private strError As String
    Private strMaThuaDat As String
    Private strToBanDo As String
    Private strSoThua As String
    Private dblDienTichTuNhien As String
    Private strMaHoSoCapGCN As String = ""
    'Private btHinhDangThua As Byte
    'Khai báo thuộc tính nhận chuỗi kết nối Database
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnnection = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien
    Public ReadOnly Property Err() As String
        Get
            Return strError
        End Get
    End Property
    Public Property HoSoCapGCN() As String
        Get
            Return strMaHoSoCapGCN
        End Get
        Set(ByVal value As String)
            strMaHoSoCapGCN = value
        End Set
    End Property
    Private strMaDonViHanhChinh As String = ""

    Public Property MaDonViHanhChinh() As String
        Get
            Return strMaDonViHanhChinh
        End Get
        Set(ByVal value As String)
            strMaDonViHanhChinh = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien 
    Public Property MaThuaDat() As String
        Get
            Return strMaThuaDat
        End Get
        Set(ByVal value As String)
            strMaThuaDat = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property ToBanDo() As String
        Get
            Return strToBanDo
        End Get
        Set(ByVal value As String)
            strToBanDo = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property SoThua() As String
        Get
            Return strSoThua
        End Get
        Set(ByVal value As String)
            strSoThua = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property DienTichTuNhien() As String
        Get
            Return dblDienTichTuNhien
        End Get
        Set(ByVal value As String)
            dblDienTichTuNhien = value
        End Set
    End Property

    'Public Function Execute(ByRef records As Integer) As String
    '    Try
    '        'Khai báo và khởi tạo đối tượng clsDatabase
    '        Dim Database As New clsDatabase
    '        'Neu ket noi co so du lieu thanh cong
    '        Database.Connection = strConnnection
    '        If Database.OpenConnection = True Then
    '            'Khai bao mang gia tri
    '            Dim Values() As String = _
    '            {strMaThuaDat, strToBanDo, strSoThua, dblDienTichTuNhien}
    '            'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
    '            If (Paras.Length <> Values.Length) Then
    '                Return "Mảng giá trị chuyền vào chưa phù hợp!"
    '            End If
    '            'Goi phuong thuc ExecuteSP cua doi tuong clsSQLDatabase
    '            Database.ExecuteSP("spSelectThongTinThuaTuNhien", Paras, Values, records)
    '            strError = Database.Err
    '            Database.CloseConnection()
    '        End If
    '    Catch ex As Exception
    '        strError = ex.Message
    '    End Try
    '    Return strError
    'End Function

    ''' <summary>
    ''' Truy vấn thông tin TỰ NHIÊN thửa đất
    ''' </summary>
    ''' <param name="dtRecords"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectThongTinTuNhien(ByRef dtRecords As DataTable) As String
        Dim Paras() As String = {"@MaThuaDat", "@ToBanDo", "@SoThua", "@DienTichTuNhien", "@MaDonViHanhChinh"} ', "@HinhDangThua"}
        Dim Values() As String = _
                   {strMaThuaDat, strToBanDo, strSoThua, dblDienTichTuNhien, strMaDonViHanhChinh}
        Return Me.SelectData("spSelectThongTinThuaTuNhien", dtRecords, Paras, Values)
    End Function

    ''' <summary>
    ''' Truy vấn thông tin LỊCH SỬ thửa đất
    ''' </summary>
    ''' <param name="dtRecords"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectThongTinLichSu(ByRef dtRecords As DataTable) As String
        Dim Paras() As String = {"@MaThuaDat", "@ToBanDo", "@SoThua", "@DienTichTuNhien"} ', "@HinhDangThua"}
        Dim Values() As String = _
                   {strMaThuaDat, strToBanDo, strSoThua, dblDienTichTuNhien}
        Return Me.SelectData("spSelectLichSuThuaDat", dtRecords, Paras, Values)
    End Function

    Public Function SelectMaHoSoCapGCN(ByRef dtRecords As DataTable) As String
        Dim Paras() As String = {"@MaThuaDat", "@ToBanDo", "@SoThua", "@DienTichTuNhien"} ', "@HinhDangThua"}
        Dim Values() As String = _
                   {strMaThuaDat, strToBanDo, strSoThua, dblDienTichTuNhien}
        Return Me.SelectData("spSelectMaHoSoCapGCNByToBanDoSoThua", dtRecords, Paras, Values)
    End Function
    Public Function SelectThongTinHoSo(ByRef dtRecords As DataTable) As String
        Dim Paras() As String = {"@MaHoSoCapGCN"} ', "@HinhDangThua"}
        Dim Values() As String = {strMaHoSoCapGCN}
        Return Me.SelectData("spSelectThongTinChuByMaHoSoCapGCN", dtRecords, Paras, Values)
    End Function
    ''' <summary>
    ''' Hàm truy vấn cơ sở dữ liệu
    ''' </summary>
    ''' <param name="strStoreProcedureName"></param>
    ''' <param name="dtRecords"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SelectData(ByVal strStoreProcedureName As String, ByRef dtRecords As DataTable, ByVal paras() As String, ByVal values() As String) As String
        Try
            'Khai báo và khởi tạo đối tượng clsDatabase
            Dim Database As New clsDatabase
            Database.Connection = strConnnection
            If (Database.OpenConnection = True) Then
                'Neu ket noi co so du lieu thanh cong
                'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
                If (paras.Length <> values.Length) Then
                    Return "Mảng giá trị chuyền vào chưa phù hợp!"
                End If
                'Goi phuong thuc GetValue cua doi tuong DMC.clsDatabase
                Database.getValue(dtRecords, strStoreProcedureName, paras, values)
                Database.CloseConnection()
                strError = ""
            End If
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strError
    End Function
End Class
