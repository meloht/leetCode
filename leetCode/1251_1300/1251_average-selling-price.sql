
select a.product_id, case when sum(COALESCE(b.units,0)) =0 then 0 else round(sum( COALESCE(b.units,0)*a.price)::numeric/sum(COALESCE(b.units,0)) ,2) end as average_price 
from Prices a left join UnitsSold b on 
a.product_id=b.product_id and b.purchase_date between a.start_date and a.end_date and b.units>0 
group by a.product_id