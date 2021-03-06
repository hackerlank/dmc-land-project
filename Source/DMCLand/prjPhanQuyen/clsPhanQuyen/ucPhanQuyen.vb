Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class ucPhanQuyen
    Private iMaQuyen As Integer
    Private sqlConnect As New SqlConnection
    Private arrMaDVHC() As Integer
    Private arrChucNang() As Integer
    Private bNew As Boolean = False
    Private bUpdate = False
    Private bDelete = False
    'khoi tao 
    Private cls As New clsPhanQuyen
#Region "Các sự kiện"

    Public Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        For Each ob As Object In GroupBox1.Controls
            If TypeOf ob Is TextBox Then
                ob.Text = ""
                ob.backcolor = Color.LightYellow
                ob.readonly = True
            End If
        Next
        dtpNgayTao.DropDownAlign = LeftRightAlignment.Right
        grdvwThongTin.ReadOnly = True
        tlstpbtUpdate.Enabled = False
        tlstpbtDelete.Enabled = True
        tstpbtModify.Enabled = True
        TlstpbtAdd.Enabled = True

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub tlstpbtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FindForm.Close()
    End Sub

    Private Sub TlstpbtAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlstpbtAdd.Click
        tlstpbtDelete.Enabled = False
        tstpbtModify.Enabled = False
        tlstpbtUpdate.Enabled = True
        For Each ob As Object In GroupBox1.Controls
            If TypeOf ob Is TextBox Then
                ob.Text = ""
                ob.backcolor = Color.White
                ob.readonly = False
            End If
        Next
        bNew = True
        bUpdate = False
        HienThiDonVi("")
        HienThiChucNangNguoidung("")
        'trvwDonViHanhChinh.ExpandAll()
    End Sub

    Private Sub tlstpbtUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpbtUpdate.Click
        With cls
            .ChucVu = ""
            .DiaChi = ""
            .dNgayPhanChucNang = ""
            .IDGroup = ""
            .iMaChucNang = ""
            .MaDonViHanhChinh = ""
            .MaQuyen = ""
            .MatKhau = ""
            .MaUser = ""
            .NgayPhanQuyen = ""
            .NgayTaoUser = ""
            .nMoToChucNang = ""
            .nTenChucNang = ""
            .PhongBan = ""
            .SoDienThoai = ""
            .TenDangNhap = ""
            .TenDayDu = ""
            .uMaUserChucNang = ""
        End With

        Dim ar() As Integer
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "pro_AddUser"
        cmd.Connection = sqlConnect
        If sqlConnect.State <> ConnectionState.Open Then
            sqlConnect.Open()
        End If
        cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar)
        cmd.Parameters("@Tendangnhap").Value = txtTenDangNhap.Text
        cmd.Parameters.Add("@maquyen", SqlDbType.Int)
        cmd.Parameters("@maquyen").Value = iMaQuyen + 1
        cmd.Parameters.Add("@tendaydu", SqlDbType.NVarChar)
        cmd.Parameters("@Tendaydu").Value = txtTendaydu.Text
        cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar)
        cmd.Parameters("@chucvu").Value = txtChucVu.Text
        cmd.Parameters.Add("@phongban", SqlDbType.NVarChar)
        cmd.Parameters("@phongban").Value = txtPhongBan.Text
        cmd.Parameters.Add("@diachi", SqlDbType.NVarChar)
        cmd.Parameters("@diachi").Value = txtDiaChi.Text
        cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar)
        cmd.Parameters("@sodienthoai").Value = txtSoDienThoai.Text
        cmd.Parameters.Add("@mausers", SqlDbType.UniqueIdentifier)
        cmd.Parameters("@mausers").Direction = ParameterDirection.Output
        ar = Get_DVHC()
        'Khi tạo mới một user
        If bNew Then
            If KiemtraInput() Then
                If ar Is Nothing Then
                    MsgBox("Chưa chọn đơn vị hành chính")
                    Exit Sub
                Else
                    'Thêm một user
                    cmd.ExecuteNonQuery()

                    'Thêm đơn vị mã hành chính mà user mới quản lý
                    Dim cmd1 As New SqlCommand
                    cmd1.Connection = sqlConnect
                    cmd1.CommandType = CommandType.StoredProcedure
                    cmd1.CommandText = "pro_AddUserStatus"
                    cmd1.Parameters.Add("@mausers", SqlDbType.UniqueIdentifier)
                    cmd1.Parameters("@mausers").Value = cmd.Parameters("@mausers").Value
                    cmd1.Parameters.Add("@madvhc", SqlDbType.Int)
                    For i As Integer = 0 To UBound(ar) - 1
                        cmd1.Parameters("@madvhc").Value = ar(i)
                        cmd1.ExecuteNonQuery()
                    Next
                    cmd1.Dispose()

                    'Insert Chức năng
                    Dim cmdchucnang As New SqlCommand
                    cmdchucnang.Connection = sqlConnect
                    For Each n As TreeNode In trvwChucNang.Nodes
                        For Each m As TreeNode In n.Nodes
                            If m.Checked Then
                                'spUserChucNang voi flag=0

                                Dim fielUseChucNang() As String = {"MaUsers", "iMaChucNang", "dNgayPhanChucNang", "TenDangNhap"}
                                Dim ValueUseChucNang() As String = {cmd.Parameters("@mausers").Value.ToString, m.Name, "", ""}
                                MyExecute("spUserChucNang", 0, fielUseChucNang, ValueUseChucNang)
                                ' ''cmdchucnang.CommandText = "insert into tbluserchucnang values(newid(),'" & cmd.Parameters("@mauser").Value.ToString & "','" & m.Name & "',getdate())"
                                ' ''cmdchucnang.ExecuteNonQuery()
                            End If
                        Next
                    Next
                    cmdchucnang.Dispose()

                    'Hiển thị lại thông tin mới
                    HienThiThongTinLenGridview()
                    HienthithongtinlenTextbox(grdvwThongTin.CurrentCell.RowIndex)
                    HienThiDonVi(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value)
                    HienThiChucNangNguoidung(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value)
                    MsgBox("Tạo mới thành công")
                    tlstpbtUpdate.Enabled = False
                    bNew = False
                End If
            Else
                Exit Sub
            End If
        ElseIf bUpdate Then
            If txtSoDienThoai.Text <> "" Then
                If IsNumeric(txtSoDienThoai.Text) = False Then
                    MsgBox("Số điện thoại không hợp lệ")
                    txtSoDienThoai.Focus()
                    Exit Sub
                End If
            End If
            If ar Is Nothing Then
                MsgBox("Chưa chọn đơn vị hành chính", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            Else
                'spUser voi flag=0
                With cls
                    .MaUser = ""
                    Dim fielusers() As String = {"MaUsers", "tendaydu", "chucvu", "phongban", "diachi", "sodienthoai", "tendangnhap", "MaQuyen", "MatKhau", "NgayTaoUser"}
                    Dim Valueusers() As String = {.MaUser, txtTendaydu.Text, txtChucVu.Text, txtPhongBan.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtTenDangNhap.Text, "", "", ""}

                    MyExecute("spUsers", 0, fielusers, Valueusers)
                End With
                ' '' ''Dim cmd3 As New SqlCommand("update tblusers set tendaydu=N'" & txtTendaydu.Text & "',chucvu=N'" & txtChucVu.Text & "',phongban=N'" & txtPhongBan.Text & "',diachi=N'" & txtDiaChi.Text & "',sodienthoai='" & txtSoDienThoai.Text & "' where tendangnhap='" & txtTenDangNhap.Text & "' ", sqlConnect)
                ' '' ''cmd3.ExecuteNonQuery()
                ' '' ''cmd3.Dispose()

                'Thực hiện update Đơn vị hành chính
                'spUserStatus voi flag=0
                ' '' ''Dim cmd2 As New SqlCommand("select * from tbluserstatus where mauser=(select mausers from tblusers where tendangnhap='" & txtTenDangNhap.Text & "')", sqlConnect)
                ' '' ''cmd2.ExecuteNonQuery()
                ' '' ''Dim da As New SqlDataAdapter(cmd2)
                ' '' ''Dim ds As New DataSet
                ' '' ''da.Fill(ds, "result")
                Dim FieldUserStatus() As String = {"tendangnhap", "MaUsers", "MaDonViHanhChinh", "NgayPhanQuyen"}
                Dim ValuesUserStatus() As String = {txtTenDangNhap.Text, "", "", ""}
                Dim Tableuserstatus As New DataTable
                Tableuserstatus = MyDataTable("spUserStatus", 0, FieldUserStatus, ValuesUserStatus)
                Try
                    'Trường hợp người đó đã được cấp đơn vị hành chính quản lý
                    If Tableuserstatus.Rows.Count > 0 Then
                        Dim arr2() As Integer
                        ReDim arr2(0)
                        Dim arrRS() As Integer
                        For i As Integer = 0 To Tableuserstatus.Rows.Count - 1
                            ReDim Preserve arr2(i + 1)
                            arr2(i) = Tableuserstatus.Rows(i).Item("MaDonViHanhChinh")
                        Next
                        arrRS = Get_MangTrung(ar, arr2)
                        Dim sqlcm As New SqlCommand
                        sqlcm.CommandType = CommandType.Text
                        sqlcm.Connection = sqlConnect

                        'Bắt đầu thực hiện
                        For i As Integer = 0 To UBound(ar) - 1
                            If KT(ar(i), arrRS) = False Then
                                'spUserStatus voi flag=1
                                Dim InsFielUserStatus() As String = {"MaUsers", "MaDonViHanhChinh", "tendangnhap", "NgayPhanQuyen"}
                                Dim InsValuesUserStatus() As String = {Tableuserstatus.Rows(0).Item(1).ToString, ar(i), "", ""}
                                MyExecute("spUserStatus", 1, InsFielUserStatus, InsValuesUserStatus)
                                ' '' ''sqlcm.CommandText = "insert into tbluserstatus values(newid(),'" & Tableuserstatus.Rows(0).Item(1).ToString & "','" & ar(i) & "',getdate())"
                                ' '' ''sqlcm.ExecuteNonQuery()
                            End If
                        Next
                        For i As Integer = 0 To UBound(arr2) - 1
                            If KT(arr2(i), arrRS) = False Then
                                'spUserStatus voi flag=2
                                Dim DelFielUserStatus() As String = {"MaUsers", "madonvihanhchinh", "NgayPhanQuyen", "TenDangNhap"}
                                Dim DelValuesUserStatus() As String = {Tableuserstatus.Rows(0).Item(1).ToString, arr2(i), "", ""}
                                MyExecute("spUserStatus", 1, DelFielUserStatus, DelValuesUserStatus)

                                '' ''sqlcm.CommandText = "delete tbluserstatus where mauser='" & Tableuserstatus.Rows(0).Item(1).ToString & "' and madonvihanhchinh='" & arr2(i) & "'"
                                '' ''sqlcm.ExecuteNonQuery()
                            End If
                        Next
                        sqlcm.Dispose()
                    End If
                    ' ''cmd2.Dispose()
                Catch ex As Exception 'Trường hợp chưa có
                    Dim cmd1 As New SqlCommand
                    cmd1.Connection = sqlConnect
                    cmd1.CommandType = CommandType.StoredProcedure
                    cmd1.CommandText = "pro_AddUserStatus"
                    cmd1.Parameters.Add("@Mausers", SqlDbType.NVarChar, 50)
                    cmd1.Parameters("@mausers").Value = grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value
                    cmd1.Parameters.Add("@madvhc", SqlDbType.Int)
                    For i As Integer = 0 To UBound(ar) - 1
                        cmd1.Parameters("@madvhc").Value = ar(i)
                        cmd1.ExecuteNonQuery()
                    Next
                    cmd1.Dispose()
                End Try

                'Thực hiện Update chức năng
                'spUserChucNang voi flag=1

                '' ''Dim cmdchucnang As New SqlCommand("select * from tbluserchucnang where umauser=(select mausers from tblusers where tendangnhap='" & txtTenDangNhap.Text & "')", sqlConnect)
                '' ''cmdchucnang.ExecuteNonQuery()
                '' ''Dim dacn As New SqlDataAdapter(cmdchucnang)
                '' ''Dim dscn As New DataSet
                Dim arrcn() As Integer
                ReDim arrcn(0)
                Dim ii As Integer = 0
                '' ''dacn.Fill(dscn, "result")

                Dim selFieldUserChucNang() As String = {"tendangnhap", "MaUsers", "iMaChucNang", "dNgayPhanChucNang"}
                Dim SelValuesUserChucNang() As String = {txtTenDangNhap.Text, "", "", ""}
                Dim TableUserChucNang As New DataTable
                TableUserChucNang = MyDataTable("spUserChucNang", 1, selFieldUserChucNang, SelValuesUserChucNang)

                For Each n As TreeNode In trvwChucNang.Nodes
                    For Each m As TreeNode In n.Nodes
                        If m.Checked Then
                            ii = ii + 1
                            ReDim Preserve arrcn(ii)
                            arrcn(ii - 1) = m.Name
                        End If
                    Next
                Next
                Try
                    'Trường hợp người đó đã được cấp chức năng
                    If TableUserChucNang.Rows.Count > 0 Then
                        Dim arr2() As Integer
                        ReDim arr2(0)
                        Dim arrRS() As Integer
                        For i As Integer = 0 To TableUserChucNang.Rows.Count - 1
                            ReDim Preserve arr2(i + 1)
                            arr2(i) = TableUserChucNang.Rows(i).Item(2)
                        Next
                        arrRS = Get_MangTrung(arrcn, arr2)
                        Dim sqlcm As New SqlCommand
                        sqlcm.CommandType = CommandType.Text
                        sqlcm.Connection = sqlConnect

                        'Bắt đầu thực hiện
                        If Not arrcn Is Nothing Then
                            For i As Integer = 0 To UBound(arrcn) - 1
                                If KT(arrcn(i), arrRS) = False Then
                                    'spUserChucNang voi flag=2
                                    Dim insFieldUserChucNang() As String = {"MaUsers", "iMaChucNang", "dNgayPhanChucNang", "TenDangNhap"}
                                    Dim insValuesUserChucNang() As String = {TableUserChucNang.Rows(0).Item(1).ToString, arrcn(i), "", ""}
                                    MyExecute("spUserChucNang", 2, insFieldUserChucNang, insValuesUserChucNang)
                                    ' ''sqlcm.CommandText = "insert into tbluserchucnang values(newid(),'" & TableUserChucNang.Rows(0).Item(1).ToString & "','" & arrcn(i) & "',getdate())"
                                    ' ''sqlcm.ExecuteNonQuery()

                                End If
                            Next
                        End If
                        For i As Integer = 0 To UBound(arr2) - 1
                            If KT(arr2(i), arrRS) = False Then
                                'spUserChucNang voi flag=3
                                Dim insFieldUserChucNang() As String = {"MaUsers", "imachucnang", "dNgayPhanChucNang", "TenDangNhap"}
                                Dim insValuesUserChucNang() As String = {TableUserChucNang.Rows(0).Item(1).ToString, arr2(i), "", ""}
                                MyExecute("spUserChucNang", 3, insFieldUserChucNang, insValuesUserChucNang)

                                '' ''sqlcm.CommandText = "delete tbluserchucnang where umauser='" & TableUserChucNang.Rows(0).Item(1).ToString & "' and imachucnang='" & arr2(i) & "'"
                                '' ''sqlcm.ExecuteNonQuery()
                            End If
                        Next
                        sqlcm.Dispose()
                    Else
                        Dim cmd1 As New SqlCommand
                        cmd1.Connection = sqlConnect
                        For i As Integer = 0 To UBound(arrcn) - 1
                            'spUserChucNang voi flag=2
                            Dim insFieldUserChucNang() As String = {"MaUsers", "iMaChucNang", "dNgayPhanChucNang", "TenDangNhap"}
                            Dim insValuesUserChucNang() As String = {grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString, arrcn(i), "", "", ""}
                            MyExecute("spUserChucNang", 2, insFieldUserChucNang, insValuesUserChucNang)
                            '' ''cmd1.CommandText = "insert into tbluserchucnang values(newid(),'" & grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString & "','" & arrcn(i) & "',getdate())"
                            '' ''cmd1.ExecuteNonQuery()
                        Next
                        cmd1.Dispose()
                    End If
                    ' ''cmdchucnang.Dispose()
                Catch ex As Exception 'Trường hợp chưa có
                    Dim cmd1 As New SqlCommand
                    cmd1.Connection = sqlConnect
                    For i As Integer = 0 To UBound(arrcn) - 1
                        'spUserChucNang voi flag=2
                        Dim insFieldUserChucNang() As String = {"MaUsers", "iMaChucNang", "dNgayPhanChucNang", "TenDangNhap"}
                        Dim insValuesUserChucNang() As String = {grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString, arrcn(i), "", "", ""}
                        MyExecute("spUserChucNang", 2, insFieldUserChucNang, insValuesUserChucNang)

                        ' '' ''cmd1.CommandText = "insert into tbluserchucnang values(newid(),'" & grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString & "','" & arrcn(i) & "',getdate())"
                        ' '' ''cmd1.ExecuteNonQuery()
                    Next
                    cmd1.Dispose()
                End Try
                HienThiThongTinLenGridview()
                HienthithongtinlenTextbox(grdvwThongTin.CurrentCell.RowIndex)
                HienThiDonVi(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString)
                HienThiChucNangNguoidung(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString)
            End If
        End If
        bNew = False
        bUpdate = False
        cmd.Dispose()
        TlstpbtAdd.Enabled = True
        tstpbtModify.Enabled = True
        tlstpbtDelete.Enabled = True
    End Sub

    'Hàm trả về mảng giá trị 
    Private Function Get_MangTrung(ByVal arr1() As Integer, ByVal arr2() As Integer) As Integer()
        Dim b As Boolean = False
        Dim vt() As Integer
        Dim dem As Integer = 0
        ReDim Preserve vt(0)
        For i As Integer = 0 To UBound(arr1) - 1
            For j As Integer = 0 To UBound(arr2) - 1
                If arr1(i) = arr2(j) Then
                    dem = dem + 1
                    ReDim Preserve vt(dem)
                    vt(dem - 1) = arr1(i)
                    Exit For
                End If
            Next
        Next
        If dem > 0 Then
            Return vt
        Else
            Return Nothing
        End If
    End Function

    Private Sub tstpbtModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstpbtModify.Click
        If txtTenDangNhap.Text <> "" Then
            tlstpbtUpdate.Enabled = True
            TlstpbtAdd.Enabled = False
            tlstpbtDelete.Enabled = False
            bUpdate = True
            For Each ob As Object In GroupBox1.Controls
                If TypeOf ob Is TextBox Then
                    ob.backcolor = Color.White
                    ob.readonly = False
                End If
            Next
            txtTenDangNhap.BackColor = Color.LightYellow
            txtTenDangNhap.ReadOnly = True
            txtTendaydu.Focus()
        Else
            MsgBox("Chưa chọn đối tượng để sửa")
        End If

    End Sub

    Private Sub tlstpbtDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpbtDelete.Click
        If txtTenDangNhap.Text <> "" Then
            If MsgBox("Bạn có chắc chắn muốn xóa không?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Thông báo") = MsgBoxResult.Yes Then
                'spUserchucnag voi Flag 3
                Dim delFieldUserStatus() As String = {"tendangnhap", "MaDonViHanhChinh", "MaUsers", "NgayPhanQuyen"}
                Dim insValuesUserStatus() As String = {txtTenDangNhap.Text, "", "", "", ""}
                MyExecute("spUserStatus", 3, delFieldUserStatus, insValuesUserStatus)



                '' ''Dim cmd1 As New SqlCommand("delete tbluserstatus where mauser=(select mausers from tblusers where tendangnhap='" & txtTenDangNhap.Text & "')", sqlConnect)
                '' ''Try
                '' ''    cmd1.ExecuteNonQuery()
                '' ''Catch ex As Exception
                '' ''End Try

                ' '' ''Dim cmd2 As New SqlCommand("delete tbluserchucnang where umauser=(select mausers from tblusers where tendangnhap='" & txtTenDangNhap.Text & "')", sqlConnect)
                ' '' ''Try
                ' '' ''    cmd2.ExecuteNonQuery()
                ' '' ''Catch ex As Exception
                ' '' ''End Try
                'spUserChucNang voi flag=4
                Dim delFielduserchucnang() As String = {"tendangnhap", "MaUsers", "iMaChucNang", "dNgayPhanChucNang"}
                Dim insValuesuserchucnang() As String = {txtTenDangNhap.Text, "", "", ""}
                MyExecute("spUserChucNang", 4, delFielduserchucnang, insValuesuserchucnang)

                'spUser truong hop flag=1
                Dim delFielduser() As String = {"tendangnhap", "MaUsers", "MaQuyen", "MatKhau", "NgayTaoUser", "TenDayDu", "ChucVu", "Phongban", "Diachi", "SoDienThoai"}
                Dim insValuesuser() As String = {txtTenDangNhap.Text, "", "", "", "", "", "", "", "", ""}
                MyExecute("spUsers", 1, delFielduser, insValuesuser)
                '' ''Dim cmd As New SqlCommand("delete tblusers where tendangnhap='" & txtTenDangNhap.Text & "'", sqlConnect)
                '' ''cmd.ExecuteNonQuery()
                HienThiThongTinLenGridview()
                HienthithongtinlenTextbox(grdvwThongTin.CurrentCell.RowIndex)
                HienThiDonVi(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString)
                HienThiChucNangNguoidung(grdvwThongTin.Item(7, grdvwThongTin.CurrentCell.RowIndex).Value.ToString)
                '' ''cmd.Dispose()
                '' ''cmd1.Dispose()
                '' ''cmd2.Dispose()
            End If
        End If
    End Sub

    Private Sub txtTenDangNhap_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTenDangNhap.KeyUp
        If e.KeyData = Keys.Enter Then
            txtTendaydu.Focus()
        End If
    End Sub

    Private Sub txtTendaydu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTendaydu.KeyUp
        If e.KeyData = Keys.Enter Then
            txtChucVu.Focus()
        End If
    End Sub

    Private Sub txtChucVu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChucVu.KeyUp
        If e.KeyData = Keys.Enter Then
            txtPhongBan.Focus()
        End If
    End Sub

    Private Sub txtPhongBan_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhongBan.KeyUp
        If e.KeyData = Keys.Enter Then
            txtDiaChi.Focus()
        End If
    End Sub

    Private Sub txtDiaChi_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiaChi.KeyUp
        If e.KeyData = Keys.Enter Then
            txtSoDienThoai.Focus()
        End If
    End Sub

#End Region

#Region "Kiểm tra input "
    Private Function KiemtraInput() As Boolean
        If txtTenDangNhap.Text = "" Then
            MsgBox("Chưa có tên đăng nhập")
            txtTenDangNhap.Focus()
            Return False
            Exit Function
        End If
        If txtSoDienThoai.Text <> "" Then
            If Not IsNumeric(txtSoDienThoai.Text) Then
                MsgBox("Số điện thọai không hợp lệ")
                txtSoDienThoai.Focus()
                Return False
                Exit Function
            End If
        End If

        Dim cmd1 As New SqlCommand
        cmd1.CommandType = CommandType.Text
        'spuser truong hop flag =2
        Dim selFielduser() As String = {"tendangnhap", "MaUsers", "MaQuyen", "MatKhau", "NgayTaoUser", "TenDayDu", "ChucVu", "Phongban", "Diachi", "SoDienThoai"}
        Dim SelValuesuser() As String = {txtTenDangNhap.Text, "", "", "", "", "", "", "", "", ""}
        Dim TableUser As New DataTable
        TableUser = MyDataTable("spUsers", 2, selFielduser, SelValuesuser)
        '' ''cmd1.CommandText = "select * from tblusers where tendangnhap='" & txtTenDangNhap.Text & "'"
        '' ''cmd1.Connection = sqlConnect
        '' ''If sqlConnect.State <> ConnectionState.Open Then
        '' ''    sqlConnect.Open()
        '' ''End If
        '' ''cmd1.ExecuteNonQuery()
        '' ''Dim da As New SqlDataAdapter
        '' ''da.SelectCommand = cmd1
        '' ''Dim ds As New DataSet
        '' ''da.Fill(ds, "result")
        Try
            If TableUser.Rows.Count > 0 Then
                MsgBox("Tên này đã có người sử dụng, hãy chọn tên khác!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Thông báo")
                txtTenDangNhap.Focus()
                Return False
                cmd1.Dispose()
                Exit Function
            End If
        Catch ex As Exception
            Return True
            cmd1.Dispose()
            Exit Function
        End Try
        cmd1.Dispose()
        Return True
    End Function

    Private Function Get_DVHC() As Integer()
        Dim arr() As Integer
        Dim arrc1() As Integer
        Dim arrc2() As Integer
        Dim arrc3() As Integer
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "proc_Test"
        cmd.Connection = sqlConnect
        If sqlConnect.State <> ConnectionState.Open Then
            sqlConnect.Open()
        End If
        cmd.Parameters.Add("@madvhc1", SqlDbType.Int)
        cmd.Parameters.Add("@madvhc2", SqlDbType.Int)
        cmd.Parameters.Add("@test", SqlDbType.Bit)
        cmd.Parameters("@test").Direction = ParameterDirection.Output

        Dim dem As Integer = 0
        Dim dem2 As Integer = 0
        Dim dem3 As Integer = 0
        Dim dem4 As Integer = 0
        ReDim arr(0)
        ReDim arrc1(0)
        ReDim arrc2(0)
        ReDim arrc3(0)
        For Each n As TreeNode In trvwDonViHanhChinh.Nodes
            If n.Checked = True Then
                dem2 = dem2 + 1
                ReDim Preserve arrc1(dem2)
                arrc1(dem2 - 1) = CInt(n.Name)
            End If
            For Each m As TreeNode In n.Nodes
                If m.Checked = True Then
                    dem3 = dem3 + 1
                    ReDim Preserve arrc2(dem3)
                    arrc2(dem3 - 1) = CInt(m.Name)
                End If
                For Each k As TreeNode In m.Nodes
                    If k.Checked = True Then
                        dem4 = dem4 + 1
                        ReDim Preserve arrc3(dem4)
                        arrc3(dem4 - 1) = CInt(k.Name)
                    End If
                Next
            Next
        Next

        If dem2 > 0 Then
            For i As Integer = 0 To dem2 - 1
                For j As Integer = 0 To UBound(arrMaDVHC) - 1
                    cmd.Parameters("@madvhc1").Value = arrMaDVHC(j)
                    cmd.Parameters("@madvhc2").Value = arrc1(i)
                    cmd.ExecuteNonQuery()
                    If cmd.Parameters("@test").Value Then
                        dem = dem + 1
                        ReDim Preserve arr(dem)
                        arr(dem - 1) = arrc1(i)
                    End If
                Next
            Next
        End If

        If dem3 > 0 Then
            For i As Integer = 0 To dem3 - 1
                For j As Integer = 0 To UBound(arrMaDVHC) - 1
                    cmd.Parameters("@madvhc1").Value = arrMaDVHC(j)
                    cmd.Parameters("@madvhc2").Value = arrc2(i)
                    cmd.ExecuteNonQuery()
                    If cmd.Parameters("@test").Value Then
                        Dim p() As TreeNode
                        p = trvwDonViHanhChinh.Nodes.Find(arrc2(i).ToString, True)
                        If dem > 0 Then
                            If KT(CInt(p(0).Parent.Name), arr) = False Then
                                dem = dem + 1
                                ReDim Preserve arr(dem)
                                arr(dem - 1) = arrc2(i)
                            End If
                        Else
                            dem = dem + 1
                            ReDim Preserve arr(dem)
                            arr(dem - 1) = arrc2(i)
                        End If
                    End If
                Next
            Next
        End If

        If dem4 > 0 Then
            For i As Integer = 0 To dem4 - 1
                For j As Integer = 0 To UBound(arrMaDVHC) - 1
                    cmd.Parameters("@madvhc1").Value = arrMaDVHC(j)
                    cmd.Parameters("@madvhc2").Value = arrc3(i)
                    cmd.ExecuteNonQuery()
                    If cmd.Parameters("@test").Value Then
                        Dim p() As TreeNode
                        p = trvwDonViHanhChinh.Nodes.Find(arrc3(i).ToString, True)
                        If dem > 0 Then
                            If KT(CInt(p(0).Parent.Name), arr) = False Then
                                If KT(CInt(p(0).Parent.Parent.Name), arr) = False Then
                                    dem = dem + 1
                                    ReDim Preserve arr(dem)
                                    arr(dem - 1) = arrc3(i)
                                End If
                            End If
                        Else
                            dem = dem + 1
                            ReDim Preserve arr(dem)
                            arr(dem - 1) = arrc3(i)
                        End If
                    End If
                Next
            Next
        End If

        If dem > 0 Then
            Return arr
        Else
            Return Nothing
        End If
        cmd.Dispose()
    End Function

    Public Function KT(ByVal k As Integer, ByVal arr() As Integer) As Boolean
        If Not arr Is Nothing Then
            For i As Integer = 0 To UBound(arr) - 1
                If k = arr(i) Then
                    Return True
                    Exit Function
                End If
            Next
            Return False
        Else
            Return False
        End If
    End Function


#End Region

#Region "Các thủ tục hỗ trợ SQl"
    Private Function AddParam(ByVal strArrParam As String, ByVal iNumber As Integer, ByRef sqlCmd As SqlCommand) As DataSet
        Dim strtemp(iNumber * 2) As String
        Dim dtDA As New SqlDataAdapter
        Dim dtds As New DataSet
        TachXau(strArrParam, strtemp)
        'Set our parm properties
        For i As Integer = 1 To iNumber * 2
            If i Mod 2 = 1 Then
                Dim oParam As New SqlClient.SqlParameter
                oParam = sqlCmd.CreateParameter()
                oParam.ParameterName = strtemp(i)
                oParam.Value = strtemp(i + 1)
                sqlCmd.Parameters.Add(oParam)
            End If
        Next
        sqlCmd.ExecuteNonQuery()
        dtDA.SelectCommand = sqlCmd
        dtDA.Fill(dtds, "result")
        Try
            If dtds.Tables("result").Rows.Count > 0 Then
                Return dtds
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub TachXau(ByVal FullString As String, ByRef SplitString() As String)
        Dim i As Integer, NumStr As Integer
        NumStr = 0
        i = 1
        Do
            Do While (Mid$(FullString, i, 1) = " ") Or (Mid$(FullString, i, 1) = ",") _
                                Or (Mid$(FullString, i, 1) = Chr(32)) Or (Mid$(FullString, i, 1) = ";") _
                                Or (Mid$(FullString, i, 1) = Chr(34)) Or (Mid$(FullString, i, 1) = Chr(9)) _
                                Or (Mid$(FullString, i, 1) = ":") _
                                And (i <= Len(FullString))
                i = i + 1
            Loop
            If i <= Len(FullString) Then
                NumStr = NumStr + 1
                ReDim Preserve SplitString(NumStr)
                SplitString(NumStr) = ""
            End If
            Do While (i <= Len(FullString)) And (Mid$(FullString, i, 1) <> " ") _
                And (Mid$(FullString, i, 1) <> ",") _
                And (Mid$(FullString, i, 1) <> Chr(32)) _
                And (Mid$(FullString, i, 1) <> ";") _
                And (Mid$(FullString, i, 1) <> Chr(34)) _
                And (Mid$(FullString, i, 1) <> Chr(9)) _
                And (Mid$(FullString, i, 1) <> ":")
                SplitString(NumStr) = SplitString(NumStr) + Mid$(FullString, i, 1)
                i = i + 1
            Loop
        Loop Until i > Len(FullString)
    End Sub
    Private Function Encrypt(ByVal mess As String) As String
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bs As Byte()
        bs = System.Text.Encoding.UTF8.GetBytes(mess)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower)
        Next
        Return s.ToString.ToUpper
    End Function
