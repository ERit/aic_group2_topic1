/*
-- Query: SELECT * FROM aic_group2_topic1.users
LIMIT 0, 1000

-- Date: 2012-10-26 15:22
*/

CREATE SCHEMA `aic_group2_topic1`;

CREATE TABLE `users` (
`id` int(11) NOT NULL AUTO_INCREMENT,

`username` varchar(255) NOT NULL,

`password` varchar(255) NOT NULL,

`firstname` varchar(255) NOT NULL,

`lastname` varchar(255) NOT NULL,

`email` varchar(255) NOT NULL,

`creditcard` varchar(255) NOT NULL,

`company` varchar(255) NOT NULL,

PRIMARY KEY (`id`));


INSERT INTO `users` 
(`id`,`username`,`password`,`firstname`,`lastname`,`email`,`creditcard`,`company`)


VALUES (1,'max','352db51c3ff06159d380d3d9935ec814','Max','Mustermann','max.mustermann@tuwien.ac.at',
'123ert-123645-456fdvfv-678sdfd','Apple');



