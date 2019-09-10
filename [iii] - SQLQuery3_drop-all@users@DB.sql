USE master;
GO
ALTER DATABASE "ChoixResto.Models.BddContextTest"
SET SINGLE_USER 
WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE "ChoixResto.Models.BddContextTest";

//https://stackoverflow.com/questions/7469130/cannot-drop-database-because-it-is-currently-in-use