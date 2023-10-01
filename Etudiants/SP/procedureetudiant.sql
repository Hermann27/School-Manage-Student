delimiter |
create procedure SP_ETUDIANT_INSERT
(
	IN MAT CHAR(8),
	IN NOM VARCHAR(50),
	IN SEXE ENUM('F','M'),
	IN TEL CHAR(7),
	IN CIT ENUM('O','N'),
	IN CODECL CHAR(5),
	IN DATEN DATE,
	IN LIEUN VARCHAR(50),
	IN EXTN CHAR(5),
	IN CHEN VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	INSERT INTO Etudiants(matricule,
			    nomEtud,
			    sexeEtud,				
			    telEtud,
			    cite,
			    codeClasse,
			    DateNaiss,
			    Lieu,ExtPhoto,CheminPhoto,DateCreation,DateModification,IdCreateur,IdModificateur) VALUES(MAT,NOM,SEXE,TEL,CIT,CODECL,DATEN,LIEUN,EXTN,CHEN,now(),now(),idcre,idup);
END |

create procedure SP_ETUDIANT_UPDATE
(
	IN MAT CHAR(8),
	IN OLDMAT CHAR(8),
	IN NOM VARCHAR(50),
	IN SEXE ENUM('F','M'),
	IN TEL CHAR(7),
	IN CIT ENUM('O','N'),
	IN CODECL CHAR(5),
	IN DATEN DATE,
	IN LIEUN VARCHAR(50),
	IN EXTN CHAR(5),
	IN CHEN VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	UPDATE Etudiants SET matricule=MAT ,
			    nomEtud=NOM ,
			    sexeEtud=SEXE ,				
			    telEtud=TEL ,
			    cite=CIT ,
			    codeClasse=CODECL ,
			    DateNaiss=DATEN ,
			    Lieu=LIEUN,
			    ExtPhoto=EXTN,
		            CheminPhoto=CHEN,
			    DateModification=now(),
			    IdCreateur=idcre,
		            IdModificateur=idup

        WHERE matricule=OLDMAT ;
END|

create procedure SP_ETUDIANT_DELETE
(
	IN MAT CHAR(8)
	

)
BEGIN
	DELETE FROM Etudiants  WHERE matricule=MAT;
END|

create procedure SP_ETUDIANT_SELECT
(
	
	IN MAT CHAR(8),
	IN NOM VARCHAR(50),
	IN SEXE ENUM('F','M'),
	IN TEL CHAR(7),
	IN CIT ENUM('O','N'),
	IN CODECL CHAR(5),
	IN LIEUN VARCHAR(50),
	IN DATEN DATE,
	IN idcre INT,
	IN idup INT,
	IN dtcre DATETIME,
	IN dtup DATETIME

)
BEGIN
	SELECT * FROM Etudiants

	WHERE matricule LIKE CASE WHEN MAT IS NULL THEN '%' ELSE CONCAT('%',CONCAT(MAT,'%')) END AND
	nomEtud LIKE CASE WHEN NOM IS NULL THEN '%' ELSE CONCAT('%',CONCAT(NOM,'%')) END AND
	sexeEtud LIKE CASE WHEN SEXE IS NULL THEN '%' ELSE CONCAT('%',CONCAT(SEXE,'%')) END AND
	telEtud LIKE CASE WHEN TEL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(TEL,'%')) END AND
	cite LIKE CASE WHEN CIT IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CIT,'%')) END AND
	codeClasse LIKE CASE WHEN CODECL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CODECL,'%')) END AND
	(Lieu LIKE CASE WHEN LIEUN IS NULL THEN '%' ELSE CONCAT('%',CONCAT(LIEUN,'%')) END OR Lieu IS NULL) AND
	(DateNaiss LIKE CASE WHEN DATEN IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DATEN AS CHAR),'%')) END OR DateNaiss IS NULL) AND 
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END AND
	DateCreation LIKE CASE WHEN dtcre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtcre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dtup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dtup AS CHAR),'%')) END;
END|
