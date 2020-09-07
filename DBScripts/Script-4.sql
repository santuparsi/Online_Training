USE [DiscountPricing]
GO

/****** Object:  StoredProcedure [dbo].[prcInsExclusions]    Script Date: 9/6/2020 1:02:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prcInsExclusions] 
@strDrugNDC	VARCHAR(15),
@strContractCode VARCHAR(50)
AS
BEGIN
	SET @strDrugNDC = RIGHT('00000000000' + RTRIM(LTRIM(CONVERT(varchar(11), CONVERT(varchar(11), @strDrugNDC)))), 11)

	IF NOT EXISTS(SELECT 1 FROM [dbo].[tblExclusions] WHERE strDrugNDC = @strDrugNDC AND strContractCode=@strContractCode)
	BEGIN
		INSERT INTO [dbo].[tblExclusions] ([strDrugNDC],[strContractCode]) VALUES (@strDrugNDC,@strContractCode)
	END
END
GO


