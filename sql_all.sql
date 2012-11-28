
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


DROP TABLE if exists statcalls;
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
  `statistics_count`int DEFAULT 0,
  `isActivated` boolean,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;


CREATE TABLE `statcalls` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `call_time` datetime NOT NULL,
   FOREIGN KEY (username) REFERENCES `users`(username),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;






