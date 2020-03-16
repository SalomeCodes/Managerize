USE [InvoiceServiceDb]
GO

CREATE TABLE [dbo].[Customers_MOCK](
	[Id] [nvarchar](50) NOT NULL,
	[CustomerNumber] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Prefix] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[ZipCode] [nvarchar](50) NOT NULL,
	[HouseNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

BULK INSERT CUSTOMERS_MOCK
FROM 'D:\git\Managerize\InvoiceService\mockdata\Customers_MOCK.csv'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '0x0A',
	DATAFILETYPE = 'char'
)
GO

CREATE TABLE [dbo].[InvoiceLines_MOCK](
	[Id] [nvarchar](50) NOT NULL,
	[ItemId] [int] NOT NULL,
	[Amount] [nvarchar](50) NOT NULL,
	[InvoiceId] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
BULK INSERT InvoiceLines_MOCK
FROM 'D:\git\Managerize\InvoiceService\mockdata\InvoiceLines_MOCK.csv'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '0x0A',
	DATAFILETYPE = 'char'
)
GO

CREATE TABLE [dbo].[Invoices_MOCK](
	[Id] [nvarchar](50) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[DateSent] [datetime2](7) NOT NULL,
	[TotalPrice] [nvarchar](50) NOT NULL,
	[PayedAmount] [nvarchar](50) NOT NULL,
	[IsPayed] [nvarchar](50) NOT NULL,
	[DatePayed] [nvarchar](50),
	[CustomerId] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

BULK INSERT Invoices_MOCK
FROM 'D:\git\Managerize\InvoiceService\mockdata\Invoices_MOCK.csv'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ',',
	ROWTERMINATOR = '0x0A',
	DATAFILETYPE = 'char'
)
GO

CREATE TABLE [dbo].[Items_MOCK](
	[Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Price] [nvarchar](250) NOT NULL
) ON [PRIMARY]
GO

BULK INSERT Items_MOCK
FROM 'D:\git\Managerize\InvoiceService\mockdata\Items.txt'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '0x0A',
	DATAFILETYPE = 'char'
)
GO

CREATE TABLE [dbo].[Buurtcode](
	[Buurtcode_2019] [int] NOT NULL,
	[Buurtnaam_2019] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO

BULK INSERT Buurtcode
FROM 'D:\git\Managerize\InvoiceService\mockdata\Adressentabel\Buurtcode.csv'
WITH(
	FIRSTROW = 2,
	ROWTERMINATOR = '0x0A',
	FIELDTERMINATOR = ';'
)
GO

CREATE TABLE [dbo].[Postcode_Buurt_Gemeente_Wijk](
	[PC6] [nvarchar](50) NOT NULL,
	[Huisnummer] [nvarchar](50) NOT NULL,
	[Buurt2019] [int] NOT NULL,
	[Wijk2019] [int] NOT NULL,
	[Gemeente2019] [int] NOT NULL
) ON [PRIMARY]
GO

BULK INSERT Postcode_Buurt_Gemeente_Wijk
FROM 'D:\git\Managerize\InvoiceService\mockdata\Adressentabel\Postcode_Buurt_Gemeente_Wijk.csv'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '0x0A',
	DATAFILETYPE = 'char'
)
GO

CREATE TABLE [dbo].[Postcode_Straat](
	[Id] [int] NOT NULL,
	[Postcode] [nvarchar](50) NOT NULL,
	[StraatNaam] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO

BULK INSERT Postcode_Straat
FROM 'D:\git\Managerize\InvoiceService\mockdata\Adressentabel\Postcode_Straat.csv'
WITH(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '0x0A'
)
GO

