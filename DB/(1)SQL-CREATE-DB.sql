CREATE DATABASE QUANLYSV
GO

USE QUANLYSV
GO
-- 1. TẠO BẢNG KHOA
CREATE TABLE KHOA(
	ma_k CHAR(12) PRIMARY KEY, -- Mã Khoa (PK)
	ten_k NVARCHAR(50),		   -- Tên Khoa
)
GO


-- 2. TẠO BẢNG CHUYÊN NGÀNH
CREATE TABLE CHUYEN_NGANH(
	ma_cn CHAR(12) PRIMARY KEY, -- Mã chuyên ngành (PK)
	ten_cn NVARCHAR(50),		-- Tên chuyên ngành
	ma_k CHAR(12),				-- Mã khoa (FK - KHOA)
	--------------------------------------------------
	FOREIGN KEY(ma_k) REFERENCES  dbo.KHOA(ma_k), -- Tạo khóa ngoại (ma_k - KHOA)
)
GO

-- 3. TẠO BẢNG GIẢNG VIÊN
CREATE TABLE GIANG_VIEN(
	ma_gv CHAR(12) PRIMARY KEY, -- Mã giảng viên (PK)
	ten_gv NVARCHAR(50),		-- Tên giảng viên
	sdt_gv CHAR(11),			-- Số điện thoại giảng viên
	thong_tin_lh NVARCHAR(150),	-- Thông tin liên hệ (Địa chỉ)
	chuc_vu NVARCHAR(50)		-- Chức vụ nắm giữ (vd: cố vấn học tập, bí thư đoàn, trưởng khoa,...)
)
GO

-- 4. TẠO BẢNG LỚP
CREATE TABLE LOP(
	ma_lop CHAR(12) PRIMARY KEY, -- Mã lớp (PK)
	ten_lop NVARCHAR(50),		-- Tên giảng viên
	ma_gv CHAR(12),				-- Mã giảng viên phụ trách lớp (FK - GIANG_VIEN)
	ma_cn CHAR(12),				-- Mã chuyên ngành của lớp đang học (FK - CHUYEN_NGANH)
	--------------------------------------------------
	FOREIGN KEY(ma_gv) REFERENCES  dbo.GIANG_VIEN(ma_gv), -- Tạo khóa ngoại (ma_gv - GIANG_VIEN)
	FOREIGN KEY(ma_cn) REFERENCES  dbo.CHUYEN_NGANH(ma_cn), -- Tạo khóa ngoại(ma_cn - CHUYEN_NGANH)
)
GO



-- 5. TẠO BẢNG BẬC ĐÀO TẠO
CREATE TABLE BAC_DAO_TAO(
	ma_bdt CHAR(12) PRIMARY KEY,	-- Mã bậc đào tạo (PK)
	ten_bdt NVARCHAR(50),			-- Tên bậc đào tạo (VD: Đại học - tín chỉ, Cao đẳng - tín chỉ, Thạc sĩ, Kĩ sư,...)
	loai_hinh_dao_tao NVARCHAR(50),	-- Loại hình đào tạo (VD: Chính quy, liên thông, vừa học vừa làm,...)
	thoi_gian_dao_tao FLOAT,		-- Thời gian đào tạo (Đơn vị năm)
)
GO


