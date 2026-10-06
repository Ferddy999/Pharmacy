USE PharmacySystem;
CREATE TABLE Receipts (
    ReceiptID INT PRIMARY KEY IDENTITY(1,1),
    BatchID INT NOT NULL,
    Quantity INT NOT NULL,
    ReceiptDate DATE NOT NULL,
    FOREIGN KEY (BatchID) REFERENCES Batches(BatchID)
);