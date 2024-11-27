-- Create database
-- CREATE DATABASE IF NOT EXISTS library;

-- Use the database
 USE library;

CREATE TABLE `role` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL
) ENGINE=InnoDB;

CREATE TABLE `user` (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
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

INSERT INTO `role` (name) VALUES 
('Адміністратор'),
('Працівник');

INSERT INTO `user` (name, phone, login, password, roleId)
VALUES ('Денис', '+380688675286', 'dkifor', 'denys', 1);

SELECT * FROM `role`;
SELECT * FROM `user`;
SELECT * FROM `reminder`;

SELECT id FROM `user` WHERE login = 'dkifor' AND password = 'denys';

INSERT INTO `user` (name, phone, login, password, roleId)
 VALUES ('Денsис', '+3806dsf88675286', 'dkifosfsfr', 'desnys', 2);
SELECT * FROM `reminder`;

INSERT INTO reminder (title, description, userId) VALUES ("kojnspdkjohyguijnod", "konjihjkojibhjhhsd", 2);
 SELECT * FROM `user`;
 
ALTER TABLE `reminder`
ADD isActive BOOLEAN DEFAULT TRUE;

SET FOREIGN_KEY_CHECKS = 0; 
TRUNCATE TABLE `reminder`; 
SET FOREIGN_KEY_CHECKS = 1;


ALTER TABLE `user`
ADD surname VARCHAR(30);
SELECT user.name, user.phone, user.password, role.name, ifnull(user.surname, '') FROM user LEFT JOIN role ON role.id = user.roleId WHERE user.login = 'dkifor';

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
    genre_id INT,
    FOREIGN KEY (genre_id) REFERENCES genre(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB;

INSERT INTO genre (name) VALUES ("Жахи"), ("Детектикиви");
SELECT * FROM genre;

SELECT * FROM book;

SET FOREIGN_KEY_CHECKS = 0; 
TRUNCATE TABLE `book`; 
SET FOREIGN_KEY_CHECKS = 1;