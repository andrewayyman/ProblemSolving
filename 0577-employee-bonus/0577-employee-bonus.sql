# Write your MySQL query statement below

Select 
    E.name , B.bonus
From 
    Employee E left join Bonus B 
On 
    E.empId = B.empId
Where
    B.bonus < 1000 or 
    B.Bonus Is Null
