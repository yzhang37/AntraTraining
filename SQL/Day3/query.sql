-- 1. List all cities that have both Employees and Customers.
-- Use Join
SELECT DISTINCT City
FROM Employees
INTERSECT
SELECT DISTINCT City
FROM Customers;
-- Use Subquery
SELECT DISTINCT c.City
FROM Customers c
WHERE EXISTS (
    SELECT 1
    FROM Employees e
    WHERE e.City = c.City 
);

-- 2. List all cities that have Customers but no Employee.
--     1. Use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE NOT EXISTS (
    SELECT 1
    FROM Employees e
    WHERE e.City = c.City 
);

--     2. Do not use sub-query
SELECT DISTINCT City
FROM Customers
EXCEPT
SELECT DISTINCT City
FROM Employees;

-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS "Total quantities"
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName;

-- 4. List all Customer Cities and total products ordered by that city.
SELECT o.ShipCity "Customer Cities", SUM(od.Quantity) "Total Products"
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.ShipCity IN (
    SELECT DISTINCT City
    FROM Customers
)
GROUP BY o.ShipCity;

-- 5. List all Customer Cities that have at least two customers.
--     1. Use union

-- This question is very strange. It shouldn't require a UNION since we can simply use
-- aggregate functions to determine the answer for "at least 2 customers".

SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*) = 1
UNION 
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*) = 2;

--     2. Use sub-query and no union
SELECT DISTINCT City
FROM Customers c1
WHERE (SELECT COUNT(*) FROM Customers c2 WHERE c1.City = c2.City) IN (1, 2);

-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) > 2;

-- 7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.


-- 8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.


-- 9. List all cities that have never ordered something but we have employees there.
--     1. Use sub-query


--     2. Do not use sub-query


-- 10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)


-- 11. How do you remove the duplicates record of a table?
