CREATE PROC BankAdd
@Bname varchar(250),
@Bcode int,
@Baddress varchar(1024),
@adminId int

as
insert into BANK(NAME,CODE,ADDRESS,AID)
values (@Bname,@Bcode,@Baddress,@adminId)
