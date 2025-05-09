USE CoffeeShopManagement
GO

--==================PRODUCT==================--
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

CREATE PROC uspUpdateProduct
	@id VARCHAR(10),
	@name NVARCHAR(100),
	@price FLOAT,
	@discount FLOAT,
	@categoryID INT,
	@image VARBINARY(MAX)
AS
BEGIN
	UPDATE Product
	SET [name] = @name, price = @price, discount = @discount, categoryID = @categoryID, [image] = @image
	WHERE id = @id;
END
GO
--=================SUPPLIER==================--
CREATE PROC uspUpdateSupplier
	@id  Nchar(10),
	@name NVARCHAR(100),
	@address NVARCHAR(max)
AS
BEGIN
	UPDATE Supplier
	SET id = @id, [name] = @name,[address] = @address
	WHERE id = @id;
END
GO
--==================COUPON==================--
CREATE PROC uspUpdateCoupon
	@id VARCHAR(10),
	@description NVARCHAR(100),
	@value FLOAT
AS
BEGIN
	UPDATE Coupon
	SET id = @id, [description] = @description, [value] = @value
	WHERE id = @id;
END
GO

--==================ACCOUNT==================--
CREATE PROC uspAddAccount
	@username VARCHAR(50),
	@password VARCHAR(50),
	@role VARCHAR(10),
	@fullName NVARCHAR(100),
	@sex NVARCHAR(10),
	@dateOfBirth DATE,
	@address NVARCHAR(255),
	@phoneNumber VARCHAR(10)
AS
BEGIN
	INSERT INTO Account (username, [password], [role], fullName, sex, dateOfBirth, [address], phoneNumber) 
	VALUES(@username, @password, @role, @fullName, @sex, @dateOfBirth, @address, @phoneNumber);
END
GO

CREATE PROC uspUpdateAccount
	@id INT,
	@username VARCHAR(50),
	@password VARCHAR(50),
	@role VARCHAR(10),
	@fullName NVARCHAR(100),
	@sex NVARCHAR(10),
	@dateOfBirth DATE,
	@address NVARCHAR(255),
	@phoneNumber VARCHAR(10)
AS
BEGIN
	UPDATE Account
	SET username = @username, [password] = @password, [role] = @role, fullName = @fullName, sex = @sex, dateOfBirth = @dateOfBirth, [address] = @address, phoneNumber = @phoneNumber
	WHERE id = @id;
END
GO

--==================INGREDIENT==================--
CREATE PROC uspUpdateIngredient
	@id VARCHAR(10),
	@name NVARCHAR(100),
	@unit NVARCHAR(20),
	@quantity INT,
	@expirationDate DATE,
	@status NVARCHAR(20),
	@supplierID VARCHAR(20)
AS
BEGIN
	UPDATE Ingredient
	SET id = @id, [name] = @name, unit = @unit, quantity = @quantity, expirationDate = @expirationDate, [status] = @status, supplierID = @supplierID
	WHERE id = @id;
END
GO

--==================Stats==================--
--drop proc GetStatsByProduct
CREATE PROCEDURE GetStatsByProduct
    @Year varchar(20)
AS
BEGIN
    SELECT 
        i.productID, 
        p.name, 
        SUM(i.price * i.quantity) AS totalRevenue
    FROM 
        Item i
    JOIN 
        [Order] o ON i.orderID = o.id
    JOIN 
        [Product] p ON i.productID = p.id
    WHERE 
         YEAR(o.createdDate) = @Year
    GROUP BY 
        i.productID, p.name;
END
GO
--*******
--drop proc GetMonthlyRevenue
CREATE PROCEDURE GetMonthlyRevenue
    @Year Varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        MONTH(createdDate) AS Month, 
        SUM(totalPrice) AS TotalRevenue  
    FROM 
        [Order] 
    WHERE 
        YEAR(createdDate) = @Year
    GROUP BY 
        MONTH(createdDate) 
    ORDER BY 
        MONTH(createdDate);
END;
GO
--/////////////////////////////////////

CREATE PROCEDURE AddWorkday
    @AccountID INT,
    @ShiftID INT,
    @Date DATE
AS
BEGIN
    INSERT INTO Workday(accountID, shiftID, date)
    VALUES (@AccountID, @ShiftID, @Date);
END;
GO


CREATE PROC UpdateWorkday

    @date DATE,
	@isChecked BIT
AS
BEGIN
    UPDATE Workday
	SET isChecked = @isChecked
	WHERE date = @date;
END;
GO

CREATE PROC GetWorkDayByAccountID
    @AccountID int
AS
BEGIN
SELECT date,s.name,s.time,w.accountID, w.isChecked
from Workday w
JOIN Shift s on w.shiftID = s.id
Where w.accountID=@AccountID
END;
GO


--/////tính lương

CREATE PROC CalSalaryByAccIDAndDate
	@accountID INT ,
    @month INT  ,
	 @year INT 
	 AS
BEGIN
SELECT 
   
    SUM(s.wage) AS totalSalary
FROM 
    Workday w
JOIN 
    Shift s ON w.shiftID = s.id
WHERE 
	w.accountID=@accountID
    AND MONTH(w.date) = @month
    AND YEAR(w.date) = @year
    AND w.isChecked = 1
END;
GO

