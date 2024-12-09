


select a.name,b.balance from Users a inner join (
select account,sum(amount) as balance  
	from Transactions 
	group by account 
	having(sum(amount)>10000)) b on a.account=b.account