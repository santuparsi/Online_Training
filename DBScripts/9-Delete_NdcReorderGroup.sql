USE [DiscountPricing]
GO

/****** Object:  StoredProcedure [dbo].[prcInsPriceGroup]    Script Date: 9/6/2020 1:03:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prcDelPriceGroup]
@intNdcReorderGroupID	AS INT,
@intDrugPriceTypeID		AS INT
AS

BEGIN
	DELETE FROM [dbo].[tblNdcReorderGroup]  WHERE intNdcReorderGroupID = @intNdcReorderGroupID AND intDrugPriceTypeID	=@intDrugPriceTypeID
END




GO


