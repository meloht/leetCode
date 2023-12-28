
SELECT num AS ConsecutiveNums
FROM (
  SELECT *, 
         @count := IF(@prev = num, @count + 1, 1) AS count, 
         @prev := num
  FROM Logs, (SELECT @count := 0, @prev := NULL) AS vars
  ORDER BY id
) AS tmp
WHERE count >= 3
GROUP BY num;


SELECT
    DISTINCT t.Num AS ConsecutiveNums
FROM
(
SELECT 
    CASE @pre WHEN Num THEN 
        @cnt := @cnt + 1
    ELSE @cnt := 1 END AS cnt,
    @pre := Num,
    Num
FROM
    Logs a,
    (SELECT @cnt := 1, @pre := '') b
) t WHERE t.cnt >= 3