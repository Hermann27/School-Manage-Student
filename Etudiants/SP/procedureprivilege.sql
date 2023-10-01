delimiter |
create procedure SP_PRIVILEGE_INSERT
(
	IN intipriv VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int
	

)
BEGIN
	INSERT INTO Privilege(
			    				
			    Intitule,
			    DateCreation,
			    DateModification,
			    IdCreateur,
			    IdModificateur) VALUES(intipriv ,now(),now(),idcre,idup);
END |

create procedure SP_PRIVILEGE_UPDATE
(
	IN idp int,
	IN intipriv VARCHAR(50),
	IN datecre DATETIME,
	IN dateup DATETIME,
	IN idcre int,
	IN idup int
)
BEGIN
	UPDATE Privilege SET Intitule=intipriv,
			    DateCreation=now(),
			    DateModification=now(),
			    IdCreateur=idcre,
			    IdModificateur=idup 

        WHERE Id=idp ;
END|

create procedure SP_PRIVILEGE_DELETE
(
	IN idp int
	

)
BEGIN
	DELETE FROM Privilege  WHERE Id=idp;
END|

create procedure SP_PRIVILEGE_SELECT
(
	
	IN idp int,
	IN intipriv VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int

)
BEGIN

	SELECT * FROM Privilege

	WHERE Id LIKE CASE WHEN idp IS NULL THEN '%' ELSE CAST(idp AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	DateCreation LIKE CASE WHEN datecre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(datecre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dateup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dateup AS CHAR),'%')) END AND
	Intitule LIKE CASE WHEN intipriv IS NULL THEN '%' ELSE CONCAT('%',CONCAT(intipriv,'%')) END ;
END|
