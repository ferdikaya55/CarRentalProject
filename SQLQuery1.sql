Create Table Cars(
	Id int Primary Key IDentity(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	Foreign Key (BrandID) REFERENCES Brands(BrandID),
	Foreign Key (ColorID) REFERENCES Colors(ColorID)
)

Create Table Colors(
	ColorId int Primary Key Identity(1,1),
	ColorName nvarchar(25)
)

Create Table Brands(
	BrandId int Primary Key Identity(1,1),
	BrandName nvarchar(25)
)

Insert Into Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
Values
	('1','2','2012','150','Manuel Benzin'),
	('1','3','2015','250','Otomatik Benzin'),
	('2','1','2017','300','Manuel Dizel'),
	('3','3','2014','350','Manuel Benzin');

Insert Into Colors(ColorName)
Values
	('Beyaz'),
	('Siyah'),
	('Kırmızı');
	
Insert Into Brands(BrandName)
Values
	('Volvo'),
	('Renault'),
	('Mercedes');

Select * from Cars

