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
VALUES (1, 'ergens', TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'event summary', 20 );
INSERT INTO Event 
VALUES (2, 'ergensanders', TO_DATE('1993/08/11 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'event summary', 20 );
INSERT INTO Event 
VALUES (3, 'weerergensanders', TO_DATE('1993/09/14 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), TO_DATE('2015/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'), 'event summary', 20 );

INSERT INTO Account 
VALUES (1, 1, 'pieter', 'pieter', 'pieter peters', 'ergensstraat 3', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'pieter@gmail.com', 061234567);
INSERT INTO Account
VALUES (2, 1, 'johan', 'johan', 'johan kan', 'ergensstraat 8', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'johan@gmail.com', 061234223);
INSERT INTO Account
VALUES (3, 1, 'henk', 'henk', 'henk jansen', 'ergensstraat 11', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'henk@gmail.com', 061112425);
INSERT INTO Account
VALUES (4, 1, 'freek', 'freek', 'freek van jachten', 'ergensstraat 24', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'freek@gmail.com', 0625224141);
INSERT INTO Account
VALUES (5, 1, 'boris', 'boris', 'boris hoenders', 'ergensstraat 1', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'boris@gmail.com', 061238888);
INSERT INTO Account
VALUES (6, 1, 'anne', 'anne', 'anne baarssen', 'ergensstraat 27', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'anne@gmail.com', 061239797);

INSERT INTO Role
VALUES (1, 'EventManager', 'Event Manager beschrijving');
INSERT INTO Role
VALUES (2, 'ReservationManager', 'reserveringen beheren');
INSERT INTO Role
VALUES (3, 'AccessManager', 'toegangscontrole');
INSERT INTO Role
VALUES (4, 'EntryManager', 'Event Manager beschrijving');
INSERT INTO Role
VALUES (5, 'SocialMediaManager', 'reserveringen beheren');
INSERT INTO Role
VALUES (6, 'Admin', 'toegangscontrole');

INSERT INTO Employee
VALUES (1, 1, 1);
INSERT INTO Employee
VALUES (2, 6, 3);
INSERT INTO Employee
VALUES (3, 5, 2);

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
VALUES(1,2,'2800b81df0','Y');
INSERT INTO Guest
VALUES(2,3,'4a003611eb','Y');
INSERT INTO Guest
VALUES(3,4,'7000826e43','N');


commit;

INSERT INTO LOCATIONTYPE
VALUES(1,'hutje','backtobasic',100);
INSERT INTO LOCATION
VALUES (1,1);
INSERT INTO RESERVATION
VALUES (1,1,TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'),TO_DATE('1993/07/13 12:12:12', 'yyyy/mm/dd hh24:mi:ss'),100,'PAID');
INSERT INTO GUESTRESERVATION
VALUES (1,1,1);
commit;

