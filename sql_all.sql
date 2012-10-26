/*
-- Query: SELECT * FROM aic_group2_topic1.users
LIMIT 0, 1000

-- Date: 2012-10-26 15:22
*/

CREATE SCHEMA `aic_group2_topic1`

CREATE TABLE `users` (
`id` int(11) NOT NULL AUTO_INCREMENT,
`username` varchar(255) NOT NULL,
`password` varchar(255) NOT NULL,
PRIMARY KEY (`id`))
ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;


INSERT INTO `users` (`id`,`username`,`password`) VALUES (1,'wolfgang','3720f54e919b22cce392b05de57102dd');
INSERT INTO `users` (`id`,`username`,`password`) VALUES (2,'manuela','c4646d2f83c510ab1e7e553cd1e2f710');
INSERT INTO `users` (`id`,`username`,`password`) VALUES (3,'bernhard','eaa72d8db7e4c24d35052865786f7b98');
INSERT INTO `users` (`id`,`username`,`password`) VALUES (4,'andreas','e024f9589c1e9d64b34cb1257d9c9dfc');
