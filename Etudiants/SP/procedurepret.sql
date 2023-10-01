drop procedure SP_PRET_INSERT|
drop procedure SP_PRET_SELECT|
drop procedure SP_PRET_UPDATE|
drop procedure SP_PRET_DELETE|
delimiter |
create procedure SP_PRET_INSERT
(
	IN NumP int,
	IN DateP DATE,
	IN EcheanP DATE,
	IN RetourP ENUM('O','N'),
	IN DateRP DATE,
	IN Mat char(8),
	IN CodeLivreL MEDIUMINT
	

)
BEGIN
	INSERT INTO Prets(  numPret,
			    datePret,
			    echeancePret,				
			    retour,
			    dateRetour,
			    matricule,
			    codeLivre
			    ) VALUES(NumP,DateP, EcheanP,RetourP,DateRP,Mat,CodeLivreL);
END |

create procedure SP_PRET_UPDATE
(
	IN NumP int,
	IN DateP DATE,
	IN EcheanP DATE,
	IN RetourP ENUM('O','N'),
	IN DateRP DATE,
	IN Mat char(8),
	IN CodeLivreL MEDIUMINT

)
BEGIN
	UPDATE Prets  SET   datePret=DateP,
			    echeancePret=EcheanP,				
			    retour=RetourP,
			    dateRetour=DateRP,
			    matricule=Mat,
			    codeLivre=CodeLivreL 
	WHERE numPret=NumP;
END|

create procedure SP_PRET_DELETE
(
	IN NumP int
	

)
BEGIN
	DELETE FROM Prets  WHERE numPret=NumP;
END|

create procedure SP_PRET_SELECT
(
	IN NumP int,
	IN DateP DATE,
	IN EcheanP DATE,
	IN RetourP ENUM('O','N'),
	IN DateRP DATE,
	IN Mat char(8),
	IN CodeLivreL MEDIUMINT

)
BEGIN
	SELECT * FROM Prets

	WHERE numPret LIKE CASE WHEN NumP IS NULL THEN '%' ELSE CAST(NumP AS CHAR) END AND
	datePret LIKE CASE WHEN DateP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DateP AS CHAR),'%')) END AND
	echeancePret LIKE CASE WHEN EcheanP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(EcheanP AS CHAR),'%')) END AND
	retour LIKE CASE WHEN RetourP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(RetourP,'%')) END AND
	dateRetour LIKE CASE WHEN DateRP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DateRP AS CHAR),'%')) END AND
	matricule LIKE CASE WHEN Mat IS NULL THEN '%' ELSE CONCAT('%',CONCAT(Mat,'%')) END
	;
END|

	
