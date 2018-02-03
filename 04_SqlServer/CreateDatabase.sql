--1.代码创建数据库
CREATE DATABASE MyDBDemo
ON PRIMARY(
	--数据文件名称
	NAME='MyDBDemo',
	--路径
	FILENAME='c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyDBDemo.mdf',
	--初始大小
	SIZE=5MB,
	--增量
	FILEGROWTH=1MB
)
LOG ON(
	--日志文件名称
	NAME='MyDBDemo_log',
	--路径
	FILENAME='c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyDBDemo_log.ldf',
	--初始大小
	SIZE=3MB,
	--增量
	FILEGROWTH=10%
)


--2.代码创建表
Create table class(
	--identity(1,1)从1开始，每次增长1
	classId int identity(1,1) primary key,
	className nvarchar(10) not null,
	classDesc nvarchar(50)
)
create table Employees(
	EmpId int identity(1,1),
	EmpName varchar(50),
	EmpGender char(2),
	EmpAge int,
	EmpEmail varchar(100),
	EmpAddress varchar(500)
)
create table Department(
	DepId int identity(1,1) primary key,
	DepName varchar(50) unique not null	
)

--创建餐桌信息表，包含字段（主键，编号，信息，备注，标示，时间）
Create table Desk
(
	DeskId int identity(1,1) primary key,
	DeskNum nvarchar(10),
	DeskInfo nvarchar(10),
	DeskRemark nvarchar(20),
	Flag int,
	DeskSetTime Datetime
)


--3.向表中添加数据
--方法1，返回受影响的行数
--Insert into 表名(列1,列2) values(值1,值2)，可以直接把'列'拖过来
insert into class(className,classDesc) values('初中二班','不是一般人')
--方法2，
--insert into 表名 values(值)
insert into class values('初中一班','假正经')
--方法3，一次插入多条数据
insert into class values('初中一班','假正经')
insert into class values('初中三班','不是好人')
--方法4，和方法三相同，一次插入多条数据
insert into class(className,classDesc)
select N'高中1-3','都不正经' union --N用于解决中文乱码问题
select '高中4-6','有点问题' union
select '高中7班','还算正常'


--4.修改数据，返回受影响的行数
--update 表名 set 列1=值1,列2=值2
update class set classDesc = '都不正经' --该字段所有数据行都更改
update class set classDesc = '比较正经' where classId = 1 or classId = 6 --只修改满足判断条件的行
update class set classDesc = '比较正经', className='高一三班' where classId = 1
--把年龄>25的学生年龄都加1
update student set TSAge=TSAge+1 where TSAge>25
--给所有学生的成绩+5分，（考虑满分的情况，满分100）
update TblScore set tEnglish=100 where tEnglish+5>100
update TblScore set tEnglish=tEnglish+5 where tEnglish+5<100


--5.切换数据库
use TestDB
insert into class values('初中二班','不是一般人')
select * from class


--6.删除，返回受影响的行数
--方法1，删除表中的指定数据（不加条件就全部删除），表还在；ID从删除前的ID开始+1
delete from class
delete from class where classId = 10
--方法2，删除表中的全部数据,表还在；ID从1开始
truncate table class
--方法3，删除表，轻易不使用
drop table Desk


--7.代码设计表，对字段新增，删除，添加约束
--手动删除一列(删除EmpAddress列)
alter table Employees drop column EmpAddress
alter table Employees drop column DeptID
--手动增加一列(增加一列EmpAddr varchar(1000))
alter table Employees add EmpAddr nvarchar(50)
--手动修改一下EmpEmail的数据类型(varchar(200))
alter table Employees alter column EmpEmail varchar(200)
--为EmpId增加一个主键约束
alter table Employees add constraint PK_Employees_EmpID primary key(EmpID)
alter table Employees add constraint PK_Employees_EmpID primary key(EmpID)
--非空约束,为EmpName增加一个非空约束
alter table Employees alter column DeptID int not null
--为EmpName增加一个唯一约束
alter table Employees add constraint UQ_Employees_EmpAge unique (EmpName)
Insert into Employees values ('zhan','男',12,'123@123.com',1,'beijing')
--为性别增加一个默认约束，默认为'男'
alter table Employees add constraint DF_Employees_EmpGender default ('男') for EmpGender
--为年龄增加一个检查约束：年龄必须在1-120岁之间，含岁与岁。
alter table Employees add constraint CK_Employees_EmpAge check (EmpAge>=1 and EmpAge<=120)
--创建一个部门表，然后为Employee表增加一个DepId列。
alter table Employees add DepId int not null
select * from Employees
--增加外键约束
alter table Employees add constraint FK_Employees_DepId foreign key(DepId) references Department(DepId)


