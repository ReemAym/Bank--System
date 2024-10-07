/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/26/2022 9:56:24 PM                         */
/*==============================================================*/

use BankSystem;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_HAS_BRANCH')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_HAS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK') and o.name = 'FK_BANK_CREATES_ADMIN')
alter table BANK
   drop constraint FK_BANK_CREATES_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_APPENDS_ADMIN')
alter table BRANCH
   drop constraint FK_BRANCH_APPENDS_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_OWNS_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_OWNS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEALS_WITH') and o.name = 'FK_DEALS_WI_DEALS_WIT_EMPLOYEE')
alter table DEALS_WITH
   drop constraint FK_DEALS_WI_DEALS_WIT_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEALS_WITH') and o.name = 'FK_DEALS_WI_DEALS_WIT_CUSTOMER')
alter table DEALS_WITH
   drop constraint FK_DEALS_WI_DEALS_WIT_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_ADDS_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_ADDS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFERS_BRANCH')
alter table LOAN
   drop constraint FK_LOAN_OFFERS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPENS') and o.name = 'FK_OPENS_OPENS_CUSTOMER')
alter table OPENS
   drop constraint FK_OPENS_OPENS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPENS') and o.name = 'FK_OPENS_OPENS2_ACCOUNT')
alter table OPENS
   drop constraint FK_OPENS_OPENS2_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVES') and o.name = 'FK_SERVES_SERVES_BRANCH')
alter table SERVES
   drop constraint FK_SERVES_SERVES_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVES') and o.name = 'FK_SERVES_SERVES2_CUSTOMER')
alter table SERVES
   drop constraint FK_SERVES_SERVES2_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES_CUSTOMER')
alter table TAKES
   drop constraint FK_TAKES_TAKES_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES2_LOAN')
alter table TAKES
   drop constraint FK_TAKES_TAKES2_LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK')
            and   name  = 'CREATES_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK.CREATES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'APPENDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.APPENDS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.OWNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEALS_WITH')
            and   name  = 'DEALS_WITH2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEALS_WITH.DEALS_WITH2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEALS_WITH')
            and   name  = 'DEALS_WITH_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEALS_WITH.DEALS_WITH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEALS_WITH')
            and   type = 'U')
   drop table DEALS_WITH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'ADDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.ADDS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPENS')
            and   name  = 'OPENS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPENS.OPENS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPENS')
            and   name  = 'OPENS_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPENS.OPENS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPENS')
            and   type = 'U')
   drop table OPENS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVES')
            and   name  = 'SERVES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVES.SERVES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVES')
            and   name  = 'SERVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVES.SERVES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SERVES')
            and   type = 'U')
   drop table SERVES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAKES')
            and   type = 'U')
   drop table TAKES
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ACCOUTNUMBER         int                  not null,
   BRANCHNUM            int                  not null,
   BALANCE              double precision     not null,
   TYPE                 varchar(250)         not null,
   constraint PK_ACCOUNT primary key nonclustered (ACCOUTNUMBER)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on ACCOUNT (
BRANCHNUM ASC
)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   AFIRSTNAME           varchar(250)         not null,
   ALASTNAME            varchar(250)         not null,
   AID                  int                  not null,
   AUserName            varchar(250)         not null, 
   APassword            varchar(250)         not null,
   constraint PK_ADMIN primary key nonclustered (AID)
)
go


/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   NAME                 varchar(250)         not null,
   CODE                 int                  not null,
   AID                  int                  not null,
   ADDRESS              varchar(1024)        not null,
   constraint PK_BANK primary key nonclustered (CODE)
)
go

