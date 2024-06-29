-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.

-- Id Integer, Name (longtext), Int EmployerID

--Part 2: Write a query to list the names of the employers in St. Louis City.

-- SELECT name, FROM Employers, WHERE (location is going to equal "St.Louis City")

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

    -- SELECT Name, SkillName, FROM jobskill,INNER JOIN jobs ON jobs.Id = jobskill.JobsId,INNER JOIN skill ON skill.Id = jobskill.SkillsId, WHERE jobs.Id IS NOT NULL, ORDER BY SkillName;