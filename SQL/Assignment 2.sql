
--1. Display the details from Customer table who is from Germany
select * from Customer where Country = 'Germany'
--OR
select * from Customer where Country like 'Germany'

--2. Display the fullname of Employee
-- no employee table given but I am doing for Customer table
select FirstName+' '+LastName as 'Full Name'
from Customer

--3. Display the customers details who has Fax Number
-- Here I am considering Phone as Fax Number in Customer Table
select * from Customer 
where Phone <> ''

--4. display the customer details whoes name holds second letter as U

select * from Customer where FirstName like '_u%'

--5.	select order Details where unit price is greater than 10 and less than 20


select * from [Order]
where Id in (select OrderId from OrderItem where UnitPrice between 10 and 20)

select * from OrderItem

--6. 6.	Display order details which contains shipping date and arrange the order by date
-- No table given for shipping date

--7.	Print the orders shipped by ship name 'La corne d'abondance' between 2 dates(Choose dates of your choice)
-- No table given for shipname

--8. No table given for Supplier

--9. print the average quantity ordered for every product

select (select ProductName from Product 
where Product.Id = OrderItem.ProductId) as Product_Name,
avg(Quantity) as Average_QTY from OrderItem
group by ProductId

-- 10 11 12 13 dont have the required tables