Imports System.Drawing
Imports System.Windows.Forms
Public Class ctrlThongTinThuaKeKhai
    'Khai báo biến Mã Hồ sơ cấp GCN
    Private strMaHoSoCapGCN As String = ""
    Private dtThuaDat As New DataTable
    Private blnNonNumberEntered As Boolean
    Private strConnection As String ' Khai báo biến nhận chuỗi kết nối cơ sở dữ liệu
    Private strError As String = ""    'Khai báo biến kiểm tra kết nối
    Private strMaThuaDatCapGCN As String = ""
    Private shortAction As Short = 0     'Khai báo biến trạng thái cập nhật
    Private strTenPhuong As String = ""
    Private strMaDonViHanhChinh As String = ""
    Private strThongTinCu As String
    Private strMaThuaDat As String = ""
    Public Property MaThuaDat() As String
        Get
            Return strMaThuaDat
        End Get
        Set(ByVal value As String)
            strMaThuaDat = value
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
    Public Property TenPhuong() As String
        Get
            Return strTenPhuong
        End Get
        Set(ByVal value As String)
            strTenPhuong = value
        End Set
    End Property
    'Khai báo thuộc tính nhận chuỗi kết nối cơ sở dữ liệu
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property
    Private MaLoaiBienDong As String = ""
    Public Property MaKhoa() As String
        Get
            Return MaLoaiBienDong
        End Get
        Set(ByVal value As String)
            MaLoaiBienDong = value
        End Set
    End Property
    'Khai báo thuộc tính Mã hồ sơ cấp GCN
    Public WriteOnly Property MaHoSoCapGCN() As String
        Set(ByVal value As String)
            strMaHoSoCapGCN = value
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
    Public Sub NhatKyNguoiDung(ByVal ChucNang As String, ByVal MoTa As String)
        Dim clsNhatky As New prjNhatKyNguoiDung.clsNhatKyNguoiDung
        clsNhatky.Connection = strConnection
        clsNhatky.MaHoSoCapGCN = strMaHoSoCapGCN
        clsNhatky.MaThuaDat = strMaThuaDatCapGCN
        clsNhatky.MaDonViHanhChinh = strMaDonViHanhChinh
        clsNhatky.NghiepVu = "Cập nhật thông tin thửa kê khai"
        clsNhatky.ChucNang = ChucNang
        clsNhatky.MoTa = MoTa
        clsNhatky.DuongDanFile = Application.StartupPath
        clsNhatky.LuuNhatKyNguoiDung()
    End Sub
    'Add các cột cần thiết cho Grid
    Public Sub FormatGridContruction()
        Try
            With Me.grdvw
                'Ẩn tất cả các cột trên Grid
                Me.HideAllColumns(grdvw)
                'Thiết đặt các giá trị cần thiết cho cột
                With .Columns("ToBanDo")
                    .HeaderText = "Tờ bản đồ"
                    .Width = 150
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("SoThua")
                    .HeaderText = "Số thửa"
                    .Width = 120
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DiaChi")
                    .HeaderText = "Địa chỉ"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DienTich")
                    .HeaderText = "Diện tích"
                    .Width = 150
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DienTichBangChu")
                    .HeaderText = "Diện tích bằng chữ"
                    .Width = 150
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DienTichRieng")
                    .HeaderText = "Diện tích Riêng"
                    .Width = 150
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DienTichChung")
                    .HeaderText = "Diện tích Chung"
                    .Width = 150
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("MucDichSuDung")
                    .HeaderText = "Mục đích sử dụng"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("ThoiHanSuDung")
                    .HeaderText = "Thời hạn sử dụng"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("NguonGocSuDung")
                    .HeaderText = "Nguồn gốc sử dụng"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                'Phần diện tích không cấp
                With .Columns("DienTichKhongCap")
                    .HeaderText = "Diện tích không cấp"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("DienTichKhongCapBangChu")
                    .HeaderText = "Diện tích không cấp bằng chữ"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With

                With .Columns("LyDoKhongCap")
                    .HeaderText = "Lý do không cấp"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                With .Columns("GhiChu")
                    .HeaderText = "Ghi chú"
                    .Width = 200
                    .Visible = True
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Không cho phép thêm
                .AllowUserToAddRows = False
                'Không cho phép xóa
                .AllowUserToDeleteRows = False
                'Không cho lựa chọn bất kỳ bản ghi nào lúc ban đầu
                .ClearSelection()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Thông tin thửa đất" + vbNewLine + " Lỗi: " & vbNewLine & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        'Bo lua chon tren Grid
        Me.grdvw.ClearSelection()
        strMaThuaDatCapGCN = ""
        shortAction = 1
        With Me
            'Thiet lap trang thai ban dau
            .TrangThaiBanDau()
            'Trang thai cap nhat
            .TrangThaiCapNhat(True)
            'Trang thai chuc nang 
            .TrangThaiChucNang(True)
        End With
        'Thiết lập giá trị mặc định lúc thêm mới
        Me.txtThoiHanSuDung.Text = "Lâu dài"
        'Ẩn nút Mục đích và nguồn gốc sử dụng chi tiết
        'Chỉ khi nào tồn tại thửa đất thì mới hiển thị
        'để cập nhật Mục đích và nguồn gốc chi tiết
        Me.btnMucDichChiTiet.Enabled = False
        Me.btnNguonGocChiTiet.Enabled = False
    End Sub
    Public Sub ShowData()
        'Khai bao va khoi tao doi tuong
        Dim ThuaDat As New clsThongTinThuaKeKhai
        'Gan gia tri cho cac thuoc tinh doi voi truong hop truy van
        Try
            With ThuaDat
                .Connection = strConnection 'Gán chuỗi kết nối cơ sở dữ liệu
                .MaHoSoCapGCN = strMaHoSoCapGCN

            End With
            dtThuaDat.Clear()
            With Me.grdvw
                .ClearSelection()
                'Goi phuong thuc GetData de khoi tao doi tuong cls
                If ThuaDat.GetData(dtThuaDat) = "" Then
                    ' Trinh bay du lieu len grdvwMucDich
                    .DataSource = dtThuaDat
                    If dtThuaDat.Rows.Count > 0 Then
                        'Định dạng lại các cột trên Grid
                        Me.FormatGridContruction()
                    Else
                        'Ẩn tất cả các cột
                        Me.HideAllColumns(grdvw)
                    End If
                End If
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hiển thị dữ liệu: " & vbNewLine & " Thông tin thửa đất " _
                   & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
        'Trạng thái ban đầu
        Me.TrangThaiBanDau()
        'Trạng thái chức năng
        Me.TrangThaiChucNang()
        'Trạng thái cập nhật
        Me.TrangThaiCapNhat()
    End Sub
    Public Sub UpdateData()
        'Khai báo và khởi tạo đối tượng
        Dim ThuaDat As New clsThongTinThuaKeKhai
        Try
            'Xác nhận bản ghi cần xóa
            With ThuaDat
                .Connection = strConnection 'Gán chuỗi kết nối cơ sở dữ liệu
                .MaHoSoCapGCN = strMaHoSoCapGCN
                .MaThuaDatCapGCN = strMaThuaDatCapGCN
                'Tờ bản đồ
                .ToBanDo = txtToBanDo.Text.Trim
                'Số thửa
                .SoThua = txtSoThua.Text.Trim
                'Địa chỉ
                .DiaChi = txtDiaChi.Text.Trim
                If IsNumeric(numDienTich.Text.Trim) Then
                    .DienTich = numDienTich.Text.Trim
                Else
                    .DienTich = Nothing
                End If
                .DienTichBangChu = txtDienTichBangChu.Text.Trim
                If IsNumeric(numDienTichRieng.Text.Trim) Then
                    .DienTichRieng = numDienTichRieng.Text.Trim
                Else
                    .DienTichRieng = Nothing
                End If
                If IsNumeric(numDienTichChung.Text.Trim) Then
                    .DienTichChung = numDienTichChung.Text.Trim
                Else
                    .DienTichChung = Nothing
                End If
                .MucDichSuDung = txtMucDichSuDung.Text.Trim
                .ThoiHanSuDung = txtThoiHanSuDung.Text.Trim
                .NguonGocSuDung = txtNguonGocSuDung.Text.Trim

                'Phần diện tích không cấp
                If IsNumeric(Me.numDienTichKhongCap.Text.Trim) Then
                    .DienTichKhongCap = Me.numDienTichKhongCap.Text.Trim
                Else
                    .DienTichKhongCap = Nothing
                End If
                .DienTichKhongCapBangChu = Me.txtDienTichKhongCapBangChu.Text.Trim
                .LyDoKhongCap = Me.txtLyDoKhongCap.Text.Trim
                .GhiChu = Me.txtGhiChu.Text.Trim
                .LoaiDuong = Me.txtLoaiDuong.Text.Trim
                .ViTri = Me.txtViTri.Text.Trim
                .NgoRong = txtNgoRong.Text.Trim
                .CachDuongChinh = txtCachDuongChinh.Text.Trim
                .LPTB = txtLPTB.Text.Trim
                .TTNCN = txtTTNCN.Text.Trim
                .NoiDungHoSo = txtNoiDungHoSo.Text

                .DT100GiaDat = txtDT100GiaDat.Text.Trim
                .DT50GiaDat = txtDT50GiaDat.Text.Trim
                .DT40GiaDat = txtDT40GiaDat.Text.Trim
                .DT20GiaDat = txtDT20GiaDat.Text
                .MaDonViHanhChinh = strMaDonViHanhChinh
                .MaThuaDat = strMaThuaDat
            End With
            Dim str As String = ""
            If shortAction = 1 Then
                ThuaDat.InsertThuaDatCapGCNByMaThuaDatCapGCN(str)
                NhatKyNguoiDung("Thêm", "thêm thửa đất mới " & str)
            ElseIf shortAction = 2 Then
                ThuaDat.UpdateThuaDatCapGCNByMaThuaDatCapGCN(str)
                NhatKyNguoiDung("Sửa", "Thay bằng (" & strThongTinCu & ")")
                'strThongTinCu = strThongTinCu & "  " & grdvw.Columns(i).Name & ":" & grdvw.CurrentRow.Cells(i).Value.ToString
            ElseIf shortAction = 3 Then
                ThuaDat.DeleteThuaDatCapGCNByMaThuaDatCapGCN(str)
                NhatKyNguoiDung("Sửa", "xóa (" & strThongTinCu & ")")
            End If
            strError = ThuaDat.Err
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Cập nhật dữ liệu " & vbNewLine & " Thông tin thửa đất " _
                   & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
        TrangThaiBanDau()
        shortAction = 0
    End Sub

    Public Sub TrangThaiCapNhat(Optional ByVal blnCapNhat As Boolean = False)
        With Me
            .grdvw.BackgroundColor = Color.White
            'Diện tích kê khai
            With .numDienTich
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            'Diện tích Riêng
            With .numDienTichRieng
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            'Diện tích Chung
            With .numDienTichChung
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            'Mục đích sử dụng
            .txtMucDichSuDung.ReadOnly = Not blnCapNhat
            'Nguồn gốc sử dụng
            .txtNguonGocSuDung.ReadOnly = Not blnCapNhat
            'Tờ bản đồ
            .txtToBanDo.ReadOnly = Not blnCapNhat
            'Thời hạn
            .txtThoiHanSuDung.ReadOnly = Not blnCapNhat
            'Diện tích bằng chữ
            .txtDienTichBangChu.ReadOnly = Not blnCapNhat
            'Số thửa
            .txtSoThua.ReadOnly = Not blnCapNhat
            'Địa chỉ
            .txtDiaChi.ReadOnly = Not blnCapNhat
            'Chi tiết Mục đích sử dụng
            .btnMucDichChiTiet.Enabled = blnCapNhat
            'Chi tiết Nguồn gốc sử dụng
            .btnNguonGocChiTiet.Enabled = blnCapNhat
            'Diện tích bằng chữ 
            .btnDienTichBangChu.Enabled = blnCapNhat
            'Phần diện tích không cấp GCN
            .numDienTichKhongCap.Enabled = blnCapNhat
            .txtDienTichKhongCapBangChu.ReadOnly = Not blnCapNhat
            .txtLyDoKhongCap.ReadOnly = Not blnCapNhat
            .txtGhiChu.ReadOnly = Not blnCapNhat


            .txtLoaiDuong.ReadOnly = Not blnCapNhat
            .txtViTri.ReadOnly = Not blnCapNhat
            .txtNgoRong.ReadOnly = Not blnCapNhat
            .txtCachDuongChinh.ReadOnly = Not blnCapNhat
            .txtLPTB.ReadOnly = Not blnCapNhat
            .txtTTNCN.ReadOnly = Not blnCapNhat
            .txtNoiDungHoSo.ReadOnly = Not blnCapNhat

            .txtDT100GiaDat.ReadOnly = Not blnCapNhat
            .txtDT50GiaDat.ReadOnly = Not blnCapNhat
            .txtDT40GiaDat.ReadOnly = Not blnCapNhat
            .txtDT20GiaDat.ReadOnly = Not blnCapNhat
            If blnCapNhat Then
                'Phần diện tích cấp GCN
                .numDienTich.BackColor = Color.White
                .numDienTichRieng.BackColor = Color.White
                .numDienTichChung.BackColor = Color.White
                .txtDienTichBangChu.BackColor = Color.White
                .txtMucDichSuDung.BackColor = Color.White
                .txtNguonGocSuDung.BackColor = Color.White
                .txtThoiHanSuDung.BackColor = Color.White
                .txtToBanDo.BackColor = Color.White
                .txtDienTichBangChu.BackColor = Color.White
                .txtSoThua.BackColor = Color.White
                .txtDiaChi.BackColor = Color.White
                'Phần diện tích không cấp GCN
                .numDienTichKhongCap.BackColor = Color.White
                .txtDienTichKhongCapBangChu.BackColor = Color.White
                .txtLyDoKhongCap.BackColor = Color.White
                .txtGhiChu.BackColor = Color.White
                .txtLoaiDuong.BackColor = Color.White
                .txtViTri.BackColor = Color.White
                .txtNgoRong.BackColor = Color.White
                .txtCachDuongChinh.BackColor = Color.White
                .txtLPTB.BackColor = Color.White
                .txtTTNCN.BackColor = Color.White
                .txtNoiDungHoSo.BackColor = Color.White

                .txtDT100GiaDat.BackColor = Color.White
                .txtDT50GiaDat.BackColor = Color.White
                .txtDT40GiaDat.BackColor = Color.White
                .txtDT20GiaDat.BackColor = Color.White
            Else
                'Phần diện tích cấp GCN
                .numDienTich.BackColor = Color.LightYellow
                .numDienTichRieng.BackColor = Color.LightYellow
                .numDienTichChung.BackColor = Color.LightYellow
                .txtDienTichBangChu.BackColor = Color.LightYellow
                .txtMucDichSuDung.BackColor = Color.LightYellow
                .txtNguonGocSuDung.BackColor = Color.LightYellow
                .txtToBanDo.BackColor = Color.LightYellow
                .txtThoiHanSuDung.BackColor = Color.LightYellow
                .txtDienTichBangChu.BackColor = Color.LightYellow
                .txtSoThua.BackColor = Color.LightYellow
                .txtDiaChi.BackColor = Color.LightYellow
                'Phần diện tích không cấp GCN
                .numDienTichKhongCap.BackColor = Color.LightYellow
                .txtDienTichKhongCapBangChu.BackColor = Color.LightYellow
                .txtLyDoKhongCap.BackColor = Color.LightYellow
                .txtGhiChu.BackColor = Color.LightYellow
                .txtLoaiDuong.BackColor = Color.LightYellow
                .txtViTri.BackColor = Color.LightYellow
                .txtNgoRong.BackColor = Color.LightYellow
                .txtCachDuongChinh.BackColor = Color.LightYellow
                .txtLPTB.BackColor = Color.LightYellow
                .txtTTNCN.BackColor = Color.LightYellow
                .txtNoiDungHoSo.BackColor = Color.LightYellow

                .txtDT100GiaDat.BackColor = Color.LightYellow
                .txtDT50GiaDat.BackColor = Color.LightYellow
                .txtDT40GiaDat.BackColor = Color.LightYellow
                .txtDT20GiaDat.BackColor = Color.LightYellow
            End If
        End With
    End Sub

    Public Sub TrangThaiBanDau(Optional ByVal blnClearGrid As Boolean = False)
        With Me
            If (blnClearGrid) Then
                .HideAllColumns(grdvw)
            End If
            'Thiết lập trên Form nhập liệu
            .numDienTich.Text = ""
            .numDienTichRieng.Text = ""
            .numDienTichChung.Text = ""
            .txtMucDichSuDung.Text = ""
            .txtNguonGocSuDung.Text = ""
            '.txtToBanDo.Text = ""
            .txtThoiHanSuDung.Text = ""
            .txtDienTichBangChu.Text = ""
            '  .txtSoThua.Text = ""
            .txtDiaChi.Text = strTenPhuong
            'Phần diện tích không cấp GCN
            .numDienTichKhongCap.Text = ""
            .txtDienTichKhongCapBangChu.Text = ""
            .txtLyDoKhongCap.Text = ""
            .txtGhiChu.Text = ""
            .txtLoaiDuong.Text = ""
            .txtViTri.Text = ""
            .txtNgoRong.Text = ""
            .txtCachDuongChinh.Text = ""
            .txtLPTB.Text = ""
            .txtTTNCN.Text = ""
            .txtNoiDungHoSo.Text = ""

            .txtDT100GiaDat.Text = ""
            .txtDT50GiaDat.Text = ""
            .txtDT40GiaDat.Text = ""
            .txtDT20GiaDat.Text = ""
        End With
    End Sub

    Public Sub TrangThaiChucNang(Optional ByVal blnStartEdited As Boolean = False, Optional ByVal blnStartDeleted As Boolean = False)
        With Me
            If Me.MaLoaiBienDong <> "MG" Then
                Me.GroupBox3.Enabled = True
                .btnSua.Enabled = Not blnStartEdited
                .btnXoa.Enabled = Not blnStartEdited
                .btnThem.Enabled = Not blnStartEdited
                .btnMucDichChiTiet.Enabled = blnStartEdited
                .btnNguonGocChiTiet.Enabled = blnStartEdited
                .btnDienTichBangChu.Enabled = blnStartEdited
                .btnCapNhat.Enabled = blnStartEdited
                .btnHuyLenh.Enabled = blnStartEdited
                If blnStartDeleted Then
                    .btnCapNhat.Enabled = Not blnStartDeleted
                    .btnHuyLenh.Enabled = Not blnStartDeleted
                    .btnMucDichChiTiet.Enabled = Not blnStartDeleted
                    .btnNguonGocChiTiet.Enabled = Not blnStartDeleted
                    .btnDienTichBangChu.Enabled = Not blnStartDeleted
                End If
            Else
                Me.GroupBox3.Enabled = False
            End If
            
        End With
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If strMaThuaDatCapGCN <> "" Then
            shortAction = 2
            'Thiết lập trạng thái chức năng
            TrangThaiChucNang(True)
            'Thiết lập trạng thái cập nhật cho các điều khiển
            TrangThaiCapNhat(True)
            strThongTinCu = ""
            For i As Integer = 0 To grdvw.Columns.Count - 1
                strThongTinCu = strThongTinCu & "  " & grdvw.Columns(i).Name & ":" & grdvw.CurrentRow.Cells(i).Value.ToString
            Next

        Else
            MsgBox(" Bạn chưa chọn Thửa đất cần sửa!", MsgBoxStyle.Information, "DMCLand")
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        shortAction = 3
        'Neu ton tai ma can xoa
        If strMaThuaDatCapGCN <> "" Then
            If MsgBox("Bạn chắc chắn muốn xóa không?", MsgBoxStyle.YesNo, "DMCLand!") = MsgBoxResult.Yes Then
                Try
                    With Me
                        .UpdateData()
                        strMaThuaDatCapGCN = ""
                    End With
                Catch ex As Exception
                    strError = ex.Message
                End Try
                If (strError = "") Or (strError = "OK") Then
                    MsgBox(" Bạn đã cập nhật thành công!", MsgBoxStyle.Information, "DMCLand")
                Else
                    MsgBox(" Cập nhật chưa thành công!", MsgBoxStyle.Critical, "DMCLand")
                End If
            End If
        Else
            MsgBox(" Bạn chưa chọn Thửa đất cần xóa!", MsgBoxStyle.Information, "DMCLand")
        End If
        'Hiển thị dữ liệu
        Me.ShowData()
        strError = ""
    End Sub

    Private Sub btnCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        Try
            With Me
                'Cập nhật thông tin Thửa đất sử dụng
                .UpdateData()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Cập nhật dữ liệu " & vbNewLine & " Thửa đất sử dụng " & vbNewLine _
                & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
        If (strError = "") Or (strError = "OK") Then
            MsgBox(" Bạn đã cập nhật thành công!", MsgBoxStyle.Information, "DMCLand")
        Else
            MsgBox(" Cập nhật chưa thành công!", MsgBoxStyle.Critical, "DMCLand")
        End If
        ShowData()
        'Khởi tạo giá trị cho biến dùng chung
        strMaThuaDatCapGCN = ""
        strError = ""
    End Sub

    Private Sub btnHuyLenh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyLenh.Click
        With Me
            'Hiển thị dữ liệu
            .ShowData()
            'Khởi tạo giá trị cho biến dùng chung
            strMaThuaDatCapGCN = ""
        End With
        shortAction = 0
    End Sub

    'Private Sub grdvw_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    'Try
    'With Me.grdvw.Columns(e.ColumnIndex)
    '    If .Name = "NgayBatDau" Then
    '        If e.Value IsNot Nothing Then
    '            e.Value = DateTime.Parse(e.Value).ToString("dd\/MM\/yyyy")
    '        End If
    '    End If
    '    If .Name = "NgayKetThuc" Then
    '        If e.Value IsNot Nothing Then
    '            e.Value = DateTime.Parse(e.Value).ToString("dd\/MM\/yyyy")
    '        End If
    '    End If
    'End With
    ' Catch ex As Exception
    '     strError = ex.Message
    '     MsgBox(" Định dạng ngày tháng " & vbNewLine & " Thông tin thửa đất " & vbNewLine _
    '& " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
    ' End Try
    'End Sub

    Private Sub ctrlThongTinThuaKeKhai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Me
                .TrangThaiBanDau()
                'Trang thai cap nhat
                .TrangThaiCapNhat()
                'Trang thai chuc nang
                .TrangThaiChucNang()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Nạp dữ liệu ban đầu " & vbNewLine & " Thông tin thửa đất " _
            & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Private Sub numDienTichRieng_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDienTichRieng.ValueChanged
        If (numDienTichRieng.Value > numDienTich.Value) Then
            System.Windows.Forms.MessageBox.Show("Diện tích Riêng phải nhỏ hơn hoặc bằng diện tích thửa đất", "DMCLand", MessageBoxButtons.OK)
            numDienTichRieng.Value = 0.0
            numDienTichRieng.Text = ""
            numDienTichRieng.Focus()
            Return
        End If
        Dim dblDienTichChung As Decimal
        Dim dblDienTichDat As New Decimal
        Dim dblDienTichRieng As New Decimal
        'If (numDienTichChung.Text <> "") Then
        '    If (numDienTichChung.Text = "0.0") Then
        '        dblDienTichChung = numDienTichKeKhai.Value - numDienTichRieng.Value
        '    Else
        '        Return
        '    End If
        'Else
        dblDienTichChung = numDienTich.Value - numDienTichRieng.Value
        'End If
        numDienTichChung.Text = dblDienTichChung
    End Sub

    Private Sub grdvw_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdvw.CellMouseClick
        'Không dùng chuột phải
        If e.Button.ToString = "Right" Then
            Exit Sub
        End If
        'Khai báo và khởi tạo lớp Thông tin thửa kê khai
        Dim ThuaDat As New clsThongTinThuaKeKhai
        If e.RowIndex >= 0 Then
            Try
                'Gán chuỗi kết nối cơ sở dữ liệu
                ThuaDat.Connection = strConnection
                With dtThuaDat.Rows(e.RowIndex)
                    ThuaDat.MaThuaDatCapGCN = .Item("MaThuaDatCapGCN").ToString
                    strMaThuaDatCapGCN = ThuaDat.MaThuaDatCapGCN
                    ThuaDat.MaHoSoCapGCN = .Item("MaHoSoCapGCN").ToString
                    ThuaDat.ToBanDo = .Item("ToBanDo").ToString
                    ThuaDat.SoThua = .Item("SoThua").ToString
                    ThuaDat.DiaChi = .Item("DiaChi").ToString
                    ThuaDat.DienTich = .Item("DienTich").ToString
                    ThuaDat.DienTichBangChu = .Item("DienTichBangChu").ToString
                    ThuaDat.DienTichRieng = .Item("DienTichRieng").ToString
                    ThuaDat.DienTichChung = .Item("DienTichChung").ToString
                    ThuaDat.MucDichSuDung = .Item("MucDichSuDung").ToString
                    ThuaDat.ThoiHanSuDung = .Item("ThoiHanSuDung").ToString
                    ThuaDat.NguonGocSuDung = .Item("NguonGocSuDung").ToString
                    'Phần diện tích không cấp GCN
                    ThuaDat.DienTichKhongCap = .Item("DienTichKhongCap").ToString
                    ThuaDat.DienTichKhongCapBangChu = .Item("DienTichKhongCapBangChu").ToString
                    ThuaDat.LyDoKhongCap = .Item("LyDoKhongCap").ToString
                    ThuaDat.GhiChu = .Item("GhiChu").ToString
                    ThuaDat.LoaiDuong = .Item("LoaiDuong").ToString
                    ThuaDat.ViTri = .Item("ViTri").ToString
                    ThuaDat.NgoRong = .Item("NgoRong").ToString
                    ThuaDat.CachDuongChinh = .Item("CachDuongChinh").ToString
                    ThuaDat.LPTB = .Item("LPTB").ToString
                    ThuaDat.TTNCN = .Item("TTNCN").ToString
                    ThuaDat.NoiDungHoSo = .Item("NoiDungHoSo").ToString

                    ThuaDat.DT100GiaDat = .Item("DT100GiaDat").ToString
                    ThuaDat.DT50GiaDat = .Item("DT50GiaDat").ToString
                    ThuaDat.DT40GiaDat = .Item("DT40GiaDat").ToString
                    ThuaDat.DT20GiaDat = .Item("DT20GiaDat").ToString
                End With
                'Hiển thị bản ghi được lựa chon lên Form
                With Me
                    .txtToBanDo.Text = ThuaDat.ToBanDo
                    .txtSoThua.Text = ThuaDat.SoThua
                    .txtDiaChi.Text = ThuaDat.DiaChi
                    If IsNumeric(ThuaDat.DienTich) Then
                        .numDienTich.Text = ThuaDat.DienTich
                    Else
                        .numDienTich.Text = ""
                    End If
                    .txtDienTichBangChu.Text = ThuaDat.DienTichBangChu
                    If IsNumeric(ThuaDat.DienTichRieng) Then
                        .numDienTichRieng.Text = ThuaDat.DienTichRieng
                    Else
                        .numDienTichRieng.Text = ""
                    End If
                    If IsNumeric(ThuaDat.DienTichChung) Then
                        .numDienTichChung.Text = ThuaDat.DienTichChung
                    Else
                        .numDienTichChung.Text = ""
                    End If
                    .txtMucDichSuDung.Text = ThuaDat.MucDichSuDung
                    .txtThoiHanSuDung.Text = ThuaDat.ThoiHanSuDung
                    .txtNguonGocSuDung.Text = ThuaDat.NguonGocSuDung
                    'Phần diện tích không cấp
                    If IsNumeric(ThuaDat.DienTichKhongCap) Then
                        .numDienTichKhongCap.Text = ThuaDat.DienTichKhongCap
                    Else
                        .numDienTichKhongCap.Text = ""
                    End If
                    .txtDienTichKhongCapBangChu.Text = ThuaDat.DienTichKhongCapBangChu
                    .txtLyDoKhongCap.Text = ThuaDat.LyDoKhongCap
                    .txtGhiChu.Text = ThuaDat.GhiChu

                    .txtLoaiDuong.Text = ThuaDat.LoaiDuong
                    .txtViTri.Text = ThuaDat.ViTri
                    .txtNgoRong.Text = ThuaDat.NgoRong
                    .txtCachDuongChinh.Text = ThuaDat.CachDuongChinh

                    .txtLPTB.Text = ThuaDat.LPTB
                    .txtTTNCN.Text = ThuaDat.TTNCN
                    .txtNoiDungHoSo.Text = ThuaDat.NoiDungHoSo


                    .txtDT100GiaDat.Text = ThuaDat.DT100GiaDat
                    .txtDT50GiaDat.Text = ThuaDat.DT50GiaDat
                    .txtDT40GiaDat.Text = ThuaDat.DT40GiaDat
                    .txtDT20GiaDat.Text = ThuaDat.DT20GiaDat
                End With
            Catch ex As Exception
                strError = ex.Message
                MsgBox(" Hiển thị Thông tin thửa đất lên Form " _
                       & vbNewLine & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
            End Try
        End If
    End Sub

    Private Sub btnMucDichChiTiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMucDichChiTiet.Click
        'Chắc chắn rằng có thửa đất được lựa chọn để
        'cập nhật thông tin Mục đích sử dụng chi tiết
        If strMaThuaDatCapGCN = "" Then
            System.Windows.Forms.MessageBox.Show("Bạn phải lựa chọn một thửa đất", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim MucDich As New frmMucDichSuDung
        With MucDich
            With .CtrlMucDich
                .Connection = strConnection
                .MaThuaDatCapGCN = strMaThuaDatCapGCN
                .MaDonViHanhChinh = strMaDonViHanhChinh
                .DienTichKeKhai = numDienTich.Value
                .MaHoSoCapGCN = strMaHoSoCapGCN
                .ShowData()
            End With
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            'Tổng hợp mục đích sử dụng
            If MucDich.CtrlMucDich.TrangThaiTongHop Then
                'If MucDich.CtrlMucDich.TongHopThongTinMucDich IsNot Nothing Then
                Me.txtMucDichSuDung.Text = MucDich.CtrlMucDich.TongHopThongTinMucDich
                Me.txtThoiHanSuDung.Text = MucDich.CtrlMucDich.TongHopThongTinThoiHanMucDich
                'End If
            End If
        End With
    End Sub

    Private Sub btnNguonGocChiTiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNguonGocChiTiet.Click
        'Chắc chắn rằng có một thửa được lựa chọn để 
        'cập nhật thông tin Nguồn gốc sử dụng đất
        If strMaThuaDatCapGCN = "" Then
            System.Windows.Forms.MessageBox.Show("Bạn phải lựa chọn một thửa đất", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim NguonGoc As New frmNguonGoc
        With NguonGoc
            With .CtrlNguonGoc
                .Connection = strConnection
                .MaThuaDatCapGCN = strMaThuaDatCapGCN
                .MaDonViHanhChinh = strMaDonViHanhChinh
                .MaHoSoCapGCN = strMaHoSoCapGCN
                .ShowData()
            End With
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            'Tổng hợp Nguồn gốc sử dụng
            If NguonGoc.CtrlNguonGoc.TrangThaiTongHop Then
                Me.txtNguonGocSuDung.Text = NguonGoc.CtrlNguonGoc.TongHopThongTin
            End If
        End With
    End Sub

    Private Sub numDienTichKhongCap_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDienTichKhongCap.ValueChanged
        Dim DoiSoThanhChu As New clsDoiSoThanhChu
        Dim strDienTich As String = ""
        strDienTich = numDienTichKhongCap.Value 'numDienTichKhongCap.Text.Trim
        If (strDienTich = "") Then
            txtDienTichKhongCapBangChu.Text = ""
            Exit Sub
        End If
        If IsNumeric(strDienTich) Then
            txtDienTichKhongCapBangChu.Text = clsDoiSoThanhChu.Number2Text(strDienTich) & " mét vuông"
        End If
    End Sub

    Private Sub btnDienTichBangChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDienTichBangChu.Click
        Dim DoiSoThanhChu As New clsDoiSoThanhChu
        Dim strDienTich As String = ""
        strDienTich = String.Format("{0:0.00}", numDienTich.Value)
        If (strDienTich = "") Then
            txtDienTichBangChu.Text = ""
            Exit Sub
        End If
        If IsNumeric(strDienTich) Then
            txtDienTichBangChu.Text = clsDoiSoThanhChu.Number2Text(strDienTich) & " mét vuông"
        End If
    End Sub

    Private Sub numDienTich_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDienTich.ValueChanged
        numDienTichChung.Value = numDienTich.Value
        numDienTichRieng.Text = "0.0"
    End Sub

    Private Sub numDienTichChung_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDienTichChung.ValueChanged
        If (numDienTichChung.Value > numDienTich.Value) Then
            System.Windows.Forms.MessageBox.Show("Diện tích Chung phải nhỏ hơn hoặc bằng diện tích thửa đất", "DMCLand", MessageBoxButtons.OK)
            numDienTichChung.Value = 0.0
            numDienTichChung.Text = ""
            numDienTichChung.Focus()
            Return
        End If
        Dim dblDienTichDat As New Decimal
        Dim dblDienTichRieng As New Decimal
        dblDienTichRieng = numDienTich.Value - numDienTichChung.Value
        numDienTichRieng.Text = dblDienTichRieng
    End Sub

    Private Sub txtSoThua_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSoThua.KeyDown
        If (e.KeyValue = 13) Then
            txtToBanDo.Focus()
        End If
    End Sub

    Private Sub txtToBanDo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToBanDo.KeyDown
        If (e.KeyValue = 13) Then
            txtDiaChi.Focus()
        End If
    End Sub

    Private Sub txtDiaChi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiaChi.KeyDown
        If (e.KeyValue = 13) Then
            numDienTich.Focus()
        End If
    End Sub

    Private Sub numDienTich_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDienTich.KeyDown
        If (e.KeyValue = 13) Then
            txtDienTichBangChu.Focus()
        End If
    End Sub

    Private Sub txtDienTichBangChu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDienTichBangChu.KeyDown
        If (e.KeyValue = 13) Then
            numDienTichRieng.Focus()
        End If
    End Sub

    Private Sub numDienTichRieng_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDienTichRieng.KeyDown
        If (e.KeyValue = 13) Then
            numDienTichChung.Focus()
        End If
    End Sub

    Private Sub numDienTichChung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDienTichChung.KeyDown
        If (e.KeyValue = 13) Then
            txtThoiHanSuDung.Focus()
        End If
    End Sub

    Private Sub txtThoiHanSuDung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtThoiHanSuDung.KeyDown
        If (e.KeyValue = 13) Then
            txtMucDichSuDung.Focus()
        End If
    End Sub

    Private Sub txtMucDichSuDung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMucDichSuDung.KeyDown
        If (e.KeyValue = 13) Then
            txtNguonGocSuDung.Focus()
        End If
    End Sub

    Private Sub txtNguonGocSuDung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNguonGocSuDung.KeyDown
        If (e.KeyValue = 13) Then
            txtLoaiDuong.Focus()
        End If
    End Sub

    Private Sub txtLoaiDuong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoaiDuong.KeyDown
        If (e.KeyValue = 13) Then
            txtNgoRong.Focus()
        End If
    End Sub

    Private Sub txtNgoRong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNgoRong.KeyDown
        If (e.KeyValue = 13) Then
            txtViTri.Focus()
        End If
    End Sub

    Private Sub txtViTri_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtViTri.KeyDown
        If (e.KeyValue = 13) Then
            txtCachDuongChinh.Focus()
        End If
    End Sub

    Private Sub txtCachDuongChinh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCachDuongChinh.KeyDown
        If (e.KeyValue = 13) Then
            txtLPTB.Focus()
        End If
    End Sub

    Private Sub txtLPTB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLPTB.KeyDown
        If (e.KeyValue = 13) Then
            txtTTNCN.Focus()
        End If
    End Sub

    Private Sub txtTTNCN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTTNCN.KeyDown
        If (e.KeyValue = 13) Then
            txtNoiDungHoSo.Focus()
        End If
    End Sub

    Private Sub txtNoiDungHoSo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoiDungHoSo.KeyDown
        If (e.KeyValue = 13) Then
            txtGhiChu.Focus()
        End If
    End Sub

    Private Sub txtGhiChu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGhiChu.KeyDown
        If (e.KeyValue = 13) Then
            btnCapNhat.Focus()
        End If
    End Sub

    Private Sub ctrlThongTinThuaKeKhai_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
       
    End Sub
End Class
