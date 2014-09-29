-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 29. Sep 2014 um 23:51
-- Server Version: 5.6.16
-- PHP-Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `aqfm`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_einkommen_9_2014`
--

CREATE TABLE IF NOT EXISTS `tbl_einkommen_9_2014` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `personNr` int(11) NOT NULL,
  `Betrag` decimal(10,2) NOT NULL,
  `waehrungsNr` int(11) NOT NULL,
  `Auszug` int(11) DEFAULT NULL,
  `transferArtNr` int(11) NOT NULL,
  `kontoNr` int(11) NOT NULL,
  `Datum` date NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tbl_einkommen_9_2014`
--

INSERT INTO `tbl_einkommen_9_2014` (`Id`, `personNr`, `Betrag`, `waehrungsNr`, `Auszug`, `transferArtNr`, `kontoNr`, `Datum`) VALUES
(1, 1, '90.00', 1, 65, 1, 1, '2014-09-28');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_konto`
--

CREATE TABLE IF NOT EXISTS `tbl_konto` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Konto` int(11) NOT NULL,
  `Bezeichnung` varchar(500) DEFAULT NULL,
  `Kategorie` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tbl_konto`
--

INSERT INTO `tbl_konto` (`Id`, `Konto`, `Bezeichnung`, `Kategorie`) VALUES
(1, 600, 'Familie Hagelgans', NULL);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_person`
--

CREATE TABLE IF NOT EXISTS `tbl_person` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Vorname` varchar(100) DEFAULT NULL,
  `Land` varchar(100) DEFAULT NULL,
  `PLZ` int(11) DEFAULT NULL,
  `Ort` varchar(100) DEFAULT NULL,
  `Strasse` varchar(100) DEFAULT NULL,
  `Hausnummer` int(11) DEFAULT NULL,
  `Telefon` int(11) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `BIC` varchar(100) DEFAULT NULL,
  `IBAN` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tbl_person`
--

INSERT INTO `tbl_person` (`Id`, `Name`, `Vorname`, `Land`, `PLZ`, `Ort`, `Strasse`, `Hausnummer`, `Telefon`, `Email`, `BIC`, `IBAN`) VALUES
(1, 'Hildebrandt', 'Helene', 'Deutschland', 33729, 'Bielefeld', 'Mecklenburgerstr', 47, 521392974, NULL, 'PBNKDEFF', 'DE36660100750401110751');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_transferart`
--

CREATE TABLE IF NOT EXISTS `tbl_transferart` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TransferArt` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tbl_transferart`
--

INSERT INTO `tbl_transferart` (`Id`, `TransferArt`) VALUES
(1, 'Dauerüberweisung');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_waerung`
--

CREATE TABLE IF NOT EXISTS `tbl_waerung` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Währung` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tbl_waerung`
--

INSERT INTO `tbl_waerung` (`Id`, `Währung`) VALUES
(1, 'Euro');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
