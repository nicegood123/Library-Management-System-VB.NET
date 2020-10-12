-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 12, 2020 at 10:35 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lms`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `id` int(8) NOT NULL,
  `title` text NOT NULL,
  `author` text DEFAULT 'No Author',
  `publisher` text DEFAULT 'No Publisher',
  `date_published` varchar(4) DEFAULT NULL,
  `copies` int(10) DEFAULT 0,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`id`, `title`, `author`, `publisher`, `date_published`, `copies`, `created_at`, `updated_at`) VALUES
(441221, 'Networking I', 'Johnny Bravo', 'Nicegood Publishing, Inc.', '1772', 1, '2020-09-22 03:00:52', '2020-10-12 17:46:15'),
(441222, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Gates, Inc.', '1768', 5, '2020-09-30 22:31:01', '2020-10-12 17:46:15'),
(448921, 'Object-Oriented Programming and Design', 'Xander Ford', 'Ford Inc.', '1753', 3, '2020-09-22 02:59:51', '2020-10-12 17:45:58'),
(478049, 'The Lord of the Rings', 'J.R.R. Tolkien', 'Reyes, Inc.', '1774', 1, '2020-09-22 02:59:08', '2020-10-12 17:32:04'),
(478050, 'The Contemporary World of Kalibutan', 'Lisandro E. Claudio & Patricio N. Abinales', 'C & E Publishing, Inc.', '1943', 118, '2020-09-28 17:16:39', '2020-10-12 18:34:32'),
(478051, '1984', 'George Orwell', 'Bookware Publishing Corporation', '1776', 23, '2020-10-12 00:44:07', '2020-10-12 17:32:32'),
(478055, 'Harry Potter and the Philosopher’s Stone', 'K.K. Rowling', 'Ateneo De Manila University Press', '2000', 1, '2020-10-12 01:10:47', '2020-10-12 17:39:57'),
(478056, 'To Kill a Mockingbird', 'Harper Lee', 'Nicegood Publishing, Inc.', '1960', 10, '2020-10-12 17:16:48', '2020-10-12 17:18:20'),
(478057, 'Pride and Prejudice', 'Jane Austen', 'Saint Matthew’s Publishing', '2004', 2, '2020-10-12 17:21:02', '2020-10-12 17:40:04'),
(478058, 'The Diary Of A Young Girl', 'Anne Frank', 'UST Publishing House', '1960', 0, '2020-10-12 17:21:22', '2020-10-12 17:34:38'),
(478059, 'The Book Thief', 'Markus Zusak', 'Bookware Publishing Corporation', '2000', 9, '2020-10-12 17:21:45', '2020-10-12 17:40:23'),
(478060, 'The Hobbit', 'J.R.R. Tolkien', 'Anvil Publishing', '2007', 5, '2020-10-12 17:22:02', '2020-10-12 17:40:13'),
(478061, 'Little Women', 'Louisa May Alcott', 'University of The Philippines Press', '2015', 8, '2020-10-12 17:22:38', '2020-10-12 17:40:32'),
(478062, 'Why Don’t Students Like School?', 'Daniel WIllingham', 'Anvil Publishing', '1757', 11, '2020-10-12 17:23:39', '2020-10-12 17:37:51'),
(478063, 'The Hidden Lives of Learners', 'Graham Nuthall', 'Vival Publishing House', '2020', 3, '2020-10-12 17:23:58', '2020-10-12 17:36:19'),
(478064, 'Trivium 21c', 'Martin Robinson', 'University of The Philippines Press', '1945', 0, '2020-10-12 17:24:13', '2020-10-12 17:35:07'),
(478065, 'Embedded Formative Assessment', 'Dylan William', 'Ateneo De Manila University Press', '1773', 10, '2020-10-12 17:24:32', '2020-10-12 17:41:30'),
(478066, 'Seven Myths About Education', 'Daisy Chrisodoulou', 'UST Publishing House', '2007', 0, '2020-10-12 17:24:58', '2020-10-12 17:34:46'),
(478067, 'Visible Learning and the Science of How We Learn', 'John Hattie', 'Bookware Publishing Corporation', '2018', 189, '2020-10-12 17:25:23', '2020-10-12 17:46:33'),
(478068, 'Bringing Words to Life', 'Isabel L. Beck & Margaret G. McKeown', 'Bookware Publishing Corporation', '1758', 5, '2020-10-12 17:26:00', '2020-10-12 20:24:54'),
(478069, 'Why Knowledge Matters', 'ED Hirsch', 'Saint Matthew’s Publishing', '2000', 3, '2020-10-12 17:26:32', '2020-10-12 20:25:00');

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_details`
--

