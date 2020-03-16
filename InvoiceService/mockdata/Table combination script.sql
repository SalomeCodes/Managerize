INSERT INTO Customers (Customers.Id, CustomerNumber, Name, Prefix, Surname, Customers_MOCK.ZipCode, HouseNumber, Email, PhoneNumber, Street, Place)
SELECT DISTINCT
	MAX(Customers_MOCK.Id) as Id, 
	MAX(CustomerNumber) as CustomerNumber, 
	MAX(Name) as Name, 
	MAX(Prefix) as Prefix, 
	MAX(Surname) as Surname, 
	MAX(Customers_MOCK.ZipCode) as ZipCode, 
	MAX(HouseNumber) as HouseNumber, 
	MAX(Email) as Email, 
	MAX(PhoneNumber) as PhoneNumber, 
	MAX(SUBSTRING(StraatNaam, 1, (PATINDEX('% [0-9]%', StraatNaam)))) as Street,
	MAX(Buurtcode.Buurtnaam_2019) as Place
FROM Customers_MOCK 
INNER JOIN Postcode_Buurt_Gemeente_Wijk 
ON Customers_MOCK.ZipCode = Postcode_Buurt_Gemeente_Wijk.PC6
INNER JOIN Buurtcode
ON Postcode_Buurt_Gemeente_Wijk.Buurt2019 = Buurtcode.Buurtcode_2019
INNER JOIN Postcode_Straat
ON Customers_MOCK.ZipCode = Postcode_Straat.Postcode
GROUP BY Customers_MOCK.Id;

INSERT INTO Items (Name, Description, Price)
SELECT Name, Description, Price FROM Items_MOCK;

INSERT INTO Invoices (Id, InvoiceNumber, CreationDate,DateSent,TotalPrice,PayedAmount,IsPayed, CustomerId, DatePayed)
SELECT convert(uniqueidentifier,Id) as Id, InvoiceNumber, CreationDate,DateSent,TotalPrice,PayedAmount,IsPayed, convert(uniqueidentifier,CustomerId) as CustomerId, 
CASE WHEN DatePayed = '""' THEN null ELSE DatePayed END as DatePayedNULL
FROM Invoices_MOCK;

INSERT INTO InvoiceLines (InvoiceId, ItemId, Amount)
SELECT CONVERT(uniqueidentifier, InvoiceId), ItemId, Amount FROM InvoiceLines_MOCK;

SELECT * FROM Customers;
SELECT * FROM Items;
SELECT * FROM Invoices;
SELECT * FROM InvoiceLines;

