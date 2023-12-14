--CREATE DATABASE Aurora;

--USE Aurora;

CREATE TABLE [User](
	Id INT PRIMARY KEY IDENTITY,
	Login VARCHAR(20) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	Register DATETIME NOT NULL,
	Status BIT NOT NULL
);

CREATE TABLE Customer(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(60) NOT NULL,
	Birthdate DATE NOT NULL,ri
	Document VARCHAR(14) NOT NULL,
	Register DATETIME NOT NULL,
	Status BIT NOT NULL
);

CREATE TABLE State(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(40) NOT NULL
);

CREATE TABLE City(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(40) NOT NULL,
	StateId INT NOT NULL REFERENCES State(Id)
);

CREATE TABLE CustomerAddress(
	Id INT PRIMARY KEY IDENTITY,
	CustomerId INT NOT NULL REFERENCES Customer(Id),
	Address VARCHAR(100) NOT NULL,
	Number VARCHAR(5) NOT NULL,
	ZipCode VARCHAR(8) NOT NULL,
	CityId INT NOT NULL REFERENCES City(Id),
	StateId INT NOT NULL REFERENCES State(Id),
	Register DATETIME NOT NULL,
	Status BIT NOT NULL
);

CREATE TABLE Product(
	Id INT PRIMARY KEY IDENTITY,
	Description VARCHAR(60) NOT NULL,
	Price DECIMAL NOT NULL,
	Stock INT NOT NULL,
	Register DATETIME NOT NULL,
	Status BIT NOT NULL
);

CREATE TABLE [Order](
	Id INT PRIMARY KEY IDENTITY,
	CustomerId INT NOT NULL REFERENCES Customer(Id),
	UserId INT NOT NULL REFERENCES [User](Id),
	Register DATETIME NOT NULL,
	Status BIT NOT NULL
);

CREATE TABLE OrderProduct(
	Id INT PRIMARY KEY IDENTITY,
	Amount INT NOT NULL,
	Discount FLOAT,
	OrderId INT REFERENCES [Order](Id),
	ProductId INT REFERENCES Product(Id)
);