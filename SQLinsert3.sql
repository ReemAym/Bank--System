CREATE PROC BeanchAdd
@Braddress varchar(1024),
@Brnum int,
@Brcode int,
@Aid int

as
insert into BRANCH(ADDRESS,BRANCHNUM,CODE,AID)
values (@Braddress,@Brnum,@Brcode,@Aid)