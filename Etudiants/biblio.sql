-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Serveur: localhost
-- Généré le : Lun 24 Février 2014 à 17:40
-- Version du serveur: 5.5.8
-- Version de PHP: 5.3.5

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
('gbh', 'Geni L', '2014-02-05 15:34:53', '2014-02-05 15:34:53', 1, 1),
('GL', 'Geni Logiciel', '2014-01-17 09:18:22', '2014-01-17 09:18:22', 1, 1),
('PAPI', 'Programmation appliqu‚ pour internet fort', '2014-01-03 16:03:34', '2014-01-14 02:03:27', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `domaines`
--

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `domaines`
--

INSERT INTO `domaines` (`numDom`, `nomDom`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(3, 'ALGEBRE', '2014-01-14 02:49:13', '2014-01-14 02:49:13', 1, 1),
(4, 'ABOUBAKAR', '2014-01-14 02:51:06', '2014-01-14 02:51:06', 1, 1),
(5, 'Science', '2014-01-17 09:13:25', '2014-01-17 09:13:25', 1, 1),
(6, 'GHFG', '2014-01-31 10:16:57', '2014-01-31 10:16:57', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `entrees`
--

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `entrees`
--

INSERT INTO `entrees` (`NumBord`, `DateBord`, `NomFsseur`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, '2014-01-14', 'Njamen', '2014-01-14 03:15:26', '2014-01-14 03:15:26', 1, 1),
(2, '2014-01-22', 'DHL', '2014-01-22 19:58:05', '2014-01-22 19:58:05', 1, 1),
(3, '2014-02-02', 'hjjj', '2014-02-02 11:00:29', '2014-02-02 11:00:29', 1, 1),
(4, '2014-02-04', 'potila', '2014-02-12 13:42:24', '2014-02-12 13:42:24', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `entrees_livres`
--

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
  `DateCreation` datetime NOT NULL,
  `DateModification` datetime NOT NULL,
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
('ISTD00', 'Couakam Njamen Guy', 'M', '9627905', NULL, 'GL', '2014-01-18', 'Douala', '', 'ISTD00', '2014-01-22 19:24:09', '2014-01-22 19:24:09', 1, 1),
('Istdi00', 'daniel onguene', '', '7809899', '', 'GL', '2014-01-22', 'Bafia', '.jpg', 'Istdi00', '2014-01-22 19:26:43', '2014-01-27 23:33:06', 1, 1),
('Istdi002', 'daniel onguene', '', '7809899', '', 'PAPI', '2014-01-22', 'Bafia', '.jpg', 'dossierphoto\\Istdi002', '2014-01-27 23:33:40', '2014-01-27 23:33:40', 1, 1),
('Istdi23', 'daniel onguene', '', '7809899', '', 'GL', '2014-01-22', 'Bafia', '.jpg', 'dossierphoto\\Istdi23', '2014-01-27 23:30:55', '2014-01-27 23:30:55', 1, 1),
('ISTDITIC', 'Couakam Njamen Guy', 'M', '9627905', NULL, 'GL', '2014-01-18', 'Dyde', '', 'ISTDITIC', '2014-01-16 00:00:00', '2014-01-22 19:24:56', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `groupe`
--

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Contenu de la table `livres`
--

INSERT INTO `livres` (`codeLivre`, `ISBN`, `intitule`, `auteur`, `editeur`, `stock`, `pu`, `numDom`, `ExtCouverture`, `CheminCouv`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(4, '1111-00F', 'Programmation C++ 2009', 'Zera Eryoruk', 'Ramus', 2, 36000, 6, '.gif', '1111-00F', '2014-02-02 09:13:23', '2014-02-02 09:13:23', 1, 1),
(6, '1435-Z', 'Programmation JAVA 2009', 'Zera Eryoruk', 'Ramus', 2, 36000, 3, '.jpg', 'DossierImages\\1435-Z', '2014-02-02 09:31:31', '2014-02-02 09:31:31', 1, 1),
(7, '1435-Z44', 'Programmation JAVA 2009', 'Zera Eryoruk', 'Ramus', 2, 36000, 5, '.jpg', 'DossierImages\\1435-Z44', '2014-02-20 01:44:58', '2014-02-20 01:44:58', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `prets`
--

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

INSERT INTO `prets` (`numPret`, `datePret`, `echeancePret`, `retour`, `dateRetour`, `matricule`, `codeLivre`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(0, '2014-02-02', '2014-02-02', '', '2014-02-02', 'Istdi00', 4, '2014-02-02 10:27:10', '2014-02-02 10:27:10', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `privilege`
--

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`Id`, `IdGroupe`, `Compte`, `Passe`, `Nom`, `DateDernierConnexion`, `Telephone`, `Statut`, `Email`, `Photo`, `PhotoExtension`, `DateCreation`, `DateModification`, `IdCreateur`, `IdModificateur`) VALUES
(1, 2, 'Admin', '*A36A3F5563C1D8B6FC6478B64988A0061201E506', 'Couakam Guy', NULL, '96279059', b'1', 'jgjgjhj', 'PhotoUser\\Admin', '.JPG', '2014-01-12 00:29:25', '2014-01-12 00:29:25', 1, 1),
(16, 1, 'GUYD', '*FD011983B590BD7BA69AC93A31A0E6AB0B190D99', 'GUYD', NULL, '12345678', b'1', 'GUYD', 'PhotoUser\\GUYD', '', '2014-01-12 17:34:20', '2014-01-12 17:34:20', 1, 1);

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
