USE [DiscountPricing]
GO

/****** Object:  Table [dbo].[tblBatchProcess]    Script Date: 9/12/2020 9:27:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBatchProcess](
	[intBatchProcessID] [int] IDENTITY(1,1) NOT NULL,
	[intBatchProcessTypeID] [int] NULL,
	[dtmProcessDate] [datetime] NULL,
	[strDescription] [varchar](1000) NULL,
	[strPeriod] [varchar](100) NULL,
	[strNABP] [varchar](50) NULL,
	[strContractCode] [varchar](50) NULL,
	[ynStatus] [bit] NULL,
	[ynOrderPlaced] [bit] NULL,
	[ynOutsourceOrderEmailSent] [bit] NOT NULL,
	[strCreatedBy] [varchar](50) NULL,
	[dtmCreatedDateTime] [datetime] NULL,
	[strUpdatedBy] [varchar](50) NULL,
	[dtmUpdatedDateTime] [datetime] NULL,
	[dtmPeriodEnd] [date] NULL,
	[dtmPeriodStart] [date] NULL,
	[strPeriodEnd] [varchar](100) NULL,
	[strPeriodStart] [varchar](100) NULL,
	[ynIncludedInBillingCycle] [bit] NOT NULL,
 CONSTRAINT [PK_tblWholesaleOrderBatch] PRIMARY KEY CLUSTERED 
(
	[intBatchProcessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblBatchProcess_ynStatus]  DEFAULT ((1)) FOR [ynStatus]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblBatchProcess_ynOrderPlaced]  DEFAULT ((0)) FOR [ynOrderPlaced]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblBatchProcess_ynOutsourceEmailSent]  DEFAULT ((0)) FOR [ynOutsourceOrderEmailSent]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblWholesaleOrderBatch_strCreatedBy]  DEFAULT (user_name()) FOR [strCreatedBy]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblWholesaleOrderBatch_dtmCreatedDateTime]  DEFAULT (getdate()) FOR [dtmCreatedDateTime]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblWholesaleOrderBatch_strUpdatedBy]  DEFAULT (user_name()) FOR [strUpdatedBy]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF_tblWholesaleOrderBatch_dtmUpdatedDateTime]  DEFAULT (getdate()) FOR [dtmUpdatedDateTime]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF__tblBatchP__dtmPe__2484897E]  DEFAULT ('01/01/1900') FOR [dtmPeriodEnd]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF__tblBatchP__dtmPe__2578ADB7]  DEFAULT ('01/01/1900') FOR [dtmPeriodStart]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF__tblBatchP__strPe__266CD1F0]  DEFAULT ('01/01/1900') FOR [strPeriodEnd]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  CONSTRAINT [DF__tblBatchP__strPe__2760F629]  DEFAULT ('01/01/1900') FOR [strPeriodStart]
GO

ALTER TABLE [dbo].[tblBatchProcess] ADD  DEFAULT ((0)) FOR [ynIncludedInBillingCycle]
GO

ALTER TABLE [dbo].[tblBatchProcess]  WITH CHECK ADD  CONSTRAINT [FK_tblBatchProcess_tblBatchProcessType] FOREIGN KEY([intBatchProcessTypeID])
REFERENCES [dbo].[lkuBatchProcessType] ([intBatchProcessTypeID])
GO

ALTER TABLE [dbo].[tblBatchProcess] CHECK CONSTRAINT [FK_tblBatchProcess_tblBatchProcessType]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Batch Process Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'intBatchProcessID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Batch Process Type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'intBatchProcessTypeID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Process Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'dtmProcessDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strDescription'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Period' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strPeriod'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nabp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strNABP'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contract Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strContractCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'ynStatus'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Created By' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strCreatedBy'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Created Date Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'dtmCreatedDateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Updated By' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'strUpdatedBy'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Updated Date Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblBatchProcess', @level2type=N'COLUMN',@level2name=N'dtmUpdatedDateTime'
GO


