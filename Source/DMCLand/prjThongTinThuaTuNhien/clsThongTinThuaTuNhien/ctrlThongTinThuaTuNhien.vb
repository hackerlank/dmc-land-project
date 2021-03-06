Imports System.Drawing
Imports System.Windows.Forms

Public Class ctrlThongTinThuaTuNhien
    Private dtThongTinThuaTuNhien As New DataTable
    Private dtThongTinThuaLichSu As New DataTable
    Private strMaThuaDatLichSu As String = ""
    'Khai báo biến Tờ bản đồ
    Private strToBanDo As String = ""
    'Khai báo biến Số thửa 
    Private strSoThua As String = ""
    'Khai báo biến Diện tích
    Private strDienTich As String = ""
    'Public RaiseEvent ShowData2(0, strMaThuaDat)
    'Khai báo biến nhận chuỗi kết nối Database
    Private strConnection As String = ""
    'Khai báo biến nhận Mã Hồ sơ cấp GCN hiện thời
    'Biến này vụng cho việc cập nhật thông tin Lịch sử thửa đất
    'Vào hồ sơ cấp GCN hiện thời
    Private strMaHoSoCapGCNHienThoi As String = ""
    'Khai báo biến kiểm tra lỗi
    Private strError As String = ""
    'Khai báo sự kiện thoát khỏi Form chứa UserControl này
    Public Event Close()
    Public Event ChonHoSo()
    'Khai báo thuộc tính chỉ đọc Tờ bản đồ
    Private strMaHS As String = ""

    Private strMaHoSoCapGCNLichSu As String
    Public Property MaHoSoCapGCNLichSu() As String
        Get
            Return strMaHoSoCapGCNLichSu
        End Get
        Set(ByVal value As String)
            strMaHoSoCapGCNLichSu = value
        End Set
    End Property
    Public ReadOnly Property ToBanDo() As String
        Get
            Return strToBanDo
        End Get
    End Property
    Public Property MaHSChon() As String
        Get
            Return strMaHS
        End Get
        Set(ByVal value As String)
            strMaHS = value
        End Set
    End Property
    'Khai báo thuôc tính chỉ đọc Số thửa
    Public ReadOnly Property SoThua() As String
        Get
            Return strSoThua
        End Get
    End Property
    'Khai báo thuộc tính chỉ đọc Diện tích
    Public ReadOnly Property DienTich() As String
        Get
            Return strDienTich
        End Get
    End Property
    'Khai báo thuộc tính nhận (chỉ ghi) Mã hồ sơ cấp GCN thửa đất hiện thời
    Public WriteOnly Property MaHoSoCapGCNHienThoi() As String
        Set(ByVal value As String)
            strMaHoSoCapGCNHienThoi = value
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
    Public Event showdata2()
    'Khai báo thuộc tính nhận chuỗi kết nối Database
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property

    Private Sub HideAllColumns(ByRef grdvw As DataGridView)
        'Ẩn tất cả các cột trên Grid
        With grdvw
            For i As Integer = 0 To (.Columns.Count - 1)
                .Columns(i).Visible = False
            Next
            .RowHeadersVisible = False
        End With
    End Sub

    'Add các cột cần thiết cho Grid Lịch sử thửa đất
    Public Sub FormatGridContruction()
        Try
            With Me.grdvwLichSuThuaDat
                'Ẩn tất cả các cột trên Grid
                Me.HideAllColumns(grdvwLichSuThuaDat)
                'Thiết đặt các giá trị cần thiết cho cột
                'Tờ bản đồ
                With .Columns("ToBanDo")
                    .HeaderText = "Tờ bản đồ"
                    .Width = 100
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Số thửa
                With .Columns("SoThua")
                    .HeaderText = "Số thửa"
                    .Width = 120
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Không cho phép lựa chọn nhiều bản ghi trong cùng lúc
                .MultiSelect = False
                .ReadOnly = True
                'Khong cho phep them
                .AllowUserToAddRows = False
                'Khong cho phep xoa
                .AllowUserToDeleteRows = False
                'Khong lua chon bat ky dong nao luc ban dau
                .ClearSelection()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hiển thị thông tin lịch sử thửa đất" + vbNewLine + strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub


    Public Sub ShowData(ByVal MaThuaDat As String)
        'Khai bao va khoi tao doi tuong
        Dim ThongTinThuaTuNhien As New clsThongTinThuaTuNhien
        Dim ThongTinThuaLichSu As New clsThongTinThuaDatLichSu
        Dim strXML As String = ""
        'Gan gia tri cho cac thuoc tinh doi voi truong hop truy van
        With ThongTinThuaTuNhien
            'Nhận chuỗi kết nối Database
            .Connection = strConnection
            .MaThuaDat = MaThuaDat
            .MaDonViHanhChinh = strMaDonViHanhChinh
        End With
        'Khoi tao trang thai ban dau
        Me.TrangThaiBanDau()
        Try
            'Goi phuong thuc GetData de khoi tao doi tuong cls
            If ThongTinThuaTuNhien.SelectThongTinTuNhien(dtThongTinThuaTuNhien) = "" Then
                ' Trinh bay du lieu len grdvwTaiSan
                If dtThongTinThuaTuNhien.Rows.Count > 0 Then
                    With dtThongTinThuaTuNhien.Rows(0)
                        'Diện tích
                        If IsNumeric(.Item("DienTichTuNhien").ToString) Then
                            strDienTich = .Item("DienTichTuNhien").ToString
                        Else
                            strDienTich = ""
                        End If
                        Me.numDienTichTuNhien.Text = strDienTich
                        'Số thửa
                        strSoThua = .Item("SoThua").ToString
                        Me.txtSoThua.Text = strSoThua
                        'Tờ bản đồ
                        strToBanDo = .Item("ToBanDo").ToString
                        Me.txtToBanDo.Text = strToBanDo
                        'Danh sách thửa đất Cha
                        If .Item("DanhSachMaThuaDatCha").ToString.Trim <> "" Then
                            strXML = .Item("DanhSachMaThuaDatCha").ToString.Trim
                        End If
                        'Hiển thị thông tin Lịch sử thửa đất
                        With ThongTinThuaLichSu
                            If strXML <> "" Then
                                'Kiểm tra xem chuỗi có cấu trúc XML hay không?
                                '-------------Xem lại chỗ này----------------
                                If InStr(1, strXML, "<root><ThuaDat>") = 0 Then
                                    GoTo out
                                End If
                                'Nhận chuỗi kết nối Database
                                .Connection = strConnection
                                .XML = strXML
                                .MaDonViHanhChinh = strMaDonViHanhChinh
                                .MaHoSoCapGCNLichSu = strMaHoSoCapGCNLichSu
                                If ThongTinThuaLichSu.SelectThongTinLichSu(dtThongTinThuaLichSu) = "" Then
                                    ' Trinh bay du lieu len grdvwMucDich
                                    grdvwLichSuThuaDat.DataSource = dtThongTinThuaLichSu
                                    If dtThongTinThuaLichSu.Rows.Count > 0 Then
                                        'Định dạng lại các cột trên Grid
                                        Me.FormatGridContruction()
                                    Else
                                        'Ẩn tất cả các cột
                                        Me.HideAllColumns(grdvwLichSuThuaDat)
                                    End If
                                End If
                            Else
                                'Ẩn tất cả các cột
                                Me.HideAllColumns(grdvwLichSuThuaDat)
                            End If
                        End With
