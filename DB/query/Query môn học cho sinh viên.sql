
USE QUANLYSV
GO

--Query môn học sinh viên
SELECT MON_HOC.ma_mh, MON_HOC.ten_mh
    FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
        WHERE SINH_VIEN.ma_lop = LOP.ma_lop
	    AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop
	    AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
		AND SINH_VIEN.ma_sv = '18810310205'

-- update

UPDATE CHI_TIET_MON_HOC SET trang_thai_mh = N''
WHERE ma_mh = '' AND ma_lop = ''




