USE master
GO

CREATE DATABASE QLNHAKHOA
GO

USE QLNHAKHOA
GO

-- Tao bang va rang buoc khoa chinh
CREATE TABLE login
(
    user_name VARCHAR(10) NOT NULL,
    pass_word VARCHAR(20) NOT NULL,
    CONSTRAINT pk_login PRIMARY KEY(user_name) 
)

CREATE TABLE staff
(
    id VARCHAR(10) NOT NULL,
    staff_name NVARCHAR(50) NOT NULL,
    gender NVARCHAR(3) CHECK(gender IN (N'Nam',N'Nữ')),
    birthday DATE ,
    phone_number VARCHAR(10) ,
    email VARCHAR(30) ,
    staff_address NVARCHAR(50) ,
    user_name VARCHAR(10) ,
    CONSTRAINT pk_staff PRIMARY KEY(id)
)

CREATE TABLE dentist
(
    id VARCHAR(10) NOT NULL,
    dentist_name NVARCHAR(50) NOT NULL,
    gender NVARCHAR(3) CHECK(gender IN (N'Nam',N'Nữ')),
    birthday DATE ,
    phone_number VARCHAR(10) ,
    email VARCHAR(30) ,
    dentist_address NVARCHAR(50) ,
    user_name VARCHAR(10) ,
    CONSTRAINT pk_dentist PRIMARY KEY(id)
)

CREATE TABLE work_time
(
    dentist_id VARCHAR(10) NOT NULL,
    day_of_week NVARCHAR(8) CHECK(day_of_week IN (N'Thứ hai', N'Thứ ba', N'Thứ tư', N'Thứ năm', N'Thứ sáu', N'Thứ bảy', N'Chủ nhật')),
    start_time TIME,
    end_time TIME,
    CONSTRAINT pk_work_time PRIMARY KEY(dentist_id,day_of_week)
)

CREATE TABLE appointment
(
    id VARCHAR(10) NOT NULL,
    appointment_time DATETIME,
    appointment_order INT,
    is_first_time BIT,
    notes NVARCHAR(100),
    sent_date DATE,
    patient VARCHAR(10),
    doctor VARCHAR(10),
    assistant VARCHAR(10),
    room VARCHAR(4),
    previous_appointment VARCHAR(10),
    CONSTRAINT pk_appointment PRIMARY KEY(id)
)

CREATE TABLE room 
(
    room_number VARCHAR(4) NOT NULL
    CONSTRAINT pk_room PRIMARY KEY(room_number)
)

CREATE TABLE patient
(
    id VARCHAR(10) NOT NULL,
    patient_name NVARCHAR(50) NOT NULL,
    gender NVARCHAR(3) CHECK(gender IN (N'Nam',N'Nữ')),
    phone_number VARCHAR(10),
    patient_address NVARCHAR(50),
    birthday DATE,
    general_teeth_info NVARCHAR(100),
    notes NVARCHAR(100),
    default_dentist VARCHAR(10),
    CONSTRAINT pk_patient PRIMARY KEY(id)
)

CREATE TABLE payment
(
    id VARCHAR(10) NOT NULL,
    total_bill INT,
    total_paid INT,
    change INT,
    paid_date DATE,
    notes NVARCHAR(100),
    patient VARCHAR(10),
    mode NVARCHAR(8),
    CONSTRAINT pk_payment PRIMARY KEY(id)
)


CREATE TABLE treatment_plan
(
    id VARCHAR(10) NOT NULL,
    description NVARCHAR(100),
    treated_date DATE,
    notes NVARCHAR(100), 
    treat_status VARCHAR(6), -- yellow | blue | green
    price INT,
    treatment VARCHAR(10),
    doctor VARCHAR(10),
    assistant VARCHAR(10),
    patient VARCHAR(10),
    payment VARCHAR(10),
    CONSTRAINT pk_treatment_plan PRIMARY KEY(id)
)

CREATE TABLE treatment
(
    id VARCHAR(10) NOT NULL,
    treatment_name NVARCHAR(50) UNIQUE,
    CONSTRAINT pk_treatment PRIMARY KEY(id)
)

