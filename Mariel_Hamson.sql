-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: Mariel_Hamson
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20200821162528_Initial','2.2.4-servicing-10062'),('20200821185429_AddPagination','2.2.4-servicing-10062'),('20200821212758_ReSeedDB','2.2.4-servicing-10062');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Animals`
--

DROP TABLE IF EXISTS `Animals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Animals` (
  `AnimalId` int(11) NOT NULL AUTO_INCREMENT,
  `EnergyLevel` longtext NOT NULL,
  `GetsAlongWith` longtext NOT NULL,
  `Type` longtext NOT NULL,
  `Breed` longtext NOT NULL,
  `Age` longtext NOT NULL,
  `Disposition` longtext NOT NULL,
  `Coloring` longtext NOT NULL,
  `NumOfFeet` float NOT NULL,
  `Size` longtext NOT NULL,
  PRIMARY KEY (`AnimalId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Animals`
--

LOCK TABLES `Animals` WRITE;
/*!40000 ALTER TABLE `Animals` DISABLE KEYS */;
INSERT INTO `Animals` VALUES (1,'High','Small dogs, children','Dog','Golden Retriever','1','super sweet','Yellow',4,'Perfect'),(2,'Medium','Small dogs','Dog','Labrador Retriever','4','super sweet but bitey','Black',4,'Perfect'),(3,'Low','Handler','Lizard','Iguana','7','lays around','speckled',3,'Perfect'),(4,'Slothlike','big dogs, friends','Dog','Pug','1','super sweet','Beige with Black muzzle',4,'Perfect'),(5,'Bouncy','Children','Pig','Potbelly','6 months','wants cuddles forever','pink with black spots',4,'Perfect'),(6,'Chill','Small dogs, children','Cat','Leopard','3','rough and tumble','Yellow with spots',4,'Perfect'),(7,'Medium','Adults and random strangers','Dog','Weimeraner','1','bouncey and happy','Grey/Silver',4,'Perfect'),(8,'Med-Low','Small things','Rat','Just Rat','5','loves to climb','pink and grey',3,'Perfect'),(9,'Highest','me','Dog','Rat Terrier','7','can be nice when food is available','white with brown spots, or is it brown with white spots',4,'Perfect'),(10,'Normal','Everyone','Kangaroo','Roo','10','loyal and honest','Yellow',2,'Perfect');
/*!40000 ALTER TABLE `Animals` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-21 14:30:04
