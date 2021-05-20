USE MASTER
GO

IF NOT EXISTS (
    SELECT [name]
    FROM sys.databases
    WHERE [name] = 'DogWalkMVCEx'
)
CREATE DATABASE DogWalkMVCEx
GO

USE DogWalkMVCEx
GO



DROP TABLE IF EXISTS Walker;
DROP TABLE IF EXISTS Dog;
DROP TABLE IF EXISTS [Owner];





CREATE TABLE [Owner] (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	Email VARCHAR(255) NOT NULL,
	[Name] VARCHAR(55) NOT NULL,
	[Address] VARCHAR(255) NOT NULL,
	
	Phone VARCHAR(55) NOT NULL,

	CONSTRAINT UQ_Email UNIQUE(Email)
);

CREATE TABLE Dog (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(55) NOT NULL,
	OwnerId INTEGER NOT NULL,
	Breed VARCHAR(55) NOT NULL,
	Notes VARCHAR(255),
	ImageUrl VARCHAR(255),
	CONSTRAINT FK_Dog_Owner FOREIGN KEY (OwnerId) REFERENCES [Owner](Id) ON DELETE CASCADE
);

CREATE TABLE Walker (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(55) NOT NULL,
	ImageUrl VARCHAR(255),
);

CREATE TABLE Walks (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	[Date] DATETIME NOT NULL,
	Duration INTEGER NOT NULL,
	WalkerId INTEGER NOT NULL,
	DogId INTEGER NOT NULL,
	CONSTRAINT FK_Walks_Walker FOREIGN KEY (WalkerId) REFERENCES Walker(Id) ON DELETE CASCADE,
	CONSTRAINT FK_Walks_Dog FOREIGN KEY (DogId) REFERENCES Dog(Id) ON DELETE CASCADE
);



INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('John Sanchez', 'john@gmail.com', '355 Main St',  '(615)-553-2456');
INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('Patricia Young', 'patty@gmail.com', '233 Washington St', '(615)-448-5521');
INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('Robert Brown', 'robert@gmail.com', '145 Sixth Ave', '(615)-323-7711');
INSERT INTO [Owner] ([Name], Email, [Address], Phone) VALUES ('Jennifer Wilson', 'Jennifer@gmail.com', '495 Cedar Rd', '(615)-919-8944');
INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('Michael Moore', 'mike@gmail.com', '88 Oak St', '(615)-556-7273');
INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('Linda Green', 'linda@gmail.com', '53 Lake Cir', '(615)-339-4488');
INSERT INTO [Owner] ([Name], Email, [Address],  Phone) VALUES ('William Anderson', 'willy@gmail.com', '223 Hill St', '(615)-232-6768');

INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Ninni', 1, 'Rottweiler');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Kuma', 1, 'Rottweiler');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Remy', 2, 'Greyhound');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Xyla', 3, 'Dalmation');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Chewy', 3, 'Beagle');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Groucho', 4, 'Dalmation');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Finley', 5, 'Golden Retriever');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Casper', 6, 'Golden Retriever');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Bubba', 7, 'English Bulldog');
INSERT INTO Dog ([Name], OwnerId, Breed) VALUES ('Zeus', 7, 'Schnauzer');


INSERT INTO Walker ([Name], ImageUrl) values ('Claudelle', 'https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Roi', 'https://avatars.dicebear.com/v2/male/ebf2f3a7c07a83e6bce11358860bec57.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Shena', 'https://avatars.dicebear.com/v2/female/08c75cdd62072da8400654c560a5ed6b.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Gibb', 'https://avatars.dicebear.com/v2/male/6640bd96cd90587bf8e00d9e7f187b36.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Tammy', 'https://avatars.dicebear.com/v2/female/e092d74ffd42e2d1d1be3e3f71b88289.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Rufe', 'https://avatars.dicebear.com/v2/male/3a47dbe77df7fcab368e15983a39725c.svg');
INSERT INTO Walker ([Name], ImageUrl)  values ('Cassandry', 'https://avatars.dicebear.com/v2/female/91c2e90fb83e3a21d388c84de5746b60.svg');
INSERT INTO Walker ([Name], ImageUrl)  values ('Cully', 'https://avatars.dicebear.com/v2/male/bdd61e876afcf343969a266c9fdfb111.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Agnesse', 'https://avatars.dicebear.com/v2/female/08f7c5edb1dd8760e24283373c640a7b.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Koo', 'https://avatars.dicebear.com/v2/male/0156bd784b34e8939bb52051c6f0dc44.svg');
INSERT INTO Walker ([Name], ImageUrl) values ('Diana', 'https://avatars.dicebear.com/v2/female/14e803e1cf517d1d4d3eef8ba7fc60bf.svg');
INSERT INTO Walker ([Name], ImageUrl)  values ('Moreen', 'https://avatars.dicebear.com/v2/female/bb9466af25bc563d1aabb6dd483691ec.svg');
INSERT INTO Walker ([Name], ImageUrl)  values ('Sonni', 'https://avatars.dicebear.com/v2/male/1277989709535d07963ab9e151a94645.svg');

INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-09 17:30:00', 1200, 1, 1);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-10 17:30:00', 1200, 1, 2);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-08 16:00:00', 900, 2, 9);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-09 08:30:00', 1800, 2, 6);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-10 12:00:00', 1750, 3, 3);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-08 09:00:00', 1275, 3, 7);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-09 13:30:00', 2000, 4, 4);
INSERT INTO Walks ([Date], Duration, WalkerId, DogId) VALUES ('2020-04-09 13:30:00', 2000, 4, 5);



/* TESTING GROUNDS: */
SELECT Id, [Name], Email, [Address],  Phone
                        FROM Owner
 SELECT Id, [Name], OwnerId, Breed
                        FROM Dog

						SELECT Id, [Date], Duration, WalkerId, DogId FROM Walks

						SELECT w.Id, w.[Date], w.Duration, w.WalkerId, w.DogId, 
						d.Name AS NameofDog, d.OwnerId, o.Name AS NameofOwner
                        FROM Walks w
                        JOIN Dog d ON w.DogId = d.Id
                        JOIN Owner o ON o.Id = d.OwnerId
                        
						SELECT w.Id, w.[Date], w.Duration, w.WalkerId, w.DogId,
						d.[Name] AS NameofDog, d.OwnerId, o.[Name] AS NameofOwner,
                         Walker.[Name] AS NameofWalker, walker.ImageUrl
                        FROM Walks w
                        JOIN Dog d ON w.DogId = d.Id
                        Join Walker ON w.WalkerId = Walker.Id
                        JOIN Owner o ON o.Id = d.OwnerId
						
                       


					SELECT w.Id, w.[Name], w.ImageUrl
					
                    FROM Walker w 
					

					    SELECT w.Id, w.[Name], w.ImageUrl
                        FROM Walker w
                        



						SELECT w.Id, w.[Date], w.Duration, w.WalkerId, w.DogId,
						d.[Name] AS NameofDog, d.OwnerId, o.[Name] AS NameofOwner,
                         Walker.[Name] AS NameofWalker, walker.ImageUrl
                        FROM Walks w
                        JOIN Dog d ON w.DogId = d.Id
                        Join Walker ON w.WalkerId = Walker.Id
                        JOIN [Owner] o ON d.OwnerId = o.Id
						                   
/* TESTING GROUNDS: */