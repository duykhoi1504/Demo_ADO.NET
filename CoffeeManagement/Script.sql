USE CoffeeShopManagement
GO

CREATE PROC uspAddProduct
	@id VARCHAR(10),
	@name NVARCHAR(100),
	@price FLOAT,
	@discount FLOAT,
	@categoryID INT,
	@image VARBINARY(MAX)
AS
BEGIN
	INSERT INTO Product(id, [name], price, discount, categoryID, [image]) VALUES(@id, @name, @price, @discount, @categoryID, @image);
END
GO