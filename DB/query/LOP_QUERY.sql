USE QUANLYSV


SELECT ROW_NUMBER() OVER (ORDER BY ma_lop) AS [STT], ma_lop AS N'Mã lớp', ten_lop AS N'Tên lớp', ma_gv AS N'Giáo viên chủ nhiệm', ma_cn AS N'Chuyên ngành'
FROM LOP


INSERT INTO LOP(ma_lop, ten_lop, ma_gv, ma_cn)
VALUES('', N'', '', '')

UPDATE LOP SET ten_lop = N'', ma_gv = '', ma_cn = ''
WHERE ma_lop = ''

DELETE LOP WHERE ma_lop = ''


SELECT ROW_NUMBER() OVER (ORDER BY ma_lop) AS [STT], ma_lop AS N'Mã lớp', ten_lop AS N'Tên lớp', LOP.ma_gv AS N'Giáo viên chủ nhiệm', LOP.ma_cn AS N'Chuyên ngành'
FROM LOP, GIANG_VIEN, CHUYEN_NGANH
WHERE (ma_lop LIKE '%%' OR ten_lop LIKE N'%%' OR LOP.ma_gv LIKE '%%' OR LOP.ma_cn LIKE '%%' OR GIANG_VIEN.ten_gv LIKE N'' OR CHUYEN_NGANH.ten_cn LIKE N'')
AND LOP.ma_gv = GIANG_VIEN.ma_gv
AND LOP.ma_cn = CHUYEN_NGANH.ma_cn