-- Insert data into Manufacturer table
INSERT INTO Manufacturer (Name) VALUES
    ('ABC Electronics'),
    ('XYZ Gadgets'),
    ('PQR Appliances');

-- Insert data into Product table
INSERT INTO Product (Name, Price, ManufacturerId, Description) VALUES
    ('Laptop', 999.99, 1, 'High-performance laptop with SSD storage'),
    ('Smartphone', 499.99, 2, '5G enabled smartphone with dual cameras'),
    ('Refrigerator', 799.99, 3, 'Large capacity refrigerator with energy-efficient features');

-- Insert data into Customer table
INSERT INTO Customer (firstName, lastName, DOB) VALUES
    ('John', 'Doe', '1990-05-15'),
    ('Alice', 'Smith', '1985-09-22'),
    ('Bob', 'Johnson', '1998-03-10');

-- Insert data into Sale table
INSERT INTO Sale (NumItems, TotalPrice, DiscountPrice, CustomerId, DateOfPurchase) VALUES
    (2, 1999.98, 100.00, 1, '2024-02-01'),
    (1, 499.99, NULL, 2, '2024-02-02'),
    (3, 2399.97, 200.00, 3, '2024-02-03');