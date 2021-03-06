-- districts

SELECT        TOP (1000000) o.OrgID, o.Created, o.Modified, o.Deleted, o.AddressTypeID, o.ParentID, o.AuthorityID, o.TradingStatus, o.HauntedStatus, o.TradingName, o.AlternateName, o.SimpleName, o.Address, o.Postcode, 
                         o.Locality, o.Town, o.Administrative_area_level_2, o.Phone, o.Twitter, o.Email, o.Facebook, o.Website, o.Lat, o.Lon, o.Tried, o.GoogleMapData, o.OSX, o.OSY, o.LaTried, o.LaCode, o.LaData, district.Name, 
                         district.Type, county.Name AS countyName, county.Type AS countyType, region.Name AS regionName, region.Type AS regionType
FROM            Organisation.Org AS o INNER JOIN
                         dbo.Authority AS district ON district.AuthorityID = o.AuthorityID INNER JOIN
                         dbo.Authority AS county ON district.ParentID = county.AuthorityID INNER JOIN
                         dbo.Authority AS region ON county.ParentID = region.AuthorityID
WHERE        (district.Type = 'district') AND (county.Type = 'county')

SELECT        TOP (1000000) o.OrgID, o.Created, o.Modified, o.Deleted, o.AddressTypeID, o.ParentID, o.AuthorityID, o.TradingStatus, o.HauntedStatus, o.TradingName, o.AlternateName, o.SimpleName, o.Address, o.Postcode, 
                         o.Locality, o.Town, o.Administrative_area_level_2, o.Phone, o.Twitter, o.Email, o.Facebook, o.Website, o.Lat, o.Lon, o.Tried, o.GoogleMapData, o.OSX, o.OSY, o.LaTried, o.LaCode, o.LaData, district.Name, 
                         district.Type, county.Name AS countyName, county.Type AS countyType, region.Name AS regionName, region.Type AS regionType
FROM            Organisation.Org AS o INNER JOIN
                         dbo.Authority AS district ON district.AuthorityID = o.AuthorityID INNER JOIN
                         dbo.Authority AS county ON district.ParentID = county.AuthorityID INNER JOIN
                         dbo.Authority AS region ON county.ParentID = region.AuthorityID
WHERE        (district.Type = 'met district') AND (county.Type = 'met county')
