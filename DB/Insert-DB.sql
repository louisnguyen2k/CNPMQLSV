USE QUANLYSV

INSERT _ADMIN(tai_khoan,mat_khau) VALUES
('admin','admin'),
('18810310205','1234'),
('18810310206','5678')
GO
INSERT BAC_DAO_TAO(ma_bdt,ten_bdt,loai_hinh_dao_tao,thoi_gian_dao_tao) VALUES 
('BDT01',N'Đại học',N'Kỹ sư',5),
('BDT02',N'Cao đẳng',N'Kỹ sư',3)

INSERT KHOA(ma_k,ten_k) VALUES 
('K01',N'Công nghệ thông tin'),
('K02',N'Điện tử viễn thông'),
('K03',N'Kinh tế')

INSERT CHUYEN_NGANH(ma_cn,ten_cn,ma_k) VALUES
('CN01',N'Công nghệ phần mềm','K01'),
('CN02',N'Thương mại điện tử','K01'),
('CN03',N'Quản trị an ninh mạng','K01'),
('CN04',N'Tài chính ngân hàng','K03')

INSERT GIANG_VIEN(ma_gv,ten_gv,sdt_gv,thong_tin_lh,chuc_vu) VALUES
('GV01',N'Nguyễn Thị Thanh Tân','0923432443','0923432443',N'Giảng viên'),
('GV02',N'Phương Văn Cảnh','0927832652','0927832652',N'Giảng viên'),
('GV03',N'Nguyễn Thị Hồng Khánh','092783902','092783902',N'Giảng viên'),
('GV04',N'Cù Việt Dũng','0823432012','0823432012',N'Giảng viên')

INSERT MON_HOC(ma_mh,ten_mh,so_tc_mh,so_tiet_lt_mh,so_tiet_th_mh) VALUES
('MH01',N'Nhập môn tin học',2,15,15),
('MH02',N'Toán cao cấp 1',2,30,0),
('MH03',N'Toán cao cấp 2',2,30,0),
('MH04',N'Tiếng anh 1',3,45,0),
('MH05',N'Tiếng anh 2',2,30,0),
('MH06',N'Cấu trúc dữ liệu và giải thuật',3,30,15),
('MH07',N'Công nghệ phần mềm',3,30,15),
('MH08',N'Tiếng anh chuyên ngành',2,30,0),
('MH09',N'Cấu trúc dữ liệu và giải thuật nâng cao',3,30,15),
('MH10',N'Lập trình web',2,30,0),
('MH11',N'Lập trình hướng đối tượng',2,30,0),
('MH12',N'Lập trình Java',2,30,0),
('MH13',N'Lập trình .NET',2,30,0),
('MH14',N'Đồ án .NET',3,30,15),
('MH15',N'Nguyên lý hệ điều hành',2,30,0),
('MH16',N'Lập trình hệ thống',3,30,15),
('MH17',N'Toán rời rạc',3,45,0),
('MH18',N'Vật lý 1',2,30,0),
('MH19',N'Vật lý 2',2,30,0),
('MH20',N'Nhập môn trí tuệ nhân tạo',2,30,0),
('MH21',N'Lập trình web nâng cao',3,30,15),
('MH22',N'Giáo dục quốc phòng 1',2,30,0),
('MH23',N'Giáo dục quốc phòng 2',2,30,0),
('MH24',N'Giáo dục quốc phòng 3',2,30,0),
('MH25',N'Giáo dục quốc phòng 4',2,30,0),
('MH26',N'Giáo dục thể chất 1',2,30,0),
('MH27',N'Giáo dục thể chất 2',2,30,0),
('MH28',N'Giáo dục thể chất 3',2,30,0),
('MH29',N'Giáo dục thể chất 4',2,30,0),
('MH30',N'Kiến trúc máy tính',2,30,0),
('MH31',N'Pháp luật đại cương',2,30,0),
('MH32',N'Những Nguyên lý cơ bản của chủ nghĩa Mác – Lênin 1',2,30,0),
('MH33',N'Những Nguyên lý cơ bản của chủ nghĩa Mác – Lênin 2',2,30,0),
('MH34',N'Cơ sở dữ liệu',2,30,0),
('MH35',N'Hệ quản trị cơ sở dữ liệu',3,30,15),
('MH36',N'Mạng máy tính',2,30,0),
('MH37',N'Lập trình C',2,30,0),
('MH38',N'Lập trình C nâng cao',2,30,0),
('MH39',N'Phân tích thiết kế hệ thống thông tin',2,30,0),
('MH40',N'Phân tích thiết kế hệ thống hướng đối tượng',2,30,0),
('MH41',N'Đường lối cách mạng của Đảng CS Việt nam',2,30,0),
('MH42',N'Mạng không dây và di động',2,30,0),
('MH43',N'Xác suất thống kê',2,30,0),
('MH44',N'Đồ họa máy tính',2,30,0),
('MH45',N'Nhập môn An toàn và bảo mật thông tin',2,30,0),
('MH46',N'Tư tưởng Hồ Chí Minh',2,30,0),
('MH47',N'Lập trình trên thiết bị di động',3,30,15),
('MH48',N'Phần mềm mã nguồn mở',2,30,0),
('MH49',N'Chương trình dịch',2,30,0),
('MH50',N'Nhập môn học máy',2,30,0)


