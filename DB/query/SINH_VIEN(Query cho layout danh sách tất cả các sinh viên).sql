USE QUANLYSV

-- query cơ bản (không full TABLE SINH_VIEN)
SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	ma_sv AS N'Mã sinh viên',
	ten_sv AS N'Tên sinh viên',
	gioitinh_sv AS N'Giới tính',
	sdt_sv AS N'SĐT',
	email_sv AS N'Email',
	ngay_sinh_sv AS N'Ngày sinh',
	cmnd_sv AS N'CMND',
	dia_chi_sv AS N'Địa chỉ'
FROM SINH_VIEN

SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	ma_sv AS N'Mã sinh viên',
	ten_sv AS N'Tên sinh viên',
	gioitinh_sv AS N'Giới tính',
	sdt_sv AS N'SĐT',
	email_sv AS N'Email',
	ngay_sinh_sv AS N'Ngày sinh',
	cmnd_sv AS N'CMND',
	dia_chi_sv AS N'Địa chỉ'
FROM SINH_VIEN
    WHERE ma_sv LIKE '%" + key + "%' OR ten_sv LIKE N'%" + key + "%'