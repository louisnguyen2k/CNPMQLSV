USE QUANLYSV
GO

SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
GROUP BY SINH_VIEN.ma_sv
HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) >= 7.5
AND AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) < 8.5

