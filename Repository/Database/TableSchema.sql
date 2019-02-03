/*
drop table Visit
drop table Patient
drop table Dentist
drop table Contact
drop table Address
*/

Create Table Address
(
	AddressId INT  NOT NULL  IDENTITY PRIMARY KEY,
	Street varchar(100) NOT NULL,
	Zipcode varchar(10) NOT NULL,
	City varchar(100) NOT NULL,
	State varchar(2) NOT NULL,
	CreatedDate datetime NOT NULL,
	UpdatedDate datetime NOT NULL
)


Create Table Dentist
(
	DentistId INT  NOT NULL    IDENTITY    PRIMARY KEY,
	AddressId INT NOT NULL FOREIGN KEY (AddressId) REFERENCES Address(AddressId),
	FirstName varchar(100) NOT NULL,
	LastName varchar(100) NOT NULL,
	LicenseNumber varchar(100) NOT NULL,
	CreatedDate datetime NOT NULL,
	UpdatedDate datetime NOT NULL	
	
)

Create table Patient
(
	PatientId INT  NOT NULL    IDENTITY    PRIMARY KEY,
	AddressId INT NOT NULL FOREIGN KEY (AddressId) REFERENCES Address(AddressId),
	FirstName varchar(100) NOT NULL,
	LastName varchar(100) NOT NULL,
	DateOfBirth datetime NOT NULL,
	CreatedDate datetime NOT NULL,
	UpdatedDate datetime NOT NULL	
	
)

Create table Visit
(
	VisitId INT  NOT NULL    IDENTITY    PRIMARY KEY,
	PatientId INT  NOT NULL FOREIGN KEY (PatientId) REFERENCES Patient(PatientId),
	DentistId INT  NOT NULL FOREIGN KEY (DentistId) REFERENCES Dentist(DentistId),
	VisitDate DateTime NOT NULL,
	InsurancePolicyNumber nvarchar(100) NULL,
	InsuranceCompany nvarchar(100) NULL,
	InsuranceAddressId INT NULL FOREIGN KEY (InsuranceAddressId) REFERENCES Address(AddressId),
	TotalCost money null,
	PaidAmount money null,
	Balance money null,
	CreatedDate datetime NOT NULL,
	UpdatedDate datetime NOT NULL
)


