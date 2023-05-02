create table employee4
(empId int primary key not null,
Name char(200) not null,
Salary varchar(255) not null);

insert into employee4 values(1,'sredha','1000000'),(2,'manjima ','20000'),(3,'anusree','20000');

select * from employee4;

select Name from employee4 where empId=1;
