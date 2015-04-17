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

INSERT INTO FileTable 
VALUES (1, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel', 'file path', 3, 0);
INSERT INTO FileTable
VALUES (2, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel2', 'file path2', 1, 0);
INSERT INTO FileTable
VALUES (3, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel3', 'file path3', 4, 0);
INSERT INTO FileTable
VALUES (4, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel4', 'file path4', 2, 0);

INSERT INTO CommentTable 
VALUES (1,1, 1, NULL, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'comment titel1', 'bericht inhoud1', 3, 5);
INSERT INTO CommentTable 
VALUES (2,1, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'comment titel2', 'bericht inhoud2', 3, 5);
INSERT INTO CommentTable 
VALUES (3,2, 1, NULL, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'comment titel3', 'bericht inhoud3', 3, 5);
INSERT INTO CommentTable 
VALUES (4,3, 1, NULL, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'comment titel4', 'bericht inhoud4', 3, 5);

INSERT INTO LikeOrFlag
VALUES (1, 2, NULL, 1, TO_TIMESTAMP('1993/07/14 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'LIKE');
INSERT INTO LikeOrFlag
VALUES (2, 2, NULL, 2, TO_TIMESTAMP('1993/07/14 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'FLAG');
INSERT INTO LikeOrFlag
VALUES (3, 2, NULL, 1, TO_TIMESTAMP('1993/07/14 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'LIKE');

INSERT INTO Role
VALUES (1, 'Event Manager', 'Event Manager beschrijving');
INSERT INTO Role
VALUES (2, 'Catering', 'Drank boykie');
INSERT INTO Role
VALUES (1, 'Interieur verzorger', 'Schoonmaken en netjes houden van eventterrein');

INSERT INTO Employee
VALUES (1, 1, 1);
INSERT INTO Employee
VALUES (2, 6, 3);
INSERT INTO Employee
VALUES (3, 5, 2);

INSERT INTO RFID
VALUES();
INSERT INTO RFID
VALUES();
INSERT INTO RFID
VALUES();
INSERT INTO RFID
VALUES();
INSERT INTO RFID
VALUES();


