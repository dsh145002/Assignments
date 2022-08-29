----------Assignment 3--------------

--Tables - Customer, Order, OrderItem, Prodcut created in Assignment 1

select * from Customer
select * from [Order]
select * from OrderItem
select * from Product

--1. write a query to display the orders placed by customer with phone number 030-0074321

--using subquery
select * from [Order] where CustomerId = (select Id from Customer where
Phone = '030-0074321')


--using joins
select [Order].* from Customer
inner join [Order]
on Customer.Id = [Order].CustomerId
where Customer.Phone = '030-0074321'

----------------------------------------------------------

--3. Display the orders placed by customers not in London

--using joins
select [Order].* from Customer
inner join [Order]
on Customer.Id = [Order].CustomerId
where Customer.City not like 'london'

-- OR using subquery
select * from [Order] where
CustomerId in (select Id from Customer
where City not like 'London')

--------------------------------------------------------

--4.  selects all the order which are placed for the product Chai.

-- subquery
select * from [Order] where Id in (select OrderId from OrderItem where
ProductId = (select Id from Product where ProductName = 'Chai'))

-- joins
select [Order].* from Product 
join OrderItem 
on Product.Id = OrderItem.ProductId
join [Order]
on OrderItem.OrderId = [Order].Id
where ProductName = 'Chai'

-- for 2nd there was no table which had catergory column
-- for 5th there was no table which has employee details
