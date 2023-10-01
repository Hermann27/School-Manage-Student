delimiter |
create procedure SP_GROUPE_INSERT
(
	IN intig VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN statu bit
	

)
BEGIN
	INSERT INTO Groupe(
			    				
			    Intitule,
			    DateCreation,
			    DateModification,
			    IdCreateur,
			    IdModificateur,Statut) VALUES(intig ,now(),now(),idcre,idup,statu);
END |

create procedure SP_GROUPE_UPDATE
(
	IN idg int,
	IN intig VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN statu bit
)
BEGIN
	UPDATE Groupe SET Intitule=intig ,
			    DateCreation=now() ,
			    DateModification=now() ,
			    IdCreateur=idcre ,
			    IdModificateur=idup,
			    Statut=statu 

        WHERE Id=idg ;
END|

create procedure SP_GROUPE_DELETE
(
	IN idg int
	

)
BEGIN
	DELETE FROM Groupe  WHERE Id=idg;
END|

create procedure SP_Groupe_SELECT
(
	
	IN idg int,
	IN intig VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN statu bit

)
BEGIN

	SELECT * FROM Groupe

	WHERE Id LIKE CASE WHEN idg IS NULL THEN '%' ELSE CAST(idg AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	DateCreation LIKE CASE WHEN datecre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(datecre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dateup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dateup AS CHAR),'%')) END AND
	Intitule LIKE CASE WHEN intig IS NULL THEN '%' ELSE CONCAT('%',CONCAT(intig,'%')) END AND
	Statut LIKE CASE WHEN statu IS NULL THEN '%' ELSE CAST(statu AS CHAR) END;
END|
