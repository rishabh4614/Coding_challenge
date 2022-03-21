
--create database EmployeeManagement;

--create table Code_Employee
--(empno int primary key,
--empname varchar(50) not null,
--empsal numeric(10,2) check(empsal >=25000),
--emptype varchar(1) check(emptype in ('C','P')))

	
--insert into Code_Employee
--values 
--(10,'Rishabh',26000,'C'),
--		(20,'Raksesh',26000,'P'),
--		(30,'Ramesh',27300,'C'),
--		(40,'Priya',30000,'C');
	
--select * from Code_Employee


--Creating Procedure

CREATE PROCEDURE InsertData
@EmpNO int,
@EmpName varchar(50),
@EmpSal numeric(10,2),
@EmpType varchar(1)

AS
BEGIN
	INSERT INTO Code_Employee (EmpNO, EmpName, EmpSal, EmpType)
	VALUES (@EmpNO, @EmpName, @EmpSal, @EmpType)
END

--Inserting Data into Procedure
EXEC InsertData 50,NoName, 35000,P