-- 6. TẠO BẢNG SINH VIÊN
CREATE TABLE SINH_VIEN(
	ma_sv CHAR(12) PRIMARY KEY,		-- Mã sinh viên (PK)
	ten_sv NVARCHAR(50),			-- Tên sinh viên
	gioitinh_sv BIT,				-- Giới tính sinh viên (1 là nam, 0 là nữ)
	sdt_sv CHAR(11),				-- Số điện thoại sinh viên
	email_sv NCHAR(50),				-- Email sinh viên
	ngay_sinh_sv DATE,				-- Ngày sinh sinh viên
	noi_sinh_sv NVARCHAR(50),		-- Nơi sinh sinh viên
	dan_toc_sv NVARCHAR(20),		-- Dân tộc sinh viên
	ton_giao_sv NVARCHAR(15),		-- Tôn giáo sinh viên
	khu_vuc_sv NVARCHAR(20),		-- Khu vực sinh viên
	cmnd_sv	CHAR(13),				-- Số CMND sinh viên
	ngay_cap_cmnd_sv DATE,			-- Ngày cấp CMND sinh viên
	noi_cap_cmnd_sv NVARCHAR(70),	-- Nơi cấp CMND sinh viên
	ho_khau_sv NVARCHAR(150),		-- Hộ khẩu sinh viên
	dia_chi_sv NVARCHAR(150),		-- Địa chỉ sinh viên
	ngay_vao_truong_sv DATE,		-- Ngày vào trường của sinh viên
	chuc_vu_sv NVARCHAR(30),		-- Chức vụ của sinh viên
	link_img_sv IMAGE,				-- Đường link dẫn tới ảnh của sinh viên
	alt_img_sv NVARCHAR(200),		-- Mô tả của ảnh sinh viên
	----------------- Thông tin cha sinh viên -----------------
	ten_cha NVARCHAR(50),		-- Tên cha của sinh viên
	ngay_sinh_cha DATE,				-- Ngày sinh của cha sinh viên
	nghe_nghiep_cha NVARCHAR(150),	-- Nghề nghiệp của cha
	sdt_cha CHAR(11),				-- Số điện thoại cha
	quoc_tich_cha NVARCHAR(30),		-- Quốc tịch của cha
	con_song_cha BIT,				-- Cha còn sống hay đã mất(1 là còn sống, 0 là đã mất)
	----------------- Thông tin mẹ sinh viên -----------------
	ten_me NVARCHAR(50),			-- Tên mẹ của sinh viên
	ngay_sinh_me DATE,				-- Ngày sinh của mẹ sinh viên
	nghe_nghiep_me NVARCHAR(150),	-- Nghề nghiệp của mẹ
	sdt_me CHAR(11),				-- Số điện thoại mẹ
	quoc_tich_me NVARCHAR(30),		-- Quốc tịch của mẹ
	con_song_me BIT,				-- Mẹ còn sống hay đã mất(1 là còn sống, 0 là đã mất)
	-----------------------------------------------------
	password_sv CHAR(30),			-- Mật khẩu tài khoản đăng nhập sinh viên
	ma_lop CHAR(12),				-- Mã lớp (FK - LOP)
	ma_bdt CHAR(12),				-- Mã bậc đào tạo (FK - BAC_DAO_TAO)
	------------------------------------------------------
	FOREIGN KEY(ma_lop) REFERENCES  dbo.LOP(ma_lop),			-- Tạo khóa ngoại (ma_lop - LOP)
	FOREIGN KEY(ma_bdt) REFERENCES  dbo.BAC_DAO_TAO(ma_bdt),	-- Tạo khóa ngoại (ma_bdt - BAC_DAO_TAO)
)
GO



-- 7. TẠO BẢNG MÔN HỌC
CREATE TABLE MON_HOC(
	ma_mh CHAR(12) PRIMARY KEY, -- Mã môn học (PK)
	ten_mh NVARCHAR(50),		-- Tên môn học
	so_tc_mh TINYINT,			-- Số tín chỉ của môn học
	so_tiet_lt_mh TINYINT,		-- Số tiết lý thuyết của môn học
	so_tiet_th_mh TINYINT,		-- Số tiết thực hành của môn học
)
GO

-- 8. TẠO BẢNG CHI TIẾT MÔN HỌC
CREATE TABLE CHI_TIET_MON_HOC(
	ma_mh CHAR(12),				-- Mã môn học (PK)
	ma_lop CHAR(12),			-- Mã lớp học (PK)
	PRIMARY KEY(ma_mh, ma_lop), -- tạo khóa chính kép của bảng là 2 trường ma_mh và ma_lop
	--------------------------------------------
	ki_hoc TINYINT,				-- Kì học môn học (1->9)
	trang_thai_mh NVARCHAR(50),	-- Trạng thái môn học (VD: đang học, chưa học,...)
	--------------------------------------------
	FOREIGN KEY(ma_mh) REFERENCES  dbo.MON_HOC(ma_mh),	-- Tạo khóa ngoại (ma_mh - MON_HOC)
	FOREIGN KEY(ma_lop) REFERENCES  dbo.LOP(ma_lop),	-- Tạo khóa ngoại (ma_lop - LOP)
)
GO

-- 9. TẠO BẢNG ĐIỂM
CREATE TABLE DIEM(
	ma_mh CHAR(12),				-- Mã môn học (PK)
	ma_sv CHAR(12),				-- Mã sinh viên (PK)
	PRIMARY KEY(ma_mh, ma_sv),	-- tạo khóa chính kép của bảng là 2 trường ma_mh và ma_sv
	--------------------------------------------
	diem_tp1 FLOAT,				-- Điểm thành phần 1
	diem_tp2 FLOAT,				-- Điểm thành phần 2
	diem_kt FLOAT,				-- Điểm kết thúc môn học
	co_duoc_thi BIT,			-- Có được thi không? (1 là có được thi, 0 là không được thi)
	--------------------------------------------
	FOREIGN KEY(ma_mh) REFERENCES  dbo.MON_HOC(ma_mh),	-- Tạo khóa ngoại (ma_mh - MON_HOC)
	FOREIGN KEY(ma_sv) REFERENCES  dbo.SINH_VIEN(ma_sv),	-- Tạo khóa ngoại (ma_sv - SINH_VIEN)
)
GO


-- 10. TÀI KHOẢN ADMIN
CREATE TABLE _ADMIN(
	tai_khoan VARCHAR(16) PRIMARY KEY,	-- Tài khoản admin (PK)
	mat_khau VARCHAR(16)				-- Mật khẩu admin
)
GO

-- INSERT TÀI KHOẢN ADMIN: admin-admin
INSERT INTO _ADMIN(tai_khoan, mat_khau)
	VALUES('admin','admin')

