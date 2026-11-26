-- ========================================================
-- DATABASE: patientbillingdb
-- Metro Pedia Care / Patient Information & Billing System
-- ========================================================

CREATE DATABASE IF NOT EXISTS `patientbillingdb`
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE `patientbillingdb`;

SET FOREIGN_KEY_CHECKS = 0;

-- --------------------------------------------------------
-- 1. USER MANAGEMENT
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `Users` (
  `user_id` VARCHAR(36) NOT NULL,
  `username` VARCHAR(50) NOT NULL,
  `password_hash` VARCHAR(255) NOT NULL,
  `full_name` VARCHAR(150) NOT NULL,
  `role` ENUM('Admin', 'Doctor', 'Nurse', 'Billing') NOT NULL,
  `email` VARCHAR(100) DEFAULT NULL,
  `contact_number` VARCHAR(30) DEFAULT NULL,
  `specialty` VARCHAR(100) DEFAULT NULL,
  `license_number` VARCHAR(50) DEFAULT NULL,
  `is_active` TINYINT(1) NOT NULL DEFAULT 1,
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `uq_users_username` (`username`),
  UNIQUE KEY `uq_users_email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 2. MASTER CLINIC SETUPS
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `RoomsBeds` (
  `bed_id` VARCHAR(20) NOT NULL,
  `room_number` VARCHAR(20) NOT NULL,
  `bed_number` VARCHAR(20) NOT NULL,
  `room_type` ENUM('Ward', 'Semi-Private', 'Private', 'ICU') NOT NULL,
  `daily_rate` DECIMAL(10,2) NOT NULL CHECK (`daily_rate` >= 0),
  `is_occupied` TINYINT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`bed_id`),
  UNIQUE KEY `UQ_Room_Bed` (`room_number`, `bed_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `MedicineCatalog` (
  `medicine_code` VARCHAR(30) NOT NULL,
  `name` VARCHAR(150) NOT NULL,
  `dosage_unit` VARCHAR(50) NOT NULL,
  `category` VARCHAR(50) NOT NULL,
  `unit_price` DECIMAL(10,2) NOT NULL CHECK (`unit_price` >= 0),
  `stock_quantity` INT NOT NULL DEFAULT 0 CHECK (`stock_quantity` >= 0),
  `is_active` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`medicine_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `LabTestCatalog` (
  `test_code` VARCHAR(30) NOT NULL,
  `test_name` VARCHAR(150) NOT NULL,
  `category` VARCHAR(50) NOT NULL,
  `price` DECIMAL(10,2) NOT NULL CHECK (`price` >= 0),
  `turnaround_time` VARCHAR(50) NOT NULL,
  `is_active` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`test_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `DoctorFeeSchedules` (
  `fee_schedule_id` INT NOT NULL AUTO_INCREMENT,
  `doctor_id` VARCHAR(36) NOT NULL,
  `standard_fee` DECIMAL(10,2) NOT NULL CHECK (`standard_fee` >= 0),
  `follow_up_fee` DECIMAL(10,2) NOT NULL CHECK (`follow_up_fee` >= 0),
  `schedule_days` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`fee_schedule_id`),
  UNIQUE KEY `uq_doctor_fee` (`doctor_id`),
  CONSTRAINT `fk_doctor_fee_user` FOREIGN KEY (`doctor_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 3. PATIENTS & ADMISSIONS
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `Patients` (
  `patient_id` VARCHAR(20) NOT NULL,
  `full_name` VARCHAR(150) NOT NULL,
  `date_of_birth` DATE NOT NULL,
  `gender` ENUM('Male', 'Female', 'Other') NOT NULL,
  `contact_number` VARCHAR(30) DEFAULT NULL,
  `address` VARCHAR(255) DEFAULT NULL,
  `emergency_contact_name` VARCHAR(100) DEFAULT NULL,
  `emergency_contact_phone` VARCHAR(30) DEFAULT NULL,
  `blood_type` ENUM('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-') DEFAULT NULL,
  `allergies` VARCHAR(500) NOT NULL DEFAULT 'None known',
  `current_status` ENUM('Outpatient', 'Admitted', 'Discharged') NOT NULL DEFAULT 'Outpatient',
  `assigned_doctor_id` VARCHAR(36) DEFAULT NULL,
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`patient_id`),
  KEY `fk_patients_doctor` (`assigned_doctor_id`),
  CONSTRAINT `fk_patients_doctor` FOREIGN KEY (`assigned_doctor_id`) REFERENCES `Users` (`user_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `Appointments` (
  `appointment_id` INT NOT NULL AUTO_INCREMENT,
  `patient_id` VARCHAR(20) NOT NULL,
  `doctor_id` VARCHAR(36) NOT NULL,
  `scheduled_date` DATE NOT NULL,
  `scheduled_time` VARCHAR(10) NOT NULL,
  `reason` VARCHAR(255) NOT NULL,
  `status` ENUM('Scheduled', 'Completed', 'Cancelled', 'No-Show') NOT NULL DEFAULT 'Scheduled',
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`appointment_id`),
  KEY `fk_appointments_patient` (`patient_id`),
  KEY `fk_appointments_doctor` (`doctor_id`),
  CONSTRAINT `fk_appointments_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_appointments_doctor` FOREIGN KEY (`doctor_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `Admissions` (
  `admission_id` INT NOT NULL AUTO_INCREMENT,
  `patient_id` VARCHAR(20) NOT NULL,
  `bed_id` VARCHAR(20) NOT NULL,
  `admitted_by_nurse_id` VARCHAR(36) NOT NULL,
  `admission_date` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `discharge_date` DATETIME DEFAULT NULL,
  `discharge_notes` TEXT DEFAULT NULL,
  `status` ENUM('Admitted', 'Discharged', 'Transferred') NOT NULL DEFAULT 'Admitted',
  PRIMARY KEY (`admission_id`),
  KEY `fk_admissions_patient` (`patient_id`),
  KEY `fk_admissions_bed` (`bed_id`),
  KEY `fk_admissions_nurse` (`admitted_by_nurse_id`),
  CONSTRAINT `fk_admissions_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_admissions_bed` FOREIGN KEY (`bed_id`) REFERENCES `RoomsBeds` (`bed_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_admissions_nurse` FOREIGN KEY (`admitted_by_nurse_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 4. CLINICAL OBSERVATIONS & CONSULTATIONS
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `PatientVitalsHistory` (
  `vital_id` INT NOT NULL AUTO_INCREMENT,
  `patient_id` VARCHAR(20) NOT NULL,
  `taken_by_nurse_id` VARCHAR(36) NOT NULL,
  `blood_pressure` VARCHAR(15) NOT NULL,
  `pulse_rate` INT NOT NULL,
  `temperature` DECIMAL(4,1) NOT NULL,
  `weight_kg` DECIMAL(5,2) NOT NULL,
  `recorded_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`vital_id`),
  KEY `fk_vitals_patient` (`patient_id`),
  KEY `fk_vitals_nurse` (`taken_by_nurse_id`),
  CONSTRAINT `fk_vitals_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_vitals_nurse` FOREIGN KEY (`taken_by_nurse_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `NurseObservationLogs` (
  `log_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `nurse_id` VARCHAR(36) NOT NULL,
  `shift` VARCHAR(50) NOT NULL,
  `vitals_summary` VARCHAR(100) DEFAULT NULL,
  `clinical_observation` TEXT NOT NULL,
  `action_taken` TEXT NOT NULL,
  `timestamp` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`),
  KEY `fk_nurse_logs_patient` (`patient_id`),
  KEY `fk_nurse_logs_nurse` (`nurse_id`),
  CONSTRAINT `fk_nurse_logs_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_nurse_logs_nurse` FOREIGN KEY (`nurse_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `HealthCheckups` (
  `checkup_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `doctor_id` VARCHAR(36) NOT NULL,
  `checkup_date` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `blood_pressure` VARCHAR(15) NOT NULL,
  `pulse_rate` INT NOT NULL,
  `temperature` DECIMAL(4,1) NOT NULL,
  `weight_kg` DECIMAL(5,2) NOT NULL,
  `chief_complaint` TEXT NOT NULL,
  `subjective_symptoms` TEXT DEFAULT NULL,
  `objective_findings` TEXT DEFAULT NULL,
  `final_diagnosis` TEXT NOT NULL,
  `clinical_notes` TEXT DEFAULT NULL,
  PRIMARY KEY (`checkup_id`),
  KEY `fk_checkups_patient` (`patient_id`),
  KEY `fk_checkups_doctor` (`doctor_id`),
  CONSTRAINT `fk_checkups_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_checkups_doctor` FOREIGN KEY (`doctor_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `PrescriptionItems` (
  `prescription_item_id` INT NOT NULL AUTO_INCREMENT,
  `checkup_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `medicine_code` VARCHAR(30) DEFAULT NULL,
  `medicine_name` VARCHAR(150) NOT NULL,
  `dosage` VARCHAR(50) NOT NULL,
  `frequency` VARCHAR(50) NOT NULL,
  `duration` VARCHAR(50) NOT NULL,
  `instructions` VARCHAR(255) DEFAULT NULL,
  `date_prescribed` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`prescription_item_id`),
  KEY `fk_prescriptions_checkup` (`checkup_id`),
  KEY `fk_prescriptions_patient` (`patient_id`),
  KEY `fk_prescriptions_medicine` (`medicine_code`),
  CONSTRAINT `fk_prescriptions_checkup` FOREIGN KEY (`checkup_id`) REFERENCES `HealthCheckups` (`checkup_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_prescriptions_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_prescriptions_medicine` FOREIGN KEY (`medicine_code`) REFERENCES `MedicineCatalog` (`medicine_code`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `LabRequestItems` (
  `lab_request_id` INT NOT NULL AUTO_INCREMENT,
  `checkup_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `test_code` VARCHAR(30) NOT NULL,
  `urgency` ENUM('Routine', 'STAT') NOT NULL DEFAULT 'Routine',
  `clinical_indication` VARCHAR(255) DEFAULT NULL,
  `status` ENUM('Pending', 'Processing', 'Completed', 'Cancelled') NOT NULL DEFAULT 'Pending',
  `results_summary` TEXT DEFAULT NULL,
  `requested_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`lab_request_id`),
  KEY `fk_lab_requests_checkup` (`checkup_id`),
  KEY `fk_lab_requests_patient` (`patient_id`),
  KEY `fk_lab_requests_test` (`test_code`),
  CONSTRAINT `fk_lab_requests_checkup` FOREIGN KEY (`checkup_id`) REFERENCES `HealthCheckups` (`checkup_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_lab_requests_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_lab_requests_test` FOREIGN KEY (`test_code`) REFERENCES `LabTestCatalog` (`test_code`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 5. BILLING & FINANCIALS
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `BillingRecords` (
  `bill_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `admission_id` INT DEFAULT NULL,
  `billing_status` ENUM('Unpaid', 'Partial', 'Paid', 'Cancelled') NOT NULL DEFAULT 'Unpaid',
  `total_amount` DECIMAL(12,2) NOT NULL DEFAULT 0.00 CHECK (`total_amount` >= 0),
  `amount_paid` DECIMAL(12,2) NOT NULL DEFAULT 0.00 CHECK (`amount_paid` >= 0),
  `remaining_balance` DECIMAL(12,2) GENERATED ALWAYS AS (`total_amount` - `amount_paid`) STORED,
  `due_date` DATETIME NOT NULL,
  `breakdown_notes` VARCHAR(500) DEFAULT NULL,
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`bill_id`),
  KEY `fk_billing_patient` (`patient_id`),
  KEY `fk_billing_admission` (`admission_id`),
  CONSTRAINT `fk_billing_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_billing_admission` FOREIGN KEY (`admission_id`) REFERENCES `Admissions` (`admission_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `BillingLineItems` (
  `item_id` INT NOT NULL AUTO_INCREMENT,
  `bill_id` VARCHAR(30) NOT NULL,
  `item_type` ENUM('Consultation', 'RoomBed', 'Laboratory', 'Medication', 'Other') NOT NULL,
  `description` VARCHAR(200) NOT NULL,
  `quantity` INT NOT NULL DEFAULT 1 CHECK (`quantity` > 0),
  `unit_price` DECIMAL(10,2) NOT NULL CHECK (`unit_price` >= 0),
  `subtotal` DECIMAL(12,2) GENERATED ALWAYS AS (`quantity` * `unit_price`) STORED,
  PRIMARY KEY (`item_id`),
  KEY `fk_line_items_bill` (`bill_id`),
  CONSTRAINT `fk_line_items_bill` FOREIGN KEY (`bill_id`) REFERENCES `BillingRecords` (`bill_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `PaymentRecords` (
  `payment_id` VARCHAR(30) NOT NULL,
  `bill_id` VARCHAR(30) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `amount_due_before` DECIMAL(12,2) NOT NULL,
  `amount_paid` DECIMAL(12,2) NOT NULL CHECK (`amount_paid` > 0),
  `remaining_balance_after` DECIMAL(12,2) NOT NULL CHECK (`remaining_balance_after` >= 0),
  `payment_method` ENUM('Cash', 'GCash', 'Credit card', 'Debit card', 'Bank Transfer', 'HMO/Insurance') NOT NULL,
  `official_receipt_number` VARCHAR(50) NOT NULL,
  `cashier_user_id` VARCHAR(36) NOT NULL,
  `payment_date` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `notes` VARCHAR(500) DEFAULT NULL,
  PRIMARY KEY (`payment_id`),
  UNIQUE KEY `uq_official_receipt` (`official_receipt_number`),
  KEY `fk_payments_bill` (`bill_id`),
  KEY `fk_payments_patient` (`patient_id`),
  KEY `fk_payments_cashier` (`cashier_user_id`),
  CONSTRAINT `fk_payments_bill` FOREIGN KEY (`bill_id`) REFERENCES `BillingRecords` (`bill_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_payments_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_payments_cashier` FOREIGN KEY (`cashier_user_id`) REFERENCES `Users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 6. AUDIT & LOGS
-- --------------------------------------------------------

CREATE TABLE IF NOT EXISTS `StaffLoginLogs` (
  `log_id` INT NOT NULL AUTO_INCREMENT,
  `staff_id` VARCHAR(36) NOT NULL,
  `event_type` ENUM('Login', 'Logout', 'Failed Attempt') NOT NULL,
  `terminal_ip` VARCHAR(45) NOT NULL,
  `timestamp` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`),
  KEY `fk_login_logs_staff` (`staff_id`),
  CONSTRAINT `fk_login_logs_staff` FOREIGN KEY (`staff_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS `PatientAccessLogs` (
  `log_id` INT NOT NULL AUTO_INCREMENT,
  `staff_id` VARCHAR(36) NOT NULL,
  `patient_id` VARCHAR(20) NOT NULL,
  `action_taken` VARCHAR(255) NOT NULL,
  `timestamp` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`),
  KEY `fk_access_logs_staff` (`staff_id`),
  KEY `fk_access_logs_patient` (`patient_id`),
  CONSTRAINT `fk_access_logs_staff` FOREIGN KEY (`staff_id`) REFERENCES `Users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_access_logs_patient` FOREIGN KEY (`patient_id`) REFERENCES `Patients` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- 7. PLACEHOLDER / SEED DATA
-- --------------------------------------------------------

-- Users (All roles for login testing)
INSERT INTO `Users` (`user_id`, `username`, `password_hash`, `full_name`, `role`, `email`, `contact_number`, `specialty`, `license_number`, `is_active`) VALUES
('USR-ADM-001', 'admin', 'admin123', 'Administrator User', 'Admin', 'admin@metrocare.com', '09171110001', 'System Administration', 'ADM-2026-001', 1),
('USR-DOC-001', 'doctor', 'doctor123', 'Dr. Sarah Smith, MD', 'Doctor', 'doctor@metrocare.com', '09172220002', 'General Pediatrics', 'DOC-PRC-100234', 1),
('USR-DOC-002', 'doctor_john', 'doctor123', 'Dr. John Doe, MD', 'Doctor', 'john.doe@metrocare.com', '09172220003', 'Internal Medicine', 'DOC-PRC-100567', 1),
('USR-NUR-001', 'nurse', 'nurse123', 'Clara Oswald, RN', 'Nurse', 'nurse@metrocare.com', '09173330004', 'Clinical Pediatric Care', 'NUR-RN-889901', 1),
('USR-BIL-001', 'billing', 'billing123', 'Robert Billing Staff', 'Billing', 'billing@metrocare.com', '09174440005', 'Hospital Cashiering & Claims', 'BIL-ACC-445566', 1)
ON DUPLICATE KEY UPDATE `full_name` = VALUES(`full_name`);

-- Clinic Rooms & Beds
INSERT INTO `RoomsBeds` (`bed_id`, `room_number`, `bed_number`, `room_type`, `daily_rate`, `is_occupied`) VALUES
('BED-W101-1', 'Room 101', 'Bed 1', 'Ward', 800.00, 1),
('BED-W101-2', 'Room 101', 'Bed 2', 'Ward', 800.00, 0),
('BED-W101-3', 'Room 101', 'Bed 3', 'Ward', 800.00, 0),
('BED-SP201-1', 'Room 201', 'Bed 1', 'Semi-Private', 1500.00, 0),
('BED-SP201-2', 'Room 201', 'Bed 2', 'Semi-Private', 1500.00, 0),
('BED-P301-1', 'Room 301', 'Bed 1', 'Private', 3000.00, 0),
('BED-ICU01-1', 'ICU 01', 'Bed 1', 'ICU', 6500.00, 0)
ON DUPLICATE KEY UPDATE `daily_rate` = VALUES(`daily_rate`);

-- Medicine Catalog
INSERT INTO `MedicineCatalog` (`medicine_code`, `name`, `dosage_unit`, `category`, `unit_price`, `stock_quantity`, `is_active`) VALUES
('MED-PCM-500', 'Paracetamol 500mg', 'Tablet', 'Analgesic / Antipyretic', 8.50, 500, 1),
('MED-AMX-500', 'Amoxicillin 500mg', 'Capsule', 'Antibiotic', 15.00, 300, 1),
('MED-IBU-400', 'Ibuprofen 400mg', 'Tablet', 'NSAID / Anti-inflammatory', 12.00, 250, 1),
('MED-MET-500', 'Metformin 500mg', 'Tablet', 'Antidiabetic', 10.00, 400, 1),
('MED-AML-005', 'Amlodipine 5mg', 'Tablet', 'Antihypertensive', 18.00, 350, 1),
('MED-CTZ-010', 'Cetirizine 10mg', 'Tablet', 'Antihistamine', 14.50, 200, 1),
('MED-ORS-001', 'Oral Rehydration Salts (ORS)', 'Sachet', 'Electrolytes', 25.00, 150, 1)
ON DUPLICATE KEY UPDATE `unit_price` = VALUES(`unit_price`);

-- Lab Test Catalog
INSERT INTO `LabTestCatalog` (`test_code`, `test_name`, `category`, `price`, `turnaround_time`, `is_active`) VALUES
('LAB-CBC-001', 'Complete Blood Count (CBC)', 'Hematology', 350.00, '2 Hours', 1),
('LAB-URN-001', 'Routine Urinalysis', 'Clinical Microscopy', 180.00, '1 Hour', 1),
('LAB-LIP-001', 'Lipid Profile (Cholesterol, HDL, LDL, Triglycerides)', 'Clinical Chemistry', 850.00, '4 Hours', 1),
('LAB-FBS-001', 'Fasting Blood Sugar (FBS)', 'Clinical Chemistry', 220.00, '2 Hours', 1),
('LAB-CXR-001', 'Chest X-Ray (PA View)', 'Radiology & Imaging', 600.00, '3 Hours', 1),
('LAB-FEC-001', 'Routine Fecalysis', 'Parasitology', 170.00, '1 Hour', 1)
ON DUPLICATE KEY UPDATE `price` = VALUES(`price`);

-- Doctor Fee Schedules
INSERT INTO `DoctorFeeSchedules` (`doctor_id`, `standard_fee`, `follow_up_fee`, `schedule_days`) VALUES
('USR-DOC-001', 600.00, 400.00, 'Mon, Wed, Fri (09:00 AM - 03:00 PM)'),
('USR-DOC-002', 750.00, 500.00, 'Tue, Thu, Sat (10:00 AM - 05:00 PM)')
ON DUPLICATE KEY UPDATE `standard_fee` = VALUES(`standard_fee`);

-- Sample Patients
INSERT INTO `Patients` (`patient_id`, `full_name`, `date_of_birth`, `gender`, `contact_number`, `address`, `emergency_contact_name`, `emergency_contact_phone`, `blood_type`, `allergies`, `current_status`, `assigned_doctor_id`) VALUES
('PAT-2026-0001', 'Juan Dela Cruz', '1995-04-12', 'Male', '09171234567', '123 Rizal St, Sampaloc, Manila', 'Maria Dela Cruz', '09179876543', 'O+', 'None known', 'Admitted', 'USR-DOC-001'),
('PAT-2026-0002', 'Maria Santos', '1988-08-23', 'Female', '09205551234', '456 Bonifacio Ave, Quezon City', 'Pedro Santos', '09205554321', 'A+', 'Penicillin', 'Outpatient', 'USR-DOC-002'),
('PAT-2026-0003', 'Baby Liam Garcia', '2024-01-15', 'Male', '09187778899', '789 Luna St, Pasig City', 'Elena Garcia', '09187778899', 'B+', 'None known', 'Outpatient', 'USR-DOC-001')
ON DUPLICATE KEY UPDATE `full_name` = VALUES(`full_name`);

-- Sample Admissions
INSERT INTO `Admissions` (`admission_id`, `patient_id`, `bed_id`, `admitted_by_nurse_id`, `admission_date`, `status`) VALUES
(1, 'PAT-2026-0001', 'BED-W101-1', 'USR-NUR-001', '2026-11-15 08:30:00', 'Admitted')
ON DUPLICATE KEY UPDATE `status` = VALUES(`status`);

-- Sample Vitals History
INSERT INTO `PatientVitalsHistory` (`vital_id`, `patient_id`, `taken_by_nurse_id`, `blood_pressure`, `pulse_rate`, `temperature`, `weight_kg`, `recorded_at`) VALUES
(1, 'PAT-2026-0001', 'USR-NUR-001', '120/80', 78, 37.8, 68.50, '2026-11-15 09:00:00'),
(2, 'PAT-2026-0002', 'USR-NUR-001', '110/70', 72, 36.5, 55.00, '2026-11-16 10:15:00')
ON DUPLICATE KEY UPDATE `blood_pressure` = VALUES(`blood_pressure`);

-- Sample Health Checkup
INSERT INTO `HealthCheckups` (`checkup_id`, `patient_id`, `doctor_id`, `checkup_date`, `blood_pressure`, `pulse_rate`, `temperature`, `weight_kg`, `chief_complaint`, `final_diagnosis`, `clinical_notes`) VALUES
('CHK-2026-0001', 'PAT-2026-0001', 'USR-DOC-001', '2026-11-15 09:30:00', '120/80', 78, 37.8, 68.50, 'High fever for 3 days and joint pains', 'Acute Febrile Illness (Suspected Dengue)', 'Hydration therapy advised. CBC monitoring every 24h.')
ON DUPLICATE KEY UPDATE `final_diagnosis` = VALUES(`final_diagnosis`);

-- Sample Prescription
INSERT INTO `PrescriptionItems` (`prescription_item_id`, `checkup_id`, `patient_id`, `medicine_code`, `medicine_name`, `dosage`, `frequency`, `duration`, `instructions`) VALUES
(1, 'CHK-2026-0001', 'PAT-2026-0001', 'MED-PCM-500', 'Paracetamol 500mg', '1 tablet', 'Every 4-6 hours PRN', '3 days', 'Take after meals for fever')
ON DUPLICATE KEY UPDATE `instructions` = VALUES(`instructions`);

-- Sample Lab Request
INSERT INTO `LabRequestItems` (`lab_request_id`, `checkup_id`, `patient_id`, `test_code`, `urgency`, `clinical_indication`, `status`) VALUES
(1, 'CHK-2026-0001', 'PAT-2026-0001', 'LAB-CBC-001', 'STAT', 'Fever and low platelet surveillance', 'Completed')
ON DUPLICATE KEY UPDATE `status` = VALUES(`status`);

-- Sample Billing Record
INSERT INTO `BillingRecords` (`bill_id`, `patient_id`, `admission_id`, `billing_status`, `total_amount`, `amount_paid`, `due_date`, `breakdown_notes`) VALUES
('BILL-2026-0001', 'PAT-2026-0001', 1, 'Partial', 1750.00, 1000.00, '2026-11-20 17:00:00', 'Initial admission, consultation and laboratory breakdown')
ON DUPLICATE KEY UPDATE `total_amount` = VALUES(`total_amount`);

-- Sample Billing Line Items
INSERT INTO `BillingLineItems` (`item_id`, `bill_id`, `item_type`, `description`, `quantity`, `unit_price`) VALUES
(1, 'BILL-2026-0001', 'RoomBed', 'Ward Bed Accommodation (BED-W101-1)', 1, 800.00),
(2, 'BILL-2026-0001', 'Consultation', 'Pediatric Specialist Consultation Fee', 1, 600.00),
(3, 'BILL-2026-0001', 'Laboratory', 'Complete Blood Count (STAT)', 1, 350.00)
ON DUPLICATE KEY UPDATE `description` = VALUES(`description`);

-- Sample Payment Record
INSERT INTO `PaymentRecords` (`payment_id`, `bill_id`, `patient_id`, `amount_due_before`, `amount_paid`, `remaining_balance_after`, `payment_method`, `official_receipt_number`, `cashier_user_id`, `notes`) VALUES
('PAY-2026-0001', 'BILL-2026-0001', 'PAT-2026-0001', 1750.00, 1000.00, 750.00, 'Cash', 'OR-2026-0001', 'USR-BIL-001', 'Initial partial deposit upon admission')
ON DUPLICATE KEY UPDATE `amount_paid` = VALUES(`amount_paid`);

-- Compatibility View for existing SignIn code
CREATE OR REPLACE VIEW `userTable` AS 
SELECT 
    username AS Username, 
    password_hash AS Password, 
    CASE 
        WHEN role = 'Admin' THEN '1'
        WHEN role = 'Nurse' THEN '2'
        WHEN role = 'Doctor' THEN '3'
        WHEN role = 'Billing' THEN '4'
        ELSE role
    END AS Usertype 
FROM Users;

SET FOREIGN_KEY_CHECKS = 1;
