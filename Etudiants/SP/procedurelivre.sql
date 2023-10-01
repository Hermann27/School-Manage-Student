delimiter |
create procedure SP_LIVRE_INSERT
(
	IN CodeLivreL MEDIUMINT,
	IN ISBNL CHAR(13),
	IN IntituleL varCHAR(50),
	IN AuteurL varchar(50),
	IN EditeurL varCHAR(50),
	IN StockL TINYINT,
	IN PUL MEDIUMINT,
	IN NumDomL TINYINT,
	IN ExtCouvL CHAR(5),
	IN CheminCouvL VARCHAR(200),
	IN IdCreateur INT,
	IN IdModificateur INT

)
BEGIN
	INSERT INTO Livres(
			    ISBN,
			    intitule,				
			    auteur,
			    editeur,
			    stock,
			    pu,
		        numDom,				
			    ExtCouverture,
			    CheminCouv,
				IdCreateur,
				IdModificateur
			    ) VALUES(ISBNL, IntituleL,AuteurL,EditeurL,StockL,PUL,NumDomL,ExtCouvL,CheminCouvL,IdCreateur,IdModificateur);
END |

create procedure SP_LIVRE_UPDATE
(
	IN CodeLivreL MEDIUMINT,
	IN OLDCodeLivreL MEDIUMINT,
	IN ISBNL CHAR(13),
	IN IntituleL varCHAR(50),
	IN AuteurL varchar(50),
	IN EditeurL varCHAR(50),
	IN StockL TINYINT,
	IN PUL MEDIUMINT,
	IN NumDomL TINYINT,
	IN ExtCouvL CHAR(5),
	IN CheminCouvL VARCHAR(200),
	IN IdCreateur INT,
	IN IdModificateur INT

)
BEGIN
	UPDATE Livres SET codeLivre=CodeLivreL,
			    ISBN=ISBNL,
			    intitule=IntituleL,				
			    auteur=AuteurL,
			    editeur=EditeurL,
			    stock=StockL,
			    pu=PUL,
		        numDom=NumDomL,				
			    ExtCouverture=ExtCouvL,
			    CheminCouv=CheminCouvL,
				IdCreateur=IdCreateur,
				IdModificateur=IdModificateur
	WHERE codeLivre=OLDCodeLivreL;
END|

create procedure SP_LIVRE_DELETE
(
	IN CodeLivreL MEDIUMINT
	

)
BEGIN
	DELETE FROM Livres  WHERE codeLivre=CodeLivreL;
END|

create procedure SP_LIVRE_SELECT
(
	
	IN CodeLivreL MEDIUMINT,
	IN ISBNL CHAR(13),
	IN IntituleL varCHAR(50),
	IN AuteurL varchar(50),
	IN EditeurL varCHAR(50),
	IN StockL TINYINT,
	IN PUL MEDIUMINT,
	IN NumDomL TINYINT

)
BEGIN
	SELECT * FROM Livres

	WHERE CodeLivre LIKE CASE WHEN CodeLivreL IS NULL THEN '%' ELSE CAST(CodeLivreL AS CHAR) END AND
	ISBN LIKE CASE WHEN ISBNL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(ISBNL,'%')) END AND
	Intitule LIKE CASE WHEN IntituleL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(IntituleL,'%')) END AND
	Auteur LIKE CASE WHEN AuteurL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(AuteurL,'%')) END AND
	Editeur LIKE CASE WHEN EditeurL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(EditeurL,'%')) END AND
	Stock LIKE CASE WHEN StockL IS NULL THEN '%' ELSE CAST(StockL AS CHAR) END OR Stock IS NULL AND
	PU LIKE CASE WHEN PUL IS NULL THEN '%' ELSE CAST(PUL AS CHAR) END OR PU IS NULL AND
	NumDom LIKE CASE WHEN NumDomL IS NULL THEN '%' ELSE CAST(NumDomL AS CHAR) END
	;
END|

	
