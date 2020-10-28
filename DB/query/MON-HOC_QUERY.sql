USE QUANLYSV


SELECT ROW_NUMBER() OVER (ORDER BY ma_mh) AS [STT],
ma_mh AS N'Mã môn học',
ten_mh AS N'Tên môn học',
so_tc_mh AS N'Số tín chỉ',
so_tiet_lt_mh AS N'Số tiết lý thuyết',
so_tiet_th_mh AS N'Số tiết thực hành'
FROM MON_HOC

INSERT INTO MON_HOC(ma_mh, ten_mh, so_tc_mh, so_tiet_lt_mh, so_tiet_th_mh)
VALUES('', N'', , , )


UPDATE MON_HOC SET ten_mh = N'', so_tc_mh = , so_tiet_lt_mh = , so_tiet_th_mh = WHERE ma_mh = ''


DELETE MON_HOC 
WHERE ma_mh = ''


SELECT ROW_NUMBER() OVER (ORDER BY ma_mh) AS [STT],
ma_mh AS N'Mã môn học',
ten_mh AS N'Tên môn học',
so_tc_mh AS N'Số tín chỉ',
so_tiet_lt_mh AS N'Số tiết lý thuyết',
so_tiet_th_mh AS N'Số tiết thực hành'
FROM MON_HOC
WHERE ma_mh LIKE '%%'
OR ten_mh LIKE N'%%'