--8.查询
select * from class
Select EmpName, EmpAge from Employees
--方法1
Select EmPname as '姓名', EmpAge as '年龄' from Employees
--方法2
Select EmPname as 姓名, EmpAge as 年龄 from Employees
--方法3
Select 姓名=EmpName, 年龄=EmpAge from Employees
--条件检索
Select EmPname as '姓名', EmpAge as '年龄' from Employees where EmpGender = 1

--select显示在“结果”
Select 100+1
Select GETDATE()
--print显示在“消息”
print 100+90
print '当前时间'+getdate() --存在“字符串”和“时间”格式装换的问题


--9.查询前n项 + 排序
--查询所有数据的前10条数据
Select top 10* from Employees
--查询年龄最小的5个学生的信息
Select top 5* from Employees order by EmpAge --默认是升序排列asce
--从大到小排序，查询的是年龄最大的百分之10的学生信息
Select top 10 percent * from Employees order by EmpAge desc --降序排列
--用英语成绩排序，并列的用数学成绩，降序排列
Select * from tblScore where order by tsEnglish desc, order by tsMath desc
Select *, 总成绩 = (tsenglish + tsmath) from tblScore where order by (tsEnglish +tsMath) desc
--去除重复 
--distinct在查询结果中去除重复结果，而不是针对某一列
Select distinct EmpName from Employees


--10.聚合函数:MAX, MIN, AVG, SUM, COUNT, 
--null不参与聚合函数的运算，结果集中列数兼容问题
--查询有多少条数据
select COUNT(*) from Employees
--查询最高的数学成绩
select MAX(tsmath) from tblScore
--查询数学成绩最高的人的英语成绩
select top 1 tsenglish, math from tblScore order by tsmath desc
--查询最低的数学成绩
select MIN(tsmath) from tblScore
--计算数学成绩的总和
select SUM(tsmath) from tblScore
--计算平均值
select AVG(tsmath) from tblScore
--显示英语成绩的最大值，平均值，总和
select MAX(tsenglish) as '最大值', AVG(tsenglish) as '平均值', SUM(tsenglish) as '总和' from tblScore


--11.小问题总结：
---a.关于*和所有行,所有列的查询速度有比*快
select * from table
select 所有列 from table 
---b.换行，可以按关键字换行，不影响运算。方便读写
select 
MAX(tsenglish) as '最大值', 
AVG(tsenglish) as '平均值', 
SUM(tsenglish) as '总和' 
from tblScore
---c.null是否包含在*运算中,COUNT(*)包含null,COUNT(列名)不包含
select  COUNT(*) from tblScore
select COUNT(tsEnglish) from tblScore


--12.带条件的查询
---a.between...and，闭区间查询包含上下限；
select * from Employees where EmpAge>20 and EmpAge<30 and EmpGender = 1
select * from Employees where EmpGender = 1 and EmpAge Between 20 and 30 --between...and做过优化，更高效
---b.in，多条件包含查询
select * from Employees where EmpId = 1 or EmpId = 2 or EmpId = 3
select * from Employees where EmpId in (1,2,3)--更简洁直观


--13.模糊查询 like，
---通配符%, _, []可用于关键字重名, ^(只有MSSQLSERVER支持，其他DBMS用not like)
--名字里面姓张的所有名字
select * from Employees where EmpName like '张%'
--张后面带一个字
select * from Employees where EmpName like '张_'
--张后面带两个字
select * from Employees where EmpName like '张__'
select * from Employees where EmpName like '张%' and LEN(EmpName) = 3
--张中有字母的名字
select * from Employees where EmpName like '张[a-z]%'
--名字里面带张的，不一定姓张
select * from Employees where EmpName like '%张%'
--姓张的名字里面带百分号的
select * from Employees where EmpName like '张[%]%' --名字中带‘%’
select * from Employees where EmpName like '张[_]%' --名字中带‘-’
--姓张的名字里面带不带数字
select * from Employees where EmpName like '张[0-9]_' --以张开头，带数字，三个字的名字
select * from Employees where EmpName like '张[^0-9]_' --...，不带数字，...


