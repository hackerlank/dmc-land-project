Imports DMC.Interface.GridView

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTimKiem
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtDiaChiDat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtToBanDo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSoThua = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtHoSoTiepNhanSo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTrangThaiHoSo = New System.Windows.Forms.ComboBox
        Me.txtSoThuTuTiepNhan = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtDinhDanh = New System.Windows.Forms.TextBox
        Me.txtTenChu = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtToTrinh = New System.Windows.Forms.TextBox
        Me.txtNamCapGCN = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNamTrinh = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSoPhatHanhGCN = New System.Windows.Forms.TextBox
        Me.txtSoQuyetDinhCapGCN = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSoVaoSoGCN = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnTimMoi = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdvwTacNghiep = New DMC.[Interface].GridView.ctrlGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdvwTimKiem = New DMC.[Interface].GridView.ctrlGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdvwTacNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdvwTimKiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.btnTimKiem)
        Me.GroupBox2.Controls.Add(Me.btnTimMoi)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 213)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Điều kiện tìm kiếm"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtDiaChiDat)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.txtToBanDo)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.txtSoThua)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Location = New System.Drawing.Point(4, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(625, 36)
        Me.GroupBox7.TabIndex = 37
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Thông tin thửa đất"
        '
        'txtDiaChiDat
        '
        Me.txtDiaChiDat.Location = New System.Drawing.Point(395, 13)
        Me.txtDiaChiDat.Name = "txtDiaChiDat"
        Me.txtDiaChiDat.Size = New System.Drawing.Size(224, 20)
        Me.txtDiaChiDat.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Địa chỉ"
        '
        'txtToBanDo
        '
        Me.txtToBanDo.Location = New System.Drawing.Point(97, 13)
        Me.txtToBanDo.Name = "txtToBanDo"
        Me.txtToBanDo.Size = New System.Drawing.Size(90, 20)
        Me.txtToBanDo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tờ bản đồ"
        '
        'txtSoThua
        '
        Me.txtSoThua.Location = New System.Drawing.Point(248, 13)
        Me.txtSoThua.Name = "txtSoThua"
        Me.txtSoThua.Size = New System.Drawing.Size(85, 20)
        Me.txtSoThua.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Số thửa"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtHoSoTiepNhanSo)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.cmbTrangThaiHoSo)
        Me.GroupBox6.Controls.Add(Me.txtSoThuTuTiepNhan)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 54)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(624, 38)
        Me.GroupBox6.TabIndex = 36
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Thông tin Hồ sơ"
        '
        'txtHoSoTiepNhanSo
        '
        Me.txtHoSoTiepNhanSo.Location = New System.Drawing.Point(324, 12)
        Me.txtHoSoTiepNhanSo.Name = "txtHoSoTiepNhanSo"
        Me.txtHoSoTiepNhanSo.Size = New System.Drawing.Size(105, 20)
        Me.txtHoSoTiepNhanSo.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(430, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Số thứ tự tiếp nhận"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hồ sơ tiếp nhận số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Trạng thái hồ sơ"
        '
        'cmbTrangThaiHoSo
        '
        Me.cmbTrangThaiHoSo.FormattingEnabled = True
        Me.cmbTrangThaiHoSo.Items.AddRange(New Object() {"Tất cả", "Hồ sơ kê khai", "Thẩm định", "Phê duyệt", "Cấp GCN", "Mới tạo", "Thửa không đủ điều kiện", "Thửa đã biến động"})
        Me.cmbTrangThaiHoSo.Location = New System.Drawing.Point(96, 12)
        Me.cmbTrangThaiHoSo.Name = "cmbTrangThaiHoSo"
        Me.cmbTrangThaiHoSo.Size = New System.Drawing.Size(123, 21)
        Me.cmbTrangThaiHoSo.TabIndex = 3
        '
        'txtSoThuTuTiepNhan
        '
        Me.txtSoThuTuTiepNhan.Location = New System.Drawing.Point(532, 12)
        Me.txtSoThuTuTiepNhan.Name = "txtSoThuTuTiepNhan"
        Me.txtSoThuTuTiepNhan.Size = New System.Drawing.Size(86, 20)
        Me.txtSoThuTuTiepNhan.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDinhDanh)
        Me.GroupBox5.Controls.Add(Me.txtTenChu)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 95)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(627, 38)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Thông tin chủ sử dụng"
        '
        'txtDinhDanh
        '
        Me.txtDinhDanh.Location = New System.Drawing.Point(522, 12)
        Me.txtDinhDanh.Name = "txtDinhDanh"
        Me.txtDinhDanh.Size = New System.Drawing.Size(101, 20)
        Me.txtDinhDanh.TabIndex = 7
        '
        'txtTenChu
        '
        Me.txtTenChu.Location = New System.Drawing.Point(117, 14)
        Me.txtTenChu.Name = "txtTenChu"
        Me.txtTenChu.Size = New System.Drawing.Size(302, 20)
        Me.txtTenChu.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Tên chủ sử dụng đất"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 12)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "CMTND (HC, GPKD)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtToTrinh)
        Me.GroupBox4.Controls.Add(Me.txtNamCapGCN)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtNamTrinh)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtSoPhatHanhGCN)
        Me.GroupBox4.Controls.Add(Me.txtSoQuyetDinhCapGCN)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtSoVaoSoGCN)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(624, 71)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin cấp GCN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(421, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Năm cấp GCN"
        '
        'txtToTrinh
        '
        Me.txtToTrinh.Location = New System.Drawing.Point(114, 39)
        Me.txtToTrinh.Name = "txtToTrinh"
        Me.txtToTrinh.Size = New System.Drawing.Size(107, 20)
        Me.txtToTrinh.TabIndex = 11
        '
        'txtNamCapGCN
        '
        Me.txtNamCapGCN.Location = New System.Drawing.Point(521, 39)
        Me.txtNamCapGCN.Name = "txtNamCapGCN"
        Me.txtNamCapGCN.Size = New System.Drawing.Size(99, 20)
        Me.txtNamCapGCN.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Tờ trình"
        '
        'txtNamTrinh
        '
        Me.txtNamTrinh.Location = New System.Drawing.Point(311, 39)
        Me.txtNamTrinh.Name = "txtNamTrinh"
        Me.txtNamTrinh.Size = New System.Drawing.Size(105, 20)
        Me.txtNamTrinh.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Năm trình"
        '
        'txtSoPhatHanhGCN
        '
        Me.txtSoPhatHanhGCN.Location = New System.Drawing.Point(114, 13)
        Me.txtSoPhatHanhGCN.Name = "txtSoPhatHanhGCN"
        Me.txtSoPhatHanhGCN.Size = New System.Drawing.Size(107, 20)
        Me.txtSoPhatHanhGCN.TabIndex = 8
        '
        'txtSoQuyetDinhCapGCN
        '
        Me.txtSoQuyetDinhCapGCN.Location = New System.Drawing.Point(521, 13)
        Me.txtSoQuyetDinhCapGCN.Name = "txtSoQuyetDinhCapGCN"
        Me.txtSoQuyetDinhCapGCN.Size = New System.Drawing.Size(99, 20)
        Me.txtSoQuyetDinhCapGCN.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Sô phát hành GCN"
        '
        'txtSoVaoSoGCN
        '
        Me.txtSoVaoSoGCN.Location = New System.Drawing.Point(311, 13)
        Me.txtSoVaoSoGCN.Name = "txtSoVaoSoGCN"
        Me.txtSoVaoSoGCN.Size = New System.Drawing.Size(105, 20)
        Me.txtSoVaoSoGCN.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Số vào sổ GCN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Số quyết định cấp"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(644, 184)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(57, 23)
        Me.btnTimKiem.TabIndex = 14
        Me.btnTimKiem.Text = "Tìm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnTimMoi
        '
        Me.btnTimMoi.Location = New System.Drawing.Point(644, 26)
        Me.btnTimMoi.Name = "btnTimMoi"
        Me.btnTimMoi.Size = New System.Drawing.Size(57, 23)
        Me.btnTimMoi.TabIndex = 15
        Me.btnTimMoi.Text = "Tìm mới"
        Me.btnTimMoi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.grdvwTacNghiep)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 367)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 102)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thửa đất cần tác nghiệp"
        '
        'grdvwTacNghiep
        '
        Me.grdvwTacNghiep.AllowUserToAddRows = False
        Me.grdvwTacNghiep.AllowUserToDeleteRows = False
        Me.grdvwTacNghiep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvwTacNghiep.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwTacNghiep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvwTacNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwTacNghiep.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdvwTacNghiep.Location = New System.Drawing.Point(3, 16)
        Me.grdvwTacNghiep.Name = "grdvwTacNghiep"
        Me.grdvwTacNghiep.ReadOnly = True
        Me.grdvwTacNghiep.RowHeadersVisible = False
        Me.grdvwTacNghiep.RowHeadersWidth = 25
        Me.grdvwTacNghiep.Size = New System.Drawing.Size(706, 83)
        Me.grdvwTacNghiep.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdvwTimKiem)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 139)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách thửa tìm được"
        '
        'grdvwTimKiem
        '
        Me.grdvwTimKiem.AllowUserToAddRows = False
        Me.grdvwTimKiem.AllowUserToDeleteRows = False
        Me.grdvwTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvwTimKiem.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwTimKiem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdvwTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwTimKiem.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdvwTimKiem.Location = New System.Drawing.Point(2, 19)
        Me.grdvwTimKiem.Name = "grdvwTimKiem"
        Me.grdvwTimKiem.ReadOnly = True
        Me.grdvwTimKiem.RowHeadersVisible = False
        Me.grdvwTimKiem.RowHeadersWidth = 25
        Me.grdvwTimKiem.Size = New System.Drawing.Size(707, 114)
        Me.grdvwTimKiem.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "TT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tờ bản đồ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Số thửa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tên chủ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Định danh"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tờ bản đồ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Số thửa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tên chủ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 500
        '
        'ctrlTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ctrlTimKiem"
        Me.Size = New System.Drawing.Size(716, 472)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdvwTacNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdvwTimKiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnTimMoi As System.Windows.Forms.Button
    Friend WithEvents cmbTrangThaiHoSo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtToBanDo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSoThua As System.Windows.Forms.TextBox
    Friend WithEvents txtDinhDanh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTenChu As System.Windows.Forms.TextBox
    Friend WithEvents txtSoPhatHanhGCN As System.Windows.Forms.TextBox
    Friend WithEvents txtSoThuTuTiepNhan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSoVaoSoGCN As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtHoSoTiepNhanSo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSoQuyetDinhCapGCN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents grdvwTacNghiep As ctrlGridView
    Friend WithEvents grdvwTimKiem As ctrlGridView
    Friend WithEvents txtDiaChiDat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtToTrinh As System.Windows.Forms.TextBox
    Friend WithEvents txtNamCapGCN As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNamTrinh As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
