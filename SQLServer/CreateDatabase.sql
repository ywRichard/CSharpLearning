
Create Table class
(
	classId int identity(1,1) primary key,
	className nvarchar(10) not null,
	classDesc nvarchar(50)
)
select * from DeskInfo
--主键，编号，信息，备注，标示，时间
Create Table Desk
(
	DeskId int identity(1,1) primary key,
	DeskNum nvarchar(10),
	DeskInfo nvarchar(10),
	DeskRemark nvarchar(20),
	Flag int,
	DeskSetTime Datetime
)
use TestDB

select * from Desk
select * from class

--方法1，注意返回值
Insert into 表名(列1,列2) values(值1,值2)
insert into class(className,classDesc) values('初中二班','不是一般人')
--方法2，方法3，可以添加多行数据
insert into class values('初中一班','假正经')
insert into class values('初中三班','不是好人')
--方法4,N用于解决中文乱码问题
insert into class(className,classDesc)
select N'高中1-3','都不正经' union
select '高中4-6','有点问题' union
select '高中7班','还算正常'

select * from class
--更新数据,返回值为受影响的行数

update 表名 set 列1 = 值1
update class set classDesc = '都不正经'
update class set classDesc = '比较正经' where classId = 1 or classId = 6
update class set classDesc = '比较正经' where classId = 1

--切换数据库
use TestDB
select * from class
insert into class values('初中二班','不是一般人')
--删除
--方法1，只删除数据，ID从删除前的ID开始+1
delete from class
delete from class where classId = 10
--方法2，删除整张表，轻易不使用
drop table Desk
--方法3，删除数据,ID从1开始
truncate table class

create table Employees
(
	EmpId int identity(1,1),
	EmpName varchar(50),
	EmpGender char(2),
	EmpAge int,
	EmpEmail varchar(100),
	EmpAddress varchar(500)
)


create table Department
(
	DepId int identity(1,1) primary key,
	DepName varchar(50) unique not null	
)

----Lesson 2
--练习
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
--只检索需要的列
Select EmpName, EmpAge from Employees
--方法1
Select EmPname as '员工姓名', EmpAge as '年龄' from Employees
--方法2
Select EmPname as 员工姓名, EmpAge as 年龄 from Employees
--方法3
Select 员工姓名=EmpName, 年龄=EmpAge from Employees
--条件检索
Select EmPname as '员工姓名', EmpAge as '年龄' from Employees where EmpGender = 1

Select 100+1
Select GETDATE()
print 100+90
print '当前时间'+getdate()---字符串和时间格式装换的问题

--排序
--查询所有数据的前10条数据
Select top 10* from Employees
--查询年龄最小的5个学生的信息
Select top 5* from Employees order by EmpAge --默认是升序排列asce
--从大到小排序，查询的是年龄最大的百分之10的学生信息
Select top 10 percent * from Employees order by EmpAge desc --降序排列
--用英语成绩排序，并列的用数学成绩，降序排列
Select * from tblScore where order by tsEnglish desc, order by tsMath desc

Select*, 总成绩 = (tsenglish + tsmath) from tblScore where order by (tsEnglish +tsMath) desc
--去除重复 distinct在查询结果中去除重复结果，而不是针对某一列
Select distinct EmpName from Employees

--SQL聚合函数:MAX, MIN, AVG, SUM, COUNT, null不参与聚合函数的运算
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

--小问题总结：
--1、关于*和所有行,所有列的查询速度有比*快
select * from table
select 所有列 from table 
--2、换行，可以按关键字换行，不影响运算。方便读写
select 
MAX(tsenglish) as '最大值', 
AVG(tsenglish) as '平均值', 
SUM(tsenglish) as '总和' 
from tblScore
--3、null是否包含在*运算中,COUNT(*)包含null,COUNT(列名)不包含
select  COUNT(*) from tblScore
select COUNT(tsEnglish) from tblScore

--查询年纪大于20小于30的男性, between效率更高
select * from Employees where EmpAge>20 and EmpAge<30 and EmpGender = 1
select * from Employees where EmpGender = 1 and EmpAge Between 20 and 30

--查询员工编号为1,2,3的员工,两种方法
select * from Employees where EmpId = 1 or EmpId = 2 or EmpId = 3
select * from Employees where EmpId in (1,2,3)

