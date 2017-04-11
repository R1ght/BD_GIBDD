create proc vivodStrah
(
@name Nvarchar(64)
)
as
SELECT СтраховыеКомпании.Название, СтраховыеКомпании.Адрес, СтраховыеКомпании.Телефон from СтраховыеКомпании where СтраховыеКомпании.Название LIKE '%' + @name +'%'

go


EXEC vivodStrah @name = 'РОСГОССТРАХ';