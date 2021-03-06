'Ngày hiệu chỉnh gần nhất: 200807
'Danh sách người thực hiện: Vũ Lê Thành,
'Mô tả:
Imports DMC.Database
Public Class clsThongTinThuaKeKhai
    'Khai báo mảng tham số
    Dim Paras() As String = { _
        "@MaThuaDatCapGCN", "@MaHoSoCapGCN", "@ToBanDo", "@SoThua", _
        "@DiaChi", "@DienTich", "@DienTichBangChu", "@DienTichRieng", _
        "@DienTichChung", "@MucDichSuDung", "@ThoiHanSuDung", "@NguonGocSuDung" _
        , "@DienTichKhongCap", "@DienTichKhongCapBangChu", "@LyDoKhongCap", "@GhiChu", "@LoaiDuong", "@ViTri", "@NgoRong", "@CachDuongChinh", "@LPTB", "@TTNCN", "@NoiDungHoSo", "@DT100GiaDat", "@DT50GiaDat", "@DT40GiaDat", "@DT20GiaDat", "@MaDonViHanhChinh", "@MaThuaDat"}
    'Khai báo biến chuỗi kết nối cơ sở dữ liệu
    Private strConnection As String = ""
    'Khai báo biến kiểm tra lỗi
    Private strError As String = ""
    Private strMaThuaDatCapGCN As String
    Private strMaHoSoCapGCN As String
    Private strToBanDo As String
    Private strSoThua As String
    Private strDiaChi As String
    Private strDienTich As String
    Private strDienTichBangChu As String
    Private strDienTichRieng As String
    Private strDienTichChung As String
    Private strMucDichSuDung As String
    Private strThoiHanSuDung As String
    Private strNguonGocSuDung As String

    Private strDienTichKhongCap As String
    Private strDienTichKhongCapBangChu As String
    Private strLyDoKhongCap As String
    Private strGhiChu As String
    Private strMaDonViHanhChinh As String = ""

    Private strLoaiDuong As String = ""
    Private strViTri As String = ""
    Private strNgoRong As String = "0"
    Private strCachDuongChinh As String = "0"

    Private strLPTB As String = ""
    Private strTTNCN As String = ""
    Private strDT100GiaDat As String = ""
    Private strDT50GiaDat As String = ""
    Private strDT40GiaDat As String = ""
    Private strDT20GiaDat As String = ""

    Private strMaThuaDat As String = ""

    Public Property MaThuaDat() As String
        Get
            Return strMaThuaDat
        End Get
        Set(ByVal value As String)
            strMaThuaDat = value
        End Set
    End Property

    Public Property DT100GiaDat() As String
        Get
            Return strDT100GiaDat
        End Get
        Set(ByVal value As String)
            strDT100GiaDat = value
        End Set
    End Property
    Public Property DT50GiaDat() As String
        Get
            Return strDT50GiaDat
        End Get
        Set(ByVal value As String)
            strDT50GiaDat = value
        End Set
    End Property
    Public Property DT40GiaDat() As String
        Get
            Return strDT40GiaDat
        End Get
        Set(ByVal value As String)
            strDT40GiaDat = value
        End Set
    End Property
    Public Property DT20GiaDat() As String
        Get
            Return strDT20GiaDat
        End Get
        Set(ByVal value As String)
            strDT20GiaDat = value
        End Set
    End Property

    Private strNoiDungHoSo As String = ""

    Public Property NoiDungHoSo() As String
        Get
            Return strNoiDungHoSo
        End Get
        Set(ByVal value As String)
            strNoiDungHoSo = value
        End Set
    End Property

    Public Property LPTB() As String
        Get
            Return strLPTB
        End Get
        Set(ByVal value As String)
            strLPTB = value
        End Set
    End Property
    Public Property TTNCN() As String
        Get
            Return strTTNCN
        End Get
        Set(ByVal value As String)
            strTTNCN = value
        End Set
    End Property

    Public Property LoaiDuong() As String
        Get
            Return strLoaiDuong
        End Get
        Set(ByVal value As String)
            strLoaiDuong = value
        End Set
    End Property
    Public Property ViTri() As String
        Get
            Return strViTri
        End Get
        Set(ByVal value As String)
            strViTri = value
        End Set
    End Property
    Public Property NgoRong() As String
        Get
            Return strNgoRong
        End Get
        Set(ByVal value As String)
            strNgoRong = value
        End Set
    End Property
    Public Property CachDuongChinh() As String
        Get
            Return strCachDuongChinh
        End Get
        Set(ByVal value As String)
            strCachDuongChinh = value
        End Set
    End Property



    Public Property MaDonViHanhChinh() As String
        Get
            Return strMaDonViHanhChinh
        End Get
        Set(ByVal value As String)
            strMaDonViHanhChinh = value
        End Set
    End Property
    'Khai báo thuộc tính nhận chuỗi kết nối cơ sở dữ liệu
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property
    'Khai bao thuoc tinh ung voi bien
    Public ReadOnly Property Err() As String
        Get
            Return strError
        End Get
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property MaThuaDatCapGCN() As String
        Get
            Return strMaThuaDatCapGCN
        End Get
        Set(ByVal value As String)
            strMaThuaDatCapGCN = value
        End Set
    End Property

    'Khai bao thuoc tinh ung voi bien 
    Public Property MaHoSoCapGCN() As String
        Get
            Return strMaHoSoCapGCN
        End Get
        Set(ByVal value As String)
            strMaHoSoCapGCN = value
        End Set
    End Property

    Public Property ToBanDo() As String
        Get
            Return strToBanDo
        End Get
        Set(ByVal value As String)
            strToBanDo = value
        End Set
    End Property

    Public Property SoThua() As String
        Get
            Return strSoThua
        End Get
        Set(ByVal value As String)
            strSoThua = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property DienTich() As String
        Get
            Return strDienTich
        End Get
        Set(ByVal value As String)
            strDienTich = value
        End Set
    End Property

    Public Property DienTichBangChu() As String
        Get
            Return strDienTichBangChu
        End Get
        Set(ByVal value As String)
            strDienTichBangChu = value
        End Set
    End Property

    Public Property DienTichRieng() As String
        Get
            Return strDienTichRieng
        End Get
        Set(ByVal value As String)
            strDienTichRieng = value
        End Set
    End Property

    Public Property DienTichChung() As String
        Get
            Return strDienTichChung
        End Get
        Set(ByVal value As String)
            strDienTichChung = value
        End Set
    End Property

    Public Property MucDichSuDung() As String
        Get
            Return strMucDichSuDung
        End Get
        Set(ByVal value As String)
            strMucDichSuDung = value
        End Set
    End Property

    Public Property ThoiHanSuDung() As String
        Get
            Return strThoiHanSuDung
        End Get
        Set(ByVal value As String)
            strThoiHanSuDung = value
        End Set
    End Property

    Public Property NguonGocSuDung() As String
        Get
            Return strNguonGocSuDung
        End Get
        Set(ByVal value As String)
            strNguonGocSuDung = value
        End Set
    End Property

    Public Property DienTichKhongCap() As String
        Get
            Return strDienTichKhongCap
        End Get
        Set(ByVal value As String)
            strDienTichKhongCap = value
        End Set
    End Property

    Public Property DienTichKhongCapBangChu() As String
        Get
            Return strDienTichKhongCapBangChu
        End Get
        Set(ByVal value As String)
            strDienTichKhongCapBangChu = value
        End Set
    End Property

    Public Property LyDoKhongCap() As String
        Get
            Return strLyDoKhongCap
        End Get
        Set(ByVal value As String)
            strLyDoKhongCap = value
        End Set
    End Property

    Public Property GhiChu() As String
        Get
            Return strGhiChu
        End Get
        Set(ByVal value As String)
            strGhiChu = value
        End Set
    End Property

