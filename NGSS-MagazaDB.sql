USE [NGSS]
GO
/****** Object:  Table [dbo].[Kartlar]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kartlar](
	[KartID] [int] IDENTITY(1,1) NOT NULL,
	[KartTipi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kartlar] PRIMARY KEY CLUSTERED 
(
	[KartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KayitFatura]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KayitFatura](
	[KayitFaturaID] [int] IDENTITY(1,1) NOT NULL,
	[FaturaNo] [int] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_KayitFatura] PRIMARY KEY CLUSTERED 
(
	[KayitFaturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KKBilgileri]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KKBilgileri](
	[KKID] [int] IDENTITY(1,1) NOT NULL,
	[KartNumarasi] [nvarchar](max) NULL,
	[Ay] [nvarchar](50) NULL,
	[Yıl] [nvarchar](50) NULL,
	[Cvv] [nvarchar](50) NULL,
 CONSTRAINT [PK_KKBilgileri] PRIMARY KEY CLUSTERED 
(
	[KKID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriTable]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriTable](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [nvarchar](50) NULL,
	[MusteriSoyadi] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[KullaniciSifre] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Telefon] [nvarchar](11) NULL,
	[KayıtTarihi] [date] NULL,
 CONSTRAINT [PK_MusteriTable] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sepett]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sepett](
	[SepetID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[UrunFiyati] [bigint] NULL,
	[UrunAdedi] [bigint] NULL,
	[MusteriID] [int] NULL,
 CONSTRAINT [PK_Sepett] PRIMARY KEY CLUSTERED 
(
	[SepetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunFatura]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunFatura](
	[UrunFaturaID] [int] IDENTITY(1,1) NOT NULL,
	[UrunFaturaNo] [nvarchar](50) NULL,
	[KartIndirimi] [float] NULL,
	[FaturaIndirim] [bigint] NULL,
	[ToplamTutar] [bigint] NULL,
	[MusteriID] [int] NULL,
 CONSTRAINT [PK_FaturaTable] PRIMARY KEY CLUSTERED 
(
	[UrunFaturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[Fiyati] [bigint] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunSepet]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunSepet](
	[UrunID] [int] NOT NULL,
	[SepetID] [int] NOT NULL,
 CONSTRAINT [PK_UrunSepet] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC,
	[SepetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Fiyati]) VALUES (1, N'Telefon', 1000)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Fiyati]) VALUES (2, N'Tablet', 2000)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Fiyati]) VALUES (3, N'Televizyon', 3000)
INSERT [dbo].[Urunler] ([UrunID], [UrunAdi], [Fiyati]) VALUES (4, N'Bilgisayar', 4000)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
ALTER TABLE [dbo].[Kartlar]  WITH CHECK ADD  CONSTRAINT [FK_Kartlar_MusteriTable] FOREIGN KEY([KartID])
REFERENCES [dbo].[MusteriTable] ([MusteriID])
GO
ALTER TABLE [dbo].[Kartlar] CHECK CONSTRAINT [FK_Kartlar_MusteriTable]
GO
ALTER TABLE [dbo].[KayitFatura]  WITH CHECK ADD  CONSTRAINT [FK_KayitFatura_MusteriTable] FOREIGN KEY([KayitFaturaID])
REFERENCES [dbo].[MusteriTable] ([MusteriID])
GO
ALTER TABLE [dbo].[KayitFatura] CHECK CONSTRAINT [FK_KayitFatura_MusteriTable]
GO
ALTER TABLE [dbo].[KKBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KKBilgileri_MusteriTable] FOREIGN KEY([KKID])
REFERENCES [dbo].[MusteriTable] ([MusteriID])
GO
ALTER TABLE [dbo].[KKBilgileri] CHECK CONSTRAINT [FK_KKBilgileri_MusteriTable]
GO
ALTER TABLE [dbo].[Sepett]  WITH CHECK ADD  CONSTRAINT [FK_Sepett_MusteriTable] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[MusteriTable] ([MusteriID])
GO
ALTER TABLE [dbo].[Sepett] CHECK CONSTRAINT [FK_Sepett_MusteriTable]
GO
ALTER TABLE [dbo].[UrunFatura]  WITH CHECK ADD  CONSTRAINT [FK_UrunFatura_MusteriTable] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[MusteriTable] ([MusteriID])
GO
ALTER TABLE [dbo].[UrunFatura] CHECK CONSTRAINT [FK_UrunFatura_MusteriTable]
GO
ALTER TABLE [dbo].[UrunSepet]  WITH CHECK ADD  CONSTRAINT [FK_UrunSepet_Sepett] FOREIGN KEY([SepetID])
REFERENCES [dbo].[Sepett] ([SepetID])
GO
ALTER TABLE [dbo].[UrunSepet] CHECK CONSTRAINT [FK_UrunSepet_Sepett]
GO
ALTER TABLE [dbo].[UrunSepet]  WITH CHECK ADD  CONSTRAINT [FK_UrunSepet_Urunler] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urunler] ([UrunID])
GO
ALTER TABLE [dbo].[UrunSepet] CHECK CONSTRAINT [FK_UrunSepet_Urunler]
GO
/****** Object:  StoredProcedure [dbo].[FaturaKayit]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FaturaKayit]
(
	@kullaniciadi nvarchar(50) null
)
as begin
declare @fiyat money
declare @faturano int
declare @kart nvarchar(50)
select @kart=k.KartTipi from MusteriTable m inner join Kartlar k on m.MusteriID=k.KartID where m.KullaniciAdi=@kullaniciadi

if(@kart='Gold')
begin
select @fiyat=300
select @faturano=RAND()*99
insert into KayitFatura
values(@faturano,@fiyat)
end

if(@kart='Silver')
begin
select @fiyat=200
select @faturano=RAND()*99
insert into KayitFatura
values(@faturano,@fiyat)
end

if(@kart='Normal')
begin
select @fiyat=100
select @faturano=RAND()*99
insert into KayitFatura
values(@faturano,@fiyat)
end

if(@kart='Yok')
begin
select @fiyat=0
select @faturano=RAND()*99
insert into KayitFatura
values(@faturano,@fiyat)
end

end
GO
/****** Object:  StoredProcedure [dbo].[Faturasil]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Faturasil]
(
	@kullaniciadi nvarchar(50) null
)
as begin
declare @musteriid int
select @musteriid=u.MusteriID from UrunFatura u inner join MusteriTable m on u.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi

delete from UrunFatura where MusteriID=@musteriid
end
GO
/****** Object:  StoredProcedure [dbo].[FaturaUrun]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FaturaUrun]
(
	@kullaniciadi nvarchar(50) null
)
as begin
declare @faturaNo int
declare @kartindirimi float
declare @sontoplamtutar money
declare @karttipi nvarchar(50)
declare @musteriliksuresi int
declare @uruntipi nvarchar(50)
declare @fiyat money
declare @adet int
declare @toplamfaturaindirim money
declare @musteriID int
declare @telefonmu int
declare @toplam money
declare @toplamkartindirimi money
declare @telefonindirimi money
declare @digerindirimler money
declare @teltoplam money
declare @toplamtelharic money
declare @telsizindirimlitoplam money
declare @hepsimi int
declare @hepsi money
declare @aa money
declare @x int
declare @y int
declare @z int
declare @sontoplamtutar2 money
declare @s money


select @faturaNo=RAND()*99
select @karttipi=k.KartTipi from MusteriTable m inner join Kartlar k on m.MusteriID=k.KartID where m.KullaniciAdi=@kullaniciadi
select @musteriliksuresi=DATEDIFF(YEAR,KayıtTarihi,GETDATE()) from MusteriTable where KullaniciAdi=@kullaniciadi
select @toplam=sum(s.UrunAdedi*s.UrunFiyati)from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi
select @hepsi=sum(s.UrunAdedi*s.UrunFiyati),@hepsimi=1 from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi and s.UrunAdi !='Telefon'
select @teltoplam=sum(s.UrunAdedi*s.UrunFiyati),@telefonmu=1 from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi and UrunAdi='Telefon'
select @uruntipi=s.UrunAdi, @adet=s.UrunAdedi,@fiyat=s.UrunFiyati,@musteriID=s.MusteriID from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi


if(@karttipi='Gold')
select @kartindirimi=0.3

else if(@karttipi='Silver')
select @kartindirimi=0.2

else if(@karttipi='Yok' and @musteriliksuresi<2)
select @kartindirimi=0


--if(@uruntipi='Telefon')
--select @telefonmu=1

else if(@karttipi='Yok' and @musteriliksuresi>2)
select @kartindirimi=0.05


if(@telefonmu=1)
begin
select @toplamtelharic=CAST((@toplam-@teltoplam) as money)
select @toplamkartindirimi=CAST((@toplamtelharic*@kartindirimi) as money)
select @telsizindirimlitoplam=CAST((@toplamtelharic-@toplamkartindirimi) as money)
select @aa=CAST((@telsizindirimlitoplam+@teltoplam) as money)
select @sontoplamtutar=CAST((@aa) as money)
select @x=CAST((@sontoplamtutar/200) as int)*5
select @sontoplamtutar2=(@sontoplamtutar-@x)
end

if(@hepsimi=1)
begin
select @toplamkartindirimi=CAST((@hepsi*@kartindirimi) as money)
select @sontoplamtutar=CAST((@hepsi-@toplamkartindirimi) as money)
select @x=CAST((@sontoplamtutar/200) as int)*5
select @sontoplamtutar2=(@sontoplamtutar-@x)
end


insert into UrunFatura
values(@faturaNo,@kartindirimi,@x,@sontoplamtutar2,@musteriID)
end
GO
/****** Object:  StoredProcedure [dbo].[FaturaUrunn]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FaturaUrunn]
(
	@kullaniciadi nvarchar(50) null
)
as begin
declare @faturano int
declare @kartTipi nvarchar(50)
declare @uyeliksenesi int
declare @kartindirimi float
declare @musteriID int



select @faturano=RAND()*99
select @musteriID=m.MusteriID from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where m.KullaniciAdi=@kullaniciadi 
select @kartTipi=k.KartTipi from Kartlar k inner join MusteriTable m on k.KartID=m.MusteriID where m.KullaniciAdi=@kullaniciadi
select @uyeliksenesi=DATEDIFF(YEAR,KayıtTarihi,GETDATE()) from MusteriTable where KullaniciAdi=@kullaniciadi


if(@kartTipi='Yok' and @uyeliksenesi<2)
begin
select @kartindirimi=0
end

else if(@kartTipi='Yok' and @uyeliksenesi>2)
begin
select @kartindirimi=0.05
end

else if(@kartTipi='Gold')
select @kartindirimi=0.3

else if(@kartTipi='Silver')
select @kartindirimi=0.2

else if(@kartTipi='Normal')
select @kartindirimi=0.1


declare @uruntipi nvarchar(50)
declare @telefonmu int
declare @digerleri int
declare @digerleritoplam bigint
declare @teltoplam bigint

declare @toplam bigint
select @toplam=sum(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where m.KullaniciAdi=@kullaniciadi
declare @yuzdeindirim bigint
declare @aratoplam bigint
declare @faturaindirimi bigint
declare @sontoplam bigint

if(exists(select * from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi and s.UrunAdi = 'Telefon' ))
begin
select @teltoplam=SUM(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID 
where KullaniciAdi=@kullaniciadi and s.UrunAdi = 'Telefon' 
select @yuzdeindirim=(@toplam-@teltoplam)*@kartindirimi
select @aratoplam=@toplam-@yuzdeindirim
select @faturaindirimi=CAST((@aratoplam/200)*5 as bigint)
select @sontoplam=@aratoplam-@faturaindirimi
end

else
begin
select @digerleritoplam=SUM(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID 
where KullaniciAdi=@kullaniciadi and s.UrunAdi != 'Telefon'
select @yuzdeindirim=@digerleritoplam*@kartindirimi
select @aratoplam=@digerleritoplam-@yuzdeindirim
select @faturaindirimi=CAST((@aratoplam/200)*5 as bigint)
select @sontoplam=@aratoplam-@faturaindirimi
end



--select @telefonmu=1,@teltoplam=SUM(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID 
--where KullaniciAdi=@kullaniciadi and s.UrunAdi = 'Telefon' 

--select @digerleri=1,@digerleritoplam=SUM(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID 
--where KullaniciAdi=@kullaniciadi and s.UrunAdi != 'Telefon' 


--if(@telefonmu=1)
--begin
--select @yuzdeindirim=(@toplam-@teltoplam)*@kartindirimi
--select @aratoplam=@toplam-@yuzdeindirim
--select @faturaindirimi=CAST((@aratoplam/200)*5 as bigint)
--select @sontoplam=@aratoplam-@faturaindirimi
--end

--if(@digerleri=1)
--begin
--select @yuzdeindirim=@digerleritoplam*@kartindirimi
--select @aratoplam=@digerleritoplam-@yuzdeindirim
--select @faturaindirimi=CAST((@aratoplam/200)*5 as bigint)
--select @sontoplam=@aratoplam-@faturaindirimi
--end


insert into UrunFatura
values(@faturano,@kartindirimi,@faturaindirimi,@sontoplam,@musteriID)
end
GO
/****** Object:  StoredProcedure [dbo].[Kartekle]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Kartekle]
(
	@kartnumarasi nvarchar(max) null,
	@ay nvarchar(50) null,
	@yil nvarchar(50) null,
	@cvv nvarchar(50) null
)
as begin
declare @id int
select @id=IDENT_CURRENT('MusteriTable')
if(not exists(select * from KKBilgileri where KKID=@id))
insert into KKBilgileri
values(@kartnumarasi,@ay,@yil,@cvv)
end
GO
/****** Object:  StoredProcedure [dbo].[KKekle]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KKekle]
(
	@kartnumarasi nvarchar(max) null,
	@ay nvarchar(50) null,
	@yil nvarchar(50) null,
	@cvv nvarchar(50) null,
	@kullaniciadi nvarchar(50) null
)
as begin
--declare @id int
--select @id=IDENT_CURRENT('MusteriTable')

--if(not exists(select * from KKBilgileri where KKID=@id))
--insert into KKBilgileri
--values(@kartnumarasi,@ay,@yil,@cvv)

declare @idd int
select @idd=m.MusteriID from MusteriTable m inner join KKBilgileri k on m.MusteriID=k.KKID where m.KullaniciAdi=@kullaniciadi
if(not exists(select * from KKBilgileri where KKID=@idd))
insert into KKBilgileri
values(@kartnumarasi,@ay,@yil,@cvv)
end
GO
/****** Object:  StoredProcedure [dbo].[musterigiris]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[musterigiris]
(
	@kullaniciadi nvarchar(50) null,
	@sifre nvarchar(50) null,
	@id int out
)
as begin
if(not exists(select KullaniciAdi from MusteriTable where KullaniciAdi=@kullaniciadi and KullaniciSifre=@sifre))
select @id=0
else
select @id=1
end
GO
/****** Object:  StoredProcedure [dbo].[musteriuyeol]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[musteriuyeol]
(
	@Adi nvarchar(50) null,
	@SoyAdi nvarchar(50) null,
	@Telefon nvarchar(11) null,
	@mail nvarchar(max) null,
	@kullaniciadi nvarchar(50) null,
	@sifre nvarchar(50) null,
	@KayitTarihi date null,
	@KartTipi nvarchar(50) null,
	@id int out
)
as begin
if(exists(select MusteriAdi from MusteriTable where KullaniciAdi=@kullaniciadi))
select @id=1
else
insert into MusteriTable
values(@Adi,@SoyAdi,@kullaniciadi,@sifre,@mail,@Telefon,@KayitTarihi)
insert into Kartlar
values(@KartTipi)
end
GO
/****** Object:  StoredProcedure [dbo].[SepeteEkle]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SepeteEkle]
(
	@urunadi nvarchar(50) null,
	@urunadedi int null,
	@kullaniciadi nvarchar(50) null
)
as begin
declare @fiyat money
select @fiyat=Fiyati from Urunler where UrunAdi=@urunadi

declare @id int
select @id=MusteriID from MusteriTable where KullaniciAdi=@kullaniciadi

insert into Sepett
values(@urunadi,@fiyat,@urunadedi,@id)

end
GO
/****** Object:  StoredProcedure [dbo].[SepetGuncelle]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SepetGuncelle]
(
	@yeniurunadi nvarchar(50) null,
	@urunadedi int null,
	@kullaniciadi nvarchar(50) null,
	@urunadi nvarchar(50) null
)
as begin

declare @id int
select @id=SepetID from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi and UrunAdi=@urunadi

update Sepett
set UrunAdi=@yeniurunadi,UrunAdedi=@urunadedi where SepetID=@id 

end
GO
/****** Object:  StoredProcedure [dbo].[Sepetisil]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sepetisil]
(
	@kullaniciadi nvarchar(50) null
)
as begin
declare @musteriid int
select @musteriid=s.MusteriID from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi

delete from Sepett where MusteriID=@musteriid
end
GO
/****** Object:  StoredProcedure [dbo].[sepetsil]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sepetsil](
	@kullaniciadi nvarchar(50) null,
	@urunadi nvarchar(50) null
)
as begin
declare @id int
select @id=SepetID from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where KullaniciAdi=@kullaniciadi and UrunAdi=@urunadi
delete from Sepett where SepetID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[siparislistele]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[siparislistele]
(
	@kullaniciadi nvarchar(50) null
)
as begin

declare @kayitsuresi int

select DATEDIFF(YEAR,KayıtTarihi,GETDATE()) as 'KayıtlıSure',* from Sepett s inner join  MusteriTable m on s.MusteriID=m.MusteriID
inner join Kartlar k on k.KartID=m.MusteriID
inner join UrunFatura u on u.MusteriID=m.MusteriID
where m.KullaniciAdi=@kullaniciadi
end
GO
/****** Object:  StoredProcedure [dbo].[siparislistelee]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[siparislistelee]
(
	@kullaniciadi nvarchar(50) null
)
as begin

declare @kayitsuresi int

select DATEDIFF(YEAR,KayıtTarihi,GETDATE()) as 'KayıtlıSure',* from  MusteriTable m
inner join Kartlar k on k.KartID=m.MusteriID
inner join UrunFatura u on u.MusteriID=m.MusteriID
inner join Siparis s on s.SiparisID=u.UrunFaturaID
where m.KullaniciAdi=@kullaniciadi
end
GO
/****** Object:  StoredProcedure [dbo].[toplamfiyat]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[toplamfiyat]
(
	@kullaniciadi nvarchar(50) null,
	@toplamfiyat int out
)
as begin
select @toplamfiyat=sum(s.UrunAdedi*s.UrunFiyati) from Sepett s inner join MusteriTable m on s.MusteriID=m.MusteriID where m.KullaniciAdi=@kullaniciadi
end
GO
/****** Object:  StoredProcedure [dbo].[UyeFaturaListele]    Script Date: 12.04.2022 03:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UyeFaturaListele]
(
	@kullaniciadi nvarchar(50) null
)
as begin
select * from Kartlar k inner join MusteriTable m on k.KartID=m.MusteriID
inner join KayitFatura kf on kf.KayitFaturaID=m.MusteriID
where m.KullaniciAdi=@kullaniciadi
end
GO
