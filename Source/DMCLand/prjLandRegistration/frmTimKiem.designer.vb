Imports DMC.Land.TimKiem
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBienDong = New System.Windows.Forms.Button
        Me.btnHoSo = New System.Windows.Forms.Button
        Me.btnBanDo = New System.Windows.Forms.Button
        Me.btnThoat = New System.Windows.Forms.Button
        Me.cmdXoaHS = New System.Windows.Forms.Button
        Me.CrtTimKiemHoSoThuaDat1 = New DMC.Land.TimKiem.crtTimKiemHoSoThuaDat
        Me.SuspendLayout()
        '
        'btnBienDong
        '
        Me.btnBienDong.Location = New System.Drawing.Point(472, 516)
        Me.btnBienDong.Name = "btnBienDong"
        Me.btnBienDong.Size = New System.Drawing.Size(64, 23)
        Me.btnBienDong.TabIndex = 2
        Me.btnBienDong.Text = "Biến động"
        Me.btnBienDong.UseVisualStyleBackColor = True
        Me.btnBienDong.Visible = False
        '
        'btnHoSo
        '
        Me.btnHoSo.Location = New System.Drawing.Point(612, 516)
        Me.btnHoSo.Name = "btnHoSo"
        Me.btnHoSo.Size = New System.Drawing.Size(64, 23)
        Me.btnHoSo.TabIndex = 4
        Me.btnHoSo.Text = "Hồ sơ"
        Me.btnHoSo.UseVisualStyleBackColor = True
        '
        'btnBanDo
        '
        Me.btnBanDo.Location = New System.Drawing.Point(542, 516)
        Me.btnBanDo.Name = "btnBanDo"
        Me.btnBanDo.Size = New System.Drawing.Size(64, 23)
        Me.btnBanDo.TabIndex = 3
        Me.btnBanDo.Text = "Bản đồ"
        Me.btnBanDo.UseVisualStyleBackColor = True
        Me.btnBanDo.Visible = False
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(682, 516)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(64, 23)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'cmdXoaHS
        '
        Me.cmdXoaHS.Location = New System.Drawing.Point(12, 516)
        Me.cmdXoaHS.Name = "cmdXoaHS"
        Me.cmdXoaHS.Size = New System.Drawing.Size(64, 23)
        Me.cmdXoaHS.TabIndex = 1
        Me.cmdXoaHS.Text = "Xóa HS"
        Me.cmdXoaHS.UseVisualStyleBackColor = True
        '
        'CrtTimKiemHoSoThuaDat1
        '
        Me.CrtTimKiemHoSoThuaDat1.BackColor = System.Drawing.Color.Lavender
        Me.CrtTimKiemHoSoThuaDat1.CanhBaoTranhChap = ""
        Me.CrtTimKiemHoSoThuaDat1.ChuChuyenNhuong = Nothing
        Me.CrtTimKiemHoSoThuaDat1.ChuSuDung = ""
        Me.CrtTimKiemHoSoThuaDat1.DiaChiThua = ""
        Me.CrtTimKiemHoSoThuaDat1.DienTich = ""
        Me.CrtTimKiemHoSoThuaDat1.Location = New System.Drawing.Point(-2, 2)
        Me.CrtTimKiemHoSoThuaDat1.MaDonViHanhChinh = ""
        Me.CrtTimKiemHoSoThuaDat1.NamCapGCN = ""
        Me.CrtTimKiemHoSoThuaDat1.Name = "CrtTimKiemHoSoThuaDat1"
        Me.CrtTimKiemHoSoThuaDat1.NgayLapToTrinh = ""
        Me.CrtTimKiemHoSoThuaDat1.Size = New System.Drawing.Size(840, 508)
        Me.CrtTimKiemHoSoThuaDat1.SoDinhDanh = ""
        Me.CrtTimKiemHoSoThuaDat1.SoThua = ""
        Me.CrtTimKiemHoSoThuaDat1.TabIndex = 0
        Me.CrtTimKiemHoSoThuaDat1.TenBangBanDo = Nothing
        Me.CrtTimKiemHoSoThuaDat1.ToBanDo = ""
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(839, 551)
        Me.Controls.Add(Me.CrtTimKiemHoSoThuaDat1)
        Me.Controls.Add(Me.cmdXoaHS)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnBienDong)
        Me.Controls.Add(Me.btnHoSo)
        Me.Controls.Add(Me.btnBanDo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTimKiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tim kiem"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBienDong As System.Windows.Forms.Button
    Friend WithEvents btnHoSo As System.Windows.Forms.Button
    Friend WithEvents btnBanDo As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents cmdXoaHS As System.Windows.Forms.Button
    Friend WithEvents CrtTimKiemHoSoThuaDat1 As DMC.Land.TimKiem.crtTimKiemHoSoThuaDat
End Class
