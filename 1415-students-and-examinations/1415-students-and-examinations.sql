# Write your MySQL query statement below
SELECT 
    S.student_id , S.student_name , Sub.subject_name , COALESCE(COUNT(Ex.student_id), 0) AS attended_exams
FROM 
    Students S 
    CROSS JOIN Subjects Sub
    LEFT JOIN Examinations Ex 
        ON S.student_id = Ex.student_id 
        AND Sub.subject_name = Ex.subject_name
GROUP BY 
    S.student_id, S.student_name, Sub.subject_name
ORDER BY 
    S.student_id, Sub.subject_name;
