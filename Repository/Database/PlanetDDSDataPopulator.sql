INSERT INTO Address
(Street, Zipcode, City, State, CreatedDate, UpdatedDate)
VALUES
('123 Test Dr.', '12345', 'Tustin', 'CA', GETDATE(), GETDATE())

INSERT INTO Address
(Street, Zipcode, City, State, CreatedDate, UpdatedDate)
VALUES
('321 Main st.', '54321', 'Irvine', 'CA', GETDATE(), GETDATE())

INSERT INTO Address
(Street, Zipcode, City, State, CreatedDate, UpdatedDate)
VALUES
('41323 Victory rd.', '90210', 'Hollywood', 'CA', GETDATE(), GETDATE())

INSERT INTO Address
(Street, Zipcode, City, State, CreatedDate, UpdatedDate)
VALUES
('41323 Burberrt rd.', '90221', 'Costa Mesa', 'CA', GETDATE(), GETDATE())


INSERT INTO DENTIST
(AddressId, FirstName, LastName, LicenseNumber, CreatedDate, UpdatedDate)
VALUES
(2, 'Joe', 'Smith', '32123245', GETDATE(), GETDATE())

INSERT INTO Patient
(AddressId, FirstName, LastName, DateOfBirth, CreatedDate, UpdatedDate)
VALUES
(3, 'Bao', 'Pham', '02/25/1991', GETDATE(), GETDATE())

INSERT INTO Patient
(AddressId, FirstName, LastName, DateOfBirth, CreatedDate, UpdatedDate)
VALUES
(4, 'Josh', 'Johnson', '05/22/1984', GETDATE(), GETDATE())

INSERT INTO Patient
(AddressId, FirstName, LastName, DateOfBirth, CreatedDate, UpdatedDate)
VALUES
(5, 'Deborah', 'Alexander', '01/12/1943', GETDATE(), GETDATE())