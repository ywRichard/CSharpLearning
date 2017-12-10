
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/09/2017 17:25:16
-- Generated from EDMX file: C:\Users\Admin\Desktop\GitHub\07_MvcOA\07_MvcOA.Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OAEntities];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserInfoR_UserInfo_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_UserInfo_ActionInfo] DROP CONSTRAINT [FK_UserInfoR_UserInfo_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoRoleInfo_UserInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoRoleInfo] DROP CONSTRAINT [FK_UserInfoRoleInfo_UserInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoRoleInfo_RoleInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoRoleInfo] DROP CONSTRAINT [FK_UserInfoRoleInfo_RoleInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_R_UserInfo_ActionInfoActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_UserInfo_ActionInfo] DROP CONSTRAINT [FK_R_UserInfo_ActionInfoActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ActionInfoRoleInfo_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionInfoRoleInfo] DROP CONSTRAINT [FK_ActionInfoRoleInfo_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ActionInfoRoleInfo_RoleInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionInfoRoleInfo] DROP CONSTRAINT [FK_ActionInfoRoleInfo_RoleInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ActionInfoDepartment_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionInfoDepartment] DROP CONSTRAINT [FK_ActionInfoDepartment_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ActionInfoDepartment_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionInfoDepartment] DROP CONSTRAINT [FK_ActionInfoDepartment_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoDepartment_UserInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoDepartment] DROP CONSTRAINT [FK_UserInfoDepartment_UserInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoDepartment_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoDepartment] DROP CONSTRAINT [FK_UserInfoDepartment_Department];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO
IF OBJECT_ID(N'[dbo].[ActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[RoleInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleInfo];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[R_UserInfo_ActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[R_UserInfo_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[Book]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Book];
GO
IF OBJECT_ID(N'[dbo].[KeywordsRank]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KeywordsRank];
GO
IF OBJECT_ID(N'[dbo].[SearchDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SearchDetails];
GO
IF OBJECT_ID(N'[dbo].[UserInfoRoleInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoRoleInfo];
GO
IF OBJECT_ID(N'[dbo].[ActionInfoRoleInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionInfoRoleInfo];
GO
IF OBJECT_ID(N'[dbo].[ActionInfoDepartment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionInfoDepartment];
GO
IF OBJECT_ID(N'[dbo].[UserInfoDepartment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoDepartment];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(32)  NOT NULL,
    [UserPwd] nvarchar(32)  NOT NULL,
    [SubTime] datetime  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [ModifiedOn] datetime  NOT NULL,
    [Remark] nvarchar(max)  NOT NULL,
    [Sort] int  NOT NULL
);
GO

-- Creating table 'ActionInfo'
CREATE TABLE [dbo].[ActionInfo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SubTime] datetime  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [ModifiedOn] datetime  NOT NULL,
    [Remark] nvarchar(256)  NULL,
    [Url] nvarchar(512)  NOT NULL,
    [HttpMethod] nvarchar(32)  NOT NULL,
    [ActionMethodName] nvarchar(32)  NULL,
    [ControllerName] nvarchar(128)  NULL,
    [ActionInfoName] nvarchar(32)  NOT NULL,
    [Sort] nvarchar(max)  NULL,
    [ActionTypeEnum] smallint  NOT NULL,
    [MenuIcon] varchar(512)  NULL,
    [IconWidth] int  NOT NULL,
    [IconHeight] int  NOT NULL
);
GO

-- Creating table 'RoleInfo'
CREATE TABLE [dbo].[RoleInfo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(32)  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [SubTime] datetime  NOT NULL,
    [Remark] nvarchar(256)  NULL,
    [ModifiedOn] datetime  NOT NULL,
    [Sort] nvarchar(max)  NULL
);
GO

-- Creating table 'Department'
CREATE TABLE [dbo].[Department] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DepName] nvarchar(32)  NOT NULL,
    [ParentId] int  NOT NULL,
    [TreePath] nvarchar(128)  NOT NULL,
    [Level] int  NOT NULL,
    [IsLeaf] bit  NOT NULL
);
GO

-- Creating table 'R_UserInfo_ActionInfo'
CREATE TABLE [dbo].[R_UserInfo_ActionInfo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserInfoID] int  NOT NULL,
    [ActionInfoID] int  NOT NULL,
    [IsPass] bit  NOT NULL
);
GO

-- Creating table 'Book'
CREATE TABLE [dbo].[Book] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(32)  NOT NULL,
    [Author] nvarchar(32)  NOT NULL,
    [PublisherId] int  NOT NULL,
    [PublishDate] datetime  NOT NULL,
    [ISBN] nvarchar(32)  NOT NULL,
    [WordsCount] int  NOT NULL,
    [UnitPrice] decimal(18,0)  NOT NULL,
    [ContentDescription] nvarchar(max)  NOT NULL,
    [AuthorDescription] nvarchar(500)  NULL,
    [EditorComment] nvarchar(200)  NULL,
    [TOC] nvarchar(200)  NULL,
    [Category] smallint  NOT NULL,
    [CategoryId] int  NOT NULL,
    [Clicks] int  NOT NULL
);
GO

-- Creating table 'KeywordsRank'
CREATE TABLE [dbo].[KeywordsRank] (
    [Id] uniqueidentifier  NOT NULL,
    [KeyWords] nvarchar(255)  NOT NULL,
    [SearchCount] int  NOT NULL
);
GO

-- Creating table 'SearchDetails'
CREATE TABLE [dbo].[SearchDetails] (
    [Id] uniqueidentifier  NOT NULL,
    [KeyWords] nvarchar(255)  NOT NULL,
    [SearchDateTime] datetime  NOT NULL
);
GO

-- Creating table 'UserInfoRoleInfo'
CREATE TABLE [dbo].[UserInfoRoleInfo] (
    [UserInfo_UserID] int  NOT NULL,
    [RoleInfo_ID] int  NOT NULL
);
GO

-- Creating table 'ActionInfoRoleInfo'
CREATE TABLE [dbo].[ActionInfoRoleInfo] (
    [ActionInfo_ID] int  NOT NULL,
    [RoleInfo_ID] int  NOT NULL
);
GO

-- Creating table 'ActionInfoDepartment'
CREATE TABLE [dbo].[ActionInfoDepartment] (
    [ActionInfo_ID] int  NOT NULL,
    [Department_ID] int  NOT NULL
);
GO

-- Creating table 'UserInfoDepartment'
CREATE TABLE [dbo].[UserInfoDepartment] (
    [UserInfo_UserID] int  NOT NULL,
    [Department_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [ID] in table 'ActionInfo'
ALTER TABLE [dbo].[ActionInfo]
ADD CONSTRAINT [PK_ActionInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RoleInfo'
ALTER TABLE [dbo].[RoleInfo]
ADD CONSTRAINT [PK_RoleInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Department'
ALTER TABLE [dbo].[Department]
ADD CONSTRAINT [PK_Department]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [PK_R_UserInfo_ActionInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'Book'
ALTER TABLE [dbo].[Book]
ADD CONSTRAINT [PK_Book]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KeywordsRank'
ALTER TABLE [dbo].[KeywordsRank]
ADD CONSTRAINT [PK_KeywordsRank]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SearchDetails'
ALTER TABLE [dbo].[SearchDetails]
ADD CONSTRAINT [PK_SearchDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserInfo_UserID], [RoleInfo_ID] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [PK_UserInfoRoleInfo]
    PRIMARY KEY CLUSTERED ([UserInfo_UserID], [RoleInfo_ID] ASC);
GO

-- Creating primary key on [ActionInfo_ID], [RoleInfo_ID] in table 'ActionInfoRoleInfo'
ALTER TABLE [dbo].[ActionInfoRoleInfo]
ADD CONSTRAINT [PK_ActionInfoRoleInfo]
    PRIMARY KEY CLUSTERED ([ActionInfo_ID], [RoleInfo_ID] ASC);
GO

-- Creating primary key on [ActionInfo_ID], [Department_ID] in table 'ActionInfoDepartment'
ALTER TABLE [dbo].[ActionInfoDepartment]
ADD CONSTRAINT [PK_ActionInfoDepartment]
    PRIMARY KEY CLUSTERED ([ActionInfo_ID], [Department_ID] ASC);
GO

-- Creating primary key on [UserInfo_UserID], [Department_ID] in table 'UserInfoDepartment'
ALTER TABLE [dbo].[UserInfoDepartment]
ADD CONSTRAINT [PK_UserInfoDepartment]
    PRIMARY KEY CLUSTERED ([UserInfo_UserID], [Department_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserInfoID] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [FK_UserInfoR_UserInfo_ActionInfo]
    FOREIGN KEY ([UserInfoID])
    REFERENCES [dbo].[UserInfo]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoR_UserInfo_ActionInfo'
CREATE INDEX [IX_FK_UserInfoR_UserInfo_ActionInfo]
ON [dbo].[R_UserInfo_ActionInfo]
    ([UserInfoID]);
GO

-- Creating foreign key on [UserInfo_UserID] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_UserInfo]
    FOREIGN KEY ([UserInfo_UserID])
    REFERENCES [dbo].[UserInfo]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoleInfo_ID] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_RoleInfo]
    FOREIGN KEY ([RoleInfo_ID])
    REFERENCES [dbo].[RoleInfo]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoRoleInfo_RoleInfo'
CREATE INDEX [IX_FK_UserInfoRoleInfo_RoleInfo]
ON [dbo].[UserInfoRoleInfo]
    ([RoleInfo_ID]);
GO

-- Creating foreign key on [ActionInfoID] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [FK_R_UserInfo_ActionInfoActionInfo]
    FOREIGN KEY ([ActionInfoID])
    REFERENCES [dbo].[ActionInfo]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_R_UserInfo_ActionInfoActionInfo'
CREATE INDEX [IX_FK_R_UserInfo_ActionInfoActionInfo]
ON [dbo].[R_UserInfo_ActionInfo]
    ([ActionInfoID]);
GO

-- Creating foreign key on [ActionInfo_ID] in table 'ActionInfoRoleInfo'
ALTER TABLE [dbo].[ActionInfoRoleInfo]
ADD CONSTRAINT [FK_ActionInfoRoleInfo_ActionInfo]
    FOREIGN KEY ([ActionInfo_ID])
    REFERENCES [dbo].[ActionInfo]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoleInfo_ID] in table 'ActionInfoRoleInfo'
ALTER TABLE [dbo].[ActionInfoRoleInfo]
ADD CONSTRAINT [FK_ActionInfoRoleInfo_RoleInfo]
    FOREIGN KEY ([RoleInfo_ID])
    REFERENCES [dbo].[RoleInfo]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionInfoRoleInfo_RoleInfo'
CREATE INDEX [IX_FK_ActionInfoRoleInfo_RoleInfo]
ON [dbo].[ActionInfoRoleInfo]
    ([RoleInfo_ID]);
GO

-- Creating foreign key on [ActionInfo_ID] in table 'ActionInfoDepartment'
ALTER TABLE [dbo].[ActionInfoDepartment]
ADD CONSTRAINT [FK_ActionInfoDepartment_ActionInfo]
    FOREIGN KEY ([ActionInfo_ID])
    REFERENCES [dbo].[ActionInfo]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Department_ID] in table 'ActionInfoDepartment'
ALTER TABLE [dbo].[ActionInfoDepartment]
ADD CONSTRAINT [FK_ActionInfoDepartment_Department]
    FOREIGN KEY ([Department_ID])
    REFERENCES [dbo].[Department]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionInfoDepartment_Department'
CREATE INDEX [IX_FK_ActionInfoDepartment_Department]
ON [dbo].[ActionInfoDepartment]
    ([Department_ID]);
GO

-- Creating foreign key on [UserInfo_UserID] in table 'UserInfoDepartment'
ALTER TABLE [dbo].[UserInfoDepartment]
ADD CONSTRAINT [FK_UserInfoDepartment_UserInfo]
    FOREIGN KEY ([UserInfo_UserID])
    REFERENCES [dbo].[UserInfo]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Department_ID] in table 'UserInfoDepartment'
ALTER TABLE [dbo].[UserInfoDepartment]
ADD CONSTRAINT [FK_UserInfoDepartment_Department]
    FOREIGN KEY ([Department_ID])
    REFERENCES [dbo].[Department]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoDepartment_Department'
CREATE INDEX [IX_FK_UserInfoDepartment_Department]
ON [dbo].[UserInfoDepartment]
    ([Department_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------