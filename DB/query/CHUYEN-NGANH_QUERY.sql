

SELECT ma_cn AS N'M� chuy�n ng�nh', ten_cn AS N'T�n chuy�n ng�nh', ma_k AS N'Khoa'
FROM CHUYEN_NGANH

INSERT INTO CHUYEN_NGANH(ma_cn, ten_cn, ma_k)
VALUES('',N'','')

UPDATE CHUYEN_NGANH SET ten_cn = N'', ma_k = '' 
WHERE ma_cn = ''

DELETE CHUYEN_NGANH WHERE ma_cn = ''
-- th�ng tin
SELECT ma_cn AS N'M� chuy�n ng�nh', ten_cn AS N'T�n chuy�n ng�nh', CHUYEN_NGANH.ma_k AS N'Khoa'
	FROM CHUYEN_NGANH , KHOA
	WHERE (ma_cn LIKE '%%' OR ten_cn LIKE N'%%' OR CHUYEN_NGANH.ma_k LIKE '%%' OR KHOA.ten_k LIKE N'%%') 
	AND CHUYEN_NGANH.ma_k = KHOA.ma_k