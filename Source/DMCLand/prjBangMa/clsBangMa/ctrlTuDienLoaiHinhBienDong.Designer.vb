﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTuDienLoaiHinhBienDong
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnHuyLenh = New System.Windows.Forms.Button
        Me.btnSua = New System.Windows.Forms.Button
        Me.grdvwBangMa = New DMC.[Interface].GridView.ctrlGridView
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBangMaMoTa = New System.Windows.Forms.TextBox
        Me.txtBangMaKyHieu = New System.Windows.Forms.TextBox
        Me.txtNoiDungGhiSo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.grdvwBangMa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHuyLenh
        '
        Me.btnHuyLenh.Location = New System.Drawing.Point(246, 359)
        Me.btnHuyLenh.Name = "btnHuyLenh"
        Me.btnHuyLenh.Size = New System.Drawing.Size(58, 21)
        Me.btnHuyLenh.TabIndex = 5
        Me.btnHuyLenh.Text = "Hủy lệnh"
        Me.btnHuyLenh.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(66, 359)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(58, 21)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'grdvwBangMa
        '
        Me.grdvwBangMa.AllowUserToAddRows = False
        Me.grdvwBangMa.AllowUserToDeleteRows = False
        Me.grdvwBangMa.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwBangMa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvwBangMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwBangMa.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdvwBangMa.Location = New System.Drawing.Point(5, 4)
        Me.grdvwBangMa.MultiSelect = False
        Me.grdvwBangMa.Name = "grdvwBangMa"
        Me.grdvwBangMa.ReadOnly = True
        Me.grdvwBangMa.RowHeadersVisible = False
        Me.grdvwBangMa.RowHeadersWidth = 25
        Me.grdvwBangMa.Size = New System.Drawing.Size(563, 165)
        Me.grdvwBangMa.TabIndex = 40
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(184, 359)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(58, 21)
        Me.btnGhi.TabIndex = 4
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(126, 359)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(58, 21)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(6, 359)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 21)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Mô tả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Tên:"
        '
        'txtBangMaMoTa
        '
        Me.txtBangMaMoTa.Location = New System.Drawing.Point(6, 245)
        Me.txtBangMaMoTa.Multiline = True
        Me.txtBangMaMoTa.Name = "txtBangMaMoTa"
        Me.txtBangMaMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBangMaMoTa.Size = New System.Drawing.Size(564, 45)
        Me.txtBangMaMoTa.TabIndex = 42
        '
        'txtBangMaKyHieu
        '
        Me.txtBangMaKyHieu.Location = New System.Drawing.Point(7, 187)
        Me.txtBangMaKyHieu.Multiline = True
        Me.txtBangMaKyHieu.Name = "txtBangMaKyHieu"
        Me.txtBangMaKyHieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBangMaKyHieu.Size = New System.Drawing.Size(564, 39)
        Me.txtBangMaKyHieu.TabIndex = 41
        '
        'txtNoiDungGhiSo
        '
        Me.txtNoiDungGhiSo.Location = New System.Drawing.Point(5, 309)
        Me.txtNoiDungGhiSo.Multiline = True
        Me.txtNoiDungGhiSo.Name = "txtNoiDungGhiSo"
        Me.txtNoiDungGhiSo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoiDungGhiSo.Size = New System.Drawing.Size(564, 45)
        Me.txtNoiDungGhiSo.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nội dung ghi sổ"
        '
        'ctrlTuDienLoaiHinhBienDong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNoiDungGhiSo)
        Me.Controls.Add(Me.btnHuyLenh)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.grdvwBangMa)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBangMaMoTa)
        Me.Controls.Add(Me.txtBangMaKyHieu)
        Me.Name = "ctrlTuDienLoaiHinhBienDong"
        Me.Size = New System.Drawing.Size(573, 390)
        CType(Me.grdvwBangMa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHuyLenh As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents grdvwBangMa As DMC.Interface.GridView.ctrlGridView
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBangMaMoTa As System.Windows.Forms.TextBox
    Friend WithEvents txtBangMaKyHieu As System.Windows.Forms.TextBox
    Friend WithEvents txtNoiDungGhiSo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
