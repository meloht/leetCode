

select b.score,t2.`rank` from (select score , RANK() OVER(ORDER BY score DESC) AS `rank` from ( select score from scores group by score ) t ) t2 
inner join scores b on t2.score=b.score order by  b.score desc

SELECT
  S.score,
  DENSE_RANK() OVER (
    ORDER BY
      S.score DESC
  ) AS 'rank'
FROM
  Scores S;
  
  
  SELECT
  S1.score,
  (
    SELECT
      COUNT(DISTINCT S2.score)
    FROM
      Scores S2
    WHERE
      S2.score >= S1.score
  ) AS 'rank'
FROM
  Scores S1
ORDER BY
  S1.score DESC;
