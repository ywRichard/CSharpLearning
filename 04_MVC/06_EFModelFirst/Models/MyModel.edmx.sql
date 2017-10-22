
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/22/2017 13:04:09
-- Generated from EDMX file: C:\Users\Admin\Desktop\GitHub\04_MVC\06_EFModelFirst\Models\MyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestDemo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BookTypeBookInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookInfo] DROP CONSTRAINT [FK_BookTypeBookInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BookType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookType];
GO
IF OBJECT_ID(N'[dbo].[BookInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BookType'
CREATE TABLE [dbo].[BookType] (
    [TypeId] int IDENTITY(1,1) NOT NULL,
    [TypeTitle] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'BookInfo'
CREATE TABLE [dbo].[BookInfo] (
    [BookId] int IDENTITY(1,1) NOT NULL,
    [BookTitle] nvarchar(100)  NOT NULL,
    [BookTid] int  NOT NULL,
    [BookContent] nvarchar(400)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TypeId] in table 'BookType'
ALTER TABLE [dbo].[BookType]
ADD CONSTRAINT [PK_BookType]
    PRIMARY KEY CLUSTERED ([TypeId] ASC);
GO

-- Creating primary key on [BookId] in table 'BookInfo'
ALTER TABLE [dbo].[BookInfo]
ADD CONSTRAINT [PK_BookInfo]
    PRIMARY KEY CLUSTERED ([BookId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BookTid] in table 'BookInfo'
ALTER TABLE [dbo].[BookInfo]
ADD CONSTRAINT [FK_BookTypeBookInfo]
    FOREIGN KEY ([BookTid])
    REFERENCES [dbo].[BookType]
        ([TypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookTypeBookInfo'
CREATE INDEX [IX_FK_BookTypeBookInfo]
ON [dbo].[BookInfo]
    ([BookTid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------