CREATE TABLE teeth_in_plan
(
    treatment_plan_id VARCHAR(10),
    teeth_number INT,
    CONSTRAINT pk_teeth_in_plan PRIMARY KEY(treatment_plan_id,teeth_number)
)

CREATE TABLE teeth
(
    teeth_number INT,
    CONSTRAINT pk_teeth PRIMARY KEY(teeth_number)
)

CREATE TABLE teeth_side
(
    side_code VARCHAR(1),
    teeth_number INT,
    CONSTRAINT pk_teeth_side PRIMARY KEY(side_code)
)

CREATE TABLE prescription
(
    id VARCHAR(10),
    prescription_date DATE,
    patient VARCHAR(10),
    CONSTRAINT pk_prescription PRIMARY KEY(id)
)

CREATE TABLE ingredient
(
    prescription_id VARCHAR(10),
    medicine_id VARCHAR(10),
    quantity INT,
    CONSTRAINT pk_ingredient PRIMARY KEY(prescription_id, medicine_id)
)

CREATE TABLE medicine
(
    id VARCHAR(10) NOT NULL,
    medicine_name NVARCHAR(50) UNIQUE,
    origin VARCHAR(50),
    usage NVARCHAR(100),
    CONSTRAINT pk_medicine PRIMARY KEY(id)
)

-- Tao rang buoc khoa ngoai
ALTER TABLE staff
ADD CONSTRAINT fk_staff_login
FOREIGN KEY (user_name)
REFERENCES login(user_name)

ALTER TABLE dentist
ADD CONSTRAINT fk_dentist_login
FOREIGN KEY (user_name)
REFERENCES login(user_name)

ALTER TABLE work_time
ADD CONSTRAINT fk_work_time_dentist
FOREIGN KEY (dentist_id)
REFERENCES dentist(id)

ALTER TABLE appointment
ADD CONSTRAINT fk_appointment_patient
FOREIGN KEY (patient)
REFERENCES patient(id)

ALTER TABLE appointment
ADD CONSTRAINT fk_appointment_doctor
FOREIGN KEY (doctor)
REFERENCES dentist(id)

ALTER TABLE appointment
ADD CONSTRAINT fk_appointment_assistant
FOREIGN KEY (assistant)
REFERENCES dentist(id)

ALTER TABLE appointment
ADD CONSTRAINT fk_appointment_room
FOREIGN KEY (room)
REFERENCES room(room_number)

ALTER TABLE appointment
ADD CONSTRAINT fk_appointment_appointment
FOREIGN KEY (previous_appointment)
REFERENCES appointment(id)

ALTER TABLE patient
ADD CONSTRAINT fk_patient_dentist
FOREIGN KEY (default_dentist)
REFERENCES dentist(id)

ALTER TABLE payment
ADD CONSTRAINT fk_payment_patient
FOREIGN KEY (patient)
REFERENCES patient(id)

ALTER TABLE treatment_plan
ADD CONSTRAINT fk_treatment_plan_treatment
FOREIGN KEY (treatment)
REFERENCES treatment(id)

ALTER TABLE treatment_plan
ADD CONSTRAINT fk_treatment_plan_doctor
FOREIGN KEY (doctor)
REFERENCES dentist(id)

ALTER TABLE treatment_plan
ADD CONSTRAINT fk_treatment_plan_assistant
FOREIGN KEY (assistant)
REFERENCES dentist(id)

ALTER TABLE treatment_plan
ADD CONSTRAINT fk_treatment_plan_patient
FOREIGN KEY (patient)
REFERENCES patient(id)

ALTER TABLE treatment_plan
ADD CONSTRAINT fk_treatment_plan_payment
FOREIGN KEY (payment)
REFERENCES payment(id)

ALTER TABLE teeth_in_plan
ADD CONSTRAINT fk_teeth_in_plan_treatment_plan
FOREIGN KEY (treatment_plan_id)
REFERENCES treatment_plan(id)

ALTER TABLE teeth_in_plan
ADD CONSTRAINT fk_teeth_in_plan_teeth
FOREIGN KEY (teeth_number)
REFERENCES teeth(teeth_number)

ALTER TABLE teeth_side
ADD CONSTRAINT fk_teeth_side_teeth
FOREIGN KEY (teeth_number)
REFERENCES teeth(teeth_number)

