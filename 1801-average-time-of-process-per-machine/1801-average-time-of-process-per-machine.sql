# Write your MySQL query statement below
-- time to complete process = end - start (timestamp)
-- avg time = total time every process / no of processes
Select A1.MAchine_Id ,Round(AVG( A2.Timestamp - A1.Timestamp),3 ) As Processing_Time From Activity A1 , Activity A2 -- Activity1 for start and Activity2 for end 
Where A1.Machine_Id = A2.Machine_Id And A1.Process_ID = A2.Process_ID And A1.Activity_Type = 'start' And A2.Activity_Type = 'end' Group By Machine_Id