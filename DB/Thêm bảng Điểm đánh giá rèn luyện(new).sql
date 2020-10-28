USE QUANLYSV
GO

CREATE TABLE DIEM_REN_LUYEN
(
	ma_sv CHAR(12) PRIMARY KEY,
	diem_ren_luyen_ki_1 int,
	diem_ren_luyen_ki_2 int,
	diem_ren_luyen_ki_3 int,
	diem_ren_luyen_ki_4 int,
	diem_ren_luyen_ki_5 int,
	diem_ren_luyen_ki_6 int,
	diem_ren_luyen_ki_7 int,
	diem_ren_luyen_ki_8 int,
	diem_ren_luyen_ki_9 int
	FOREIGN KEY (ma_sv) REFERENCES SINH_VIEN(ma_sv)
)
GO

INSERT DIEM_REN_LUYEN(ma_sv,diem_ren_luyen_ki_1,diem_ren_luyen_ki_2,diem_ren_luyen_ki_3,diem_ren_luyen_ki_4,diem_ren_luyen_ki_5,diem_ren_luyen_ki_6,diem_ren_luyen_ki_7,diem_ren_luyen_ki_8,diem_ren_luyen_ki_9) 
VALUES ('18810310205',90,92,90,97,96,90,88,90,98),
('18810310206',90,92,90,97,96,97,90,80,89),
('18810310207',80,92,87,92,30,90,88,80,60),
('18810310208',70,92,80,87,96,90,60,80,89),
('18810310209',60,20,88,60,70,60,40,80,40),
('18810310210',40,92,60,87,96,90,88,60,70),
('18810310211',50,60,80,87,96,40,20,80,89),
('18810310212',70,92,90,88,95,90,88,92,97),
('18810310213',80,92,60,87,96,88,88,80,89),
('18810310214',30,92,80,87,96,90,40,80,89),
('18810310215',20,20,92,87,70,90,88,60,89),
('18810310216',98,92,80,87,96,90,88,80,40)

--DELETE DIEM_REN_LUYEN WHERE 1= 1
