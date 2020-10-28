USE QUANLYSV

SELECT ma_gv AS N'Mã giảng viên', ten_gv AS N'Tên giảng viên', sdt_gv AS N'SĐT', thong_tin_lh AS N'Thông tin liên hệ', chuc_vu AS N'Chức vụ'
FROM GIANG_VIEN


INSERT INTO GIANG_VIEN(ma_gv, ten_gv, sdt_gv, thong_tin_lh, chuc_vu)
VALUES('', N'', '', N'', N'')


UPDATE GIANG_VIEN SET ten_gv = N'', sdt_gv = '', thong_tin_lh = N'', chuc_vu = N''
WHERE ma_gv = ''

DELETE GIANG_VIEN 
WHERE ma_gv = ''

SELECT ma_gv AS N'Mã giảng viên', ten_gv AS N'Tên giảng viên', sdt_gv AS N'SĐT', thong_tin_lh AS N'Thông tin liên hệ', chuc_vu AS N'Chức vụ'
	FROM GIANG_VIEN
	WHERE ma_gv LIKE '%%' 
	OR ten_gv LIKE N'%%' 
	OR sdt_gv LIKE '%%' 
	OR thong_tin_lh LIKE N'%%'
	OR chuc_vu LIKE N'%%'