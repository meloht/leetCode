
select a.product_id, case when sum(COALESCE(b.units,0)) =0 then 0 else round(sum( COALESCE(b.units,0)*a.price)::numeric/sum(COALESCE(b.units,0)) ,2) end as average_price 
from Prices a left join UnitsSold b on 
a.product_id=b.product_id and b.purchase_date between a.start_date and a.end_date and b.units>0 
group by a.product_id;


SELECT
    product_id,
    IFNULL(Round(SUM(sales) / SUM(units), 2), 0) AS average_price
FROM (
    SELECT
        Prices.product_id AS product_id,
        Prices.price * UnitsSold.units AS sales,
        UnitsSold.units AS units
    FROM Prices 
    LEFT JOIN UnitsSold ON Prices.product_id = UnitsSold.product_id
    AND (UnitsSold.purchase_date BETWEEN Prices.start_date AND Prices.end_date)
) T
GROUP BY product_id

