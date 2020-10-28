USE QUANLYSV
GO

SELECT * FROM SINH_VIEN
WHERE ma_sv = '18810310208'
GO


SELECT ten_bdt FROM BAC_DAO_TAO
WHERE ma_bdt = 'BDT01'
GO

SELECT loai_hinh_dao_tao FROM BAC_DAO_TAO
WHERE ma_bdt = 'BDT01'
GO


SELECT KHOA.ten_k FROM LOP, CHUYEN_NGANH, KHOA
WHERE LOP.ma_cn = CHUYEN_NGANH.ma_cn
AND KHOA.ma_k = CHUYEN_NGANH.ma_k
AND LOP.ma_lop = 'CNPM1'
GO


-----
SELECT CHUYEN_NGANH.ten_cn FROM LOP, CHUYEN_NGANH
WHERE LOP.ma_cn = CHUYEN_NGANH.ma_cn
AND LOP.ma_lop = 'CNPM1'
GO


SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		+diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		+diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
FROM DIEM_REN_LUYEN,SINH_VIEN
WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		+diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		+diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 >=80
AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		+diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		+diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 <90