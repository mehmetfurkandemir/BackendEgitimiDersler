--1
SELECT ProductName, UnitPrice
FROM Products

--2

SELECT CompanyName, City
FROM Customers
ORDER BY CompanyName, City

--3

SELECT CONCAT(FirstName, ' ', LastName) AS FullName
FROM Employees

--4

SELECT ProductName, UnitsInStock
FROM Products
WHERE UnitsInStock < 10

--5

SELECT *
FROM Orders
WHERE YEAR(OrderDate) = 1998

--6

SELECT C.CategoryName, COUNT(P.ProductID) AS ProductCount
FROM Categories C
LEFT JOIN Products P ON C.CategoryID = P.CategoryID
GROUP BY C.CategoryName

--7

SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC
 
--8

SELECT Country, COUNT(CustomerID) AS CustomerCount
FROM Customers
GROUP BY Country
ORDER BY CustomerCount DESC

--9 

SELECT *
FROM Orders
WHERE Freight > 50

--10

SELECT E.FirstName, E.LastName, COUNT(O.OrderID) AS TotalOrders
FROM Employees E
LEFT JOIN Orders O ON E.EmployeeID = O.EmployeeID
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY TotalOrders DESC

--11

SELECT P.ProductName, C.CategoryName
FROM Products P
JOIN Categories C ON P.CategoryID = C.CategoryID

--12

SELECT O.OrderID, SUM(OD.UnitPrice * OD.Quantity) AS TotalAmount
FROM Orders O
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY O.OrderID

--13

SELECT TOP 5 P.ProductName, SUM(OD.Quantity) AS TotalSold
FROM Products P
JOIN OrderDetails OD ON P.ProductID = OD.ProductID
GROUP BY P.ProductID, P.ProductName
ORDER BY TotalSold DESC

--14

SELECT C.CompanyName, COUNT(O.OrderID) AS TotalOrders
FROM Customers C
LEFT JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName
ORDER BY TotalOrders DESC

--15

SELECT S.CompanyName, COUNT(O.OrderID) AS TotalOrders
FROM Orders O
JOIN Shippers S ON O.ShipVia = S.ShipperID
GROUP BY S.ShipperID, S.CompanyName

--16

SELECT E.EmployeeID, E.FirstName, E.LastName, SUM(OD.UnitPrice * OD.Quantity) AS TotalSales
FROM Employees E
JOIN Orders O ON E.EmployeeID = O.EmployeeID
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY TotalSales DESC

--17 

SELECT C.CategoryName, AVG(P.UnitPrice) AS AveragePrice
FROM Categories C
JOIN Products P ON C.CategoryID = P.CategoryID
GROUP BY C.CategoryName

--18

SELECT C.CompanyName, COUNT(O.OrderID) AS TotalOrders
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName
HAVING COUNT(O.OrderID) >= 5

--19

SELECT C.Country, SUM(OD.UnitPrice * OD.Quantity) AS TotalSales
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY C.Country

--20

SELECT YEAR(O.OrderDate) AS OrderYear, MONTH(O.OrderDate) AS OrderMonth, SUM(OD.UnitPrice * OD.Quantity) AS TotalSales
FROM Orders O
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY YEAR(O.OrderDate), MONTH(O.OrderDate)
ORDER BY OrderYear, OrderMonth