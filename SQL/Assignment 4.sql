-- Assignment 4

--1,2,3 tables misssing data


--4. Write a query to get most expense and least expensive Product list (name and unit price).

with cte_max(UnitPrice) as (
	select max(UnitPrice) as UnitPrice from Product
),
cte_min(UnitPrice) as (
	select min(UnitPrice) as UnitPrice from Product
)
select ProductName, UnitPrice from Product 
where UnitPrice in ( (select * from cte_max), (select * from cte_min))

--5. Display the list of products that are out of stock

select * from Product where isDiscontinued = 1

--6,7 missing data for supplier and stock

--8. Display complete list of customers, the OrderID and date of any orders they have made
select c.*, o.Id, OrderDate from Customer c
inner join [Order] o
on o.CustomerId = c.Id
order by c.Id

--9. Write  query that determines the customer who has placed the maximum number of orders
select * from Customer
where Id in (
select top(1) CustomerId 
from [Order]
group by CustomerId 
order by Count(*) desc )

--10. Display the customerid whose name has substring ‘RA’

select Id from Customer
where FirstName like '%ra%'


--11.Display the first word of all the company name
--there is no company name column so i am doing for firstname in customer table

select substring(FirstName,1,1) from Customer






