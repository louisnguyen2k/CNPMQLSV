USE QUANLYSV

--
SELECT ma_bdt AS N'Mã bậc đào tạo', ten_bdt AS N'Tên bậc đào tạo', loai_hinh_dao_tao AS N'Loại hình đào tạo', thoi_gian_dao_tao AS N'Thời gian đào tạo'
FROM BAC_DAO_TAO WHERE ma_bdt LIKE '%Đại%' OR ten_bdt LIKE N'%Đại%' OR loai_hinh_dao_tao LIKE N'%Đại%' OR thoi_gian_dao_tao LIKE '%Đại%'


--
INSERT INTO BAC_DAO_TAO(ma_bdt, ten_bdt, loai_hinh_dao_tao, thoi_gian_dao_tao)
VALUES('',N'',N'',0)

--
UPDATE BAC_DAO_TAO 
SET ten_bdt = N'', loai_hinh_dao_tao = N'', thoi_gian_dao_tao = 0 
WHERE ma_bdt =''
--
DELETE BAC_DAO_TAO WHERE ma_bdt =''
--
SELECT ma_bdt AS N'Mã bậc đào tạo',
	ten_bdt AS N'Tên bậc đào tạo',
	loai_hinh_dao_tao AS N'Loại hình đào tạo',
	thoi_gian_dao_tao AS N'Thời gian đào tạo'
FROM BAC_DAO_TAO
WHERE ma_bdt LIKE '%%'
	AND ten_bdt LIKE N'%%'
	AND loai_hinh_dao_tao LIKE N'%%'
	AND thoi_gian_dao_tao LIKE '%%'










