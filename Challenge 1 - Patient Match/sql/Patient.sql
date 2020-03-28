-- Create a new database called 'DatabaseName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'DatabaseName'
)
CREATE DATABASE PatientData;

-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('SchemaName.TableName', 'U') IS NOT NULL
DROP TABLE SchemaName.TableName
GO
-- Create the table in the specified schema
CREATE TABLE Patients
(
    patient_id INT NOT NULL PRIMARY KEY,
    group_id INT,
    patient_acct_# VARCHAR(15), 
    first_name VARCHAR(35) NOT NULL,
    last_name VARCHAR(35) NOT NULL,
    middle_name VARCHAR(35),
    date_of_birth DATE NOT NULL,
    sex VARCHAR(20),
    address_1 VARCHAR(255),
    address_2 VARCHAR(255),
    city VARCHAR(255),
    [state] VARCHAR(255), /*state is a SQL keyword*/
    zip_code INT(5),
    prev_first_name VARCHAR(35),
    prev_middle_name VARCHAR(35),
    prev_last_name VARCHAR(35),
    prev_address1 VARCHAR(255),
    prev_address2 VARCHAR(255),
    prev_city VARCHAR(255),
    prev_state VARCHAR(255),
    prev_zip_code INT(5)
	
);
GO