-- Create the database if not exists
CREATE DATABASE IF NOT EXISTS ecommercestore;

-- Switch to the created database
USE ecommercestore;

-- Create the Manufacturer table
CREATE TABLE Manufacturer (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL
);

-- Create the Customer table
CREATE TABLE Customer (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    firstName VARCHAR(255) NOT NULL,
    lastName VARCHAR(255) NOT NULL,
    DOB DATE
);

-- Create the Product table
CREATE TABLE Product (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    ManufacturerId INT,
    Description TEXT,
    FOREIGN KEY (ManufacturerId) REFERENCES Manufacturer(Id)
);

-- Create the Sale table
CREATE TABLE Sale (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    NumItems INT NOT NULL,
    TotalPrice DECIMAL(10, 2) NOT NULL,
    DiscountPrice DECIMAL(10, 2),
    CustomerId INT,
    DateOfPurchase DATE,
    FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
);