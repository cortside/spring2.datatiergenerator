if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spTournamentFee_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[spTournamentFee_Update]
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spTournamentFee_Update

	@TournamentFeeId	int,
	@TournamentId	int,
	@Key	varchar(50),
	@Fee	money

AS


UPDATE
	TournamentFee
SET
	TournamentId = @TournamentId,
	[Key] = @Key,
	Fee = @Fee
WHERE
TournamentFeeId = @TournamentFeeId


if @@ROWCOUNT <> 1
    BEGIN
        RAISERROR  ('spTournamentFee_Update:  update was expected to update a single row and updated %d rows', 16,1, @@ROWCOUNT)
        RETURN(-1)
    END
GO

