USE Bass


CREATE TABLE EnigmaMessages (
EnigmaMessageId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
UserID INT NOT NULL,
Username VARCHAR(255),
EnigmaMessage VARCHAR(255),
EnigmaMessageEncoded VARCHAR(255),
EnigmaMessageDecoded VARCHAR(255),
CreatedOn DATETIME DEFAULT GETDATE(),
);

INSERT INTO EnigmaMessages (UserID,EnigmaMessage) VALUES (1,'Uijt!jt!b!efnp!pg!fodszqujpo');
INSERT INTO EnigmaMessages (UserID,EnigmaMessage) VALUES (2,'Test');
INSERT INTO EnigmaMessages (UserID,EnigmaMessage) VALUES (3,'Uftu');

CREATE TABLE dbo.Users (
UserID INT IDENTITY(1001,1),
username VARCHAR(50),
email VARCHAR(50) UNIQUE,
password binary(64),
salt UNIQUEIDENTIFIER,
ccreatedOn DATETIME DEFAULT GETDATE()
);

SELECT * FROM dbo.Users;

DECLARE @password VARCHAR(50) ='Test123!';
DECLARE @salt UNIQUEIDENTIFIER = NEWID();
INSERT INTO Users (username, email, password, salt) VALUES
(
'Landon',
'Admin',
HASHBYTES ('sha2_512', @password + CAST(@salt AS NVARCHAR(36))),
@salt
);

CREATE PROC dbo.User_Login (
@email VARCHAR(50),
@password VARCHAR(100)
)
AS
BEGIN
SELECT COUNT(*) FROM Users
WHERE email = @email
AND
password = HASHBYTES('sha2_512', @password + CAST(salt AS NVARCHAR(36)))
END

EXEC User_Login 
@email = 'Admin',
@password = 'Test123!';

SELECT * FROM EnigmaMessages;
SELECT * FROM Users;