--模糊查询，通配符%, _, []可用于关键字重名, ^(只有MSSQLSERVER支持，其他DBMS用not like)
--名字里面姓张的所有名字
select * from Employees where EmpName like '张%'
--张后面带一个字
select * from Employees where EmpName like '张_'
--张后面带两个字
select * from Employees where EmpName like '张__'
select * from Employees where EmpName like '张%' and LEN(EmpName) = 3
--张中有字母的名字
select * from Employees where EmpName like '张[a-z]%'
--名字里面带张的
select * from Employees where EmpName like '%张%'
--姓张的名字里面带百分号的
select * from Employees where EmpName like '张[%]%'
select * from Employees where EmpName like '张[_]%'
--姓张的名字里面带不带数字
select * from Employees where EmpName like '张[0-9]%'
select * from Employees where EmpName like '张[^0-9]_'

--空值处理,null不知道,判断是不是mull
select * from Employees where EmpAge is null
select * from Employees where EmpAge is not null

--分组
--查询每个班级的总人数
select tclassid as '班级', COUNT(*) as '人数' from student group by tclassid
--查询每个班级的男同学的人数
select tclassid as '班级', COUNT(*) as '人数' from student where Gender = 1 group by tclassid
--分组筛选，having
select tclassid as '班级', COUNT(*) as '人数' from student group by tclassid
having count(*)>3

--在order表中查询
--1.热销售商品排名表，按每种商品总销量排序
select 商品名称, 销售总量 = SUM(销售总量) 
from MrOrders 
group by 商品名称 
order by SUM(销售总量) desc
--2.请统计销售价格超过3000元的商品名称和销售总价
select 商品名称, 销售总价 = SUM(销售数量*销售价格) 
from MrOrders 
group by 商品名称 
having SUM(销售数量*销售价格)>3000 
order by 销售总价 desc
--3.统计各个客户对‘可口可乐’的喜爱程度，统计每人的购买量
select 购买人, 销售总数量 = SUM(销售数量) 
from MrOrders 
where 商品名称='可口可乐' 
group by 购买人 
order by 销售总数量 
desc

--类型装换 CAST CONVERT ISNULL
select '当前时间'+GETDATE()
--方法一
select '当前时间'+CAST(GETDATE() as varchar(20))
--方法二
select '当前时间'+ CONVERT(varchar(20),GETDATE(),120)
--方法三
select 
	ISNULL(CONVERT(varchar(10),tsEnglish),'缺考')--判断是否为NULL
from tblScore

select CAST(9.85 as int) --舍去小数

--select * frome class1, class2--笛卡尔积

--联合结果集,联合的列数目，类型要相同
select tsid, tsname, tsaddress from student
union
select tclassid, tclassname, tclassdesc from TblClass
union
select sid, CONVERT(varchar(5),tsmath),CONVERT(varchar(10),tsenglish) from TblScore
--union, 列变行
select '最高成绩' as 内容,MAX(tsenglish) as 分数 from tblscore
union
select '最低成绩',MIN(tsenglish) from tbScore
union
select '最低成绩',AVG(tsenglish) from tbScore
--union会去除重复 效率低，union all不会去除重复 效率高

--备份,只备份数据不备份约束，备份表未建
--方法一  备份数据+结构
select * into newStudent from student
--方法二 只备份结构,不备份数据
select * into newStudent from student where 1<>1--效率低
--方法三 只备份结构
select top 0 * from newStudent from student--效率高
--备份表已建
insert into backupStudent select * from student--backupStudent表必须提前建好

--字符串函数
--查询字符串长度
select LEN(className) from class
select LEN('一坨翔') from class
--查询字节数
select DATALENGTH('哈哈，又变帅了')
select DATALENGTH(classDesc) from class --查字节的时候要先看看该列的数据类型
--转大小写
select LOWER('HELLO')
select UPPER('word')
--去除空格
select '====='+LTRIM('     哈哈，不在相信爱情了      ')+'=='
select '====='+RTRIM('     哈哈，不在相信爱情了      ')+'=='
select '====='+RTRIM(LTRIM('     哈哈，不在相信爱情了      '))+'=='

--时间函数
select GETDATE();--当前服务器的时间
--加法的作用，
select DATEADD(YEAR,5,GETDATE())--五年之后
select DATEADD(MONTH,5,GETDATE())--五月之后
select DATEADD(DAY,5,GETDATE())--五天之后
select DATEADD(HOUR,5,GETDATE())--五小时之后
select DATEADD(SECOND,5,GETDATE())--五秒之后
--获取几年，求差
select DATEDIFF(YEAR,'2010',GETDATE())
--获取时间的某个部分
select DATEPART(YEAR,HOUR,GETDATE())

