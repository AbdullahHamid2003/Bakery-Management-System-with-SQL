create database WINFORM_DB

CREATE TABLE LOGIN_TBL
(
  USERNAME VARCHAR(50) NOT NULL,
  PASS VARCHAR(50) NOT NULL
);

SELECT * FROM LOGIN_TBL;

INSERT INTO LOGIN_TBL VALUES('Abdullah', '264');
INSERT INTO LOGIN_TBL VALUES('Sameer', '239');
INSERT INTO LOGIN_TBL VALUES('Ali', '259');


drop table LOGIN_TBL;


create table ADD_ITEM_TBL
(
   p_id int primary key identity(1,1),
   item varchar(max),
   price int,
   quantity int,
   total int
);

select * from ADD_ITEM_TBL

truncate table ADD_ITEM_TBL

drop table ADD_ITEM_TBL
