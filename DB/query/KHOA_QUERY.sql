USE QUANLYSV

SELECT ma_k AS N'M� khoa', ten_k AS N'T�n khoa'
FROM KHOA
WHERE ma_k LIKE '%%' OR ten_k LIKE N'%%'



INSERT INTO KHOA(ma_k, ten_k)
VALUES('',N'')




UPDATE KHOA SET ten_k = N'' WHERE ma_k = ''




DELETE KHOA WHERE ma_k = ''