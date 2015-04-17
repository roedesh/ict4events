CoCREATE TABLE SwearWord
(Word			varchar2(255 char)		PRIMARY KEY
);


CREATE TABLE Event
(EventID		int					PRIMARY KEY,
Location		varchar2(255 char)	NOT NULL,
StartDate		date				NOT NULL,
EndDate			date				NOT NULL,
Description		varchar2(255 char)	NOT NULL,
AdmissionFee	int					CHECK(AdmissionFee>0)
);


CREATE TABLE Account
(AccountID		int						PRIMARY KEY,
EventID			int						NOT NULL,
Username		varchar2(255 char)		UNIQUE,
Password		varchar2(255 char)		NOT NULL,
FullName		varchar2(255 char)		NOT NULL,
Adress			varchar2(255 char)		NOT NULL,
City			varchar2(255 char)		NOT NULL,
PostalCode		varchar2(255 char)		NOT NULL,
DateOfBirth		date					NOT NULL,
Email			varchar2(255 char)		NOT NULL,
Phonenumber		int						NOT NULL,
CONSTRAINT FK_EventID1 FOREIGN KEY (EventID) REFERENCES Event (EventID)
);

CREATE TABLE FileTable	
(FileID			int						PRIMARY KEY,
AccountID		int						NOT NULL,
DateTimeFile	timestamp				NOT NULL,
Titel			varchar2(255 char)		NOT NULL,
FilePath		varchar2(255 char)		NOT NULL,
NumberOfLikes	int						DEFAULT 0,
NumberOfFlags	int						DEFAULT 0,
CONSTRAINT FK_AccountID1 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
);


CREATE TABLE CommentTable
(CommentID		int						PRIMARY KEY,
FileID			int						NOT NULL,
AccountID		int						NOT NULL,
CommentRecu		int						NULL,
DateTimeComment	timestamp				NOT NULL,
Titel			varchar2(255 char)		NOT NULL,
Message			varchar2(255 char)		NULL,
NumberOfLikes	int						DEFAULT 0,
NumberOfFlags	int						DEFAULT 0,
CONSTRAINT FK_AccountID2 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_FileID1 FOREIGN KEY (FileID) REFERENCES FileTable (FileID)
);

CREATE TABLE LikeOrFlag
(LikeFlagID		int						PRIMARY KEY,
AccountID		int						NOT NULL,
CommentID		int						NULL,
FileId			int						NULL,
DateTimeLoF		timestamp				NOT NULL,
TypeLOF			varchar2(255 char)		CHECK(TypeLOF = 'LIKE' OR TypeLOF = 'FLAG'),
CONSTRAINT FK_AccountID3 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_FileID2 FOREIGN KEY (FileID) REFERENCES FileTable (FileID),
CONSTRAINT FK_CommentID1 FOREIGN KEY (CommentID) REFERENCES CommentTable (CommentId)
);

CREATE TABLE Role
(RoleID			int						PRIMARY KEY,
RoleName		varchar2(255 char)		NOT NULL,
Description		varchar2(255 char)		NULL
);

CREATE TABLE Employee
(EmployeeID		int				PRIMARY KEY,
AccountID		int				NOT NULL,
RoleID			int				NULL,
CONSTRAINT FK_AccountID4 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_RoleID1 FOREIGN KEY (RoleID) REFERENCES Role (RoleID)
);

CREATE TABLE RFID
(RFID			varchar2(255 char)		PRIMARY KEY,
);

CREATE TABLE Guest
(GuestID		int						PRIMARY KEY,
AccountID		int						NOT NULL,
RFID			varchar2(255 char)		NOT NULL,
IsPresent		varchar2(255 char)		CHECK(IsPresent = 'Y' OR IsPresent = 'N'),
CONSTRAINT FK_AccountID5 FOREIGN KEY (AccountID) REFERENCES Account (AccountID),
CONSTRAINT FK_RFID FOREIGN KEY (RFID) REFERENCES RFID (RFID)
);

CREATE TABLE LocationType
(LocationTypeID	int						PRIMARY KEY,
Name			varchar2(255 char)		NOT NULL,
Description		varchar2(255 char)		NULL,
Price			int				CHECK(Price>0)
);

CREATE TABLE Location
(LocationID	    int						PRIMARY KEY,
LocationTypeID	int						NOT NULL,
CONSTRAINT FK_LocationTypeID FOREIGN KEY (LocationTypeID) REFERENCES LocationType (LocationTypeID)
);

CREATE TABLE Reservation
(ReservationID	int				PRIMARY KEY,
LocationID	int				NOT NULL,
StartDate		date			NOT NULL,
EndDate			date			NOT NULL,
TotalAmount		int				CHECK(TotalAmount>0),
PaymentStatus	varchar2(255 char)		CHECK(PaymentStatus = 'PAID' OR PaymentStatus = 'NOT PAID'),
CONSTRAINT FK_LocationID FOREIGN KEY (LocationID) REFERENCES Location (LocationID)
);

CREATE TABLE GuestReservation
(GuestReservationID	int				PRIMARY KEY,
GuestID				int				NULL,
ReservationID		int				NOT NULL,
CONSTRAINT FK_GuestID1 FOREIGN KEY (GuestID) REFERENCES Guest (GuestID),
CONSTRAINT FK_ReservationID1 FOREIGN KEY (ReservationID) REFERENCES Reservation (ReservationID)
);

CREATE TABLE Item
(ItemID			int						PRIMARY KEY,
Name			varchar2(255 char)		NOT NULL,
TypeItem		varchar2(255 char)		NOT NULL,
Stock			int						NOT NULL,
Price			int						CHECK(Price>0)
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
(ItemRentalID	int       		PRIMARY KEY,
ItemID			int				NULL,
RentalID		int				NULL,
CONSTRAINT FK_RentalID1 FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
CONSTRAINT FK_ItemID1 FOREIGN KEY (ItemID) REFERENCES Item (ItemID)
);

COMMIT;

