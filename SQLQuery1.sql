CREATE TABLE [dbo].[Cars] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]      INT           NOT NULL,
    [ColorId]      INT           NOT NULL,
    [ModelYear]    INT           NOT NULL,
    [DailyPrice]   DECIMAL (18, 2) NOT NULL,
    [Description]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Brands] (
    [BrandId]      INT           IDENTITY (1, 1) NOT NULL,
    [BrandName]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

CREATE TABLE [dbo].[Colors] (
    [ColorId]      INT           IDENTITY (1, 1) NOT NULL,
    [ColorName]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);
CREATE TABLE [dbo].[Users] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR(50)  NOT NULL,
    [LastName]   NVARCHAR(50)  NOT NULL,
    [Email]      NVARCHAR(100) NOT NULL,
    [Password]   NVARCHAR(50)  NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Müşteriler tablosu
CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT           IDENTITY (1, 1) NOT NULL,
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

-- Arabanın kiralanma bilgisini tutan tablo
CREATE TABLE [dbo].[Rentals] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [CarId]       INT           NOT NULL,
    [CustomerId]  INT           NOT NULL,
    [RentDate]    DATETIME      NOT NULL,
    [ReturnDate]  DATETIME      NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rentals_Cars] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id]),
    CONSTRAINT [FK_Rentals_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

INSERT INTO Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) 
VALUES (1, 1, 2020, 150.00, 'Audi A4'),
       (2, 2, 2019, 120.00, 'BMW 3 Series'),
       (3, 3, 2018, 100.00, 'Mercedes-Benz C-Class'),
       (1, 2, 2017, 90.00, 'Audi A3'),
       (2, 1, 2016, 80.00, 'BMW 5 Series');

INSERT INTO Colors (ColorName) 
VALUES ('Red'),
       ('Blue'),
       ('White'),
       ('Black'),
       ('Silver');

INSERT INTO Brands (BrandName) 
VALUES ('Audi'),
       ('BMW'),
       ('Mercedes-Benz'),
       ('Toyota'),
       ('Honda');