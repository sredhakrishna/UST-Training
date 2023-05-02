USE [EmpDB]
GO

DECLARE	@return_value int,
		@name varchar(255)

EXEC	@return_value = [dbo].[getName]
		@personId = 100,
		@name = @name OUTPUT

SELECT	@name as N'@name'

SELECT	'Return Value' = @return_value

GO
