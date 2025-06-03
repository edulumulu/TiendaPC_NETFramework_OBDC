SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tiendapc`
--

-- --------------------------------------------------------

--
-- Estructura de suport per a vistes `catalogo`
-- (mireu a sota per a la visualització real)
--
CREATE TABLE `catalogo` (
`id` int(10) unsigned
,`componente` varchar(255)
,`precio` decimal(10,2) unsigned
,`marca` varchar(50)
,`categoría` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura de la taula `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Bolcament de dades per a la taula `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`) VALUES
(1, 'Procesadores'),
(2, 'Fuentes de Alimentación'),
(3, 'Tarjetas gráficas'),
(4, 'Placas Base'),
(5, 'Memoria RAM'),
(6, 'Discos Duros'),
(7, 'Torres/Cajas'),
(8, 'Refrigeración');

-- --------------------------------------------------------

--
-- Estructura de la taula `componentes`
--

CREATE TABLE `componentes` (
  `id` int(10) UNSIGNED NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `precio` decimal(10,2) UNSIGNED NOT NULL,
  `marca` varchar(50) NOT NULL,
  `id_categoria` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Bolcament de dades per a la taula `componentes`
--

INSERT INTO `componentes` (`id`, `nombre`, `precio`, `marca`, `id_categoria`) VALUES
(1, 'AMD Ryzen 5 5600X 3.7GHz', '228.04', 'AMD', 1),
(2, 'Intel Core i5-11400F 2.6 GHz', '157.80', 'Intel', 1),
(3, 'AMD Ryzen 5 5600G 4.40GHz', '198.55', 'AMD', 1),
(4, 'Intel Core i5-12400F 4.4 GHz', '195.62', 'Intel', 1),
(5, 'AMD Ryzen 5 5500 3.6GHz Box', '174.95', 'AMD', 1),
(6, 'Intel Core i5-10400F 2.90 GHz', '131.13', 'Intel', 1),
(7, 'Intel Core i5-12600K 4.9 GHz', '319.39', 'Intel', 1),
(8, 'AMD Ryzen 7 5800X 3.8GHz', '449.90', 'AMD', 1),
(9, 'AMD Ryzen 5 5600 3.5GHz Box', '216.31', 'AMD', 1),
(10, 'Intel Core i7-12700K 5.0 GHz', '425.47', 'Intel', 1),
(11, 'AMD Ryzen 7 5700G 4.6GHz', '301.50', 'AMD', 1),
(12, 'Intel Celeron G5905 3.50GHz', '39.72', 'Intel', 1),
(13, 'Intel Core i5-10400 2.90 GHz', '166.99', 'Intel', 1),
(14, 'Intel Core i7-12700 4.9 GHz', '391.44', 'Intel', 1),
(15, 'AMD Ryzen 7 5700X 3.4GHz Box', '321.90', 'AMD', 1),
(16, 'Intel Core i7-11700K 3.6 GHz', '375.18', 'Intel', 1),
(17, 'Intel Core i9-12900K 5.2 GHz', '625.00', 'Intel', 1),
(18, 'AMD Ryzen 9 5900X 3.7 GHz', '444.09', 'AMD', 1),
(19, 'Intel Core i9-12900KS 5.5 GHz', '879.90', 'Intel', 1),
(20, 'Intel Pentium Gold G6405 4.1 GHz', '60.55', 'Intel', 1),
(21, 'Intel Core i3-10105 3.7 GHz', '115.98', 'Intel', 1),
(22, 'AMD Ryzen 5 4500 3.6GHz Box', '152.48', 'AMD', 1),
(23, 'Intel Core i7-12700F 4.9 GHz', '371.18', 'Intel', 1),
(24, 'Intel Core i5-11600K 3.9 GHz', '250.64', 'Intel', 1),
(25, 'Intel Core i3-12100 4.3 GHz', '147.95', 'Intel', 1),
(26, 'Intel Core i5-12600 4.8 GHz', '261.18', 'Intel', 1),
(27, 'Intel Core i3-10105F 3.7 GHz', '80.54', 'Intel', 1),
(28, 'Intel Core i5-11400 2.6 GHz', '181.71', 'Intel', 1),
(29, 'Intel Core i5-11600KF 3.9 GHz', '232.28', 'Intel', 1),
(30, 'Intel Core i3-12100F 4.3 GHz', '124.62', 'Intel', 1),
(31, 'Intel Core i5-12400 4.4 GHz', '214.36', 'Intel', 1),
(32, 'Intel Core i5-12600KF 4.9 GHz', '294.56', 'Intel', 1),
(33, 'Intel Core i9-11900K 3.5 Ghz', '463.94', 'Intel', 1),
(34, 'Intel Core i7-10700KF 3.80 GHz', '325.48', 'Intel', 1),
(35, 'AMD Ryzen 5 3600 3.6GHz BOX OEM', '169.90', 'AMD', 1),
(36, 'AMD Ryzen 9 5950X 3.4 GHz', '576.64', 'AMD', 1),
(37, 'AMD Ryzen 5 5600X 3.7GHz Wraith Stealth Bulk', '289.90', 'AMD', 1),
(38, 'AMD Ryzen 5 5600X 3.7GHz Tray sin Cooler', '279.35', 'AMD', 1),
(39, 'Intel Core i7-12700KF 5.0 GHz', '417.47', 'Intel', 1),
(40, 'Intel Core i7-10700F 2.9GHz', '270.22', 'Intel', 1),
(41, 'MSI MPG A850GF 850W 80 Plus Gold Modular', '122.48', 'MSI', 2),
(42, 'Tempest PSU 750W Fuente de Alimentación', '31.99', 'Tempest', 2),
(43, 'MSI MPG A750GF 750W 80 Plus Gold Modular', '116.56', 'MSI', 2),
(44, 'Owlotech BPS Fuente Alimentación 600W', '15.98', 'Owlotech', 2),
(45, 'MSI MPG A650GF 650W 80 Plus Gold Modular', '79.98', 'MSI', 2),
(46, 'Forgeon Bolt PSU 850W 80+ Gold Full Modular Fuente de Alimentación', '139.98', 'Forgeon', 2),
(47, 'Nfortec Sagitta RGB 650W 80 Plus Gold Full Modular', '99.95', 'Nfortec', 2),
(48, 'Corsair CX750M 750 W 80 Plus Bronze Semi-Modular', '71.39', 'Corsair', 2),
(49, 'Nox Urano VX 750W 80+ Bronze 140MM PWM', '59.70', 'NOX', 2),
(50, 'Corsair RM Series RM850 850W 80 Plus Gold Full Modular', '112.94', 'Corsair', 2),
(51, 'Tempest PSU 650W Fuente de Alimentación', '25.99', 'Tempest', 2),
(52, 'Tempest PSU X 650W 80+ Bronce Modular Fuente de Alimentación', '42.99', 'Tempest', 2),
(53, 'Tempest PSU X 750W 80+ Bronce Modular Fuente de Alimentación', '50.99', 'Tempest', 2),
(54, 'Thermaltake Smart RGB 700W 80 Plus', '59.99', 'Thermaltake', 2),
(55, 'Corsair RM Series RM750 750W 80 Plus Gold Full Modular', '99.20', 'Corsair', 2),
(56, 'Corsair HX1200 1200W 80 Plus Platinum Modular', '280.14', 'Corsair', 2),
(57, 'Seasonic B12 BC Series 850W 80 Plus Bronze', '79.45', 'Seasonic', 2),
(58, 'EVGA BQ 850W 80 Plus Bronze Modular', '103.26', 'EVGA', 2),
(59, 'EVGA SuperNOVA 650 G6 650W 80 Plus Gold Full Modular', '123.34', 'EVGA', 2),
(60, 'EVGA SuperNOVA 750 G6 750W 80 Plus Gold Full Modular', '136.62', 'EVGA', 2),
(61, 'Cooler Master MWE White V2 700W', '48.67', 'Cooler Master', 2),
(62, 'Thermaltake Smart BX1 750W 80 Plus Bronze', '70.98', 'Thermaltake', 2),
(63, 'EVGA GQ 750W 80 Plus Gold Modular', '90.40', 'EVGA', 2),
(64, 'EVGA GQ 850W 80 Plus Gold Modular', '130.14', 'EVGA', 2),
(65, 'Corsair RMx Series RM1000x 1000W 80 Plus Gold Modular', '164.91', 'Corsair', 2),
(66, 'Thermaltake Toughpower GF2 ARGB 750W Premium Edition 80 Plus Gold Modular', '134.90', 'Thermaltake', 2),
(67, 'Nox Urano VX 650W 80+ Bronze 120MM PWM', '48.82', 'NOX', 2),
(68, 'Thermaltake Smart RGB 600W  80 Plus', '52.99', 'Thermaltake', 2),
(69, 'EVGA BQ 650W 80 Plus Bronze Semi Modular', '75.69', 'EVGA', 2),
(70, 'EVGA Supernova 750 GT 750W 80 Plus Gold Modular', '113.15', 'EVGA', 2),
(71, 'Tempest PSU PRO 750W 80+ Bronce Fuente de Alimentación', '42.99', 'Tempest', 2),
(72, 'EVGA GQ 1000W 80 Plus Gold Semi Modular', '174.19', 'EVGA', 2),
(73, 'MSI MAG A650BN 650W 80 Plus Bronze', '59.00', 'MSI', 2),
(74, 'Thermaltake TR2 S 700W 80 Plus', '55.68', 'Thermaltake', 2),
(75, 'Forgeon Bolt PSU 650W 80+ Gold Full Modular Fuente de Alimentación', '120.00', 'Forgeon', 2),
(76, 'Tempest PSU PRO 850W 80+ Bronce Fuente de Alimentación', '50.99', 'Tempest', 2),
(77, 'Tempest PSU X 850W 80+ Bronce Modular Fuente de Alimentación', '54.99', 'Tempest', 2),
(78, 'Seasonic G12 GC Series 750W 80 Plus Gold', '79.64', 'Seasonic', 2),
(79, 'Corsair RM White Series RM750 750W 80 Plus Gold Full Modular', '101.62', 'Corsair', 2),
(80, 'Forgeon Bolt PSU 750W 80+ Gold Full Modular Fuente de Alimentación', '129.99', 'Forgeon', 2),
(81, 'Thermaltake Toughpower GF1 650W 80 Plus Gold Full Modular', '104.89', 'Thermaltake', 2),
(82, 'EVGA BQ 750W 80 Plus Bronze Semi Modular', '88.21', 'EVGA', 2),
(83, 'Cooler Master V750 V2 750W 80 Plus Gold Modular', '103.56', 'Cooler Master', 2),
(84, 'Asus Dual GeForce RTX 3050 OC Edition 8GB GDDR6', '374.89', 'Asus', 3),
(85, 'Gigabyte GeForce RTX 3060 GAMING OC 12GB GDDR6 Rev 2.0', '539.90', 'Gigabyte', 3),
(86, 'Asus GeForce RTX 2060 Dual OC EVO Edition 6GB GDDR6', '450.69', 'Asus', 3),
(87, 'Zotac Gaming GeForce RTX 3060 Twin Edge OC LHR 12GB GDDR6', '499.90', 'Zotac', 3),
(88, 'Asus Dual GeForce RTX 3060 OC Edition V2 12GB GDDR6', '489.00', 'Asus', 3),
(89, 'MSI GeForce RTX 3060 GAMING X 12GB GDDR6', '539.90', 'MSI', 3),
(90, 'Asus TUF Gaming GeForce RTX 3070 Ti OC Edition 8GB GDDR6X', '899.90', 'Asus', 3),
(91, 'Gigabyte GeForce GTX 1660 SUPER OC 6GB GDDR6', '403.99', 'Gigabyte', 3),
(92, 'MSI GeForce RTX 3070 Ti VENTUS 3X 8GB GDDR6X', '1076.17', 'MSI', 3),
(93, 'MSI GeForce GTX 1650 D6 VENTUS XS OC 4GB GDDR6', '219.95', 'MSI', 3),
(94, 'Gigabyte GeForce RTX 3080 GAMING OC V2 LHR 10GB GDDR6X', '1055.02', 'Gigabyte', 3),
(95, 'Sapphire PULSE AMD Radeon RX 6600 8GB GDDR6', '499.90', 'Sapphire', 3),
(96, 'Gigabyte GeForce RTX 3070 Ti GAMING OC 8GB GDDR6X', '889.89', 'Gigabyte', 3),
(97, 'Gigabyte GeForce RTX 3060 EAGLE OC 12GB LHR GDDR6 Rev 2.0', '519.90', 'Gigabyte', 3),
(98, 'Gigabyte GeForce RTX 3070 GAMING OC LHR V2 8GB GDDR6', '799.89', 'Gigabyte', 3),
(99, 'MSI GeForce RTX 3060 VENTUS 2X OC LHR 12GB GDDR6', '507.76', 'MSI', 3),
(100, 'Asus TUF Gaming GeForce RTX 3070 Ti OC Edition 8GB GDDR6X', '899.90', 'Asus', 3),
(101, 'MSI GeForce RTX 3070 VENTUS 2X OC LHR 8GB GDDR6', '799.89', 'MSI', 3),
(102, 'Gigabyte GeForce RTX 3050 GAMING OC 8GB GDDR6', '429.90', 'Gigabyte', 3),
(103, 'Gigabyte Radeon RX 6600 XT GAMING OC 8GB GDDR6', '619.90', 'Gigabyte', 3),
(104, 'XFX Speedster SWFT 210 AMD Radeon RX 6600 XT 8GB GDDR6', '497.01', 'XFX', 3),
(105, 'MSI GeForce GTX 1660 SUPER Ventus XS OC 6GB GDDR6', '329.94', 'MSI', 3),
(106, 'Gigabyte GeForce RTX 3080 Ti GAMING OC 12GB GDDR6X', '1546.72', 'Gigabyte', 3),
(107, 'Asus Dual GeForce RTX 3050 OC Edition 8GB GDDR6', '374.89', 'Asus', 3),
(108, 'Zotac Gaming GeForce RTX 3060 Twin Edge LHR 12GB GDDR6', '479.90', 'Zotac', 3),
(109, 'Zotac Gaming GeForce RTX 3070 Ti Trinity OC LHR 8GB GDDR6X', '819.90', 'Zotac', 3),
(110, 'PNY GeForce RTX 3080 XLR8 Gaming REVEL EPIC-X RGB Triple Fan LHR 10GB GDDR6X', '952.78', 'PNY', 3),
(111, 'XFX SPEEDSTER SWFT 210 AMD RADEON RX 6600 8GB GDDR6', '399.59', 'XFX', 3),
(112, 'MSI GeForce RTX 3080 VENTUS 3X PLUS OC LHR 10GB GDDR6', '1064.68', 'MSI', 3),
(113, 'Gigabyte GeForce RTX 3060 Ti Gaming OC LHR 8GB GDDR6', '649.95', 'Gigabyte', 3),
(114, 'EVGA GeForce RTX 3060 XC GAMING 12GB GDDR6', '563.69', 'EVGA', 3),
(115, 'Zotac Gaming Geforce RTX 3080 TRINITY OC LHR 10GB GDDR6X', '1049.90', 'Zotac', 3),
(116, 'Asus GeForce RTX 2060 Dual OC EVO Edition 6GB GDDR6', '450.69', 'Asus', 3),
(117, 'MSI GeForce RTX 3050 VENTUS 2X OC 8GB GDDR6', '399.91', 'MSI', 3),
(118, 'MSI GeForce GT 730 Low Profile 2GB GDDR3', '78.98', 'MSI', 3),
(119, 'MSI GeForce RTX 3060 VENTUS 2X 12GB GDDR6', '448.66', 'MSI', 3),
(120, 'Gigabyte Radeon RX 6600 XT EAGLE 8GB GDDR6', '599.91', 'Gigabyte', 3),
(121, 'MSI RTX 3060 TI VENTUS 2X OC V1 LHR 8GB GDDR6', '599.91', 'MSI', 3),
(122, 'MSI GeForce RTX 3070 Ti VENTUS 3X OC 8GB GDDR6X', '879.00', 'MSI', 3),
(123, 'MSI GeForce RTX 3060 Ti VENTUS 3X OC LHR 8GB GDDR6', '614.29', 'MSI', 3),
(124, 'Gigabyte GeForce RTX 3070 EAGLE OC 8GB GDDR6 Rev 2.0', '713.34', 'Gigabyte', 3),
(125, 'MSI AMD Radeon RX 6500 XT MECH 2X OC 4GB GDDR6', '229.30', 'MSI', 3),
(126, 'Sapphire NITRO+ AMD RADEON RX 6600 XT GAMING OC 8GB GDDR6', '563.45', 'Sapphire', 3),
(127, 'Gigabyte GeForce GTX 1660 Ti OC 6GB', '399.91', 'Gigabyte', 3),
(128, 'MSI GeForce RTX 3070 Ti VENTUS 3X 8GB GDDR6X', '1057.61', 'MSI', 3),
(129, 'Gigabyte B560M DS3H V2', '82.43', 'Gigabyte', 4),
(130, 'MSI MPG B550 GAMING PLUS', '157.95', 'MSI', 4),
(131, 'Gigabyte B550 AORUS ELITE V2', '132.19', 'Gigabyte', 4),
(132, 'MSI MAG Z590 TOMAHAWK WIFI', '261.03', 'MSI', 4),
(133, 'Gigabyte H510M S2H V2', '74.95', 'Gigabyte', 4),
(134, 'MSI H510M-A Pro', '67.49', 'MSI', 4),
(135, 'Asus TUF GAMING B450-PLUS II', '93.98', 'Asus', 4),
(136, 'Gigabyte B660 GAMING X DDR4', '167.96', 'Gigabyte', 4),
(137, 'MSI PRO Z690-A DDR4', '226.40', 'MSI', 4),
(138, 'Asus TUF GAMING B660-PLUS WIFI D4', '185.52', 'Asus', 4),
(139, 'Gigabyte B660M DS3H DDR4', '119.87', 'Gigabyte', 4),
(140, 'MSI MAG B550M MORTAR', '150.83', 'MSI', 4),
(141, 'Gigabyte Z590 GAMING X', '189.90', 'Gigabyte', 4),
(142, 'Gigabyte B550M DS3H', '85.95', 'Gigabyte', 4),
(143, 'MSI MAG B550 TORPEDO', '139.88', 'MSI', 4),
(144, 'Gigabyte B560M H', '83.99', 'Gigabyte', 4),
(145, 'Asus TUF GAMING B560-PLUS WIFI', '157.42', 'Asus', 4),
(146, 'Gigabyte Z590 AORUS PRO AX', '237.10', 'Gigabyte', 4),
(147, 'Gigabyte Z690 UD DDR4', '212.56', 'Gigabyte', 4),
(148, 'Gigabyte H610M S2H DDR4', '94.90', 'Gigabyte', 4),
(149, 'Gigabyte X570S AORUS ELITE AX', '259.90', 'Gigabyte', 4),
(150, 'Asus TUF GAMING B550-PLUS WIFI II', '178.66', 'Asus', 4),
(151, 'Gigabyte B450M DS3H', '64.57', 'Gigabyte', 4),
(152, 'MSI B550M-A PRO', '66.26', 'MSI', 4),
(153, 'Asus PRIME B660M-A D4', '134.90', 'Asus', 4),
(154, 'MSI MAG B560M MORTAR', '155.55', 'MSI', 4),
(155, 'Asus PRIME B660-PLUS D4', '159.90', 'Asus', 4),
(156, 'MSI Z490-A PRO', '124.73', 'MSI', 4),
(157, 'Gigabyte Z590 AORUS ELITE AX', '219.91', 'Gigabyte', 4),
(158, 'Gigabyte H410M S2H V3', '63.38', 'Gigabyte', 4),
(159, 'Asus PRIME Z690-P D4', '231.69', 'Asus', 4),
(160, 'MSI B450-A Pro Max', '80.53', 'MSI', 4),
(161, 'Asus ROG STRIX X570-E GAMING WIFI II', '348.44', 'Asus', 4),
(162, 'Asus TUF GAMING B550M-PLUS WIFI II', '146.01', 'Asus', 4),
(163, 'Asus TUF GAMING B550-PLUS', '155.53', 'Asus', 4),
(164, 'MSI MAG X570S TOMAHAWK MAX WIFI', '279.16', 'MSI', 4),
(165, 'MSI PRO Z690-A', '229.72', 'MSI', 4),
(166, 'Gigabyte Z690 AORUS ELITE DDR4', '271.60', 'Gigabyte', 4),
(167, 'Gigabyte X570S UD', '161.34', 'Gigabyte', 4),
(168, 'Asus TUF GAMING X570-PRO (WI-FI)', '245.55', 'Asus', 4),
(169, 'Kingston FURY Beast DDR4 2666MHz 8GB 2x4GB CL16', '57.57', 'Kingston', 5),
(170, 'Kingston FURY Beast DDR4 2666 MHz 8GB CL16', '36.81', 'Kingston', 5),
(171, 'Kingston FURY Beast DDR4 3200 MHz 8GB CL16', '38.95', 'Kingston', 5),
(172, 'Corsair Vengeance LPX DDR4 3200 PC4-25600 16GB 2X8GB CL16 Negro', '74.86', 'Corsair', 5),
(173, 'PNY XLR8 RGB DDR4 3200 PC4-25600 16GB 2x8GB CL16', '89.99', 'PNY', 5),
(174, 'Team Group T-Force Delta RGB DDR4 3600MHz PC4-28800 16GB 2x8GB CL18 Negro', '93.41', 'Team Group', 5),
(175, 'Kingston FURY Beast DDR4 3200 MHz 16GB 2x8GB CL16', '89.18', 'Kingston', 5),
(176, 'Kingston FURY Beast DDR4 3200 MHz 8GB CL16', '38.95', 'Kingston', 5),
(177, 'Team Group Delta White RGB DDR4 3200 PC4-25600 16GB 2x8GB CL16', '100.22', 'Team Group', 5),
(178, 'Goodram IRDM Pro DDR4 3600MHz 8GB CL18', '50.18', 'GoodRam', 5),
(179, 'Crucial DDR4 2400 PC4-19200 8GB CL17', '36.94', 'Crucial', 5),
(180, 'Kingston FURY Beast DDR4 3200 MHz 16GB CL16', '73.56', 'Kingston', 5),
(181, 'Team Group Delta RGB DDR4 3200 PC4-25600 16GB 2x8GB CL16', '77.23', 'Team Group', 5),
(182, 'Kingston FURY Beast DDR4 2666MHz 16GB 2x8GB CL16', '83.34', 'Kingston', 5),
(183, 'G.Skill Trident Z RGB DDR4 3200 PC4-25600 16GB 2x8GB CL16', '111.24', 'G.Skill', 5),
(184, 'Corsair Vengeance LPX DDR4 3200MHz PC4-25600 32GB 2x16GB CL16', '142.61', 'Corsair', 5),
(185, 'Thermaltake Toughram Z-One RGB DDR4 3600 16GB 2x8GB CL18', '135.27', 'Thermaltake', 5),
(186, 'Corsair Vengeance RGB Pro Optimizado AMD DDR4 3200 16GB 2x8GB CL16', '117.52', 'Corsair', 5),
(187, 'Team Group Elite DDR4 2666MHz 16GB CL19', '78.13', 'Team Group', 5),
(188, 'Team Group T-Force Zeus DDR4 3200MHz PC4-25600 32GB CL20', '150.16', 'Team Group', 5),
(189, 'Corsair Vengeance LPX DDR4 3200 PC4-25600 16GB 2x8GB CL16', '78.95', 'Corsair', 5),
(190, 'Kingston HyperX DDR4 4000MHz 16GB 2x8GB CL19', '164.91', 'Kingston', 5),
(191, 'Corsair Vengeance LPX DDR4 3200MHz PC4-25600 8GB CL16 Negro', '40.33', 'Corsair', 5),
(192, 'Crucial CT16G4DFRA266 DDR4 2666Mhz PC4-21300 16GB CL19', '67.76', 'Crucial', 5),
(193, 'GoodRam SO-DIMM DDR4 2666 MHz 8GB CL19', '38.64', 'GoodRam', 5),
(194, 'Crucial CT8G4DFRA266 DDR4 2666MHz PC4-21300 8GB CL19', '35.59', 'Crucial', 5),
(195, 'Corsair Vengeance RGB Pro DDR4 3200 PC4-25600 32GB 2x16GB CL16', '155.51', 'Corsair', 5),
(196, 'Kingston FURY Beast RGB DDR4 3200 MHz 8 GB CL16', '47.46', 'Kingston', 5),
(197, 'Team Group Elite DDR4 2400MHz 8GB CL16', '37.30', 'Team Group', 5),
(198, 'PNY Performance DDR4 2666MHz PC4-21300 8GB CL19', '35.95', 'PNY', 5),
(199, 'Thermaltake Toughram XG RGB DDR4 3600 2x8GB 16GB CL18 Negro', '161.62', 'Thermaltake', 5),
(200, 'Team Group Delta RGB DDR4 3200 PC4-25600 32GB 2x16GB CL16 Blanco', '172.79', 'Team Group', 5),
(201, 'Corsair VENGEANCE DDR5 4800MHz PC5-38400 32GB 2x16GB CL40', '299.70', 'Corsair', 5),
(202, 'Team Group T-Force Night Hawk RGB Gen2 DDR4 3000 16GB 2x8GB CL16', '95.88', 'Team Group', 5),
(203, 'Goodram IRDM Pro DDR4 3600MHz 32GB 2x16GB CL18', '166.08', 'GoodRam', 5),
(204, 'PNY XLR8 Gaming REV RGB DDR4 3200MHz 16GB 2x8GB CL16', '98.26', 'PNY', 5),
(205, 'Corsair Vengeance LPX DDR4 3200MHz PC4-25600 16GB CL16 Negro', '72.36', 'Corsair', 5),
(206, 'Thermaltake Toughram Z-One RGB DDR4 3200 2x8GB 16GB CL16', '97.63', 'Thermaltake', 5),
(207, 'Kingston FURY Beast DDR4 2666 MHz 16 GB CL16', '81.72', 'Kingston', 5),
(208, 'Team Group T-Create Expert DDR4 3200MHz PC4-25600 16GB 2x8GB CL16', '77.27', 'Team Group', 5),
(209, 'Corsair Vengeance RGB Pro SL DDR4 3600 PC4-28800 32GB 2x16GB CL18 Optimizado AMD Ryzen', '165.31', 'Corsair', 5),
(210, 'Kingston FURY Beast DDR4 3600 MHz 32GB 2x16GB CL18', '153.29', 'Kingston', 5),
(211, 'Crucial P5 Plus 1TB SSD M.2 2280 PCIe 4.0', '129.94', 'Crucial', 6),
(212, 'Nfortec Alcyon 256GB SSD M.2 NVMe', '52.05', 'Nfortec', 6),
(213, 'Crucial P2 500GB SSD M.2 2280 PCIe Gen3 x4 NVMe', '59.33', 'Crucial', 6),
(214, 'Kioxia EXCERIA 500GB SSD NVMe M.2 2280', '52.01', 'Kioxia', 6),
(215, 'Crucial P5 Plus 500GB SSD M.2 2280 PCIe 4.0', '84.16', 'Crucial', 6),
(216, 'Kioxia EXCERIA 480GB SSD SATA', '48.27', 'Kioxia', 6),
(217, 'MSI Spatium M390 500GB SSD NVMe M.2', '76.72', 'MSI', 6),
(218, 'Kingston NV1 Disco SSD 500GB PCIe NVMe', '57.21', 'Kingston', 6),
(219, 'MSI Spatium M390 SSD 1TB M.2 NVMe PCIe Gen3x4', '134.06', 'MSI', 6),
(220, 'Kingston A400 SSD 240GB', '30.60', 'Kingston', 6),
(221, 'Kioxia EXCERIA PLUS 500GB SSD NVMe M.2 2280', '72.71', 'Kioxia', 6),
(222, 'Samsung 980 SSD 1TB PCIe 3.0 NVMe M.2', '127.23', 'Samsung', 6),
(223, 'Kioxia Exceria G2 Unidad SSD 1TB NVMe M.2 2280', '85.61', 'Kioxia', 6),
(224, 'Samsung 980 PRO 1TB SSD PCIe 4.0 NVMe M.2 con Disipador de Calor', '192.14', 'Samsung', 6),
(225, 'Kingston A400 SSD 480GB', '49.14', 'Kingston', 6),
(226, 'Samsung 980 SSD 500GB PCIe 3.0 NVMe M.2', '71.83', 'Samsung', 6),
(227, 'Kingston A400 SSD 120GB', '23.38', 'Kingston', 6),
(228, 'Crucial MX500 SSD 500GB SATA', '62.90', 'Crucial', 6),
(229, '\"Samsung 870 EVO SSD 2.5\"\" 500GB SATA3 Negro\"', '79.93', 'Samsung', 6),
(230, 'WD Blue SN570 SSD 1TB M.2 NVMe', '111.93', 'Western Digital', 6),
(231, 'Crucial P5 Plus 500GB SSD M.2 2280 PCIe 4.0', '84.16', 'Crucial', 6),
(232, 'Kingston NV1 Disco SSD 1TB PCIe NVMe', '96.67', 'Kingston', 6),
(233, 'Samsung 980 PRO 2TB SSD PCIe 4.0 NVMe M.2 con Disipador de Calor', '373.06', 'Samsung', 6),
(234, 'Samsung 980 Pro SSD 2TB PCIe 4.0 NVMe M.2', '311.67', 'Samsung', 6),
(235, 'Samsung 980 Pro SSD 1TB PCIe NVMe M.2', '184.30', 'Samsung', 6),
(236, '\"GoodRam CL100 Gen.3 SSD 960GB 2.5\"\" SATA III\"', '100.91', 'GoodRam', 6),
(237, 'MSI Spatium M390 500GB SSD NVMe M.2', '76.73', 'MSI', 6),
(238, 'Kioxia EXCERIA PLUS 1TB SSD NVMe M.2 2280', '127.55', 'Kioxia', 6),
(239, 'Kingston KC3000 SSD 512GB M.2 PCIe 4.0 NVMe', '107.88', 'Kingston', 6),
(240, 'GoodRam PX500 SSD 512GB M.2 PCIe GEN 3 X4 NVMe', '67.29', 'GoodRam', 6),
(241, 'Samsung 970 EVO Plus 1TB SSD NVMe M.2', '137.07', 'Samsung', 6),
(242, 'WD Black SN850 1TB SSD NVMe M.2 PCIe 4.0 con Disipador Térmico', '199.49', 'Western Digital', 6),
(243, 'Crucial BX500 SSD 480GB 3D NAND SATA3', '55.84', 'Crucial', 6),
(244, 'WD Green SN350 SSD 1TB M.2 NVMe', '105.26', 'Western Digital', 6),
(245, 'Team Group Cardea Zero Z340 1TB PCIe M.2 Gaming SSD', '165.92', 'Team Group', 6),
(246, '\"Samsung 870 EVO SSD 2.5\"\" 1TB SATA3 Negro\"', '130.30', 'Samsung', 6),
(247, '\"GoodRam CL100 Gen.3 SSD 480GB 2.5\"\" SATA III\"', '59.22', 'GoodRam', 6),
(248, 'Samsung 870 QVO SSD 1TB SATA3', '109.06', 'Samsung', 6),
(249, 'Crucial MX500 SSD 1000GB SATA', '99.92', 'Crucial', 6),
(250, 'Kioxia Exceria G2 Unidad SSD 2TB NVMe M.2 2280', '213.08', 'Kioxia', 6),
(251, 'Crucial P2 500GB SSD M.2 2280 PCIe Gen3 x4 NVMe', '59.33', 'Crucial', 6),
(252, 'Nfortec Alcyon X 512GB SSD M.2 NVMe', '102.29', 'Nfortec', 6),
(253, '\"Nfortec Alcyon 256GB SSD 2.5\"\" SATA 3\"', '42.46', 'Nfortec', 6),
(254, 'Nfortec Alcyon X 256GB SSD M.2 NVMe', '71.23', 'Nfortec', 6),
(255, 'WD Black SN850 500GB SSD NVMe M.2 PCIe 4.0 sin Disipador Térmico', '90.79', 'Western Digital', 6),
(256, 'Tempest Start Torre ATX Negra + Fuente de Alimentación 500W', '39.99', 'Tempest', 7),
(257, 'Owlotech Start Case USB 3.0 500W Torre ATX', '30.00', 'Owlotech', 7),
(258, 'Forgeon Arcanite ARGB Mesh Torre ATX Negra', '149.99', 'Forgeon', 7),
(259, 'Nfortec Lynx Cristal Templado USB 3.0 RGB Negra', '49.95', 'Nfortec', 7),
(260, 'Tempest Spectra RGB Torre ATX Negra', '36.99', 'Tempest', 7),
(261, 'Tempest Spectra RGB Torre ATX Blanca', '37.99', 'Tempest', 7),
(262, 'Tempest Work Torre ATX Negra + Fuente de Alimentación 500W', '52.99', 'Tempest', 7),
(263, 'Tempest Spook RGB Torre ATX Negra', '34.99', 'Tempest', 7),
(264, 'Tempest Spook RGB Torre ATX Blanca', '37.99', 'Tempest', 7),
(265, 'Tempest Mirage RGB Mesh Torre ATX Negra', '65.99', 'Tempest', 7),
(266, 'Tempest Shade RGB Torre ATX Blanca', '50.99', 'Tempest', 7),
(267, 'Corsair iCUE 220T RGB Airflow Cristal Templado USB 3.0 Negra', '110.09', 'Corsair', 7),
(268, 'MSI MAG Forge 100M Cristal Templado USB 3.2 RGB', '62.40', 'MSI', 7),
(269, 'Tempest Phantom RGB Torre ATX Negra', '31.99', 'Tempest', 7),
(270, 'Tempest Vision RGB Torre ATX Negra', '45.99', 'Tempest', 7),
(271, 'Forgeon Arcanite ARGB Mesh Torre ATX Blanca', '149.99', 'Forgeon', 7),
(272, 'Corsair Carbide Spec-Delta RGB Cristal Templado USB 3.0', '78.59', 'Corsair', 7),
(273, 'Bitfenix Pack Nova Mesh TG 4ARGB Cristal Templado USB 3.1 Negra + Fórmula Gold 750W 80+ Gold', '168.99', 'BitFenix', 7),
(274, 'Corsair iCUE 220T RGB Airflow Cristal Templado USB 3.0 Blanca', '102.84', 'Corsair', 7),
(275, 'Tempest Revenant RGB Torre ATX Negra', '59.99', 'Tempest', 7),
(276, 'Bitfenix Pack Nova Mesh TG 4ARGB Cristal Templado Blanca +  Fórmula Gold 650W 80+ Gold', '168.32', 'BitFenix', 7),
(277, 'Forgeon Mithril ARGB Mesh Torre ATX Blanca', '149.99', 'Forgeon', 7),
(278, 'Cooler Master MasterBox Q300L USB 3.0 con Ventana Negra + Elite 500 V4 500W 80 Plus', '87.02', 'Cooler Master', 7),
(279, 'Corsair iCUE 4000X RGB Cristal Templado USB 3.1 RGB Negro', '124.85', 'Corsair', 7),
(280, 'Tempest Shade RGB Torre ATX Negra', '50.99', 'Tempest', 7),
(281, 'Tempest Vapor RGB Torre ATX Negra', '50.99', 'Tempest', 7),
(282, 'Tempest Vapor RGB Torre ATX Blanca', '53.99', 'Tempest', 7),
(283, 'Nfortec Krater Cristal Templado USB 3.0 ARGB Blanco', '78.98', 'Nfortec', 7),
(284, 'Nox LITE010 USB 3.0 + Fuente de Alimentación 500W', '44.90', 'NOX', 7),
(285, 'NOX Hummer Zero Core Black Edition + Fuente de Alimentación 450W', '88.40', 'NOX', 7),
(286, 'Forgeon Mithril ARGB Mesh Torre ATX Negra', '149.99', 'Forgeon', 7),
(287, 'Phanteks Eclipse P400A Cristal Templado USB 3.0 RGB Blanca', '96.73', 'Phanteks', 7),
(288, 'Phanteks Eclipse P400A Cristal Templado USB 3.0 RGB Negra', '104.87', 'Phanteks', 7),
(289, 'Phanteks Eclipse P500A ARGB Cristal Templado USB 3.0 Negra', '154.99', 'Phanteks', 7),
(290, 'MSI MAG Vampiric 010 Cristal Templado USB 3.0 ARGB Negro', '60.94', 'MSI', 7),
(291, 'Cooler Master MasterBox MB520 RGB Cristal Templado USB 3.0', '98.29', 'Cooler Master', 7),
(292, 'MSI MPG Gungnir 110M Cristal Templado USB 3.2 RGB Negro', '97.01', 'MSI', 7),
(293, 'Bitfenix Pack Nova Mesh TG 4ARGB Cristal Templado Negra +  Fórmula Gold 650W 80+ Gold', '168.32', 'BitFenix', 7),
(294, 'Nox Infinity SIGMA ARGB Cristal Templado USB 3.0', '59.69', 'NOX', 7),
(295, 'Tempest Soul RGB Torre ATX Negra', '37.99', 'Tempest', 7),
(296, 'Tempest PRO Cooler 4Pipes White RGB Ventilador CPU 120mm Negro', '30.00', 'Tempest', 8),
(297, 'Forgeon Solarian Cooler 4Pipes White ARGB Ventilador CPU 120mm', '50.99', 'Forgeon', 8),
(298, 'Nfortec Sculptor Black Disipador de Alto Rendimiento Negro', '49.95', 'Nfortec', 8),
(299, 'Tempest Zeroº Pasta Térmica 4g 6.2W/mK', '4.49', 'Tempest', 8),
(300, 'Tempest Zeroº Pasta Térmica 1g 6.2W/mK', '1.49', 'Tempest', 8),
(301, 'Tempest Adaptador CPU Cooler Socket LGA 1700', '1.98', 'Tempest', 8),
(302, 'Forgeon Adaptador para Ventilador de CPU Socket LGA 1700', '6.99', 'Forgeon', 8),
(303, 'Tempest Fan 120mm ARGB White PWN', '4.99', 'Tempest', 8),
(304, 'Nfortec Draco V2 Fan ARGB Ventilador Suplementario 120mm', '22.82', 'Nfortec', 8),
(305, 'Tempest Cooler 4Pipes Black Ventilador CPU 120mm Negro', '24.99', 'Tempest', 8),
(306, 'Tempest Fan 120mm ARGB Black PWM', '4.99', 'Tempest', 8),
(307, 'Tempest Liquid Cooler 360 RGB Kit de Refrigeración Líquida Negro', '89.99', 'Tempest', 8),
(308, 'Forgeon Azoth 360 ARGB Kit de Refrigeración Líquida Negro', '169.99', 'Forgeon', 8),
(309, 'Nfortec Hydrus V2 120 Blue Kit de Refrigeración Líquida', '49.95', 'Nfortec', 8),
(310, 'Corsair iCUE H100i ELITE CAPELLIX Kit de Refrigeración Líquida', '150.94', 'Corsair', 8),
(311, 'Tempest Cooler 4Pipes White Ventilador CPU 120mm Blanco', '24.99', 'Tempest', 8),
(312, 'Cooler Master Hyper 212 RGB Black Edition', '48.99', 'Cooler Master', 8),
(313, 'Tempest Cooler 3Pipes Ventilador CPU 120mm Negro', '19.99', 'Tempest', 8),
(314, 'Cooler Master MasterLiquid ML240L V2 RGB Kit de Refrigeración Líquida', '70.98', 'Cooler Master', 8),
(315, 'Tempest Cooler 4Pipes Ventilador CPU 120mm Negro', '21.99', 'Tempest', 8),
(316, 'Tempest Liquid Cooler 120 RGB Kit de Refrigeración Líquida Negro', '49.99', 'Tempest', 8),
(317, 'Tempest Liquid Cooler 240 RGB Kit de Refrigeración Líquida Negro', '69.99', 'Tempest', 8),
(318, 'Cooler Master Hyper 212 RGB Black Edition Ventilador CPU', '63.46', 'Cooler Master', 8),
(319, 'Cooler Master LC240E RGB Kit Refrigeración Líquida', '97.65', 'Cooler Master', 8),
(320, 'Cooler Master Hyper 212 Black Edition', '61.63', 'Cooler Master', 8),
(321, 'Forgeon Azoth 240 ARGB Kit de Refrigeración Líquida Negro', '139.98', 'Forgeon', 8),
(322, 'Corsair iCUE H115i ELITE CAPELLIX Kit de Refrigeración Líquida', '149.97', 'Corsair', 8),
(323, 'Forgeon Solarian Cooler 4Pipes Black ARGB Ventilador CPU 120mm', '50.99', 'Forgeon', 8),
(324, 'Lian Li Galahad AIO 360 RGB Kit Refrigeración Líquida Negra', '149.94', 'Lian-Li', 8),
(325, 'Corsair iCUE H100i ELITE CAPELLIX Kit de Refrigeración Líquida Blanco', '150.94', 'Corsair', 8),
(326, 'Lian Li Galahad AIO 360 RGB Kit Refrigeración Líquida Plata', '219.09', 'Lian-Li', 8),
(327, 'Nfortec Hydrus V2 120 Red Kit de Refrigeración Líquida', '49.95', 'Nfortec', 8),
(328, 'Corsair iCUE H100i RGB PRO XT', '121.96', 'Corsair', 8),
(329, 'Lian Li Galahad AIO 240 RGB Kit Refrigeración Líquida Blanco', '135.83', 'Lian-Li', 8),
(330, 'Cooler Master MasterLiquid ML240L V2 ARGB Kit de Refrigeración Líquida', '159.70', 'Cooler Master', 8),
(331, 'Nfortec Hydrus RGB 120 Kit de Refrigeración Líquida', '54.95', 'Nfortec', 8),
(332, 'Noctua NH-U12S CH Ventilador CPU Intel', '90.23', 'Noctua', 8),
(333, 'MSI MAG CoreLiquid 240R V2 Kit de Refrigeración Líquida ARGB', '96.99', 'MSI', 8),
(334, 'Cooler Master Hyper 212 LED Turbo ARGB Ventilador CPU', '68.81', 'Cooler Master', 8),
(335, 'Mars Gaming MT0 Pasta Térmica', '5.49', 'Mars Gaming', 8);

-- --------------------------------------------------------

--
-- Estructura per a vista `catalogo`
--
DROP TABLE IF EXISTS `catalogo`;

CREATE VIEW `catalogo`  AS SELECT `comp`.`id` AS `id`, `comp`.`nombre` AS `componente`, `comp`.`precio` AS `precio`, `comp`.`marca` AS `marca`, `cat`.`nombre` AS `categoría` FROM (`componentes` `comp` join `categorias` `cat`) WHERE `comp`.`id_categoria` = `cat`.`id` ;

--
-- Índexs per a les taules bolcades
--

--
-- Índexs per a la taula `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Índexs per a la taula `componentes`
--
ALTER TABLE `componentes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per les taules bolcades
--

--
-- AUTO_INCREMENT per la taula `componentes`
--
ALTER TABLE `componentes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=336;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
