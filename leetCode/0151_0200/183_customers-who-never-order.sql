

select  a.name as Customers from customers a where a.id not in(select customerId from orders)


SELECT name AS 'Customers'
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId
WHERE Orders.CustomerId IS NULL

