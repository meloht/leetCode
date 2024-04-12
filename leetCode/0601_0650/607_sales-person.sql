
select name from SalesPerson where sales_id not in(
 select b.sales_id from Company a inner join Orders b on a.com_id=b.com_id
 inner join SalesPerson c on c.sales_id=b.sales_id
 where a.name= 'RED')