CREATE TABLE `borrowed_details` (
  `student_id` int(8) NOT NULL,
  `book_id` int(8) NOT NULL,
  `date_borrowed` timestamp NOT NULL DEFAULT current_timestamp(),
  `date_returned` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `borrowed_details`
--

INSERT INTO `borrowed_details` (`student_id`, `book_id`, `date_borrowed`, `date_returned`) VALUES
(455050, 448921, '2020-10-12 17:45:58', NULL),
(455050, 478050, '2020-10-12 17:45:58', NULL),
(455050, 478068, '2020-10-12 17:45:58', NULL),
(455052, 478067, '2020-10-12 17:46:33', NULL),
(455053, 441221, '2020-10-12 17:46:15', NULL),
(455053, 441222, '2020-10-12 17:46:15', NULL),
(455054, 448921, '2020-10-03 00:35:36', NULL),
(455054, 478050, '2020-10-01 07:22:53', NULL),
(455061, 478050, '2020-10-01 13:48:10', NULL),
(455064, 441221, '2020-10-03 00:35:56', NULL),
(455064, 478050, '2020-10-03 00:35:56', NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `borrower`
-- (See below for the actual view)
--
CREATE TABLE `borrower` (
`student_id` int(8)
,`id` int(8)
,`title` text
,`author` text
,`publisher` text
,`date_published` varchar(4)
,`date_borrowed` timestamp
);

-- --------------------------------------------------------

--
-- Table structure for table `librarian`
--

CREATE TABLE `librarian` (
  `id` int(8) NOT NULL,
  `avatar` varchar(150) NOT NULL,
  `name` varchar(30) NOT NULL,
  `address` text NOT NULL,
  `contact` varchar(13) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(40) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `librarian`
--

INSERT INTO `librarian` (`id`, `avatar`, `name`, `address`, `contact`, `username`, `password`, `created_at`, `updated_at`) VALUES
(1, 'avatar\\librarian\\1.jpg', 'administrator', '', '', 'admin', 'admin', '2020-10-01 03:07:36', '2020-10-10 18:34:34'),
(3050, 'avatar\\librarian\\3050.jpg', 'Miriam Trinidad', 'PUROK 35 MAHARLIKA VILL. MAA DAVAO CITY', '+639886529258', 'user', 'user123', '2020-10-01 03:08:51', '2020-10-12 18:25:17'),
(3051, 'avatar\\librarian\\3051.jpg', 'Gisan Geff M Raniego', '6TH AVENUE, PUROK 4, LIZADA ST., DAVAO CITY', '+639005437768', 'gisangeff', 'nicegood321', '2020-10-11 17:21:22', '2020-10-12 18:25:25'),
(3052, 'avatar\\librarian\\3052.jpg', 'Qassem Suleimani', 'Block 6, Lot 12, Sto Cristo Street, Macleod Toril, Davao City', '+639758565923', 'sowndergleeking', 'sowndergleeking', '2020-10-11 17:22:10', '2020-10-12 18:25:34'),
(3053, 'avatar\\librarian\\3053.jpg', 'Sun Kailiang', 'ph.2, blk. 10, lot12, batolusa, toril, davao city', '+639141860329', 'egadfilm', 'egadfilm', '2020-10-11 17:23:41', '2020-10-12 18:25:45'),
(3054, 'avatar\\librarian\\3054.jpg', 'Mokhtar Belmokhtar', 'batolusa ph.2, bgy. bangkas hts, toril, davao city', '+639042022484', 'technicianbellh', 'technicianbellhop', '2020-10-11 17:26:29', '2020-10-12 18:25:53'),
(3056, 'avatar\\librarian\\3056.jpg', 'Frank Lucas', 'Paquibato District, Davao City', '+639301082903', 'driedhuorn', 'driedhuorn', '2020-10-11 17:28:29', '2020-10-12 18:26:42'),
(3057, 'avatar\\librarian\\3057.jpg', 'Ibrahim al-Asiri AKA Abu Saleh', 'Block 3, Lot 2, DLF Village, Dumoy, Davao City', '+639977064268', 'rnalate', 'rnalate', '2020-10-12 16:04:28', '2020-10-12 18:26:32'),
(3058, 'avatar\\librarian\\3058.jpg', 'Grace O’Malley', 'San Nicolas, Daliao, Toril, Davao City', '+639216137802', 'translatornide', 'translatornide', '2020-10-12 17:14:01', '2020-10-12 18:26:24'),
(3059, 'avatar\\librarian\\3059.jpg', 'Jemeker Thompson', 'J. Saavedra Street Bangoy Compound Toril, Davao City', '+639869004672', 'videorash', 'videorash', '2020-10-12 17:14:11', '2020-10-12 18:26:16'),
(3060, 'avatar\\librarian\\3060.jpg', 'Charmaine Roman', 'ph.2, virgen delos remedios st., manggahan, toril, davao city', '+639230864606', 'sushidandelion', 'sushidandelion', '2020-10-12 17:14:26', '2020-10-12 18:26:06');

-- --------------------------------------------------------

--
-- Stand-in structure for view `records`
-- (See below for the actual view)
--
CREATE TABLE `records` (
`id` int(8)
,`avatar` varchar(150)
,`name` varchar(100)
,`contact` varchar(13)
,`address` text
,`Borrowed` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(8) NOT NULL,
  `avatar` varchar(150) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` text NOT NULL,
  `contact` varchar(13) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `avatar`, `name`, `address`, `contact`, `created_at`, `updated_at`) VALUES
(455050, 'avatar\\students\\455050.jpg', 'Cody Wilson', 'Block 1, Lot B, Daffodil Street, Davao City', '+639123789122', '2020-09-23 21:50:54', '2020-10-12 18:27:00'),
(455051, 'avatar\\students\\455051.jpg', 'Semion Mogilevich', 'Door #3, Choing Apartment, Sitio Basak, Mintal, Davao City', '+639058479987', '2020-09-28 13:18:33', '2020-10-12 18:28:58'),
(455052, 'avatar\\students\\455052.jpg', 'Abubakar Shekau', 'Blk 31 Lot 4,  Wellspring 1,  Catalunan Pequeno,  Davao City', '+639794505135', '2020-09-28 13:18:52', '2020-10-12 18:29:12'),
(455053, 'avatar\\students\\455053.jpg', 'Matteo Messina Denaro', 'St. Luke, EMP Village, Marfori Heights, Davao City', '+639734939248', '2020-09-28 13:21:06', '2020-10-12 18:29:26'),
(455054, 'avatar\\students\\455054.jpg', 'Miriam Trinidad', 'SAMMY UY RELOCATION SUBD, KM. 2, DAVAO CITY', '+639334183526', '2020-09-28 13:21:18', '2020-10-12 18:29:43'),
(455055, 'avatar\\students\\455055.jpg', 'Griselda Blanco Restrepo', 'R. CASTILLO JEROME SOLID EXT. AGDAO, DAVAO CITY', '+639248021921', '2020-09-28 13:21:20', '2020-10-12 18:31:18'),
(455056, 'avatar\\students\\455056.jpg', 'Phoolan Devi', 'R. CASTILLO JEROME SOLID EXT. AGDAO, DAVAO CITY', '+639806792640', '2020-09-28 13:21:23', '2020-10-12 18:31:29'),
(455058, 'avatar\\students\\455058.jpg', 'Gisan Geff Raniego', '#4 RUBY ST. MARFORI HEIGHTS, DAVAO CITY', '+639831495477', '2020-09-28 13:21:30', '2020-10-12 18:31:09'),
(455059, 'avatar\\students\\455059.jpg', '+639291934216', '74-A, ARROYO VILLAGE, MATINA, DAVAO CITY', '+639123789168', '2020-09-28 13:21:32', '2020-10-12 18:30:58'),
(455060, 'avatar\\students\\455060.jpg', 'Rosetta Cutolo', '#14 EMERALD ST., MARFORI HEIGHTS SUBD., DAVAO CITY', '+639479995692', '2020-09-28 13:41:07', '2020-10-12 18:30:46'),
(455061, 'avatar\\students\\455061.jpg', 'Sandra Ávila Beltrán', '956 TRADING BLVD, DAVAO CITY', '+639960203652', '2020-09-28 13:41:36', '2020-10-12 18:30:36'),
(455062, 'avatar\\students\\455062.jpg', 'Joseph Kony', 'MALAMBOON, ECOLAND, DAVAO CITY', '+639400844625', '2020-09-28 13:43:49', '2020-10-12 18:29:53'),
(455063, 'avatar\\students\\455063.jpg', 'Griselda Blanco', 'SUNFLOWER ST., BGY. UBALDE, AGDAO, DAVAO CITY', '+639812353440', '2020-09-28 13:43:58', '2020-10-12 18:30:27'),
(455064, 'avatar\\students\\455064.jpg', 'Omar Hassan al-Bashir', '41-2 FATIMA VILLAGE, BAJADA, DAVAO CITY', '+639776366706', '2020-09-28 14:08:36', '2020-10-12 18:30:19'),
(455065, 'avatar\\students\\455065.jpg', 'Enedina Arellano Felix', 'BLOCK 11, LOT 12, JADE ST., RIVERVIEW VILLAGE, BGY. 19-B, BAJADA, DAVAO CITY', '+639849195717', '2020-10-12 17:06:05', '2020-10-12 18:30:11'),
(455066, 'avatar\\students\\455066.jpg', 'Ismael ‘El Mayo’ Zambada', '333-A STA. MONICA ST., BUHANGIN, DAVAO CITY', '+639744025531', '2020-10-12 17:08:35', '2020-10-12 18:30:01');

-- --------------------------------------------------------

--
-- Structure for view `borrower`
--
DROP TABLE IF EXISTS `borrower`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `borrower`  AS  select `borrowed_details`.`student_id` AS `student_id`,`book`.`id` AS `id`,`book`.`title` AS `title`,`book`.`author` AS `author`,`book`.`publisher` AS `publisher`,`book`.`date_published` AS `date_published`,`borrowed_details`.`date_borrowed` AS `date_borrowed` from (`borrowed_details` join `book` on(`borrowed_details`.`book_id` = `book`.`id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `records`
--
DROP TABLE IF EXISTS `records`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `records`  AS  select `student`.`id` AS `id`,`student`.`avatar` AS `avatar`,`student`.`name` AS `name`,`student`.`contact` AS `contact`,`student`.`address` AS `address`,count(`borrowed_details`.`student_id`) AS `Borrowed` from (`borrowed_details` join `student` on(`borrowed_details`.`student_id` = `student`.`id`)) group by `borrowed_details`.`student_id` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `borrowed_details`
--
ALTER TABLE `borrowed_details`
  ADD PRIMARY KEY (`student_id`,`book_id`);

--
-- Indexes for table `librarian`
--
ALTER TABLE `librarian`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
