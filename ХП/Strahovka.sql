create proc Strahovka
(
@fam Nvarchar,
@name Nvarchar,
@otchestvo Nvarchar
)
as
SELECT ������.�������, ������.���, ������.��������, ����������.��������� AS [�����], 
����������.������, ���������.�����, ���������.�����, ���������.������_���������, 
���������.���������_���������, �����������������.�������� as [�������� ���������]
from ������ inner join ���������� on ������.ID_�������  = ����������.������ inner join 
��������� on ����������.ID_���������� = ���������.���������� inner join �����������������
on ���������.����������������� = �����������������.ID_��������
where ������.������� LIKE '%' + @fam +'%' AND ������.��� LIKE '%' + @name +'%' AND ������.�������� LIKE '%' + @otchestvo +'%'

go


EXEC Strahovka @fam = '�������', @name = '����', @otchestvo = '����������';

drop proc Strahovka