SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThuaDatCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThuaDatCapGCN](
	[MaThuaDatCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaThuaDat] [bigint] NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ToBanDo] [nvarchar](50) NULL,
	[SoThua] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[DienTich] [float] NULL,
	[DienTichBangChu] [nvarchar](500) NULL,
	[DienTichRieng] [float] NULL,
	[DienTichChung] [float] NULL,
	[MucDichSuDung] [nvarchar](50) NULL,
	[ThoiHanSuDung] [nvarchar](200) NULL,
	[NguonGocSuDung] [nvarchar](50) NULL,
	[DienTichKhongCap] [float] NULL,
	[DienTichKhongCapBangChu] [nvarchar](200) NULL,
	[LyDoKhongCap] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblThuaDatCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaThuaDatCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privbldg#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[privbldg#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTiepNhanHoSo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTiepNhanHoSo](
	[MaTiepNhanHoSo] [uniqueidentifier] NOT NULL,
	[CoQuanThucHien] [uniqueidentifier] NOT NULL,
	[ThoiDiemTiepNhan] [datetime] NULL,
	[SoHoSoTiepNhan] [nvarchar](50) NULL,
	[ThuTuTiepNhan] [int] NULL,
	[TenNguoiTiepNhan] [nvarchar](50) NULL,
	[TenNguoiDiKeKhai] [nvarchar](50) NULL,
	[CMTNguoiDiKeKhai] [nvarchar](50) NULL,
	[SoDienThoaiNguoiDiKeKhai] [char](10) NULL,
	[DiaChiNguoiDiKeKhai] [nvarchar](200) NULL,
	[NguoiVietDon] [nvarchar](50) NULL,
	[ThoiDiemVietDon] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privbldg#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[privbldg#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[administrator].[tblTuDienLoaiNhanThuaDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [administrator].[tblTuDienLoaiNhanThuaDat](
	[MaDoiTuong] [int] IDENTITY(1,1) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienLoaiNhanThuaDat] PRIMARY KEY CLUSTERED 
(
	[MaDoiTuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienChucNang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienChucNang](
	[iMachucnang] [int] NOT NULL,
	[nTenchucnang] [nvarchar](50) NOT NULL,
	[nMotachucnang] [nvarchar](200) NULL,
	[IDGroup] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienCoQuanChinhLyGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienCoQuanChinhLyGCN](
	[Ma] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienCoQuanChinhLyGCN_Ma]  DEFAULT (newid()),
	[KyHieu] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
	[Nhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTuDienCoQuanChinhLyGCN] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienDoiTuongSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienDoiTuongSuDungDat](
	[Ma] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienDoiTuongSuDungDat_Ma]  DEFAULT (newid()),
	[KyHieu] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[Nhom] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienDoiTuongSuDungDat] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienDonViHanhChinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienDonViHanhChinh](
	[MaDonViHanhChinh] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaTinh] [int] NULL,
	[MaHuyen] [int] NULL,
	[MaXa] [int] NULL,
	[LatMin] [float] NULL,
	[LngMin] [float] NULL,
	[LatMax] [float] NULL,
	[LngMax] [float] NULL,
	[LatCenter] [float] NULL,
	[LngCenter] [float] NULL,
 CONSTRAINT [PK_tblTuDienDonViHanhChinh] PRIMARY KEY CLUSTERED 
(
	[MaDonViHanhChinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pubbldg#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HIENTRANG#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienMauDon]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienMauDon](
	[MaTuDienMauDon] [uniqueidentifier] NOT NULL,
	[MauDonSo] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienMucDichSDD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienMucDichSDD](
	[Ma] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienMucDichSDD_Ma]  DEFAULT (newid()),
	[KyHieu] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
	[Nhom] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienMucDichSDD] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[rdpaved#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNghiaVuTaiChinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNghiaVuTaiChinh](
	[MaNghiaVuTaiChinh] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienNghiaVuTaiChinh_MaNghiaVuTaiChinh]  DEFAULT (newid()),
	[KyHieu] [nvarchar](500) NULL,
	[MoTa] [nvarchar](500) NULL,
	[Nhom] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienNghiaVuTaiChinh] PRIMARY KEY CLUSTERED 
