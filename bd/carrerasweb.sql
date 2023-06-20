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
  `id_rol` int(11) DEFAULT NULL,
  `rol` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.rol: ~2 rows (aproximadamente)
INSERT INTO `rol` (`id_rol`, `rol`) VALUES
	(1, 'usuario'),
	(2, 'administrador');

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
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `contraseña` varchar(50) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `dinero` double DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla carrerasweb.usuario: ~1 rows (aproximadamente)
INSERT INTO `usuario` (`user_id`, `nombre`, `contraseña`, `correo`, `dinero`) VALUES
	(1, 'Padrique', 'padre', 'padrique@gmail.com', 200);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
