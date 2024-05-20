-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 20 May 2024, 14:29:11
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `gorselprogram`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `akademisyenler`
--

CREATE TABLE `akademisyenler` (
  `akademik_id` int(11) NOT NULL,
  `unvan` varchar(50) NOT NULL,
  `ad_soyad` varchar(100) NOT NULL,
  `bolum` varchar(50) NOT NULL,
  `tel_numara` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `akademisyenler`
--

INSERT INTO `akademisyenler` (`akademik_id`, `unvan`, `ad_soyad`, `bolum`, `tel_numara`) VALUES
(1, 'Öğr.Gör.', 'Tuğba Altındağ', 'Bilgisayar Mühendisliği', '12345'),
(2, 'Prof. Dr.', 'Celal Şengör', 'Jeoloji Mühendisliği', '555123'),
(3, 'Prof. Dr.', 'Ayşe Yılmaz', 'Bilgisayar Mühendisliği', '5222'),
(5, 'Doç.Dr.', 'Mehmet Kaya', 'Matematik', '5124'),
(6, 'Yrd.Doç.Dr.', 'Fatma Demir', 'Fizik', '5266');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `aradeg`
--

CREATE TABLE `aradeg` (
  `egitim_ogretim_donemi` varchar(50) DEFAULT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `ogrenci_no` int(11) DEFAULT NULL,
  `ogrenci_ad_soyad` varchar(100) DEFAULT NULL,
  `ara_notu` decimal(5,2) DEFAULT NULL,
  `final_notu` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `geneltablo`
--

CREATE TABLE `geneltablo` (
  `Proje_ID` int(11) NOT NULL,
  `ogrenci_no` int(11) DEFAULT NULL,
  `proje_adi` varchar(255) DEFAULT NULL,
  `proje_danismani` varchar(255) DEFAULT NULL,
  `ara_notu` decimal(5,2) DEFAULT NULL,
  `final_notu` decimal(5,2) DEFAULT NULL,
  `Proje_Süresi_YarıYıl` varchar(50) DEFAULT NULL,
  `Proje_Kaçıncı_YarıYıl` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `geneltablo`
--

INSERT INTO `geneltablo` (`Proje_ID`, `ogrenci_no`, `proje_adi`, `proje_danismani`, `ara_notu`, `final_notu`, `Proje_Süresi_YarıYıl`, `Proje_Kaçıncı_YarıYıl`) VALUES
(1, 1, '1', '1', 9.00, 1.00, NULL, '1'),
(2, 2, '2', '2', 0.00, 2.00, NULL, '2'),
(3, 1, 'q', 'w', 0.00, 15.00, '2', '4'),
(4, 22299504, 'enes', 'Tuğba Altındağ', 0.00, 15.00, NULL, NULL),
(5, 22299503, 'deneme12', 'Fatma Demir', 11.00, 1.00, NULL, NULL),
(6, 2, 'ENESBA', 'Fatma Demir', 40.00, NULL, NULL, NULL),
(7, 22299503, 'asdasd', 'Tuğba Altındağ', 0.00, 15.00, NULL, NULL),
(8, 22299503, 'enesio', 'Tuğba Altındağ', 40.00, 60.00, NULL, NULL),
(9, 22299503, 'enesv', 'Tuğba Altındağ', 8.00, 18.00, NULL, NULL),
(10, 22299505, 'asd', 'Celal Şengör', 1.00, NULL, '2023', '2025'),
(11, 22299503, 'enes', 'Tuğba Altındağ', 78.00, 18.00, '2025-Bahar', '2024-Bahar'),
(25, 22299505, 'proje', 'Tuğba Altındağ', 1.00, 15.00, '2023-BAHAR', '2023-BAHAR');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `ID` int(11) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Sifre` varchar(100) NOT NULL,
  `Unvan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`ID`, `Email`, `Sifre`, `Unvan`) VALUES
(1, 'taltindag@baskent.edu.tr', '123456', 'Öğr.Gör.'),
(2, 'enesmuratgul@gmail.com', '123123', 'Admin');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenciler`
--

CREATE TABLE `ogrenciler` (
  `egitim_ogretim_donemi` varchar(20) NOT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `ogrenci_no` int(11) NOT NULL,
  `ogrenci_ad_soyad` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `ogrenciler`
--

INSERT INTO `ogrenciler` (`egitim_ogretim_donemi`, `ogrenci_id`, `ogrenci_no`, `ogrenci_ad_soyad`) VALUES
('2023-2024 Bahar', 1, 22299503, 'Enes Muratgül'),
('2023-2024 Bahar', 2, 22299504, 'Mehmet Akif'),
('2023-2023 Bahar', 3, 22299505, 'Fatma Ceylan');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenciler2`
--

CREATE TABLE `ogrenciler2` (
  `egitim_ogretim_donemi` varchar(20) DEFAULT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `ogrenci_no` int(11) DEFAULT NULL,
  `ogrenci_ad_soyad` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `akademisyenler`
--
ALTER TABLE `akademisyenler`
  ADD PRIMARY KEY (`akademik_id`);

--
-- Tablo için indeksler `aradeg`
--
ALTER TABLE `aradeg`
  ADD PRIMARY KEY (`ogrenci_id`);

--
-- Tablo için indeksler `geneltablo`
--
ALTER TABLE `geneltablo`
  ADD PRIMARY KEY (`Proje_ID`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `ogrenciler`
--
ALTER TABLE `ogrenciler`
  ADD PRIMARY KEY (`ogrenci_id`);

--
-- Tablo için indeksler `ogrenciler2`
--
ALTER TABLE `ogrenciler2`
  ADD PRIMARY KEY (`ogrenci_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `akademisyenler`
--
ALTER TABLE `akademisyenler`
  MODIFY `akademik_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `aradeg`
--
ALTER TABLE `aradeg`
  MODIFY `ogrenci_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `geneltablo`
--
ALTER TABLE `geneltablo`
  MODIFY `Proje_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `ogrenciler`
--
ALTER TABLE `ogrenciler`
  MODIFY `ogrenci_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `ogrenciler2`
--
ALTER TABLE `ogrenciler2`
  MODIFY `ogrenci_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