(
	[MaNghiaVuTaiChinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[rdpaved#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguoiKyGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguoiKyGCN](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[GioiTinh] [bit] NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[ChucVu] [nvarchar](200) NULL,
	[ChucDanh] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblTuDienNguoiKyGCN] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienGCN](
	[Ma] [uniqueidentifier] NOT NULL,
	[DonViQuanLy] [nvarchar](200) NULL,
	[CoQuanCapGCN] [nvarchar](100) NULL,
	[ChucVuLanhDaoCoQuanCapGCN] [nvarchar](100) NULL,
	[LanhDaoCoQuanCapGCN] [nvarchar](100) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pubbldg#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguoiLapBieu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguoiLapBieu](
	[MaNguoiLap] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblTuDienNguoiLapBieu] PRIMARY KEY CLUSTERED 
(
	[MaNguoiLap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguoiPheDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguoiPheDuyet](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[ChucDanh] [nvarchar](200) NULL,
	[ChucVu] [nvarchar](200) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_tblTuDienNguoiPheDuyet] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spotelev#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[spotelev#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguoiThamDinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguoiThamDinh](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[ChucDanh] [nvarchar](200) NULL,
	[ChucVu] [nvarchar](200) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_tblTuDienNguoiThamDinh] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spotelev#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[spotelev#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguoiXetDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguoiXetDuyet](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](200) NOT NULL,
	[ChucDanh] [nvarchar](200) NULL,
	[ChucVu] [nvarchar](200) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_tblTuDienNguoiXetDuyet] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienNguonGocSDD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienNguonGocSDD](
	[Ma] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienNguonGocSDD_Ma]  DEFAULT (newid()),
	[KyHieu] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](300) NULL,
 CONSTRAINT [PK_tblTuDienNguonGocSDD] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCayLichSuThuaDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblCayLichSuThuaDat](
	[MaThuaDatHienThoi] [int] NOT NULL,
	[MaThuaDatLichSu] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblChu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblChu](
	[MaChu] [bigint] IDENTITY(1,1) NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[DoiTuongSDD] [nvarchar](50) NULL,
	[QuanHe] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [int] NULL,
	[QuocTich] [nvarchar](100) NULL,
	[SoDinhDanh] [nvarchar](50) NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](200) NULL,
	[QuocTich2] [nchar](100) NULL,
	[SoDinhDanh2] [nchar](50) NULL,
	[NgayCap2] [datetime] NULL,
	[NoiCap2] [nchar](200) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoHoKhau] [nvarchar](50) NULL,
	[NgayCapHoKhau] [datetime] NULL,
	[NoiCapHoKhau] [nvarchar](200) NULL,
	[DaChet] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblChuDeNghiCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblChuDeNghiCapGCN](
	[MaChuDeNghiCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[MaChu] [bigint] NOT NULL,
 CONSTRAINT [PK_tblChuDeNghiCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaChuDeNghiCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienPhieuThamDinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienPhieuThamDinh](
	[Ma] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTuDienPhieuThamDinh_Ma]  DEFAULT (newid()),
	[DonViQuanLy] [nvarchar](200) NULL,
	[DonViThucHien] [nvarchar](200) NULL,
	[LanhDaoDVTH] [nvarchar](100) NULL,
	[ChucVuLanhDaoDVTH] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienPhieuThamDinh] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblChuHoSoCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblChuHoSoCapGCN](
	[MaChuHoSoCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[MaChu] [bigint] NOT NULL,
	[Dat] [bit] NULL,
	[NhaO] [bit] NULL,
	[CongTrinhXayDung] [bit] NULL,
	[RungCay] [bit] NULL,
	[CayLauNam] [bit] NULL,
 CONSTRAINT [PK_tblChuHoSoCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaChuHoSoCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienQuanLyDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienQuanLyDat](
	[Ma] [uniqueidentifier] NOT NULL,
	[Kyhieu] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCongTrinhXayDung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblCongTrinhXayDung](
	[MaCongTrinhXayDung] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[GiayPhep] [nvarchar](500) NULL,
	[Ten] [nvarchar](500) NULL,
	[MoTa] [nvarchar](500) NULL,
	[NguonGoc] [nvarchar](500) NULL,
	[DienTichXayDung] [float] NULL,
	[HinhThanhTrongTuongLai] [bit] NULL,
	[ThoiDiemHinhThanh] [datetime] NULL,
 CONSTRAINT [PK_tblCongTrinhXayDung_1] PRIMARY KEY CLUSTERED 
(
	[MaCongTrinhXayDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienQuyenDangNhap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienQuyenDangNhap](
	[MaQuyen] [int] NOT NULL,
	[Quyen] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienQuyetDinhCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienQuyetDinhCapGCN](
	[MaQuyetDinhCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[SoQuyetDinhCapGCN] [nvarchar](50) NULL,
	[NgayQuyetDinhCapGCN] [datetime] NULL,
	[DonViQuyetDinhCapGCN] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblTuDienQuyetDinhCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaQuyetDinhCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTieuDeKyGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTieuDeKyGCN](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[TieuDeKyGCN] [nvarchar](200) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblTieuDeKyGCN] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDanhSachToaDo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDanhSachToaDo](
	[MaDanhSachToaDo] [int] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [nvarchar](50) NULL,
	[MaThuaDat] [nvarchar](50) NULL,
	[SoThuTu] [nvarchar](50) NULL,
	[ToaDoX] [nvarchar](50) NULL,
	[ToaDoY] [nvarchar](50) NULL,
	[HeSoGoc] [nvarchar](50) NULL,
	[ChieuDai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDanhSachToaDo] PRIMARY KEY CLUSTERED 
(
	[MaDanhSachToaDo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTongHopChuSuDung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTongHopChuSuDung](
	[MaTongHop] [int] IDENTITY(1,1) NOT NULL,
	[Mota] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblTuDienTongHopChuSuDung] PRIMARY KEY CLUSTERED 
(
	[MaTongHop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianDiaGioiHanhChinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianDiaGioiHanhChinh](
	[MaDiaGioiHanhChinh] [uniqueidentifier] NOT NULL,
	[MaDonViHanhChinh] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTongHopChuSuDungChiTiet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTongHopChuSuDungChiTiet](
	[MaTongHopChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaTongHop] [int] NULL,
	[MoTa] [nvarchar](500) NULL,
	[GiaTriThemVao] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblTuDienTongHopChuSuDungChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaTongHopChiTiet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANQUIHOACH#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienToTrinhDiaChinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienToTrinhDiaChinh](
	[MaToTrinhDiaChinh] [bigint] IDENTITY(1,1) NOT NULL,
	[SoToTrinhDiaChinh] [nvarchar](50) NULL,
	[NgayLapToTrinhDiaChinh] [datetime] NULL,
	[DonViLapToTrinhDiaChinh] [nvarchar](200) NULL,
	[NgayTrinhDiaChinh] [datetime] NULL,
	[DVHC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTuDienToTrinhDiaChinh] PRIMARY KEY CLUSTERED 
(
	[MaToTrinhDiaChinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl10ThuaDatMoiThaoTac]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl10ThuaDatMoiThaoTac](
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ToBanDo] [nvarchar](20) NULL,
	[SoThua] [nvarchar](10) NULL,
	[DienTich] [float] NULL,
	[DiaChiDat] [nvarchar](max) NULL,
	[ThoiDiem] [int] IDENTITY(1,1) NOT NULL,
	[MaThuaDat] [int] NULL,
	[MaDonViHanhChinh] [int] NULL,
 CONSTRAINT [PK_tbl10ThuaDatMoiThaoTac] PRIMARY KEY CLUSTERED 
(
	[MaHoSoCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiCapGCN](
	[MaTrangThaiHoSo] [int] IDENTITY(1,1) NOT NULL,
	[GiaTri] [int] NULL,
	[MoTa] [nvarchar](200) NULL,
	[R] [int] NULL,
	[G] [int] NULL,
	[B] [int] NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiHoSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiKeKhai]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiKeKhai](
	[MaTuDienTrangThaiKeKhai] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiKeKhai] PRIMARY KEY CLUSTERED 
(
	[MaTuDienTrangThaiKeKhai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianThuaDat#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiPheDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiPheDuyet](
	[MaTuDienTrangThaiPheDuyet] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiPheDuyet] PRIMARY KEY CLUSTERED 
(
	[MaTuDienTrangThaiPheDuyet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiThamDinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiThamDinh](
	[MaTuDienTrangThaiThamDinh] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiThamDinh] PRIMARY KEY CLUSTERED 
(
	[MaTuDienTrangThaiThamDinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianToBanDo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianToBanDo](
	[Ma] [uniqueidentifier] NOT NULL,
	[ToBanDoSo] [nvarchar](50) NOT NULL,
	[PhienHieuManh] [nvarchar](50) NOT NULL,
	[TiLe] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblGroupFunction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblGroupFunction](
	[IDGroup] [int] NOT NULL,
	[NameGroup] [nvarchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHangMucCongTrinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHangMucCongTrinh](
	[MaHangMucCongTrinh] [bigint] IDENTITY(1,1) NOT NULL,
	[MaCongTrinhXayDung] [bigint] NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[TenHangMucCongTrinh] [nvarchar](500) NULL,
	[DienTichXayDung] [float] NULL,
	[CongSuat] [nvarchar](500) NULL,
	[KetCau] [nvarchar](50) NULL,
	[CapHang] [nvarchar](50) NULL,
	[SoTang] [float] NULL,
	[NamXayDung] [int] NULL,
	[ThoiHanSoHuu] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblCongTrinhXayDung] PRIMARY KEY CLUSTERED 
(
	[MaHangMucCongTrinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sheet1$]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sheet1$](
	[ToBanDo] [nvarchar](255) NULL,
	[SoThua] [nvarchar](255) NULL,
	[Chu1] [nvarchar](255) NULL,
	[Chu2] [nvarchar](255) NULL,
	[LoaiDoiTuong] [nvarchar](255) NULL,
	[DienTich] [float] NULL,
	[CapGCN] [nvarchar](255) NULL,
	[QuiHoach] [nvarchar](255) NULL,
	[KiemKe] [nvarchar](255) NULL,
	[ChiTiet] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[F12] [nvarchar](255) NULL,
	[F13] [nvarchar](255) NULL,
	[F14] [nvarchar](255) NULL,
	[F15] [nvarchar](255) NULL,
	[F16] [nvarchar](255) NULL,
	[F17] [nvarchar](255) NULL,
	[F18] [nvarchar](255) NULL,
	[F19] [nvarchar](255) NULL,
	[F20] [nvarchar](255) NULL,
	[F21] [nvarchar](255) NULL,
	[F22] [nvarchar](255) NULL,
	[F23] [nvarchar](255) NULL,
	[F24] [nvarchar](255) NULL,
	[F25] [nvarchar](255) NULL,
	[F26] [nvarchar](255) NULL,
	[F27] [nvarchar](255) NULL,
	[F28] [nvarchar](255) NULL,
	[F29] [nvarchar](255) NULL,
	[F30] [nvarchar](255) NULL,
	[F31] [nvarchar](255) NULL,
	[F32] [nvarchar](255) NULL,
	[F33] [nvarchar](255) NULL,
	[F34] [nvarchar](255) NULL,
	[F35] [nvarchar](255) NULL,
	[F36] [nvarchar](255) NULL,
	[F37] [nvarchar](255) NULL,
	[F38] [nvarchar](255) NULL,
	[F39] [nvarchar](255) NULL,
	[F40] [nvarchar](255) NULL,
	[F41] [nvarchar](255) NULL,
	[F42] [nvarchar](255) NULL,
	[F43] [nvarchar](255) NULL,
	[F44] [nvarchar](255) NULL,
	[F45] [nvarchar](255) NULL,
	[F46] [nvarchar](255) NULL,
	[F47] [nvarchar](255) NULL,
	[F48] [nvarchar](255) NULL,
	[F49] [nvarchar](255) NULL,
	[F50] [nvarchar](255) NULL,
	[F51] [nvarchar](255) NULL,
	[F52] [nvarchar](255) NULL,
	[F53] [nvarchar](255) NULL,
	[F54] [nvarchar](255) NULL,
	[F55] [nvarchar](255) NULL,
	[F56] [nvarchar](255) NULL,
	[F57] [nvarchar](255) NULL,
	[F58] [nvarchar](255) NULL,
	[F59] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoiDongXetDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoiDongXetDuyet](
	[MaHoiDongXetDuyet] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoiXetDuyet] [int] NOT NULL,
	[MaHoSoCapGCN] [bigint] NULL,
 CONSTRAINT [PK_tblHoiDongXetDuyet] PRIMARY KEY CLUSTERED 
(
	[MaHoiDongXetDuyet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BACHDANG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BACHDANG](
	[NDX] [int] NULL,
	[MI_STYLE] [varchar](254) NULL,
	[MI_SQL_REC_NUM] [int] IDENTITY(1,1) NOT NULL,
	[MI_SQL_X] [float] NULL,
	[MI_SQL_Y] [float] NULL,
	[MI_SQL_MICODE] [varchar](18) NULL,
PRIMARY KEY CLUSTERED 
(
	[MI_SQL_REC_NUM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoPheDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoPheDuyet](
	[MaHoSoPheDuyet] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[KetQuaPheDuyet] [nvarchar](50) NULL,
	[HoTenCanBoPheDuyet] [nvarchar](50) NULL,
	[NgayPheDuyet] [datetime] NULL,
	[YKienPheDuyet] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblHoSoPheDuyet] PRIMARY KEY CLUSTERED 
(
	[MaHoSoPheDuyet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoQuyetDinhCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoQuyetDinhCapGCN](
	[MaHoSoQuyetDinhCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[MaQuyetDinhCapGCN] [bigint] NOT NULL,
 CONSTRAINT [PK_tblHoSoQuyetDinhCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaHoSoQuyetDinhCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoThamDinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoThamDinh](
	[MaHoSoThamDinh] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[DonViThamDinh] [nvarchar](200) NULL,
	[KetQuaThamDinh] [nvarchar](50) NULL,
	[HoTenCanBoThamDinh] [nvarchar](50) NULL,
	[NgayThamDinh] [datetime] NULL,
	[YKienThamDinh] [nvarchar](500) NULL,
	[LyDoKhongCap] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblHoSoThamDinh] PRIMARY KEY CLUSTERED 
(
	[MaHoSoThamDinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoTiepNhan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoTiepNhan](
	[MaHoSoTiepNhan] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ThoiDiemTiepNhan] [datetime] NULL,
	[SoHoSoTiepNhan] [nvarchar](50) NULL,
	[ThuTuTiepNhan] [bigint] NULL,
	[NoiNhanHoSo] [nvarchar](500) NULL,
	[NgayNhanDuHoSo] [datetime] NULL,
	[TenNguoiTiepNhan] [nvarchar](100) NULL,
	[TenNguoiDiKeKhai] [nvarchar](100) NULL,
	[CMTNguoiDiKeKhai] [nvarchar](50) NULL,
	[SoDienThoaiNguoiDiKeKhai] [nvarchar](50) NULL,
	[DiaChiNguoiDiKeKhai] [nvarchar](200) NULL,
	[NguoiVietDon] [nvarchar](100) NULL,
	[ThoiDiemVietDon] [datetime] NULL,
	[NgayKeKhaiDangKy] [datetime] NULL,
 CONSTRAINT [PK_tblHoSoTiepNhan] PRIMARY KEY CLUSTERED 
(
	[MaHoSoTiepNhan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoTrinhDiaChinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoTrinhDiaChinh](
	[MaHoSoTrinhDiaChinh] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[MaToTrinhDiaChinh] [bigint] NOT NULL,
 CONSTRAINT [PK_tblHoSoTrinhDiaChinh] PRIMARY KEY CLUSTERED 
(
	[MaHoSoTrinhDiaChinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuChuSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuChuSuDungDat](
	[MaChuSuDungDatLichSu] [uniqueidentifier] NOT NULL,
	[ThoiDiemBienDong] [datetime] NOT NULL,
	[MaChuSuDung] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[DoiTuongSDD] [nvarchar](50) NULL,
	[QuanHe] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [int] NULL,
	[SoDinhDanh] [nvarchar](50) NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[QuocTich] [nvarchar](100) NULL,
	[SoHoKhau] [nvarchar](50) NULL,
	[NgayCapHoKhau] [datetime] NULL,
	[NoiCapHoKhau] [nvarchar](200) NULL,
	[MaChuSuDungDatCha] [uniqueidentifier] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MAPINFO].[MAPINFO_MAPCATALOG]') AND type in (N'U'))
BEGIN
CREATE TABLE [MAPINFO].[MAPINFO_MAPCATALOG](
	[SPATIALTYPE] [float] NULL,
	[TABLENAME] [varchar](32) NOT NULL,
	[OWNERNAME] [varchar](32) NOT NULL,
	[SPATIALCOLUMN] [varchar](32) NULL,
	[DB_X_LL] [float] NULL,
	[DB_Y_LL] [float] NULL,
	[DB_X_UR] [float] NULL,
	[DB_Y_UR] [float] NULL,
	[COORDINATESYSTEM] [varchar](254) NULL,
	[SYMBOL] [varchar](254) NULL,
	[XCOLUMNNAME] [varchar](32) NULL,
	[YCOLUMNNAME] [varchar](32) NULL,
	[RENDITIONTYPE] [int] NULL,
	[RENDITIONCOLUMN] [varchar](32) NULL,
	[RENDITIONTABLE] [varchar](32) NULL,
	[VIEW_X_LL] [float] NULL,
	[VIEW_Y_LL] [float] NULL,
	[VIEW_X_UR] [float] NULL,
	[VIEW_Y_UR] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[TABLENAME] ASC,
	[OWNERNAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuChuSuDungHoSoCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuChuSuDungHoSoCapGCN](
	[MaChuSuDungHoSoCapNhatGCNLichSu] [uniqueidentifier] NOT NULL,
	[ThoiDiemBienDong] [datetime] NULL,
	[MaChuSuDungHoSoCapGCN] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[MaChuSuDungDat] [uniqueidentifier] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuDLieuKGianThuaDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuDLieuKGianThuaDat](
	[MaThuaDat] [uniqueidentifier] NOT NULL,
	[COUNTER] [int] NULL,
	[BIENDONG_MAIN] [nvarchar](100) NULL,
	[BIENDONG_EXT] [nvarchar](100) NULL,
	[LAND_ACTION] [int] NULL,
	[HISTORY] [varbinary](50) NULL,
	[NGAYTHANG] [datetime] NULL,
	[Zoom] [float] NULL,
	[CenterX] [float] NULL,
	[CenterY] [float] NULL,
	[GHICHU] [nvarchar](200) NULL,
	[PIC] [varbinary](50) NULL,
	[SmallPic] [varbinary](50) NULL,
	[FixZoom] [float] NULL,
	[BUFFER] [nvarchar](200) NULL,
	[MaDonViHanhChinh] [int] NULL,
	[DienTichTuNhien] [float] NULL,
	[ThoiDiemTaoThua] [datetime] NULL,
	[ToBanDo] [nvarchar](50) NULL,
	[SoHieuThua] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuHoSoCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuHoSoCapGCN](
	[MaLichSuHoSoCapGCN] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ThoiDiemBienDong] [datetime] NOT NULL,
	[MaThuaDat] [int] NULL,
	[SoHoSo] [nvarchar](50) NULL,
	[SoThuTuHoSo] [bigint] NULL,
	[NgayKeKhaiDangKy] [datetime] NULL,
	[SoHoSoCapGCN] [bigint] NULL,
	[ToBanDo] [nvarchar](50) NULL,
	[SoThua] [nvarchar](50) NULL,
	[DienTichTuNhien] [float] NULL,
	[DiaChiThua] [nvarchar](200) NULL,
	[ThoiDiemKeKhaiCapGCN] [datetime] NULL,
	[ThoiDiemHenTra] [datetime] NULL,
	[MaQuanLy] [nvarchar](50) NULL,
	[HoanTatHoSoKeKhai] [bit] NULL,
	[ToTrinhPhuong] [nvarchar](50) NULL,
	[NgayTrinhPhuong] [datetime] NULL,
	[NgayXetDuyet] [datetime] NULL,
	[KetQuaXetDuyet] [nvarchar](50) NULL,
	[CanhBaoTranhChapKhieuKien] [bit] NULL,
	[NoiDungTranhChapKhieuKien] [nvarchar](500) NULL,
	[YKienCanBoXetDuyet] [nvarchar](200) NULL,
	[KetQuaThamDinh] [nvarchar](50) NULL,
	[TongDienTichThucCap] [float] NULL,
	[TongDienTichRieng] [float] NULL,
	[TongDienTichChung] [float] NULL,
	[TongDienTichKhongCap] [float] NULL,
	[TongHopDienTichKhongCap] [nvarchar](1500) NULL,
	[TongHopDienTichThucCap] [nvarchar](1500) NULL,
	[QuiHoachChiTiet] [nvarchar](500) NULL,
	[HanhLangBaoVeCongTrinhHaTang] [nvarchar](200) NULL,
	[NgayNopDuHoSoHopLe] [datetime] NULL,
	[TrinhTuThuTucPhuong] [nvarchar](200) NULL,
	[CacKhoanPhaiNop] [nvarchar](500) NULL,
	[HoTenCanBoThamDinh] [nvarchar](50) NULL,
	[NgayThamDinh] [datetime] NULL,
	[YKienThamDinh] [nvarchar](500) NULL,
	[HoanTatThamDinh] [bit] NULL,
	[KetQuaPheDuyet] [nvarchar](50) NULL,
	[HoTenCanBoPheDuyet] [nvarchar](50) NULL,
	[NgayPheDuyet] [datetime] NULL,
	[YKienPheDuyet] [nvarchar](500) NULL,
	[HoanTatPheDuyet] [bit] NULL,
	[ToTrinhDiaChinh] [nvarchar](50) NULL,
	[NgayTrinhDiaChinh] [datetime] NULL,
	[NguoiLapToTrinh] [nvarchar](50) NULL,
	[NoiCapGCN] [nvarchar](200) NULL,
	[MaSoGCN] [nvarchar](50) NULL,
	[GhiChuChuSuDung] [nvarchar](500) NULL,
	[GhiChuGCN] [nvarchar](200) NULL,
	[NghiaVuTaiChinh] [nvarchar](500) NULL,
	[NgayCapGCN] [datetime] NULL,
	[isMaVach] [bit] NULL,
	[MaVach] [nvarchar](20) NULL,
	[NguoiLapSoQuanLy] [nvarchar](100) NULL,
	[SoQuyetDinhCapGCN] [nvarchar](50) NULL,
	[NgayQuyetDinhCapGCN] [datetime] NULL,
	[SoVaoSoCapGCN] [nvarchar](50) NULL,
	[NgayVaoSo] [datetime] NULL,
	[SoPhatHanhGCN] [nvarchar](50) NULL,
	[NgayThongBaoCuaUBND] [datetime] NULL,
	[NgayCongDanDenNhanSo] [datetime] NULL,
	[NgayTraGCN] [datetime] NULL,
	[NgayHoanTatGCN] [datetime] NULL,
	[SoHoSoGoc] [nvarchar](100) NULL,
	[NgayKyGCN] [datetime] NULL,
	[NguoiKyGCN] [nvarchar](50) NULL,
	[ThoiDiemInGCN] [datetime] NULL,
	[NgayGiaoGCN] [datetime] NULL,
	[NguoiNhanGCN] [nvarchar](50) NULL,
	[HoanTatCapGCN] [bit] NULL,
	[MapId] [varbinary](50) NULL,
	[MapTab] [varbinary](50) NULL,
	[MapDat] [varbinary](50) NULL,
	[MapMap] [varbinary](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuMucDichSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuMucDichSuDungDat](
	[MaMucDichSuDungLichSu] [uniqueidentifier] NOT NULL,
	[MaMucDichSuDung] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[KyHieu] [nvarchar](50) NULL,
	[DienTichKeKhai] [float] NULL,
	[DienTichThucCap] [float] NULL,
	[DienTichRieng] [float] NULL,
	[DienTichChung] [float] NULL,
	[DienTichKhongCap] [float] NULL,
	[LyDoKhongCap] [nvarchar](500) NULL,
	[LoaiThoiHan] [bit] NULL,
	[ThoiDiemBatDau] [datetime] NULL,
	[ThoiDiemKetThuc] [datetime] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[ThoiDiemBienDong] [datetime] NOT NULL,
	[MaMucDichSuDungCha] [uniqueidentifier] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuNguonGocSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuNguonGocSuDungDat](
	[MaLichSuNguonGoc] [uniqueidentifier] NOT NULL,
	[MaNguonGoc] [uniqueidentifier] NOT NULL,
	[ThoiDiemBienDong] [datetime] NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[KyHieu] [nvarchar](10) NULL,
	[DienTich] [float] NULL,
	[DaCoTaiLieuChungThuc] [bit] NULL,
	[TenTaiLieuChungThuc] [nvarchar](200) NULL,
	[NoiDungChungThuc] [nvarchar](1500) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[MaNguonGocCha] [uniqueidentifier] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuTaiSan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuTaiSan](
	[MaLichSuTaiSan] [uniqueidentifier] NOT NULL,
	[ThoiDiemBienDong] [datetime] NOT NULL,
	[MaTaiSan] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[LoaiNha] [nvarchar](50) NULL,
	[CapHangNha] [nvarchar](50) NULL,
	[NamXayDung] [int] NULL,
	[LoaiThoiHanSoHuu] [bit] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[KetCauNha] [nvarchar](50) NULL,
	[TongSoCanHo] [int] NULL,
	[SoTang] [float] NULL,
	[DiaChiNha] [nvarchar](200) NULL,
	[DienTichXayDung] [float] NULL,
	[DienTichSuDung] [float] NULL,
	[DienTichSanXayDung] [float] NULL,
	[DienTichSanPhu] [float] NULL,
	[SoGiayPhepXayDung] [nvarchar](50) NULL,
	[NamCapPhepXayDung] [int] NULL,
	[CoQuanCapGPXD] [nvarchar](200) NULL,
	[ThongTinXuLyViPham] [nvarchar](500) NULL,
	[TaiSanKhac] [nvarchar](200) NULL,
	[MapId] [varbinary](50) NULL,
	[MapTab] [varbinary](50) NULL,
	[MapDat] [varbinary](50) NULL,
	[MapMap] [varbinary](50) NULL,
	[MaTaiSanCha] [uniqueidentifier] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuUsers](
	[MaUsers] [uniqueidentifier] NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MaQuyen] [int] NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgayTaoUser] [datetime] NULL,
	[TenDayDu] [nvarchar](50) NULL,
	[ChuVu] [nvarchar](50) NULL,
	[PhongBan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDangKyBienDong]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDangKyBienDong](
	[MaDangKyBienDong] [bigint] IDENTITY(1,1) NOT NULL,
	[MaThuaDat] [bigint] NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[MaCoQuanChinhLyGCN] [nvarchar](50) NULL,
	[ThuTuHoSoBienDong] [int] NULL,
	[MaLoaiBienDong] [nvarchar](50) NULL,
	[ThoiDiemDangKy] [datetime] NULL,
	[LoaiThoiHanBienDong] [bit] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[NoidungSoDiaChinh] [nvarchar](500) NULL,
	[NoidungSoBienDong] [nvarchar](500) NULL,
	[NoiDungSoMucKe] [nvarchar](500) NULL,
	[NoiDungSoCapGCN] [nvarchar](500) NULL,
	[NoiDungMatBonGCN] [nvarchar](500) NULL,
	[TenNguoiDangKy] [nvarchar](50) NULL,
	[SoCMTNguoiDangKy] [nchar](10) NULL,
	[DiaChiNguoiDangKy] [nvarchar](200) NULL,
	[HoanTatDangKyBienDong] [bit] NULL,
	[Chon] [bit] NULL,
 CONSTRAINT [PK_tblDangKyBienDong] PRIMARY KEY CLUSTERED 
(
	[MaDangKyBienDong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUserChucNang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblUserChucNang](
	[uMaUserChucNang] [uniqueidentifier] NOT NULL,
	[MaUsers] [uniqueidentifier] NOT NULL,
	[iMaChucNang] [int] NOT NULL,
	[dNgayPhanChucNang] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblUsers](
	[MaUsers] [uniqueidentifier] NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MaQuyen] [int] NULL,
	[NguoiQuanLy] [uniqueidentifier] NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgayTaoUser] [datetime] NULL,
	[TenDayDu] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[PhongBan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADAT1#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUserStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblUserStatus](
	[MaUserStatus] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblUserStatus_MaUserStatus]  DEFAULT (newid()),
	[MaUsers] [uniqueidentifier] NULL,
	[MaDonViHanhChinh] [int] NULL,
	[NgayPhanQuyen] [datetime] NULL,
 CONSTRAINT [PK_tblUserStatus] PRIMARY KEY CLUSTERED 
(
	[MaUserStatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHoSoCapGCN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblHoSoCapGCN](
	[MaHoSoCapGCN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaXa] [int] NULL,
	[TrangThaiHoSoCapGCN] [int] NULL CONSTRAINT [DF_tblHoSoCapGCN_TrangThaiHoSoCapGCN]  DEFAULT ((0)),
	[NgayKeKhaiDangKy] [datetime] NULL,
	[SoHoSoCapGCN] [bigint] NULL,
	[ThoiDiemKeKhaiCapGCN] [datetime] NULL,
	[ThoiDiemHenTra] [datetime] NULL,
	[MaQuanLy] [nvarchar](50) NULL,
	[HoanTatKeKhai] [bit] NULL,
	[ToTrinhPhuong] [nvarchar](50) NULL,
	[NgayTrinhPhuong] [datetime] NULL,
	[NgayXetDuyet] [datetime] NULL,
	[KetQuaXetDuyet] [nvarchar](50) NULL,
	[HanhLangBaoVeCongTrinhHaTang] [nvarchar](500) NULL,
	[CanhBaoTranhChapKhieuKien] [bit] NULL,
	[NoiDungTranhChapKhieuKien] [nvarchar](500) NULL,
	[YKienCanBoXetDuyet] [nvarchar](200) NULL,
	[LyDoKhongCap] [nvarchar](500) NULL,
	[NgayNopDuHoSoHopLe] [datetime] NULL,
	[TrinhTuThuTucPhuong] [nvarchar](200) NULL,
	[CacKhoanPhaiNop] [nvarchar](1000) NULL,
	[GhiChuThamDinh] [nvarchar](500) NULL,
	[LyDoThamDinh] [nvarchar](500) NULL,
	[CoQuanCapGCN] [nvarchar](200) NULL,
	[MaSoGCN] [nvarchar](50) NULL,
	[GhiChuNoiDungChuDeNghiCapGCN] [nvarchar](500) NULL,
	[ThongTinThuaDatDeNghiCapGCN] [nvarchar](500) NULL,
	[ThongTinNhaODeNghiCapGCN] [nvarchar](500) NULL,
	[ThongTinHangMucCongTrinhDeNghiCapGCN] [nvarchar](500) NULL,
	[ThongTinRungCayDeNghiCapGCN] [nvarchar](500) NULL,
	[ThongTinCayLauNamDeNghiCapGCN] [nvarchar](500) NULL,
	[DiaDanhNoiCap] [nvarchar](200) NULL,
	[NgayKyGCN] [datetime] NULL,
	[TieuDeKyGCN] [nvarchar](200) NULL,
	[NguoiKyGCN] [nvarchar](200) NULL,
	[GhiChuGCN] [nvarchar](1000) NULL,
	[AnhMaVach] [image] NULL,
	[InMaVach] [bit] NULL,
	[NghiaVuTaiChinh] [nvarchar](500) NULL,
	[KyHieuThamQuyenCapGCN] [nvarchar](2) NULL,
	[ThuTuVaoSoCapGCN] [int] NULL,
	[SoVaoSoCapGCN] [nvarchar](50) NULL,
	[NgayVaoSoCapGCN] [datetime] NULL,
	[SoPhatHanhGCN] [nvarchar](50) NULL,
	[NgayThongBaoUBND] [datetime] NULL,
	[NgayCongDanNhanThongBao] [datetime] NULL,
	[NgayTraGCN] [datetime] NULL,
	[NgayHoanTatGCN] [datetime] NULL,
	[SoHoSoGoc] [int] NULL,
	[ThoiDiemInGCN] [datetime] NULL,
	[NgayGiaoGCN] [datetime] NULL,
	[NgayNhanGCN] [nvarchar](50) NULL,
	[HoanTatCapGCN] [bit] NULL,
	[HoSoKiThuatGCN] [image] NULL,
	[HoSoKiThuatThamDinh] [image] NULL,
	[SoDoNhaDat] [image] NULL,
	[Status] [nchar](10) NULL CONSTRAINT [DF_tblHoSoCapGCN_Status]  DEFAULT ((1)),
 CONSTRAINT [PK_tblHoSoCapGCN] PRIMARY KEY CLUSTERED 
(
	[MaHoSoCapGCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblYeuCauBoXung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblYeuCauBoXung](
	[MaYeuCauBoXung] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[SoCongVanYeuCauBoXung] [nvarchar](50) NULL,
	[NgayCongVanYeuCauBoXung] [datetime] NULL,
	[NoiDungYeuCauBoXung] [nvarchar](200) NULL,
	[ThoiHanYeuCauBoXung] [int] NULL,
	[YeuCauBoXungTuNgay] [datetime] NULL,
	[SoCongVanBoXung] [nvarchar](50) NULL,
	[NgayCongVanBoXung] [datetime] NULL,
	[NoiDungBoXung] [nvarchar](200) NULL,
	[NgayBoXung] [datetime] NULL,
	[HoanTatBoXung] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiHoSo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiHoSo](
	[MaTuDienTrangThaiHoSo] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiHoSo] PRIMARY KEY CLUSTERED 
(
	[MaTuDienTrangThaiHoSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienLoaiHinhBienDong]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienLoaiHinhBienDong](
	[Ma] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [varchar](10) NULL,
	[Nhom] [nvarchar](100) NULL,
	[MotaNhom] [nvarchar](500) NULL,
	[MoTa] [nvarchar](500) NULL,
	[NoiDungGhiSo] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblTuDienLoaiHinhBienDong] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTuDienTrangThaiXetDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTuDienTrangThaiXetDuyet](
	[MaTuDienTrangThaiXetDuyet] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieu] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblTuDienTrangThaiXetDuyet] PRIMARY KEY CLUSTERED 
(
	[MaTuDienTrangThaiXetDuyet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLichSuUserStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLichSuUserStatus](
	[MaUserStatus] [uniqueidentifier] NOT NULL,
	[MaUser] [uniqueidentifier] NULL,
	[MaDonViHanhChinh] [int] NULL,
	[NgayPhanQuyen] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblLog](
	[LogID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NULL,
	[ModulName] [nvarchar](200) NULL,
	[TimeStart] [datetime] NULL,
	[TimeEnd] [datetime] NULL,
	[ActionName] [nvarchar](200) NULL,
	[ObjName] [nchar](100) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblLog] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[flood100#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[flood100#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMucDichSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblMucDichSuDungDat](
	[MaMucDichSuDung] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblMucDichSuDungDat_MaMucDichSuDung]  DEFAULT (newid()),
	[MaThuaDatCapGCN] [bigint] NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[KyHieu] [nvarchar](50) NULL,
	[DienTichKeKhai] [float] NULL,
	[DienTichRieng] [float] NULL,
	[DienTichChung] [float] NULL,
	[ThoiHan] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[KyHieuKiemKe] [nvarchar](50) NULL,
	[MoTaKiemKe] [nvarchar](500) NULL,
	[GhiChuKiemKe] [nvarchar](200) NULL,
	[KyHieuQuiHoach] [nvarchar](50) NULL,
	[MoTaQuiHoach] [nvarchar](500) NULL,
	[ChiTietQuiHoach] [nvarchar](500) NULL,
	[GhiChuQuiHoach] [nvarchar](200) NULL,
	[ChiTiet] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblMucDichSuDungDat] PRIMARY KEY CLUSTERED 
(
	[MaMucDichSuDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[flood100#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[flood100#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADATLICHSU#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNguonGocSuDungDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblNguonGocSuDungDat](
	[MaNguonGoc] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblNguonGocSuDungDat_MaNguonGoc]  DEFAULT (newid()),
	[MaThuaDatCapGCN] [bigint] NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[KyHieu] [nvarchar](10) NULL,
	[DienTich] [float] NULL,
	[ChiTiet] [nvarchar](1500) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[DaCoTaiLieuChungThuc] [bit] NULL,
	[TenTaiLieuChungThuc] [nvarchar](200) NULL,
	[NoiDungChungThuc] [nvarchar](1500) NULL,
 CONSTRAINT [PK_tblNguonGocSuDungDat] PRIMARY KEY CLUSTERED 
(
	[MaNguonGoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhaO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblNhaO](
	[MaNhaO] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ThoiDiemKeKhaiDangKy] [datetime] NULL,
	[LoaiNha] [nvarchar](50) NULL,
	[CapHangNha] [nvarchar](50) NULL,
	[NamXayDung] [int] NULL,
	[NamHoanThanhXayDung] [int] NULL,
	[ThoiHanSoHuu] [nvarchar](500) NULL,
	[KetCauNha] [nvarchar](50) NULL,
	[SoTang] [nvarchar](50) NULL,
	[DiaChiNha] [nvarchar](200) NULL,
	[DienTichXayDung] [float] NULL,
	[DienTichSanXayDung] [float] NULL,
	[DienTichSanPhu] [float] NULL,
	[SoGiayPhepXayDung] [nvarchar](50) NULL,
	[NgayCapPhepXayDung] [datetime] NULL,
	[CoQuanCapGPXD] [nvarchar](200) NULL,
	[ThongTinXuLyViPham] [nvarchar](500) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lake#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[lake#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblNhomLoaiHinhBienDong]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblNhomLoaiHinhBienDong](
	[MaNhomTuDienLoadHinhBienDong] [uniqueidentifier] NOT NULL,
	[MaTuDienLoaiHinhBienDong] [uniqueidentifier] NULL,
	[MoTa] [nvarchar](250) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lake#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[lake#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSOANHOSOTHUADAT#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHA#m#SW_GEOMETRY#m#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NHA#m#SW_GEOMETRY#m#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSoQuanLy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblSoQuanLy](
	[MaSoQuanLy] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NULL,
	[NguoiLapSoQuanLy] [nvarchar](200) NULL,
	[SoVaoSoCapGCN] [nvarchar](50) NULL,
	[SoPhatHanhGCN] [nvarchar](50) NULL,
	[SoHoSoGoc] [nvarchar](50) NULL,
	[NgayVaoSo] [datetime] NULL,
 CONSTRAINT [PK_tblSoQuanLy] PRIMARY KEY CLUSTERED 
(
	[MaSoQuanLy] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [image] NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTaiLieuKemTheo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTaiLieuKemTheo](
	[MaTaiLieuKemTheo] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_tblTaiLieuKemTheo_MaTaiLieuKemTheo]  DEFAULT (newid()),
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[TenTepDuLieuNguon] [nvarchar](500) NULL,
	[MoTa] [nvarchar](500) NULL,
	[TaiLieu] [image] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DinhDangTaiLieu] [smallint] NULL,
 CONSTRAINT [PK_tblTaiLieuKemTheo] PRIMARY KEY CLUSTERED 
(
	[MaTaiLieuKemTheo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongTinCayLauNam]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThongTinCayLauNam](
	[MaThongTinCayLauNam] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[DienTich] [float] NULL,
	[LoaiCay] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblThongTinCayLauNam] PRIMARY KEY CLUSTERED 
(
	[MaThongTinCayLauNam] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parcel#m#sw_geometry#m#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parcel#m#sw_geometry#m#sw_member](
	[keyvalue] [int] NOT NULL,
	[llx] [float] NULL,
	[lly] [float] NULL,
	[urx] [float] NULL,
	[ury] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongTinKiemKe]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThongTinKiemKe](
	[MaThongTinKiemKe] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[KyHieu] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
	[DienTich] [float] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblThongTinKiemKe] PRIMARY KEY CLUSTERED 
(
	[MaThongTinKiemKe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parcel#r#sw_geometry#r#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parcel#r#sw_geometry#r#sw_member](
	[id] [int] NOT NULL,
	[i_type] [char](1) NULL,
	[height] [int] NULL,
	[cnt] [int] NULL,
	[entries] [varbinary](8000) NULL,
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongTinQuiHoach]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThongTinQuiHoach](
	[MaThongTinQuiHoach] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[KyHieu] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
	[DienTich] [float] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblThongTinQuiHoach] PRIMARY KEY CLUSTERED 
(
	[MaThongTinQuiHoach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBaoLanhTheChap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblBaoLanhTheChap](
	[MaTheChap] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [int] NULL,
	[LoaiTheChap] [nvarchar](50) NULL,
	[SDK_Nam] [nchar](10) NULL,
	[SDK_So] [nchar](10) NULL,
	[SoQuyetDinhCapGCN] [nvarchar](50) NULL,
	[NgayQuyetDinhCapGCN] [datetime] NULL,
	[NgayNhanDon] [datetime] NULL,
	[TheChap] [bit] NULL,
	[BaoLanh] [bit] NULL,
	[TenTheChap] [nvarchar](300) NULL,
	[DiaChiTheChap] [nvarchar](500) NULL,
	[TaiSanQSD] [bit] NULL,
	[TaiSanDat] [bit] NULL,
	[TaiSanQSDDat] [bit] NULL,
	[GiayToKemTheo] [binary](7000) NULL,
	[GhiChu] [nvarchar](3000) NULL,
	[SoCongChung] [nvarchar](50) NULL,
	[NgayCongChung] [datetime] NULL,
	[SoQuyen] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongTinRungCay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThongTinRungCay](
	[MaThongTinRungCay] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[DienTichCoRung] [float] NULL,
	[NguonGocTaoLap] [nvarchar](500) NULL,
	[SoHoSoGiaoRung] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblRungCay] PRIMARY KEY CLUSTERED 
(
	[MaThongTinRungCay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTheChapBaoLanh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblTheChapBaoLanh](
	[MaTheChapBaoLanh] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCN] [int] NULL,
	[LoaiTheChap] [nvarchar](50) NULL,
	[SDK_Nam] [numeric](18, 0) NULL,
	[SDK_So] [numeric](18, 0) NULL,
	[SoQuyetDinhCapGCN] [nvarchar](50) NULL,
	[NgayQuyetDinhCapGCN] [datetime] NULL,
	[NgayNhanDon] [datetime] NULL,
	[TheChap] [bit] NULL,
	[BaoLanh] [bit] NULL,
	[TenTheChap] [nvarchar](500) NULL,
	[DiaChiTheChap] [nvarchar](500) NULL,
	[TaiSanQSD] [bit] NULL,
	[TaiSanDat] [bit] NULL,
	[TaiSanQSDDat] [bit] NULL,
	[GiayToKemTheo] [binary](7000) NULL,
	[GhiChu] [nvarchar](3000) NULL,
	[SoCongChung] [nchar](10) NULL,
	[NgayCongChung] [datetime] NULL,
	[QuyenSo] [nchar](10) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblThongTinXetDuyet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblThongTinXetDuyet](
	[MaXetDuyet] [uniqueidentifier] NOT NULL,
	[MaHoSoCapGCN] [bigint] NOT NULL,
	[ToTrinh] [nvarchar](50) NULL,
	[NgayTrinh] [datetime] NULL,
	[NgayXetDuyet] [datetime] NULL,
	[KetQuaXetDuyet] [nvarchar](50) NULL,
	[TongDienTichThucCap] [float] NULL,
	[TongDienTichRiengThucCap] [float] NULL,
	[TongDienTichChungThucCap] [float] NULL,
	[TongDienTichKhongCap] [float] NULL,
	[LyDoKhongCap] [nvarchar](200) NULL,
	[QuiHoachChiTiet] [nvarchar](200) NULL,
	[YKienCanBoXetDuyet] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privbldg]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[privbldg](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[privbldg_ci] [int] NULL,
	[privbldg_cm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[privbldg#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[privbldg#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[privbldg] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[privbldg#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[privbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[privbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[privbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[privbldg#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[privbldg#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[privbldg] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[privbldg#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[privbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[privbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[privbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[privbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[privbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[privbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[privbldg] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[privbldg].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parcel#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parcel#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHA#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NHA#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parcel]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parcel](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[parcel_ci] [int] NULL,
	[parcel_cm] [int] NULL,
	[pin] [varchar](12) NULL,
	[site_no] [varchar](9) NULL,
	[surf_area] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[parcel#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[parcel#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[parcel] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[parcel#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[parcel]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[parcel#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[parcel#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[parcel#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[parcel#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[parcel] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[parcel#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[parcel]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[parcel#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[parcel#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[parcel]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[parcel#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[parcel#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[parcel] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[parcel].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NHA](
	[ToBanDo] [varchar](50) NULL,
	[SoThua] [varchar](50) NULL,
	[SoNha] [varchar](50) NULL,
	[LoaiNha] [varchar](50) NULL,
	[DienTich] [decimal](19, 2) NULL,
	[FeatureID] [varchar](100) NULL,
	[MaDonViHanhChinh] [int] NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
 CONSTRAINT [PK_NHA] PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[NHA#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[NHA#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[NHA] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[NHA]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[NHA#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[NHA#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[NHA#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[NHA] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[NHA]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[NHA#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[NHA]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[NHA#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[NHA#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[NHA] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[NHA].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSOANHOSOTHUADAT#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lake#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[lake#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLSOANHOSOTHUADAT](
	[MaHoSoCapGCN] [bigint] NULL,
	[MaDoiTuong] [int] NULL,
	[ToBanDo] [varchar](50) NULL,
	[SoThua] [varchar](50) NULL,
	[DienTich] [decimal](19, 2) NULL,
	[featureID] [int] NULL,
	[TYLEIN] [float] NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
	[Temp] [bit] NULL,
	[FixZoom] [float] NULL,
 CONSTRAINT [PK_TBLSOANHOSOTHUADAT] PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLSOANHOSOTHUADAT#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[TBLSOANHOSOTHUADAT] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLSOANHOSOTHUADAT#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLSOANHOSOTHUADAT#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[TBLSOANHOSOTHUADAT] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLSOANHOSOTHUADAT#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[TBLSOANHOSOTHUADAT] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[TBLSOANHOSOTHUADAT].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lake]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[lake](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[sw_member1] [int] NULL,
	[lake_ci] [int] NULL,
	[lake_cm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[lake#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[lake#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[lake] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[lake#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[lake]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[lake#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[lake#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[lake#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[lake#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[lake] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[lake#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[lake]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[lake#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[lake#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[lake]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[lake#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[lake#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[lake] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[lake].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADATLICHSU#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[flood100#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[flood100#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADAT1](
	[tobando] [varchar](50) NULL,
	[sothua] [varchar](50) NULL,
	[dientich] [decimal](19, 2) NULL,
	[featureID] [varchar](100) NULL,
	[TYLEIN] [float] NULL,
	[Status] [int] NULL,
	[MaDonViHanhChinh] [varchar](50) NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLDLIEUKGIANTHUADAT1#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLDLIEUKGIANTHUADAT1#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[TBLDLIEUKGIANTHUADAT1].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianThuaDat](
	[ToBanDo] [varchar](254) NULL,
	[SoThua] [varchar](254) NULL,
	[DienTichTuNhien] [decimal](19, 1) NULL,
	[featureID] [varchar](100) NULL,
	[TYLEIN] [float] NULL,
	[Status] [int] NULL,
	[MaDonViHanhChinh] [int] NULL,
	[DanhSachMaThuaDatCha] [varchar](254) NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
 CONSTRAINT [PK_tblDLieuKGianThuaDat] PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[tblDLieuKGianThuaDat#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[tblDLieuKGianThuaDat] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[tblDLieuKGianThuaDat]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[tblDLieuKGianThuaDat#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[tblDLieuKGianThuaDat] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[tblDLieuKGianThuaDat]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[tblDLieuKGianThuaDat]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[tblDLieuKGianThuaDat#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[tblDLieuKGianThuaDat] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[tblDLieuKGianThuaDat].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADAT1#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADAT1#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[flood100]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[flood100](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[flood100_ci] [int] NULL,
	[flood100_cm] [int] NULL,
	[flood_type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[flood100#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[flood100#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[flood100] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[flood100#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[flood100]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[flood100#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[flood100#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[flood100#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[flood100#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[flood100] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[flood100#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[flood100]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[flood100#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[flood100#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[flood100]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[flood100#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[flood100#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[flood100] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[flood100].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDLieuKGianThuaDat#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblDLieuKGianThuaDat#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANQUIHOACH#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANQUIHOACH](
	[MaDonViHanhChinh] [int] NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
 CONSTRAINT [PK_TBLDLIEUKGIANQUIHOACH] PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLDLIEUKGIANQUIHOACH#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANQUIHOACH#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[TBLDLIEUKGIANQUIHOACH#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[TBLDLIEUKGIANQUIHOACH].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBLDLIEUKGIANTHUADATLICHSU](
	[NgayBienDong] [smalldatetime] NULL CONSTRAINT [DF_TBLDLIEUKGIANTHUADATLICHSU_NgayBienDong]  DEFAULT (getdate()),
	[LoaiBienDong] [nvarchar](50) NULL,
	[ToBanDo] [varchar](50) NULL,
	[SoThua] [varchar](500) NULL,
	[DienTichTuNhien] [decimal](19, 1) NULL,
	[featureID] [varchar](100) NULL,
	[TYLEIN] [float] NULL,
	[Status] [int] NULL,
	[MaDonViHanhChinh] [int] NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
	[DanhSachMaThuaDatCha] [nvarchar](500) NULL,
	[DanhSachMaThuaDatCon] [nvarchar](500) NULL,
 CONSTRAINT [PK_TBLDLIEUKGIANTHUADATLICHSU] PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[TBLDLIEUKGIANTHUADATLICHSU#d#SW_GEOMETRY#d#SW_MEMBER] 
ON [dbo].[TBLDLIEUKGIANTHUADATLICHSU] 	
FOR DELETE AS 	
BEGIN 	
DECLARE @one integer 
SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER]
WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	
DECLARE @unique_name varchar(64) 	
DECLARE @tmp_key_tab varchar(64) 	
SELECT @unique_name = cast (NEWID() as varchar(64)) 
SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 
EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	

DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	
OPEN spatialtable_d_cur 	
DECLARE @spatialtable_d_key integer 	
FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	
WHILE (@@FETCH_STATUS = 0) 	
BEGIN 
EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 
FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	
END 
CLOSE spatialtable_d_cur 	
DEALLOCATE spatialtable_d_cur 
EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	
EXEC (''DROP TABLE '' + @tmp_key_tab) 	
END
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TBLDLIEUKGIANTHUADATLICHSU#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[TBLDLIEUKGIANTHUADATLICHSU#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [dbo].[TBLDLIEUKGIANTHUADATLICHSU] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[TBLDLIEUKGIANTHUADATLICHSU].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spotelev#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[spotelev#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spotelev]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[spotelev](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[spotelev_ci] [int] NULL,
	[spotelev_cm] [int] NULL,
	[ptelev] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[spotelev#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[spotelev#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[spotelev] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[spotelev#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[spotelev]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[spotelev#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[spotelev#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[spotelev#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[spotelev#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[spotelev] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[spotelev#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[spotelev]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[spotelev#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[spotelev#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[spotelev]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[spotelev#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[spotelev#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[spotelev] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[spotelev].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pubbldg#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[rdpaved#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[rdpaved](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[rdname] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[rdpaved#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[rdpaved] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[rdpaved#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[rdpaved]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[rdpaved#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[rdpaved#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[rdpaved#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[rdpaved#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[rdpaved] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[rdpaved#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[rdpaved]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[rdpaved#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[rdpaved#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[rdpaved]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[rdpaved#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[rdpaved#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[rdpaved] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[rdpaved].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG#t#SW_GEOMETRY#t#SW_MEMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HIENTRANG#t#SW_GEOMETRY#t#SW_MEMBER](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pubbldg](
	[sw_member] [int] IDENTITY(1,1) NOT NULL,
	[sw_geometry] [dbo].[st_spatial] NULL,
	[bldg_type] [int] NULL,
	[bldg_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sw_member] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg#d#sw_geometry#d#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[pubbldg#d#sw_geometry#d#sw_member] 	ON [georgetown].[dbo].[pubbldg] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[pubbldg#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[pubbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[pubbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[pubbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[pubbldg#iu#sw_geometry#iu#sw_member]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[pubbldg#iu#sw_geometry#iu#sw_member] 	ON [georgetown].[dbo].[pubbldg] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([sw_geometry]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[pubbldg#r#sw_geometry#r#sw_member] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [sw_member] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[pubbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[pubbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[pubbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [sw_member] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[pubbldg]'', ''[sw_member]'', ''[sw_geometry]'', ''[georgetown].[dbo].[pubbldg#m#sw_geometry#m#sw_member]'', ''[georgetown].[dbo].[pubbldg#r#sw_geometry#r#sw_member]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[pubbldg] SET [sw_geometry] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[pubbldg].[sw_member] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HIENTRANG](
	[HoTenChu] [char](50) NULL,
	[XuDong] [char](20) NULL,
	[DienTich] [decimal](4, 0) NULL,
	[GhiChu] [char](15) NULL,
	[MI_STYLE] [varchar](254) NULL,
	[SW_MEMBER] [int] IDENTITY(1,1) NOT NULL,
	[SW_GEOMETRY] [dbo].[st_spatial] NULL,
PRIMARY KEY CLUSTERED 
(
	[SW_MEMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG#d#SW_GEOMETRY#d#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[HIENTRANG#d#SW_GEOMETRY#d#SW_MEMBER] 	ON [georgetown].[dbo].[HIENTRANG] 	FOR DELETE AS 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''insert into '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[HIENTRANG]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[HIENTRANG#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	END' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[HIENTRANG#iu#SW_GEOMETRY#iu#SW_MEMBER]'))
EXEC dbo.sp_executesql @statement = N'	CREATE TRIGGER [dbo].[HIENTRANG#iu#SW_GEOMETRY#iu#SW_MEMBER] 	ON [georgetown].[dbo].[HIENTRANG] 	FOR INSERT, UPDATE AS 	BEGIN 	IF UPDATE([SW_GEOMETRY]) 	BEGIN 	DECLARE @one integer 	SELECT @one = 1 FROM [georgetown].[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER] WITH (TABLOCKX, HOLDLOCK) WHERE id = 0 	DECLARE @unique_name varchar(64) 	DECLARE @tmp_key_tab varchar(64) 	DECLARE @tmp_ret_tab varchar(64) 	DECLARE @is_hgblob integer 	SET @is_hgblob = 1 	SELECT @unique_name = cast (NEWID() as varchar(64)) 	SET @tmp_key_tab = ''[##'' + @unique_name + '']'' 	EXEC (''CREATE TABLE ''+ @tmp_key_tab + '' (keyvalue integer primary key)'') 	SET @tmp_ret_tab = ''[##'' + @unique_name + ''1]'' 	EXEC (''CREATE TABLE ''+ @tmp_ret_tab + '' (keyvalue integer primary key,spatialvalue image)'') 	DECLARE spatialtable_d_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM deleted 	OPEN spatialtable_d_cur 	DECLARE @spatialtable_d_key integer 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_d_key + '')'') 	FETCH NEXT FROM spatialtable_d_cur INTO @spatialtable_d_key 	END 	CLOSE spatialtable_d_cur 	DEALLOCATE spatialtable_d_cur 	EXEC master..xp_rtree_bat_delete_trigger ''[georgetown].[dbo].[HIENTRANG]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[HIENTRANG#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab 	EXEC (''delete from '' + @tmp_key_tab) 	DECLARE spatialtable_iu_cur CURSOR FOR 	SELECT [SW_MEMBER] FROM inserted 	OPEN spatialtable_iu_cur 	DECLARE @spatialtable_iu_key integer 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	WHILE (@@FETCH_STATUS = 0) 	BEGIN 	EXEC (''INSERT INTO '' + @tmp_key_tab + ''(keyvalue) values ('' + @spatialtable_iu_key + '')'') 	FETCH NEXT FROM spatialtable_iu_cur INTO @spatialtable_iu_key 	END 	CLOSE spatialtable_iu_cur 	DEALLOCATE spatialtable_iu_cur 	EXEC master..xp_rtree_bat_insert_trigger ''[georgetown].[dbo].[HIENTRANG]'', ''[SW_MEMBER]'', ''[SW_GEOMETRY]'', ''[georgetown].[dbo].[HIENTRANG#m#SW_GEOMETRY#m#SW_MEMBER]'', ''[georgetown].[dbo].[HIENTRANG#r#SW_GEOMETRY#r#SW_MEMBER]'', @tmp_key_tab, @tmp_ret_tab, @is_hgblob OUTPUT 	IF @is_hgblob = 0 BEGIN 	EXEC (''UPDATE[georgetown].[dbo].[HIENTRANG] SET [SW_GEOMETRY] = a.spatialvalue FROM ''+ @tmp_ret_tab  + '' AS a WHERE [georgetown].[dbo].[HIENTRANG].[SW_MEMBER] = a.keyvalue '') 	END 	EXEC (''DROP TABLE '' + @tmp_key_tab) 	EXEC (''DROP TABLE '' + @tmp_ret_tab) 	END 	END' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privbldg#t#sw_geometry#t#sw_member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[privbldg#t#sw_geometry#t#sw_member](
	[keyvalue] [int] NOT NULL,
	[spatialvalue] [dbo].[st_spatial] NULL,
UNIQUE NONCLUSTERED 
(
	[keyvalue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
