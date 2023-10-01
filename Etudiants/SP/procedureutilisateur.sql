delimiter |
create procedure SP_USER_INSERT
(
	IN idg int,
	IN log VARCHAR(50),
	IN passw VARCHAR(50),
	IN nomu VARCHAR(50),
	IN dateder DATE,
	IN telu VARCHAR(50),
	IN statu bit,
	IN emailu VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN phot VARCHAR(50),
	IN extp VARCHAR(50)

)
BEGIN
	INSERT INTO Utilisateur(
			    IdGroupe,
			    Compte,
			    Passe,				
			    Nom,
			    DateDernierConnexion,
			    Telephone,
			    Statut,
			    Email,
			    Photo,
			    PhotoExtension,
			    DateCreation,
			    DateModification,
			    IdCreateur,
			    IdModificateur) VALUES(idg,log,PASSWORD(passw),nomu,dateder,telu,statu,emailu,phot,extp,now(),now(),idcre,idup);
END |

create procedure SP_USER_UPDATE
(
	IN idu int,
	IN idg int,
	IN log VARCHAR(50),
	IN passw VARCHAR(50),
	IN nomu VARCHAR(50),
	IN dateder DATE,
	IN telu VARCHAR(50),
	IN statu bit,
	IN emailu VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN phot VARCHAR(50),
	IN extp VARCHAR(50)

)
BEGIN
	UPDATE Utilisateur SET IdGroupe=idg,
			    Compte=log,
			    Passe=PASSWORD(passw),				
			    Nom=nomu,
			    DateDernierConnexion=dateder,
			    Telephone=telu,
			    Statut=statu,
			    Email=emailu,
			    Photo=phot,
			    PhotoExtension=extp,
			    DateCreation=now(),
			    DateModification=now(),
			    IdCreateur=idcre,
			    IdModificateur=idup

        WHERE Id=idu ;
END|

create procedure SP_USER_DELETE
(
	IN idu int,
	IN idDel int
	

)
BEGIN
SET AUTOCOMMIT=0;

	START TRANSACTION;	
		UPDATE Utilisateur SET IdCreateur=CASE WHEN IdCreateur=idu THEN idDel END,IdModificateur=CASE WHEN IdModificateur=idu THEN idDel END WHERE IdCreateur=idu OR IdModificateur=idu;
		DELETE FROM Utilisateur  WHERE Id=idu;

	SELECT ROW_COUNT() INTO @nbre;

       COMMIT;
END|

create procedure SP_USER_SELECT
(
	
	IN idu int,
	IN idg int,
	IN log VARCHAR(50),
	IN passw VARCHAR(50),
	IN nomu VARCHAR(50),
	IN dateder DATE,
	IN telu VARCHAR(50),
	IN statu bit,
	IN emailu VARCHAR(50),
	IN datecre DATE,
	IN dateup DATE,
	IN idcre int,
	IN idup int,
	IN phot VARCHAR(50),
	IN extp VARCHAR(50)

)
BEGIN

	SELECT * FROM Utilisateur

	WHERE Id LIKE CASE WHEN idu IS NULL THEN '%' ELSE CAST(idu AS CHAR) END AND
	IdGroupe LIKE CASE WHEN idg IS NULL THEN '%' ELSE CAST(idg AS CHAR) END AND
	Compte LIKE CASE WHEN log IS NULL THEN '%' ELSE CONCAT('%',CONCAT(log,'%')) END AND
	Passe LIKE CASE WHEN passw IS NULL THEN '%' ELSE CONCAT('%',CONCAT(passw,'%')) END AND
	Nom LIKE CASE WHEN nomu IS NULL THEN '%' ELSE CONCAT('%',CONCAT(nomu,'%')) END AND
	(DateDernierConnexion LIKE CASE WHEN dateder IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dateder AS CHAR),'%')) END) OR DateDernierConnexion IS NULL AND
	(Telephone LIKE CASE WHEN telu IS NULL THEN '%' ELSE CONCAT('%',CONCAT(telu,'%')) END) OR Telephone IS NULL AND
	Statut LIKE CASE WHEN statu IS NULL THEN '%' ELSE CAST(statu AS CHAR) END AND
	(Email LIKE CASE WHEN emailu IS NULL THEN '%' ELSE CONCAT('%',CONCAT(emailu,'%')) END) OR Email IS NULL AND
	DateCreation LIKE CASE WHEN datecre IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(datecre AS CHAR),'%')) END AND
	DateModification LIKE CASE WHEN dateup IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(dateup AS CHAR),'%')) END AND
	IdCreateur LIKE CASE WHEN idcre IS NULL THEN '%' ELSE CAST(idcre AS CHAR) END AND
	IdModificateur LIKE CASE WHEN idup IS NULL THEN '%' ELSE CAST(idup AS CHAR) END;
	
END|
