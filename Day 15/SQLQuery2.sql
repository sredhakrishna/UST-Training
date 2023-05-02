SELECT a.Accounnum as ACNO,
a.Name as [Account Holder Name],
a.Balance,a.ReferenceId as[ref id],
r.Name as[reference name]
from Table_1 a left join Table_1 r
on a.ReferenceId=r.Accounnum