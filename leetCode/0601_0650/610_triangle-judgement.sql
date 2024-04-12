select x,y,z ,
case 
when x>=y+z then 'No'
when y>=x+z then 'No'
when z>=y+x then 'No'
else
'Yes'
end as triangle
   from Triangle


SELECT 
    x,
    y,
    z,
    CASE
        WHEN x + y > z AND x + z > y AND y + z > x THEN 'Yes'
        ELSE 'No'
    END AS 'triangle'
FROM
    triangle
;

