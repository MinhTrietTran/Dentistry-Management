-- Thêm thông tin của 2 cuộc hẹn
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES
('2024-01-20 08:00', 1, 1, N'Hẹn khám răng, đến muộn 30 phút', '2024-01-14', 1024, 1018, 1030, 105),
('2024-01-21 09:30', 2, 0, N'Hẹn điều trị răng số 3', '2024-01-15', 1025, 1019, 1031, 106)

-- Thêm thông tin của 3 cuộc hẹn cho các phòng
-- Cuộc hẹn cho phòng 502
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-22 10:00', 1, 1, N'Hẹn kiểm tra răng, làm sạch răng', '2024-01-16', 1026, 1020, 1032, 502);

-- Cuộc hẹn cho phòng 501
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-23 11:30', 2, 0, N'Hẹn điều trị răng sâu', '2024-01-17', 1027, 1021, 1033, 501);

-- Cuộc hẹn cho phòng 304
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-24 13:00', 3, 1, N'Hẹn kiểm tra và làm răng số 5', '2024-01-18', 1028, 1022, 1034, 304);

-- Cuộc hẹn cho phòng 304
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-25 13:00', 3, 1, N'Hẹn kiểm tra và làm răng số 8', '2024-01-2', 1028, 6, 5, 304);

INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-02-1 8:00', 3, 1, N'Hẹn kiểm tra và làm trắng răng', '2024-01-6', 1028, 3, 5, 309);

INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-28 14:00', 3, 1, N'Hẹn kiểm tra và làm rang so 2', '2024-01-10', 1031, 1033, 1032, 509);

INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-02-9 13:00', 1, 0, N'Hẹn kiểm tra và làm răng số 8', '2024-01-2', 1028, 1015, 1016, 509);
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-02-9 13:00', 1, 0, N'Hẹn kiểm tra và làm răng số 8', '2024-01-2', 1021, 1025, 1030, 406);
INSERT INTO CuocHen (GioCH, ThuTuCH, IsLanDau, GhiChu, NgayGui, BenhNhan, NhaSi, TroLy, Phong)
VALUES ('2024-01-23 10:00', 2, 1, N'Hẹn kiểm tra niềng răng', '2024-01-15', 1031, 1015, 1016, 303);