INSERT LOP(ma_lop,ten_lop,ma_gv,ma_cn) VALUES
('L01','D13CNPM3','GV01','CN01'),
('L02','D13CNPM3','GV02','CN01'),
('L03','D13CNPM3','GV03','CN03'),
('L04','D13CNPM2','GV01','CN01'),
('L05','D13CNPM2','GV01','CN01'),
('L06','D13CNPM2','GV04','CN02')

INSERT CHI_TIET_MON_HOC(ma_mh,ma_lop,ki_hoc,trang_thai_mh) VALUES
('MH01','L01',01,N'Đã học'),
('MH02','L01',01,N'Đã học'),
('MH03','L01',01,N'Đã học'),
('MH04','L02',01,N'Đã học'),
('MH05','L02',01,N'Đã học'),
('MH06','L02',01,N'Đã học'),
('MH07','L02',01,N'Đã học'),
('MH08','L01',01,N'Đã học'),
('MH09','L03',02,N'Đã học'),
('MH10','L03',02,N'Đã học'),
('MH11','L03',02,N'Đã học'),
('MH12','L01',02,N'Đã học'),
('MH13','L01',02,N'Đã học'),
('MH14','L01',02,N'Đã học'),
('MH15','L01',02,N'Đang học'),
('MH16','L01',02,N'Đang học'),
('MH17','L01',03,N'Đang học'),
('MH18','L04',03,N'Đang học'),
('MH19','L04',03,N'Đang học'),
('MH20','L04',03,N'Đang học'),
('MH21','L01',03,N'Chưa học'),
('MH22','L02',03,N'Chưa học'),
('MH23','L03',03,N'Chưa học'),
('MH24','L01',03,N'Chưa học'),
('MH25','L01',03,N'Chưa học'),
('MH26','L01',04,N'Chưa học'),
('MH27','L01',04,N'Chưa học'),
('MH28','L02',04,N'Chưa học'),
('MH29','L02',04,N'Chưa học'),
('MH30','L03',04,N'Chưa học'),
('MH31','L03',04,N'Chưa học'),
('MH32','L04',04,N'Chưa học'),
('MH33','L04',04,N'Chưa học'),
('MH34','L05',05,N'Chưa học'),
('MH35','L05',05,N'Chưa học'),
('MH36','L01',05,N'Chưa học'),
('MH37','L01',05,N'Chưa học'),
('MH38','L01',05,N'Chưa học'),
('MH39','L01',05,N'Chưa học'),
('MH40','L01',05,N'Chưa học'),
('MH41','L01',05,N'Chưa học'),
('MH42','L01',05,N'Chưa học'),
('MH43','L06',06,N'Chưa học'),
('MH44','L06',06,N'Chưa học'),
('MH45','L06',06,N'Chưa học'),
('MH46','L06',06,N'Chưa học'),
('MH47','L01',06,N'Chưa học'),
('MH48','L01',06,N'Chưa học'),
('MH49','L01',06,N'Chưa học'),
('MH50','L01',06,N'Chưa học')


