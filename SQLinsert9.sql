CREATE PROC RequestLoan
@loannum int,
@amount double precision,
@type varchar(250),
@ssn int

as
insert into LOAN(LOANNUMBER,LOANAMOUNT,LOANTYPE)
values (@loannum,@amount,@type)

insert into TAKES (SSN,LOANNUMBER) 
values(@ssn , @loannum)