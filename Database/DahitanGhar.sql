--Initial Draft: Start: Shiwa-15Jan'2025, Create DB with some Authenticatin Related tables.
GO
USE master
DROP DATABASE IF EXISTS DahitanGhar;
CREATE DATABASE DahitanGhar;
GO

USE DahitanGhar;

GO 
DROP TABLE IF EXISTS Mst_Users

CREATE TABLE Mst_Users(
	Id UNIQUEIDENTIFIER NOT NULL CONSTRAINT PK_Mst_Users_ID PRIMARY KEY (Id),
	FullName VARCHAR(100) NOT NULL,
	UserName VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	PasswordHash VARCHAR(2000) NOT NULL,
	PhoneNumber VARCHAR(20) NOT NULL,
	RefreshToken VARCHAR(500) NOT NULL,
	RefreshTokenExpiryTime DATETIMEOFFSET(7) NOT NULL 
)
GO

INSERT INTO Mst_Users 
VALUES(NEWID(),'admin',
	'admain@gmail.com',
	'admain@gmail.com',
	'$2y$10$N67d95CBvsbaiDgoLSTYq.tc8gxBsIwHYD55WVfqTs3cCtg2BnILK', --pass@123
	'9867594177',
	'550e8400-e29b-41d4-a716-446655440000',
	SYSDATETIMEOFFSET()
);
GO

/*Start: 18Mar'2025, Tables to store image and their description created.*/
GO
DROP TABLE IF EXISTS Mst_Image
CREATE TABLE Mst_Image(
	ImageId INT NOT NULL CONSTRAINT PK_Mst_Images_ID PRIMARY KEY IDENTITY(1,1),
	Source VARCHAR(1000) NOT NULL,
	ImageType NVARCHAR(100) NOT NULL,
	Title NVARCHAR(200) NOT NULL,
	IsCarousalActive BIT NOT NULL
)


GO
DROP TABLE IF EXISTS Img_Description
CREATE TABLE Img_Description(
	Id INT NOT NULL CONSTRAINT PK_Img_Description_Id PRIMARY KEY IDENTITY(1,1),
	ImageId INT CONSTRAINT FK_Img_Description_Id_Mst_Images_Id REFERENCES Mst_Image(ImageId),
	CostPerNight INT, --Only if Image type is room.
	Summary NVARCHAR(1000),
	RoomType VARCHAR(50)  --Only if Image type is room.
)
GO
/*End: 18Mar'2025, Tables to store image and their description created.*/