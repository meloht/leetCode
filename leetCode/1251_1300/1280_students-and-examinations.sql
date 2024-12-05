

select tt.student_id,tt.student_name,tt.subject_name ,sum(case when b.subject_name is null then 0 else 1 end) as attended_exams from 
(select a.student_id,a.student_name, b.subject_name from Students a , Subjects b ) tt left join Examinations b on tt.student_id=b.student_id and tt.subject_name=b.subject_name 
 group by tt.student_id,tt.subject_name order by tt.student_id