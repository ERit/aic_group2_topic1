/*
-- Query: SELECT * FROM aic_group2_topic1.users
LIMIT 0, 1000

-- Date: 2012-10-26 15:22
*/

CREATE SCHEMA if not exists `aic_group2_topic1`;

DROP TABLE if exists bill;
CREATE TABLE `bill` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userId` int(11) NOT NULL,
  `price` decimal(10,0) NOT NULL DEFAULT '0',
  `isPayed` tinyint(4) NOT NULL DEFAULT '0',
  `accountedUntil` datetime NOT NULL,
  `created` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;


DROP TABLE if exists users;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL UNIQUE,
  `password` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `creditcard` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `activeDate` datetime NOT NULL,
  `deactiveDate` datetime DEFAULT NULL,
  `statisticCalls` int DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;


/*
  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`)


  VALUES (1,'max','352db51c3ff06159d380d3d9935ec814','Max','Mustermann','max.mustermann@tuwien.ac.at',
  '123ert-123645-456fdvfv-678sdfd','Apple');
*/




