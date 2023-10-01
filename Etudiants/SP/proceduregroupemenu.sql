delimiter |
create procedure SP_GROUPE_PRIVILEGE_INSERT
(
	IN idg int,
	IN idm int,
	IN statu int,
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int
	

)
BEGIN
	INSERT INTO Groupe_Privilege(
			    				
			    IdGroupe,
			    IdMenu,
			    Statut,
			    DateCreation,
			    DateModification,
			    IdCreateur,
			    IdModificateur) VALUES(idg ,idm,statu,datecre,dateup,idcre,idup);
END |

create procedure SP_GROUPE_PRIVILEGE_UPDATE
(
	IN oldidg int,
	IN oldidm int,
	IN idg int,
	IN idm int,
	IN statu int,
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int
)
BEGIN
	UPDATE Groupe_Privilege SET IdGroupe=idg,
			    	IdMenu=idm,
			    	Statut=statu,
			    	DateCreation=datecre,
			    	DateModification=dateup,
			    	IdCreateur=idcre,
			    	IdModificateur=idup

        WHERE IdGroupe=oldidg AND IdMenu=oldidm ;
END|

create procedure SP_GROUPE_PRIVILEGE_DELETE
(
	IN idg int,
	IN idm int
	

)
BEGIN
	DELETE FROM Groupe_Privilege WHERE IdGroupe=idg AND IdMenu=idm ;
END|

create procedure SP_GROUPE_PRIVILEGE_SELECT
(
	
	IN idg int,
	IN idm int,
	IN statu int,
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int

)
BEGIN

	SELECT * FROM Groupe_Privilege

	WHERE IdMenu LIKE CASE WHEN idm IS NULL THEN '%' ELSE CAST(idm AS CHAR) END AND
	IdGroupe LIKE CASE WHEN idg IS NULL THEN '%' ELSE CAST(idg AS CHAR) END AND
	Statut LIKE CASE WHEN statu IS NULL THEN '%' ELSE CAST(statu AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	DateCreation LIKE CASE WHEN datecre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(datecre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dateup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dateup AS CHAR),'%')) END;
END|
