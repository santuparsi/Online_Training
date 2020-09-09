USE [DiscountPricing]
GO

/****** Object:  Table [dbo].[tblExclusions]    Script Date: 9/6/2020 1:04:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblExclusions](
	[intExclusionsID] [int] IDENTITY(1,1) NOT NULL,
	[strDrugNDC] [varchar](15) NOT NULL,
	[strContractCode] [varchar](50) NOT NULL,
	[UpdatedBy] [varchar](50) NOT NULL,
	[dtmCreated] [datetime] NOT NULL,
	[dtmUpdated] [datetime] NOT NULL,
 CONSTRAINT [PK_tblExclusions] PRIMARY KEY CLUSTERED 
(
	[intExclusionsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblExclusions] ADD  CONSTRAINT [DF_tblExclusions_strContractCode]  DEFAULT ('') FOR [strContractCode]
GO

ALTER TABLE [dbo].[tblExclusions] ADD  CONSTRAINT [DF_tblExclusion_UpdatedBy]  DEFAULT (suser_sname()) FOR [UpdatedBy]
GO

ALTER TABLE [dbo].[tblExclusions] ADD  CONSTRAINT [DF_tblExclusion_dtmCreated]  DEFAULT (getdate()) FOR [dtmCreated]
GO

ALTER TABLE [dbo].[tblExclusions] ADD  CONSTRAINT [DF_tblExclusion_dtmUpdated]  DEFAULT (getdate()) FOR [dtmUpdated]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Exclusion Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'intExclusionsID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NDC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'strDrugNDC'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contract Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'strContractCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Author' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'UpdatedBy'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Created Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'dtmCreated'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Updated Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblExclusions', @level2type=N'COLUMN',@level2name=N'dtmUpdated'
GO


