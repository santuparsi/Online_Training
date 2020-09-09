

CREATE PROCEDURE [dbo].[prcUpdExclusions] 
@strDrugNDC	VARCHAR(15),
@strContractCode VARCHAR(50)
AS
BEGIN
	UPDATE [dbo].[tblExclusions]
   SET [strDrugNDC] = @strDrugNDC
      ,[UpdatedBy] = suser_sname()
      ,[dtmCreated] = getdate()
      ,[dtmUpdated] = getdate()
	  WHERE  [strContractCode] = @strContractCode
END
GO


