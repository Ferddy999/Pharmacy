-- Use the PharmacySystem database
USE PharmacySystem;

-- 1. Insert into Drugs (independent table)
INSERT INTO Drugs (DrugCode, Name, Description)
VALUES 
('DRG001', 'Paracetamol', 'Pain reliever and fever reducer'),
('DRG002', 'Amoxicillin', 'Antibiotic for bacterial infections'),
('DRG003', 'Ibuprofen', 'Nonsteroidal anti-inflammatory drug');

-- 2. Insert into Users (independent table)
-- Note: Passwords are plain text here; hash them in a real system.
INSERT INTO Users (Username, PasswordHash, Role)
VALUES 
('admin', '123', 'Admin'),
('storemanager', '123', 'StoreManager'),
('dispenser', '123', 'Dispenser');

-- 3. Insert into Patients (independent table)
INSERT INTO Patients (Name, ContactInfo)
VALUES 
('stano handy', 'star@gmail.e.com'),
('Jane Smith', 'jane@gmail.com'),
('Sharon Johnson', 'sharon@gmail.com');

-- 4. Insert into Batches (depends on Drugs)
-- Assuming DrugID 1 = DRG001, DrugID 2 = DRG002, DrugID 3 = DRG003
INSERT INTO Batches (DrugID, BatchNo, ExpiryDate, StoreQuantity, DispensingQuantity)
VALUES 
(1, 'BATCH001', '2025-12-31', 100, 0),  -- Paracetamol
(1, 'BATCH002', '2026-06-30', 50, 0),   -- Paracetamol
(2, 'BATCH003', '2025-11-30', 200, 0),  -- Amoxicillin
(3, 'BATCH004', '2026-01-15', 150, 0);  -- Ibuprofen

-- 5. Insert into Receipts (depends on Batches)
-- Assuming BatchID 1 = BATCH001, BatchID 2 = BATCH002, etc.
INSERT INTO Receipts (BatchID, Quantity, ReceiptDate)
VALUES 
(1, 100, '2025-06-01'),  -- Received 100 units of Paracetamol BATCH001
(2, 50, '2025-06-02'),   -- Received 50 units of Paracetamol BATCH002
(3, 200, '2025-06-03'),  -- Received 200 units of Amoxicillin BATCH003
(4, 150, '2025-06-04');  -- Received 150 units of Ibuprofen BATCH004

-- 6. Insert into IssuesToDispensing (depends on Batches)
-- Transfer quantities from store to dispensing area
INSERT INTO IssuesToDispensing (BatchID, Quantity, IssueDate)
VALUES 
(1, 20, '2025-06-05'),  -- Issued 20 units of Paracetamol BATCH001
(2, 10, '2025-06-06'),  -- Issued 10 units of Paracetamol BATCH002
(3, 50, '2025-06-07'),  -- Issued 50 units of Amoxicillin BATCH003
(4, 30, '2025-06-08');  -- Issued 30 units of Ibuprofen BATCH004

-- Update Batches table to reflect the transfers
UPDATE Batches SET StoreQuantity = StoreQuantity - 20, DispensingQuantity = DispensingQuantity + 20 WHERE BatchID = 1;
UPDATE Batches SET StoreQuantity = StoreQuantity - 10, DispensingQuantity = DispensingQuantity + 10 WHERE BatchID = 2;
UPDATE Batches SET StoreQuantity = StoreQuantity - 50, DispensingQuantity = DispensingQuantity + 50 WHERE BatchID = 3;
UPDATE Batches SET StoreQuantity = StoreQuantity - 30, DispensingQuantity = DispensingQuantity + 30 WHERE BatchID = 4;

-- 7. Insert into Sales (depends on Patients and Batches)
-- Assuming PatientID 1 = John Doe, BatchID 1 = BATCH001, etc.
INSERT INTO Sales (PatientID, BatchID, Quantity, Price, SaleDate)
VALUES 
(1, 1, 5, 10.00, '2025-06-10'),  -- Sold 5 units of Paracetamol to John Doe
(2, 3, 10, 15.00, '2025-06-11'), -- Sold 10 units of Amoxicillin to Jane Smith
(3, 4, 15, 20.00, '2025-06-12'); -- Sold 15 units of Ibuprofen to Alice Johnson

-- Update Batches table to reflect the sales
UPDATE Batches SET DispensingQuantity = DispensingQuantity - 5 WHERE BatchID = 1;
UPDATE Batches SET DispensingQuantity = DispensingQuantity - 10 WHERE BatchID = 3;
UPDATE Batches SET DispensingQuantity = DispensingQuantity - 15 WHERE BatchID = 4;