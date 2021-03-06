if exists (select * from sysobjects where id = object_id(N'[vwOrganizer]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [vwOrganizer]
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW vwOrganizer

AS

SELECT
	Organizer.OrganizerId,
	Organizer.Name,
	Organizer.Address1,
	Organizer.Address2,
	Organizer.City,
	Organizer.State,
	Organizer.Country,
	Organizer.PostalCode,
	Organizer.OrganizerContactName,
	Organizer.OrganizerContactPhone,
	Organizer.OrganizerContactEmail,
	Organizer.TechnicalContactName,
	Organizer.TechnicalContactPhone,
	Organizer.TechnicalContactEmail,
	(select count(*) from OrganizationDetail where OrganizationDetail.OrganizationId=Organization.OrganizationId) ComputedColumn
FROM
	Organizer
GO
