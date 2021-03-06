USE [master]
GO
/****** Object:  Database [Restaurant]    Script Date: 5/31/2020 12:10:33 PM ******/
CREATE DATABASE [Restaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurant', FILENAME = N'C:\Users\Asus\Desktop\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restaurant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restaurant_log', FILENAME = N'C:\Users\Asus\Desktop\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restaurant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Restaurant] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restaurant] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restaurant] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Restaurant] SET QUERY_STORE = OFF
GO
USE [Restaurant]
GO
/****** Object:  Table [dbo].[Alergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alergen](
	[id_alergen] [int] NOT NULL,
	[denumire_alergen] [varchar](50) NULL,
 CONSTRAINT [PK_Alergen] PRIMARY KEY CLUSTERED 
(
	[id_alergen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorie_preparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie_preparat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tip_preparat] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorii_preparate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorie_utilizator]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie_utilizator](
	[id_catUser] [int] IDENTITY(1,1) NOT NULL,
	[tip_User] [varchar](50) NULL,
 CONSTRAINT [PK_Categorie_utilizator] PRIMARY KEY CLUSTERED 
(
	[id_catUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comanda]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_utilizator] [int] NOT NULL,
	[id_stare_comanda] [int] NOT NULL,
	[pret] [float] NOT NULL,
	[data_comanda] [date] NULL,
	[cod_comanda] [varchar](10) NULL,
	[ora_livrare] [datetime] NULL,
 CONSTRAINT [PK_Comanda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cont_utilizator]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cont_utilizator](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](50) NULL,
	[prenume] [varchar](50) NULL,
	[nr_tel] [varchar](50) NOT NULL,
	[adresa] [varchar](80) NOT NULL,
	[email] [varchar](50) NULL,
	[parola] [varchar](20) NULL,
	[id_categorie] [int] NOT NULL,
 CONSTRAINT [PK_Cont_utilizator] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fotografie]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fotografie](
	[id_fotografie] [int] IDENTITY(1,1) NOT NULL,
	[url] [varchar](100) NULL,
	[id_preparat] [int] NULL,
 CONSTRAINT [PK_Fotografie] PRIMARY KEY CLUSTERED 
(
	[id_fotografie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[id_preparat] [int] NULL,
	[id_comanda] [int] NULL,
	[id_meniu] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meniu](
	[id_meniu] [int] IDENTITY(1,1) NOT NULL,
	[denumire_meniu] [varchar](50) NULL,
	[fotografie] [varchar](100) NULL,
	[id_categorie] [int] NULL,
 CONSTRAINT [PK_Meniu] PRIMARY KEY CLUSTERED 
(
	[id_meniu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meniu_Preparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meniu_Preparat](
	[id_meniu_preparat] [int] IDENTITY(1,1) NOT NULL,
	[id_meinu] [int] NOT NULL,
	[id_preparat] [int] NOT NULL,
 CONSTRAINT [PK_Meniu_Preparat] PRIMARY KEY CLUSTERED 
(
	[id_meniu_preparat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preparat](
	[idPreparat] [int] IDENTITY(1,1) NOT NULL,
	[denumire] [varchar](50) NOT NULL,
	[pret] [float] NOT NULL,
	[cantitate_per_portie] [int] NULL,
	[cantitatea_totala] [int] NULL,
	[id_categorie] [int] NOT NULL,
 CONSTRAINT [PK_Preparat] PRIMARY KEY CLUSTERED 
(
	[idPreparat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preparat-Alergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preparat-Alergen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_preparat] [int] NOT NULL,
	[id_alergen] [int] NOT NULL,
 CONSTRAINT [PK_Preparat-Alergen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stare_Comanda]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stare_Comanda](
	[id_stare] [int] IDENTITY(1,1) NOT NULL,
	[denumire_stare] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Stare_Comanda] PRIMARY KEY CLUSTERED 
(
	[id_stare] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comanda]  WITH CHECK ADD  CONSTRAINT [FK_Comanda_Cont_utilizator] FOREIGN KEY([id_utilizator])
REFERENCES [dbo].[Cont_utilizator] ([idUser])
GO
ALTER TABLE [dbo].[Comanda] CHECK CONSTRAINT [FK_Comanda_Cont_utilizator]
GO
ALTER TABLE [dbo].[Comanda]  WITH CHECK ADD  CONSTRAINT [FK_Comanda_Stare] FOREIGN KEY([id_stare_comanda])
REFERENCES [dbo].[Stare_Comanda] ([id_stare])
GO
ALTER TABLE [dbo].[Comanda] CHECK CONSTRAINT [FK_Comanda_Stare]
GO
ALTER TABLE [dbo].[Cont_utilizator]  WITH CHECK ADD  CONSTRAINT [FK_Cont_utilizator_Categorie_utilizator] FOREIGN KEY([id_categorie])
REFERENCES [dbo].[Categorie_utilizator] ([id_catUser])
GO
ALTER TABLE [dbo].[Cont_utilizator] CHECK CONSTRAINT [FK_Cont_utilizator_Categorie_utilizator]
GO
ALTER TABLE [dbo].[Fotografie]  WITH CHECK ADD  CONSTRAINT [FK_Fotografie_Preparat] FOREIGN KEY([id_preparat])
REFERENCES [dbo].[Preparat] ([idPreparat])
GO
ALTER TABLE [dbo].[Fotografie] CHECK CONSTRAINT [FK_Fotografie_Preparat]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Comanda] FOREIGN KEY([id_comanda])
REFERENCES [dbo].[Comanda] ([id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Comanda]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Meniu] FOREIGN KEY([id_meniu])
REFERENCES [dbo].[Meniu] ([id_meniu])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Meniu]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Preparat] FOREIGN KEY([id_preparat])
REFERENCES [dbo].[Preparat] ([idPreparat])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Preparat]
GO
ALTER TABLE [dbo].[Meniu]  WITH CHECK ADD  CONSTRAINT [FK_Meniu_Categorie_preparat] FOREIGN KEY([id_categorie])
REFERENCES [dbo].[Categorie_preparat] ([id])
GO
ALTER TABLE [dbo].[Meniu] CHECK CONSTRAINT [FK_Meniu_Categorie_preparat]
GO
ALTER TABLE [dbo].[Meniu_Preparat]  WITH CHECK ADD  CONSTRAINT [FK_Meniu_Preparat_Meniu] FOREIGN KEY([id_meinu])
REFERENCES [dbo].[Meniu] ([id_meniu])
GO
ALTER TABLE [dbo].[Meniu_Preparat] CHECK CONSTRAINT [FK_Meniu_Preparat_Meniu]
GO
ALTER TABLE [dbo].[Meniu_Preparat]  WITH CHECK ADD  CONSTRAINT [FK_Meniu_Preparat_Preparat] FOREIGN KEY([id_preparat])
REFERENCES [dbo].[Preparat] ([idPreparat])
GO
ALTER TABLE [dbo].[Meniu_Preparat] CHECK CONSTRAINT [FK_Meniu_Preparat_Preparat]
GO
ALTER TABLE [dbo].[Preparat]  WITH CHECK ADD  CONSTRAINT [FK_Preparat_Categorie_preparat] FOREIGN KEY([id_categorie])
REFERENCES [dbo].[Categorie_preparat] ([id])
GO
ALTER TABLE [dbo].[Preparat] CHECK CONSTRAINT [FK_Preparat_Categorie_preparat]
GO
ALTER TABLE [dbo].[Preparat-Alergen]  WITH CHECK ADD  CONSTRAINT [FK_Preparat-Alergen_Alergen] FOREIGN KEY([id_alergen])
REFERENCES [dbo].[Alergen] ([id_alergen])
GO
ALTER TABLE [dbo].[Preparat-Alergen] CHECK CONSTRAINT [FK_Preparat-Alergen_Alergen]
GO
ALTER TABLE [dbo].[Preparat-Alergen]  WITH CHECK ADD  CONSTRAINT [FK_Preparat-Alergen_Preparat] FOREIGN KEY([id_preparat])
REFERENCES [dbo].[Preparat] ([idPreparat])
GO
ALTER TABLE [dbo].[Preparat-Alergen] CHECK CONSTRAINT [FK_Preparat-Alergen_Preparat]
GO
/****** Object:  StoredProcedure [dbo].[AddCategoriePreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCategoriePreparat]
	-- Add the parameters for the stored procedure here
	@tip varchar(50)
AS
BEGIN
	INSERT into [dbo].[Categorie_preparat](tip_preparat) values (@tip) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddClient]
	@nume varchar(50),
	@prenume varchar(50),
	@nr_tel varchar(50),
	@adresa varchar(50),
	@email varchar(50),
	@parola varchar(20),
	@id_categorie int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into [dbo].[Cont_utilizator](nume,prenume,nr_tel,adresa,email,parola,id_categorie) values (@nume,@prenume,@nr_tel,@adresa,@email,@parola,@id_categorie) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddComanda]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddComanda]
	@id_utilizator int,
	@id_stare_comanda int,
	@pret float,
	@data date,
	@cod varchar(10)
AS
BEGIN
	INSERT into [dbo].[Comanda](id_utilizator,id_stare_comanda,pret,data_comanda,cod_comanda) values (@id_utilizator,@id_stare_comanda,@pret,@data,@cod) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddFotografie]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddFotografie]
	@id_preparat int ,
	@url varchar(50)
AS
BEGIN
	INSERT into [dbo].[Fotografie](id_preparat,url) values (@id_preparat,@url)
END
GO
/****** Object:  StoredProcedure [dbo].[AddItemMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AddItemMeniu]
	-- Add the parameters for the stored procedure here
	@id_meniu int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into [dbo].[Item](id_meniu) values (@id_meniu)
END
GO
/****** Object:  StoredProcedure [dbo].[AddItemPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AddItemPreparat]
	-- Add the parameters for the stored procedure here
	@id_preparat int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into [dbo].[Item](id_preparat) values (@id_preparat)
END
GO
/****** Object:  StoredProcedure [dbo].[AddMeniuForComands]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddMeniuForComands]
	@id_meniu int,
	@id_comanda int
AS
BEGIN
	INSERT into [dbo].[Item](id_meniu,id_comanda) values (@id_meniu,@id_comanda) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPreparat]
	@denumire varchar(50),
	@id_categorie int,
	@pret float,
	@cantitateP int,
	@cantitateT int
AS
BEGIN
	INSERT into [dbo].[Preparat](denumire,id_categorie,pret,cantitate_per_portie,cantitatea_totala) values (@denumire,@id_categorie,@pret,@cantitateP,@cantitateT) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddPreparat-Alergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AddPreparat-Alergen]
	@id_preparat int,
	@id_alergen int
AS
BEGIN
	INSERT into [dbo].[Preparat-Alergen](id_preparat,id_alergen) values (@id_preparat,@id_alergen)
END
GO
/****** Object:  StoredProcedure [dbo].[AddPreparatForComands]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPreparatForComands]
	@id_preparat int,
	@id_comanda int
AS
BEGIN
	INSERT into [dbo].[Item](id_preparat,id_comanda) values (@id_preparat,@id_comanda) 
END

GO
/****** Object:  StoredProcedure [dbo].[ComenzileDescrescator]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ComenzileDescrescator]
	
AS
BEGIN
	SELECT * FROM Comanda ORDER BY data_comanda DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteFotografie]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteFotografie]
	@id_preparat int
AS
BEGIN
	delete from [dbo].[Fotografie]
	where id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteMeniu]
	@id int
AS
BEGIN
	delete from [dbo].Meniu
	where id_meniu = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMeniu-Preparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DeleteMeniu-Preparat]
	@id int
AS
BEGIN
	delete from [dbo].Meniu_Preparat
	where id_meinu = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePreparat]
	@id int
AS
BEGIN
	delete from [dbo].[Preparat]
	where idPreparat = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePreparat-Alergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePreparat-Alergen]
	@id_preparat int
AS
BEGIN
	delete from [dbo].[Preparat-Alergen]
	where id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePreparatMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePreparatMeniu]
	@id_preparat int
AS
BEGIN
	delete from [dbo].[Meniu_Preparat]
	where id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetAdresa]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAdresa]
	@id int
AS
BEGIN
	
	SELECT adresa FROM Cont_utilizator WHERE idUser=@id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAlergeniMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAlergeniMeniu]
	@id_meniu int
AS
BEGIN
	SELECT [dbo].[Alergen].denumire_alergen FROM
	[dbo].[Meniu] JOIN [dbo].[Meniu_Preparat] ON [dbo].[Meniu].id_meniu=[dbo].[Meniu_Preparat].id_meinu
	JOIN [dbo].[Preparat] ON [dbo].[Meniu_Preparat].id_preparat=[dbo].[Preparat].idPreparat
	JOIN [dbo].[Preparat-Alergen] ON [dbo].[Preparat].idPreparat=[dbo].[Preparat-Alergen].id_preparat
	JOIN [dbo].[Alergen] ON [dbo].[Preparat-Alergen].id_alergen=[dbo].[Alergen].id_alergen
	WHERE [dbo].[Meniu].id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetCantitate]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCantitate] 
	@id_preparat int
AS
BEGIN
	SELECT cantitate_per_portie
	from [dbo].[Preparat]
	where @id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetCantitateFromPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCantitateFromPreparat]
	@id_meniu int
AS
BEGIN
	SELECT SUM([dbo].[Preparat].cantitate_per_portie) FROM [dbo].[Meniu]
	JOIN [dbo].[Meniu_Preparat] ON [dbo].[Meniu].id_meniu=[dbo].[Meniu_Preparat].id_meinu
	JOIN [dbo].[Preparat] ON [dbo].[Meniu_Preparat].id_preparat=[dbo].[Preparat].idPreparat
	WHERE [dbo].[Meniu].id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetCantitateMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCantitateMeniu]
	@id_meniu int
AS
BEGIN
	SELECT [dbo].[Preparat].cantitate_per_portie FROM
	[dbo].[Meniu] JOIN [dbo].[Meniu_Preparat] ON [dbo].[Meniu].id_meniu=[dbo].[Meniu_Preparat].id_meinu
	JOIN [dbo].[Preparat] ON [dbo].[Meniu_Preparat].id_preparat=[dbo].[Preparat].idPreparat
	WHERE [dbo].[Meniu].id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetCategorie]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCategorie]
	@id_cat int
AS
BEGIN
	SELECT tip_preparat
	from [dbo].[Categorie_preparat]
	where id = @id_cat
END
GO
/****** Object:  StoredProcedure [dbo].[GetDenumireAlergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDenumireAlergen]
	@id_preparat int
AS
BEGIN  
  SELECT 
     [dbo].[Alergen].denumire_alergen
  FROM [dbo].[Preparat] 
  JOIN [dbo].[Preparat-Alergen]  ON [dbo].[Preparat].idPreparat=[dbo].[Preparat-Alergen].id_preparat
  JOIN [dbo].[Alergen] ON [dbo].[Preparat-Alergen].id_alergen=[dbo].Alergen.id_alergen
  WHERE [dbo].[Preparat].idPreparat= @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetIdAlergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIdAlergen]
	@denumire varchar(50)
AS
BEGIN
	SELECT id_alergen
	from [dbo].[Alergen]
	where denumire_alergen = @denumire
END
GO
/****** Object:  StoredProcedure [dbo].[GetIdMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIdMeniu]
	@id_preparat int
AS
BEGIN
	SELECT id_meinu
	from [dbo].[Meniu_Preparat]
	where id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetIDPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIDPreparat] 
	@id_meniu int
AS
BEGIN
	SELECT id_preparat
	from [dbo].[Meniu_Preparat]
	where id_meinu = @id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetIDPreparatFromAlergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIDPreparatFromAlergen]
	@denumire varchar(50)
AS
BEGIN
	SELECT [dbo].[Preparat-Alergen].id_preparat FROM [dbo].[Alergen]
	JOIN [dbo].[Preparat-Alergen] ON [dbo].[Alergen].id_alergen=[dbo].[Preparat-Alergen].id_alergen
	WHERE [dbo].[Alergen].denumire_alergen=@denumire
END
GO
/****** Object:  StoredProcedure [dbo].[GetIdPreparatFromPM]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIdPreparatFromPM] 
	@id_meniu int
AS
BEGIN
	SELECT id_preparat
	FROM [dbo].[Meniu_Preparat]
	WHERE id_meinu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetMeniu]
	@id_meniu int
AS
BEGIN
	
	SELECT denumire_meniu
	FROM [dbo].[Meniu]
	WHERE id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetNume]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetNume]
	@id int
AS
BEGIN
	
	SELECT nume FROM Cont_utilizator WHERE idUser=@id
END
GO
/****** Object:  StoredProcedure [dbo].[GetPrenume]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPrenume]
	@id int
AS
BEGIN
	
	SELECT prenume FROM Cont_utilizator WHERE idUser=@id
END
GO
/****** Object:  StoredProcedure [dbo].[GetPreparatCantitate]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPreparatCantitate]
	@id_preparat int
AS
BEGIN
	SELECT cantitate_per_portie
	FROM [dbo].[Preparat]
	WHERE idPreparat=@id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetPreparatDenumire]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPreparatDenumire]
	@id_preparat int
AS
BEGIN
	SELECT denumire
	FROM [dbo].[Preparat]
	WHERE idPreparat=@id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetPreparatPret]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPreparatPret]
	@id_preparat int
AS
BEGIN
	SELECT pret
	FROM [dbo].[Preparat]
	WHERE idPreparat=@id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetPret]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPret] 
	@id_preparat int
AS
BEGIN
	SELECT pret
	from [dbo].[Preparat]
	where @id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[GetPretFromPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPretFromPreparat]
	@id_meniu int
AS
BEGIN
	SELECT SUM([dbo].[Preparat].pret) FROM [dbo].[Meniu]
	JOIN [dbo].[Meniu_Preparat] ON [dbo].[Meniu].id_meniu=[dbo].[Meniu_Preparat].id_meinu
	JOIN [dbo].[Preparat] ON [dbo].[Meniu_Preparat].id_preparat=[dbo].[Preparat].idPreparat
	WHERE [dbo].[Meniu].id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetPretMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPretMeniu]
	@id_meniu int
AS
BEGIN
	SELECT SUM([dbo].[Preparat].pret) FROM 
	[dbo].[Meniu] JOIN [dbo].[Meniu_Preparat] ON [dbo].[Meniu].id_meniu=[dbo].[Meniu_Preparat].id_meinu
	JOIN [dbo].[Preparat] ON [dbo].[Meniu_Preparat].id_preparat=[dbo].[Preparat].idPreparat
	WHERE [dbo].[Meniu].id_meniu=@id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[GetStare]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetStare]
	@id int
AS
BEGIN
	SELECT denumire_stare
	FROM [dbo].[Stare_Comanda]
	WHERE id_stare=@id
END
GO
/****** Object:  StoredProcedure [dbo].[GetTelefon]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTelefon]
	@id int
AS
BEGIN
	
	SELECT nr_tel FROM Cont_utilizator WHERE idUser=@id
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserId]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetUserId] 
	@email varchar(50)
AS
BEGIN
	SELECT idUser
	from [dbo].[Cont_utilizator]
	where email = @email
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserType]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUserType] 
	@email varchar(50)
AS
BEGIN
	SELECT id_categorie
	from [dbo].[Cont_utilizator]
	where email = @email
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyCantitateLaAnulare]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ModifyCantitateLaAnulare] 
	@id_preparat int
AS
BEGIN
	update [dbo].[Preparat]
	set cantitatea_totala = cantitatea_totala+cantitate_per_portie
	where idPreparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyCantitatePreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyCantitatePreparat] 
	@id_preparat int,
	@cantitate int
AS
BEGIN
	update [dbo].[Preparat]
	set cantitatea_totala = cantitatea_totala-@cantitate
	where idPreparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyFotografie]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyFotografie] 
	@id_preparat int,
	@denumire varchar(50)
AS
BEGIN
	update [dbo].[Fotografie]
	set url=@denumire
	where id_preparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyMeniu]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyMeniu] 
	@id_meniu int,
	@denumire varchar(50),
	@fotografie varchar(50),
	@categorie int
AS
BEGIN
	update [dbo].[Meniu]
	set denumire_meniu = @denumire, fotografie = @fotografie, id_categorie=@categorie
	where id_meniu = @id_meniu
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyPreparat]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyPreparat] 
	@id_preparat int,
	@denumire varchar(50),
	@pret float,
	@cantitateP int,
	@cantitateT int,
	@categorie int
AS
BEGIN
	update [dbo].[Preparat]
	set denumire = @denumire, pret = @pret, cantitate_per_portie=@cantitateP, cantitatea_totala=@cantitateT,
	id_categorie=@categorie
	where idPreparat = @id_preparat
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyStare]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyStare] 
	@id_stare int,
	@id int,
	@ora datetime
AS
BEGIN
	update [dbo].[Comanda]
	set id_stare_comanda = @id_stare, ora_livrare=@ora
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyStareFaraOra]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModifyStareFaraOra] 
	@id_stare int,
	@id int
AS
BEGIN
	update [dbo].[Comanda]
	set id_stare_comanda = @id_stare
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ShowAlergeni]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE[dbo].[ShowAlergeni] 
	@id int
AS
BEGIN
	SELECT id_alergen
	from [dbo].[Preparat-Alergen]
	where id_preparat = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ShowPictures]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ShowPictures] 
	@id int
AS
BEGIN
	SELECT url
	from [dbo].[Fotografie]
	where id_preparat = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Shows_name_allergen]    Script Date: 5/31/2020 12:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Shows_name_allergen] 
	@id int
AS
BEGIN
	SELECT denumire_alergen
	from [dbo].[Alergen]
	where id_alergen = @id
END
GO
USE [master]
GO
ALTER DATABASE [Restaurant] SET  READ_WRITE 
GO
