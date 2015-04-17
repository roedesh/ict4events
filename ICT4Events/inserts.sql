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

INSERT INTO Account 
VALUES (1, 1, 'pieter', 'pieter', 'pieter peters', 'ergensstraat 3', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'pieter@gmail.com', 061234567);
INSERT INTO Account
VALUES (2, 1, 'johan', 'johan', 'johan kan', 'ergensstraat 8', 'stad', '1234AA', TO_DATE('1993/07/13','yyyy/mm/dd hh24:mi:ss'), 'johan@gmail.com', 061234567);

INSERT INTO Category 
VALUES (1,null, 'categorieA');

INSERT INTO FileTable 
VALUES (1, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel', 'file path', 0, 0);
INSERT INTO FileTable
VALUES (2, 1, 1, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'file titel2', 'file path2', 1, 0);

INSERT INTO CommentTable 
VALUES (1,1, 1, NULL, TO_TIMESTAMP('1993/07/13 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'comment titel', 'bericht inhoud', 3, 5);

INSERT INTO LikeOrFlag
VALUES (1, 2, NULL, 1, TO_TIMESTAMP('1993/07/14 12:12:12' , 'YYYY-MM-DD HH24:MI:SS'), 'LIKE');

INSERT INTO Role
VALUES (1, 'Event Manager', 'Event Manager beschrijving');

INSERT INTO Employee
VALUES (1, 2, 1);



