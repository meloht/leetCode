

DELETE p1 FROM Person p1,
    Person p2
WHERE
    p1.Email = p2.Email AND p1.Id > p2.Id

    delete from person where id not in (
    select id from (
        select min(id) as id from person group by email
    ) as tmp
)