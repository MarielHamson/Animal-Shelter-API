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
INSERT INTO `__EFMigrationsHistory` VALUES ('20200821162528_Initial','2.2.4-servicing-10062'),('20200821185429_AddPagination','2.2.4-servicing-10062'),('20200821212758_ReSeedDB','2.2.4-servicing-10062'),('20200821220744_CatsAndDogs','2.2.4-servicing-10062'),('20200821223409_AnimalSchema','2.2.4-servicing-10062');
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
INSERT INTO `Animals` VALUES (1,'High','Small dogs, children','Lizard','Iguana','1','super sweet','Yellow',4,'Perfect'),(2,'Medium','Small dogs','Octopus','Oceanic','4','super sweet but bitey','Black',4,'Perfect'),(3,'Low','Handler','Red Panda','Chinese','7','lays around','speckled',3,'Perfect'),(4,'Slothlike','big dogs, friends','Bird','Canary','1','super sweet','Beige with Black muzzle',4,'Perfect'),(5,'Bouncy','Children','Pig','Potbelly','6 months','wants cuddles forever','pink with black spots',4,'Perfect'),(6,'Chill','Small dogs, children','Elephant','African','3','rough and tumble','Yellow with spots',4,'Perfect'),(7,'Medium','Adults and random strangers','Snake','Rattle','1','bouncey and happy','Grey/Silver',4,'Perfect'),(8,'Med-Low','Small things','Monster','Loch Ness','5','loves to climb','pink and grey',3,'Perfect'),(9,'Highest','me','Fox','Red','7','can be nice when food is available','white with brown spots, or is it brown with white spots',4,'Perfect'),(10,'Normal','Everyone','Kangaroo','Roo','10','loyal and honest','Yellow',2,'Perfect');
/*!40000 ALTER TABLE `Animals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Cats`
--

DROP TABLE IF EXISTS `Cats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Cats` (
  `CatId` int(11) NOT NULL AUTO_INCREMENT,
  `EnergyLevel` longtext NOT NULL,
  `GetsAlongWith` longtext NOT NULL,
  `Breed` longtext NOT NULL,
  `Age` longtext NOT NULL,
  `Disposition` longtext NOT NULL,
  `Coloring` longtext NOT NULL,
  `NumOfFeet` float NOT NULL,
  `Size` longtext NOT NULL,
  PRIMARY KEY (`CatId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Cats`
--

LOCK TABLES `Cats` WRITE;
/*!40000 ALTER TABLE `Cats` DISABLE KEYS */;
INSERT INTO `Cats` VALUES (1,'High','Small dogs, children','British Shorthair','1','super sweet','Yellow',4,'Perfect'),(2,'Medium','Small dogs','Maine Coon','4','super sweet but bitey','Black',4,'Perfect'),(3,'Low','Handler','Rag doll','7','lays around','speckled',3,'Perfect'),(4,'Slothlike','big dogs, friends','Sphynx','1','super sweet','Beige with Black muzzle',4,'Perfect'),(5,'Bouncy','Children','Bengal','6 months','wants cuddles forever','pink with black spots',4,'Perfect'),(6,'Chill','Small dogs, children','Persian','3','rough and tumble','Yellow with spots',4,'Perfect'),(7,'Medium','Adults and random strangers','Siamese','1','bouncey and happy','Grey/Silver',4,'Perfect'),(8,'Med-Low','Small things','American Shorthair','5','loves to climb','pink and grey',3,'Perfect'),(9,'Highest','me','Abyssinian','7','can be nice when food is available','white with brown spots, or is it brown with white spots',4,'Perfect'),(10,'Normal','Everyone','Russian Blue','10','loyal and honest','Yellow',2,'Perfect');
/*!40000 ALTER TABLE `Cats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Dogs`
--

DROP TABLE IF EXISTS `Dogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Dogs` (
  `DogId` int(11) NOT NULL AUTO_INCREMENT,
  `EnergyLevel` longtext NOT NULL,
  `GetsAlongWith` longtext NOT NULL,
  `Breed` longtext NOT NULL,
  `Age` longtext NOT NULL,
  `Disposition` longtext NOT NULL,
  `Coloring` longtext NOT NULL,
  `NumOfFeet` float NOT NULL,
  `Size` longtext NOT NULL,
  PRIMARY KEY (`DogId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Dogs`
--

LOCK TABLES `Dogs` WRITE;
/*!40000 ALTER TABLE `Dogs` DISABLE KEYS */;
INSERT INTO `Dogs` VALUES (1,'High','Small dogs, children','Golden Retriever','1','super sweet','Yellow',4,'Perfect'),(2,'Medium','Small dogs','Labrador Retriever','4','super sweet but bitey','Black',4,'Perfect'),(3,'Low','Handler','French Bulldog','7','lays around','speckled',3,'Perfect'),(4,'Slothlike','big dogs, friends','Pug','1','super sweet','Beige with Black muzzle',4,'Perfect'),(5,'Bouncy','Children','Affenpinscher','6 months','wants cuddles forever','pink with black spots',4,'Perfect'),(6,'Chill','Small dogs, children','Poodle','3','rough and tumble','Yellow with spots',4,'Perfect'),(7,'Medium','Adults and random strangers','Weimeraner','1','bouncey and happy','Grey/Silver',4,'Perfect'),(8,'Med-Low','Small things','Chihuahua','5','loves to climb','pink and grey',3,'Perfect'),(9,'Highest','me','Rat Terrier','7','can be nice when food is available','white with brown spots, or is it brown with white spots',4,'Perfect'),(10,'Normal','Everyone','Great Dane','10','loyal and honest','Yellow',2,'Perfect');
/*!40000 ALTER TABLE `Dogs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-21 15:34:50
