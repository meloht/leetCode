﻿
select a.project_id,round(avg(b.experience_years),2) as average_years from Project a inner join Employee b on a.employee_id=b.employee_id group by a.project_id