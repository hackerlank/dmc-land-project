<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongTinThuaKeKhai
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
        Me.btnThem = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.numDienTichChung = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.numDienTichRieng = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtDT20GiaDat = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtDT40GiaDat = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtDT50GiaDat = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtDT100GiaDat = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtNoiDungHoSo = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtTTNCN = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtLPTB = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCachDuongChinh = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNgoRong = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtViTri = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtLoaiDuong = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtGhiChu = New System.Windows.Forms.TextBox
        Me.btnDienTichBangChu = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtLyDoKhongCap = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDienTichKhongCapBangChu = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.numDienTichKhongCap = New System.Windows.Forms.NumericUpDown
        Me.btnNguonGocChiTiet = New System.Windows.Forms.Button
        Me.btnMucDichChiTiet = New System.Windows.Forms.Button
        Me.txtMucDichSuDung = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDienTichBangChu = New System.Windows.Forms.TextBox
        Me.grdvw = New DMC.[Interface].GridView.ctrlGridView
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSoThua = New System.Windows.Forms.TextBox
        Me.txtThoiHanSuDung = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtToBanDo = New System.Windows.Forms.TextBox
        Me.numDienTich = New System.Windows.Forms.NumericUpDown
        Me.txtNguonGocSuDung = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSua = New System.Windows.Forms.Button
        Me.btnHuyLenh = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnCapNhat = New System.Windows.Forms.Button
        Me.btnTroGiup = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.numDienTichChung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDienTichRieng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numDienTichKhongCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDienTich, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(9, 14)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 21)
        Me.btnThem.TabIndex = 27
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(219, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Diện tích Chung (m2)"
        '
        'numDienTichChung
        '
        Me.numDienTichChung.DecimalPlaces = 2
        Me.numDienTichChung.Location = New System.Drawing.Point(335, 100)
        Me.numDienTichChung.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichChung.Name = "numDienTichChung"
        Me.numDienTichChung.Size = New System.Drawing.Size(92, 20)
        Me.numDienTichChung.TabIndex = 8
        Me.numDienTichChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Diện tích Riêng (m2)"
        '
        'numDienTichRieng
        '
        Me.numDienTichRieng.DecimalPlaces = 2
        Me.numDienTichRieng.Location = New System.Drawing.Point(117, 99)
        Me.numDienTichRieng.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichRieng.Name = "numDienTichRieng"
        Me.numDienTichRieng.Size = New System.Drawing.Size(90, 20)
        Me.numDienTichRieng.TabIndex = 7
        Me.numDienTichRieng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Địa chỉ thửa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtDT20GiaDat)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtDT40GiaDat)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtDT50GiaDat)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtDT100GiaDat)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtNoiDungHoSo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTTNCN)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtLPTB)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCachDuongChinh)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtNgoRong)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtViTri)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtLoaiDuong)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.btnDienTichBangChu)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnNguonGocChiTiet)
        Me.GroupBox1.Controls.Add(Me.btnMucDichChiTiet)
        Me.GroupBox1.Controls.Add(Me.txtMucDichSuDung)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDienTichBangChu)
        Me.GroupBox1.Controls.Add(Me.grdvw)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.numDienTichChung)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.numDienTichRieng)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSoThua)
        Me.GroupBox1.Controls.Add(Me.txtThoiHanSuDung)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtToBanDo)
        Me.GroupBox1.Controls.Add(Me.numDienTich)
        Me.GroupBox1.Controls.Add(Me.txtNguonGocSuDung)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 441)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(540, 280)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 13)
        Me.Label25.TabIndex = 97
        Me.Label25.Text = "20% giá đất(m2)"
        '
        'txtDT20GiaDat
        '
        Me.txtDT20GiaDat.Location = New System.Drawing.Point(634, 277)
        Me.txtDT20GiaDat.Name = "txtDT20GiaDat"
        Me.txtDT20GiaDat.Size = New System.Drawing.Size(73, 20)
        Me.txtDT20GiaDat.TabIndex = 24
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(541, 257)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "40% giá đất(m2)"
        '
        'txtDT40GiaDat
        '
        Me.txtDT40GiaDat.Location = New System.Drawing.Point(635, 254)
        Me.txtDT40GiaDat.Name = "txtDT40GiaDat"
        Me.txtDT40GiaDat.Size = New System.Drawing.Size(73, 20)
        Me.txtDT40GiaDat.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(540, 234)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 13)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "50% giá đất(m2)"
        '
        'txtDT50GiaDat
        '
        Me.txtDT50GiaDat.Location = New System.Drawing.Point(635, 231)
        Me.txtDT50GiaDat.Name = "txtDT50GiaDat"
        Me.txtDT50GiaDat.Size = New System.Drawing.Size(73, 20)
        Me.txtDT50GiaDat.TabIndex = 19
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(540, 208)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 13)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "100% giá đất(m2)"
        '
        'txtDT100GiaDat
        '
        Me.txtDT100GiaDat.Location = New System.Drawing.Point(635, 205)
        Me.txtDT100GiaDat.Name = "txtDT100GiaDat"
        Me.txtDT100GiaDat.Size = New System.Drawing.Size(73, 20)
        Me.txtDT100GiaDat.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(30, 280)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Nội dung hồ sơ"
        '
        'txtNoiDungHoSo
        '
        Me.txtNoiDungHoSo.Location = New System.Drawing.Point(117, 277)
        Me.txtNoiDungHoSo.Name = "txtNoiDungHoSo"
        Me.txtNoiDungHoSo.Size = New System.Drawing.Size(364, 20)
        Me.txtNoiDungHoSo.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(327, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "TTNCN (m2)"
        '
        'txtTTNCN
        '
        Me.txtTTNCN.Location = New System.Drawing.Point(397, 254)
        Me.txtTTNCN.Name = "txtTTNCN"
        Me.txtTTNCN.Size = New System.Drawing.Size(84, 20)
        Me.txtTTNCN.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(53, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "LPTB (m2)"
        '
        'txtLPTB
        '
        Me.txtLPTB.Location = New System.Drawing.Point(117, 252)
        Me.txtLPTB.Name = "txtLPTB"
        Me.txtLPTB.Size = New System.Drawing.Size(89, 20)
        Me.txtLPTB.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(280, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Cách đường chính (m)"
        '
        'txtCachDuongChinh
        '
        Me.txtCachDuongChinh.Location = New System.Drawing.Point(397, 231)
        Me.txtCachDuongChinh.Name = "txtCachDuongChinh"
        Me.txtCachDuongChinh.Size = New System.Drawing.Size(84, 20)
        Me.txtCachDuongChinh.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(326, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Ngõ rộng (m)"
        '
        'txtNgoRong
        '
        Me.txtNgoRong.Location = New System.Drawing.Point(397, 205)
        Me.txtNgoRong.Name = "txtNgoRong"
        Me.txtNgoRong.Size = New System.Drawing.Size(84, 20)
        Me.txtNgoRong.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(81, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Vị trí"
        '
        'txtViTri
        '
        Me.txtViTri.Location = New System.Drawing.Point(116, 229)
        Me.txtViTri.Name = "txtViTri"
        Me.txtViTri.Size = New System.Drawing.Size(129, 20)
        Me.txtViTri.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Loại đường"
        '
        'txtLoaiDuong
        '
        Me.txtLoaiDuong.Location = New System.Drawing.Point(116, 205)
        Me.txtLoaiDuong.Name = "txtLoaiDuong"
        Me.txtLoaiDuong.Size = New System.Drawing.Size(129, 20)
        Me.txtLoaiDuong.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(63, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Ghi chú:"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhiChu.Location = New System.Drawing.Point(117, 301)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(591, 41)
        Me.txtGhiChu.TabIndex = 25
        '
        'btnDienTichBangChu
        '
        Me.btnDienTichBangChu.Location = New System.Drawing.Point(335, 66)
        Me.btnDienTichBangChu.Name = "btnDienTichBangChu"
        Me.btnDienTichBangChu.Size = New System.Drawing.Size(27, 21)
        Me.btnDienTichBangChu.TabIndex = 6
        Me.btnDienTichBangChu.Text = ">>"
        Me.btnDienTichBangChu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtLyDoKhongCap)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDienTichKhongCapBangChu)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.numDienTichKhongCap)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(687, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 67)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Phần diện tích không cấp"
        Me.GroupBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(45, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Lý do:"
        '
        'txtLyDoKhongCap
        '
        Me.txtLyDoKhongCap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLyDoKhongCap.Location = New System.Drawing.Point(104, 43)
        Me.txtLyDoKhongCap.Name = "txtLyDoKhongCap"
        Me.txtLyDoKhongCap.Size = New System.Drawing.Size(584, 20)
        Me.txtLyDoKhongCap.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(203, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Diện tích bằng chữ"
        '
        'txtDienTichKhongCapBangChu
        '
        Me.txtDienTichKhongCapBangChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDienTichKhongCapBangChu.Location = New System.Drawing.Point(310, 16)
        Me.txtDienTichKhongCapBangChu.Name = "txtDienTichKhongCapBangChu"
        Me.txtDienTichKhongCapBangChu.Size = New System.Drawing.Size(379, 20)
        Me.txtDienTichKhongCapBangChu.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(11, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Diện tích (m2)"
        '
        'numDienTichKhongCap
        '
        Me.numDienTichKhongCap.DecimalPlaces = 1
        Me.numDienTichKhongCap.Location = New System.Drawing.Point(104, 17)
        Me.numDienTichKhongCap.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTichKhongCap.Name = "numDienTichKhongCap"
        Me.numDienTichKhongCap.Size = New System.Drawing.Size(90, 20)
        Me.numDienTichKhongCap.TabIndex = 13
        '
        'btnNguonGocChiTiet
        '
        Me.btnNguonGocChiTiet.Location = New System.Drawing.Point(608, 179)
        Me.btnNguonGocChiTiet.Name = "btnNguonGocChiTiet"
        Me.btnNguonGocChiTiet.Size = New System.Drawing.Size(60, 21)
        Me.btnNguonGocChiTiet.TabIndex = 13
        Me.btnNguonGocChiTiet.Text = "Chi tiết"
        Me.btnNguonGocChiTiet.UseVisualStyleBackColor = True
        '
        'btnMucDichChiTiet
        '
        Me.btnMucDichChiTiet.Location = New System.Drawing.Point(608, 154)
        Me.btnMucDichChiTiet.Name = "btnMucDichChiTiet"
        Me.btnMucDichChiTiet.Size = New System.Drawing.Size(60, 21)
        Me.btnMucDichChiTiet.TabIndex = 11
        Me.btnMucDichChiTiet.Text = "Chi tiết"
        Me.btnMucDichChiTiet.UseVisualStyleBackColor = True
        '
        'txtMucDichSuDung
        '
        Me.txtMucDichSuDung.Location = New System.Drawing.Point(116, 154)
        Me.txtMucDichSuDung.Name = "txtMucDichSuDung"
        Me.txtMucDichSuDung.Size = New System.Drawing.Size(486, 20)
        Me.txtMucDichSuDung.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Mục đích sử dụng"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(228, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Diện tích bằng chữ"
        '
        'txtDienTichBangChu
        '
        Me.txtDienTichBangChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDienTichBangChu.Location = New System.Drawing.Point(368, 66)
        Me.txtDienTichBangChu.Name = "txtDienTichBangChu"
        Me.txtDienTichBangChu.Size = New System.Drawing.Size(340, 20)
        Me.txtDienTichBangChu.TabIndex = 5
        '
        'grdvw
        '
        Me.grdvw.AllowUserToAddRows = False
        Me.grdvw.AllowUserToDeleteRows = False
        Me.grdvw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvw.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvw.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdvw.Location = New System.Drawing.Point(6, 348)
        Me.grdvw.Name = "grdvw"
        Me.grdvw.ReadOnly = True
        Me.grdvw.RowHeadersWidth = 25
        Me.grdvw.Size = New System.Drawing.Size(701, 87)
        Me.grdvw.TabIndex = 26
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(116, 41)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(592, 20)
        Me.txtDiaChi.TabIndex = 3
        Me.txtDiaChi.Text = "Phường Long Biên, Quận Long Biên, Tp Hà Nội"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Số thửa"
        '
        'txtSoThua
        '
        Me.txtSoThua.Location = New System.Drawing.Point(116, 14)
        Me.txtSoThua.Name = "txtSoThua"
        Me.txtSoThua.Size = New System.Drawing.Size(92, 20)
        Me.txtSoThua.TabIndex = 1
        '
        'txtThoiHanSuDung
        '
        Me.txtThoiHanSuDung.Location = New System.Drawing.Point(117, 125)
        Me.txtThoiHanSuDung.Name = "txtThoiHanSuDung"
        Me.txtThoiHanSuDung.Size = New System.Drawing.Size(553, 20)
        Me.txtThoiHanSuDung.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Diện tích (m2)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tờ bản đồ"
        '
        'txtToBanDo
        '
        Me.txtToBanDo.Location = New System.Drawing.Point(335, 14)
        Me.txtToBanDo.Name = "txtToBanDo"
        Me.txtToBanDo.Size = New System.Drawing.Size(92, 20)
        Me.txtToBanDo.TabIndex = 2
        '
        'numDienTich
        '
        Me.numDienTich.DecimalPlaces = 2
        Me.numDienTich.Location = New System.Drawing.Point(116, 67)
        Me.numDienTich.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numDienTich.Name = "numDienTich"
        Me.numDienTich.Size = New System.Drawing.Size(90, 20)
        Me.numDienTich.TabIndex = 4
        Me.numDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNguonGocSuDung
        '
        Me.txtNguonGocSuDung.Location = New System.Drawing.Point(116, 180)
        Me.txtNguonGocSuDung.Name = "txtNguonGocSuDung"
        Me.txtNguonGocSuDung.Size = New System.Drawing.Size(486, 20)
        Me.txtNguonGocSuDung.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nguồn gốc sử dụng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Thời hạn sử dụng"
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(68, 14)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(58, 21)
        Me.btnSua.TabIndex = 28
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnHuyLenh
        '
        Me.btnHuyLenh.Location = New System.Drawing.Point(245, 14)
        Me.btnHuyLenh.Name = "btnHuyLenh"
        Me.btnHuyLenh.Size = New System.Drawing.Size(58, 21)
        Me.btnHuyLenh.TabIndex = 31
        Me.btnHuyLenh.Text = "Hủy lệnh"
        Me.btnHuyLenh.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(127, 14)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(58, 21)
        Me.btnXoa.TabIndex = 29
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(186, 14)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(58, 21)
        Me.btnCapNhat.TabIndex = 30
        Me.btnCapNhat.Text = "Ghi"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnTroGiup
        '
        Me.btnTroGiup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTroGiup.Location = New System.Drawing.Point(645, 14)
        Me.btnTroGiup.Name = "btnTroGiup"
        Me.btnTroGiup.Size = New System.Drawing.Size(58, 21)
        Me.btnTroGiup.TabIndex = 32
        Me.btnTroGiup.Text = "Trợ giúp"
        Me.btnTroGiup.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnThem)
        Me.GroupBox3.Controls.Add(Me.btnSua)
        Me.GroupBox3.Controls.Add(Me.btnHuyLenh)
        Me.GroupBox3.Controls.Add(Me.btnXoa)
        Me.GroupBox3.Controls.Add(Me.btnCapNhat)
        Me.GroupBox3.Controls.Add(Me.btnTroGiup)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 444)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(716, 42)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'ctrlThongTinThuaKeKhai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ctrlThongTinThuaKeKhai"
        Me.Size = New System.Drawing.Size(726, 488)
        CType(Me.numDienTichChung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDienTichRieng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numDienTichKhongCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDienTich, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numDienTichChung As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numDienTichRieng As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoThua As System.Windows.Forms.TextBox
    Friend WithEvents txtThoiHanSuDung As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtToBanDo As System.Windows.Forms.TextBox
    Friend WithEvents numDienTich As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNguonGocSuDung As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnHuyLenh As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnTroGiup As System.Windows.Forms.Button
    Friend WithEvents grdvw As DMC.Interface.GridView.ctrlGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDienTichBangChu As System.Windows.Forms.TextBox
    Friend WithEvents txtMucDichSuDung As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnMucDichChiTiet As System.Windows.Forms.Button
    Friend WithEvents btnNguonGocChiTiet As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDienTichKhongCapBangChu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents numDienTichKhongCap As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLyDoKhongCap As System.Windows.Forms.TextBox
    Friend WithEvents btnDienTichBangChu As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCachDuongChinh As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNgoRong As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtViTri As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLoaiDuong As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTTNCN As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLPTB As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNoiDungHoSo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtDT20GiaDat As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDT40GiaDat As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtDT50GiaDat As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDT100GiaDat As System.Windows.Forms.TextBox

End Class
