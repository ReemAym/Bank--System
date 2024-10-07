CREATE PROC CustomerAdd
@ssn int,
@Cfirstname varchar(250),
@Clastname varchar(250),
@Cphone varchar(250),
@Caddress varchar(1024),
@employeenum int

as
insert into CUSTOMER(SSN,FIRSTNAME,SECONDNAME,ADDRESS,PHONE)
values (@ssn,@Cfirstname,@Clastname,@Caddress,@Cphone)

insert into DEALS_WITH (EID,SSN)
values (@employeenum,@ssn)

