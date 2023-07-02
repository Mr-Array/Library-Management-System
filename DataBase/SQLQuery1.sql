--create database library_System;

create table Users(
UserID int identity(1,1),
Username varchar(200) not null,
Password varchar(200) not null,
FullName varchar(500) not null,
Email varchar(250) not null,
Phone varchar(200) not null,
Address varchar(250) not null,
Type varchar(50) not null
unique(Email),
primary key(UserID)
);

create table Books(
ID int not null,
Title varchar(250) not null,
Author varchar(250) not null,
Section varchar(50) not null,
Edition varchar(70),
Quantity int not null,
Price int not null
unique(Title),
primary key(ID)
);


 create table Bowrrowed_books(
 BookID_borrow int not null ,
 ID int not null,
 UserID_borrow int not null,
 First_date datetime not null,
 End_date datetime not null,
 status varchar(60) not null
 Foreign key(UserID_borrow) REFERENCES Users(UserID),
 foreign key(ID) REFERENCES Books(ID)
 );

  
 insert into Books(ID,Title,Author,section,Edition,Quantity,Price) values(20 , 'Hacking' ,'Mr Robert','Cyber Securty','2017',5,15);

 insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(203, 'Problem Solving', 'Mostafa Saad', 'Programming', '2015', 40, 250),
(24, 'The Mythical Man-Month', 'Frederick Brooks', 'Software Engineering', '1995', 6, 15),
insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values(25, 'Design Patterns', 'Erich Gamma et al.', 'Programming', '1994', 5, 30),
insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values(26, 'Refactoring', 'Martin Fowler', 'Programming', '1999', 3, 20),
insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values(27, 'The C Programming Language', 'Brian Kernighan and Dennis Ritchie', 'Programming', '1988', 7, 10),
insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values(28, 'Introduction to Algorithms', 'Thomas Cormen et al.', 'Computer Science', '2009', 2, 50)

insert into Users(UserID,Username,Password,FullName,Email,Phone,Type,Address)
 values ('2001' , 'Mr_Array', '1234', 'Mohamed Nasser', 'Mr@gmail.com','01068061927' , 'System User', 'Qena')

 insert into bowrrowed_books(BookID_borrow,ID,UserID_borrow,first_date,end_date,status)

select Username , password , type , Email  from Users
select UserID , Username , Email , Address from Users where  Type = 'Student' order by UserID;
select Title from Books;
select * from bowrrowed_books order by status asc;
delete Books from Books where Books.ID ='';
delete from Users where UserID ='';
select Quantity from Books;
update Books set Quantity where ID ='';
select BookID_borrow from bowrrowed_books where UserID_borrow ='';

