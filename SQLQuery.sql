--CREATE DATABASE library;
--GO

-- Використання бази даних
USE [D:\LIBRARY\LIBRARY\DBLIBRARY.MDF];
--GO

---- Таблиця [role]
--CREATE TABLE [role] (
--    id INT IDENTITY(1,1) PRIMARY KEY, -- Первинний ключ із автоінкрементом
--    name VARCHAR(30) NOT NULL         -- Додано NOT NULL для обов'язкових значень
--);
--GO

---- Таблиця [user]
--CREATE TABLE [user] (
--    id INT IDENTITY(1,1) PRIMARY KEY, -- Первинний ключ із автоінкрементом
--    name VARCHAR(50) NOT NULL,        -- Ім'я користувача (обов'язкове)
--    phone VARCHAR(50),                -- Телефон (може бути NULL)
--    login VARCHAR(50) NOT NULL UNIQUE,-- Логін користувача (обов'язковий і унікальний)
--    password VARCHAR(50) NOT NULL,    -- Пароль користувача (обов'язковий)
--    roleId INT NOT NULL,              -- Роль користувача (обов'язкова)
--    FOREIGN KEY (roleId) REFERENCES [role](id) ON DELETE CASCADE ON UPDATE CASCADE
--);
--GO

--INSERT INTO [role] (name) VALUES 
--('Адміністратор'), 
--('Працівник');

---- Додати користувача
--INSERT INTO [user] (name, phone, login, password, roleId) 
--VALUES ('Денис', '+380688675286', 'dkifor', 'den', 1);

-- Перевірити дані
--SELECT * FROM [role];
SELECT * FROM [user];