#Region "Cập nhật thông tin thửa kê khai"
    Public Function DeleteThuaDatCapGCNByMaThuaDatCapGCN(ByRef strResults As String) As String
        Return Me.Execute("spDeleteThuaDatCapGCNByMaThuaDatCapGCN", strResults)
    End Function

    Public Function InsertThuaDatCapGCNByMaThuaDatCapGCN(ByRef strResults As String) As String
        Return Me.Execute("spInsertThuaDatCapGCNByMaThuaDatCapGCN", strResults)
    End Function

    Public Function UpdateThuaDatCapGCNByMaThuaDatCapGCN(ByRef strResults As String) As String
        Return Me.Execute("spUpdateThuaDatCapGCNByMaThuaDatCapGCN", strResults)
    End Function

#End Region


    ''' <summary>
    ''' Hàm thực thi phát biểu SQL
    ''' </summary>
    ''' <param name="strStoreProcedureName">Tên  Thủ tục trong SQL Server</param>
    ''' <param name="strResults"></param>
    ''' <returns>Kết quả trả về là biến lỗi</returns>
    ''' <remarks></remarks>
    Private Function Execute(ByVal strStoreProcedureName As String, ByRef strResults As String) As String
        Try
            'Khoi tao doi tuong clsSqlDatabase
            Dim Database As New clsDatabase
            'Neu ket noi co so du lieu thanh cong
            Database.Connection = strConnection
            If Database.OpenConnection = True Then
                'Khai bao mang gia tri
                Dim Values() As String = _
                {strMaThuaDatCapGCN, strMaHoSoCapGCN, strToBanDo _
                , strSoThua, strDiaChi, strDienTich, strDienTichBangChu _
                , strDienTichRieng, strDienTichChung, strMucDichSuDung _
                , strThoiHanSuDung, strNguonGocSuDung, strDienTichKhongCap _
                , strDienTichKhongCapBangChu, strLyDoKhongCap, GhiChu, strLoaiDuong, strViTri, strNgoRong, strCachDuongChinh, strLPTB, strTTNCN, strNoiDungHoSo, strDT100GiaDat, strDT50GiaDat, strDT40GiaDat, strDT20GiaDat, strMaDonViHanhChinh, strMaThuaDat}
                'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
                If (Paras.Length <> Values.Length) Then
                    Return "Mảng giá trị chuyền vào chưa phù hợp!"
                End If
                'Goi phuong thuc ExecuteSP cua doi tuong clsSQLDatabase
                Database.ExecuteSP(strStoreProcedureName, Paras, Values, strResults)
                strError = Database.Err
                Database.CloseConnection()
            End If
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strError
    End Function

    Public Function GetData(ByRef records As DataTable) As String
        Try
            'Khoi tao doi tuong DMC.clsDatabase
            Dim Database As New clsDatabase
            Database.Connection = strConnection
            If Database.OpenConnection = True Then
                'Neu ket noi co so du lieu thanh cong
                'Khai bao mang gia tri
                Dim Values() As String = _
                {strMaThuaDatCapGCN, strMaHoSoCapGCN, strToBanDo _
                , strSoThua, strDiaChi, strDienTich, strDienTichBangChu _
                , strDienTichRieng, strDienTichChung, strMucDichSuDung _
                , strThoiHanSuDung, strNguonGocSuDung, strDienTichKhongCap _
                , strDienTichKhongCapBangChu, strLyDoKhongCap, strGhiChu, strLoaiDuong, strViTri, strNgoRong, strCachDuongChinh, strLPTB, strTTNCN, strNoiDungHoSo, strDT100GiaDat, strDT50GiaDat, strDT40GiaDat, strDT20GiaDat, strMaDonViHanhChinh, strMaThuaDat}
                'Chắc chắn rằng mảng giá trị truyền vào tương đương với mảng tham biến
                If (Paras.Length <> Values.Length) Then
                    Return "Mảng giá trị chuyền vào chưa phù hợp!"
                End If
                Database.getValue(records, "spSelectThuaDatCapGCNByMaHoSoCapGCN", Paras, Values)
                Database.CloseConnection()
                strError = ""
            End If
        Catch ex As Exception
            strError = ex.Message
        End Try
        Return strError
    End Function

End Class
        