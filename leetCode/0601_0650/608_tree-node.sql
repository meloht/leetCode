select id,'Root' as type from Tree where p_id is null
union
select b.p_id,'Inner'as type from Tree a inner join Tree b on a.id=b.p_id where a.p_id is not null group by b.p_id
union
select a.id ,'Leaf' as type from Tree a left join Tree b on a.id=b.p_id where b.id is null and a.p_id is not null