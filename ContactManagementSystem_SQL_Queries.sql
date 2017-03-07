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

		
