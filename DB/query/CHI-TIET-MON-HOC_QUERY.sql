USE QUANLYSV


SELECT ma_mh, ten_mh FROM MON_HOC

SELECT ma_lop, ten_lop FROM LOP




SELECT ROW_NUMBER() OVER (ORDER BY CHI_TIET_MON_HOC.ma_mh, CHI_TIET_MON_HOC.ma_lop) AS [STT],
ma_mh AS N'Mã môn học',
ma_lop AS N'Mã lớp',
ki_hoc AS N'Kì học',
trang_thai_mh AS N'Trạng thái môn học'
FROM CHI_TIET_MON_HOC

INSERT INTO CHI_TIET_MON_HOC(ma_mh, ma_lop, ki_hoc, trang_thai_mh)
VALUES('', '', , N'')

UPDATE CHI_TIET_MON_HOC SET  ki_hoc = , trang_thai_mh = ''
WHERE ma_mh = '' AND ma_lop = ''

DELETE CHI_TIET_MON_HOC WHERE ma_mh = '' AND  ma_lop = ''


SELECT ROW_NUMBER() OVER (ORDER BY CTMH.ma_mh, CTMH.ma_lop) AS [STT],
	CTMH.ma_mh AS N'Mã môn học',
	CTMH.ma_lop AS N'Mã lớp',
	ki_hoc AS N'Kì học',
	trang_thai_mh AS N'Trạng thái môn học'
FROM CHI_TIET_MON_HOC AS CTMH,
	MON_HOC AS MH,
	LOP AS L
	WHERE CTMH.ma_mh = MH.ma_mh
AND CTMH.ma_lop = L.ma_lop
AND(CTMH.ma_mh LIKE '%%' OR MH.ten_mh LIKE N'%%'
	OR CTMH.ma_lop LIKE '%%' OR L.ten_lop LIKE N'%%'
	OR trang_thai_mh LIKE N'%%')