out:
                        'lay thong tin ve chu su dung 
                        Dim dt As New DataTable
                        ThongTinThuaTuNhien.ToBanDo = strToBanDo.Trim
                        ThongTinThuaTuNhien.SoThua = strSoThua.Trim
                        ThongTinThuaTuNhien.SelectMaHoSoCapGCN(dt)
                        cboChonChu.Items.Clear()
                        If dt.Rows.Count > 0 And dt.Rows.Count < 2 Then
                            LabThongTinChu.Text = "Thửa đất 1 chủ sử dụng"
                            LabChonChu.Visible = False
                            cboChonChu.Visible = False
                            cmdChon.Visible = False
                        End If
                        If dt.Rows.Count > 1 Then
                            LabThongTinChu.Text = "Thửa đất nhiều chủ sử dụng"
                            LabChonChu.Visible = True
                            cboChonChu.Visible = True
                            cmdChon.Visible = True
                        End If
                        If (strToBanDo <> "" And strSoThua <> "" And dt.Rows.Count = 0) Then
                            LabThongTinChu.Text = "Thửa đất chưa có hồ sơ"
                            LabChonChu.Visible = False
                            cmdChon.Visible = False
                        End If
                        If (strToBanDo = "" And strSoThua = "") Then
                            LabThongTinChu.Text = "..."
                            LabChonChu.Visible = False
                            cmdChon.Visible = False
                        End If
                        If dt.Rows.Count > 0 Then

                            For i As Integer = 0 To dt.Rows.Count - 1
                                Dim str As String = ""
                                str = dt.Rows(i).Item("MaHoSoCapGCN")
                                If ThongTinChu(dt.Rows(i).Item(0).ToString) <> "" Then
                                    str = str & " - " & ThongTinChu(dt.Rows(i).Item(0).ToString) & " - " & dt.Rows(i).Item("DienTich") & "m2 - " & dt.Rows(i).Item("diachi")
                                Else
                                    str = str & " - " & dt.Rows(i).Item("DienTich") & "m2 - " & dt.Rows(i).Item("diachi")
                                End If
                                cboChonChu.Items.Add(str)
                            Next
                            cboChonChu.Text = cboChonChu.Items(0).ToString
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Thông tin thửa tự nhiên " & vbNewLine & " Hiển thị dữ liệu " & vbNewLine _
                & " Lỗi: " & ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    Public Function ThongTinChu(ByVal MaHoSoCapGCN As String) As String
        Dim str As String = ""
        Dim cls As New clsThongTinThuaTuNhien
        cls.Connection = strConnection
        cls.HoSoCapGCN = MaHoSoCapGCN
        Dim dt As New DataTable
        cls.SelectThongTinHoSo(dt)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If i = 0 Then
                    If Not IsDBNull(dt.Rows(i).Item("GioiTinh")) Then
                        If dt.Rows(i).Item("GioiTinh") = "False" Then
                            str = str & "Bà " & dt.Rows(i).Item("HoTen")
                        Else
                            str = str & "Ông " & dt.Rows(i).Item("HoTen")
                        End If
                    Else
                        str = str & dt.Rows(i).Item("HoTen")
                    End If

                Else
                    If Not IsDBNull(dt.Rows(i).Item("GioiTinh")) Then
                        If dt.Rows(i).Item("GioiTinh") = "False" Then
                            str = str & " và bà " & dt.Rows(i).Item("HoTen")
                        Else
                            str = str & " và ông " & dt.Rows(i).Item("HoTen")
                        End If
                    Else
                        str = str & "," & dt.Rows(i).Item("HoTen")
                    End If
                End If

            Next
            str = str & dt.Rows(0).Item("DiaChi")
        End If
        Return str
    End Function
    Public Sub showdT()
        RaiseEvent showdata2()
    End Sub

    Public Sub TrangThaiBanDau()
        'Lam sach du lieu tren DataTable
        dtThongTinThuaTuNhien.Clear()
        dtThongTinThuaLichSu.Clear()
        'Lam sach du lieu tren Form 
        With Me
            .numDienTichTuNhien.Text = ""
            .txtSoThua.Text = ""
            .txtToBanDo.Text = ""
        End With
    End Sub
    Public Sub TrangThaiCapNhat(Optional ByVal blnCapNhat As Boolean = False)
        With Me
            .txtSoThua.ReadOnly = Not blnCapNhat
            .txtToBanDo.ReadOnly = Not blnCapNhat
            .numDienTichTuNhien.ReadOnly = Not blnCapNhat
            .numDienTichTuNhien.Enabled = blnCapNhat
            If blnCapNhat Then
                .txtSoThua.BackColor = Color.White
                .txtToBanDo.BackColor = Color.White
                .numDienTichTuNhien.BackColor = Color.White
            Else
                .txtSoThua.BackColor = Color.LightYellow
                .txtToBanDo.BackColor = Color.LightYellow
                .numDienTichTuNhien.BackColor = Color.LightYellow
            End If
        End With
    End Sub
    Private Sub ctrlThongTinThuaTuNhien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me
            'Khoi tao trang thai ban dau
            .TrangThaiBanDau()
            'Trang thai cap nhat
            .TrangThaiCapNhat()
        End With
    End Sub

    Private Sub grdvwLichSuThuaDat_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdvwLichSuThuaDat.CellMouseClick
        'Chắc chắn rằng chuột phải được click
        If (e.Button = Windows.Forms.MouseButtons.Left) And (e.RowIndex >= 0) Then
            Me.grdvwLichSuThuaDat.ClearSelection()
            Exit Sub
        End If
        'Chắc chắn rằng một bản ghi được lựa chọn 
        If (e.Button = Windows.Forms.MouseButtons.Right) And (e.RowIndex >= 0) Then
            Try
                With grdvwLichSuThuaDat
                    '.ClearSelection()
                    .Rows(e.RowIndex).Selected = True
                End With
                With dtThongTinThuaLichSu.Rows(e.RowIndex)
                    'Gan gia tri vao bien dung chung
                    strMaThuaDatLichSu = ""
                    strMaThuaDatLichSu = .Item("MaThua").ToString
                End With
                'Hiển thị ContextMenuStrip
                Me.contextCapNhatThongTinLichSu.Show(grdvwLichSuThuaDat, e.Location)
            Catch ex As Exception
                strError = ex.Message
                MsgBox("Lựa chọn Thửa đất lịch sử " & vbNewLine & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
            End Try
        End If
    End Sub

    Private Sub contextChuSuDung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextChuSuDung.Click
        'Thông tin Lịch sử CHỦ SỬ DỤNG ĐẤT 
        Dim frmLichSuChuSuDung As New frmLichSuChuSuDung
        With frmLichSuChuSuDung
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub contextMucDich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextMucDich.Click
        'Thông tin Lịch sử MỤC ĐÍCH SỬ DỤNG ĐẤT 
        Dim frmLichSuMucDichSuDung As New frmLichSuMucDichSuDung
        With frmLichSuMucDichSuDung
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub contextNguonGoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextNguonGoc.Click
        'Thông tin Lịch sử NGUỒN GỐC SỬ DỤNG ĐẤT 
        Dim frmLichSuNguonGoc As New frmLichSuNguonGocSuDung
        With frmLichSuNguonGoc
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub contextKiemKe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextKiemKe.Click
        'Thông tin Lịch sử KIỂM KÊ SỬ DỤNG ĐẤT 
        Dim frmLichSuKiemKe As New frmLichSuKiemKe
        With frmLichSuKiemKe
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub contextQuiHoach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextQuiHoach.Click
        'Thông tin Lịch sử QUI HOẠCH SỬ DỤNG ĐẤT 
        Dim frmLichSuQuiHoach As New frmLichSuQuiHoach
        With frmLichSuQuiHoach
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub contextTaiLieuKemTheo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextTaiLieuKemTheo.Click
        'Thông tin Lịch sử TÀI LIỆU KÈM THEO
        Dim frmLichSuTaiLieuKemTheo As New frmLichSuTaiLieuKemTheo
        With frmLichSuTaiLieuKemTheo
            'Truyền chuỗi kết nối cơ sở dữ liệu
            .Connection = strConnection
            'Truyền Mã hồ sơ cấp GCN hiện thời
            .MaHoSoCapGCNHienThoi = strMaHoSoCapGCNHienThoi
            'Truyền Mã thửa đất lich sử
            .MaThuaDatLichSu = strMaThuaDatLichSu
            .MaDonViHanhChinh = strMaDonViHanhChinh
            'Hiển thị Thông tin Lịch sử Chủ sử dụng lên Form
            .ShowData()
            'Hiển thị Form giữa màn hình
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog(Me)
        End With
    End Sub
    Public Function PTChuoi(ByVal str As String, ByVal kt As Char) As String
        Dim n As Integer
        Dim st() As Char = str.ToCharArray
        Dim k As Integer = 0
        For n = 0 To st.Length - 1
            If st(n) = kt Then
                k = k + 1
            End If
        Next
        Dim m() As Char = str.Split(kt)(0)
        Dim t As String = CType(m, String)
        Return t
    End Function

    Private Sub cmdChon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChon.Click
        strMaHS = PTChuoi(cboChonChu.Text, "-")
        RaiseEvent ChonHoSo()
    End Sub
End Class
