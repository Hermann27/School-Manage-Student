delimiter |
create procedure SP_CLASSE_INSERT
(
	IN CODECL CHAR(5),
	IN LIBCL VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	INSERT INTO Classes(codeClasse,libClasse,DateCreation,DateModification,IdCreateur,IdModificateur) VALUES(CODECL,LIBCL,now(),now(),idcre,idup);
END |

create procedure SP_CLASSE_UPDATE
(
	IN CODECL CHAR(5),
	IN OLDCODECL CHAR(5),
	IN LIBCL VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	UPDATE Classes SET 
		codeClasse=CODECL,
		libClasse=LIBCL,
                DateModification=now(),
		IdCreateur=idcre,
		IdModificateur=idup
	WHERE codeClasse=OLDCODECL;
END|

create procedure SP_CLASSE_DELETE
(
	IN CODECL CHAR(5)
	

)
BEGIN
	DELETE FROM Classes  WHERE codeClasse=CODECL;
END|

create procedure SP_CLASSE_SELECT
(
	IN CODECL CHAR(5),
	IN LIBCL VARCHAR(50),
	IN idcre INT,
	IN idup INT,
	IN dtcre DATETIME,
	IN dtup DATETIME

)
BEGIN
	SELECT * FROM Classes

	WHERE codeClasse LIKE CASE WHEN CODECL IS NULL THEN '%' ELSE  CONCAT('%',CONCAT(CODECL,'%')) END AND
	libClasse LIKE CASE WHEN LIBCL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(LIBCL,'%')) END AND
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	DateCreation LIKE CASE WHEN dtcre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtcre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dtup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtup AS CHAR),'%')) END;
END|

	
