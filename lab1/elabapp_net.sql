-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 28, 2024 at 08:45 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `elabapp_net`
--

-- --------------------------------------------------------

--
-- Table structure for table `lab1`
--

CREATE TABLE `lab1` (
  `ID` int(11) NOT NULL,
  `NUME` varchar(255) NOT NULL,
  `PRENUME` varchar(255) NOT NULL,
  `VECHIME` int(11) NOT NULL,
  `SALAR` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lab1`
--

INSERT INTO `lab1` (`ID`, `NUME`, `PRENUME`, `VECHIME`, `SALAR`) VALUES
(2, 'BOSTAN', 'DANIEL', 2, 540),
(3, 'PREDA', 'GABRIELA', 12, 1123),
(1, 'VASILE', 'RIMURESCU', 14, 555),
(4, 'ANTONIU', 'IONEL', 8, 789),
(5, 'BARBU', 'STEFAN', 9, 1789);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
