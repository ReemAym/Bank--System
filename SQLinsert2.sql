CREATE PROC EmployeeSignUp
@Eid int,
@Efirstname varchar(250),
@Elastname varchar(250),
@Ebranchnum int,
@Eusername varchar(250),
@Epassword varchar(250)

as
insert into EMPLOYEE(EID,EFIRSTNAME,ELASTNAME,BRANCHNUM,EUserName,EPassword)
values (@Eid,@Efirstname,@Elastname,@Ebranchnum,@Eusername,@Epassword)
