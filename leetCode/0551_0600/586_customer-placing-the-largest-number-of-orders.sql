
select customer_number from (
select customer_number,count(*) as num from orders group by customer_number 
order by num desc limit 1) t;

SELECT
    customer_number
FROM
    orders
GROUP BY customer_number
ORDER BY COUNT(*) DESC
LIMIT 1
;
