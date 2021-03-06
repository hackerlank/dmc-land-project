Imports System.Windows.Forms
Imports System.Drawing
Public Class ctrlHangMucCongTrinh
    Private strMaCongTrinhXayDung As String = ""
    Private dtCongTrinhXayDung As New DataTable
    Private blnNonNumberEntered As Boolean
    ' Khai báo nhận Tên đơn vị hành chính
    Private strTenDonViHanhChinh As String = ""
    'Khai báo biến nhận chuỗi kết nối Database
    Private strConnection As String = ""
    'Khai báo biến kiểm tra lỗi
    Private strError As String = ""
    Private strMaHangMucCongTrinh As String = ""
    Private shortAction As Short = 0
    'lay cac gia tri chon dc
    Private strTenHangMucCongTrinh As String = ""

    Private dblDienTichXayDung As String = ""
    Private strKetCau As String = ""
    Private strCapHang As String = ""
    Private dblSoTang As Double
    Private strThoiHanSoHuu As String = ""
    Private strNamXayDung As String
    Private strCongSuat As String = ""

    'Khai báo nhận Tên đơn vị hành chính
    Public WriteOnly Property TenDonViHanhChinh() As String
        Set(ByVal value As String)
            strTenDonViHanhChinh = value
        End Set
    End Property
    'Khai báo thuộc tính nhận chuỗi kết nối Database
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property
    Public WriteOnly Property Action() As String
        Set(ByVal value As String)
            shortAction = value
        End Set
    End Property
    Public WriteOnly Property MaCongTrinhXayDung() As String
        Set(ByVal value As String)
            strMaCongTrinhXayDung = value
        End Set
    End Property
    Public Property MaHangMucCongTrinh() As String
        Get
            Return strMaHangMucCongTrinh
        End Get
        Set(ByVal value As String)
            strMaHangMucCongTrinh = value
        End Set
    End Property

    Public Sub ShowData()
        'Khai báo và khởi tạo đối tượng
        Dim HangMucCongTrinh As New clsHangMucCongTrinh
        'Gán giá trị cho các thuộc tính đối với trường hợp truy vấn
        Try
            With HangMucCongTrinh
                'Nhận chuỗi kết nối cơ sở dữ liệu
                .Connection = strConnection
                .MaCongTrinhXayDung = strMaCongTrinhXayDung
            End With
            dtCongTrinhXayDung.Clear()
            With Me.grdvwHangMucCongTrinh
                .ClearSelection()
                'Gọi phương thức GetData 
                If HangMucCongTrinh.SelectHangMucCongTrinhByMaMaCongTrinhXayDung(dtCongTrinhXayDung) = "" Then
                    'Trình bày dữ liệu lên Grid
                    .DataSource = dtCongTrinhXayDung
                    'Định dạng các cột của Grid
                    If dtCongTrinhXayDung.Rows.Count > 0 Then
                        Me.FormatGridContruction()
                    Else
                        Me.HideAllColumns(grdvwHangMucCongTrinh)
                    End If
                End If
            End With
            'Thiết đặt trạng thái ban đầu
            Me.TrangThaiBanDau()
            'Trạng thái chức năng
            Me.TrangThaiChucNang()
            'Trạng thái cập nhật
            Me.TrangThaiCapNhat()
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hiển thị dữ liệu " & vbNewLine & " Hạng mục công trình " _
                   & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Public Sub TrangThaiChucNang(Optional ByVal blnStartEdited As Boolean = False, Optional ByVal blnStartDeleted As Boolean = False)
        With Me
            .btnSua.Enabled = Not blnStartEdited
            .btnXoa.Enabled = Not blnStartEdited
            .btnThem.Enabled = Not blnStartEdited
            .btnCapNhat.Enabled = blnStartEdited
            .btnHuyLenh.Enabled = blnStartEdited
            If blnStartDeleted Then
                .btnCapNhat.Enabled = Not blnStartDeleted
                .btnHuyLenh.Enabled = Not blnStartDeleted
            End If
        End With
    End Sub
    Public Sub TrangThaiCapNhat(Optional ByVal blnCapNhat As Boolean = False)
        With Me
            .grdvwHangMucCongTrinh.BackgroundColor = Color.White
            'Diện tích 
            With .txtCongSuat
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            'Diện tích 
            With .numDienTichXayDung
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            With .numNamXayDung
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            With .numSoTang
                .ReadOnly = Not blnCapNhat
                .Enabled = blnCapNhat
            End With
            .txtTenHangMucCongTrinh.ReadOnly = Not blnCapNhat
            .txtKetCau.ReadOnly = Not blnCapNhat
            .txtThoiHanSoHuu.ReadOnly = Not blnCapNhat
            .cmbCapHang.Enabled = blnCapNhat
            If blnCapNhat Then
                .txtCongSuat.BackColor = Color.White
                .numDienTichXayDung.BackColor = Color.White
                .numNamXayDung.BackColor = Color.White
                .numSoTang.BackColor = Color.White
                .txtTenHangMucCongTrinh.BackColor = Color.White
                .txtKetCau.BackColor = Color.White
                .txtThoiHanSoHuu.BackColor = Color.White
                .cmbCapHang.BackColor = Color.White
            Else
                .txtCongSuat.BackColor = Color.LightYellow
                .numDienTichXayDung.BackColor = Color.LightYellow
                .numNamXayDung.BackColor = Color.LightYellow
                .numSoTang.BackColor = Color.LightYellow
                .txtTenHangMucCongTrinh.BackColor = Color.LightYellow
                .txtKetCau.BackColor = Color.LightYellow
                .txtThoiHanSoHuu.BackColor = Color.LightYellow
                .cmbCapHang.BackColor = Color.LightYellow
            End If
        End With
    End Sub
    Public Sub UpdateData()
        'Khai báo và khởi tạo lớp Công trình xây dựng
        Dim HangMucCongTrinh As New clsHangMucCongTrinh
        Try
            With HangMucCongTrinh
                'Nhận chuỗi kết nối cơ sở dữ liệu
                .Connection = strConnection
                .MaCongTrinhXayDung = strMaCongTrinhXayDung

                .MaHangMucCongTrinh = strMaHangMucCongTrinh
                .TenHangMucCongTrinh = Me.txtTenHangMucCongTrinh.Text.Trim
                If IsNumeric(numDienTichXayDung.Text) Then
                    .DienTichXayDung = numDienTichXayDung.Text
                Else
                    .DienTichXayDung = Nothing
                End If
                .KetCau = txtKetCau.Text
                .CapHang = cmbCapHang.Text
                If IsNumeric(numSoTang.Text) Then
                    .SoTang = numSoTang.Text
                Else
                    .SoTang = Nothing
                End If
                .ThoiHanSoHuu = txtThoiHanSoHuu.Text
                If IsNumeric(numNamXayDung.Text) Then
                    .NamXayDung = numNamXayDung.Text
                Else
                    .NamXayDung = Nothing
                End If
                If IsNumeric(txtCongSuat.Text) Then
                    .CongSuat = txtCongSuat.Text
                Else
                    .CongSuat = Nothing
                End If

                Dim str As String = ""
                Dim strResults As String = ""
                If (shortAction = 1) Then
                    strResults = .InsertHangMucCongTrinh(str)
                ElseIf (shortAction = 2) Then
                    strResults = .UpdateHangMucCongTrinh(str)
                ElseIf (shortAction = 3) Then
                    strResults = .DeleteHangMucCongTrinhByMaHangMucCongTrinh(str)
                ElseIf (shortAction = 4) Then
                    strResults = .DeleteHangMucCongTrinhByMaCongTrinhXayDung(str)
                End If
                If strResults = "" Then
                    ShowData()
                    shortAction = 0
                End If
                strError = HangMucCongTrinh.Err
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Công trình xây dựng " & vbNewLine & " Cập nhật " & vbNewLine & _
                   " Lỗi " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        'Nếu tồn tại Mã Công trình xây dựng cần xóa
        If strMaHangMucCongTrinh <> "" Then
            If MsgBox("Bạn chắc chắn muốn xóa không?", MsgBoxStyle.YesNo, "DMCLand!") = MsgBoxResult.Yes Then
                Try
                    With Me
                        shortAction = 3
                        .UpdateData()
                        strMaHangMucCongTrinh = ""
                        'Hiển thị dữ liệu
                        .ShowData()
                        'Trạng thái chức năng
                    End With
                Catch ex As Exception
                    strError = ex.Message
                End Try
                If (strError = "") Then
                    MsgBox(" Bạn đã cập nhật thành công!", MsgBoxStyle.Information, "DMCLand")
                Else
                    MsgBox(" Cập nhật chưa thành công!", MsgBoxStyle.Critical, "DMCLand")
                End If
            End If
        Else
            MsgBox(" Bạn phải chọn Hạng mục công trình xây dựng cần xóa!", MsgBoxStyle.Information, "DMCLand")
        End If
        'Hiển thị dữ liệu
        Me.ShowData()
        strError = ""
    End Sub

    Private Sub grdvwCongTrinhXayDung_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdvwHangMucCongTrinh.CellMouseClick
        'Chỉ thực thi khi người dùng chọn chuột trái
        If e.Button.ToString = "Right" Then
            Exit Sub
        End If
        'Khởi tạo đối tượng
        Dim HangMucCongTrinh As New clsHangMucCongTrinh
        If e.RowIndex >= 0 Then
            Try
                'Gán giá trị cho các thuộc tính ứng với trường hợp truy vấn
                shortAction = 0
                With Me.dtCongTrinhXayDung.Rows(e.RowIndex)
                    HangMucCongTrinh.CongSuat = .Item("CongSuat").ToString
                    If IsNumeric(.Item("DienTichXayDung").ToString) Then
                        HangMucCongTrinh.DienTichXayDung = .Item("DienTichXayDung").ToString
                    Else
                        HangMucCongTrinh.DienTichXayDung = Nothing
                    End If
                    HangMucCongTrinh.KetCau = .Item("KetCau").ToString
                    HangMucCongTrinh.CapHang = .Item("CapHang").ToString
                    HangMucCongTrinh.ThoiHanSoHuu = .Item("ThoiHanSoHuu").ToString
                    strMaHangMucCongTrinh = .Item("MaHangMucCongTrinh").ToString
                    HangMucCongTrinh.MaHangMucCongTrinh = strMaHangMucCongTrinh
                    HangMucCongTrinh.MaCongTrinhXayDung = .Item("MaCongTrinhXayDung").ToString
                    If IsNumeric(.Item("NamXayDung").ToString) Then
                        HangMucCongTrinh.NamXayDung = .Item("NamXayDung").ToString
                    Else
                        HangMucCongTrinh.NamXayDung = Nothing
                    End If
                    HangMucCongTrinh.ThoiHanSoHuu = .Item("ThoiHanSoHuu").ToString
                    HangMucCongTrinh.SoTang = .Item("SoTang").ToString
                    HangMucCongTrinh.TenHangMucCongTrinh = .Item("TenHangMucCongTrinh").ToString
                End With
                'Hiển thị bản ghi được lựa chon lên Form
                With Me
                    If IsNumeric(HangMucCongTrinh.CongSuat) Then
                        Me.txtCongSuat.Text = HangMucCongTrinh.CongSuat
                    Else
                        Me.txtCongSuat.Text = ""
                    End If
                    If IsNumeric(HangMucCongTrinh.DienTichXayDung) Then
                        Me.numDienTichXayDung.Text = HangMucCongTrinh.DienTichXayDung
                    Else
                        Me.numDienTichXayDung.Text = ""
                    End If
                    Me.txtKetCau.Text = HangMucCongTrinh.KetCau
                    Me.cmbCapHang.Text = HangMucCongTrinh.CapHang
                    Me.txtThoiHanSoHuu.Text = HangMucCongTrinh.ThoiHanSoHuu
                    If IsNumeric(HangMucCongTrinh.NamXayDung) Then
                        Me.numNamXayDung.Text = HangMucCongTrinh.NamXayDung
                    Else
                        Me.numNamXayDung.Text = ""
                    End If
                    If IsNumeric(HangMucCongTrinh.SoTang) Then
                        Me.numSoTang.Text = HangMucCongTrinh.SoTang
                    Else
                        Me.numSoTang.Text = ""
                    End If
                    Me.txtTenHangMucCongTrinh.Text = HangMucCongTrinh.TenHangMucCongTrinh
                End With
            Catch ex As Exception
                strError = ex.Message
                MsgBox(" Hiển thị dữ liệu lên Form " & vbNewLine & " Công trình xây dựng" _
                       & vbNewLine & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
        'Bo lua chon tren Grid
        Me.grdvwHangMucCongTrinh.ClearSelection()
        strMaHangMucCongTrinh = ""
        shortAction = 1
        With Me
            'Thiet lap trang thai ban dau
            .TrangThaiBanDau()
            'Trang thai cap nhat
            .TrangThaiCapNhat(True)
            'Trang thai chuc nang 
            .TrangThaiChucNang(True)
        End With
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If strMaHangMucCongTrinh <> "" Then
            shortAction = 2
            'Trang thai chuc nang
            TrangThaiChucNang(True)
            'Trang thai cap nhat
            TrangThaiCapNhat(True)
        Else
            MsgBox(" Bạn chưa chọn Công trình xây dựng cần sửa thông tin!", MsgBoxStyle.Information, "DMCLand")
        End If
    End Sub
    Public Sub TrangThaiBanDau(Optional ByVal blnClearGrid As Boolean = False)
        Try
            With Me
                If (blnClearGrid) Then
                    .HideAllColumns(grdvwHangMucCongTrinh)
                End If
                .txtTenHangMucCongTrinh.Text = ""
                .txtKetCau.Text = ""
                .txtThoiHanSoHuu.Text = ""

                .txtCongSuat.Text = ""
                .numDienTichXayDung.Text = ""
                .numNamXayDung.Text = ""
                .numSoTang.Text = ""
                .cmbCapHang.Text = ""
            End With
        Catch ex As Exception
            MessageBox.Show("Công trình xây dựng " & vbNewLine & "Trạng thái ban đầu" & vbNewLine & "Lỗi: " & ex.Message(), "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ctrlCongTrinhXayDung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If strMaCongTrinhXayDung = "" Then
                Me.TrangThaiBanDau()
                Me.TrangThaiCapNhat()
                'Trạng thái chức năng
                Me.TrangThaiChucNang()
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Nạp dữ liệu ban đầu " & vbNewLine & " Công trình xây dựng " & vbNewLine _
            & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Private Sub grdvwCongTrinhXayDung_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdvwHangMucCongTrinh.CellFormatting
        'If Me.grdvwCongTrinhXayDung.Columns(e.ColumnIndex).Name _
        '    = "NgayCapPhepXayDung" Then
        '    If e.Value IsNot Nothing Then
        '        e.Value = DateTime.Parse(e.Value).ToString("dd\/MM\/yyyy")
        '    End If
        'End If
        'If Me.grdvwCongTrinhXayDung.Columns(e.ColumnIndex).Name _
        '    = "NgayBatDau" Then
        '    If e.Value IsNot Nothing Then
        '        e.Value = DateTime.Parse(e.Value).ToString("dd\/MM\/yyyy")
        '    End If
        'End If
        'If Me.grdvwCongTrinhXayDung.Columns(e.ColumnIndex).Name _
        '    = "NgayKetThuc" Then
        '    If e.Value IsNot Nothing Then
        '        e.Value = DateTime.Parse(e.Value).ToString("dd\/MM\/yyyy")
        '    End If
        'End If
    End Sub
    Private Sub HideAllColumns(ByRef grdvw As DataGridView)
        'Ẩn tất cả các cột trên Grid
        With grdvw
            For i As Integer = 0 To (.Columns.Count - 1)
                .Columns(i).Visible = False
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Public Sub FormatGridContruction()
        Try
            With Me.grdvwHangMucCongTrinh
                Me.HideAllColumns(grdvwHangMucCongTrinh)
                'CHỈ HIỆN THỊ NHỮNG CỘT CẦN THIẾT
                'Hạng mục công trình
                With .Columns("TenHangMucCongTrinh")
                    .Visible = True
                    .HeaderText = "Tên hạng mục công trình"
                    .Width = 200
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Diện tích xây dựng
                With .Columns("DienTichXayDung")
                    .Visible = True
                    .HeaderText = "Diện tích xây dựng"
                    .Width = 130
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Diện tích sàn (Công suất)
                With .Columns("CongSuat")
                    .Visible = True
                    .HeaderText = "Công suất"
                    .Width = 130
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Kết cấu
                With .Columns("KetCau")
                    .Visible = True
                    .HeaderText = "Kết cấu"
                    .Width = 120
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Cấp hạng
                With .Columns("CapHang")
                    .Visible = True
                    .HeaderText = "Cấp hạng"
                    .Width = 120
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Số tầng
                With .Columns("SoTang")
                    .Visible = True
                    .HeaderText = "Số tầng"
                    .Width = 120
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Năm xây dựng
                With .Columns("NamXayDung")
                    .Visible = True
                    .HeaderText = "Năm xây dựng"
                    .Width = 120
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                'Thời hạn sở hữu
                With .Columns("ThoiHanSoHuu")
                    .Visible = True
                    .HeaderText = "Thời hạn"
                    .Width = 120
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .GridColor = Color.WhiteSmoke
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hạng mục công trình " & vbNewLine & "Lỗi: " & vbNewLine & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Private Sub btnCapNhat_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        'Kiểm tra dữ liệu nhập vào
        Try
            With Me
                'Cập nhật thông tin Công trình xây dựng
                .UpdateData()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Cập nhật dữ liệu " & vbNewLine & " Hạng mục công trình " & vbNewLine _
                & " Lỗi: " & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
        If (strError = "") Or (strError = "OK") Then
            MsgBox(" Bạn đã cập nhật thành công!", MsgBoxStyle.Information, "DMCLand")
        Else
            MsgBox(" Cập nhật chưa thành công!", MsgBoxStyle.Critical, "DMCLand")
        End If
        ShowData()
        'Khởi tạo giá trị cho biến dùng chung
        strMaHangMucCongTrinh = ""
        strError = ""
    End Sub

    Private Sub btnHuyLenh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyLenh.Click
        With Me
            'Hiển thị dữ liệu
            .ShowData()
            'Khởi tạo giá trị cho biến dùng chung
            strMaHangMucCongTrinh = ""
        End With
        shortAction = 0
    End Sub

    Private Sub txtTenHangMucCongTrinh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTenHangMucCongTrinh.KeyDown
        If (e.KeyValue = 13) Then
            numDienTichXayDung.Focus()
        End If
    End Sub

    Private Sub numDienTichXayDung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDienTichXayDung.KeyDown
        If (e.KeyValue = 13) Then
            txtCongSuat.Focus()
        End If
    End Sub

    Private Sub txtCongSuat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCongSuat.KeyDown
        If (e.KeyValue = 13) Then
            txtKetCau.Focus()
        End If
    End Sub

    Private Sub txtKetCau_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKetCau.KeyDown
        If (e.KeyValue = 13) Then
            cmbCapHang.Focus()
        End If
    End Sub

    Private Sub cmbCapHang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCapHang.KeyDown
        If (e.KeyValue = 13) Then
            numSoTang.Focus()
        End If
    End Sub

    Private Sub numSoTang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numSoTang.KeyDown
        If (e.KeyValue = 13) Then
            numNamXayDung.Focus()
        End If
    End Sub

    Private Sub numNamXayDung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numNamXayDung.KeyDown
        If (e.KeyValue = 13) Then
            txtThoiHanSoHuu.Focus()
        End If
    End Sub

    Private Sub txtThoiHanSoHuu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtThoiHanSoHuu.KeyDown
        If (e.KeyValue = 13) Then
            btnCapNhat.Focus()
        End If
    End Sub
End Class
