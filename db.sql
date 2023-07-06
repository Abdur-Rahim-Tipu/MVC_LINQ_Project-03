create database ProductDb
go
use ProductDb
go
-- Create the Products table
CREATE TABLE Products (
    ProductId INT PRIMARY KEY Identity,
	ProductName VARCHAR(100) NOT NULL,
	Category VARCHAR(50) NOT NULL,
    Price money NOT NULL,
	Stock INT NOT NULL,
    ManufacturerDate date NOT NULL,
	Picture Nvarchar(100) Not Null
)
go
-- Create the purchases table
CREATE TABLE purchases (
    purchaseId INT PRIMARY KEY Identity,
    PurchaseDate DATE NOT NULL,
    Quantity INT NOT NULL,
    Price money NOT NULL,
    ProductId INT REFERENCES products(ProductId)
)
go
-- Create the Customers table
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY Identity,
    CustomerName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    [address] VARCHAR(200) NOT NULL
)
go
-- Create the Sells table
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY Identity,
    CustomerId INT NOT NULL,
    ProductId INT NOT NULL,
	Price money Not Null,
    Quantity INT NOT NULL,
    OrderDate DATE NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)
GO
--  For Products table
CREATE PROCEDURE SpSelectAllProducts
AS
BEGIN TRY
	SELECT * FROM Products
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SelectSingleProduct @i int
AS
BEGIN TRY
	SELECT * FROM Products
	where (ProductId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 50001
END CATCH
GO
CREATE PROC SpInsertProduct
							@n VARCHAR(100), 
							@c	VARCHAR(50) ,
							@p  money,
							@s int,
							@md date,
							@pic Nvarchar(100)
AS
BEGIN TRY
		INSERT INTO Products VALUES (@n,@c,@p, @s, @md, @pic)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER();
	THROW @en, @em, 50001
END CATCH

GO
CREATE PROC SpEditProduct
							@i int,
							@n VARCHAR(100), 
							@c	VARCHAR(50) ,
							@p  money,
							@s int,
							@md date,
							@pic Nvarchar(100)
AS
BEGIN TRY
		update Products  set  ProductName = @n,Category = @c, Price = @p,Stock= @s , ManufacturerDate=@md,Picture= @pic where (ProductId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH

GO
CREATE PROC SpdeleteProduct
							@i int
AS
BEGIN TRY
		delete from Products where ProductId = @i
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
--  For Customers table
CREATE PROCEDURE SpSelectAllCustomers
AS
BEGIN TRY
	SELECT * FROM Customers
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SpSelectSingleCustomer @i int
AS
BEGIN TRY
	SELECT * FROM Customers
	where (CustomerId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpInsertCustomer
							@n NVARCHAR(30), 
							@e	NVARCHAR(50) ,
							@p	NVARCHAR(50) ,
							@a	NVARCHAR(50) 
AS
BEGIN TRY
		INSERT INTO Customers VALUES (@n,@e, @p, @a)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpEditCustomer
							@i int,
							@n NVARCHAR(30), 
							@e	NVARCHAR(50) ,
							@p	NVARCHAR(50) ,
							@a	NVARCHAR(50) 
AS
BEGIN TRY
		update Customers  set  CustomerName = @n, Email = @e, PhoneNumber = @p, address=@a where (CustomerId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH

GO
CREATE PROC SpdeleteCustomer
							@i int
AS
BEGIN TRY
		delete from Customers where CustomerId = @i
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
--  For Orders table

CREATE TRIGGER TrInsertOrder
ON Orders
FOR INSERT
AS
BEGIN TRY
	DECLARE @id INT, @q INT
	SELECT @id=productid, @q=quantity FROM inserted
	UPDATE products SET Stock = Stock - @q
	WHERE productid = @id
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE TRIGGER TrEditOrder
ON Orders
FOR Update
AS
BEGIN TRY
	DECLARE @i INT, @oq INT, @nq INT
	SELECT @i=productid, @oq = quantity FROM deleted
	SELECT @nq = quantity FROM inserted
	UPDATE products SET Stock = Stock -(@nq-@oq)
	WHERE productid = @i
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE TRIGGER TrDeleteOrder
ON Orders
FOR Delete
AS
BEGIN TRY
	DECLARE @id INT, @q INT
	SELECT @id=productid, @q=quantity FROM deleted
	UPDATE products SET Stock = Stock + @q
	WHERE productid = @id
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SpSelectAllOrder
AS
BEGIN TRY
	SELECT * FROM Products p
join Orders o on p.ProductId = o.ProductId
join Customers c on c.CustomerId = o.CustomerId
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SpSelectSingleOrder @i int
AS
BEGIN TRY
	SELECT * FROM Orders
	where (OrderId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SpOrderWithPC @i int
AS
BEGIN TRY
		SELECT c.CustomerId, CustomerName, Email, PhoneNumber, address, p.ProductName, o.OrderDate, o.Price, Quantity, (o.Price * o.Quantity) as TotalPrice FROM Customers c
		join Orders o on c.CustomerId = o.CustomerId
		join Products p on p.ProductId = o.ProductId

	where (c.CustomerId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpInsertOrder
							@ci int, 
							@pi	int ,
							@p money,
							@q	int ,
							@od	date 
AS
BEGIN TRY
		Insert Into Orders Values(@ci, @pi, @p, @q, @od)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpEditOrder
							@i int,
							@ci int, 
							@pi	int ,
							@p money,
							@q	int ,
							@od	date 
AS
BEGIN TRY
		Update Orders Set CustomerId = @ci, ProductId =@pi, Price = @p, Quantity = @q, OrderDate = @od where (OrderId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpDeleteOrder
							@i int
AS
BEGIN TRY
		Delete Orders where (OrderId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
--  For purchases table
CREATE TRIGGER TrInsertpurchase
ON purchases
FOR INSERT
AS
BEGIN TRY
	DECLARE @id INT, @q INT
	SELECT @id=productid, @q=quantity FROM inserted
	UPDATE products SET Stock = Stock + @q
	WHERE productid = @id
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE TRIGGER TrEditpurchase
ON purchases
FOR Update
AS
BEGIN TRY
	DECLARE @i INT, @oq INT, @nq INT
	SELECT @i=productid, @oq = quantity FROM deleted
	SELECT @nq = quantity FROM inserted
	UPDATE products SET Stock = Stock -(@nq-@oq)
	WHERE productid = @i
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE TRIGGER TrDeletepurchase
ON purchases
FOR Delete
AS
BEGIN TRY
	DECLARE @id INT, @q INT
	SELECT @id=productid, @q=quantity FROM deleted
	UPDATE products SET Stock = Stock - @q
	WHERE productid = @id
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SpSelectAllpurchases
AS
BEGIN TRY
	SELECT * FROM Products p
join purchases pc on p.ProductId = pc.ProductId
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpInsertpurchase
							@pd	date ,
							@q	int ,
							@p	money,
							@pi int
AS
BEGIN TRY
		Insert Into purchases Values( @pd, @q, @p, @pi)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpEditpurchase
							@i int,
							@pd	date ,
							@q	int ,
							@p	money,
							@pi int
AS
BEGIN TRY
		Update purchases Set PurchaseDate = @pd, Quantity = @q,Price=@p,  ProductId = @pi where (purchaseId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROC SpDeletepurchase
							@i int
AS
BEGIN TRY
		Delete purchases where (purchaseId = @i)
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
CREATE PROCEDURE SPAlldata @i int
AS
BEGIN TRY
	SELECT * FROM Products p
	join Orders o on p.ProductId = o.ProductId
	join Customers c on c.CustomerId = o.CustomerId
	join purchases pc on p.Price = pc.ProductId
END TRY
BEGIN CATCH
	DECLARE @em NVARCHAR(50), @en INT
	SELECT @em = ERROR_MESSAGE(), @en = ERROR_NUMBER()
	;
	THROW @en, @em, 1
END CATCH
GO