#End Region

#Region "Các thủ tục hiển thị"


    Private Sub HienThiThongTinLenGridview()
        If sqlConnect.State <> ConnectionState.Open Then
            sqlConnect.Open()
        End If
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim DTSet1 As New DataSet
        Dim DTSet2 As New DataSet
        Dim count As Integer = 0
        cmd1.Connection = sqlConnect
        cmd1.CommandType = CommandType.StoredProcedure
        cmd1.CommandText = "Proc_GetTuDienDonViHanhChinh"
        cmd2.Connection = sqlConnect
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.CommandText = "proc_GetChaConDVHC"
        If iMaQuyen = 1 Then
            'spUser truong hop flag=3

            Dim selFielduser() As String = {"maquyen", "MaUsers", "MatKhau", "NgayTaoUser", "TenDayDu", "ChucVu", "Phongban", "Diachi", "SoDienThoai", "TenDangNhap"}
            Dim SelValuesuser() As String = {iMaQuyen + 1, "", "", "", "", "", "", "", "", ""}
            Dim TableUser As New DataTable
            TableUser = MyDataTable("spUsers", 3, selFielduser, SelValuesuser)

            '' ''Dim strSQL As String = "select * from tblusers where maquyen=" & iMaQuyen + 1
            '' ''Dim cmd As New SqlCommand(strSQL, sqlConnect)
            '' ''Dim sqlAD As New SqlDataAdapter(cmd)
            '' ''cmd.ExecuteNonQuery()
            '' ''Dim ds As New DataSet
            '' ''sqlAD.Fill(ds, "result")
            If Not TableUser Is Nothing Then
                For j As Integer = 0 To TableUser.Rows.Count - 1
                    count = count + 1
                    grdvwThongTin.RowCount = count
                    grdvwThongTin.Item(0, count - 1).Value = TableUser.Rows(j).Item(1).ToString
                    grdvwThongTin.Item(1, count - 1).Value = TableUser.Rows(j).Item(4)
                    grdvwThongTin.Item(2, count - 1).Value = TableUser.Rows(j).Item(5).ToString
                    grdvwThongTin.Item(3, count - 1).Value = TableUser.Rows(j).Item(6).ToString
                    grdvwThongTin.Item(4, count - 1).Value = TableUser.Rows(j).Item(7).ToString
                    grdvwThongTin.Item(5, count - 1).Value = TableUser.Rows(j).Item(8).ToString
                    grdvwThongTin.Item(6, count - 1).Value = TableUser.Rows(j).Item(9).ToString
                    grdvwThongTin.Item(7, count - 1).Value = TableUser.Rows(j).Item(0).ToString
                Next
            End If
            '' ''cmd.Dispose()
        Else
            If Not arrMaDVHC Is Nothing Then
                grdvwThongTin.RowCount = 0
                For i As Integer = 0 To UBound(arrMaDVHC) - 1
                    DTSet1 = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmd1)
                    cmd1.Parameters.Clear()
                    Dim s As String
                    s = "@MaTinh," & DTSet1.Tables("result").Rows(0).Item(2).ToString & ",@Mahuyen," & DTSet1.Tables("result").Rows(0).Item(3).ToString & ",@maxa," & DTSet1.Tables("result").Rows(0).Item(4).ToString & ",@Maquyen," & iMaQuyen
                    DTSet2 = AddParam(s, 4, cmd2)
                    cmd2.Parameters.Clear()
                    If Not DTSet2 Is Nothing Then
                        For j As Integer = 0 To DTSet2.Tables("result").Rows.Count - 1
                            If test(grdvwThongTin, DTSet2.Tables("result").Rows(j).Item(1).ToString) = False Then
                                count = count + 1
                                grdvwThongTin.RowCount = count
                                grdvwThongTin.Item(0, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(1).ToString
                                grdvwThongTin.Item(1, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(4)
                                grdvwThongTin.Item(2, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(5).ToString
                                grdvwThongTin.Item(3, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(6).ToString
                                grdvwThongTin.Item(4, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(7).ToString
                                grdvwThongTin.Item(5, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(8).ToString
                                grdvwThongTin.Item(6, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(9).ToString
                                grdvwThongTin.Item(7, count - 1).Value = DTSet2.Tables("result").Rows(j).Item(0).ToString
                            End If
                        Next
                    End If
                Next
            End If
        End If
        cmd1.Dispose()
        cmd2.Dispose()
    End Sub

    Private Function test(ByVal gr As DataGridView, ByVal s As String) As Boolean
        Try
            Dim dem As Integer = 0
            For i As Integer = 0 To gr.RowCount - 1
                If gr.Item(0, i).Value.ToString = s Then
                    dem = dem + 1
                End If
            Next
            If dem > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub HienThiThongTin()
        HienThiThongTinLenGridview()
        HienthithongtinlenTextbox(0)
        HienThiThongTinLenTreeview()
        HienThiChucNang()
        'Try
        HienThiDonVi(grdvwThongTin.Item(7, 0).Value.ToString)
        HienThiChucNangNguoidung(grdvwThongTin.Item(7, 0).Value.ToString)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub HienthithongtinlenTextbox(ByVal i As Integer)
        Try
            If i >= 0 Then
                txtTenDangNhap.Text = grdvwThongTin.Item(0, i).Value
                If grdvwThongTin.Item(1, i).Value Is Nothing Then
                    dtpNgayTao.Value = Nothing
                Else
                    dtpNgayTao.Text = grdvwThongTin.Item(1, i).Value.ToString
                End If

                txtTendaydu.Text = grdvwThongTin.Item(2, i).Value
                txtChucVu.Text = grdvwThongTin.Item(3, i).Value
                txtPhongBan.Text = grdvwThongTin.Item(4, i).Value
                txtDiaChi.Text = grdvwThongTin.Item(5, i).Value
                txtSoDienThoai.Text = grdvwThongTin.Item(6, i).Value
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub HienThiThongTinLenTreeview()
        trvwDonViHanhChinh.CheckBoxes = True
        Dim cmdCha As New SqlCommand
        Dim cmdCon As New SqlCommand
        Dim cmdDulieu As New SqlCommand
        Dim cmdCap As New SqlCommand
        cmdCap.CommandType = CommandType.StoredProcedure
        cmdCap.CommandText = "Proc_Getcap"
        cmdCap.Connection = sqlConnect
        cmdDulieu.CommandType = CommandType.StoredProcedure
        cmdDulieu.CommandText = "Proc_GetTuDienDonViHanhChinh"
        cmdCha.CommandType = CommandType.StoredProcedure
        cmdCha.CommandText = "proc_LayDonViCha"
        cmdCon.CommandType = CommandType.StoredProcedure
        cmdCon.CommandText = "proc_LayDonViCon"
        cmdDulieu.Connection = sqlConnect
        cmdCha.Connection = sqlConnect
        cmdCon.Connection = sqlConnect

        Dim dsdulieu As New DataSet
        Dim dsCha As New DataSet
        Dim dsCon As New DataSet
        Dim dsCap1 As New DataSet
        Dim dsCap2 As New DataSet
        Dim dsCap3 As New DataSet
        Dim dem As Integer = 0

        'Người có quyền cao nhất
        If iMaQuyen = 1 Then
            dsCap1 = AddParam("@cap," & 1, 1, cmdCap)
            If Not dsCap1 Is Nothing Then
                For j As Integer = 0 To dsCap1.Tables("result").Rows.Count - 1
                    trvwDonViHanhChinh.Nodes.Add(dsCap1.Tables("result").Rows(j).Item(0), dsCap1.Tables("result").Rows(j).Item(1))
                    cmdCap.Parameters.Clear()
                    dsCap2 = AddParam("@MaDVHC," & dsCap1.Tables("result").Rows(j).Item(0), 1, cmdCon)
                    If Not dsCap2 Is Nothing Then
                        For k As Integer = 0 To dsCap2.Tables("result").Rows.Count - 1
                            trvwDonViHanhChinh.Nodes(dsCap1.Tables("result").Rows(j).Item(0).ToString).Nodes.Add(dsCap2.Tables("result").Rows(k).Item(0), dsCap2.Tables("result").Rows(k).Item(1))
                            cmdCon.Parameters.Clear()
                            dsCap3 = AddParam("@maDVHC," & dsCap2.Tables("result").Rows(k).Item(0), 1, cmdCon)
                            If Not dsCap3 Is Nothing Then
                                For h As Integer = 0 To dsCap3.Tables("result").Rows.Count - 1
                                    trvwDonViHanhChinh.Nodes(dsCap1.Tables("result").Rows(j).Item(0).ToString).Nodes(dsCap2.Tables("result").Rows(k).Item(0).ToString).Nodes.Add(dsCap3.Tables("result").Rows(h).Item(0), dsCap3.Tables("result").Rows(h).Item(1))
                                Next
                            End If
                            cmdCon.Parameters.Clear()
                        Next
                    End If
                    cmdCon.Parameters.Clear()
                Next
            End If

            'Khi ADMIN login
        ElseIf iMaQuyen = 2 Then
            cmdCap.CommandText = "proc_cap"
            'Duyệt tất cả các đơn vị Hành chính mà ADMIN quản lý
            For i As Integer = 0 To UBound(arrMaDVHC) - 1
                cmdCap.Parameters.Add("@MaDVHC", SqlDbType.Int)
                cmdCap.Parameters("@MaDVHC").Value = arrMaDVHC(i)
                cmdCap.Parameters.Add("@Cap", SqlDbType.Int)
                cmdCap.Parameters("@Cap").Direction = ParameterDirection.Output
                cmdCap.ExecuteNonQuery()

                'Nếu đơn vị quản lý thuộc cấp 1
                If cmdCap.Parameters("@Cap").Value = 1 Then
                    'Nếu đã tồn tại trên TreeView
                    If trvwDonViHanhChinh.Nodes.Find(arrMaDVHC(i), True).Length > 0 Then
                        trvwDonViHanhChinh.Nodes(arrMaDVHC(i).ToString).Checked = True
                        'Chưa tồn tại
                    Else
                        dsCap1 = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdDulieu)
                        If Not dsCap1 Is Nothing Then
                            trvwDonViHanhChinh.Nodes.Add(dsCap1.Tables("result").Rows(0).Item(0), dsCap1.Tables(0).Rows(0).Item(1))
                            dsCap2 = AddParam("@MaDVHC," & dsCap1.Tables("result").Rows(0).Item(0), 1, cmdCon)
                            If Not dsCap2 Is Nothing Then
                                For j As Integer = 0 To dsCap2.Tables("result").Rows.Count - 1
                                    trvwDonViHanhChinh.Nodes(dsCap1.Tables("result").Rows(0).Item(0).ToString).Nodes.Add(dsCap2.Tables("result").Rows(j).Item(0), dsCap2.Tables("result").Rows(j).Item(1))
                                    cmdCon.Parameters.Clear()
                                    dsCap3 = AddParam("@MaDVHC," & dsCap2.Tables("result").Rows(j).Item(0), 1, cmdCon)
                                    If Not dsCap3 Is Nothing Then
                                        For k As Integer = 0 To dsCap3.Tables("result").Rows.Count - 1
                                            trvwDonViHanhChinh.Nodes(dsCap1.Tables("result").Rows(0).Item(0).ToString).Nodes(dsCap2.Tables("result").Rows(j).Item(0).ToString).Nodes.Add(dsCap3.Tables("result").Rows(k).Item(0), dsCap3.Tables("result").Rows(k).Item(1))
                                        Next
                                    End If
                                Next
                            End If
                        End If
                        trvwDonViHanhChinh.Nodes(arrMaDVHC(i).ToString).Checked = True
                    End If
                    'Nếu đơn vị quản lý thuộc cấp 2
                ElseIf cmdCap.Parameters("@Cap").Value = 2 Then
                    cmdDulieu.Parameters.Clear()
                    dsdulieu = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdDulieu)
                    If trvwDonViHanhChinh.Nodes.Find(arrMaDVHC(i), True).Length > 0 Then

                    Else
                        cmdCha.Parameters.Clear()
                        dsCha = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdCha)
                        If Not dsCha Is Nothing Then
lb1:
                            If trvwDonViHanhChinh.Nodes.Find(dsCha.Tables(0).Rows(0).Item(0).ToString, True).Length > 0 Then
                                trvwDonViHanhChinh.Nodes(dsCha.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsdulieu.Tables(0).Rows(0).Item(0), dsdulieu.Tables(0).Rows(0).Item(1))
                                dsCap3 = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdCon)
                                If Not dsCap3 Is Nothing Then
                                    For j As Integer = 0 To dsCap3.Tables(0).Rows.Count - 1
                                        trvwDonViHanhChinh.Nodes(dsCha.Tables(0).Rows(0).Item(0).ToString).Nodes(arrMaDVHC(i).ToString).Nodes.Add(dsCap3.Tables(0).Rows(j).Item(0), dsCap3.Tables(0).Rows(j).Item(1))
                                    Next
                                End If
                                cmdCon.Parameters.Clear()
                            Else
                                trvwDonViHanhChinh.Nodes.Add(dsCha.Tables(0).Rows(0).Item(0), dsCha.Tables(0).Rows(0).Item(1))
                                GoTo lb1
                            End If
                        End If
                    End If

                    'Đơn vị hành chính cấp 3
                ElseIf cmdCap.Parameters("@Cap").Value = 3 Then
                    cmdDulieu.Parameters.Clear()
                    dsdulieu = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdDulieu)
                    If trvwDonViHanhChinh.Nodes.Find(arrMaDVHC(i), True).Length > 0 Then

                    Else
                        cmdCha.Parameters.Clear()
                        dsCap2 = AddParam("@MaDVHC," & arrMaDVHC(i), 1, cmdCha)
                        If Not dsCap2 Is Nothing Then
                            If trvwDonViHanhChinh.Nodes.Find(dsCap2.Tables(0).Rows(0).Item(0).ToString, True).Length > 0 Then
                                cmdCha.Parameters.Clear()
                                dsCap1 = AddParam("@MaDVHC," & dsCap2.Tables(0).Rows(0).Item(0), 1, cmdCha)
                                trvwDonViHanhChinh.Nodes(dsCap1.Tables(0).Rows(0).Item(0).ToString).Nodes(dsCap2.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsdulieu.Tables(0).Rows(0).Item(0), dsdulieu.Tables(0).Rows(0).Item(1))
                                cmdCon.Parameters.Clear()
                            Else
                                cmdCha.Parameters.Clear()
                                dsCap1 = AddParam("@MaDVHC," & dsCap2.Tables("result").Rows(0).Item(0), 1, cmdCha)
                                If Not dsCap1 Is Nothing Then
                                    If trvwDonViHanhChinh.Nodes.Find(dsCap1.Tables(0).Rows(0).Item(0).ToString, True).Length > 0 Then
                                        trvwDonViHanhChinh.Nodes(dsCap1.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsCap2.Tables(0).Rows(0).Item(0), dsCap2.Tables(0).Rows(0).Item(1))
                                        trvwDonViHanhChinh.Nodes(dsCap2.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsdulieu.Tables(0).Rows(0).Item(0), dsdulieu.Tables(0).Rows(0).Item(1))
                                    Else
                                        trvwDonViHanhChinh.Nodes.Add(dsCap1.Tables(0).Rows(0).Item(0), dsCap1.Tables(0).Rows(0).Item(1))
                                        trvwDonViHanhChinh.Nodes(dsCap1.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsCap2.Tables(0).Rows(0).Item(0), dsCap2.Tables(0).Rows(0).Item(1))
                                        trvwDonViHanhChinh.Nodes(dsCap1.Tables(0).Rows(0).Item(0).ToString).Nodes(dsCap2.Tables(0).Rows(0).Item(0).ToString).Nodes.Add(dsdulieu.Tables(0).Rows(0).Item(0), dsdulieu.Tables(0).Rows(0).Item(1))
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                cmdDulieu.Parameters.Clear()
                cmdCap.Parameters.Clear()
            Next
        End If
        cmdCap.Dispose()
        cmdDulieu.Dispose()
        cmdCha.Dispose()
        cmdCon.Dispose()

    End Sub

    Private Sub HienThiChucNang()
        'Dim cmd As New SqlCommand
        'Dim dtAP As New SqlDataAdapter
        'Dim dts As New DataSet
        If sqlConnect.State <> ConnectionState.Open Then
            sqlConnect.Open()
        End If
        ' ''cmd.Connection = sqlConnect
        ' ''Dim cmd1 As New SqlCommand("select * from tblgroupfunction", sqlConnect)
        ' ''cmd1.ExecuteNonQuery()
        ' ''dtAP.SelectCommand = cmd1
        ' ''dtAP.Fill(dts, "result1")
        Dim DataGroupt As New DataTable
        DataGroupt = MyDataTableNoField("spGroupFunction", 0)

        Try
            If DataGroupt.Rows.Count > 0 Then
            End If
        Catch ex As Exception
            DataGroupt = Nothing
        End Try

        If Not DataGroupt Is Nothing Then
            For j As Integer = 0 To DataGroupt.Rows.Count - 1
                trvwChucNang.Nodes.Add(DataGroupt.Rows(j).Item(0), DataGroupt.Rows(j).Item(1))
                'spTuDienChucNang voi Flag=0
                ' ''cmd.CommandText = "Select * from tbltudienchucnang where idGroup='" & dts.Tables("result1").Rows(j).Item(0).ToString & "'"
                ' ''cmd.ExecuteNonQuery()
                ' ''dtAP.SelectCommand = cmd
                Dim DataTa As New DataTable
                ' ''dtAP.Fill(ds, "Result")
                Dim Field() As String = {"IDGroup"}
                Dim Value() As String = {DataGroupt.Rows(j).Item(0).ToString}
                DataTa = MyDataTable("spTuDienChucNang", 0, Field, Value)
                If Not DataTa Is Nothing Then
                    If DataTa.Rows.Count > 0 Then
                        For i As Integer = 0 To DataTa.Rows.Count - 1
                            trvwChucNang.Nodes(DataGroupt.Rows(j).Item(0).ToString).Nodes.Add(DataTa.Rows(i).Item(0), DataTa.Rows(i).Item(1))
                        Next
                    End If
                End If
            Next
        End If
        '' ''cmd1.Dispose()
        '' ''cmd.Dispose()
    End Sub

    Private Sub trvwDonViHanhChinh_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvwDonViHanhChinh.AfterCheck
        If e.Action <> TreeViewAction.ByKeyboard And e.Action <> TreeViewAction.ByMouse Then
            Exit Sub
        End If
        CheckChildren(e.Node, e.Node.Checked)
        CheckParent(e.Node)
    End Sub

    Private Sub CheckChildren(ByVal parentNode As TreeNode, ByVal check As Boolean)
        Dim node As TreeNode
        For Each node In parentNode.Nodes
            node.Checked = check
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                Me.CheckChildren(node, check)
            End If
        Next node

    End Sub

    Private Sub CheckParent(ByVal e As TreeNode)
        Dim blnUncheck As Boolean = False
        If Not e.Parent Is Nothing Then
            For Each child As TreeNode In e.Parent.Nodes
                If child.Checked = False Then
                    blnUncheck = True
                End If
            Next
            If blnUncheck = False Then
                e.Parent.Checked = True
            Else
                e.Parent.Checked = False
            End If
            Me.CheckParent(e.Parent)
        End If
    End Sub
    'Để hiển thị khi click vào treeview
    Private Sub HienThiDonVi(ByVal Manguoidung As String)
        Try
            'spUserStatus voi flag=4
            Dim selFieldUserStatus() As String = {"mausers", "madonvihanhchinh", "NgayPhanQuyen", "TenDangNhap"}
            Dim selValuesUserStatus() As String = {Manguoidung, "", "", "", ""}
            Dim TableUserStatus As New DataTable
            TableUserStatus = MyDataTable("spUserStatus", 4, selFieldUserStatus, selValuesUserStatus)

            '' ''Dim cmd As New SqlCommand("select * from tbluserstatus where mauser='" & Manguoidung & "' ", sqlConnect)
            '' ''Dim sqlda As New SqlDataAdapter(cmd)
            '' ''Dim ds As New DataSet
            '' ''sqlda.Fill(ds, "result")
            Try
                If TableUserStatus.Rows.Count > 0 Then
                End If
            Catch ex As Exception
                TableUserStatus = Nothing
            End Try
            trvwDonViHanhChinh.CollapseAll()
            For Each n As TreeNode In trvwDonViHanhChinh.Nodes
                If n.Checked = True Then
                    n.Checked = False
                End If
                For Each m As TreeNode In n.Nodes
                    If m.Checked = True Then
                        m.Checked = False
                    End If
                    For Each p As TreeNode In m.Nodes
                        If p.Checked = True Then
                            p.Checked = False
                        End If
                    Next
                Next
            Next
            If Not TableUserStatus Is Nothing Then
                For i As Integer = 0 To TableUserStatus.Rows.Count - 1
                    Dim n() As TreeNode
                    n = trvwDonViHanhChinh.Nodes.Find(TableUserStatus.Rows(i).Item(2).ToString, True)
                    If n.Length > 0 Then
                        n(0).Checked = True
                        CheckChildren(n(0), n(0).Checked)
                        CheckParent(n(0))
                        Dim dd As New TreeNode
                        dd = n(0).Parent
                        If Not dd Is Nothing Then
                            dd.Expand()
                            Dim d As New TreeNode
                            d = dd.Parent
                            If Not d Is Nothing Then
                                d.Expand()
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            trvwDonViHanhChinh.CollapseAll()
            For Each n As TreeNode In trvwDonViHanhChinh.Nodes
                If n.Checked = True Then
                    n.Checked = False
                End If
                For Each m As TreeNode In n.Nodes
                    If m.Checked = True Then
                        m.Checked = False
                    End If
                    For Each p As TreeNode In m.Nodes
                        If p.Checked = True Then
                            p.Checked = False
                        End If
                    Next
                Next
            Next
        End Try
    End Sub
    Private Sub HienThiChucNangNguoidung(ByVal Manguoidung As String)
        Try
            'spUseChucNang truong hop flag=5
            Dim selFielduserChucnang() As String = {"mausers", "madonvihanhchinh", "NgayPhanQuyen", "TenDangNhap"}
            Dim selValuesuserChucnang() As String = {Manguoidung, "", "", "", ""}
            Dim TableUserChucnang As New DataTable
            TableUserChucnang = MyDataTable("spUserStatus", 5, selFielduserChucnang, selValuesuserChucnang)

            '' ''Dim cmd As New SqlCommand("select * from tbluserchucnang where umauser='" & Manguoidung & "' ", sqlConnect)
            '' ''Dim sqlda As New SqlDataAdapter(cmd)
            '' ''Dim ds As New DataSet
            '' ''sqlda.Fill(ds, "result")
            Try
                If TableUserChucnang.Rows.Count > 0 Then
                End If
            Catch ex As Exception
                TableUserChucnang = Nothing
            End Try
            trvwChucNang.ExpandAll()
            For Each n As TreeNode In trvwChucNang.Nodes
                If n.Checked = True Then
                    n.Checked = False
                End If
                For Each m As TreeNode In n.Nodes
                    If m.Checked = True Then
                        m.Checked = False
                    End If
                Next
            Next
            If Not TableUserChucnang Is Nothing Then
                For i As Integer = 0 To TableUserChucnang.Rows.Count - 1
                    Dim n() As TreeNode
                    n = trvwChucNang.Nodes.Find(TableUserChucnang.Rows(i).Item(2).ToString, True)
                    If n.Length > 0 Then
                        n(0).Checked = True
                    End If
                Next
            End If
        Catch ex As Exception
            trvwChucNang.CollapseAll()
            For Each n As TreeNode In trvwChucNang.Nodes
                If n.Checked = True Then
                    n.Checked = False
                End If
            Next
        End Try
    End Sub

#End Region

#Region "Lấy thuộc tính"
    Public Property Get_sqlConnect() As SqlConnection
        Get
            Return sqlConnect
        End Get
        Set(ByVal value As SqlConnection)
            sqlConnect = value
        End Set
    End Property
    Public Property Get_Maquyen() As Integer
        Get
            Return iMaQuyen
        End Get
        Set(ByVal value As Integer)
            iMaQuyen = value
        End Set
    End Property
    Public Property Get_arrMaDVHC() As Integer()
        Get
            Return arrMaDVHC
        End Get
        Set(ByVal value As Integer())
            arrMaDVHC = value
        End Set
    End Property
#End Region

    Private Sub ucPhanQuyen_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        sqlConnect.Close()
    End Sub

    Private Sub trvwChucNang_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvwChucNang.AfterCheck
        If e.Action <> TreeViewAction.ByKeyboard And e.Action <> TreeViewAction.ByMouse Then
            Exit Sub
        End If
        CheckChildren(e.Node, e.Node.Checked)
        CheckParent(e.Node)
    End Sub

    'tra ve mot bagn du lieu
    Public Function MyDataTable(ByVal Sp As String, ByVal flag As Integer, ByVal fieldName() As String, ByVal values() As String) As DataTable
        Dim cmd As New SqlCommand
        Dim datAdap As New SqlDataAdapter
        Dim ds As New DataSet
        Dim myParameter As New SqlParameter

        Try
            With cmd
                .Connection = sqlConnect
                .CommandText = Sp
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@flag", SqlDbType.Int))
                .Parameters("@flag").Value = flag
                For i As Integer = 0 To fieldName.Count - 1
                    .Parameters.Add(New SqlParameter("@" & fieldName(i) & "", SqlDbType.NVarChar, 50))
                    If values(i) = "" Then
                        .Parameters("@" & fieldName(i) & "").Value = DBNull.Value
                    Else
                        .Parameters("@" & fieldName(i) & "").Value = values(i)
                    End If

                Next
            End With
            datAdap.SelectCommand = cmd
            datAdap.Fill(ds)

        Catch ex As Exception
            MessageBox.Show("Lỗi : " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds.Tables(0)
    End Function

    'truogn hop khogn truyen bien 
    Public Function MyDataTableNoField(ByVal Sp As String, ByVal flag As Integer) As DataTable
        Dim cmd As New SqlCommand
        Dim datAdap As New SqlDataAdapter
        Dim ds As New DataSet
        Dim myParameter As New SqlParameter

        Try
            With cmd
                .Connection = sqlConnect
                .CommandText = Sp
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@flag", SqlDbType.Int))
                .Parameters("@flag").Value = flag
            End With
            datAdap.SelectCommand = cmd
            datAdap.Fill(ds)

        Catch ex As Exception
            MessageBox.Show("Lỗi : " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds.Tables(0)
    End Function
    'truogn hop ThucThi cau lenh
    Public Sub MyExecute(ByVal Sp As String, ByVal flag As Integer, ByVal fieldName() As String, ByVal values() As String)
        Dim cmd As New SqlCommand
        Dim datAdap As New SqlDataAdapter
        Dim ds As New DataSet
        Dim myParameter As New SqlParameter
        Try
            With cmd
                .Connection = sqlConnect
                .CommandText = Sp
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@flag", SqlDbType.Int))
                .Parameters("@flag").Value = flag
                For i As Integer = 0 To fieldName.Count - 1
                    .Parameters.Add(New SqlParameter("@" & fieldName(i) & "", SqlDbType.NVarChar, 50))
                    If values(i) = "" Then
                        .Parameters("@" & fieldName(i) & "").Value = DBNull.Value
                    Else
                        .Parameters("@" & fieldName(i) & "").Value = values(i)
                    End If
                Next

            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Lỗi : " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub grdvwThongTin_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdvwThongTin.CellContentClick
        Try
            HienthithongtinlenTextbox(e.RowIndex)
            HienThiDonVi(grdvwThongTin.Item(7, e.RowIndex).Value.ToString)
            HienThiChucNangNguoidung(grdvwThongTin.Item(7, e.RowIndex).Value.ToString)
        Catch ex As Exception

        End Try
    End Sub
End Class