--14.空值处理,null不是空，而是未知数据；判断是不是null
select * from Employees where EmpAge is null
select * from Employees where EmpAge is not null


--15.分组，group by
--查询每个班级的总人数
select tclassid as '班级', COUNT(*) as '人数' from student group by tclassid
--查询每个班级中男同学的人数
select tclassid as '班级', COUNT(*) as '人数' from student where Gender = 1 group by tclassid
--分组筛选，having;分组前，where
select tclassid as '班级', COUNT(*) as '人数' from student group by tclassid
having count(*)>3


--###小练习###
---a.热销售商品排名表，按每种商品总销量排序
select 商品名称, 销售总量 = SUM(销售总量) 
from MrOrders 
group by 商品名称 
order by SUM(销售总量) desc
---b.请统计销售价格超过3000元的商品名称和销售总价
select 商品名称, 销售总价 = SUM(销售数量*销售价格) 
from MrOrders 
group by 商品名称 
having SUM(销售数量*销售价格)>3000 
order by 销售总价 desc
---c.统计各个客户对‘可口可乐’的喜爱程度，统计每人的购买量
select 购买人, 销售总数量 = SUM(销售数量) 
from MrOrders 
where 商品名称='可口可乐' 
group by 购买人 
order by 销售总数量 
desc


--16.类型装换, CAST CONVERT ISNULL
--select '当前时间'+GETDATE() --类型不兼容，需要转换
---a.CAST
select '当前时间'+CAST(GETDATE() as varchar(20))
---b.CONVERT
select '当前时间'+ CONVERT(varchar(20),GETDATE())
select '当前时间'+ CONVERT(varchar(20),GETDATE(),120) --120，指定转换的时间格式
---c.判断转换后结果是否为空
select 
	ISNULL(CONVERT(varchar(10),tsEnglish),'缺考')--判断是否为NULL，如果是则用'缺考'替换
from tblScore
---d.舍去小数
select CAST(9.85 as int)


--select * frome class1, class2--笛卡尔积
--17.联合结果集, union
---a.要求列数目相同，类型相同
select tsid, tsname, tsaddress from student
union
select tclassid, tclassname, tclassdesc from TblClass
union
select sid, CONVERT(varchar(5),tsmath),CONVERT(varchar(10),tsenglish) from TblScore
---b.union, 列变行
select '最高成绩' as 内容,MAX(tsenglish) as 分数 from tblscore
union
select '最低成绩',MIN(tsenglish) from tbScore
union
select '最低成绩',AVG(tsenglish) from tbScore
---c.union all不会去除重复 效率高；union会去除重复 效率低
select tsName from TblStudent
union all
select tClassName from TblClass


--18.拷贝，把一个表中的数据或结构复制到另一个表中；不复制约束
---a.复制结构和数据
select * into newStudent from student
---b.只复制结构
select * into newStudent from student where 1<>1 --效率低
select top 0 * from newStudent from student --效率高
---c.backupStudent表必须提前建好
insert into backupStudent select * from student


--19.字符串函数
---a.查询字符串长度
select LEN(className) from class
select LEN('一坨翔') from class
---b.查询字节数
select DATALENGTH('哈哈，又变帅了')
select DATALENGTH(classDesc) from class --查字节的时候要先看看该列的数据类型
---c.转大小写
select LOWER('HELLO')
select UPPER('word')
---d.去除空格
select '====='+LTRIM('     哈哈，不在相信爱情了      ')+'=='
select '====='+RTRIM('     哈哈，不在相信爱情了      ')+'=='
select '====='+RTRIM(LTRIM('     哈哈，不在相信爱情了      '))+'=='

