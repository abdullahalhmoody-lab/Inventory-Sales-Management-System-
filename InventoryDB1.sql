CREATE DATABASE InventoryDB1;
GO

USE InventoryDB1;
GO

/* ===========================
    1) ÃœÊ· «·√œÊ«— («·’·«ÕÌ« )
   =========================== */
CREATE TABLE Roles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Roles (RoleName)
VALUES ('Admin'), ('Manager'), ('Sales'), ('User');
GO


/* =============================
    2) ÃœÊ· «·„ÊŸ›Ì‰ (Users)
   ============================= */
CREATE TABLE Employees (
    EmpId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(200) NOT NULL,
    RoleId INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    State NVARCHAR(20) DEFAULT 'Active',
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
GO


/* =============================
    3) ÃœÊ· «·⁄„·«¡ (Customers)
   ============================= */
CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);
GO


/* =============================
    4) ÃœÊ· «·„‰ Ã«  (Products)
   ============================= */
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    BuyPrice DECIMAL(18,2) NOT NULL,
    SalePrice DECIMAL(18,2) NOT NULL,
    Quantity INT NOT NULL
);
GO


/* =============================
    5) ÃœÊ· «·›Ê« Ì— (Invoices)
   ============================= */
CREATE TABLE Invoices (
    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,
    InvoiceDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
GO


/* =============================
    6) ÃœÊ·  ›«’Ì· «·›Ê« Ì— (InvoiceItems)
   ============================= */
CREATE TABLE InvoiceItems (
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT NOT NULL,
    ProductId INT NOT NULL,
    Qty INT NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
GO


/* ====================================
    7) ÃœÊ· «·„” Œœ„Ì‰ · ”ÃÌ· «·œŒÊ·
       («Œ Ì«—Ì ≈–« ·„  ” Œœ„ Employees)
   ==================================== */
CREATE TABLE UsersLogin (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(200) NOT NULL,
    RoleId INT NOT NULL,
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
GO

INSERT INTO UsersLogin (Username, Password, RoleId)
VALUES ('admin', '1234', 1);
GO
