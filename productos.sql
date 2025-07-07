-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-07-2025 a las 06:21:23
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `productos_pets`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `ProductoId` int(11) NOT NULL,
  `Nombre` varchar(40) NOT NULL,
  `Lote` varchar(50) NOT NULL,
  `FechaIngreso` datetime(6) NOT NULL,
  `FechaCaducidad` datetime(6) NOT NULL,
  `Proveedor` varchar(100) NOT NULL,
  `Stock` int(11) NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  `Create_At` datetime(6) NOT NULL,
  `Update_Up` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`ProductoId`, `Nombre`, `Lote`, `FechaIngreso`, `FechaCaducidad`, `Proveedor`, `Stock`, `PrecioUnitario`, `Create_At`, `Update_Up`) VALUES
(1, 'Collares', 'A-3445', '2025-07-01 23:01:32.917000', '2029-11-23 23:01:32.900000', 'AnimalPet', 250, 5.50, '2025-07-06 23:02:19.575012', '2025-07-06 23:08:02.104427'),
(2, 'Comida \"Raza\"', 'C-5679', '2025-07-07 23:08:03.102000', '2026-12-16 23:08:03.102000', 'AnimalVet', 225, 10.00, '2025-07-06 23:08:58.296938', '2025-07-06 23:08:58.297063'),
(4, 'Juguete para perros', 'J-1122', '2025-07-07 10:00:00.000000', '2030-07-07 10:00:00.000000', 'PetFun', 150, 8.75, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000'),
(5, 'Arena para gatos', 'A-2233', '2025-07-07 10:30:00.000000', '2026-07-07 10:30:00.000000', 'CatCare', 300, 12.00, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000'),
(6, 'Correa retráctil', 'C-3344', '2025-07-07 11:00:00.000000', '2029-07-07 11:00:00.000000', 'AnimalPet', 100, 15.50, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000'),
(7, 'Comida para peces', 'P-4455', '2025-07-07 11:30:00.000000', '2026-12-31 11:30:00.000000', 'FishWorld', 200, 6.25, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000'),
(8, 'Cama para gatos', 'G-5566', '2025-07-07 12:00:00.000000', '2030-07-07 12:00:00.000000', 'ComfortPets', 75, 20.00, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000'),
(9, 'Vitaminas para perros', 'V-6677', '2025-07-07 12:30:00.000000', '2027-07-07 12:30:00.000000', 'VetLife', 180, 9.99, '2025-07-06 23:12:27.000000', '2025-07-06 23:12:27.000000');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`ProductoId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `ProductoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
