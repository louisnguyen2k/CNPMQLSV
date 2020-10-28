USE QUANLYSV
GO



SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	MON_HOC.ten_mh AS N'Tên môn học',
	MON_HOC.so_tc_mh AS N'Số tín chỉ',
	MON_HOC.so_tiet_lt_mh AS N'Số tiết lý thuyết',
	MON_HOC.so_tiet_th_mh AS N'Số tiết thực hành',
	CHI_TIET_MON_HOC.trang_thai_mh AS N'Trạng thái'
FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
    WHERE SINH_VIEN.ma_lop = LOP.ma_lop
	AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop
	AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	AND SINH_VIEN.ma_sv = '18810310205'

SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	                        MON_HOC.ten_mh AS N'Tên môn học',
	                        MON_HOC.so_tc_mh AS N'Số tín chỉ',
	                        MON_HOC.so_tiet_lt_mh AS N'Số tiết lý thuyết',
	                        MON_HOC.so_tiet_th_mh AS N'Số tiết thực hành',
	                        CHI_TIET_MON_HOC.trang_thai_mh AS N'Trạng thái'
                        FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                            WHERE SINH_VIEN.ma_lop = LOP.ma_lop
	                        AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop
	                        AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	                        AND ten_mh LIKE N'%" + key + "%'