/*==============================================================*/
/* Index: CREATES_FK                                            */
/*==============================================================*/
create index CREATES_FK on BANK (
AID ASC
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   ADDRESS              varchar(1024)        not null,
   BRANCHNUM            int                  not null,
   CODE                 int                  not null,
   AID                  int                  not null,
   constraint PK_BRANCH primary key nonclustered (BRANCHNUM)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/
create index OWNS_FK on BRANCH (
CODE ASC
)
go

/*==============================================================*/
/* Index: APPENDS_FK                                            */
/*==============================================================*/
create index APPENDS_FK on BRANCH (
AID ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  int                  not null,
   ADDRESS              varchar(1024)        not null,
   PHONE                varchar(250)         not null,
   FIRSTNAME            varchar(250)         not null,
   SECONDNAME           varchar(250)         not null,
   UserName             varchar(250)         null,
   Password             varchar(250)         null,

   constraint PK_CUSTOMER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Table: DEALS_WITH                                            */
/*==============================================================*/
create table DEALS_WITH (
   EID                  int                  not null,
   SSN                  int                  not null,
   constraint PK_DEALS_WITH primary key (EID, SSN)
)
go

/*==============================================================*/
/* Index: DEALS_WITH_FK                                         */
/*==============================================================*/
create index DEALS_WITH_FK on DEALS_WITH (
EID ASC
)
go

/*==============================================================*/
/* Index: DEALS_WITH2_FK                                        */
/*==============================================================*/
create index DEALS_WITH2_FK on DEALS_WITH (
SSN ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EFIRSTNAME           varchar(250)         not null,
   EID                  int                  not null,
   BRANCHNUM            int                  not null,
   ELASTNAME            varchar(250)         not null,
   EUserName            varchar(250)         not null,
   EPassword            varchar(250)         not null,
   constraint PK_EMPLOYEE primary key nonclustered (EID)
)
go

/*==============================================================*/
/* Index: WORKS_FK                                              */
/*==============================================================*/
create index WORKS_FK on EMPLOYEE (
BRANCHNUM ASC
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANTYPE             varchar(250)         not null,
   LOANAMOUNT           double precision     not null,
   LOANNUMBER           int                  not null,
   EID                  int                  null,
   BRANCHNUM            int                  null,
   constraint PK_LOAN primary key nonclustered (LOANNUMBER)
)
go


/*==============================================================*/
/* Index: OFFERS_FK                                             */
/*==============================================================*/
create index OFFERS_FK on LOAN (
BRANCHNUM ASC
)
go

/*==============================================================*/
/* Index: ADDS_FK                                               */
/*==============================================================*/
create index ADDS_FK on LOAN (
EID ASC
)
go

/*==============================================================*/
/* Table: OPENS                                                 */
/*==============================================================*/
create table OPENS (
   SSN                  int                  not null,
   ACCOUTNUMBER         int                  not null,
   constraint PK_OPENS primary key (SSN, ACCOUTNUMBER)
)
go

/*==============================================================*/
/* Index: OPENS_FK                                              */
/*==============================================================*/
create index OPENS_FK on OPENS (
SSN ASC
)
go

/*==============================================================*/
/* Index: OPENS2_FK                                             */
/*==============================================================*/
create index OPENS2_FK on OPENS (
ACCOUTNUMBER ASC
)
go

/*==============================================================*/
/* Table: SERVES                                                */
/*==============================================================*/
create table SERVES (
   BRANCHNUM            int                  not null,
   SSN                  int                  not null,
   constraint PK_SERVES primary key (BRANCHNUM, SSN)
)
go

/*==============================================================*/
/* Index: SERVES_FK                                             */
/*==============================================================*/
create index SERVES_FK on SERVES (
BRANCHNUM ASC
)
go

/*==============================================================*/
/* Index: SERVES2_FK                                            */
/*==============================================================*/
create index SERVES2_FK on SERVES (
SSN ASC
)
go

/*==============================================================*/
/* Table: TAKES                                                 */
/*==============================================================*/
create table TAKES (
   SSN                  int                  not null,
   LOANNUMBER           int                  not null,
   constraint PK_TAKES primary key (SSN, LOANNUMBER)
)
go

/*==============================================================*/
/* Index: TAKES_FK                                              */
/*==============================================================*/
create index TAKES_FK on TAKES (
SSN ASC
)
go

/*==============================================================*/
/* Index: TAKES2_FK                                             */
/*==============================================================*/
create index TAKES2_FK on TAKES (
LOANNUMBER ASC
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_HAS_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table BANK
   add constraint FK_BANK_CREATES_ADMIN foreign key (AID)
      references ADMIN (AID)
go

alter table BRANCH
   add constraint FK_BRANCH_APPENDS_ADMIN foreign key (AID)
      references ADMIN (AID)
go

alter table BRANCH
   add constraint FK_BRANCH_OWNS_BANK foreign key (CODE)
      references BANK (CODE)
go

alter table DEALS_WITH
   add constraint FK_DEALS_WI_DEALS_WIT_EMPLOYEE foreign key (EID)
      references EMPLOYEE (EID)
go

alter table DEALS_WITH
   add constraint FK_DEALS_WI_DEALS_WIT_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table LOAN
   add constraint FK_LOAN_ADDS_EMPLOYEE foreign key (EID)
      references EMPLOYEE (EID)
go

alter table LOAN
   add constraint FK_LOAN_OFFERS_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table OPENS
   add constraint FK_OPENS_OPENS_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table OPENS
   add constraint FK_OPENS_OPENS2_ACCOUNT foreign key (ACCOUTNUMBER)
      references ACCOUNT (ACCOUTNUMBER)
go

alter table SERVES
   add constraint FK_SERVES_SERVES_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table SERVES
   add constraint FK_SERVES_SERVES2_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table TAKES
   add constraint FK_TAKES_TAKES_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table TAKES
   add constraint FK_TAKES_TAKES2_LOAN foreign key (LOANNUMBER)
      references LOAN (LOANNUMBER)
go

/*query A*/
Select *
from BRANCH 
where BRANCH.BRANCHNUM not in (Select SERVES.BRANCHNUM from SERVES); 

/*query B*/
Select DISTINCT BRANCH.BRANCHNUM,BRANCH.ADDRESS,BRANCH.CODE,BRANCH.AID
from BRANCH,EMPLOYEE
where Branch.BranchNum not in (Select Employee.BranchNum from Employee)

/*query C*/
SELECT EMPLOYEE.EID,EMPLOYEE.EFIRSTNAME,EMPLOYEE.ELASTNAME,EMPLOYEE.BRANCHNUM 
from EMPLOYEE JOIN LOAN 
ON EMPLOYEE.EID =LOAN.EID 
GROUP BY EMPLOYEE.EID,EMPLOYEE.EFIRSTNAME,EMPLOYEE.ELASTNAME,EMPLOYEE.BRANCHNUM 
HAVING COUNT (EMPLOYEE.EID)=
( 
SELECT MAX(mycount) 
FROM ( 
SELECT EMPLOYEE.EID, COUNT(EMPLOYEE.EID) mycount 
from EMPLOYEE  JOIN LOAN 
ON EMPLOYEE.EID =LOAN.EID 
GROUP BY EMPLOYEE.EID,EMPLOYEE.EFIRSTNAME,EMPLOYEE.ELASTNAME,EMPLOYEE.BRANCHNUM)as MaxNumLoans
)

/*query D*/
SELECT CUSTOMER.SSN, CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS
FROM CUSTOMER join TAKES 
on CUSTOMER.SSN=TAKES.SSN
GROUP BY CUSTOMER.SSN, CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS
HAVING COUNT (CUSTOMER.SSN)=
( 
SELECT MAX(mycount) 
FROM ( 
SELECT CUSTOMER.SSN, COUNT(CUSTOMER.SSN) mycount 
FROM CUSTOMER join TAKES
on CUSTOMER.SSN=TAKES.SSN
GROUP BY CUSTOMER.SSN, CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS)as MaxNumLoans
)

/*query E*/
Select SSN,FIRSTNAME,SECONDNAME,ADDRESS,PHONE
from Customer
where Customer.SSN not in (Select takes.SSN from takes);

/*query F*/
SELECT CUSTOMER.SSN, CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS,COUNT(DEALS_WITH.EID) AS NUM_OF_EMPLOYEE
FROM CUSTOMER join DEALS_WITH on CUSTOMER.SSN=DEALS_WITH.SSN 
GROUP BY CUSTOMER.SSN ,CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS

