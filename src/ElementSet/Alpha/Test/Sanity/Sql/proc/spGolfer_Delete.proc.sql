if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spGolfer_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[spGolfer_Delete]
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spGolfer_Delete

@GolferId	int

AS

if not exists(SELECT * FROM Golfer WHERE (	GolferId = @GolferId
))
    BEGIN
        RAISERROR  ('spGolfer_Delete: record not found to delete', 16,1)
        RETURN(-1)
    END

DELETE
FROM
	Golfer
WHERE 
	GolferId = @GolferId
GO

