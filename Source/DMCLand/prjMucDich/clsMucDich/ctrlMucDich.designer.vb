Imports DMC.Interface.GridView
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlMucDich
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnSua = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnCapNhat = New System.Windows.Forms.Button
        Me.btnHuyLenh = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtChiTiet = New System.Windows.Forms.TextBox
        Me.btnMaQuiHoach = New System.Windows.Forms.Button
        Me.btnMaKiemKe = New System.Windows.Forms.Button
        Me.btnMaMucDich = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.numDienTichChung = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.numDienTichRieng = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaQuiHoach = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMaKiemKe = New System.Windows.Forms.TextBox
        Me.txtThoiHan = New System.Windows.Forms.TextBox
        Me.grdvwMucDich = New DMC.[Interface].GridView.ctrlGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMaMucDich = New System.Windows.Forms.TextBox
        Me.numDienTichKeKhai = New System.Windows.Forms.NumericUpDown
        Me.txtGhiChu = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnTroGiup = New System.Windows.Forms.Button
        Me.chkTongHopMucDich = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.numDienTichChung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDienTichRieng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwMucDich, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDienTichKeKhai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(6, 280)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 21)
        Me.btnThem.TabIndex = 14
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(65, 280)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(58, 21)
        Me.btnSua.TabIndex = 15
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(124, 280)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(58, 21)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(183, 280)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(58, 21)
        Me.btnCapNhat.TabIndex = 17
        Me.btnCapNhat.Text = "Ghi"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnHuyLenh
        '
        Me.btnHuyLenh.Location = New System.Drawing.Point(242, 280)
        Me.btnHuyLenh.Name = "btnHuyLenh"
        Me.btnHuyLenh.Size = New System.Drawing.Size(58, 21)
        Me.btnHuyLenh.TabIndex = 18
        Me.btnHuyLenh.Text = "Hủy lệnh"
        Me.btnHuyLenh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtChiTiet)
        Me.GroupBox1.Controls.Add(Me.btnMaQuiHoach)
        Me.GroupBox1.Controls.Add(Me.btnMaKiemKe)
        Me.GroupBox1.Controls.Add(Me.btnMaMucDich)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.numDienTichChung)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.numDienTichRieng)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaQuiHoach)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMaKiemKe)
        Me.GroupBox1.Controls.Add(Me.txtThoiHan)
        Me.GroupBox1.Controls.Add(Me.grdvwMucDich)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMaMucDich)
        Me.GroupBox1.Controls.Add(Me.numDienTichKeKhai)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 258)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "MĐSD chi tiết"
        '
        'txtChiTiet
        '
        Me.txtChiTiet.Location = New System.Drawing.Point(108, 39)
        Me.txtChiTiet.Name = "txtChiTiet"
        Me.txtChiTiet.Size = New System.Drawing.Size(563, 20)
        Me.txtChiTiet.TabIndex = 7
        '
        'btnMaQuiHoach
        '
        Me.btnMaQuiHoach.Location = New System.Drawing.Point(646, 12)
        Me.btnMaQuiHoach.Name = "btnMaQuiHoach"
        Me.btnMaQuiHoach.Size = New System.Drawing.Size(24, 21)
        Me.btnMaQuiHoach.TabIndex = 6
        Me.btnMaQuiHoach.Text = "..."
        Me.btnMaQuiHoach.UseVisualStyleBackColor = True
        '
        'btnMaKiemKe
        '
        Me.btnMaKiemKe.Location = New System.Drawing.Point(428, 12)
        Me.btnMaKiemKe.Name = "btnMaKiemKe"
        Me.btnMaKiemKe.Size = New System.Drawing.Size(24, 21)
        Me.btnMaKiemKe.TabIndex = 4
        Me.btnMaKiemKe.Text = "..."
        Me.btnMaKiemKe.UseVisualStyleBackColor = True
        '
        'btnMaMucDich
        '
        Me.btnMaMucDich.Location = New System.Drawing.Point(200, 11)
        Me.btnMaMucDich.Name = "btnMaMucDich"
        Me.btnMaMucDich.Size = New System.Drawing.Size(24, 21)
        Me.btnMaMucDich.TabIndex = 2
        Me.btnMaMucDich.Text = "..."
        Me.btnMaMucDich.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(649, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "(m2)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(458, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Diện tích Chung"
        '
        'numDienTichChung
        '
        Me.numDienTichChung.DecimalPlaces = 2
        Me.numDienTichChung.Location = New System.Drawing.Point(551, 72)
        Me.numDienTichChung.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichChung.Name = "numDienTichChung"
        Me.numDienTichChung.Size = New System.Drawing.Size(92, 20)
        Me.numDienTichChung.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(429, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "(m2)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(240, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Diện tích Riêng"
        '
        'numDienTichRieng
        '
        Me.numDienTichRieng.DecimalPlaces = 2
        Me.numDienTichRieng.Location = New System.Drawing.Point(335, 71)
        Me.numDienTichRieng.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichRieng.Name = "numDienTichRieng"
        Me.numDienTichRieng.Size = New System.Drawing.Size(90, 20)
        Me.numDienTichRieng.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(210, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "(m2)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "MĐSD qui hoạch"
        '
        'txtMaQuiHoach
        '
        Me.txtMaQuiHoach.Location = New System.Drawing.Point(551, 12)
        Me.txtMaQuiHoach.Name = "txtMaQuiHoach"
        Me.txtMaQuiHoach.Size = New System.Drawing.Size(92, 20)
        Me.txtMaQuiHoach.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "MĐSD kiểm kê"
        '
        'txtMaKiemKe
        '
        Me.txtMaKiemKe.Location = New System.Drawing.Point(334, 12)
        Me.txtMaKiemKe.Name = "txtMaKiemKe"
        Me.txtMaKiemKe.Size = New System.Drawing.Size(92, 20)
        Me.txtMaKiemKe.TabIndex = 3
        '
        'txtThoiHan
        '
        Me.txtThoiHan.Location = New System.Drawing.Point(107, 94)
        Me.txtThoiHan.Name = "txtThoiHan"
        Me.txtThoiHan.Size = New System.Drawing.Size(563, 20)
        Me.txtThoiHan.TabIndex = 11
        '
        'grdvwMucDich
        '
        Me.grdvwMucDich.AllowUserToAddRows = False
        Me.grdvwMucDich.AllowUserToDeleteRows = False
        Me.grdvwMucDich.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvwMucDich.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwMucDich.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grdvwMucDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwMucDich.DefaultCellStyle = DataGridViewCellStyle18
        Me.grdvwMucDich.Location = New System.Drawing.Point(12, 146)
        Me.grdvwMucDich.Name = "grdvwMucDich"
        Me.grdvwMucDich.ReadOnly = True
        Me.grdvwMucDich.RowHeadersWidth = 25
        Me.grdvwMucDich.Size = New System.Drawing.Size(663, 106)
        Me.grdvwMucDich.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Diện tích kê khai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "MĐSD trên GCN"
        '
        'txtMaMucDich
        '
        Me.txtMaMucDich.Location = New System.Drawing.Point(107, 10)
        Me.txtMaMucDich.Name = "txtMaMucDich"
        Me.txtMaMucDich.Size = New System.Drawing.Size(92, 20)
        Me.txtMaMucDich.TabIndex = 1
        '
        'numDienTichKeKhai
        '
        Me.numDienTichKeKhai.DecimalPlaces = 2
        Me.numDienTichKeKhai.Location = New System.Drawing.Point(107, 68)
        Me.numDienTichKeKhai.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichKeKhai.Name = "numDienTichKeKhai"
        Me.numDienTichKeKhai.Size = New System.Drawing.Size(90, 20)
        Me.numDienTichKeKhai.TabIndex = 8
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhiChu.Location = New System.Drawing.Point(107, 120)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(563, 20)
        Me.txtGhiChu.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Ghi chú mục đích"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Thời hạn"
        '
        'btnTroGiup
        '
        Me.btnTroGiup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTroGiup.Location = New System.Drawing.Point(621, 279)
        Me.btnTroGiup.Name = "btnTroGiup"
        Me.btnTroGiup.Size = New System.Drawing.Size(58, 21)
        Me.btnTroGiup.TabIndex = 19
        Me.btnTroGiup.Text = "Trợ giúp"
        Me.btnTroGiup.UseVisualStyleBackColor = True
        '
        'chkTongHopMucDich
        '
        Me.chkTongHopMucDich.AutoSize = True
        Me.chkTongHopMucDich.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTongHopMucDich.ForeColor = System.Drawing.Color.Red
        Me.chkTongHopMucDich.Location = New System.Drawing.Point(6, 3)
        Me.chkTongHopMucDich.Name = "chkTongHopMucDich"
        Me.chkTongHopMucDich.Size = New System.Drawing.Size(321, 20)
        Me.chkTongHopMucDich.TabIndex = 0
        Me.chkTongHopMucDich.Text = "Tổng hợp thông tin Mục đích sử dụng ghi trên GCN"
        Me.chkTongHopMucDich.UseVisualStyleBackColor = True
        '
        'ctrlMucDich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.chkTongHopMucDich)
        Me.Controls.Add(Me.btnTroGiup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuyLenh)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "ctrlMucDich"
        Me.Size = New System.Drawing.Size(686, 305)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numDienTichChung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDienTichRieng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwMucDich, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDienTichKeKhai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnHuyLenh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents txtMaMucDich As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTroGiup As System.Windows.Forms.Button
    Friend WithEvents numDienTichKeKhai As System.Windows.Forms.NumericUpDown
    Friend WithEvents grdvwMucDich As ctrlGridView
    Friend WithEvents txtThoiHan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaQuiHoach As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaKiemKe As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numDienTichChung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numDienTichRieng As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnMaMucDich As System.Windows.Forms.Button
    Friend WithEvents btnMaQuiHoach As System.Windows.Forms.Button
    Friend WithEvents btnMaKiemKe As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtChiTiet As System.Windows.Forms.TextBox
    Friend WithEvents chkTongHopMucDich As System.Windows.Forms.CheckBox

End Class
