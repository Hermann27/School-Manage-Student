delimiter |
create procedure SP_DOMAINE_INSERT
(
	IN NumD INT,
	IN NOM VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	INSERT INTO Domaines(NumDom,NomDom,DateCreation,DateModification,IdCreateur,IdModificateur) VALUES(NumD,NOM,now(),now(),idcre,idup);
END |

create procedure SP_DOMAINE_UPDATE
(
	IN NumD INT,
	IN OLDNumD CHAR(5),
	IN NOM VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	UPDATE Domaines SET 

		NumDom=NumD,
		NomDom=NoM,
		DateModification=now(),
		IdCreateur=idcre,
		IdModificateur=idup 
	WHERE NumDom=OLDNumD;
END|

create procedure SP_DOMAINE_DELETE
(
	IN NumD INT

)
BEGIN
	DELETE FROM Domaines  WHERE NumDom=NumD;
END|

create procedure SP_DOMAINE_SELECT
(
	IN NumD INT,
	IN NOM VARCHAR(50),
	IN idcre INT,
	IN idup INT,
	IN dtcre DATETIME,
	IN dtup DATETIME

)
BEGIN
	SELECT * FROM Domaines

	WHERE NumDom LIKE CASE WHEN NumD IS NULL THEN '%' ELSE CAST(NumD AS CHAR) END AND 
	NomDom LIKE CASE WHEN NOM IS NULL THEN '%' ELSE CONCAT('%',CONCAT(NoM,'%')) END
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	DateCreation LIKE CASE WHEN dtcre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtcre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dtup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtup AS CHAR),'%')) END;
END