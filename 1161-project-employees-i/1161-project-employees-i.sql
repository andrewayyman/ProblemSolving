# Write your MySQL query statement below
Select p.project_id , Round( AVG( e.experience_years ) , 2 ) as 'average_years'
From Employee e , Project p
Where e.employee_id = p.employee_id
group by p.project_id