--20.时间函数
select GETDATE();--获取当前数据库所在服务器的时间
---a.加法
select DATEADD(YEAR,5,GETDATE())--五年之后
select DATEADD(MONTH,5,GETDATE())--五月之后
select DATEADD(DAY,5,GETDATE())--五天之后
select DATEADD(HOUR,5,GETDATE())--五小时之后
select DATEADD(SECOND,5,GETDATE())--五秒之后
---b.获取几年，求差
select DATEDIFF(YEAR,'2010',GETDATE())
--获取时间的某个部分
select DATEPART(YEAR,HOUR,GETDATE())

--添加数据的同时，获取该餐桌的id
--在数据库中@@开头，为全局变量
insert into DeskInfo values('1好餐桌','pinyin',0,'123')
select @@IDENTITY

insert into DeskInfo(DeskName,DeskNamePinYin,DeskDelFlag,DeskNum)output inserted.DeskId,inserted.DeskName values('特好餐桌','pinyin',0,'123')


--21.switch case语句
SELECT 
数学成绩 = 
CASE
	WHEN TSEnglish>120 THEN 'A'
	WHEN TSEnglish>100 THEN 'B'
	WHEN TSEnglish>80 THEN 'C'
	WHEN TSEnglish>70 THEN 'D'
	WHEN TSEnglish IS NULL THEN 'abpresent'
	ELSE 'E'
END
FROM TbScore

SELECT *,
级别 = 
(
	CASE
		WHEN [Level] = 1 THEN '小虾米'
		WHEN [Level] = 2 THEN '炮灰'
		WHEN [Level] = 3 THEN '大神'
	END
)
FROM Genius

----用SQL语句实现，当A列大于B列时选择A列否则选择B列；当B列大于C列时选择B列否则选择C列。
SELECT (CASE WHEN a>b THEN a ELSE b END),(CASE WHEN b>c THEN b ELSE c END)
FROM t

-----------华丽的分割线-----------
SELECT 
[单号],
收入=
(
	CASE
		WHEN[金额]>0 THEN [金额] ELSE 0
	END
)
,
支出=
(
	CASE
		WHEN[金额]<0 THEN ABS([金额]) ELSE 0
	END
)
FROM Sale


--22.子查询:就像操作普通表一样，被当做结果集的查询语句都成为子查询。所有可以使用表的地方，几乎都可以使用子查询
SELECT * FROM (SELECT * FROM [TABLE] WHERE '条件') AS [Alias]
-----as的作用，一般是重名列名或者表名；在这里-给查询对象起个别名。
SELECT * FROM (SELECT TsEnglish FROM TbScore) as t WHERE TSEnglish >90
---a、查询出班级中所有24岁的男生（子查询）
SELECT * FROM (SELECT * FROM Student WHERE TSGender = 1) as stu WHERE TSAge>24
---b、查询出所有的黑马一期和黑马二期的学生（子查询）
SELECT * FROM Student WHERE TClassId in
(SELECT tclassid FROM TblClass where TClassName = '黑马一期' or TClassName  = '黑马二期')
---b、查询出的总人数，男同学多少人,数学平均成绩(子查询)
SELECT
总人数 = (SELECT COUNT(*) FROM Student),
男同学多少人 = (SELECT COUNT(*) FROM Student WHERE TSGender = 1),
数学平均成绩 = (SELECT AVG(TSMath) FROM TbScore)

--单值子查询，返回当且仅当一行一列的数据,可以用=，<>等一元比较运算符
--如果条件后面跟着多个结果，那么in 或者 exists关键字

--DELETE FROM Student WHERE TSID in
--( SELECT TSId FROM Student WHERE TSName = '刘备' OR TSName = '张飞' OR TSName = '关羽' )


--23.分页，
---a.每页五条数据，查询第4页。
SELECT TOP 5 * FROM CustomerID WHERE NOT IN
(SELECT TOP (5*4) FROM CustomerID ORDER BY CustomerID)
ORDER BY CustomerID
---b.每页3条数据，查询3页
SELECT TOP 3 * FROM Student WHERE TSID NOT IN
(SELECT TOP(2*3) TSID FROM Student)

