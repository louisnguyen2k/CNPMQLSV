USE QUANLYSV


-- ĐỔI MẬT KHẨU
UPDATE _ADMIN SET mat_khau = '' WHERE tai_khoan = ''


-- QUERY ĐĂNG NHẬP
SELECT COUNT(*) FROM _ADMIN
WHERE tai_khoan ='admin' AND mat_khau = 'admin'