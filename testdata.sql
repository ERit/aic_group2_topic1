/*
-- Query: SELECT * FROM aic_group2_topic1.users
LIMIT 0, 1000

-- Date: 2012-11-27 01:48
*/
  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`, `isActivated`)
  VALUES (NULL,'max','81dc9bdb52d04dc20036dbd8313ed055','Max','Mustermann',
  'max.mustermann@tuwien.ac.at', '123ert-123645-456fdvfv-678sdfd','Microsoft',NOW(),NULL,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`, `isActivated`)
  VALUES (NULL,'john','81dc9bdb52d04dc20036dbd8313ed055','John','Doe',
  'john.doe@tuwien.ac.at', '68snvkt-1sd2n5-sdfnj28-fj28alc','Logitech',NOW(),NULL,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`, `isActivated`)
  VALUES (NULL,'albert','81dc9bdb52d04dc20036dbd8313ed055','Albert','Lechner',
  'albert.lechner@gmail.com', '6869201-sd921045-cnai27a-bljo48','Canon',NOW(),NULL,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`, `isActivated`)
  VALUES (NULL,'tanja','81dc9bdb52d04dc20036dbd8313ed055','Tanja','Huber',
  'tanja.huber@gmx.net', '612h2h2-765432-123434-asdfg','Eskimo',NOW(),NULL,TRUE);

  INSERT INTO `users` 
  (`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`,`activeDate`,`deactiveDate`, `isActivated`)
  VALUES (NULL,'martina','81dc9bdb52d04dc20036dbd8313ed055','Martina','Becker',
  'mbecker@gmx.at', '50gjt2-g5d3k9s-jhgf43-as123','Nintendo',NOW(),NULL,TRUE);

/*
-- Query: SELECT * FROM aic_group2_topic1.bill
LIMIT 0, 1000

-- Date: 2012-11-27 01:47
*/
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (1,2,3,0,'2012-10-25 00:00:00','2012-11-26 23:00:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (2,2,5,0,'2012-10-26 00:00:00','2012-11-26 23:00:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (4,2,1,0,'2012-10-28 00:00:00','2012-11-27 00:22:00');
INSERT INTO `bill` (`id`,`userId`,`price`,`isPayed`,`accountedUntil`,`created`) VALUES (5,2,31,0,'2012-11-03 00:00:00','2012-11-03 00:00:00');
