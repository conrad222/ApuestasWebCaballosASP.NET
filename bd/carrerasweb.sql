-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.27-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para carrerasweb
CREATE DATABASE IF NOT EXISTS `carrerasweb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `carrerasweb`;

-- Volcando estructura para tabla carrerasweb.apuesta
CREATE TABLE IF NOT EXISTS `apuesta` (
  `id_apuesta` int(11) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`id_apuesta`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.apuesta: ~0 rows (aproximadamente)

-- Volcando estructura para tabla carrerasweb.caballo
CREATE TABLE IF NOT EXISTS `caballo` (
  `id_caballo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `pigmentacion` varchar(50) DEFAULT NULL,
  `sexo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_caballo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.caballo: ~3 rows (aproximadamente)
INSERT INTO `caballo` (`id_caballo`, `nombre`, `pigmentacion`, `sexo`) VALUES
	(1, 'Juan', 'blanco', 'macho'),
	(2, 'Pedro', 'amarillo', 'macho'),
	(3, 'Clarisa', 'marron', 'hembra');

-- Volcando estructura para tabla carrerasweb.hipodromo
CREATE TABLE IF NOT EXISTS `hipodromo` (
  `id_hipodromo` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_hipodromo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.hipodromo: ~0 rows (aproximadamente)

-- Volcando estructura para tabla carrerasweb.jockey
CREATE TABLE IF NOT EXISTS `jockey` (
  `id_jockey` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) DEFAULT NULL,
  `copas` int(11) DEFAULT NULL,
  `color_equipo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_jockey`),
  CONSTRAINT `FK_jockey_caballo` FOREIGN KEY (`id_jockey`) REFERENCES `caballo` (`id_caballo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.jockey: ~3 rows (aproximadamente)
INSERT INTO `jockey` (`id_jockey`, `numero`, `copas`, `color_equipo`) VALUES
	(1, 1, 3, 'rojo'),
	(2, 2, 4, 'azul'),
	(3, 3, 1, 'verde');

-- Volcando estructura para tabla carrerasweb.rol
CREATE TABLE IF NOT EXISTS `rol` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL DEFAULT current_timestamp(6),
  `UpdatedAt` datetime(6) DEFAULT current_timestamp(6),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.rol: ~2 rows (aproximadamente)
INSERT INTO `rol` (`Id`, `Name`, `CreatedAt`, `UpdatedAt`) VALUES
	(1, 'usuario', '2023-06-20 19:27:22.000000', '2023-06-20 19:27:23.000000'),
	(2, 'administrador', '2023-06-20 19:27:33.425086', '2023-06-20 19:27:33.425086');

-- Volcando estructura para tabla carrerasweb.trabajador
CREATE TABLE IF NOT EXISTS `trabajador` (
  `id_trabajador` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `caja_apuesta` double DEFAULT NULL,
  PRIMARY KEY (`id_trabajador`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.trabajador: ~1 rows (aproximadamente)
INSERT INTO `trabajador` (`id_trabajador`, `nombre`, `apellido`, `caja_apuesta`) VALUES
	(1, 'Lorca', 'Villazarcillo', 1000);

-- Volcando estructura para tabla carrerasweb.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext DEFAULT NULL,
  `Email` longtext DEFAULT NULL,
  `EmailVerifiedAt` datetime(6) DEFAULT NULL,
  `Password` longtext DEFAULT NULL,
  `Dinero` double DEFAULT NULL,
  `RoleId` int(11) NOT NULL,
  `RememberToken` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL DEFAULT current_timestamp(6),
  `UpdatedAt` datetime(6) DEFAULT current_timestamp(6),
  PRIMARY KEY (`Id`),
  KEY `FK_Users_rol_RoleId` (`RoleId`),
  CONSTRAINT `FK_Users_rol_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `rol` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.usuario: ~2 rows (aproximadamente)
INSERT INTO `usuario` (`Id`, `Name`, `Email`, `EmailVerifiedAt`, `Password`, `Dinero`, `RoleId`, `RememberToken`, `CreatedAt`, `UpdatedAt`) VALUES
	(1, 'Conrado', 'color@gmail.com', '2023-06-20 19:45:08.000000', 'color', 200, 1, NULL, '2023-06-20 19:45:24.000000', '2023-06-20 19:45:25.000000'),
	(2, 'Jorge', 'jorge@gmail.com', '2023-06-20 19:48:04.000000', 'jorge', 100, 2, NULL, '2023-06-20 19:48:24.000000', '2023-06-20 19:48:25.000000');

-- Volcando estructura para tabla carrerasweb.__efmigrationshistory
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.__efmigrationshistory: ~2 rows (aproximadamente)
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20230620165827_create_table_roles', '7.0.7'),
	('20230620173034_create_table_users', '7.0.7');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
