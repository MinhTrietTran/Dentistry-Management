--- Hàm xem cuộc hẹn

USE master
GO

CREATE FUNCTION xem_cuoc_hen
(
@ApID VARCHAR(10)
)
RETURNS TABLE
AS
BEGIN

RETURN
(
SELECT
    id,
    appointment_time,
    appointment_order,
    is_first_time,
    notes,
    sent_date,
    patient,
    doctor,
    assistant,
    room,
    previous_appointment
FROM
    appointment
WHERE
    id = @ApID
);

END;
GO

----Hàm này nhận vào một tham số @ApID là ID của cuộc hẹn cần xem. Hàm sẽ trả về một bảng chứa các thông tin của cuộc hẹn đó.

--Ví dụ sử dụng
/*DECLARE @ApID VARCHAR(10) = '123456';

SELECT *
FROM xem_cuoc_hen @ApID;*/

---Hàm này nhận vào một tham số @ApID là ID của cuộc hẹn cần xem. Hàm sẽ sử dụng câu lệnh SELECT để truy vấn bảng appointment và trả về một bảng chứa các thông tin của cuộc hẹn đó.





--- Hàm xoá cuộc hẹn



USE master
GO
CREATE FUNCTION xoa_cuoc_hen
(
@ApID VARCHAR(10)
)
RETURNS INT
AS
BEGIN

DELETE
FROM
    appointment
WHERE
    id = @ApID

RETURN
    1;
END;
GO

---Hàm này nhận vào một tham số @ApID là ID của cuộc hẹn cần xoá. Hàm sẽ sử dụng câu lệnh DELETE để xoá bản ghi trong bảng appointment có ID bằng @ApID.

/*
Ví dụ sử dụng : 
DECLARE @ApID VARCHAR(10) = '123456';

EXEC xoa_cuoc_hen @ApID;
*/





---Hàm thêm cuộc hẹn

USE master
GO

CREATE FUNCTION them_cuoc_hen
(
@ApTime DATETIME,
@ApOrder INT,
@IsFirstTime BIT,
@Notes NVARCHAR(100),
@SentDate DATE,
@Patient VARCHAR(10),
@Doctor VARCHAR(10),
@Assistant VARCHAR(10),
@Room VARCHAR(4),
@PreviousAp VARCHAR(10)
)
RETURNS INT
AS
BEGIN

INSERT INTO appointment
(
    appointment_time,
    appointment_order,
    is_first_time,
    notes,
    sent_date,
    patient,
    doctor,
    assistant,
    room,
    previous_appointment
)
VALUES
(
    @ApTime,
    @ApOrder,
    @IsFirstTime,
    @Notes,
    @SentDate,
    @Patient,
    @Doctor,
    @Assistant,
    @Room,
    @PreviousAp
)

RETURN
    SCOPE_IDENTITY();

END;
GO

/*
Ví dụ sử dụng : 
DECLARE @ApTime DATETIME = '2023-08-25 10:00:00';
DECLARE @ApOrder INT = 1;
DECLARE @IsFirstTime BIT = 1;
DECLARE @Notes NVARCHAR(100) = 'Ghi chú cuộc hẹn';
DECLARE @SentDate DATE = '2023-08-25 12:00:00';
DECLARE @Patient VARCHAR(10) = '1';
DECLARE @Doctor VARCHAR(10) = 'Bác sĩ Nguyễn Văn A';
DECLARE @Assistant VARCHAR(10) = 'Y tá Bùi Thị C';
DECLARE @Room VARCHAR(4) = 'Phòng 101';
DECLARE @PreviousAp VARCHAR(10) = NULL;

EXEC [dbo].[fnAddAppointment]
@ApTime,
@ApOrder,
@IsFirstTime,
@Notes,
@SentDate,
@Patient,
@Doctor,
@Assistant,
@Room,
@PreviousAp;
*/

---Các hàm đơn thuốc bệnh nhân 


--Xem danh sách đơn thuốc

CREATE FUNCTIONPxem_ds_donthuoc()
RETURNS TABLE
AS
BEGIN

RETURN
(
SELECT
    p.id,
    p.prescription_date,
    p.patient,
    m.medicine_name,
    i.quantity
FROM
    [dbo].[prescription] p
    LEFT JOIN ingredient i
        ON p.id = i.prescription_id
    LEFT JOIN medicine m
        ON i.medicine_id = m.id
);

END;
GO


