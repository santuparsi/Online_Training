USE [DiscountPricing]
GO


CREATE TABLE [dbo].[lnkBatchProcessOrder](
	[intBatchProcessOrderID] [int] IDENTITY(1,1) NOT NULL,
	[intBillingBatchProcessID] [int] NOT NULL,
	[intBatchProcessID] [int] NOT NULL,
	[intBatchProcessIDOrder] [int] NOT NULL,
	[strNABP] [varchar](15) NOT NULL,
	[dtmCreated] [datetime] NOT NULL,
	[strUserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_lnkBatchProcessOrder] PRIMARY KEY CLUSTERED 
(
	[intBatchProcessOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_intBillingBatchProcessID]  DEFAULT ((0)) FOR [intBillingBatchProcessID]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_intBatchProcessID]  DEFAULT ((0)) FOR [intBatchProcessID]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_intBatchProcessIDOrder]  DEFAULT ((0)) FOR [intBatchProcessIDOrder]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_strNABP]  DEFAULT ('') FOR [strNABP]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_dtmCreated]  DEFAULT (getdate()) FOR [dtmCreated]
GO

ALTER TABLE [dbo].[lnkBatchProcessOrder] ADD  CONSTRAINT [DF_lnkBatchProcessOrder_strUserName]  DEFAULT (suser_sname()) FOR [strUserName]
GO



------------------------------------------------------------------------------

