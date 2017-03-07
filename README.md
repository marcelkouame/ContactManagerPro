# ContactManagerPro
A Simple Contact Management System built for C# for WPF Application course at New York University Term: Spring 2017. Course end date: March 7 2017

THIS FILE IS AVAILABLE AS A PDF README FILE - The following text is NOT FORMATTED

Marcel Kouame
C# for WPF - Final Project

Contact Manager Pro - Contact Management System

OVERVIEW
The Contact Manager Pro was developed as a WPF application using an N-Tier application architecture. A Business Logic Layer, Entities Layer, and Data Context Layer have been developed as dependencies within the application.

INCLUDED FILES
- README.pdf
- ContactManagementSystem (Project Directory including Visual Studio Solution files)
      CHECKSUM
      CRC-32 (For Data): F015A1DC
      CRC-32 (For Data and Names): C145889B
      Size: 36MB

- ContactManagementSystemDB.bak
      CHECKSUM
      CRC-32: 1AB50A34
      SHA-1: 8CCC7DB4B30D60AADD462B1304A4537DA5F34A60
      Size: 2MB
      
- ContactManagementSystem_SQL_Queries.sql
      CHECKSUM
      CRC-32: 1F9878D0
      SHA-1: 40567041A252A3A21EC5B8E70CC13D42EF242171
      Size: 3984 bytes

FEATURES
The Contact Manager Pro includes the following features:
- Front Page
    - Add Contact Button and Label
    - View All Contacts Button and Label
    - Label and Logo
- Menu “Ribbon”
    - File
    - View All Contacts
        - Opens “View All Contacts” window
    - Add Contact
        - Opens “Add Contact” window
    - About
        - Opens an About Box integrated through Windows Forms inheritances

Add Contact Window
Add contacts via assembled form
Double Click argument passed from XAML to set TextBox strings to empty
Save Button Method 
Conditional properties to do a light check for default TextBox properties and null values -- not perfect as it fails the E-Mail.Text = String.Empty test
Passes TextBox properties into a Contact object
Calls Reset method to reset data to default “Masked” properties
Calls saveDataMessageBox() that appears when the Save Button is clicked
Shows a Windows Forms(inherits WAF instead of WPF) MessageBox 
MessageBox is assigned the type of DialogResult with saveDataMessageBoxResult as variable
DialogResult is checked in a conditional
Conditional is checked against saveDataMessageBoxResult and a DialogResult value (“Yes” or “No”)
DialogResult Yes value instantiates variable of the type ViewAllContactsWindow and displays View All Contacts Window
DialogResult No value calls this.show() where “this” is the Add Contact Window
View All Contacts Window
Similar UI elements as the rest of the application
DataGrid present in the View All Contacts Window is bound to the ContactManagementSystemDB data

DEPENDENCIES
The Contact Manager Pro was developed against several N-Tier Application libraries:
Dependencies/References:
ContactManagementSystemBL
This layer contains Business Logic for the application. In this layer, the Contact object is passed to the database for processing. The grid that is bound to the data is also updated accordingly (i.e. save events).
Depends on:
ContactManagementSystemDL
ContactManagementSystemEntities
ContactManagementSystemEntities
This layer defines get and set properties as well as base Contact properties for the application.
No N-Tier architecture related Dependencies/References
ContactManagementSystemDL
This layer contains the DatabaseContext files for the application. In this layer, Lists are casted as contacts in order to bind data to the grid and the appropriate database context objects are accessed and turned into implementations.
Depends on:
ContactManagementSystemEntities
ContactManagementSystem
This layer contains the XAML and CS code behind files. This is the startup project for the Contact Management System.
Depends on:
ContactManagementSystemBL
ContactManagementSystemEntities
Contains:
ContactManagementSystem.Entities
The Entities folder houses UI based files such as images

