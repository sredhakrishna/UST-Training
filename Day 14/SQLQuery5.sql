create table DEPARTMENTS
(DPT_ID int primary key,
DPT_NAME varchar(50));

insert into DEPARTMENTS values(10,'ADMIN'),(20,'BILLING');



create table EMPLOYEEE
(Emp_id int primary key,
emp_name varchar(100),
emp_dept int );


insert into EMPLOYEEE values(3,'AARON',10),(4,'SREDHA',20);

update DEPARTMENTS 
SET  DPT_NAME='ADMINISTRATOR' 
where DPT_NAME='ADMIN';

alter table  EMPLOYEEE
add salary decimal;
select * from DEPARTMENTS;

select * from EMPLOYEEE;


update EMPLOYEEE
set salary=100
where Emp_id=3 ;