--添加数据的同时，获取该餐桌的id
--在数据库中@@开头，为全局变量
insert into DeskInfo values('1好餐桌','pinyin',0,'123')
select @@IDENTITY

insert into DeskInfo(DeskName,DeskNamePinYin,DeskDelFlag,DeskNum)output inserted.DeskId,inserted.DeskName values('特好餐桌','pinyin',0,'123')

--复制数据
update ETU35_37 set N_TrippingTime_Tolerance_tmax = (select L_TrippingTime_Tolerance_tmax )from ETU35_37
update ETU35_37 set Ii_Tripping_Tolerance_Imax = (select Ii_Tripping_ETU_Ii)*1.2 from ETU35_37
select * from ETU35_37

update ETU45_47 set L_Tripping_ETU_IR = (select L_Tripping_ETU_IR) from ETU35_37

select * from ETU45_47
update ETU45_47 set G_Tripping_Tolerance_Imax = 360

update ETU45_47 set I_Tripping_Tolerance_Imax = (select I_Tripping_Tolerance_Imin)*1.2 from ETU45_47
update ETU45_47 set N_Tripping_Tolerance_tmin = (select L_Tripping_Tolerance_tmin)from ETU45_47
update ETU45_47 set N_Tripping_Tolerance_tmax = (select L_Tripping_Tolerance_tmax) from ETU45_47

--CASE语句
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


--子查询:就像操作普通表一样，被当做结果集的查询语句都成为子查询。所有可以使用表的地方，几乎都可以使用子查询

SELECT * FROM (SELECT * FROM [TABLE] WHERE '条件') AS [Alias]
-----as的作用，一般是重名列名或者表名；在这里-给查询对象起个别名。
SELECT * FROM (SELECT TsEnglish FROM TbScore) as t WHERE TSEnglish >90

---1、查询出班级中所有24岁的男生（子查询）
SELECT * FROM (SELECT * FROM Student WHERE TSGender = 1) as stu WHERE TSAge>24

---2、查询出所有的黑马一期和黑马二期的学生（子查询）
SELECT * FROM Student WHERE TClassId in
(SELECT tclassid FROM TblClass where TClassName = '黑马一期' or TClassName  = '黑马二期')

---3、查询出的总人数，男同学多少人,数学平均成绩(子查询)
SELECT
总人数 = (SELECT COUNT(*) FROM Student),
男同学多少人 = (SELECT COUNT(*) FROM Student WHERE TSGender = 1),
数学平均成绩 = (SELECT AVG(TSMath) FROM TbScore)

--单值子查询，返回当且仅当一行一列的数据,可以用=，<>等一元比较运算符
--如果条件后面跟着多个结果，那么in 或者 exists关键字

--DELETE FROM Student WHERE TSID in
--( SELECT TSId FROM Student WHERE TSName = '刘备' OR TSName = '张飞' OR TSName = '关羽' )


----分页，每页五条数据，查询第4页。

SELECT TOP 5 * FROM CustomerID WHERE NOT IN
(SELECT TOP (5*4) FROM CustomerID ORDER BY CustomerID)
ORDER BY CustomerID

--每页3条数据，查询3页
SELECT TOP 3 * FROM Student WHERE TSID NOT IN
(SELECT TOP(2*3) TSID FROM Student)

--OVER按照那一列进行排序，ROW_NUMBER编号
SELECT TSMath,名次=ROW_NUMBER()OVER(ORDER BY TSMath desc) from TbScore
--排名函数RANK,重复的名次相同
SELECT TSMath,名次=RANK()OVER(ORDER BY TSMath desc)from TbScore
SELECT *,数学考试排名=RANK()OVER(ORDER BY TSMath DESC) FROM TbScore
SELECT *,数学考试排名=RANK()OVER(ORDER BY TSMath DESC) FROM TbScore ORDER BY TSId

---partition，相同商品名各自排序
SELECT ID, 商品名称,行号=ROW_NUMBER()OVER(PARTITION BY 商品名称 ORDER BY id ASC) FROM MyOrders

---按编号查询，每页显示3条数据，显示第五页
SELECT * FROM 
(SELECT 编号=ROW_NUMBER()OVER(ORDER BY TSMath DESC),* FROM TbScore) AS newStu
WHERE newStu.编号 BETWEEN (5-1)*3+1 AND 3*5