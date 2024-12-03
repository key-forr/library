CREATE DATABASE IF NOT EXISTS library;
USE library;

CREATE TABLE `role` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL
) ENGINE=InnoDB;

CREATE TABLE `user` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    surname VARCHAR(50) NOT NULL,
    phone VARCHAR(50),
    login VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL,
    roleId INT NOT NULL,
    FOREIGN KEY (roleId) REFERENCES `role`(id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE `reminder` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(50) NOT NULL,
    description VARCHAR(200) NOT NULL,
    userId INT NOT NULL,
    FOREIGN KEY (userId) REFERENCES `user`(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE genre (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE book (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    year YEAR NOT NULL,
    publishing VARCHAR(100) NOT NULL,
    quantity INT NOT NULL DEFAULT 0,
    photo VARCHAR(255) NOT NULL,
    genreId INT,
    FOREIGN KEY (genreId) REFERENCES genre(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE `client` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    surname VARCHAR(50) NOT NULL,
    patronymic VARCHAR(50),
    phone VARCHAR(50) NOT NULL
) ENGINE=InnoDB;

CREATE TABLE `order` (
	id INT AUTO_INCREMENT PRIMARY KEY,
    documentNumber INT,
    dateGive DATE,
    dateReturn Date,
    clientId INT,
    userId INT,
    status VARCHAR(255),
    FOREIGN KEY (clientId) REFERENCES client(id),
    FOREIGN KEY (userId) REFERENCES user(id)
);

CREATE TABLE `orderRow` (
	documentNumber INT,
    lineId INT,
	bookId INT,
    status VARCHAR(255),
    FOREIGN KEY (bookId) REFERENCES book(id)
);

INSERT INTO `role` (name) VALUES 
('Адміністратор'),
('Працівник');

INSERT INTO `user` (name, phone, login, password, roleId)
VALUES ('Денис', '+380688675286', 'dkifor', 'denys', 1);

INSERT INTO `user` (name, phone, login, password, roleId)
VALUES 
('Денsис', '+3806dsf88675286', 'dkifosfsfr', 'desnys', 2);
 
 INSERT INTO genre (name) 
 VALUES 
 ("Жахи"), 
 ("Детектикиви");
 
ALTER TABLE `reminder`
ADD isActive BOOLEAN DEFAULT TRUE;

ALTER TABLE `user`
ADD surname VARCHAR(30);

SET FOREIGN_KEY_CHECKS = 0; 
TRUNCATE TABLE `reminder`; 
SET FOREIGN_KEY_CHECKS = 1;

ALTER TABLE `reminder`
ADD date DATE after description;

ALTER TABLE reminder
DROP COLUMN date;

SELECT * FROM `book`;
SELECT * FROM `genre`;
SELECT * FROM `reminder`;
SELECT * FROM `role`;
SELECT * FROM `user`;

ALTER TABLE user
ADD COLUMN surname VARCHAR(30) NOT NULL AFTER name;

INSERT INTO `order` (documentNumber, dateGive, dateReturn, clientId, userId, status)
VALUES 
(1, null, null, 1, 1, '');

SELECT id FROM `order`;