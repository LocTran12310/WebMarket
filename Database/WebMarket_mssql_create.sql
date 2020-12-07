USE [master]
GO

DROP DATABASE [WebMarket]
CREATE DATABASE [WebMarket]
GO

USE [WebMarket]
GO

CREATE TABLE [category] (
	ID integer NOT NULL,
	Name nvarchar(50) NOT NULL UNIQUE,
	image varchar(255)
  CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

CREATE TABLE [type] (
	ID integer NOT NULL,
	name nvarchar(50) NOT NULL UNIQUE,
	ID_category integer NOT NULL,
  CONSTRAINT [PK_TYPE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [provider] (
	ID integer NOT NULL,
	name nvarchar(50) NOT NULL UNIQUE,
	address nvarchar(50) NOT NULL,
	phone varchar(11) NOT NULL,
  CONSTRAINT [PK_PROVIDER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [product] (
	ID integer NOT NULL,
	name nvarchar(50) NOT NULL UNIQUE,
	price float,
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
	ID integer NOT NULL,
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
	ID integer NOT NULL,
	ID_productdetail integer NOT NULL,
	ID_admin integer NOT NULL,
  CONSTRAINT [PK_WAREHOUSE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [admin] (
	ID integer NOT NULL,
	username varchar(50) NOT NULL UNIQUE,
	password varchar(50) NOT NULL,
	name varchar(50) NOT NULL,
	address varchar(50) NOT NULL,
	phone varchar(11) NOT NULL,
	type integer NOT NULL,
  CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [image] (
	ID integer NOT NULL,
	ID_product integer NOT NULL,
	name varchar(50) NOT NULL,
	image varchar(255) NOT NULL,
  CONSTRAINT [PK_IMAGE] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [orderdetail] (
	ID integer NOT NULL,
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
	ID integer NOT NULL,
	ID_customer integer NOT NULL,
	ID_admin integer NOT NULL,
	order_date datetime NOT NULL,
	delivery_date datetime NOT NULL,
	address varchar(50) NOT NULL,
	name varchar(50),
	payment_type varchar(50) NOT NULL,
	shipping_type varchar(50),
	ship_cost float(50),
	status integer,
	note varchar(50),
  CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [customer] (
	ID integer NOT NULL,
	name varchar(50) NOT NULL,
	address varchar(50),
	phone varchar(11) NOT NULL,
	date_of_birth datetime NOT NULL,
	image varchar(50),
	email varchar(50) NOT NULL,
	status integer NOT NULL,
  CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [account] (
	ID integer NOT NULL,
	username varchar(50) NOT NULL UNIQUE,
	password varchar(50),
	type integer NOT NULL,
	ID_customer integer NOT NULL,
  CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [priceupdate] (
	ID integer NOT NULL,
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
CREATE TABLE [cart] (
	ID integer NOT NULL,
	ID_product integer NOT NULL,
	ID_customer integer NOT NULL,
	quantity integer NOT NULL,
  CONSTRAINT [PK_CART] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [background](
		ID integer NOT NULL IDENTITY,
		name varchar(50),
		image varchar(255),
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


ALTER TABLE [image] WITH CHECK ADD CONSTRAINT [image_fk0] FOREIGN KEY ([ID_product]) REFERENCES [product]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [image] CHECK CONSTRAINT [image_fk0]
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


ALTER TABLE [account] WITH CHECK ADD CONSTRAINT [account_fk0] FOREIGN KEY ([ID_customer]) REFERENCES [customer]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [account] CHECK CONSTRAINT [account_fk0]
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

ALTER TABLE [cart] WITH CHECK ADD CONSTRAINT [cart_fk0] FOREIGN KEY ([ID_product]) REFERENCES [product]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [cart] CHECK CONSTRAINT [cart_fk0]
GO
ALTER TABLE [cart] WITH CHECK ADD CONSTRAINT [cart_fk1] FOREIGN KEY ([ID_customer]) REFERENCES [customer]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [cart] CHECK CONSTRAINT [cart_fk1]
GO
insert into category values(1,'Goceries','b3.jpg')
lỗi đết đâu
ủa kì v

