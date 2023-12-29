

select  a.name as Customers from customers a where a.id not in(select customerId from orders)