SQL Queries
A collection of SQLServer queries that include: Database Creation, Table Creation, Procedure Creation for both Insert and Get Contact database objects, Insert of auto-generated data for testing purposes, and the deletion of application test data (ContactID Auto Increment numbering has been affected by the removal of the test data).

CREATE DATABASE ContactManagementSystemDB;

USE ContactManagementSystemDB;

CREATE TABLE Contacts
(
	ContactID int PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(20) NOT NULL,
	LastName varchar(30) NOT NULL,
	Title varchar(30) NULL,
	Company varchar(50) NULL,
	Email varchar(50) NOT NULL,
	Telephone varchar(20) NULL
	);

	CREATE PROCEDURE [dbo].[InsertContact]
		@FirstName VARCHAR(20),
		@LastName VARCHAR(30),
		@Title VARCHAR(30),
		@Company VARCHAR(50),
		@Email VARCHAR(50),
		@Telephone VARCHAR(20)
	AS
		INSERT INTO Contacts (FirstName,LastName,Title,Company,Email,Telephone)
		VALUES (@FirstName,@LastName,@Title,@Company,@Email,@Telephone)*/

	CREATE PROCEDURE [dbo].[GetContacts]
		AS
		BEGIN
			SELECT
				ContactID,
				FirstName,
				LastName,
				Title,
				Company,
				Email,
				Telephone
					FROM Contacts
		END
		GO

	
		

DELETE FROM Contacts WHERE FirstName = 'Test';

SELECT * FROM Contacts;

DELETE FROM Contacts WHERE FirstName = 'Enter First Name';

//Mockaroo Data
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Kathy', 'Ferguson', 'Civil Engineer', 'Sauer, Huel and Haley', 'kferguson0@hostgator.com', '33-(472)338-9235');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Harold', 'Day', 'Quality Engineer', 'Feeney, Mraz and Keeling', 'hday1@mapquest.com', '351-(481)766-3966');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Earl', 'Wallace', 'Design Engineer', 'Will-Toy', 'ewallace2@prweb.com', '62-(486)241-4133');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Rose', 'Gibson', 'Compensation Analyst', 'Toy, Gorczany and Cummerata', 'rgibson3@desdev.cn', '976-(811)840-4295');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Matthew', 'Morales', 'Help Desk Technician', 'Armstrong-Schultz', 'mmorales4@phpbb.com', '48-(985)604-2765');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Theresa', 'Mitchell', 'Accounting Assistant II', 'Emard and Sons', 'tmitchell5@constantcontact.com', '62-(187)265-7080');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Catherine', 'Graham', 'Chief Design Engineer', 'Gleason-Trantow', 'cgraham6@ucoz.ru', '86-(729)229-2108');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Cheryl', 'Hawkins', 'Accounting Assistant IV', 'Moore, Bogan and Anderson', 'chawkins7@digg.com', '52-(175)931-4717');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Billy', 'Phillips', 'Research Associate', 'Bartoletti LLC', 'bphillips8@unblog.fr', '976-(553)952-2778');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Arthur', 'Phillips', 'Electrical Engineer', 'Upton, Pfannerstill and Brown', 'aphillips9@domainmarket.com', '33-(331)147-3016');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Russell', 'Nichols', 'Dental Hygienist', 'Schuster-Ward', 'rnicholsa@ustream.tv', '55-(148)332-1880');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Maria', 'Bowman', 'Clinical Specialist', 'Durgan-Stiedemann', 'mbowmanb@phoca.cz', '86-(481)199-0446');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Jerry', 'Hart', 'Staff Accountant III', 'Heidenreich-Rath', 'jhartc@google.cn', '993-(448)222-3293');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Carl', 'Schmidt', 'Associate Professor', 'Ruecker and Sons', 'cschmidtd@goo.gl', '62-(640)277-2033');
insert into Contacts (FirstName, LastName, Title, Company, Email, Telephone) values ('Janet', 'Moore', 'Systems Administrator I', 'Trantow, Wunsch and Kling', 'jmooree@sohu.com', '58-(215)579-8043');




