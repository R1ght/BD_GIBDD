alter proc loginUserIn
(
@name Nvarchar(64),
@password Nvarchar(64),
@result int output
)
as
if @name in (select ����� from ������������)
	if @password = (select top 1 ������ from ������������ where ����� = @name)
		set @result = 1
	else set @result = -1
else set @result = -1
go
declare @test int
EXEC loginUserIn @name = 'Admffin', @password = 'admin', @result = @test output;
print @test