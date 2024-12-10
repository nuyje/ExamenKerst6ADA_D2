CREATE DATABASE  IF NOT EXISTS `ek2024` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ek2024`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: ek2024
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `groep`
--

DROP TABLE IF EXISTS `groep`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groep` (
  `idGroep` int NOT NULL AUTO_INCREMENT,
  `Naam` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idGroep`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groep`
--

LOCK TABLES `groep` WRITE;
/*!40000 ALTER TABLE `groep` DISABLE KEYS */;
INSERT INTO `groep` VALUES (1,'A'),(2,'B'),(3,'C'),(4,'D'),(5,'E'),(6,'F');
/*!40000 ALTER TABLE `groep` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wedstrijden`
--

DROP TABLE IF EXISTS `wedstrijden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wedstrijden` (
  `idWedstrijd` int NOT NULL AUTO_INCREMENT,
  `Datum` datetime DEFAULT NULL,
  `Ploeg1` varchar(45) DEFAULT NULL,
  `Ploeg2` varchar(45) DEFAULT NULL,
  `Uitslag` varchar(45) DEFAULT NULL,
  `Groep_idGroep` int NOT NULL,
  PRIMARY KEY (`idWedstrijd`),
  KEY `fk_Wedstrijden_Groep_idx` (`Groep_idGroep`),
  CONSTRAINT `fk_Wedstrijden_Groep` FOREIGN KEY (`Groep_idGroep`) REFERENCES `groep` (`idGroep`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wedstrijden`
--

LOCK TABLES `wedstrijden` WRITE;
/*!40000 ALTER TABLE `wedstrijden` DISABLE KEYS */;
INSERT INTO `wedstrijden` VALUES (1,'2024-06-14 21:00:00','Duitsland','Schotland',NULL,1),
(2,'2024-06-15 15:00:00','Hongarije','Zwitserland',NULL,1),
(3,'2024-06-15 18:00:00','Spanje','Kroatië',NULL,2),
(4,'2024-06-15 21:00:00','Italië','Albanië',NULL,2),
(5,'2024-06-16 15:00:00','Polen','Nederland',NULL,4),
(6,'2024-06-16 18:00:00','Slovenië','Denemarken',NULL,3),
(7,'2024-06-16 21:00:00','Servië','Engeland',NULL,3),
(8,'2024-06-17 15:00:00','Roemenië','Oekraïne',NULL,5),
(9,'2024-06-17 18:00:00','België','Slowakije',NULL,5),
(10,'2024-06-17 21:00:00','Oostenrijk','Frankrijk',NULL,4),
(11,'2024-06-18 18:00:00','Turkije','Georgië',NULL,6),
(12,'2024-06-18 21:00:00','Portugal','Tsjechië',NULL,6),
(13,'2024-06-19 15:00:00','Kroatië','Albanië',NULL,2),
(14,'2024-06-19 18:00:00','Duitsland','Hongarije',NULL,1),
(15,'2024-06-19 21:00:00','Schotland','Zwitserland',NULL,1),
(16,'2024-06-20 15:00:00','Slovenië','Servië',NULL,3),
(17,'2024-06-20 18:00:00','Denemarken','Engeland',NULL,3),
(18,'2024-06-20 21:00:00','Spanje','Italië',NULL,2),
(19,'2024-06-21 15:00:00','Slowakije','Oekraïne',NULL,5),
(20,'2024-06-21 18:00:00','Polen','Oostenrijk',NULL,4),
(21,'2024-06-21 21:00:00','Nederland','Frankrijk',NULL,4),
(22,'2024-06-22 15:00:00','Georgië','Tsjechië',NULL,6),
(23,'2024-06-22 18:00:00','Turkije','Portugal',NULL,6),
(24,'2024-06-22 21:00:00','België','Roemenië',NULL,5),
(25,'2024-06-23 21:00:00','Zwitserland','Duitsland',NULL,1),
(26,'2024-06-23 21:00:00','Schotland','Hongarije',NULL,1),
(27,'2024-06-24 21:00:00','Kroatië','Italië',NULL,2),
(28,'2024-06-24 21:00:00','Albanië','Spanje',NULL,2),
(29,'2024-06-25 18:00:00','Nederland','Oostenrijk',NULL,4),
(30,'2024-06-25 18:00:00','Frankrijk','Polen',NULL,4),
(31,'2024-06-25 21:00:00','Engeland','Slovenië',NULL,3),
(32,'2024-06-25 21:00:00','Denemarken','Servië',NULL,3),
(33,'2024-06-26 18:00:00','Slowakije','Roemenië',NULL,5),
(34,'2024-06-26 18:00:00','Oekraïne','België',NULL,5),
(35,'2024-06-26 21:00:00','Tsjechië','Turkije',NULL,6),
(36,'2024-06-26 21:00:00','Georgië','Portugal',NULL,6);
/*!40000 ALTER TABLE `wedstrijden` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-07 15:32:37
