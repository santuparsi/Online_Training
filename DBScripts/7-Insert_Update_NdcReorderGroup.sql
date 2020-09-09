USE [DiscountPricing]
GO

/****** Object:  StoredProcedure [dbo].[prcInsPriceGroup]    Script Date: 9/6/2020 1:03:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prcInsPriceGroup]
@intNdcReorderGroupID	AS INT,
@strDescription			AS VARCHAR(50),
@strNote				AS VARCHAR(50),
@intDrugPriceTypeID		AS INT,
@ynActive				AS BIT,
@strAction				AS CHAR(1)
AS


IF LTRIM(RTRIM(@strAction)) = 'A'
BEGIN
	IF NOT EXISTS (SELECT 1 FROM [dbo].[tblNdcReorderGroup] WHERE LTRIM(RTRIM(strDescription)) = LTRIM(RTRIM(@strDescription)))
	BEGIN
		INSERT INTO [dbo].[tblNdcReorderGroup]
				   ([strDescription]
				   ,[strNote]
				   ,[strCreatedBy]
				   ,[intDrugPriceTypeID]
				   ,[ynActive]
				   ,[dtmCreatedDateTime]
				   ,[strUpdatedBy]
				   ,[dtmUpdatedDateTime])
			 VALUES
				   (@strDescription
				   ,@strNote
				   ,suser_sname()
				   ,@intDrugPriceTypeID
				   ,@ynActive
				   ,Getdate()
				   ,suser_sname()
				   ,Getdate())
	END
END


IF LTRIM(RTRIM(@strAction)) = 'U'
BEGIN
	UPDATE [dbo].[tblNdcReorderGroup]
	   SET [strDescription]			=@strDescription
		  ,[strNote]				=@strNote
		  ,[intDrugPriceTypeID]		=@intDrugPriceTypeID
		  ,[ynActive]				=@ynActive
		  ,[strUpdatedBy]			=suser_sname()
		  ,[dtmUpdatedDateTime]		=Getdate()
	 WHERE intNdcReorderGroupID = @intNdcReorderGroupID
END




GO


