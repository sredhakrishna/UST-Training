create or alter procedure getName
@personId int, 
@name varchar(255) output
as 
begin
select @name=firstname from persons where personId=@personId;
end;
 

