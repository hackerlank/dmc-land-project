Imports DMC.Interface.GridView
Imports DMC.Land.ChuSoHuuTaiSan
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlHangMucCongTrinh
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnTroGiup = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.GroupThongtinkekhaitaisan = New System.Windows.Forms.GroupBox
        Me.txtCongSuat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtThoiHanSoHuu = New System.Windows.Forms.TextBox
        Me.numSoTang = New System.Windows.Forms.NumericUpDown
        Me.numDienTichXayDung = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.numNamXayDung = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbCapHang = New System.Windows.Forms.ComboBox
        Me.txtTenHangMucCongTrinh = New System.Windows.Forms.TextBox
        Me.txtKetCau = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdvwHangMucCongTrinh = New DMC.[Interface].GridView.ctrlGridView
        Me.btnSua = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnHuyLenh = New System.Windows.Forms.Button
        Me.btnCapNhat = New System.Windows.Forms.Button
        Me.GroupThongtinkekhaitaisan.SuspendLayout()
        CType(Me.numSoTang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDienTichXayDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNamXayDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwHangMucCongTrinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTroGiup
        '
        Me.btnTroGiup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTroGiup.Location = New System.Drawing.Point(673, 270)
        Me.btnTroGiup.Name = "btnTroGiup"
        Me.btnTroGiup.Size = New System.Drawing.Size(63, 21)
        Me.btnTroGiup.TabIndex = 21
        Me.btnTroGiup.Text = "Trợ giúp"
        Me.btnTroGiup.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(129, 270)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(58, 21)
        Me.btnXoa.TabIndex = 18
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'GroupThongtinkekhaitaisan
        '
        Me.GroupThongtinkekhaitaisan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.txtCongSuat)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label4)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.txtThoiHanSoHuu)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.numSoTang)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.numDienTichXayDung)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label14)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.numNamXayDung)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label13)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.cmbCapHang)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.txtTenHangMucCongTrinh)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.txtKetCau)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label11)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label9)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label7)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label6)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label2)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.Label1)
        Me.GroupThongtinkekhaitaisan.Controls.Add(Me.grdvwHangMucCongTrinh)
        Me.GroupThongtinkekhaitaisan.Location = New System.Drawing.Point(3, 3)
        Me.GroupThongtinkekhaitaisan.Name = "GroupThongtinkekhaitaisan"
        Me.GroupThongtinkekhaitaisan.Size = New System.Drawing.Size(743, 261)
        Me.GroupThongtinkekhaitaisan.TabIndex = 1
        Me.GroupThongtinkekhaitaisan.TabStop = False
        '
        'txtCongSuat
        '
        Me.txtCongSuat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCongSuat.Location = New System.Drawing.Point(426, 42)
        Me.txtCongSuat.Name = "txtCongSuat"
        Me.txtCongSuat.Size = New System.Drawing.Size(309, 20)
        Me.txtCongSuat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(243, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "(m2)"
        '
        'txtThoiHanSoHuu
        '
        Me.txtThoiHanSoHuu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtThoiHanSoHuu.Location = New System.Drawing.Point(136, 122)
        Me.txtThoiHanSoHuu.Name = "txtThoiHanSoHuu"
        Me.txtThoiHanSoHuu.Size = New System.Drawing.Size(596, 20)
        Me.txtThoiHanSoHuu.TabIndex = 15
        '
        'numSoTang
        '
        Me.numSoTang.Location = New System.Drawing.Point(348, 95)
        Me.numSoTang.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numSoTang.Name = "numSoTang"
        Me.numSoTang.Size = New System.Drawing.Size(90, 20)
        Me.numSoTang.TabIndex = 11
        '
        'numDienTichXayDung
        '
        Me.numDienTichXayDung.DecimalPlaces = 2
        Me.numDienTichXayDung.Location = New System.Drawing.Point(136, 43)
        Me.numDienTichXayDung.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichXayDung.Name = "numDienTichXayDung"
        Me.numDienTichXayDung.Size = New System.Drawing.Size(101, 20)
        Me.numDienTichXayDung.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Thời hạn sở hữu"
        '
        'numNamXayDung
        '
        Me.numNamXayDung.Location = New System.Drawing.Point(551, 94)
        Me.numNamXayDung.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.numNamXayDung.Minimum = New Decimal(New Integer() {1800, 0, 0, 0})
        Me.numNamXayDung.Name = "numNamXayDung"
        Me.numNamXayDung.Size = New System.Drawing.Size(52, 20)
        Me.numNamXayDung.TabIndex = 13
        Me.numNamXayDung.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(500, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Năm XD"
        '
        'cmbCapHang
        '
        Me.cmbCapHang.FormattingEnabled = True
        Me.cmbCapHang.Items.AddRange(New Object() {"IV", "III", "II", "I"})
        Me.cmbCapHang.Location = New System.Drawing.Point(136, 95)
        Me.cmbCapHang.Name = "cmbCapHang"
        Me.cmbCapHang.Size = New System.Drawing.Size(101, 21)
        Me.cmbCapHang.TabIndex = 9
        '
        'txtTenHangMucCongTrinh
        '
        Me.txtTenHangMucCongTrinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenHangMucCongTrinh.Location = New System.Drawing.Point(136, 13)
        Me.txtTenHangMucCongTrinh.Multiline = True
        Me.txtTenHangMucCongTrinh.Name = "txtTenHangMucCongTrinh"
        Me.txtTenHangMucCongTrinh.Size = New System.Drawing.Size(599, 20)
        Me.txtTenHangMucCongTrinh.TabIndex = 1
        '
        'txtKetCau
        '
        Me.txtKetCau.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKetCau.Location = New System.Drawing.Point(136, 69)
        Me.txtKetCau.Name = "txtKetCau"
        Me.txtKetCau.Size = New System.Drawing.Size(599, 20)
        Me.txtKetCau.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(79, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Kết cấu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Diện tích XD (chiếm đất)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Diện tích sàn XD (Công suất)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tên hạng mục công trình"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Số tầng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cấp (hạng)"
        '
        'grdvwHangMucCongTrinh
        '
        Me.grdvwHangMucCongTrinh.AllowUserToAddRows = False
        Me.grdvwHangMucCongTrinh.AllowUserToDeleteRows = False
        Me.grdvwHangMucCongTrinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvwHangMucCongTrinh.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwHangMucCongTrinh.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvwHangMucCongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwHangMucCongTrinh.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdvwHangMucCongTrinh.Location = New System.Drawing.Point(8, 159)
        Me.grdvwHangMucCongTrinh.Name = "grdvwHangMucCongTrinh"
        Me.grdvwHangMucCongTrinh.ReadOnly = True
        Me.grdvwHangMucCongTrinh.RowHeadersWidth = 25
        Me.grdvwHangMucCongTrinh.Size = New System.Drawing.Size(728, 97)
        Me.grdvwHangMucCongTrinh.TabIndex = 22
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(68, 270)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(58, 21)
        Me.btnSua.TabIndex = 17
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(7, 270)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 21)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnHuyLenh
        '
        Me.btnHuyLenh.Location = New System.Drawing.Point(252, 270)
        Me.btnHuyLenh.Name = "btnHuyLenh"
        Me.btnHuyLenh.Size = New System.Drawing.Size(58, 21)
        Me.btnHuyLenh.TabIndex = 20
        Me.btnHuyLenh.Text = "Hủy lệnh"
        Me.btnHuyLenh.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(190, 270)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(58, 21)
        Me.btnCapNhat.TabIndex = 19
        Me.btnCapNhat.Text = "Ghi"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'ctrlHangMucCongTrinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.btnHuyLenh)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.GroupThongtinkekhaitaisan)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTroGiup)
        Me.Name = "ctrlHangMucCongTrinh"
        Me.Size = New System.Drawing.Size(751, 293)
        Me.GroupThongtinkekhaitaisan.ResumeLayout(False)
        Me.GroupThongtinkekhaitaisan.PerformLayout()
        CType(Me.numSoTang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDienTichXayDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNamXayDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwHangMucCongTrinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTroGiup As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents grdvwHangMucCongTrinh As ctrlGridView
    Friend WithEvents GroupThongtinkekhaitaisan As System.Windows.Forms.GroupBox
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtThoiHanSoHuu As System.Windows.Forms.TextBox
    Friend WithEvents numSoTang As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDienTichXayDung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numNamXayDung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbCapHang As System.Windows.Forms.ComboBox
    Friend WithEvents txtTenHangMucCongTrinh As System.Windows.Forms.TextBox
    Friend WithEvents txtKetCau As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHuyLenh As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents txtCongSuat As System.Windows.Forms.TextBox

End Class
