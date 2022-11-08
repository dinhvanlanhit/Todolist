-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.33 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for dinhvanlanh_todolist
CREATE DATABASE IF NOT EXISTS `dinhvanlanh_todolist` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `dinhvanlanh_todolist`;

-- Dumping structure for table dinhvanlanh_todolist.todos
CREATE TABLE IF NOT EXISTS `todos` (
  `ID` bigint(11) unsigned NOT NULL AUTO_INCREMENT,
  `USER_ID` bigint(11) DEFAULT NULL,
  `NAME` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IS_ACTIVE` bit(1) DEFAULT NULL,
  `DATE_CREATE` datetime DEFAULT NULL,
  `DATE_UPDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Dumping data for table dinhvanlanh_todolist.todos: ~3 rows (approximately)
DELETE FROM `todos`;
/*!40000 ALTER TABLE `todos` DISABLE KEYS */;
INSERT INTO `todos` (`ID`, `USER_ID`, `NAME`, `IS_ACTIVE`, `DATE_CREATE`, `DATE_UPDATE`) VALUES
	(1, 1, 'Học Dotnetcore 6', b'1', '2022-11-08 22:32:03', '2022-11-08 22:32:04'),
	(2, 1, 'Học react js', b'1', '2022-11-08 22:32:03', '2022-11-08 22:32:04'),
	(3, 1, 'Học MySQL', b'1', '2022-11-08 22:32:03', '2022-11-08 22:32:04');
/*!40000 ALTER TABLE `todos` ENABLE KEYS */;

-- Dumping structure for table dinhvanlanh_todolist.users
CREATE TABLE IF NOT EXISTS `users` (
  `ID` bigint(11) unsigned NOT NULL AUTO_INCREMENT,
  `FULLNAME` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EMAIL` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `USERNAME` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PASSWORD` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SEX` int(11) DEFAULT '1',
  `ADDRESS` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IS_ACTIVE` bit(1) DEFAULT NULL,
  `DATE_CREATE` datetime DEFAULT NULL,
  `DATE_UPDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Dumping data for table dinhvanlanh_todolist.users: ~1 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`ID`, `FULLNAME`, `EMAIL`, `USERNAME`, `PASSWORD`, `SEX`, `ADDRESS`, `IS_ACTIVE`, `DATE_CREATE`, `DATE_UPDATE`) VALUES
	(1, 'Đinh Văn Lành', '073@amnote.com.vn', '073', '123456', 1, 'Đà Lạt', b'1', '2022-11-08 22:31:11', '2022-11-08 22:31:12');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
