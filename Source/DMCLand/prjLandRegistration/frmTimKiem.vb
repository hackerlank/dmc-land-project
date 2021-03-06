Imports DMC.Land.TimKiem
Imports System.Data.SqlClient
Public Class frmTimKiem
    Private connection As String = ""
    Private blnXacNhanKetQuaTimKiem As Boolean = False
    Public Property XacNhanKetQuaTimKiem() As Boolean
        Get
            Return blnXacNhanKetQuaTimKiem
        End Get
        Set(ByVal value As Boolean)
            blnXacNhanKetQuaTimKiem = value
        End Set
    End Property
    Private Sub btnHoSo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoSo.Click
        UpdateData()
        blnXacNhanKetQuaTimKiem = True
        Me.Hide()
    End Sub
    Public Sub UpdateData()
        Try
            Dim MaHoSoCapGCN As String = "0"
            Dim ToBanDo As String = ""
            Dim SoThua As String = ""
            Dim DienTich As String = ""
            Dim DiaChiDat As String = ""
            Dim MaThuaDat As String = ""
            Dim MaDonViHanhChinh As String = ""
            With Me.CrtTimKiemHoSoThuaDat1
                MaHoSoCapGCN = .MaHoSoCapGCN
                ToBanDo = .ToBanDo
                SoThua = .SoThua
                DienTich = .DienTich
                DiaChiDat = .DiaChiThua
                MaThuaDat = .MaThuaDat
                MaDonViHanhChinh = .MaDonViHanhChinh
            End With
            connection = GetConnection(bolKetNoiCSDL)
            Dim con As New SqlConnection(connection)
            Dim Cmd As New SqlCommand("spInsert10ThuaDatMoiThaoTac", con)
            Cmd.CommandType = CommandType.StoredProcedure
            Dim Para As New SqlParameter
            Para = Cmd.Parameters.Add("MaHoSoCapGCN", SqlDbType.BigInt)
            Para.Value = Integer.Parse(MaHoSoCapGCN)
            Para = Cmd.Parameters.Add("ToBanDo", SqlDbType.NVarChar, 20)
            Para.Value = ToBanDo
            Para = Cmd.Parameters.Add("SoThua", SqlDbType.NVarChar, 10)
            Para.Value = SoThua
            Para = Cmd.Parameters.Add("DienTich", SqlDbType.Float)
            Para.Value = Double.Parse(DienTich)
            Para = Cmd.Parameters.Add("DiaChiDat", SqlDbType.NVarChar, 500)
            Para.Value = DiaChiDat
            Para = Cmd.Parameters.Add("MaThuaDat", SqlDbType.NVarChar, 20)
            If MaThuaDat = "" Then
                Para.Value = Integer.Parse(0)
            Else
                Para.Value = Integer.Parse(MaThuaDat)
            End If
            Para = Cmd.Parameters.Add("MaDonViHanhChinh", SqlDbType.Int)
            Para.Value = Integer.Parse(MaDonViHanhChinh)
            con.Open()
            Cmd.ExecuteNonQuery()
            con.Close()
        Catch
        End Try

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        blnXacNhanKetQuaTimKiem = False
        Me.Hide()
    End Sub

    Private Sub btnBienDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBienDong.Click
        Me.Hide()
    End Sub

    Private Sub btnBanDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanDo.Click
        'Dim strConnect As String = ""
        'Dim strDatabaseName As String = ""
        'Dim strServerName As String = ""
        'strDatabaseName = "DMCLand2009"
        'strServerName = "dmcthanh"
        'Try
        '    strConnect = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & strDatabaseName & ";Data Source=" & strServerName
        '    Me.Hide()
        '    Gfunction.Data.ConnectServer(strConnect)
        '    Gfunction.Data.SelectPhuong("THANHLUONG")
        '    With frmBanDoTongThe
        '        .AxProlandMapinfo1.OpenDesktop("{A3498E4C-D75C-4114-86B4-00D85675B8CE}", "", "")
        '        .Show()
        '        .WindowState = FormWindowState.Maximized
        '    End With
        'Catch ex As Exception
        '    MsgBox("Mở bản đồ thửa đất" & vbNewLine & "Lỗi" & vbNewLine & ex.Message, MsgBoxStyle.Information, "DMCLand")
        'End Try
        frmMain.HienThiBaoDo()
    End Sub

    Private Sub CtrlTimKiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdXoaHS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXoaHS.Click
        If User.MaQuyen > 2 Then
            MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else


            Try
                With Me.CrtTimKiemHoSoThuaDat1
                    If .MaHoSoCapGCN <> "" Then
                        If InputBox("Nhập chuỗi xác nhận xóa hồ sơ", "DMCLand") = "dungcomotoinoi" Then
                            Dim MaDonViHanhChinh As String = ""
                            Dim MaHoSoCapGCN As String = "0"

                            MaHoSoCapGCN = .MaHoSoCapGCN
                            MaDonViHanhChinh = .MaDonViHanhChinh

                            connection = GetConnection(bolKetNoiCSDL)
                            Dim con As New SqlConnection(connection)
                            Dim Cmd As New SqlCommand("spXoaVinhVienHoSo", con)
                            Cmd.CommandType = CommandType.StoredProcedure
                            Dim Para As New SqlParameter
                            Para = Cmd.Parameters.Add("MaHoSoCapGCN", SqlDbType.BigInt)
                            Para.Value = Integer.Parse(MaHoSoCapGCN)

                            'Para = Cmd.Parameters.Add("MaDonViHanhChinh", SqlDbType.Int)
                            'Para.Value = Integer.Parse(MaDonViHanhChinh)

                            con.Open()
                            Cmd.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Xóa hồ sơ " & Me.CrtTimKiemHoSoThuaDat1.MaHoSoCapGCN & " thành công !", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Chuỗi xác nhận không đúng...., Xóa hồ sơ " & Me.CrtTimKiemHoSoThuaDat1.MaHoSoCapGCN & " chưa thành công !", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    End If
                End With
            Catch ex As Exception
                MessageBox.Show("Lỗi xóa hồ sơ !", "DMCLand", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If


    End Sub


    Private Sub CrtTimKiemHoSoThuaDat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmTimKiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class
