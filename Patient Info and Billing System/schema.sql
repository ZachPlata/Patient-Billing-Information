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

SET FOREIGN_KEY_CHECKS = 1;

