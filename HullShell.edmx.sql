
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2018 02:11:30
-- Generated from EDMX file: E:\Files Saved\VS2010Prject\HullShellDataBase\src\HullShellTest\HullShell.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HSData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MaterialHullShell]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StdHullShellSet] DROP CONSTRAINT [FK_MaterialHullShell];
GO
IF OBJECT_ID(N'[dbo].[FK_HullShellModelingParameter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_HullShellModelingParameter];
GO
IF OBJECT_ID(N'[dbo].[FK_stdHullShellTheoryPoints]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StdHullShellSet] DROP CONSTRAINT [FK_stdHullShellTheoryPoints];
GO
IF OBJECT_ID(N'[dbo].[FK_ProcessingEquipmentModelingParameter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_ProcessingEquipmentModelingParameter];
GO
IF OBJECT_ID(N'[dbo].[FK_SoftwareModelingParameter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_SoftwareModelingParameter];
GO
IF OBJECT_ID(N'[dbo].[FK_DetectEquipmentModelingParameter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_DetectEquipmentModelingParameter];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelingParameterScanPoints]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_ModelingParameterScanPoints];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelingParameterDefectsList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DefectsListSet] DROP CONSTRAINT [FK_ModelingParameterDefectsList];
GO
IF OBJECT_ID(N'[dbo].[FK_AdminsModelingParameter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_AdminsModelingParameter];
GO
IF OBJECT_ID(N'[dbo].[FK_stdHullShellResilienceFactor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResilienceFactorSet] DROP CONSTRAINT [FK_stdHullShellResilienceFactor];
GO
IF OBJECT_ID(N'[dbo].[FK_ScanPointsPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PointSet] DROP CONSTRAINT [FK_ScanPointsPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_TheoryPointsPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PointSet] DROP CONSTRAINT [FK_TheoryPointsPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_ExcessPointsPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PointSet] DROP CONSTRAINT [FK_ExcessPointsPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_EdgeEdgePointsPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PointSet] DROP CONSTRAINT [FK_EdgeEdgePointsPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_RiblinePointsPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PointSet] DROP CONSTRAINT [FK_RiblinePointsPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelingParameterHeightValues]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelingParameterSet] DROP CONSTRAINT [FK_ModelingParameterHeightValues];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelingParameterInterpolationFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InterpolationFileSet] DROP CONSTRAINT [FK_ModelingParameterInterpolationFile];
GO
IF OBJECT_ID(N'[dbo].[FK_InterpolationFileHeightValueList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HeightValueListSet] DROP CONSTRAINT [FK_InterpolationFileHeightValueList];
GO
IF OBJECT_ID(N'[dbo].[FK_AdjustShapeFileHeightValueList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HeightValueListSet] DROP CONSTRAINT [FK_AdjustShapeFileHeightValueList];
GO
IF OBJECT_ID(N'[dbo].[FK_StdHullShellRiblinePoints]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RiblinePointsSet] DROP CONSTRAINT [FK_StdHullShellRiblinePoints];
GO
IF OBJECT_ID(N'[dbo].[FK_StdHullShellExcessPoints]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExcessPointsSet] DROP CONSTRAINT [FK_StdHullShellExcessPoints];
GO
IF OBJECT_ID(N'[dbo].[FK_StdHullShellEdgeEdgePoints]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EdgeEdgePointsSet] DROP CONSTRAINT [FK_StdHullShellEdgeEdgePoints];
GO
IF OBJECT_ID(N'[dbo].[FK_StdHullShellBoundingBox]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BoundingBoxSet] DROP CONSTRAINT [FK_StdHullShellBoundingBox];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[StdHullShellSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StdHullShellSet];
GO
IF OBJECT_ID(N'[dbo].[MaterialSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaterialSet];
GO
IF OBJECT_ID(N'[dbo].[ModelingParameterSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelingParameterSet];
GO
IF OBJECT_ID(N'[dbo].[ProcessingEquipmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProcessingEquipmentSet];
GO
IF OBJECT_ID(N'[dbo].[SoftwareSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SoftwareSet];
GO
IF OBJECT_ID(N'[dbo].[ScanPointsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScanPointsSet];
GO
IF OBJECT_ID(N'[dbo].[TheoryPointsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheoryPointsSet];
GO
IF OBJECT_ID(N'[dbo].[ExcessPointsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExcessPointsSet];
GO
IF OBJECT_ID(N'[dbo].[EdgeEdgePointsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EdgeEdgePointsSet];
GO
IF OBJECT_ID(N'[dbo].[FirstPointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FirstPointSet];
GO
IF OBJECT_ID(N'[dbo].[SecondPointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SecondPointSet];
GO
IF OBJECT_ID(N'[dbo].[MiddlePointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MiddlePointSet];
GO
IF OBJECT_ID(N'[dbo].[RiblinePointsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RiblinePointsSet];
GO
IF OBJECT_ID(N'[dbo].[DetectEquipmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetectEquipmentSet];
GO
IF OBJECT_ID(N'[dbo].[AdminsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdminsSet];
GO
IF OBJECT_ID(N'[dbo].[DefectsListSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DefectsListSet];
GO
IF OBJECT_ID(N'[dbo].[ResilienceFactorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResilienceFactorSet];
GO
IF OBJECT_ID(N'[dbo].[PointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PointSet];
GO
IF OBJECT_ID(N'[dbo].[AdjustShapeFileSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdjustShapeFileSet];
GO
IF OBJECT_ID(N'[dbo].[HeightValueListSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HeightValueListSet];
GO
IF OBJECT_ID(N'[dbo].[InterpolationFileSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InterpolationFileSet];
GO
IF OBJECT_ID(N'[dbo].[BoundingBoxSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoundingBoxSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StdHullShellSet'
CREATE TABLE [dbo].[StdHullShellSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlateModel] nvarchar(max)  NOT NULL,
    [Thickness] int  NOT NULL,
    [Width1] int  NOT NULL,
    [Length1] int  NOT NULL,
    [TransverseCurvate] float  NOT NULL,
    [RiblineAmount] int  NOT NULL,
    [SideAmount] int  NOT NULL,
    [LongitudinalCurvature] float  NOT NULL,
    [CurvePlateKind] nvarchar(max)  NOT NULL,
    [Width2] float  NOT NULL,
    [Length2] float  NOT NULL,
    [ShipName] nvarchar(max)  NOT NULL,
    [Material_Id] int  NOT NULL,
    [TheoryPoints_Id] int  NOT NULL
);
GO

-- Creating table 'MaterialSet'
CREATE TABLE [dbo].[MaterialSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MaterialName] nvarchar(max)  NULL,
    [ElasticModulus] float  NULL,
    [YieldSrength] float  NULL,
    [TensileStrength] float  NULL,
    [UltimateElongation] float  NULL,
    [ReductionOfArea] float  NULL,
    [HardenablityValue] float  NULL,
    [StrainOfWidthAndThickness] float  NULL
);
GO

-- Creating table 'ModelingParameterSet'
CREATE TABLE [dbo].[ModelingParameterSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProcessNumbers] int  NULL,
    [EnvTemperation] float  NOT NULL,
    [RecordTime] datetime  NOT NULL,
    [Coefficient] float  NOT NULL,
    [ResilienceValue] float  NOT NULL,
    [ProcessingEquipment_Id] int  NOT NULL,
    [Software_Id] int  NOT NULL,
    [DetectEquipment_Id] int  NOT NULL,
    [ScanPoints_Id] int  NOT NULL,
    [Admins_Id] int  NOT NULL,
    [AdjustShapeFile_Id] int  NOT NULL,
    [StdHullShell_Id] int  NOT NULL
);
GO

-- Creating table 'ProcessingEquipmentSet'
CREATE TABLE [dbo].[ProcessingEquipmentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EquipMentName] nvarchar(max)  NULL,
    [PressureHeadLength] int  NOT NULL,
    [DriveMode] nvarchar(max)  NOT NULL,
    [HeadNumberOfDownDie] int  NOT NULL,
    [HeadNumberOfUpDie] int  NOT NULL
);
GO

-- Creating table 'SoftwareSet'
CREATE TABLE [dbo].[SoftwareSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SoftwareName] nvarchar(max)  NULL,
    [RegisterAlgorithm] nvarchar(max)  NOT NULL,
    [DiffComputer] nvarchar(max)  NOT NULL,
    [SurfaceReconstruction] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ScanPointsSet'
CREATE TABLE [dbo].[ScanPointsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TheoryPointsSet'
CREATE TABLE [dbo].[TheoryPointsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowNumber] int  NOT NULL,
    [ColumnNumber] int  NOT NULL
);
GO

-- Creating table 'ExcessPointsSet'
CREATE TABLE [dbo].[ExcessPointsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StdHullShell_Id] int  NOT NULL
);
GO

-- Creating table 'EdgeEdgePointsSet'
CREATE TABLE [dbo].[EdgeEdgePointsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StdHullShell_Id] int  NOT NULL
);
GO

-- Creating table 'FirstPointSet'
CREATE TABLE [dbo].[FirstPointSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'SecondPointSet'
CREATE TABLE [dbo].[SecondPointSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] real  NOT NULL,
    [Y] real  NOT NULL,
    [Z] real  NOT NULL
);
GO

-- Creating table 'MiddlePointSet'
CREATE TABLE [dbo].[MiddlePointSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] real  NOT NULL,
    [Y] real  NOT NULL,
    [Z] real  NOT NULL
);
GO

-- Creating table 'RiblinePointsSet'
CREATE TABLE [dbo].[RiblinePointsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StdHullShell_Id] int  NOT NULL
);
GO

-- Creating table 'DetectEquipmentSet'
CREATE TABLE [dbo].[DetectEquipmentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DetectEquipmentName] nvarchar(max)  NULL,
    [CameraResolution] nvarchar(max)  NULL,
    [PixelSize] nvarchar(max)  NULL,
    [StdPrecision] float  NOT NULL
);
GO

-- Creating table 'AdminsSet'
CREATE TABLE [dbo].[AdminsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [PassWod] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DefectsListSet'
CREATE TABLE [dbo].[DefectsListSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DefectName] nvarchar(max)  NOT NULL,
    [DefectReason] nvarchar(max)  NOT NULL,
    [Solution] nvarchar(max)  NOT NULL,
    [ModelingParameter_Id] int  NOT NULL
);
GO

-- Creating table 'ResilienceFactorSet'
CREATE TABLE [dbo].[ResilienceFactorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ResilienCoefficient] float  NOT NULL,
    [CurvatureRange] float  NOT NULL,
    [WidthRange] float  NOT NULL,
    [Curvature] float  NOT NULL,
    [stdHullShell_Id] int  NOT NULL
);
GO

-- Creating table 'PointSet'
CREATE TABLE [dbo].[PointSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] float  NOT NULL,
    [Y] float  NOT NULL,
    [Z] float  NOT NULL,
    [ScanPoints_Id] int  NULL,
    [TheoryPoints_Id] int  NULL,
    [ExcessPoints_Id] int  NULL,
    [EdgeEdgePoints_Id] int  NULL,
    [RiblinePoints_Id] int  NULL
);
GO

-- Creating table 'AdjustShapeFileSet'
CREATE TABLE [dbo].[AdjustShapeFileSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HeightValueListSet'
CREATE TABLE [dbo].[HeightValueListSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [R] int  NOT NULL,
    [C] int  NOT NULL,
    [Z] float  NOT NULL,
    [InterpolationFile_Id] int  NULL,
    [AdjustShapeFile_Id] int  NULL
);
GO

-- Creating table 'InterpolationFileSet'
CREATE TABLE [dbo].[InterpolationFileSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FileName] nvarchar(max)  NOT NULL,
    [ModelingParameter_Id] int  NOT NULL
);
GO

-- Creating table 'BoundingBoxSet'
CREATE TABLE [dbo].[BoundingBoxSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [x_Dir] float  NOT NULL,
    [y_Dir] float  NOT NULL,
    [z_Dir] float  NOT NULL,
    [x_Min] float  NOT NULL,
    [y_Min] float  NOT NULL,
    [z_Min] float  NOT NULL,
    [x_Max] float  NOT NULL,
    [y_Max] float  NOT NULL,
    [z_Max] float  NOT NULL,
    [StdHullShell_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StdHullShellSet'
ALTER TABLE [dbo].[StdHullShellSet]
ADD CONSTRAINT [PK_StdHullShellSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MaterialSet'
ALTER TABLE [dbo].[MaterialSet]
ADD CONSTRAINT [PK_MaterialSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [PK_ModelingParameterSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProcessingEquipmentSet'
ALTER TABLE [dbo].[ProcessingEquipmentSet]
ADD CONSTRAINT [PK_ProcessingEquipmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SoftwareSet'
ALTER TABLE [dbo].[SoftwareSet]
ADD CONSTRAINT [PK_SoftwareSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScanPointsSet'
ALTER TABLE [dbo].[ScanPointsSet]
ADD CONSTRAINT [PK_ScanPointsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TheoryPointsSet'
ALTER TABLE [dbo].[TheoryPointsSet]
ADD CONSTRAINT [PK_TheoryPointsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExcessPointsSet'
ALTER TABLE [dbo].[ExcessPointsSet]
ADD CONSTRAINT [PK_ExcessPointsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EdgeEdgePointsSet'
ALTER TABLE [dbo].[EdgeEdgePointsSet]
ADD CONSTRAINT [PK_EdgeEdgePointsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FirstPointSet'
ALTER TABLE [dbo].[FirstPointSet]
ADD CONSTRAINT [PK_FirstPointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SecondPointSet'
ALTER TABLE [dbo].[SecondPointSet]
ADD CONSTRAINT [PK_SecondPointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MiddlePointSet'
ALTER TABLE [dbo].[MiddlePointSet]
ADD CONSTRAINT [PK_MiddlePointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RiblinePointsSet'
ALTER TABLE [dbo].[RiblinePointsSet]
ADD CONSTRAINT [PK_RiblinePointsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetectEquipmentSet'
ALTER TABLE [dbo].[DetectEquipmentSet]
ADD CONSTRAINT [PK_DetectEquipmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdminsSet'
ALTER TABLE [dbo].[AdminsSet]
ADD CONSTRAINT [PK_AdminsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DefectsListSet'
ALTER TABLE [dbo].[DefectsListSet]
ADD CONSTRAINT [PK_DefectsListSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ResilienceFactorSet'
ALTER TABLE [dbo].[ResilienceFactorSet]
ADD CONSTRAINT [PK_ResilienceFactorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [PK_PointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdjustShapeFileSet'
ALTER TABLE [dbo].[AdjustShapeFileSet]
ADD CONSTRAINT [PK_AdjustShapeFileSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HeightValueListSet'
ALTER TABLE [dbo].[HeightValueListSet]
ADD CONSTRAINT [PK_HeightValueListSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InterpolationFileSet'
ALTER TABLE [dbo].[InterpolationFileSet]
ADD CONSTRAINT [PK_InterpolationFileSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BoundingBoxSet'
ALTER TABLE [dbo].[BoundingBoxSet]
ADD CONSTRAINT [PK_BoundingBoxSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Material_Id] in table 'StdHullShellSet'
ALTER TABLE [dbo].[StdHullShellSet]
ADD CONSTRAINT [FK_MaterialHullShell]
    FOREIGN KEY ([Material_Id])
    REFERENCES [dbo].[MaterialSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialHullShell'
CREATE INDEX [IX_FK_MaterialHullShell]
ON [dbo].[StdHullShellSet]
    ([Material_Id]);
GO

-- Creating foreign key on [TheoryPoints_Id] in table 'StdHullShellSet'
ALTER TABLE [dbo].[StdHullShellSet]
ADD CONSTRAINT [FK_stdHullShellTheoryPoints]
    FOREIGN KEY ([TheoryPoints_Id])
    REFERENCES [dbo].[TheoryPointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_stdHullShellTheoryPoints'
CREATE INDEX [IX_FK_stdHullShellTheoryPoints]
ON [dbo].[StdHullShellSet]
    ([TheoryPoints_Id]);
GO

-- Creating foreign key on [ProcessingEquipment_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_ProcessingEquipmentModelingParameter]
    FOREIGN KEY ([ProcessingEquipment_Id])
    REFERENCES [dbo].[ProcessingEquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProcessingEquipmentModelingParameter'
CREATE INDEX [IX_FK_ProcessingEquipmentModelingParameter]
ON [dbo].[ModelingParameterSet]
    ([ProcessingEquipment_Id]);
GO

-- Creating foreign key on [Software_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_SoftwareModelingParameter]
    FOREIGN KEY ([Software_Id])
    REFERENCES [dbo].[SoftwareSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareModelingParameter'
CREATE INDEX [IX_FK_SoftwareModelingParameter]
ON [dbo].[ModelingParameterSet]
    ([Software_Id]);
GO

-- Creating foreign key on [DetectEquipment_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_DetectEquipmentModelingParameter]
    FOREIGN KEY ([DetectEquipment_Id])
    REFERENCES [dbo].[DetectEquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DetectEquipmentModelingParameter'
CREATE INDEX [IX_FK_DetectEquipmentModelingParameter]
ON [dbo].[ModelingParameterSet]
    ([DetectEquipment_Id]);
GO

-- Creating foreign key on [ScanPoints_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_ModelingParameterScanPoints]
    FOREIGN KEY ([ScanPoints_Id])
    REFERENCES [dbo].[ScanPointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelingParameterScanPoints'
CREATE INDEX [IX_FK_ModelingParameterScanPoints]
ON [dbo].[ModelingParameterSet]
    ([ScanPoints_Id]);
GO

-- Creating foreign key on [ModelingParameter_Id] in table 'DefectsListSet'
ALTER TABLE [dbo].[DefectsListSet]
ADD CONSTRAINT [FK_ModelingParameterDefectsList]
    FOREIGN KEY ([ModelingParameter_Id])
    REFERENCES [dbo].[ModelingParameterSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelingParameterDefectsList'
CREATE INDEX [IX_FK_ModelingParameterDefectsList]
ON [dbo].[DefectsListSet]
    ([ModelingParameter_Id]);
GO

-- Creating foreign key on [Admins_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_AdminsModelingParameter]
    FOREIGN KEY ([Admins_Id])
    REFERENCES [dbo].[AdminsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AdminsModelingParameter'
CREATE INDEX [IX_FK_AdminsModelingParameter]
ON [dbo].[ModelingParameterSet]
    ([Admins_Id]);
GO

-- Creating foreign key on [stdHullShell_Id] in table 'ResilienceFactorSet'
ALTER TABLE [dbo].[ResilienceFactorSet]
ADD CONSTRAINT [FK_stdHullShellResilienceFactor]
    FOREIGN KEY ([stdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_stdHullShellResilienceFactor'
CREATE INDEX [IX_FK_stdHullShellResilienceFactor]
ON [dbo].[ResilienceFactorSet]
    ([stdHullShell_Id]);
GO

-- Creating foreign key on [ScanPoints_Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [FK_ScanPointsPoint]
    FOREIGN KEY ([ScanPoints_Id])
    REFERENCES [dbo].[ScanPointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScanPointsPoint'
CREATE INDEX [IX_FK_ScanPointsPoint]
ON [dbo].[PointSet]
    ([ScanPoints_Id]);
GO

-- Creating foreign key on [TheoryPoints_Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [FK_TheoryPointsPoint]
    FOREIGN KEY ([TheoryPoints_Id])
    REFERENCES [dbo].[TheoryPointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TheoryPointsPoint'
CREATE INDEX [IX_FK_TheoryPointsPoint]
ON [dbo].[PointSet]
    ([TheoryPoints_Id]);
GO

-- Creating foreign key on [ExcessPoints_Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [FK_ExcessPointsPoint]
    FOREIGN KEY ([ExcessPoints_Id])
    REFERENCES [dbo].[ExcessPointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExcessPointsPoint'
CREATE INDEX [IX_FK_ExcessPointsPoint]
ON [dbo].[PointSet]
    ([ExcessPoints_Id]);
GO

-- Creating foreign key on [EdgeEdgePoints_Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [FK_EdgeEdgePointsPoint]
    FOREIGN KEY ([EdgeEdgePoints_Id])
    REFERENCES [dbo].[EdgeEdgePointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EdgeEdgePointsPoint'
CREATE INDEX [IX_FK_EdgeEdgePointsPoint]
ON [dbo].[PointSet]
    ([EdgeEdgePoints_Id]);
GO

-- Creating foreign key on [RiblinePoints_Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [FK_RiblinePointsPoint]
    FOREIGN KEY ([RiblinePoints_Id])
    REFERENCES [dbo].[RiblinePointsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RiblinePointsPoint'
CREATE INDEX [IX_FK_RiblinePointsPoint]
ON [dbo].[PointSet]
    ([RiblinePoints_Id]);
GO

-- Creating foreign key on [ModelingParameter_Id] in table 'InterpolationFileSet'
ALTER TABLE [dbo].[InterpolationFileSet]
ADD CONSTRAINT [FK_ModelingParameterInterpolationFile]
    FOREIGN KEY ([ModelingParameter_Id])
    REFERENCES [dbo].[ModelingParameterSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelingParameterInterpolationFile'
CREATE INDEX [IX_FK_ModelingParameterInterpolationFile]
ON [dbo].[InterpolationFileSet]
    ([ModelingParameter_Id]);
GO

-- Creating foreign key on [InterpolationFile_Id] in table 'HeightValueListSet'
ALTER TABLE [dbo].[HeightValueListSet]
ADD CONSTRAINT [FK_InterpolationFileHeightValueList]
    FOREIGN KEY ([InterpolationFile_Id])
    REFERENCES [dbo].[InterpolationFileSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InterpolationFileHeightValueList'
CREATE INDEX [IX_FK_InterpolationFileHeightValueList]
ON [dbo].[HeightValueListSet]
    ([InterpolationFile_Id]);
GO

-- Creating foreign key on [AdjustShapeFile_Id] in table 'HeightValueListSet'
ALTER TABLE [dbo].[HeightValueListSet]
ADD CONSTRAINT [FK_AdjustShapeFileHeightValueList]
    FOREIGN KEY ([AdjustShapeFile_Id])
    REFERENCES [dbo].[AdjustShapeFileSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AdjustShapeFileHeightValueList'
CREATE INDEX [IX_FK_AdjustShapeFileHeightValueList]
ON [dbo].[HeightValueListSet]
    ([AdjustShapeFile_Id]);
GO

-- Creating foreign key on [StdHullShell_Id] in table 'RiblinePointsSet'
ALTER TABLE [dbo].[RiblinePointsSet]
ADD CONSTRAINT [FK_StdHullShellRiblinePoints]
    FOREIGN KEY ([StdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StdHullShellRiblinePoints'
CREATE INDEX [IX_FK_StdHullShellRiblinePoints]
ON [dbo].[RiblinePointsSet]
    ([StdHullShell_Id]);
GO

-- Creating foreign key on [StdHullShell_Id] in table 'ExcessPointsSet'
ALTER TABLE [dbo].[ExcessPointsSet]
ADD CONSTRAINT [FK_StdHullShellExcessPoints]
    FOREIGN KEY ([StdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StdHullShellExcessPoints'
CREATE INDEX [IX_FK_StdHullShellExcessPoints]
ON [dbo].[ExcessPointsSet]
    ([StdHullShell_Id]);
GO

-- Creating foreign key on [StdHullShell_Id] in table 'EdgeEdgePointsSet'
ALTER TABLE [dbo].[EdgeEdgePointsSet]
ADD CONSTRAINT [FK_StdHullShellEdgeEdgePoints]
    FOREIGN KEY ([StdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StdHullShellEdgeEdgePoints'
CREATE INDEX [IX_FK_StdHullShellEdgeEdgePoints]
ON [dbo].[EdgeEdgePointsSet]
    ([StdHullShell_Id]);
GO

-- Creating foreign key on [StdHullShell_Id] in table 'BoundingBoxSet'
ALTER TABLE [dbo].[BoundingBoxSet]
ADD CONSTRAINT [FK_StdHullShellBoundingBox]
    FOREIGN KEY ([StdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StdHullShellBoundingBox'
CREATE INDEX [IX_FK_StdHullShellBoundingBox]
ON [dbo].[BoundingBoxSet]
    ([StdHullShell_Id]);
GO

-- Creating foreign key on [AdjustShapeFile_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_ModelingParameterAdjustShapeFile]
    FOREIGN KEY ([AdjustShapeFile_Id])
    REFERENCES [dbo].[AdjustShapeFileSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelingParameterAdjustShapeFile'
CREATE INDEX [IX_FK_ModelingParameterAdjustShapeFile]
ON [dbo].[ModelingParameterSet]
    ([AdjustShapeFile_Id]);
GO

-- Creating foreign key on [StdHullShell_Id] in table 'ModelingParameterSet'
ALTER TABLE [dbo].[ModelingParameterSet]
ADD CONSTRAINT [FK_StdHullShellModelingParameter]
    FOREIGN KEY ([StdHullShell_Id])
    REFERENCES [dbo].[StdHullShellSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StdHullShellModelingParameter'
CREATE INDEX [IX_FK_StdHullShellModelingParameter]
ON [dbo].[ModelingParameterSet]
    ([StdHullShell_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------