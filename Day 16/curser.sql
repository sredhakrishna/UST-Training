declare @personId int
declare curse cursor
for select @personId from persons order by personId;
open curse
fetch next from curse into @personId;
close curse
deallocate curse

