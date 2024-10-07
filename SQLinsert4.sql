CREATE PROC CustomerSignUp
@ssn int,
@Cusername varchar(250),
@Cpassword varchar(250)

as
Update CUSTOMER
set UserName= @Cusername ,Password= @Cpassword
where CUSTOMER.SSN = @ssn
