
CREATE PROCEDURE [dbo].[prcSelNDCReorderGroup]
@intDrugPriceTypeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblNdcReorderGroup where intDrugPriceTypeID = @intDrugPriceTypeID and ynActive=1 ORDER BY strDescription 


END

