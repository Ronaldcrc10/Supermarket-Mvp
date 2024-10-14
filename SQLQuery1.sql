use Supermarket
create table Products
(
 Product_Id int identity (100000,1) primary key,
 Product_Name nvarchar (50) not null,
 Product_Price int not null,   
 Product_Stock int NOT NULL
)
go

INSERT INTO Products values ('Apple', 100, 50)
INSERT INTO Products values ('Banana', 80, 100)