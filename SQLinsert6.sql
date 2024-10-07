CREATE PROC AdmainSignUp
@Afirstname varchar(250),
@Alastname varchar(250),
@Aid int,
@Ausername varchar(250),
@Apassword varchar(250)

as
insert into ADMIN(AID,AFIRSTNAME,ALASTNAME,AUserName,APassword)
values (@Aid,@Afirstname,@Alastname,@Ausername,@Apassword)