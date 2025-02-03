-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2025 at 10:40 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gym`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `MemberName` text NOT NULL,
  `ClassName` text NOT NULL,
  `Date` text NOT NULL,
  `Time` text NOT NULL,
  `Attendance` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `availability`
--

CREATE TABLE `availability` (
  `Username` text NOT NULL,
  `Date` text NOT NULL,
  `Time` text NOT NULL,
  `Class` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `availability`
--

INSERT INTO `availability` (`Username`, `Date`, `Time`, `Class`) VALUES
('is', '2025-02-04', '2', 'Bodybuilding');

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `UserName` text NOT NULL,
  `SelectClass` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`UserName`, `SelectClass`) VALUES
('user1', 'Kickboxing'),
('user2', 'Kickboxing'),
('user3', 'Kickboxing'),
('user3', 'Yoga'),
('user1', 'Yoga'),
('user2', 'Yoga'),
('user1', 'Bodybuilding'),
('user2', 'Bodybuilding'),
('is', 'Bodybuilding');

-- --------------------------------------------------------

--
-- Table structure for table `classschedule`
--

CREATE TABLE `classschedule` (
  `ClassName` text NOT NULL,
  `Date` text NOT NULL,
  `Time` text NOT NULL,
  `Trainer` text NOT NULL,
  `Capacity` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `classschedule`
--

INSERT INTO `classschedule` (`ClassName`, `Date`, `Time`, `Trainer`, `Capacity`) VALUES
('', '', '', '', ''),
('kickboxing', '111111', '2', 'tr2', '1'),
('wrestling', '200103', '3', 'tr2', '20'),
('', '', '', '', ''),
('Bodybuilding', '220222', '1', 'tr1', '5'),
('Yoga', '220120', '2', 'tr2', '4');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `Gender` text NOT NULL,
  `DOB` text NOT NULL,
  `Telephone num` text NOT NULL,
  `Address` text NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`FirstName`, `LastName`, `Gender`, `DOB`, `Telephone num`, `Address`, `Username`, `Password`) VALUES
('Hello', 'Kitty', 'Female', 'Monday, February 1, 1999', '123456789', 'guwegfuiwg', 'user2', 'pw2'),
('Spongebob', 'Squarepants', 'Male', 'Thursday, February 1, 2001', '987654321', 'UnderWater', 'user1', 'pw1');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `UserName` text NOT NULL,
  `Total` text NOT NULL,
  `Months` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`UserName`, `Total`, `Months`) VALUES
('user1', '4000', '2'),
('user1', '2000', '1'),
('ye', '4000', '2'),
('yel', '4000', '2'),
('yel', '4000', '2');

-- --------------------------------------------------------

--
-- Table structure for table `trainer`
--

CREATE TABLE `trainer` (
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `Gender` text NOT NULL,
  `DOB` text NOT NULL,
  `Telephone num` text NOT NULL,
  `Address` text NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trainer`
--

INSERT INTO `trainer` (`FirstName`, `LastName`, `Gender`, `DOB`, `Telephone num`, `Address`, `Username`, `Password`) VALUES
('Ganidu', 'Madushan', 'Male', 'Tuesday, February 1, 2000', '234567890', 'StepUp', 'tr1', 'pw1');

-- --------------------------------------------------------

--
-- Table structure for table `trainer_payments`
--

CREATE TABLE `trainer_payments` (
  `trainer_name` text NOT NULL,
  `payment_date` text NOT NULL,
  `Salary(Rs.)` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trainer_payments`
--

INSERT INTO `trainer_payments` (`trainer_name`, `payment_date`, `Salary(Rs.)`) VALUES
('tr1', '2025-02-04', 5000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
