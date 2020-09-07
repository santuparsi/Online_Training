USE [DiscountPricing]
GO

/****** Object:  Table [dbo].[tblNdcReorderGroup]    Script Date: 9/6/2020 1:04:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNdcReorderGroup](
	[intNdcReorderGroupID] [int] IDENTITY(1,1) NOT NULL,
	[strDescription] [varchar](50) NULL,
	[strNote] [varchar](50) NULL,
	[strCreatedBy] [varchar](50) NULL,
	[intDrugPriceTypeID] [int] NULL,
	[ynActive] [bit] NULL,
	[dtmCreatedDateTime] [datetime] NULL,
	[strUpdatedBy] [varchar](50) NULL,
	[dtmUpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblNdcReorderGroup] PRIMARY KEY CLUSTERED 
(
	[intNdcReorderGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblNdcReorderGroup] ADD  CONSTRAINT [DF_tblNdcReorderGroup_strCreatedBy]  DEFAULT (user_name()) FOR [strCreatedBy]
GO

ALTER TABLE [dbo].[tblNdcReorderGroup] ADD  CONSTRAINT [DF_tblNdcReorderGroup_dtmCreatedDateTime]  DEFAULT (getdate()) FOR [dtmCreatedDateTime]
GO

ALTER TABLE [dbo].[tblNdcReorderGroup] ADD  CONSTRAINT [DF_tblNdcReorderGroup_strUpdatedBy]  DEFAULT (user_name()) FOR [strUpdatedBy]
GO

ALTER TABLE [dbo].[tblNdcReorderGroup] ADD  CONSTRAINT [DF_tblNdcReorderGroup_dtmUpdatedDateTime]  DEFAULT (getdate()) FOR [dtmUpdatedDateTime]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ndc Reorder Group Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'intNdcReorderGroupID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'strDescription'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Note' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'strNote'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Created By' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'strCreatedBy'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Drug Price Type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'intDrugPriceTypeID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Active' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'ynActive'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Created Date Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'dtmCreatedDateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Updated By' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'strUpdatedBy'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Updated Date Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblNdcReorderGroup', @level2type=N'COLUMN',@level2name=N'dtmUpdatedDateTime'
GO


