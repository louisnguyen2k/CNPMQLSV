USE QUANLYSV
GO

SELECT COUNT(*) FROM SINH_VIEN
WHERE ma_sv ='' AND password_sv = ''


UPDATE SINH_VIEN SET password_sv = '' WHERE ma_sv = ''