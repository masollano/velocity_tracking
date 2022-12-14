USE [master]
GO

/****** Object:  Database [velocity_tracking]    Script Date: 04/11/2022 2:46:03 am ******/
CREATE DATABASE [velocity_tracking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'velocity_tracking', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\velocity_tracking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'velocity_tracking_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\velocity_tracking_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [velocity_tracking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [velocity_tracking] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [velocity_tracking] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [velocity_tracking] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [velocity_tracking] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [velocity_tracking] SET ARITHABORT OFF 
GO

ALTER DATABASE [velocity_tracking] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [velocity_tracking] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [velocity_tracking] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [velocity_tracking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [velocity_tracking] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [velocity_tracking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [velocity_tracking] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [velocity_tracking] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [velocity_tracking] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [velocity_tracking] SET  DISABLE_BROKER 
GO

ALTER DATABASE [velocity_tracking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [velocity_tracking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [velocity_tracking] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [velocity_tracking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [velocity_tracking] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [velocity_tracking] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [velocity_tracking] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [velocity_tracking] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [velocity_tracking] SET  MULTI_USER 
GO

ALTER DATABASE [velocity_tracking] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [velocity_tracking] SET DB_CHAINING OFF 
GO

ALTER DATABASE [velocity_tracking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [velocity_tracking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [velocity_tracking] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [velocity_tracking] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [velocity_tracking] SET QUERY_STORE = OFF
GO

ALTER DATABASE [velocity_tracking] SET  READ_WRITE 
GO


