use AdventureWorks2019;

-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(*) AS "Num Of Products"
FROM Production.Product;

-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(*) AS "Num Of Products Have Subcategory"
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;

-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.

--    | ProductSubcategoryID | CountedProducts |
--    | -------------------- | --------------- |
--    |                      |                 |
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID;

-- 4. How many products that do not have a product subcategory.
SELECT COUNT(*) AS "Num Of Products Without Subcategory"
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

-- 5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS "All Products Quantity"
FROM Production.ProductInventory;

-- 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

--      | ProductID | TheSum |
--      | --------- | ------ |
--      |           |        |
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

--    | Shelf | ProductID | TheSum |
--    | ----- | --------- | ------ |
--    |       |           |        |
SELECT ProductID, Shelf, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) < 100;

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) AS AvgOfQuantity
FROM Production.ProductInventory
WHERE LocationID = 10;

-- 9. Write query to see the average quantity of products by shelf from the table Production.ProductInventory

--    | ProductID | Shelf | TheAvg |
--    | --------- | ----- | ------ |
--    |           |       |        |
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf;

-- 10. Write query to see the average quantity of products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

--     | ProductID | Shelf | TheAvg |
--     | --------- | ----- | ------ |
--     |           |       |        |
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf;

-- 11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

--     | Color | Class | TheCount | AvgPrice |
--     | ----- | ----- | -------- | -------- |
--     |       |       |          |          |
SELECT Color, Class, COUNT(*) AS TheCount, SUM(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

-- ## Joins:

-- 12. Write a query that lists the country and province names from Person.CountryRegion and Person.StateProvince tables. Join them and produce a result set similar to the following.

--     | Country | Province |
--     | ------- | -------- |
--     |         |          |

SELECT DISTINCT pc.Name AS Country, ps.Name AS Province
FROM Person.CountryRegion pc INNER JOIN
Person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode;

-- 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

--     | Country | Province |
--     | ------- | -------- |
--     |         |          |

SELECT DISTINCT pc.Name AS Country, ps.Name AS Province
FROM Person.CountryRegion pc INNER JOIN
Person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode
WHERE pc.Name IN ('Canada', 'Germany');

-- ## Using Northwnd Database: (Use aliases for all the Joins)
use Northwind;

-- 14. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductID, p.ProductName
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
INNER JOIN Products p ON od.ProductID = p.ProductID
WHERE DATEDIFF(year, o.OrderDate, GETDATE()) <= 25;

-- 15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS SoldCount
FROM Orders
WHERE ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode
ORDER BY SoldCount DESC;

-- 16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS SoldCount
FROM Orders
WHERE ShipPostalCode IS NOT NULL AND DATEDIFF(year, OrderDate, GETDATE()) <= 25
GROUP BY ShipPostalCode
ORDER BY SoldCount DESC;

-- 17. List all city names and number of customers in that city.   
-- 18. List city names which have more than 2 customers, and number of customers in that city
-- 19. List the names of customers who placed orders after 1/1/98 with order date.
-- 20. List the names of all customers with most recent order dates
-- 21. Display the names of all customers along with the count of products they bought
-- 22. Display the customer ids who bought more than 100 Products with count of products.
-- 23. List all of the possible ways that suppliers can ship their products. Display the results as below

--     | Supplier Company Name | Shipping Company Name |
--     | --------------------- | --------------------- |
--     |                       |                       |

-- 24. Display the products order each day. Show Order date and Product Name.
-- 25. Displays pairs of employees who have the same job title.
-- 26. Display all the Managers who have more than 2 employees reporting to them.
-- 27. Display the customers and suppliers by city. The results should have the following columns

--     - City
--     - Name
--     - Contact Name
--     - Type (Customer or Supplier)
