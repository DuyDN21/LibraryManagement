------Insert admin-------
Insert into Admin ([AID], [Name], [Password]) Values
(1, 'DuyDN', '123'),
(2, 'LamVT', '123'),
(3, 'Admin', '123')

-------Insert Student-----
Insert into Student([StudentID], [StudentName], [Phone], [DOB], [Address]) Values
('HE160373', 'Do Ngoc Duy', '0816788886','20021021' ,'Hung Yen'),
('HE160434', 'Vuong Tung Lam', '0967564778','20020611' ,'Ha Noi'),
('HE161386', 'Cao Minh Ngoc', '0321456789','20020926' ,'TP Ho Chi Minh'),
('HE160676', 'Bui Thi Hoang Lan', '0879654644','20020721' ,'Can Tho'),
('HE160517', 'Pham Truong Minh Duc', '0777856222','20020531' ,'Da Nang'),
('HE160467', 'Pham Tien Manh', '0987654321','20020701' ,'Dak Lak'),
('HE161533', 'Lai The Dat', '0987890987','20020331' ,'Thai Nguyen'),
('HS150539', 'Bui Ngoc Quynh', '0567433345','20051008' ,'Ha Nam'),
('HE153721', 'Luong Thi Quyen', '0978777777','20021010' ,'Bac Giang'),
('HE153718', 'Nguyen Thien Thanh', '0987111666','20020504' ,'Bac Ninh')

--------Insert publisher------
Insert into Publisher(PublisherID, PublisherName) values
('NXB_T','NXB Tre'),
('NXB_KD','NXB Kim Dong'),
('NXB_THTPHCM','NXB Tong Hop TP Ho Chi Minh'),
('NXB_HNV','NXB Hoi Nha Van'),
('NXB_CTQGST','NXB Chinh Tri Quoc Gia Su That'),
('NXB_PNVN','NXB Phu Nu Viet Nam'),
('NXB_LD','NXB Lao Dong'),
('NXB_NN','Nha Nam'),
('NXB_DTB','Dinh Ti Books'),
('NXB_DA','Dong A')

------Insert authors------
Insert into Authors([AuthorID],[AuthorName]) values
('Au_1','Ho Anh Thai'),
('Au_2','Nguyen Vinh Nguyen'),
('Au_3','Nguyen Truong Quy'),
('Au_4','Do Bich Thuy'),
('Au_5','Nguyen Mai Chi'),
('Au_6','Vu Trong Phung'),
('Au_7','Ngo Tat To'),
('Au_8','Nguyen Hong'),
('Au_9','Nguyen Nhat Anh'),
('Au_10','Nguyen Ngoc Tu')

------Insert book category-----
Insert into BookCategories ([CategoryName]) values
('Chinh Tri - Phap Luat'),
('Khoa Hoc Cong Nghe - Kinh Te'),
('Van Hoc Nghe Thuat'),
('Van Hoa Xa Hoi - Lich Su'),
('Giao trinh'),
('Truyen - Tieu Thuyet'),
('Tam ly - Tam linh - Ton giao'),
('Thieu nhi')

------insert books-------
insert into Books ([BookID], [BookName], [Amount], [CategoryID], [AuthorID], [PublisherID]) values
('ngk','Nha Gia Kim',10,7,'Au_3','NXB_KD'),
('dnt','Dac Nhan Tam',12,5,'Au_4','NXB_KD'),
('sd','So Do',15,6,'Au_6','NXB_LD'),
('ctxmvdtt','Cho toi xin mot ve di tuoi tho',20,8,'Au_9','NXB_KD'),
('nnta','Nhung ngay tho au',25,6,'Au_8','NXB_NN'),
('td','Tat den',30,6,'Au_7','NXB_LD'),
('tthvtcx','Toi thay hoa vang tren co xanh',24,6,'Au_9','NXB_DA'),
('cdbt','Canh dong bat tan',18,6,'Au_8','NXB_DA'),
('mb','Mat biec',8,6,'Au_9','NXB_DA'),
('dmplk','De men phieu luu ky',9,8,'Au_2','NXB_KD')

-----insert borrow
insert into BorrowBook ([BookID], [StudentID],[BorrowedDate],[ReturnDate]) values
('mb', 'HE160373', '20230628', '20230707'),
('mb', 'HE160434', '20230628', '20230707'),
('ngk', 'HE160373', '20230628', '20230707')