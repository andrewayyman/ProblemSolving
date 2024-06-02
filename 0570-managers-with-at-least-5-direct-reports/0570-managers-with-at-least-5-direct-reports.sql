# Write your MySQL query statement below
SELECT E1.name
FROM Employee E1 , Employee E2 
Where E1.id = E2.managerId
GROUP BY E1.id, E1.name
HAVING COUNT(E2.id) >= 5;
