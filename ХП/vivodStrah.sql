create proc vivodStrah
(
@name Nvarchar(64)
)
as
SELECT �����������������.��������, �����������������.�����, �����������������.������� from ����������������� where �����������������.�������� LIKE '%' + @name +'%'

go


EXEC vivodStrah @name = '�����������';