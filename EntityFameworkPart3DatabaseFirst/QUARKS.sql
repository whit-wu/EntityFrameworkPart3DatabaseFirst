-- This database was designed to work with SQL Server 2016.
-- If you are using another RDMS, you may need to tweak 
-- the code so that it uses the appropriate syntax.

CREATE DATABASE QUARKS
GO

USE QUARKS

CREATE TABLE CUSTOMERS (
	 CUSTOMER_ID INT PRIMARY KEY,
	 FIRST_NAME VARCHAR(50),
	 LAST_NAME VARCHAR(50)
);

INSERT INTO CUSTOMERS VALUES (1, 'MILES', 'OBRIEN');
INSERT INTO CUSTOMERS VALUES (2, 'JULIAN', 'BASHIR');
INSERT INTO CUSTOMERS VALUES (3, 'WILLIAM', 'RIKER');

CREATE TABLE TRANSACTIONS (
	TRANSACTION_ID INT PRIMARY KEY,
	TRANSACTION_AMOUNT MONEY,
	CUSTOMER_ID INT FOREIGN KEY REFERENCES CUSTOMERS(CUSTOMER_ID)
);

INSERT INTO TRANSACTIONS VALUES (12312, 30.76, 1);
INSERT INTO TRANSACTIONS VALUES (23423, 85.99, 1);
INSERT INTO TRANSACTIONS VALUES (12231, 11.00, 2);
INSERT INTO TRANSACTIONS VALUES (56474, 44.76, 2);
INSERT INTO TRANSACTIONS VALUES (12234, 22.22, 3);
INSERT INTO TRANSACTIONS VALUES (12343, 11.76, 3);