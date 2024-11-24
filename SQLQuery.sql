-- Create database
-- CREATE DATABASE IF NOT EXISTS library;

-- Use the database
-- USE library;

-- Create role table
-- CREATE TABLE `role` (
--     id INT AUTO_INCREMENT PRIMARY KEY,
--     name VARCHAR(30) NOT NULL
-- ) ENGINE=InnoDB;

-- Create user table
-- CREATE TABLE `user` (
--     id INT AUTO_INCREMENT PRIMARY KEY,
--     name VARCHAR(50) NOT NULL,
--     phone VARCHAR(50),
--     login VARCHAR(50) NOT NULL UNIQUE,
--     password VARCHAR(50) NOT NULL,
--     roleId INT NOT NULL,
--     FOREIGN KEY (roleId) REFERENCES `role`(id) 
--         ON DELETE CASCADE 
--         ON UPDATE CASCADE
-- ) ENGINE=InnoDB;

-- Create reminder table
-- CREATE TABLE `reminder` (
--     id INT AUTO_INCREMENT PRIMARY KEY,
--     title VARCHAR(50) NOT NULL,
--     description VARCHAR(200) NOT NULL,
--     userId INT NOT NULL,
--     FOREIGN KEY (userId) REFERENCES `user`(id)
--         ON DELETE CASCADE
--         ON UPDATE CASCADE
-- ) ENGINE=InnoDB;

-- Insert roles
-- INSERT INTO `role` (name) VALUES 
-- ('Адміністратор'),
-- ('Працівник');

-- Insert user
-- INSERT INTO `user` (name, phone, login, password, roleId)
-- VALUES ('Денис', '+380688675286', 'dkifor', 'denys', 1);

-- Select statements for verification
-- SELECT * FROM `role`;
-- SELECT * FROM `user`;
-- SELECT * FROM `reminder`;

-- Select user by login and password
-- SELECT id FROM `user` WHERE login = 'dkifor' AND password = 'denys';

INSERT INTO `user` (name, phone, login, password, roleId)
 VALUES ('Денsис', '+3806dsf88675286', 'dkifosfsfr', 'desnys', 2);
SELECT * FROM `reminder`;

INSERT INTO reminder (title, description, userId) VALUES ("kojnspdkjohyguijnod", "konjihjkojibhjhhsd", 2);
 SELECT * FROM `user`;