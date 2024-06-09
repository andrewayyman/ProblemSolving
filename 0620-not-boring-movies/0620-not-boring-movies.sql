/* Write your T-SQL query statement below */
Select *
From Cinema
Where id % 2 = 1
And Description != 'Boring'
order by rating desc