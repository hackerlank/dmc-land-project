<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPhanQuyen
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.trvwDonViHanhChinh = New System.Windows.Forms.TreeView
        Me.grdvwThongTin = New DMC.[Interface].GridView.ctrlGridView
        Me.Tendangnhap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngaytao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chucvu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phongban = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diachi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ma = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tlstpucAdmin = New System.Windows.Forms.ToolStrip
        Me.TlstpbtAdd = New System.Windows.Forms.ToolStripButton
        Me.tstpbtModify = New System.Windows.Forms.ToolStripButton
        Me.tlstpbtDelete = New System.Windows.Forms.ToolStripButton
        Me.tlstpbtUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.txtTendaydu = New System.Windows.Forms.TextBox
        Me.txtChucVu = New System.Windows.Forms.TextBox
        Me.txtPhongBan = New System.Windows.Forms.TextBox
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox
        Me.lbTenDangNhap = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpNgayTao = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.trvwChucNang = New System.Windows.Forms.TreeView
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grdvwThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlstpucAdmin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(656, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Đơn vị hành chính"
        '
        'trvwDonViHanhChinh
        '
        Me.trvwDonViHanhChinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvwDonViHanhChinh.CheckBoxes = True
        Me.trvwDonViHanhChinh.Location = New System.Drawing.Point(659, 76)
        Me.trvwDonViHanhChinh.Name = "trvwDonViHanhChinh"
        Me.trvwDonViHanhChinh.Size = New System.Drawing.Size(251, 296)
        Me.trvwDonViHanhChinh.TabIndex = 2
        '
        'grdvwThongTin
        '
        Me.grdvwThongTin.AllowUserToAddRows = False
        Me.grdvwThongTin.AllowUserToOrderColumns = True
        Me.grdvwThongTin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdvwThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdvwThongTin.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwThongTin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvwThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdvwThongTin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tendangnhap, Me.Ngaytao, Me.ten, Me.Chucvu, Me.Phongban, Me.Diachi, Me.SDT, Me.ma})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvwThongTin.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdvwThongTin.Location = New System.Drawing.Point(3, 378)
        Me.grdvwThongTin.Name = "grdvwThongTin"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdvwThongTin.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdvwThongTin.RowHeadersVisible = False
        Me.grdvwThongTin.RowHeadersWidth = 25
        Me.grdvwThongTin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdvwThongTin.Size = New System.Drawing.Size(907, 152)
        Me.grdvwThongTin.TabIndex = 3
        '
        'Tendangnhap
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tendangnhap.DefaultCellStyle = DataGridViewCellStyle2
        Me.Tendangnhap.FillWeight = 221.6089!
        Me.Tendangnhap.HeaderText = "Tên đăng nhập"
        Me.Tendangnhap.MinimumWidth = 110
        Me.Tendangnhap.Name = "Tendangnhap"
        '
        'Ngaytao
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Ngaytao.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngaytao.FillWeight = 77.22179!
        Me.Ngaytao.HeaderText = "Ngày tạo"
        Me.Ngaytao.MinimumWidth = 100
        Me.Ngaytao.Name = "Ngaytao"
        Me.Ngaytao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ten
        '
        Me.ten.FillWeight = 77.22179!
        Me.ten.HeaderText = "Tên đầy đủ"
        Me.ten.MinimumWidth = 100
        Me.ten.Name = "ten"
        '
        'Chucvu
        '
        Me.Chucvu.FillWeight = 77.22179!
        Me.Chucvu.HeaderText = "Chức vụ"
        Me.Chucvu.MinimumWidth = 100
        Me.Chucvu.Name = "Chucvu"
        '
        'Phongban
        '
        Me.Phongban.FillWeight = 77.22179!
        Me.Phongban.HeaderText = "Phòng ban"
        Me.Phongban.MinimumWidth = 100
        Me.Phongban.Name = "Phongban"
        '
        'Diachi
        '
        Me.Diachi.HeaderText = "Địa chỉ"
        Me.Diachi.MinimumWidth = 150
        Me.Diachi.Name = "Diachi"
        '
        'SDT
        '
        Me.SDT.FillWeight = 77.22179!
        Me.SDT.HeaderText = "Số điện thoại"
        Me.SDT.MinimumWidth = 100
        Me.SDT.Name = "SDT"
        '
        'ma
        '
        Me.ma.HeaderText = "Column1"
        Me.ma.Name = "ma"
        Me.ma.Visible = False
        '
        'tlstpucAdmin
        '
        Me.tlstpucAdmin.AutoSize = False
        Me.tlstpucAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlstpbtAdd, Me.tstpbtModify, Me.tlstpbtDelete, Me.tlstpbtUpdate, Me.ToolStripSeparator1})
        Me.tlstpucAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tlstpucAdmin.Name = "tlstpucAdmin"
        Me.tlstpucAdmin.Size = New System.Drawing.Size(915, 54)
        Me.tlstpucAdmin.TabIndex = 0
        Me.tlstpucAdmin.Text = "ToolStrip1"
        '
        'TlstpbtAdd
        '
        Me.TlstpbtAdd.Image = Global.DMC.Land.QuanTriHeThong.PhanQuyen.My.Resources.Resources.Add
        Me.TlstpbtAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlstpbtAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlstpbtAdd.Name = "TlstpbtAdd"
        Me.TlstpbtAdd.Size = New System.Drawing.Size(56, 51)
        Me.TlstpbtAdd.Text = "Thêm mới"
        Me.TlstpbtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tstpbtModify
        '
        Me.tstpbtModify.Image = Global.DMC.Land.QuanTriHeThong.PhanQuyen.My.Resources.Resources.Modify
        Me.tstpbtModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tstpbtModify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstpbtModify.Name = "tstpbtModify"
        Me.tstpbtModify.Size = New System.Drawing.Size(36, 51)
        Me.tstpbtModify.Text = "Sửa"
        Me.tstpbtModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlstpbtDelete
        '
        Me.tlstpbtDelete.Image = Global.DMC.Land.QuanTriHeThong.PhanQuyen.My.Resources.Resources.Delete
        Me.tlstpbtDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tlstpbtDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpbtDelete.Name = "tlstpbtDelete"
        Me.tlstpbtDelete.Size = New System.Drawing.Size(36, 51)
        Me.tlstpbtDelete.Text = "Xóa"
        Me.tlstpbtDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlstpbtUpdate
        '
        Me.tlstpbtUpdate.Image = Global.DMC.Land.QuanTriHeThong.PhanQuyen.My.Resources.Resources.Save
        Me.tlstpbtUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tlstpbtUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpbtUpdate.Name = "tlstpbtUpdate"
        Me.tlstpbtUpdate.Size = New System.Drawing.Size(55, 51)
        Me.tlstpbtUpdate.Text = "Cập nhật"
        Me.tlstpbtUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'txtTendaydu
        '
        Me.txtTendaydu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendaydu.Location = New System.Drawing.Point(97, 112)
        Me.txtTendaydu.Name = "txtTendaydu"
        Me.txtTendaydu.Size = New System.Drawing.Size(282, 20)
        Me.txtTendaydu.TabIndex = 2
        '
        'txtChucVu
        '
        Me.txtChucVu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChucVu.Location = New System.Drawing.Point(97, 152)
        Me.txtChucVu.Name = "txtChucVu"
        Me.txtChucVu.Size = New System.Drawing.Size(282, 20)
        Me.txtChucVu.TabIndex = 3
        '
        'txtPhongBan
        '
        Me.txtPhongBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhongBan.Location = New System.Drawing.Point(97, 192)
        Me.txtPhongBan.Name = "txtPhongBan"
        Me.txtPhongBan.Size = New System.Drawing.Size(282, 20)
        Me.txtPhongBan.TabIndex = 4
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(97, 232)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(282, 20)
        Me.txtDiaChi.TabIndex = 5
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDienThoai.Location = New System.Drawing.Point(97, 272)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(199, 20)
        Me.txtSoDienThoai.TabIndex = 6
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDangNhap.Location = New System.Drawing.Point(97, 32)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(199, 20)
        Me.txtTenDangNhap.TabIndex = 0
        '
        'lbTenDangNhap
        '
        Me.lbTenDangNhap.AutoSize = True
        Me.lbTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenDangNhap.ForeColor = System.Drawing.Color.Black
        Me.lbTenDangNhap.Location = New System.Drawing.Point(10, 32)
        Me.lbTenDangNhap.Name = "lbTenDangNhap"
        Me.lbTenDangNhap.Size = New System.Drawing.Size(81, 13)
        Me.lbTenDangNhap.TabIndex = 2
        Me.lbTenDangNhap.Text = "Tên đăng nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ngày tạo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tên đầy đủ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Chức vụ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Phòng ban"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Địa chỉ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Số điện thoại"
        '
        'dtpNgayTao
        '
        Me.dtpNgayTao.Enabled = False
        Me.dtpNgayTao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayTao.Location = New System.Drawing.Point(97, 72)
        Me.dtpNgayTao.Name = "dtpNgayTao"
        Me.dtpNgayTao.Size = New System.Drawing.Size(105, 20)
        Me.dtpNgayTao.TabIndex = 1
        Me.dtpNgayTao.Value = New Date(2008, 7, 29, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayTao)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.txtTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.txtSoDienThoai)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtPhongBan)
        Me.GroupBox1.Controls.Add(Me.txtChucVu)
        Me.GroupBox1.Controls.Add(Me.txtTendaydu)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 315)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin người dùng"
        '
        'trvwChucNang
        '
        Me.trvwChucNang.CheckBoxes = True
        Me.trvwChucNang.Location = New System.Drawing.Point(402, 76)
        Me.trvwChucNang.Name = "trvwChucNang"
        Me.trvwChucNang.Size = New System.Drawing.Size(251, 296)
        Me.trvwChucNang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(402, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Chức năng"
        '
        'ucPhanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Controls.Add(Me.trvwChucNang)
        Me.Controls.Add(Me.tlstpucAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.trvwDonViHanhChinh)
        Me.Controls.Add(Me.grdvwThongTin)
        Me.Name = "ucPhanQuyen"
        Me.Size = New System.Drawing.Size(915, 533)
        CType(Me.grdvwThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlstpucAdmin.ResumeLayout(False)
        Me.tlstpucAdmin.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trvwDonViHanhChinh As System.Windows.Forms.TreeView
    Friend WithEvents tlstpucAdmin As System.Windows.Forms.ToolStrip
    Friend WithEvents TlstpbtAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstpbtModify As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpbtDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpbtUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tendangnhap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngaytao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chucvu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phongban As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diachi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTendaydu As System.Windows.Forms.TextBox
    Friend WithEvents txtChucVu As System.Windows.Forms.TextBox
    Friend WithEvents txtPhongBan As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lbTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayTao As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents trvwChucNang As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdvwThongTin As DMC.Interface.GridView.ctrlGridView

End Class