ALTER TABLE prescription
ADD CONSTRAINT fk_prescription_patient
FOREIGN KEY (patient)
REFERENCES patient(id)

ALTER TABLE ingredient
ADD CONSTRAINT fk_ingredient_prescription
FOREIGN KEY (prescription_id)
REFERENCES prescription(id)

ALTER TABLE ingredient
ADD CONSTRAINT fk_ingredient_medicine
FOREIGN KEY (medicine_id)
REFERENCES medicine(id)



-- Nhap lieu (Tu dong phat sinh theo format nha )
-- login
INSERT INTO login(user_name, pass_word)
VALUES('admin', 'ntmthu@khtn')
INSERT INTO login(user_name, pass_word)
VALUES('user000001', 'MEf=d-Nj#m;Rv98n')
INSERT INTO login(user_name, pass_word)
VALUES('user000002', 'wBa$h,>]P9mYe[?+')
INSERT INTO login(user_name, pass_word)
VALUES('user000003', 'P>;F`-/ph4dJLY6^')
INSERT INTO login(user_name, pass_word)
VALUES('user000004', 'Km[39B~#@^y!vzE=')
-- staff
INSERT INTO staff(id,staff_name, gender, birthday, phone_number, email, staff_address, user_name)
VALUES('sta00001',N'Lâm Thành Châu',N'Nam', '1994-12-13', '9967206803', 'cer-iwowomo2@yahoo.com', N'16 Hung Vuong, Dong ha , Quang Tri', 'user000001')
INSERT INTO staff(id,staff_name, gender, birthday, phone_number, email, staff_address, user_name)
VALUES('sta00002',N'Nguyễn Phương An',N'Nữ', '2001-12-10', '6371988806 ', 'fey-ugazisa95@gmail.com', N'652 Dien Bien Phu Phuong 11, Quan 10, Ho Chi Minh', 'user000002')

--dentist
INSERT INTO dentist(id,dentist_name, gender, birthday, phone_number, email, dentist_address, user_name)
VALUES('den00001',N'Ngô Thanh Huy',N'Nam', '1984-01-29', '2030409092', 'dufu_fateka24@yahoo.com', N'67 Phan Dinh Phung, Ninh Kieu, Can Tho', 'user000003')
INSERT INTO dentist(id,dentist_name, gender, birthday, phone_number, email, dentist_address, user_name)
VALUES('den00002',N'La Chí Thanh',N'Nam', '1999-03-23', '4701781968', 'hagaha_zuvo80@yahoo.com', N'2/29 Cao Thang Phuong 5, Quan 3, Ho Chi Minh', 'user000004')

--work_time
INSERT INTO work_time( dentist_id, day_of_week, start_time, end_time)
VALUES('den00001', N'Thứ hai', '08:00:00', '16:00:00')
INSERT INTO work_time( dentist_id, day_of_week, start_time, end_time)
VALUES('den00001', N'Thứ tư', '08:00:00', '14:00:00')
INSERT INTO work_time( dentist_id, day_of_week, start_time, end_time)
VALUES('den00001', N'Thứ sáu', '08:00:00', '16:00:00')
INSERT INTO work_time( dentist_id, day_of_week, start_time, end_time)
VALUES('den00002', N'Thứ ba', '08:00:00', '18:00:00')

-- room
INSERT INTO room(room_number)
VALUES('0001')
INSERT INTO room(room_number)
VALUES('0002')
INSERT INTO room(room_number)
VALUES('0003')

-- patient
INSERT INTO patient(id, patient_name, gender, phone_number, patient_address, birthday, general_teeth_info, notes, default_dentist)
VALUES('0000000001', N'Võ Trung Hiếu', N'Nam', 3245212345, N'87 Hoa Khanh Dong, Duc Hoa, Long An', '2003-03-03', NULL, NULL, NULL)

--appointment
INSERT INTO appointment(id, appointment_time, appointment_order, is_first_time, notes, sent_date, patient, doctor, assistant, room, previous_appointment)
VALUES('0000000001', '2023-12-1 08:00:00', 1, 0, N'Khám răng lần đầu', '2023-11-27', '0000000001', 'den00001', NULL, '0001', NULL)


-- Cap nhat 
