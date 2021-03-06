'Ngày hiệu chỉnh gần nhất: 20080714
'Danh sách người thực hiện: Vũ Lê Thành,
'Mô tả:
Imports DMC.Database

Public Class clsTimKiem
    'Khai báo mảng tham số
    Dim Paras() As String = {"@MaDonViHanhChinh", "@ToBanDo", "@SoThua", "@HoanTatHoSoKeKhai" _
        , "@HoanTatThamDinh", "@HoanTatPheDuyet", "@SoPhatHanhGCN", "@SoVaoSoCapGCN", "@SoQuyetDinhCapGCN" _
        , "@HoanTatCapGCN", "@TenChuSuDung", "@SoDinhDanh"}

    'Khai báo chuỗi kết nối Database
    Private strConnection As String = ""
    'Khai báo biến kiểm tra lỗi
    Private strError As String = ""
    Private strMaDonViHanhChinh As String = ""
    Private strToBanDo As String = ""
    Private strSoThua As String = ""
    Private dblDienTichTuNhien As Double
    Private strToBanDoKKhai As String = ""
    Private strSoThuaKKhai As String = ""
    Private dblDTichTNhienKKhai As Double
    Private dblDienTichRieng As Double
    Private dblDienTichChung As Double
    Private strDiaChiThua As String = ""
    Private strHoanTatHoSoKeKhai As String = ""
    Private strHoanTatThamDinh As String = ""
    Private strHoanTatPheDuyet As String = ""
    Private strHoanTatCapGCN As String = ""
    Private strSoPhatHanhGCN As String = ""
    Private strSoVaoSoCapGCN As String = ""
    Private strSoQuyetDinhCapGCN As String = ""
    Private strTenChuSuDung As String = ""
    Private strSoDinhDanh As String = ""
    Private strMaHoSoCapGCN As String = ""

    'Khai báo thuộc tính gán chuỗi kết nối cơ sở dữ liệu
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property

    Public ReadOnly Property Err() As String
        Get
            Return strError
        End Get
    End Property

    'Khai bao thuoc tinh ung voi bien MaDonViHanhChinh
    Public Property MaDonViHanhChinh() As String
        Get
            Return strMaDonViHanhChinh
        End Get
        Set(ByVal value As String)
            strMaDonViHanhChinh = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien ToBanDo
    Public Property ToBanDo() As String
        Get
            Return strToBanDo
        End Get
        Set(ByVal value As String)
            strToBanDo = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien strSoThua
    Public Property SoThua() As String
        Get
            Return strSoThua
        End Get
        Set(ByVal value As String)
            strSoThua = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien dblDienTichTuNhien
    Public Property DienTichTuNhien() As Double
        Get
            Return dblDienTichTuNhien
        End Get
        Set(ByVal value As Double)
            dblDienTichTuNhien = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien ToBanDoKKhai
    Public Property ToBanDoKKhai() As String
        Get
            Return strToBanDoKKhai
        End Get
        Set(ByVal value As String)
            strToBanDoKKhai = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien strSoThuaKKhai
    Public Property SoThuaKKhai() As String
        Get
            Return strSoThuaKKhai
        End Get
        Set(ByVal value As String)
            strSoThuaKKhai = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien dblDTichTNhienKKhai
    Public Property DTichTNhienKKhai() As Double
        Get
            Return dblDTichTNhienKKhai
        End Get
        Set(ByVal value As Double)
            dblDTichTNhienKKhai = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien dblDienTichRieng
    Public Property DienTichRieng() As Double
        Get
            Return dblDienTichRieng
        End Get
        Set(ByVal value As Double)
            dblDienTichRieng = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien dblDienTichChung
    Public Property DienTichChung() As Double
        Get
            Return dblDienTichChung
        End Get
        Set(ByVal value As Double)
            dblDienTichChung = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien strDiaChiThua
    Public Property DiaChiThua() As String
        Get
            Return strDiaChiThua
        End Get
        Set(ByVal value As String)
            strDiaChiThua = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien
    Public Property HoanTatHoSoKeKhai() As String
        Get
            Return strHoanTatHoSoKeKhai
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    value = 0
            'End If
            strHoanTatHoSoKeKhai = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien
    Public Property HoanTatThamDinh() As String
        Get
            Return strHoanTatThamDinh
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    value = 0
            'End If
            strHoanTatThamDinh = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien KetQuaPheDuyet
    Public Property HoanTatPheDuyet() As String
        Get
            Return strHoanTatPheDuyet
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    value = 0
            'End If
            strHoanTatPheDuyet = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien
    Public Property HoanTatCapGCN() As String
        Get
            Return strHoanTatCapGCN
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    value = 0
            'End If
            strHoanTatCapGCN = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien SoPhatHanhGCN
    Public Property SoPhatHanhGCN() As String
        Get
            Return strSoPhatHanhGCN
        End Get
        Set(ByVal value As String)
            strSoPhatHanhGCN = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien SoVaoSoCapGCN
    Public Property SoVaoSoCapGCN() As String
        Get
            Return strSoVaoSoCapGCN
        End Get
        Set(ByVal value As String)
            strSoVaoSoCapGCN = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property SoQuyetDinhCapGCN() As String
        Get
            Return strSoQuyetDinhCapGCN
        End Get
        Set(ByVal value As String)
            strSoQuyetDinhCapGCN = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien TenNguoiSuDung
    Public Property TenChuSuDung() As String
        Get
            Return strTenChuSuDung
        End Get
        Set(ByVal value As String)
            strTenChuSuDung = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien SoCMT
    Public Property SoDinhDanh() As String
        Get
            Return strSoDinhDanh
        End Get
        Set(ByVal value As String)
            strSoDinhDanh = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien strMaHoSoCapGCN
    Public Property MaHoSoCapGCN() As String
        Get
            Return strMaHoSoCapGCN
        End Get
        Set(ByVal value As String)
            strMaHoSoCapGCN = value
        End Set
    End Property


    Public Function Execute(ByRef records As Integer) As String
        Try
            'Khai báo và khởi tạo đối tượng Database
            Dim Database As New clsDatabase
            'Neu ket noi co so du lieu thanh cong
            Database.Connection = strConnection
            If Database.OpenConnection = True Then
                'Khai bao mang gia tri
                Dim Values() As String = _
                {strMaDonViHanhChinh, strToBanDo, strSoThua, strHoanTatHoSoKeKhai, strHoanTatThamDinh _
                , strHoanTatPheDuyet, strSoPhatHanhGCN, strSoVaoSoCapGCN, strSoQuyetDinhCapGCN, strHoanTatCapGCN _
                , strTenChuSuDung, strSoDinhDanh}
                'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
                If (Paras.Length <> Values.Length) Then
                    Return "Mảng giá trị chuyền vào chưa phù hợp!"
                End If
                'Gọi phương thức ExecuteSp của đối tượng clsDatabase
                Database.ExecuteSP("spTimKiem", Paras, Values, records)
                strError = Database.Err
                Database.CloseConnection()
            End If
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strError
    End Function

    Public Function GetData(ByRef records As DataTable) As String
        Dim strError As String = ""
        Try
            'Khoi tao doi tuong DMC.clsDatabase
            Dim Database As New clsDatabase
            Database.Connection = strConnection
            If (Database.OpenConnection) Then
                'Neu ket noi co so du lieu thanh cong
                'Khai bao mang gia tri
                Dim Values() As String = _
                {strMaDonViHanhChinh, strToBanDo, strSoThua, strHoanTatHoSoKeKhai, strHoanTatThamDinh _
                , strHoanTatPheDuyet, strSoPhatHanhGCN, strSoVaoSoCapGCN, strSoQuyetDinhCapGCN, strHoanTatCapGCN _
                , strTenChuSuDung, strSoDinhDanh}
                'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
                If (Paras.Length <> Values.Length) Then
                    Return "Mảng giá trị chuyền vào chưa phù hợp!"
                End If
                'Gọi phương thức GetValue của đối tượng clsDatabase
                Database.getValue(records, "spTimKiem", Paras, Values)
                Database.CloseConnection()
                strError = ""
            End If
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strError
    End Function
End Class
