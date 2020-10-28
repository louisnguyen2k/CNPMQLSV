
USE QUANLYSV
GO

SELECT ROW_NUMBER() OVER (ORDER BY MON_HOC.ma_mh) AS [STT],
    MON_HOC.ten_mh AS N'Tên môn học',
	MON_HOC.so_tc_mh AS N'Số tín chỉ',
    DIEM.diem_tp1 AS N'Điểm thành phần 1',
	DIEM.diem_tp2 AS N'Điểm thành phần 2',
	DIEM.diem_kt AS N'Điểm kết thúc',
	(((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10 AS N'Điểm tổng kết'
FROM SINH_VIEN, DIEM, MON_HOC
WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
AND DIEM.ma_mh = MON_HOC.ma_mh
AND SINH_VIEN.ma_sv = '18810310205'
AND MON_HOC.ten_mh LIKE N'%%'

SELECT MON_HOC.ma_mh, MON_HOC.ten_mh
                            FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                                WHERE SINH_VIEN.ma_lop = LOP.ma_lop

                                AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop

                                AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	                            AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
                                AND SINH_VIEN.ma_sv = '18810310205'








SELECT MON_HOC.ma_mh, MON_HOC.ten_mh
FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
    WHERE SINH_VIEN.ma_lop = LOP.ma_lop

    AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop

    AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đang học'
    AND SINH_VIEN.ma_sv = '" + NameUser + "'


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
	                        AND ten_mh LIKE N'%%'


UPDATE DIEM SET diem_tp1 = 1, diem_tp2 =2, diem_kt = 3
WHERE ma_mh = '' AND ma_sv = ''


SELECT COUNT(*) FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC
WHERE SINH_VIEN.ma_lop = LOP.ma_lop
AND CHI_TIET_MON_HOC.ma_lop = LOP.ma_lop
AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
AND SINH_VIEN.ma_sv = '18810310205'

SELECT SUM(MON_HOC.so_tc_mh) FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
WHERE SINH_VIEN.ma_lop = LOP.ma_lop
AND CHI_TIET_MON_HOC.ma_lop = LOP.ma_lop
AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
AND SINH_VIEN.ma_sv = '18810310205'


SELECT AVG((((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10) FROM SINH_VIEN, DIEM
WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
AND SINH_VIEN.ma_sv = '18810310205'

SELECT (((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10, MON_HOC.so_tc_mh FROM SINH_VIEN, DIEM,MON_HOC
WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
AND DIEM.ma_mh = MON_HOC.ma_mh
AND SINH_VIEN.ma_sv = '18810310205'