--24.开窗函数
---OVER按照那一列进行排序，ROW_NUMBER编号
SELECT TSMath,名次=ROW_NUMBER()OVER(ORDER BY TSMath desc) from TbScore
---排名函数RANK,重复的名次相同
SELECT TSMath,名次=RANK()OVER(ORDER BY TSMath desc)from TbScore
SELECT *,数学考试排名=RANK()OVER(ORDER BY TSMath DESC) FROM TbScore
SELECT *,数学考试排名=RANK()OVER(ORDER BY TSMath DESC) FROM TbScore ORDER BY TSId

--25.partition，
---相同商品名各自排序
SELECT ID, 商品名称,行号=ROW_NUMBER()OVER(PARTITION BY 商品名称 ORDER BY id ASC) FROM MyOrders
---按编号查询，每页显示3条数据，显示第五页
SELECT * FROM 
(SELECT 编号=ROW_NUMBER()OVER(ORDER BY TSMath DESC),* FROM TbScore) AS newStu
WHERE newStu.编号 BETWEEN (5-1)*3+1 AND 3*5

--26.存储过程;不加exec也可以执行
exec sp_databases
exec sp_tables
sp_columns course
sp_helptext sp_databases
---创建存储过程
----a.两数相加
create proc usp_Add
@num1 int,
@num2 int
as 
begin
	select @num1+@num2
end
---执行相加，传参方式
---方式1
declare @n1 int=10,@n2 int=12
exec usp_Add @num1=@n1,@num2=@n2
---方式2
exec usp_Add 30,20
----b.两数相减
create proc usp_Sub
@num1 int,
@num2 int
as
begin
	print @num1-@num2
end
---执行相减
declare @n1 int=10,@n2 int=12
exec usp_Sub @num1=@n1,@num2=@n2
---方式2
exec usp_Sub 30,20

----模糊查询 存储过程  练习
----参数"姓名，年龄"；返回"满足条数+输出满足条件的数据"
create proc usp_MySelectByNameandAge
@name nvarchar(10),--名字
@age int,--年龄
@count int output--条数
as
begin
	--条数
	set @count=(select COUNT(*) from tblStudent where tsName like @name+'%' and tsAge>@age)
	select * from tblStudent where tsName like @name+'%' and tsAge>@age
end
--#######---
declare @ct int
exec usp_MySelectByNameandAge '张',20,@ct output
select @ct

----练习循环提分的存储过程
-----要求：不及格的人数必须小于总人数的一半
-----参数1：及格分数线，65；参数2：每次提分的分数，2；参数3：循环提分的次数output参数；
create proc usp_tblScoreAdd
@scoreLine int=60,
@addScore int=2,
@i int output
as
begin
	set @i=0
	---总人数
	declare @sumPerson int=(select COUNT(*) from tblScore)
	---不及格的人数
	declare @l int=(select COUNT(*) from tblScore where tmath<@scoreLine)
	while(@l>@sumPerson/2)
	begin
		update tblScore set tmath=tmath+@addScore--提分
		--再次获取不及格的人数
		set @l=(select COUNT(*) from tblScore where tmath<@scoreLine)
		set @i=@i+1
	end
end

---分页的存储过程
create proc usp_PageStudent
@page int, --页数
@count int, --条数
@sumPage int output --总页数
as
begin
	set @sumPage=(CEILING((select COUNT(*) from tblStudent)*1.0/@count))--总页数
	select * from
	(select 编号=ROW_NUMBER() over(order by tsid),* from tblStudent) as tstu
	where tstu.编号 between (@page-1)*@count+1 and @page*@count
end

declare @t int
exec usp_pageStudent 4,6,@t output
select @t

--27.创建触发器，只有after deleted触发器和instead of触发器
---a.after deleted触发器
create trigger tr_stuTrigger on student
after delete
as
begin
	insert into nstu select * from deleted
end

delete from student where tsName='赵小黑'
select * from nstu
---b.inserted触发器

--28.游标
declare cur_MyStudent cursor fast_forward for select * from tblStudent

open cur_MyStudent

fetch next from cur_MyStudent
while @@fetch_Status=0
begin
	fetch next from cur_MyStudent
end
--关闭
close cur_MyStudent
--释放
deallocate cur_MyStudent