--CREATE DATABASE library;
--GO

-- ������������ ���� �����
USE [D:\LIBRARY\LIBRARY\DBLIBRARY.MDF];
--GO

---- ������� [role]
--CREATE TABLE [role] (
--    id INT IDENTITY(1,1) PRIMARY KEY, -- ��������� ���� �� ��������������
--    name VARCHAR(30) NOT NULL         -- ������ NOT NULL ��� ����'������� �������
--);
--GO

---- ������� [user]
--CREATE TABLE [user] (
--    id INT IDENTITY(1,1) PRIMARY KEY, -- ��������� ���� �� ��������������
--    name VARCHAR(50) NOT NULL,        -- ��'� ����������� (����'������)
--    phone VARCHAR(50),                -- ������� (���� ���� NULL)
--    login VARCHAR(50) NOT NULL UNIQUE,-- ���� ����������� (����'������� � ���������)
--    password VARCHAR(50) NOT NULL,    -- ������ ����������� (����'�������)
--    roleId INT NOT NULL,              -- ���� ����������� (����'������)
--    FOREIGN KEY (roleId) REFERENCES [role](id) ON DELETE CASCADE ON UPDATE CASCADE
--);
--GO

--INSERT INTO [role] (name) VALUES 
--('�����������'), 
--('���������');

---- ������ �����������
--INSERT INTO [user] (name, phone, login, password, roleId) 
--VALUES ('�����', '+380688675286', 'dkifor', 'den', 1);

-- ��������� ���
--SELECT * FROM [role];
SELECT * FROM [user];
