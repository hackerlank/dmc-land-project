Imports System.Drawing
Imports System.Windows.Forms
Public Class ctrlTimKiem
    Private dtTimKiem As New DataTable
    'Khai báo chuỗi kết nối Database
    Private strConnection As String = ""
    'Khai bao bien kiem tra loi
    Private strError As String = ""
    Private blnCapNhat As Boolean = False
    Private strMaHoSoCapGCN As String = ""
    Private strMaThuaDat As String = ""
    Private strMaDonViHanhChinh As String = ""
    Private strToBanDo As String = ""
    Private strSoThua As String = ""
    Private strDienTich As String = ""
    Private strDiaChiThua As String = ""
    'Khai báo thuộc tính chuỗi kết nối Database
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
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
    Public Property DienTich() As String
        Get
            Return strDienTich
        End Get
        Set(ByVal value As String)
            strDienTich = value
        End Set
    End Property
    Public Property DiaChiThua() As String
        Get
            Return strDiaChiThua
        End Get
        Set(ByVal value As String)
            strDiaChiThua = value
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


    Public ReadOnly Property MaHoSoCapGCN() As String
        Get
            Return strMaHoSoCapGCN
        End Get
    End Property
    Public ReadOnly Property MaThuaDat() As String
        Get
            Return strMaThuaDat
        End Get
    End Property
    Public Sub AddColumnsTimKiem()
        Dim txtClnToBanDoTimKiem As New DataGridViewTextBoxColumn
        Dim txtClnSoThuaTimKiem As New DataGridViewTextBoxColumn
        Dim txtClnDienTichTimKiem As New DataGridViewTextBoxColumn
        Dim txtClnDiaChiThuaTimKiem As New DataGridViewTextBoxColumn
        Try
            'Tờ bản đồ
            With txtClnToBanDoTimKiem
                .HeaderText = "Tờ bản đồ"
                .Name = "ToBanDoTimKiem"
                .Width = 100
            End With
            'Số hiệu thửa
            With txtClnSoThuaTimKiem
                .HeaderText = "Số thửa"
                .Name = "SoThuaTimKiem"
                .Width = 100
            End With
            'Dien tich thửa đất
            With txtClnDienTichTimKiem
                .HeaderText = "Diện tích"
                .Name = "DienTichTimKiem"
                .Width = 100
            End With
            'Địa chỉ thửa
            With txtClnDiaChiThuaTimKiem
                .HeaderText = "Địa chỉ thửa"
                .Name = "DiaChiThuaTimKiem"
                .Width = 400
            End With
            'Add all to DataGridView
            With Me.grdvwTimKiem
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Add Columns
                With .Columns
                    .Add(txtClnToBanDoTimKiem)
                    .Add(txtClnSoThuaTimKiem)
                    .Add(txtClnDienTichTimKiem)
                    .Add(txtClnDiaChiThuaTimKiem)
                End With
                'Không cho phép thêm
                .AllowUserToAddRows = False
                'Không cho phép xóa
                .AllowUserToDeleteRows = False
                'Không lựa chọn bất kỳ dòng nào
                .ClearSelection()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Tìm kiếm" + vbNewLine + " Lỗi: " & vbNewLine & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    Public Sub AddColumnsTacNghiep()
        Dim txtClnToBanDoTacNghiep As New DataGridViewTextBoxColumn
        Dim txtClnSoThuaTacNghiep As New DataGridViewTextBoxColumn
        Dim txtClnDienTichTacNghiep As New DataGridViewTextBoxColumn
        Dim txtClnDiaChiThuaTacNghiep As New DataGridViewTextBoxColumn
        Try
            'Tờ bản đồ
            With txtClnToBanDoTacNghiep
                .HeaderText = "Tờ bản đồ"
                .Name = "ToBanDoTacNghiep"
                .Width = 100
            End With
            'Số hiệu thửa
            With txtClnSoThuaTacNghiep
                .HeaderText = "Số thửa"
                .Name = "SoThuaTacNghiep"
                .Width = 100
            End With
            'Dien tich thửa đất
            With txtClnDienTichTacNghiep
                .HeaderText = "Diện tích"
                .Name = "DienTichTacNghiep"
                .Width = 100
            End With
            'Địa chỉ thửa
            With txtClnDiaChiThuaTacNghiep
                .HeaderText = "Địa chỉ thửa"
                .Name = "DiaChiThuaTacNghiep"
                .Width = 400
            End With
            'Add all to DataGridView
            With Me.grdvwTacNghiep
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Add Columns
                With .Columns
                    .Add(txtClnToBanDoTacNghiep)
                    .Add(txtClnSoThuaTacNghiep)
                    .Add(txtClnDienTichTacNghiep)
                    .Add(txtClnDiaChiThuaTacNghiep)
                End With
                'Không cho phép thêm
                .AllowUserToAddRows = False
                'Không cho phép xóa
                .AllowUserToDeleteRows = False
                'Không lựa chọn bất kỳ dòng nào
                .ClearSelection()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Tìm kiếm" + vbNewLine + " Lỗi: " & vbNewLine & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    Private Sub btnTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        '---------------------Thong tin tim kiem Tong the------------------------'
        'Khai bao va khoi tao doi tuong clsTimKiem
        Dim TimKiem As New clsTimKiem

        With Me
            'Lam sach du lieu
            .dtTimKiem.Clear()
            .strMaHoSoCapGCN = ""
            .strMaThuaDat = ""
            With .grdvwTacNghiep
                .RowCount = 0
                .ClearSelection()
            End With
            With .grdvwTimKiem
                .RowCount = 0
                .ClearSelection()
            End With
        End With
        'Kiem tra xem da chon don vi hanh chinh can tac nghiep chua
        If (strMaDonViHanhChinh.Trim = "") Or (strMaDonViHanhChinh = "0") Then
            MsgBox("Bạn chưa chọn đơn vị hành chính!", MsgBoxStyle.Information, "DMCLand")
            Exit Sub
        End If
        With TimKiem
            'Gán chuỗi kết nối Database cho clsTimKiem
            .Connection = strConnection
            'Gan gia tri cho cac thuoc tinh doi voi truong hop truy van
            '.flag = 0
            'Mã đơn vị hành chính
            .MaDonViHanhChinh = Me.strMaDonViHanhChinh
            'Tờ bản đồ
            .ToBanDo = Me.txtToBanDo.Text.Trim
            'Số thửa
            .SoThua = Me.txtSoThua.Text.Trim
            'Cap nhat trang thai Ho so vao thuoc tinh cua lop tim kiem 
            If Me.cmbTrangThaiHoSo.Text = "Cấp GCN" Then
                .HoanTatCapGCN = 1
                .HoanTatHoSoKeKhai = ""
                .HoanTatPheDuyet = ""
                .HoanTatThamDinh = ""
            ElseIf Me.cmbTrangThaiHoSo.Text = "Phê duyệt" Then
                .HoanTatPheDuyet = 1
                .HoanTatCapGCN = ""
                .HoanTatHoSoKeKhai = ""
                .HoanTatThamDinh = ""
            ElseIf Me.cmbTrangThaiHoSo.Text = "Thẩm định" Then
                .HoanTatThamDinh = 1
                .HoanTatCapGCN = ""
                .HoanTatHoSoKeKhai = ""
                .HoanTatPheDuyet = ""
            ElseIf Me.cmbTrangThaiHoSo.Text = "Hồ sơ kê khai" Then
                .HoanTatHoSoKeKhai = 1
                .HoanTatCapGCN = ""
                .HoanTatPheDuyet = ""
                .HoanTatThamDinh = ""
            Else
                .HoanTatCapGCN = ""
                .HoanTatHoSoKeKhai = ""
                .HoanTatPheDuyet = ""
                .HoanTatThamDinh = ""
            End If
            .SoPhatHanhGCN = Me.txtSoPhatHanhGCN.Text.Trim
            .SoVaoSoCapGCN = Me.txtSoVaoSoGCN.Text.Trim
            .SoQuyetDinhCapGCN = Me.txtSoQuyetDinhCapGCN.Text.Trim
            'Gan thong tin ve nguoi su dung can tim vao thong tin tim kiem
            .TenChuSuDung = Me.txtTenChu.Text.Trim
            .SoDinhDanh = Me.txtDinhDanh.Text.Trim
        End With
        Try
            'Goi phuong thuc GetData de khoi tao doi tuong clsTimKiem
            If TimKiem.GetData(dtTimKiem) = "" Then
                ' Trinh bay du lieu len DtGrdTimKiem
                If dtTimKiem.Rows.Count > 0 Then
                    For i As Integer = 0 To dtTimKiem.Rows.Count - 1
                        With Me.grdvwTimKiem
                            .RowCount += 1
                            .Item("ToBanDoTimKiem", i).Value = dtTimKiem.Rows(i).Item("ToBanDo").ToString
                            .Item("SoThuaTimKiem", i).Value = dtTimKiem.Rows(i).Item("SoThua").ToString
                            .Item("DiaChiThuaTimKiem", i).Value = dtTimKiem.Rows(i).Item("DiaChiThua").ToString
                            .Item("DienTichTimKiem", i).Value = dtTimKiem.Rows(i).Item("DienTichTuNhien").ToString
                        End With
                    Next i
                End If
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(vbNewLine & "Lỗi: " & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    'Doi ky tu rong ve dang so (0)
    Function DoiKyTuVeDangSo(ByVal strKyTu As String) As Double
        Dim dblTempNumber As Double = 0.0
        If strKyTu = "" Then
            dblTempNumber = 0.0
        Else
            dblTempNumber = Convert.ToDouble(strKyTu)
        End If
        Return dblTempNumber
    End Function


    Private Sub ctrlTimKiem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me
            .AddColumnsTacNghiep()
            .AddColumnsTimKiem()
            With .grdvwTimKiem
                .ReadOnly = True
                .RowCount = 0
            End With
            With .grdvwTacNghiep
                .ReadOnly = True
                .RowCount = 0
            End With
        End With
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub grdvwTimKiem_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdvwTimKiem.CellMouseClick
        'Truong hop click chuot trai vao grid
        If (e.Button.ToString = "Left") And (e.RowIndex >= 0) Then
            Me.grdvwTimKiem.ClearSelection()
            Exit Sub
        End If
        'Truong hop lua chon mot ban ghi
        If (e.Button.ToString = "Right") And (e.RowIndex >= 0) Then

            Try
                With grdvwTimKiem
                    .ClearSelection()
                    .Rows(e.RowIndex).Selected = True
                End With
                With dtTimKiem.Rows(e.RowIndex)
                    'Gan gia tri vao bien dung chung
                    strMaThuaDat = ""
                    strMaThuaDat = .Item("MaThuaDat").ToString
                    strMaHoSoCapGCN = ""
                    strMaHoSoCapGCN = .Item("MaHoSoCapGCN").ToString
                    'Hien thi ban ghi lua chon len Danh sach thua can tac nghiep
                    grdvwTacNghiep.RowCount = 1
                    grdvwTacNghiep.Item("ToBanDoTacNghiep", 0).Value = .Item("ToBanDo").ToString
                    strToBanDo = .Item("ToBanDo").ToString
                    grdvwTacNghiep.Item("SoThuaTacNghiep", 0).Value = .Item("SoThua").ToString
                    strSoThua = .Item("SoThua").ToString
                    grdvwTacNghiep.Item("DiaChiThuaTacNghiep", 0).Value = .Item("DiaChiThua").ToString
                    strDiaChiThua = .Item("DiaChiThua").ToString
                    grdvwTacNghiep.Item("DienTichTacNghiep", 0).Value = .Item("DienTichTuNhien").ToString
                    strDienTich = .Item("DienTichTuNhien").ToString
                    '/...
                End With
                'Trang thai chuc nang 
                blnCapNhat = False
            Catch ex As Exception
                strError = ex.Message
                MsgBox("Tìm kiếm: " & vbNewLine & "Lỗi: " & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
            End Try
        End If
    End Sub

    Private Sub btnTimMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimMoi.Click
        With Me
            .strMaHoSoCapGCN = ""
            .strMaThuaDat = ""
            .cmbTrangThaiHoSo.Text = ""
            With .grdvwTacNghiep
                .RowCount = 0
                .ClearSelection()
            End With
            With .grdvwTimKiem
                .RowCount = 0
                .ClearSelection()
            End With
            'Thông tin thửa đất
            .txtToBanDo.Text = ""
            .txtSoThua.Text = ""
            'Thôn tin cấp GCN
            .txtSoPhatHanhGCN.Text = ""
            .txtSoVaoSoGCN.Text = ""
            .txtSoQuyetDinhCapGCN.Text = ""
            'Chủ sử dụng đất
            .txtTenChu.Text = ""
            .txtDinhDanh.Text = ""
            'Hồ sơ
            .txtHoSoTiepNhanSo.Text = ""
            .txtSoThuTuTiepNhan.Text = ""
        End With
    End Sub

End Class