------------
INSERT DIEM(ma_mh,ma_sv,diem_tp1,diem_tp2,diem_kt) VALUES
('MH01','18810310205',9,9,9),
('MH02','18810310205',7,8,7.7),
('MH03','18810310205',9,7,7.6),
('MH01','18810310207',10,9,9.3),
('MH02','18810310207',9,8,8.3),
('MH03','18810310207',9,9,9)

INSERT SINH_VIEN(ma_sv,ten_sv,gioitinh_sv,sdt_sv,email_sv,ngay_sinh_sv,noi_sinh_sv,dan_toc_sv,ton_giao_sv,khu_vuc_sv,cmnd_sv,ngay_cap_cmnd_sv,noi_cap_cmnd_sv,ho_khau_sv,dia_chi_sv,ngay_vao_truong_sv,chuc_vu_sv,link_img_sv,alt_img_sv,ten_cha,ngay_sinh_cha, nghe_nghiep_cha,sdt_cha,quoc_tich_cha,con_song_cha,ten_me,ngay_sinh_me,nghe_nghiep_me,sdt_me,quoc_tich_me,con_song_me,password_sv,ma_lop,ma_bdt,trang_thai_hoc,khoa_hoc_sv,cong_tac_doan,co_so,doi_tuong_sv,dien_chinh_sach_sv,ngay_vao_doan_sv,ngay_vao_dang_sv) VALUES
('18810310205',N'Trần Văn Định',1,'0912270469','dinh123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','035200000002','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Đạt','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Trần Thị Vi','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1234','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310206',N'Trần Văn Bình',1,'0912270469','binh123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','046200035003','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Tuấn','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Nguyễn Thị Nhi','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1235','L02','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310207',N'Trần Văn Nam',1,'0912270469','nam123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','035207305204','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Em','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Bùi Thị Bé','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1236','L02','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310208',N'Trần Văn Tuấn',1,'0912270469','tuan123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','020371000005','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Giang','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Lê Thị Hằng','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1237','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310209',N'Nguyễn Hiệp Lộc',1,'0912270469','loc123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','034920300006','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Nguyễn Văn Long','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Nguyễn Thị Mai','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1238','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310210',N'Nguyễn Thị Ngọc',0,'0912270469','ngoc123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','047200029307','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Nguyễn Văn Nam','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Vũ Thị Trang','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1239','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310211',N'Nguyễn Hà Trang',0,'0912270469','trang123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','032203307808','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Nguyễn Văn Lý','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Bùi Thị Oanh','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1210','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310212',N'Nguyễn Khánh Linh',0,'0912270469','linh123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','035200000009','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Nguyễn Văn Tùng','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Trần Thị Hà','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1211','L03','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310213',N'Vũ Hồng Khiêm',1,'0912270469','khiem123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','032937400010','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Vũ Văn Vở','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Lê Thị Nín ','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1212','L03','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310214',N'Nguyễn Văn Trãi',1,'0912270469','trai123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','035200000012','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Nguyễn Văn Tiến','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Lê Thị Thảo','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1213','L04','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310215',N'Trần Thị Nhung',0,'0912270469','nhung123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','033330498002','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Quyền','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Đỗ Thị Dung','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1214','L01','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null),
('18810310216',N'Trần Quang Vinh',1,'0912270469','vinh123@gmail.com','05-01-2000',N'Hà Nam',N'Kinh',N'Không',N'Hà Nội','064030037002','08-15-2016',N'Hà Nội',N'Hà Nội',N'Hà Nội','08-15-2018',N'Sinh viên','','',N'Trần Văn Lực','10-10-1976',N'Tự do','0912337890',N'Việt Nam',1,N'Đỗ Thị Mãi','10-10-1978',N'Tự do','0283137890',N'Việt Nam',1,'1215','L05','BDT01',N'Đang học','2018',N'Không',N'Cơ sở 1',N'Không',N'Không','04-30-2015',null)







