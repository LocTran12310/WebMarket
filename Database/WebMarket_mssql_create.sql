USE [master]
GO

DROP DATABASE [WebMarket]
CREATE DATABASE [WebMarket]
GO
use WebMarket


CREATE TABLE [category] (
	ID integer NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL UNIQUE,
	image nvarchar(100)
  CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

CREATE TABLE [type] (
	ID integer NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL UNIQUE,
	ID_category integer NOT NULL,
  CONSTRAINT [PK_TYPE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [provider] (
	ID integer NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL UNIQUE,
	address nvarchar(255) NOT NULL,
	phone varchar(11) NOT NULL,
  CONSTRAINT [PK_PROVIDER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [product] (
	ID integer NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL UNIQUE,
	price float,
	image nvarchar(100) NOT NULL,
	description text,
	ID_provider integer NOT NULL,
	ID_type integer NOT NULL,
	discount float NOT NULL,
  CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [productdetail] (
	ID integer NOT NULL IDENTITY,
	ID_product integer NOT NULL,
	quantity integer NOT NULL,
	entry_date datetime NOT NULL,
	MFG datetime NOT NULL,
	EXP datetime NOT NULL,
  CONSTRAINT [PK_PRODUCTDETAIL] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [warehouse] (
	ID integer NOT NULL IDENTITY,
	ID_productdetail integer NOT NULL,
	ID_admin integer NOT NULL,
  CONSTRAINT [PK_WAREHOUSE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [admin] (
	ID integer NOT NULL IDENTITY,
	username varchar(50) NOT NULL UNIQUE,
	password varchar(50) NOT NULL,
	name nvarchar(50) NOT NULL,
	address nvarchar(255) NOT NULL,
	phone varchar(11) NOT NULL,
	type integer NOT NULL,
  CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [orderdetail] (
	ID integer NOT NULL IDENTITY,
	ID_order integer NOT NULL,
	ID_product integer NOT NULL,
	ID_priceupdate integer NOT NULL,
	quantity float NOT NULL,
	discount float NOT NULL,
  CONSTRAINT [PK_ORDERDETAIL] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [order] (
	ID integer NOT NULL IDENTITY,
	ID_customer integer NOT NULL,
	ID_admin integer NOT NULL,
	order_date datetime NOT NULL,
	delivery_date datetime NOT NULL,
	address nvarchar(255) NOT NULL,
	name nvarchar(50),
	payment_type varchar(50) NOT NULL,
	shipping_type varchar(50),
	ship_cost float(50),
	status integer,
	note nvarchar(50),
  CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [customer] (
	ID integer NOT NULL ,
	name nvarchar(50) NOT NULL,
	address nvarchar(255),
	phone varchar(11) ,
	date_of_birth datetime,
	image nvarchar(255),
	email varchar(50) NOT NULL,
	status integer NOT NULL,
  CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [account] (
	ID integer NOT NULL IDENTITY,
	username varchar(50) NOT NULL UNIQUE,
	password varchar(50),
	type integer NOT NULL
  CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [priceupdate] (
	ID integer NOT NULL IDENTITY,
	ID_product integer NOT NULL,
	ID_admin integer NOT NULL,
	price float NOT NULL,
	date_update datetime NOT NULL,
	date_end datetime NOT NULL,
  CONSTRAINT [PK_PRICEUPDATE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [background](
		ID integer NOT NULL IDENTITY,
		name varchar(50),
		image nvarchar(100),
		description varchar(255) 
 )





ALTER TABLE [type] WITH CHECK ADD CONSTRAINT [type_fk0] FOREIGN KEY ([ID_category]) REFERENCES [category]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [type] CHECK CONSTRAINT [type_fk0]
GO


ALTER TABLE [product] WITH CHECK ADD CONSTRAINT [product_fk0] FOREIGN KEY ([ID_provider]) REFERENCES [provider]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [product] CHECK CONSTRAINT [product_fk0]
GO
ALTER TABLE [product] WITH CHECK ADD CONSTRAINT [product_fk1] FOREIGN KEY ([ID_type]) REFERENCES [type]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [product] CHECK CONSTRAINT [product_fk1]
GO

ALTER TABLE [productdetail] WITH CHECK ADD CONSTRAINT [productdetail_fk0] FOREIGN KEY ([ID_product]) REFERENCES [product]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [productdetail] CHECK CONSTRAINT [productdetail_fk0]
GO

ALTER TABLE [warehouse] WITH CHECK ADD CONSTRAINT [warehouse_fk0] FOREIGN KEY ([ID_productdetail]) REFERENCES [productdetail]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [warehouse] CHECK CONSTRAINT [warehouse_fk0]
GO
ALTER TABLE [warehouse] WITH CHECK ADD CONSTRAINT [warehouse_fk1] FOREIGN KEY ([ID_admin]) REFERENCES [admin]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [warehouse] CHECK CONSTRAINT [warehouse_fk1]
GO




ALTER TABLE [orderdetail] WITH CHECK ADD CONSTRAINT [orderdetail_fk0] FOREIGN KEY ([ID_order]) REFERENCES [order]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [orderdetail] CHECK CONSTRAINT [orderdetail_fk0]
GO
ALTER TABLE [orderdetail] WITH CHECK ADD CONSTRAINT [orderdetail_fk1] FOREIGN KEY ([ID_product]) REFERENCES [product]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [orderdetail] CHECK CONSTRAINT [orderdetail_fk1]
GO
ALTER TABLE [orderdetail] WITH CHECK ADD CONSTRAINT [orderdetail_fk2] FOREIGN KEY ([ID_priceupdate]) REFERENCES [priceupdate]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [orderdetail] CHECK CONSTRAINT [orderdetail_fk2]
GO

ALTER TABLE [order] WITH CHECK ADD CONSTRAINT [order_fk0] FOREIGN KEY ([ID_customer]) REFERENCES [customer]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [order] CHECK CONSTRAINT [order_fk0]
GO
ALTER TABLE [order] WITH CHECK ADD CONSTRAINT [order_fk1] FOREIGN KEY ([ID_admin]) REFERENCES [admin]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [order] CHECK CONSTRAINT [order_fk1]
GO


ALTER TABLE [customer] WITH CHECK ADD CONSTRAINT [customer_fk0] FOREIGN KEY ([ID]) REFERENCES [account]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [customer] CHECK CONSTRAINT [customer_fk0]
GO

ALTER TABLE [priceupdate] WITH CHECK ADD CONSTRAINT [priceupdate_fk0] FOREIGN KEY ([ID_product]) REFERENCES [product]([ID])
--ON UPDATE CASCADE
GO
ALTER TABLE [priceupdate] CHECK CONSTRAINT [priceupdate_fk0]
GO
ALTER TABLE [priceupdate] WITH CHECK ADD CONSTRAINT [priceupdate_fk1] FOREIGN KEY ([ID_admin]) REFERENCES [admin]([ID])
--ON UPDATE CASCADE
GO
ALTER TABLE [priceupdate] CHECK CONSTRAINT [priceupdate_fk1]
GO

insert into category(Name,image) values('Goceries','p2.jpg'),('Household','p3.jpg'),('PersonalCare','p4.jpg'),('packageFood','111.jpg')

insert into dbo.type(name,ID_category) values ('Foods',1),('Drinks',1),('Fruits',1),('Cakes',1)

insert into dbo.provider(name,address,phone) values 
(N'Trương Văn Nam', 'TPHCM','123456789'),
(N'Trần Phước Lộc', 'TPHCM','123456789'),
(N'Trần Trung Hiếu', 'TPHCM','0352460179'),
(N'Nguyễn Càn Long', 'TPHCM','1111111111')




insert into dbo.product(name,price,image,description,ID_provider,ID_type,discount) values
(N'Bò Húc',	15000,'bohuc.jpg',	NULL,	1,	2,	10),
(N'CoCa',	10000,'coca.jpg',	NULL,	2,	2,	0),
(N'Nước Cam',15000,'nuoccam.jpg',	NULL,	3,	2,	0),
(N'Nước Suối',5000,'nuocsuoi.jpg',	NULL,	3,	2,	0),
(N'Pepsi',15000,'pepsi.jpg',NULL,	2,	2,	0),
(N'Trà Xanh',10000,'traxanh.jpg',	NULL,	1,	2,	10),
(N'Bánh Mì',15000,'banhmi.jpg',	NULL,	1,	1,	20),
(N'Cơm Gà',	35000,'comga.jpg',	NULL,	1,	1,	0),
(N'Cơm Sường',25000,'comsuong.jpg',NULL,	1,	1,	20),
(N'Hambuger',20000,'hambuger.jpg',	NULL,	1,	1,	0),
(N'Nem Chua',15000,'nemchua.jpg',	NULL,	1,	1,	20),
(N'Xúc Xích',20000,'xucxich.jpg',	NULL,	1,	1,	0),
(N'Cam'		,50000,'cam.jpg',	NULL,	1,	3,	10),
(N'ổi'		,45000,'oi.jpg',	NULL,	1,	3,	0),
(N'Xoài'	,60000,'xoai.jpg',	NULL,	2,	3,	0)




INSERT INTO background(name,image,description) VALUES 
('BG1','11.jpg','Buy Rice Products Are Now On Line With Us'),
('BG2','22.jpg','Whole Spices Products Are Now On Line With Us'),
('BG3','44.jpg','Whole Spices Products Are Now On Line With Us')

insert into admin(username,password,name,address,phone,type) values ('admin','admin','Nam','hcm','0123456789',1)
select * from account
select * from customer
DELETE FROM account;
DELETE FROM customer;