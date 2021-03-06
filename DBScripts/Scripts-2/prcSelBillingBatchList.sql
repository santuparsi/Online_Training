USE [DiscountPricing]
GO
/****** Object:  StoredProcedure [dbo].[prcSelBillingBatchList]    Script Date: 9/12/2020 9:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[prcSelBillingBatchList]

AS
BEGIN

	SET NOCOUNT ON;

	--SELECT DISTINCT * , (strPeriod + ' - ' + strDescription ) AS strBatchDescription
	--FROM 
	--	dbo.tblBatchProcess
	--WHERE intBatchProcessTypeID = 11
	--ORDER BY 
	--	intBatchProcessID DESC
			


SELECT  DISTINCT tblBatchProcess.intBatchProcessID, tblBatchProcess.strPeriod, tblBatchProcess.strDescription + ' - ' + tblBatchProcess.strPeriod AS strBatchDescription, 
 tblBatchProcess.strContractCode
FROM         tblBatchProcess INNER JOIN
                   (SELECT DISTINCT TOP (100) PERCENT intBillingBatchProcessID,intBatchProcessIDOrder
                            FROM lnkBatchProcessOrder) AS SW ON 
                            tblBatchProcess.intBatchProcessID = SW.intBillingBatchProcessID
WHERE tblBatchProcess.intBatchProcessTypeID = 11 
ORDER BY intBatchProcessID

END
