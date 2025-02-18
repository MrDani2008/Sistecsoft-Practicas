-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: giovannigoku
-- ------------------------------------------------------
-- Server version	5.7.30-log

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
-- Table structure for table `agenda_de_contactos`
--

DROP TABLE IF EXISTS `agenda_de_contactos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agenda_de_contactos` (
  `id_agenda_de_contactos` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `NUMERO` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_agenda_de_contactos`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenda_de_contactos`
--

LOCK TABLES `agenda_de_contactos` WRITE;
/*!40000 ALTER TABLE `agenda_de_contactos` DISABLE KEYS */;
INSERT INTO `agenda_de_contactos` VALUES (1,'Juan Carlos','890-289-8976'),(2,'Peter Benjamin','809-254-7766'),(3,'Pepe Juan','809-235-2444444'),(4,'Bruno Dias','809-854-5678'),(5,'Juaquin sabina','ldsfkjasdllkjkl'),(6,'Alan Belen','809-894-7894'),(7,'Alfredo','Pallero'),(8,'marlon','2'),(9,'Jorge Cosme','8095741211'),(10,'Derian Bin Laden','898-976-8989'),(11,'Manolo Cosme','809-789-5245'),(12,'jacobo magluta','8095455454'),(13,'Malcon Miller','546-546-5487'),(14,'Jason Vorhees','809-574-1313'),(15,'Jose Quezada','212-212-3212'),(16,'ClarkKent','809-000-1938'),(17,'Pepe','809-235-2545'),(18,'Alfredo Pallero','809-456-5787'),(19,'',''),(20,'manual penialo','80925'),(21,'Marlon Bonifacio','808080800'),(22,'dionicio','25'),(23,'Giovanni Goku','vdfvdfvdsv'),(24,'Biscen Mano','34325345435'),(25,'George','3123213213'),(26,'Queseyo','4542524545'),(27,'el carlos mano','vsfdfsdfd'),(28,'Marlon Esquea','805921564'),(29,'Jorge','12345'),(30,'pedro','234'),(31,'benito','123233'),(32,'Oye eso','3423452345'),(33,'Ya tu sabe','76876278'),(34,'oye eso','ya tu sabe'),(35,'Bueno manin','87989789879'),(36,'ya tu sabe','354353454'),(37,'Peter Benjamin','809-254-7766'),(38,'Lara mayope','123456879'),(39,'esencia','42345454354'),(40,'Pepe el pollero','789213980'),(41,'Manolo Peña','789321788'),(42,'Juan el carnicero','089321890'),(43,'Jaime pica pollo','8902318900'),(44,'juan manuel perez','123456'),(45,'karla mejia','123546'),(46,'Kevin Bolo','6364564656'),(47,'Tablos Esencial','66666666666666'),(48,'Juan Moto Concho','890-890-1234'),(49,'aaaa','33333'),(50,'Benito Martinez','809-890-0978');
/*!40000 ALTER TABLE `agenda_de_contactos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'giovannigoku'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-11 14:11:05
