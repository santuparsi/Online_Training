USE [DiscountPricing]
GO

/****** Object:  StoredProcedure [dbo].[prcSelExclusions]    Script Date: 9/8/2020 12:21:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prcSelExclusions] 
@strContractCode	VARCHAR(50)
AS
BEGIN
	--SELECT * FROM tblExclusions WHERE strContractCode = @strContractCode ORDER BY dtmUpdated DESC
	SELECT * FROM tblExclusions
END
GO


