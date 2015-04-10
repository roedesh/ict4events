DROP TABLE SwearWord CASCADE CONSTRAINTS;
DROP TABLE Event CASCADE CONSTRAINTS;
DROP TABLE Account CASCADE CONSTRAINTS;
DROP TABLE Categorie CASCADE CONSTRAINTS;
DROP TABLE FileTable CASCADE CONSTRAINTS;
DROP TABLE CommentTable CASCADE CONSTRAINTS;
DROP TABLE LikeOrFlag CASCADE CONSTRAINTS;
DROP TABLE Role	CASCADE CONSTRAINTS;
DROP TABLE Employee	CASCADE CONSTRAINTS;
DROP TABLE RFID CASCADE CONSTRAINTS;
DROP TABLE Guest CASCADE CONSTRAINTS;
DROP TABLE LocationType CASCADE CONSTRAINTS;
DROP TABLE Location CASCADE CONSTRAINTS;
DROP TABLE Reservation CASCADE CONSTRAINTS;
DROP TABLE GuestReservation CASCADE CONSTRAINTS;
DROP TABLE Item CASCADE CONSTRAINTS;
DROP TABLE Rental CASCADE CONSTRAINTS;
DROP TABLE ItemRental CASCADE CONSTRAINTS;

CREATE TABLE SwearWord
(Word			varchar(20)		PRIMARY KEY
);


CREATE TABLE Event
(EventID		int				PRIMARY KEY,
Location		varchar(20)		NOT NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
Description		varchar(255)	NOT NULL,
AdmissionFee	int				CHECK(AdmissionFee>0)
);


CREATE TABLE Account
(AccountID		int				PRIMARY KEY,
EventID			int				NOT NULL,
Username		varchar(20)		UNIQUE,
Password		varchar(20)		NOT NULL,
FullName		varchar(30)		NOT NULL,
Adress			varchar(255)	NOT NULL,
City			varchar(80)		NOT NULL,
PostalCode		varchar(6)		NOT NULL,
DateOfBirth		date			NOT NULL,
Email			varchar(20)		NOT NULL,
Phonenumber		int				NOT NULL,
CONSTRAINT FK_EventID1 FOREIGN KEY (EventID) REFERENCES Event (EventID)
);

CREATE TABLE Categorie
(CategorieID	int				PRIMARY KEY,
CategorieParent int				NULL,
Name			varchar(20)		NOT NULL
);

CREATE TABLE FileTable
(FileID			int				PRIMARY KEY,
AccountID		int				NOT NULL,
CategorieID		int				NOT NULL,
DateTimeFile	timestamp		NOT NULL,
Titel			varchar(20)		NOT NULL,
FilePath		varchar(40)		NOT NULL,
NumberOfLikes	int				DEFAULT 0,
NumberOfFlags	int				DEFAULT 0,
CONSTRAINT FK_AccountID1 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_Categorie1 FOREIGN KEY (CategorieID) REFERENCES Categorie (CategorieID)
);


CREATE TABLE CommentTable
(CommentID		int				PRIMARY KEY,
FileID			int				NOT NULL,
AccountID		int				NOT NULL,
CommentRecu		int				NULL,
DateTimeComment	timestamp		NOT NULL,
Titel			varchar(20)		NOT NULL,
Message			varchar(200)	NULL,
NumberOfLikes	int				DEFAULT 0,
NumberOfFlags	int				DEFAULT 0,
CONSTRAINT FK_AccountID2 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_FileID1 FOREIGN KEY (FileID) REFERENCES FileTable (FileID)
);

CREATE TABLE LikeOrFlag
(LikeFlagID		int				PRIMARY KEY,
AccountID		int				NOT NULL,
CommentID		int				NULL,
FileId			int				NULL,
DateTimeLoF		timestamp		NOT NULL,
TypeLOF			varchar(4)		CHECK(TypeLOF = 'LIKE' OR TypeLOF = 'FLAG'),
CONSTRAINT FK_AccountID3 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_FileID2 FOREIGN KEY (FileID) REFERENCES FileTable (FileID),
CONSTRAINT FK_CommentID1 FOREIGN KEY (CommentID) REFERENCES CommentTable (CommentId)
);

CREATE TABLE Role
(RoleID			int				PRIMARY KEY,
Name			varchar(20)		NOT NULL,
Description		varchar(40)		NULL
);

CREATE TABLE Employee
(Employee		int				PRIMARY KEY,
AccountID		int				NOT NULL,
RoleID			int				NULL,
CONSTRAINT FK_AccountID4 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_RoleID1 FOREIGN KEY (RoleID) REFERENCES Role (RoleID)
);

CREATE TABLE RFID
(RFID			int				PRIMARY KEY,
EndDate			date			NOT NULL,
InUse			varchar(1)		CHECK(InUse = 'Y' OR InUse = 'N')
);

CREATE TABLE Guest
(GuestID		int				PRIMARY KEY,
AccountID		int				NOT NULL,
RFID			int				NOT NULL,
IsPresent		varchar(1)		CHECK(IsPresent = 'Y' OR IsPresent = 'N'),
CONSTRAINT FK_AccountID5 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_RFID FOREIGN KEY (RFID) REFERENCES RFID (RFID)
);

CREATE TABLE LocationType
(LocationTypeID	int				PRIMARY KEY,
Name			varchar(10)		NOT NULL,
Description		varchar(50)		NULL,
Price			int				CHECK(Price>0)
);

CREATE TABLE Location
(LocationID		int				PRIMARY KEY,
LocationTypeID	int				NOT NULL,
CONSTRAINT FK_LocationTypeID FOREIGN KEY (LocationTypeID) REFERENCES LocationType (LocationTypeID)
);

CREATE TABLE Reservation
(ReservationID	int				PRIMARY KEY,
Location		int				NOT NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
TotalAmount		int				CHECK(TotalAmount>0),
PaymentStatus	varchar(8)		CHECK(PaymentStatus = 'PAID' OR PaymentStatus = 'NOT PAID'),
CONSTRAINT FK_LocationID FOREIGN KEY (Location) REFERENCES Location (LocationID)
);

CREATE TABLE GuestReservation
(GuestID		int				NULL,
ReservationID	int				NOT NULL,
CONSTRAINT FK_GuestID1 FOREIGN KEY (GuestID) REFERENCES Guest (GuestID),
CONSTRAINT FK_ReservationID1 FOREIGN KEY (ReservationID) REFERENCES Reservation (ReservationID)
);

CREATE TABLE Item
(ItemID			int				PRIMARY KEY,
Name			varchar(20)		NOT NULL,
TypeItem		varchar(20)		NOT NULL,
Stock			int				NOT NULL,
Price			int				CHECK(Price>0)
);

CREATE TABLE Rental
(RentalID		int				PRIMARY KEY,
GuestId			int				NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
TotalAmount		int				CHECK(TotalAmount>0),
CONSTRAINT FK_GuestID2 FOREIGN KEY (GuestID) REFERENCES Guest (GuestID)
);

CREATE TABLE ItemRental
(ItemRentalID	int       PRIMARY KEY,
ItemID			int				NULL,
RentalID		int				NULL,
CONSTRAINT FK_RentalID1 FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
CONSTRAINT FK_ItemID1 FOREIGN KEY (ItemID) REFERENCES Item (ItemID)
);

