
-- Queries 1-4
--Creating Table Customer
CREATE TABLE Customer (
Id int PRIMARY KEY,
FirstName nvarchar(40) NOT NULL,
LastName nvarchar(40),
City nvarchar(40),
Country nvarchar(40),
Phone nvarchar(20)
);

--Creating Table Order
CREATE TABLE [Order] (
Id int PRIMARY KEY,
OrderDate datetime NOT NULL,
OrderNumber nvarchar(10),
CustomerId int,
TotalAmount decimal(12, 2)
);

--Creating Table Product
CREATE TABLE Product (
Id int PRIMARY KEY,
ProductName nvarchar(50),
UnitPrice decimal(12, 2),
Package nvarchar(30),
isDiscontinued bit
);

--Creating Table OrderItem
CREATE TABLE OrderItem (
Id int PRIMARY KEY,
OrderId int FOREIGN KEY REFERENCES [Order](Id),
ProductId int FOREIGN KEY REFERENCES Product(Id),
UnitPrice decimal(12, 2),
Quantity int
);

--adding foreign key reference contraint in Orders table using query
alter table [Order]
add foreign key (CustomerId)
references Customer(Id)

--Insert Records into Customer
INSERT INTO Customer (Id,FirstName, LastName,City,Country,Phone)
Values(1, 'Akshat', 'Jain', 'Delhi', 'India', '8378373783'),
(2, 'Deepak', 'Arora', 'Tokyo', 'Japan', ''),
(3, 'Bhavesh', 'Garg', 'Paris', 'Germany', '783737834'),
(4, 'Ruhin', '', 'Buenos', 'Argentina', '25488768'),
(5, 'Michael', '', 'New York', 'USA', ''),
(6, 'Jimmy', 'Anderson', 'London', 'England', ''),
(7, 'David', 'Warner', 'Sydney', 'Australia', ''),
(8, 'Griffin', 'Root', 'Madrid', 'Spain', '786131357')


--Insert Records into Order

INSERT INTO [Order] Values(1, '2022-08-12 12:00:00', '001', 2, 110)
INSERT INTO [Order] Values(2, '2021-09-24 23:05:00', '002', 1, 240)
INSERT INTO [Order] Values(3, '2020-01-02 08:10:00', '003', 5, 88)
INSERT INTO [Order] Values(4, '2022-02-01 11:15:00', '004', 7, 150)
INSERT INTO [Order] Values(5, '2020-03-10 15:00:00', '005', 3, 100)
INSERT INTO [Order] Values(6, '2020-03-10 15:00:00', '005', 4, 50)


--Insert Records into Product
INSERT INTO Product Values(1, 'Tshirt', 18, '',null);
INSERT INTO Product Values(2, 'Bottle', 25, '',null);
INSERT INTO Product Values(3, 'Mobile Cover', 12, '',null);
INSERT INTO Product Values(4, 'Mouse Pad', 8, '',null);

--Insert Records into OrderItem
INSERT INTO OrderItem Values(1, 3, 2, NULL, 10)
INSERT INTO OrderItem Values(2, 4, 1, NULL, 2)
INSERT INTO OrderItem Values(3, 6, 3, NULL, 5)
INSERT INTO OrderItem Values(4, 2, 2, NULL, 20)
INSERT INTO OrderItem Values(5, 1, 2, NULL, 35)
INSERT INTO OrderItem Values(6, 2, 4, NULL, 10)



--5. Display all Costumer details
select * from Customer

--6. Write a query to display Country whose name starts with A or I
select Country from Customer where Country like '[AI]%'

--7. Write a query to display name of customers whose third letter is i.
select FirstName, LastName from Customer 
where FirstName like '__i%'



------------------------------------------------------------------

