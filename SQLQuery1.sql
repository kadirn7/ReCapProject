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