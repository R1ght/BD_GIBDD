CREATE PROC InfStrah
(
@fam nvarchar(20),
@imya nvarchar(10),
@otchestvo nvarchar(15)
)
AS
SELECT ��������.ID_�������, ����������.���_����, ����������.������, ����������.���������, ����������.������,
���������.������_���������, ���������.���������_���������, ���������.�����, ���������.�����
FROM �������� INNER JOIN ������ ON ��������.ID_������� = ������.ID_������� INNER JOIN ���������� ON ������.ID_������� = ����������.������
INNER JOIN ��������� ON ����������.ID_���������� = ���������.����������
 WHERE ������.������� LIKE '%' + @fam + '%' AND ������.��� LIKE '%' + @imya + '%' AND ������.�������� LIKE '%' + @otchestvo + '%'

 go

 exec InfStrah @fam = '�������', @imya = '����', @otchestvo = '����������'