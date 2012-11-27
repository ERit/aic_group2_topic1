/*
-- Query: SELECT * FROM aic_group2_topic1.users
LIMIT 0, 1000

-- Date: 2012-11-27 01:48
*/
INSERT INTO `users` (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`) VALUES (1,'max','352db51c3ff06159d380d3d9935ec814','Max','Mustermann','max.mustermann@tuwien.ac.at','123ert-123645-456fdvfv-678sdfd','Apple','2012-11-22 23:22:00',NULL);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)
  VALUES (NULL,'max','352db51c3ff06159d380d3d9935ec814','Max','Mustermann',
  'max.mustermann@tuwien.ac.at', '123ert-123645-456fdvfv-678sdfd','Microsoft',NOW(),NULL,0,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)
  VALUES (NULL,'fritz','352db51c3ff06159d380d3d9935ec814','Fritz','Ferdinand',
  'fritz.ferdinand@tuwien.ac.at', '68snvkt-1sd2n5-sdfnj28-fj28alc','SQL',NOW(),NULL,0,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)
  VALUES (NULL,'albert','352db51c3ff06159d380d3d9935ec814','Albert','Lechner',
  'albert.lechner@gmail.com', '6869201-sd921045-cnai27a-bljo48','WCF',NOW(),NULL,0,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)
  VALUES (NULL,'tanja','352db51c3ff06159d380d3d9935ec814','Tanja','Huber',
  'tanja.huber@gmx.net', '612h2h2-765432-123434-asdfg','Mac OSX',NOW(),NULL,0,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`,`statistics_count`,`isActivated`)
  VALUES (NULL,'martina','352db51c3ff06159d380d3d9935ec814','Martina','Becker',
  'mbecker@gmx.at', '50gjt2-g5d3k9s-jhgf43-as123','Philips',NOW(),NULL,0,TRUE);

/*
-- Query: SELECT * FROM aic_group2_topic1.bill
LIMIT 0, 1000

-- Date: 2012-11-27 01:47
*/
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (1,1,3,0,'2012-10-25 00:00:00','2012-11-26 23:00:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (2,1,5,0,'2012-10-26 00:00:00','2012-11-26 23:00:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (4,1,1,0,'2012-10-28 00:00:00','2012-11-27 00:22:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (5,1,31,0,'2012-11-03 00:00:00','2012-11-03 00:00:00');
