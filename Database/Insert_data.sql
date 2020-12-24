INSERT INTO [category] ([name],[image]) VALUES
    ('Groceries','p2.jpg'),
    ('Household','p3.jpg'),
    ('Personal Care','p4.jpg'),
    ('Package Foods','111.jpg')

INSERT INTO [type] ([name],[ID_category]) VALUES
    (N'Dầu ăn - Gia vị - Đồ khô',1),
    (N'Đồ đông lạnh/mát',1),
    (N'Sữa - Sản phẩm từ sữa',1),
    (N'Hóa phẩm - Giấy',2),
    (N'Đồ dùng gia đình',2),
    (N'Chăm sóc cá nhân',3),
    (N'Chăm sóc cho bé',3),
    (N'Bánh kẹo - Đồ ăn vặt',4),
    (N'Đồ uống - Giải khát',4)

INSERT INTO [provider] ([name]) VALUES
    (N''),

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

Insert into priceupdate (ID_product,ID_admin,price,priceupdated) VALUES
(1, 1, 11100, 52352),
(2, 1, 12450, 54652),
(3, 1, 5453, 51232)

UPDATE priceupdate 
SET price = 135650
WHERE ID_product = 1

SELECT * FROM priceupdate FOR SYSTEM_TIME ALL