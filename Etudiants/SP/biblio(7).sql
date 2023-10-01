-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Serveur: localhost
-- Généré le : Sam 11 Janvier 2014 à 11:17
-- Version du serveur: 5.1.41
-- Version de PHP: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `biblio`
--

-- --------------------------------------------------------

--
-- Structure de la table `classes`
--

DROP TABLE IF EXISTS `classes`;
CREATE TABLE IF NOT EXISTS `classes` (
  `codeClasse` char(5) NOT NULL,
  `libClasse` varchar(50) NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`codeClasse`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `classes`
--

INSERT INTO `classes` (`codeClasse`, `libClasse`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
('PAPI', 'Programmation appliqu‚ pour internet', '2014-01-03 16:03:34', '2014-01-03 16:03:34', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `domaines`
--

DROP TABLE IF EXISTS `domaines`;
CREATE TABLE IF NOT EXISTS `domaines` (
  `numDom` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `nomDom` varchar(50) NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`numDom`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `domaines`
--


-- --------------------------------------------------------

--
-- Structure de la table `entrees`
--

DROP TABLE IF EXISTS `entrees`;
CREATE TABLE IF NOT EXISTS `entrees` (
  `NumBord` tinyint(4) NOT NULL AUTO_INCREMENT,
  `DateBord` date DEFAULT NULL,
  `NomFsseur` varchar(50) DEFAULT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`NumBord`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `entrees`
--


-- --------------------------------------------------------

--
-- Structure de la table `entrees_livres`
--

DROP TABLE IF EXISTS `entrees_livres`;
CREATE TABLE IF NOT EXISTS `entrees_livres` (
  `NumBord` tinyint(4) NOT NULL,
  `CodeLivre` mediumint(8) unsigned NOT NULL,
  `QteEntree` int(11) NOT NULL,
  `PuEntree` mediumint(8) unsigned NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`NumBord`,`CodeLivre`),
  KEY `CodeLivre` (`CodeLivre`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `entrees_livres`
--


-- --------------------------------------------------------

--
-- Structure de la table `etudiants`
--

DROP TABLE IF EXISTS `etudiants`;
CREATE TABLE IF NOT EXISTS `etudiants` (
  `matricule` char(8) NOT NULL,
  `nomEtud` varchar(50) NOT NULL,
  `sexeEtud` enum('F','M') DEFAULT 'F',
  `telEtud` char(7) DEFAULT NULL,
  `cite` enum('O','N') DEFAULT 'N',
  `codeClasse` char(5) NOT NULL,
  `DateNaiss` date DEFAULT NULL,
  `Lieu` varchar(50) DEFAULT NULL,
  `ExtPhoto` char(5) DEFAULT NULL,
  `CheminPhoto` varchar(50) DEFAULT NULL,
  `DateCreation` int(11) NOT NULL,
  `DateModification` int(11) NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`matricule`),
  KEY `idxCodeClasse` (`codeClasse`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `etudiants`
--

INSERT INTO `etudiants` (`matricule`, `nomEtud`, `sexeEtud`, `telEtud`, `cite`, `codeClasse`, `DateNaiss`, `Lieu`, `ExtPhoto`, `CheminPhoto`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
('ISTDITIC', 'Couakam Njamen Guy', '', '9627905', '', 'PAPI', '2014-01-18', 'Douala', '.JPG', 'ISTDITIC14..JPG', 2014, 2014, 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `groupe`
--

DROP TABLE IF EXISTS `groupe`;
CREATE TABLE IF NOT EXISTS `groupe` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Intitule` varchar(50) NOT NULL,
  `Statut` tinyint(1) DEFAULT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Intitule` (`Intitule`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `groupe`
--

INSERT INTO `groupe` (`Id`, `Intitule`, `Statut`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, 'Administration', 1, '2014-01-03 04:42:01', '2014-01-03 04:42:06', 1, 1),
(2, 'Super_Admin', 1, '2014-01-06 22:49:14', '2014-01-06 22:49:14', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `groupe_privilege`
--

DROP TABLE IF EXISTS `groupe_privilege`;
CREATE TABLE IF NOT EXISTS `groupe_privilege` (
  `IdGroupe` int(11) NOT NULL,
  `IdMenu` int(11) NOT NULL,
  `Statut` tinyint(1) NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`IdGroupe`,`IdMenu`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `groupe_privilege`
--

INSERT INTO `groupe_privilege` (`IdGroupe`, `IdMenu`, `Statut`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, 1, 1, '2014-01-06 00:00:00', '2014-01-06 00:00:00', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `livres`
--

DROP TABLE IF EXISTS `livres`;
CREATE TABLE IF NOT EXISTS `livres` (
  `codeLivre` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `ISBN` char(13) DEFAULT NULL,
  `intitule` varchar(50) NOT NULL,
  `auteur` varchar(50) NOT NULL,
  `editeur` varchar(50) NOT NULL,
  `stock` tinyint(3) unsigned DEFAULT NULL,
  `pu` mediumint(8) unsigned DEFAULT NULL,
  `numDom` tinyint(3) unsigned NOT NULL,
  `ExtCouverture` char(5) DEFAULT NULL,
  `CheminCouv` varchar(200) DEFAULT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`codeLivre`),
  KEY `idxNumDom` (`numDom`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `livres`
--


-- --------------------------------------------------------

--
-- Structure de la table `prets`
--

DROP TABLE IF EXISTS `prets`;
CREATE TABLE IF NOT EXISTS `prets` (
  `numPret` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `datePret` date NOT NULL DEFAULT '0000-00-00',
  `echeancePret` date NOT NULL DEFAULT '0000-00-00',
  `retour` enum('O','N') DEFAULT 'N',
  `dateRetour` date DEFAULT '0000-00-00',
  `matricule` char(8) NOT NULL,
  `codeLivre` mediumint(8) unsigned NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`numPret`),
  KEY `idxCodeLivre` (`codeLivre`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`),
  KEY `IdModificateur` (`IdModificateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `prets`
--


-- --------------------------------------------------------

--
-- Structure de la table `privilege`
--

DROP TABLE IF EXISTS `privilege`;
CREATE TABLE IF NOT EXISTS `privilege` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Intitule` varchar(50) NOT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Intitule` (`Intitule`),
  KEY `IdCreateur` (`IdCreateur`,`IdModificateur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `privilege`
--

INSERT INTO `privilege` (`Id`, `Intitule`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, 'Insert', '2014-01-06 22:55:33', '2014-01-06 22:55:33', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdGroupe` int(11) NOT NULL,
  `Compte` varchar(50) NOT NULL,
  `Passe` varchar(50) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `DateDernierConnexion` datetime DEFAULT NULL,
  `Telephone` varchar(50) DEFAULT NULL,
  `Statut` bit(1) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Photo` varchar(50) DEFAULT NULL,
  `PhotoExtension` char(5) DEFAULT NULL,
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
  `IdCreateur` int(11) NOT NULL,
  `IdModificateur` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Compte` (`Compte`),
  KEY `IdModificateur` (`IdModificateur`),
  KEY `IdCreateur` (`IdCreateur`),
  KEY `IdGroupe` (`IdGroupe`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`Id`, `IdGroupe`, `Compte`, `Passe`, `Nom`, `DateDernierConnexion`, `Telephone`, `Statut`, `Email`, `Photo`, `PhotoExtension`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, 1, 'Admin', 'G:\\phot\\DSC00203.JPG', 'Couakam Guy', NULL, '96279059', b'1', 'jgjgjhj', 'PhotoUser\\Admin', '.JPG', '2014-01-10 22:25:56', '2014-01-10 22:25:56', 1, 1),
(12, 1, 'bruit', 'G:\\phot\\DSC00196.JPG', 'bruit', NULL, '7557575757', b'1', 'bruit', 'PhotoUser\\bruit', '.JPG', '2014-01-10 00:00:00', '2014-01-10 00:00:00', 1, 1);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `classes_ibfk_2` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `domaines`
--
ALTER TABLE `domaines`
  ADD CONSTRAINT `domaines_ibfk_1` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `domaines_ibfk_2` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `entrees`
--
ALTER TABLE `entrees`
  ADD CONSTRAINT `entrees_ibfk_1` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `entrees_ibfk_2` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `entrees_livres`
--
ALTER TABLE `entrees_livres`
  ADD CONSTRAINT `entrees_livres_ibfk_1` FOREIGN KEY (`NumBord`) REFERENCES `entrees` (`NumBord`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `entrees_livres_ibfk_2` FOREIGN KEY (`CodeLivre`) REFERENCES `livres` (`codeLivre`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `entrees_livres_ibfk_3` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `entrees_livres_ibfk_4` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `etudiants`
--
ALTER TABLE `etudiants`
  ADD CONSTRAINT `etudiants_ibfk_1` FOREIGN KEY (`codeClasse`) REFERENCES `classes` (`codeClasse`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `etudiants_ibfk_2` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `etudiants_ibfk_3` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `groupe`
--
ALTER TABLE `groupe`
  ADD CONSTRAINT `groupe_ibfk_1` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `groupe_ibfk_2` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `livres`
--
ALTER TABLE `livres`
  ADD CONSTRAINT `livres_ibfk_1` FOREIGN KEY (`numDom`) REFERENCES `domaines` (`numDom`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `livres_ibfk_2` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `livres_ibfk_3` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `prets`
--
ALTER TABLE `prets`
  ADD CONSTRAINT `prets_ibfk_1` FOREIGN KEY (`codeLivre`) REFERENCES `livres` (`codeLivre`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prets_ibfk_2` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `prets_ibfk_3` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `utilisateur_ibfk_13` FOREIGN KEY (`IdCreateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `utilisateur_ibfk_14` FOREIGN KEY (`IdModificateur`) REFERENCES `utilisateur` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `utilisateur_ibfk_8` FOREIGN KEY (`IdGroupe`) REFERENCES `groupe` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `SP_CLASSE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CLASSE_DELETE`(
	IN CODECL CHAR(5)
	

)
BEGIN
	DELETE FROM Classes  WHERE codeClasse=CODECL;
END$$

DROP PROCEDURE IF EXISTS `SP_CLASSE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CLASSE_INSERT`(
	IN CODECL CHAR(5),
	IN LIBCL VARCHAR(50),
	IN idcre INT,
	IN idup INT

)
BEGIN
	INSERT INTO Classes(codeClasse,libClasse,DateCreation,DateModification,IdCreateur,IdModificateur) VALUES(CODECL,LIBCL,now(),now(),idcre,idup);
END$$

DROP PROCEDURE IF EXISTS `SP_CLASSE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CLASSE_SELECT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_CLASSE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CLASSE_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_DOMAINE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DOMAINE_DELETE`(
	IN NumD INT
	

)
BEGIN
	DELETE FROM Domaines  WHERE NumDom=NumD;
END$$

DROP PROCEDURE IF EXISTS `SP_DOMAINE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DOMAINE_INSERT`(
	IN NumD INT,
	IN NOM VARCHAR(50)

)
BEGIN
	INSERT INTO Domaines(NumDom,NomDom) VALUES(NumD,NOM );
END$$

DROP PROCEDURE IF EXISTS `SP_DOMAINE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DOMAINE_SELECT`(
	IN NumD INT,
	IN NOM VARCHAR(50)
)
BEGIN
	SELECT * FROM Domaines

	WHERE NumDom LIKE CASE WHEN NumD IS NULL THEN '%' ELSE CAST(NumD AS CHAR) END AND 
	NomDom LIKE CASE WHEN NOM IS NULL THEN '%' ELSE CONCAT('%',CONCAT(NoM,'%')) END;
END$$

DROP PROCEDURE IF EXISTS `SP_DOMAINE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_DOMAINE_UPDATE`(
	IN NumD INT,
	IN OLDNumD CHAR(5),
	IN NOM VARCHAR(50)

)
BEGIN
	UPDATE Domaines SET NumDom=NumD,NomDom=NoM WHERE NumDom=OLDNumD;
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_DELETE`(
	IN NumB INT
	

)
BEGIN
	DELETE FROM Entrees WHERE NumBord=NumB;
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_INSERT`(
	IN NumB INT,
	IN DATEB DATE,
	IN NOMF VARCHAR(50)

)
BEGIN
	INSERT INTO Entrees(NumBord, DateBord, NomFsseur) VALUES(NumB,DATEB,NOMF );
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_LIVRE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_LIVRE_DELETE`(
	IN NumB TINYINT,
	IN CodeL MEDIUMINT
)
BEGIN
	DELETE FROM ENTREES_LIVRES WHERE NumBord=NumB AND CodeLivre=CodeL;
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_LIVRE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_LIVRE_INSERT`(
	IN NumB TINYINT,
	IN CodeL MEDIUMINT,
	IN QTE INT,
	IN PU MEDIUMINT

)
BEGIN
	INSERT INTO ENTREES_LIVRES(NumBord, CodeLivre, QteEntree, PuEntree) VALUES(NumB,CodeL,QTE,PU);
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_LIVRE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_LIVRE_SELECT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_LIVRE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_LIVRE_UPDATE`(
	IN NumB TINYINT,
	IN OLDNumB TINYINT,
	IN CodeL MEDIUMINT,
	IN OLDCodeL MEDIUMINT,
	IN QTE INT,
	IN PU MEDIUMINT
)
BEGIN
	UPDATE ENTREES_LIVRES SET QteEntree=QTE, PuEntree=PU,CodeLivre=CodeL,NumBord=NumB WHERE NumBord=OLDNumB AND CodeLivre=OLDCodeL;
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_SELECT`(
	IN NumB INT,
	IN DATEB DATE,
	IN NOMF VARCHAR(50)
)
BEGIN
	SELECT * FROM Entrees

	WHERE NumBord LIKE CASE WHEN NumBord IS NULL THEN '%' ELSE CAST(NumB AS CHAR) END AND
	DateBord LIKE CASE WHEN DATEB IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DATEB AS CHAR),'%')) END OR DateBord IS NULL AND
	NomFsseur LIKE CASE WHEN NomFsseur IS NULL THEN '%' ELSE CONCAT('%',CONCAT(NOMF,'%')) END OR NomFsseu IS NULL;
END$$

DROP PROCEDURE IF EXISTS `SP_ENTREES_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ENTREES_UPDATE`(
	IN NumB INT,
	IN OLDNumB INT,
	IN DATEB DATE,
	IN NOMF VARCHAR(50)

)
BEGIN
	UPDATE Entrees SET NumBord=NumB,DateBord=DATEB,NomFsseur=NoMF WHERE NumBord=OLDNumB;
END$$

DROP PROCEDURE IF EXISTS `SP_ETUDIANT_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ETUDIANT_DELETE`(
	IN MAT CHAR(8)
	

)
BEGIN
	DELETE FROM Etudiants  WHERE matricule=MAT;
END$$

DROP PROCEDURE IF EXISTS `SP_ETUDIANT_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ETUDIANT_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_ETUDIANT_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ETUDIANT_SELECT`(
	
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
END$$

DROP PROCEDURE IF EXISTS `SP_ETUDIANT_SELECT_ALL`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ETUDIANT_SELECT_ALL`(
	
	IN MAT CHAR(8),
	IN NOM VARCHAR(50),
	IN SEXE ENUM('F','M'),
	IN TEL CHAR(7),
	IN CIT ENUM('O','N'),
	IN CODECL CHAR(5),
	IN LIEUN VARCHAR(50),
	IN DATEN DATE

)
BEGIN
	SELECT * FROM Etudiants

	WHERE matricule LIKE CASE WHEN MAT IS NULL THEN '%' ELSE CONCAT('%',CONCAT(MAT,'%')) END OR
	nomEtud LIKE CASE WHEN NOM IS NULL THEN '%' ELSE CONCAT('%',CONCAT(NOM,'%')) END OR
	sexeEtud LIKE CASE WHEN SEXE IS NULL THEN '%' ELSE CONCAT('%',CONCAT(SEXE,'%')) END OR
	telEtud LIKE CASE WHEN TEL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(TEL,'%')) END OR
	cite LIKE CASE WHEN CIT IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CIT,'%')) END OR
	codeClasse LIKE CASE WHEN CODECL IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CODECL,'%')) END OR
	(Lieu LIKE CASE WHEN LIEUN IS NULL THEN '%' ELSE CONCAT('%',CONCAT(LIEUN,'%')) END OR Lieu IS NULL) OR
	(DateNaiss LIKE CASE WHEN DATEN IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DATEN AS CHAR),'%')) END OR DateNaiss IS NULL);
END$$

DROP PROCEDURE IF EXISTS `SP_ETUDIANT_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ETUDIANT_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_DELETE`(
	IN idg int
	

)
BEGIN
	DELETE FROM Groupe  WHERE Id=idg;
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_PRIVILEGE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_PRIVILEGE_DELETE`(
	IN idg int,
	IN idm int
	

)
BEGIN
	DELETE FROM Groupe_Privilege WHERE IdGroupe=idg AND IdMenu=idm ;
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_PRIVILEGE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_PRIVILEGE_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_PRIVILEGE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_PRIVILEGE_SELECT`(
	
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
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_PRIVILEGE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_PRIVILEGE_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_Groupe_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Groupe_SELECT`(
	
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
END$$

DROP PROCEDURE IF EXISTS `SP_GROUPE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_GROUPE_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_Livres_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Livres_DELETE`(
	IN CodeLivre int
	

)
BEGIN
	DELETE FROM Livres  WHERE codeLivre=CodeLivre;
END$$

DROP PROCEDURE IF EXISTS `SP_Livres_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Livres_INSERT`(
		IN codeLivre int,
		IN ISBN char(13) ,
		IN intitule varchar(50),
		IN auteur varchar(50) ,
		IN editeur varchar(50) ,
		IN stock int ,
		IN pu double,
		IN numDom double,
	    IN ExtCouverture char(5) ,
		IN CheminCouv varchar(200) 
	
)
BEGIN
	INSERT INTO Livres(codeLivre,
			    ISBN,
			    intitule,				
			    auteur,
			    editeur,
			    stock,
			    pu,
				NumDom,ExtCouverture,CheminCouv
			    ) VALUES(codeLivre,ISBN,intitule,auteur,editeur,stock,pu,NumDom,ExtCouverture,CheminCouv);
END$$

DROP PROCEDURE IF EXISTS `SP_Livres_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Livres_UPDATE`(
		IN codeLivre int,
		IN OLDCodeLivre int,
		IN ISBN char(13) ,
		IN intitule varchar(50),
		IN auteur varchar(50) ,
		IN editeur varchar(50) ,
		IN stock int ,
		IN pu double,
		IN numDom double,
	    IN ExtCouverture char(5) ,
		IN CheminCouv varchar(200) 

)
BEGIN
	UPDATE Livres SET   codeLivre=codeLivre,
						ISBN=ISBN,				
						intitule=intitule,
						auteur=auteur,
						editeur=editeur,
						stock=stock,
						pu=pu,
						pu=pu,
						numDom=numDom,
						ExtCouverture=ExtCouverture,
					    CheminCouv=CheminCouv
					WHERE codeLivre=OLDCodeLivre;
		END$$

DROP PROCEDURE IF EXISTS `SP_LIVRE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LIVRE_DELETE`(
	IN CodeLivreL MEDIUMINT
	

)
BEGIN
	DELETE FROM Livres  WHERE codeLivre=CodeLivreL;
END$$

DROP PROCEDURE IF EXISTS `SP_LIVRE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LIVRE_INSERT`(
	IN CodeLivreL MEDIUMINT,
	IN ISBNL CHAR(13),
	IN IntituleL varCHAR(50),
	IN AuteurL varchar(50),
	IN EditeurL varCHAR(50),
	IN StockL TINYINT,
	IN PUL MEDIUMINT,
	IN NumDomL TINYINT,
	IN ExtCouvL CHAR(5),
	IN CheminCouvL VARCHAR(200)
	

)
BEGIN
	INSERT INTO Livres(codeLivre,
			    ISBN,
			    intitule,				
			    auteur,
			    editeur,
			    stock,
			    pu,
		            numDom,				
			    ExtCouverture,
			    CheminCouv
			    ) VALUES(CodeLivreL,ISBNL, IntituleL,AuteurL,EditeurL,StockL,PUL,NumDomL,ExtCouvL,CheminCouvL);
END$$

DROP PROCEDURE IF EXISTS `SP_LIVRE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LIVRE_SELECT`(
	
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
END$$

DROP PROCEDURE IF EXISTS `SP_LIVRE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LIVRE_UPDATE`(
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
	IN CheminCouvL VARCHAR(200)

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
			    CheminCouv=CheminCouvL
	WHERE codeLivre=OLDCodeLivreL;
END$$

DROP PROCEDURE IF EXISTS `SP_PRET_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRET_DELETE`(
	IN NumP int
	

)
BEGIN
	DELETE FROM Prets  WHERE numPret=NumP;
END$$

DROP PROCEDURE IF EXISTS `SP_PRET_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRET_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_PRET_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRET_SELECT`(
	IN NumP int,
	IN DateP date,
	IN EcheanP date,
	IN RetourP ENUM('O','N'),
	IN DateRP date,
	IN Mat char(8),
	IN CodeLivreL int

)
BEGIN
	SELECT * FROM Prets

	WHERE NumPret LIKE CASE WHEN NumP IS NULL THEN '%' ELSE CAST(NumP AS CHAR) END AND 
	DatePret LIKE CASE WHEN DateP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DateP AS CHAR),'%')) END AND
	EcheanPret LIKE CASE WHEN EcheanP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(EcheanP AS CHAR),'%')) END AND
	RetourPret LIKE CASE WHEN RetourP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(RetourP,'%')) END OR RetourPret IS NULL  AND
	DateRetour LIKE CASE WHEN DateRP IS NULL THEN '%' ELSE CONCAT('%',CONCAT(CAST(DateRP AS CHAR),'%')) END OR DateRetour IS NULL AND
	Matricule LIKE CASE WHEN Mat IS NULL THEN '%' ELSE CONCAT('%',CONCAT(Mat,'%')) END AND
	CodeLivre LIKE CASE WHEN CodeLivreL IS NULL THEN '%' ELSE  CAST(CodeLivreL AS CHAR) END;
END$$

DROP PROCEDURE IF EXISTS `SP_PRET_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRET_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_PRIVILEGE_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRIVILEGE_DELETE`(
	IN idp int
	

)
BEGIN
	DELETE FROM Privilege  WHERE Id=idp;
END$$

DROP PROCEDURE IF EXISTS `SP_PRIVILEGE_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRIVILEGE_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_PRIVILEGE_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRIVILEGE_SELECT`(
	
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
END$$

DROP PROCEDURE IF EXISTS `SP_PRIVILEGE_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PRIVILEGE_UPDATE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_USER_DELETE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_USER_DELETE`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_USER_INSERT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_USER_INSERT`(
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
END$$

DROP PROCEDURE IF EXISTS `SP_USER_SELECT`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_USER_SELECT`(
	
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
	
END$$

DROP PROCEDURE IF EXISTS `SP_USER_UPDATE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_USER_UPDATE`(
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
			    Passe=passw,				
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
END$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
