INSERT INTO SwearWord 
VALUES ('homo');
INSERT INTO SwearWord 
VALUES ('klootzak');
INSERT INTO SwearWord 
VALUES ('mongool');
INSERT INTO SwearWord 
VALUES ('mongol');
INSERT INTO SwearWord 
VALUES ('fuck');
INSERT INTO SwearWord 
VALUES ('fucking');
INSERT INTO SwearWord 
VALUES ('slet');

INSERT INTO Event 
VALUES (1, 'Ergens', TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'Event summary', 20 );
INSERT INTO Event 
VALUES (2, 'Ergensanders', TO_DATE('1993/08/11 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'Event summary', 20 );
INSERT INTO Event 
VALUES (3, 'Weerergensanders', TO_DATE('1993/09/14 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'Event summary', 20 );

INSERT INTO Account 
VALUES (1, 1, 'Pieter', 'Pieter', 'Pieter Peters', 'Ergensstraat 3', 'Stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'pieter@gmail.com', 0611234567);
INSERT INTO Account
VALUES (2, 1, 'Johan', 'Johan', 'Johan Kan', 'Ergensstraat 8', 'Stad', '1234AA', TO_DATE('1995/06/23','yyyy/mm/dd hh24:mi:ss'), 'johan@gmail.com', 0611234223);
INSERT INTO Account
VALUES (3, 1, 'Henk', 'Henk', 'Henk Jansen', 'Ergensstraat 11', 'Stad', '1234AA', TO_DATE('1983/12/11','yyyy/mm/dd hh24:mi:ss'), 'henk@gmail.com', 0611112425);
INSERT INTO Account
VALUES (4, 1, 'Freek', 'Freek', 'Freek van Jachten', 'Ergensstraat 24', 'Stad', '1234AA', TO_DATE('1987/01/22','yyyy/mm/dd hh24:mi:ss'), 'freek@gmail.com', 0625224141);
INSERT INTO Account
VALUES (5, 1, 'Boris', 'Boris', 'Boris Hoenders', 'Ergensstraat 1', 'Stad', '1234AA', TO_DATE('1994/10/22','yyyy/mm/dd hh24:mi:ss'), 'boris@gmail.com', 0612318888);
INSERT INTO Account
VALUES (6, 1, 'Anne', 'Anne', 'Anne Baarssen', 'Ergensstraat 27', 'Stad', '1234AA', TO_DATE('1998/05/11','yyyy/mm/dd hh24:mi:ss'), 'anne@gmail.com', 0612391797);
INSERT INTO Account 
VALUES (7, 1, 'Richard', 'Richard', 'Richard Peters', 'Ergensstraat 3', 'Stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'richard@gmail.com', 0612345515);
INSERT INTO Account
VALUES (8, 1, 'Joost', 'Joost', 'Joost Bergen', 'Ergensstraat 22', 'Stad', '1234AA', TO_DATE('1997/11/21','yyyy/mm/dd hh24:mi:ss'), 'joost@gmail.com', 0612443123);
INSERT INTO Account
VALUES (9, 1, 'Floor', 'Floor', 'Floor van den Beek', 'Ergensstraat 43', 'Stad', '1234AA', TO_DATE('1990/10/14','yyyy/mm/dd hh24:mi:ss'), 'floor@gmail.com', 0611124425);
INSERT INTO Account
VALUES (10, 1, 'Noortje', 'Noortje', 'Noortje Bierkens', 'Ergensstraat 29', 'Stad', '1234AA', TO_DATE('1986/11/17','yyyy/mm/dd hh24:mi:ss'), 'noortje@gmail.com', 0625224141);
INSERT INTO Account
VALUES (11, 1, 'Mohammed', 'Mohammed', 'Mohammed Ali', 'Ergensstraat 2', 'Stad', '1234AA', TO_DATE('1996/10/18','yyyy/mm/dd hh24:mi:ss'), 'mohammed@gmail.com', 0612389888);
INSERT INTO Account
VALUES (12, 1, 'Jolijn', 'Jolijn', 'Jolijn Janssen', 'Ergensstraat 32', 'Stad', '1234AA', TO_DATE('1984/04/17','yyyy/mm/dd hh24:mi:ss'), 'jolijn@gmail.com', 0612397897);

INSERT INTO Role
VALUES (1, 'EventManager', 'Event Manager beschrijving');
INSERT INTO Role
VALUES (2, 'ReservationManager', 'Reserveringen beheren');
INSERT INTO Role
VALUES (3, 'AccessManager', 'Toegangscontrole');
INSERT INTO Role
VALUES (4, 'EntryManager', 'Event Manager beschrijving');
INSERT INTO Role
VALUES (5, 'SocialMediaManager', 'Reserveringen beheren');
INSERT INTO Role
VALUES (6, 'Admin', 'Toegangscontrole');

INSERT INTO Employee
VALUES (1, 1, 1);
INSERT INTO Employee
VALUES (2, 6, 3);
INSERT INTO Employee
VALUES (3, 5, 2);
INSERT INTO Employee
VALUES (4, 2, 1);
INSERT INTO Employee
VALUES (5, 3, 3);
INSERT INTO Employee
VALUES (6, 4, 2);
INSERT INTO Employee
VALUES (7, 7, 3);
INSERT INTO Employee
VALUES (8, 8, 1);

INSERT INTO RFID
VALUES('2800b81df0');
INSERT INTO RFID
VALUES('4a003611eb');
INSERT INTO RFID
VALUES('7000826e43');
INSERT INTO RFID
VALUES('5c005cb362');
INSERT INTO RFID
VALUES('5c005cda59');

INSERT INTO Guest
VALUES(1,9,'2800b81df0','Y');
INSERT INTO Guest
VALUES(2,10,'4a003611eb','Y');
INSERT INTO Guest
VALUES(3,11,'7000826e43','N');
INSERT INTO Guest
VALUES(4,12,'5c005cb362', 'N');

INSERT INTO LOCATIONTYPE
VALUES(1,'Hutje','Backtobasic',100);
INSERT INTO LOCATIONTYPE
VALUES(2,'Huisje','Modern',350);
INSERT INTO LOCATIONTYPE
VALUES(3,'Villa','Luxe',1000);
INSERT INTO LOCATIONTYPE
VALUES(4,'Hutje2','Backtobasic',100);
INSERT INTO LOCATIONTYPE
VALUES(5,'Huisje2','Modern',350);
INSERT INTO LOCATIONTYPE
VALUES(6,'Villa2','Luxe',1000);
INSERT INTO LOCATIONTYPE
VALUES(7,'Hutje3','Backtobasic',100);
INSERT INTO LOCATIONTYPE
VALUES(8,'Hutje4','Backtobasic',100);
INSERT INTO LOCATION
VALUES (1,1);
INSERT INTO LOCATION
VALUES (2,2);
INSERT INTO LOCATION
VALUES (3,3);
INSERT INTO LOCATION
VALUES (4,4);
INSERT INTO LOCATION
VALUES (5,5);
INSERT INTO LOCATION
VALUES (6,6);
INSERT INTO LOCATION
VALUES (7,7);
INSERT INTO LOCATION
VALUES (8,8);

INSERT INTO RESERVATION
VALUES (1,1,TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'),TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'),100,'PAID');
INSERT INTO GUESTRESERVATION
VALUES (1,1,1);
commit;

