CREATE PROC AddAccount
@accountnum int,
@balance double precision,
@type varchar(250),
@ssn int,
@empid int,
@branchnum int


as
insert into ACCOUNT(ACCOUTNUMBER,BALANCE,TYPE,BRANCHNUM)
values (@accountnum,@balance,@type,@branchnum)

insert into OPENS(SSN,ACCOUTNUMBER)
values (@ssn,@accountnum)

insert into DEALS_WITH (EID,SSN)
values (@empid,@ssn)