/*
Hàm này sẽ trả về một bảng chứa danh sách tất cả các đơn thuốc trong cơ sở dữ liệu. Bảng này sẽ bao gồm các thông tin sau:

    ID của đơn thuốc
    Ngày kê đơn
    ID của bệnh nhân
    Tên thuốc
    Số lượng thuốc
*/

--Hàm xem chi tiết đơn thuốc 

CREATE FUNCTION chitiet_donthuoc
(
@PrescriptionID VARCHAR(10)
)
RETURNS TABLE
AS
BEGIN

RETURN
(
SELECT
    p.id,
    p.prescription_date,
    p.patient,
    m.medicine_name,
    i.quantity
FROM
    [dbo].[prescription] p
    LEFT JOIN ingredient i
        ON p.id = i.prescription_id
    LEFT JOIN medicine m
        ON i.medicine_id = m.id
WHERE
    p.id = @PrescriptionID
);

END;
GO

/*
Hàm này sẽ trả về một bảng chứa chi tiết của một đơn thuốc cụ thể. Bảng này sẽ bao gồm các thông tin giống như hàm xem danh sach don thuoc, nhưng chỉ giới hạn cho đơn thuốc có ID được chỉ định.*/
*/


---Thêm đơn thuốc

CREATE PROCEDURE them_donthuoc
(
    @PrescriptionDate DATE,
    @PatientID VARCHAR(10),
    @Ingredients NVARCHAR(MAX)
)
AS
BEGIN

DECLARE @IngredientsArray TABLE
(
    MedicineID VARCHAR(10),
    Quantity INT
);

INSERT INTO @IngredientsArray
(
    MedicineID,
    Quantity
)
VALUES
(
    -- ...
);

INSERT INTO prescription
(
    prescription_date,
    patient
)
VALUES
(
    @PrescriptionDate,
    @PatientID
);

DECLARE @PrescriptionID VARCHAR(10);

SELECT
    @PrescriptionID = SCOPE_IDENTITY()
FROM
    prescription
WHERE
    patient = @PatientID
    AND prescription_date = @PrescriptionDate;

DECLARE @IngredientID INT;

DECLARE @Quantity INT;

DECLARE @i INT = 1;

WHILE @i <= COUNT(*)
BEGIN

SET @IngredientID = (SELECT MedicineID FROM @IngredientsArray WHERE RowNumber = @i);
SET @Quantity = (SELECT Quantity FROM @IngredientsArray WHERE RowNumber = @i);

INSERT INTO ingredient
(
    prescription_id,
    medicine_id,
    quantity
)
VALUES
(
    @PrescriptionID,
    @IngredientID,
    @Quantity
);

SET @i = @i + 1;

END;

END;
GO

----Cập nhật đơn thuốc 

CREATE PROCEDURE capnhat_donthuoc
(
    @PrescriptionID VARCHAR(10),
    @PrescriptionDate DATE,
    @PatientID VARCHAR(10),
    @Ingredients NVARCHAR(MAX)
)
AS
BEGIN

DECLARE @IngredientsArray TABLE
(
    MedicineID VARCHAR(10),
    Quantity INT
);

INSERT INTO @IngredientsArray
(
    MedicineID,
    Quantity
)
VALUES
(
    -- ...
);

UPDATE prescription
SET
    prescription_date = @PrescriptionDate,
    patient = @PatientID
WHERE
    id = @PrescriptionID;

DELETE FROM ingredient
WHERE
    prescription_id = @PrescriptionID;

DECLARE @IngredientID INT;

DECLARE @Quantity INT;

DECLARE @i INT = 1;

WHILE @i <= COUNT(*)
BEGIN

SET @IngredientID = (SELECT MedicineID FROM @IngredientsArray WHERE RowNumber = @i);
SET @Quantity = (SELECT Quantity FROM @IngredientsArray WHERE RowNumber = @i);

INSERT INTO ingredient
(
    prescription_id,
    medicine_id,
    quantity
)
VALUES
(
    @PrescriptionID,
    @IngredientID,
    @Quantity
);

SET @i = @i + 1;

END;

END;
GO

---Xoá đơn thuốc 

CREATE PROCEDURE xoa_don_thuoc
(
    @PrescriptionID VARCHAR(10)
)
AS
BEGIN

DELETE FROM prescription
WHERE
    id = @PrescriptionID;

DELETE FROM ingredient
WHERE
    prescription_id = @PrescriptionID;

END;
GO
