
SELECT DATE_FORMAT(trans_date, '%Y-%m') AS month,
    country,
    COUNT(*) AS trans_count,
    COUNT(IF(state = 'approved', 1, NULL)) AS approved_count,
    SUM(amount) AS trans_total_amount,
    SUM(IF(state = 'approved', amount, 0)) AS approved_total_amount
FROM Transactions
GROUP BY month, country;


select aa.month, aa.country,aa.trans_count,
case when bb.approved_count is null then 0
else bb.approved_count end as approved_count,
aa.trans_total_amount,
case when bb.approved_total_amount is null then 0
else bb.approved_total_amount  end as approved_total_amount from
(select date_format(trans_date,'%Y-%m') as month ,country, count(*) as trans_count, sum(amount) as trans_total_amount  from Transactions group by country, date_format(trans_date,'%Y-%m')) aa 
left join 
(select date_format(trans_date,'%Y-%m') as month ,country, count(*) as approved_count, sum(amount) as approved_total_amount  from Transactions where state='approved' group by country, date_format(trans_date,'%Y-%m')) bb
on aa.month=bb.month and ((aa.country is not null and bb.country is not null and aa.country=bb.country) or (aa.country is  null and bb.country is  null))

