create database product;
use product;
 create table product(
    pid int primary key auto_increment,
    pname varchar(255),
    purchasedate date
 );

 insert into product values(1,"computer","2022-01-01");
  insert into product values(2,"laptop","2022-01-01");