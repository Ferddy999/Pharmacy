USE PharmacySystem;

INSERT INTO Users (Username, PasswordHash, Role)
VALUES 
('stano', '123', 'Admin'),
('storemanager', '123', 'StoreManager'),
('dispenser', '123', 'Dispenser');
