create proc PoiskAvtoInFIO
(
@fam nvarchar(20),
@imya nvarchar(10),
@otchestvo nvarchar(15)
)
as
SELECT ��������.ID_�������, ������.�������, ������.���, ������.��������, ������.�����_�������� AS [����� ��������], ������.������������ AS [���� ��������], ������.��������������� AS [����� ����������],
������.�����, ������.��������� AS [����� ����], ����������.��������� as [����� ����������], ����������.������, ����������.��������������� AS [��� ������������], ����������.����, 
����������.�����VIN as [VIN], ����������.�������������� as [����� ���������]  
--�������������������������.ID_�������������������������� as [����� ��], ������.�������� AS [����� ���������]

 FROM �������� inner join ������ on ��������.ID_������� = ������.ID_������� inner join ���������� on ������.ID_������� = ����������.������
 WHERE ������.������� LIKE '%' + @fam + '%' AND ������.��� LIKE '%' + @imya + '%' AND ������.�������� LIKE '%' + @otchestvo + '%'

go

 exec PoiskAvtoInFIO @fam = '�������', @imya = '����', @otchestvo = '����������'