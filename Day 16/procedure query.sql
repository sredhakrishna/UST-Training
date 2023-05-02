create or alter procedure showId(@Id int)
as
begin 
select * from Persons where personId=@Id
end
execute showId 100
