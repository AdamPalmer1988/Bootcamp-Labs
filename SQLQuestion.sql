--Question 1
select *
from Customers
Where Country = 'UK';

--Question 2
select ProductName, UnitPrice
From Products
Where UnitPrice > 30;

--Question 3
select count(*)
From Products
Where Discontinued = 1;

--Find the average, maximum, and minimum unit prices from the Products table.
select avg(UnitPrice) as 'Average', max(UnitPrice) as 'Max', min(UnitPrice) as 'Min'
from Products;

--Retrieve the names of categories and the count of products in each category from the Categories and Products tables.
select Categories.CategoryName, count(ProductID)  
from Products
Join Categories On Products.CategoryID = Categories.CategoryID
Group By Categories.CategoryName;

--List the suppliers (SupplierID and CompanyName) from the Suppliers table who
--are not from USA, Germany, or UK.

select SupplierID, CompanyName
from Suppliers 
Where Country NOT IN ('USA', 'Germany', 'UK'); 

--Retrieve all the distinct countries from the Customers table.

select distinct Country
From Customers;

--Find the top 5 most expensive products (Product name and Unit price) from the Products table.
select Top 5 *
from Products
Order By UnitPrice DESC
 
--Using the Orders and Order Details tables, calculate the total revenue for each order (OrderID).
select Orders.OrderID, sum((UnitPrice * Quantity) - Discount) 
from Orders
Join [Order Details] On Orders.OrderID = [Order Details].OrderID
Group By Orders.OrderID

--List all employees (FirstName and LastName) and the count of orders they have taken from the 
--Employees and Orders tables
select Employees.EmployeeID, FirstName, LastName, count(Employees.EmployeeID) AS 'NumberOfOrders'
from Employees
Join Orders On Employees.EmployeeID = Orders.EmployeeID
Group By Employees.EmployeeID, FirstName, LastName

--Retrieve customers (CustomerID and CompanyName) who have placed more than 10 orders using the 
--Customers and Orders tables.
select Customers.CustomerID, CompanyName, count(Customers.CustomerID) as 'NumberOfCustomerOrders'
from Customers
Join Orders On Customers.CustomerID = Orders.CustomerID
Group By Customers.CustomerID, CompanyName
Having count(Customers.CustomerID) > 10

--12. From the Products table, retrieve the names of products that are out of stock
--(units in stock is 0).

select ProductName
From Products
Where UnitsInStock = 0;

--13. Using the Products and Categories tables, list the names of products and their
--respective categories where the category is either 'Beverage' or 'Confectionery'

select ProductName, CategoryName
from Products
Join Categories On Products.CategoryID = Categories.CategoryID
Where CategoryName in ('Beverages', 'Confections')

--14. Identify which supplier (SupplierID and CompanyName from Suppliers table) has
--the highest number of products in the Products table.

select Suppliers.SupplierID, CompanyName, UnitsInStock
from Suppliers
Join Products On Suppliers.SupplierID = Products.SupplierID
Order By UnitsInStock DESC

--15. List all the products (ProductID and ProductName) which have never been
--ordered. Use the Products and Order Details tables.

select Products.ProductID, ProductName, count([Order Details].ProductID) 
from Products
Join [Order Details] On Products.ProductID = [Order Details].ProductID
Group By Products.ProductID, ProductName 
Having count([Order Details].ProductID) = 0

--Retrieve all orders (OrderID from Orders table) that were placed in December 1997.

select OrderID, OrderDate 
from Orders
Where OrderDate >= '1997-12-01' and OrderDate <= '1997-12-31';

--17. Using the Employees and Orders tables, find out which employee has processed the
--most number of orders in 1998.

select FirstName, LastName, count(Orders.EmployeeID) AS 'NumberOfOrders'
from Employees
Join Orders on Employees.EmployeeID = Orders.EmployeeID
Group By FirstName, LastName
Order By count(Orders.EmployeeID) DESC

--18. Find the customer (CustomerID and CompanyName from Customers table) who
--has purchased the most by quantity in the Order Details table.

select Customers.CustomerID, CompanyName, sum(Quantity)
from Customers
Join Orders On Customers.CustomerID = Orders.CustomerID
Join [Order Details] On Orders.OrderID = [Order Details].OrderID
Group By Customers.CustomerID, CompanyName
Order By sum(Quantity) DESC

--19. From the Shippers and Orders tables, determine which shipper has delivered the
--most number of orders

select ShipperID, CompanyName, count(ShipperID)
from Shippers
Join Orders on Shippers.ShipperID = Orders.ShipVia
Group By ShipperID, CompanyName
Order By count(ShipperID) DESC

--20. Identify the top 3 categories in terms of the number of products they have using
--the Categories and Products tables.

select Top 3 CategoryName, count(ProductID) as 'NumberOfProducts'
from Categories
Join Products On Categories.CategoryID = Products.CategoryID
Group By CategoryName
Order By count(ProductID) DESC




