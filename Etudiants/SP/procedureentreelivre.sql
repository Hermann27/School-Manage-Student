delimiter |
create procedure SP_ENTREES_LIVRE_INSERT
(
	IN NumB TINYINT,
	IN CodeL MEDIUMINT,
	IN QTE INT,
	IN PU MEDIUMINT

)
BEGIN
	INSERT INTO ENTREES_LIVRES(NumBord, CodeLivre, QteEntree, PuEntree) VALUES(NumB,CodeL,QTE,PU);
END |

create procedure SP_ENTREES_LIVRE_UPDATE
(
	IN NumB TINYINT,
	IN OLDNumB TINYINT,
	IN CodeL MEDIUMINT,
	IN OLDCodeL MEDIUMINT,
	IN QTE INT,
	IN PU MEDIUMINT
)
BEGIN
	UPDATE ENTREES_LIVRES SET QteEntree=QTE, PuEntree=PU,CodeLivre=CodeL,NumBord=NumB WHERE NumBord=OLDNumB AND CodeLivre=OLDCodeL;
END|

create procedure SP_ENTREES_LIVRE_DELETE
(
	IN NumB TINYINT,
	IN CodeL MEDIUMINT
)
BEGIN
	DELETE FROM ENTREES_LIVRES WHERE NumBord=NumB AND CodeLivre=CodeL;
END|

create procedure SP_ENTREES_LIVRE_SELECT
(
	IN NumB TINYINT,
	IN CodeL MEDIUMINT,
	IN QTE INT,
	IN PU MEDIUMINT
)
BEGIN
	SELECT * FROM ENTREES_LIVRES

	WHERE NumBord LIKE CASE WHEN NumB IS NULL THEN '%' ELSE CAST(NumB AS CHAR) END AND
	CodeLivre LIKE CASE WHEN CodeL IS NULL THEN '%' ELSE CAST(CodeL AS CHAR) END AND 
	QteEntree LIKE CASE WHEN QTE IS NULL THEN '%' ELSE CAST(QTE AS CHAR) END AND
	PuEntree LIKE CASE WHEN PU IS NULL THEN '%' ELSE CAST(PU AS CHAR) END;
END