/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 23-���-2018 14:45:15 				*/
/*  DBMS       : SQLite 								*/
/* ---------------------------------------------------- */

/* Drop Tables */

DROP TABLE IF EXISTS 'ContactInfo'
;

DROP TABLE IF EXISTS 'Department'
;

DROP TABLE IF EXISTS 'Faculty'
;

DROP TABLE IF EXISTS 'FormOfEducation'
;

DROP TABLE IF EXISTS 'Leader'
;

DROP TABLE IF EXISTS 'Speciality'
;

DROP TABLE IF EXISTS 'Subject'
;

DROP TABLE IF EXISTS 'TypeOfUser'
;

DROP TABLE IF EXISTS 'User'
;

/* Create Tables with Primary and Foreign Keys, Check and Unique Constraints */

CREATE TABLE 'ContactInfo'
(
	'InfoID' INTEGER NOT NULL PRIMARY KEY,
	'Adress' TEXT NOT NULL,
	'PhoneNumber' TEXT NOT NULL,
	'Website' TEXT NULL,
	'SpecID' INTEGER NULL,
	CONSTRAINT 'FK_ContactInfo_Speciality' FOREIGN KEY ('SpecID') REFERENCES 'Speciality' ('SpecID') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Department'
(
	'DepID' INTEGER NOT NULL PRIMARY KEY,
	'DepCode' INTEGER NOT NULL,
	'DepName' TEXT NOT NULL,
	'DepShortName' TEXT NOT NULL
)
;

CREATE TABLE 'Faculty'
(
	'FacID' INTEGER NOT NULL PRIMARY KEY,
	'FacCode' INTEGER NOT NULL,
	'FacName' TEXT NOT NULL,
	'FacShortName' TEXT NOT NULL,
	'DepID' INTEGER NULL,
	CONSTRAINT 'FK_Faculty_Department' FOREIGN KEY ('DepID') REFERENCES 'Department' ('DepID') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'FormOfEducation'
(
	'FormID' INTEGER NOT NULL PRIMARY KEY,
	'Type' INTEGER NOT NULL,
	'SubjID' INTEGER NULL,
	CONSTRAINT 'FK_FormOfEducation_Subject' FOREIGN KEY ('SubjID') REFERENCES 'Subject' ('SubjID') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Leader'
(
	'LeaderID' INTEGER NOT NULL PRIMARY KEY,
	'Name' TEXT NOT NULL,
	'ScDegree' TEXT NOT NULL,
	'ScRank' TEXT NOT NULL,
	'StartDate' TEXT NOT NULL,
	'EndDate' TEXT NULL,
	'SpecID' INTEGER NULL,
	'DepID' INTEGER NULL,
	'FacID' INTEGER NULL,
	CONSTRAINT 'FK_Leader_Department' FOREIGN KEY ('DepID') REFERENCES 'Department' ('DepID') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Leader_Faculty' FOREIGN KEY ('FacID') REFERENCES 'Faculty' ('FacID') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Leader_Speciality' FOREIGN KEY ('SpecID') REFERENCES 'Speciality' ('SpecID') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Speciality'
(
	'SpecID' INTEGER NOT NULL PRIMARY KEY,
	'Name' TEXT NOT NULL,
	'ShortName' TEXT NOT NULL,
	'Code' INTEGER NOT NULL,
	'FacID' INTEGER NULL,
	'FormID' INTEGER NULL,
	'DepID' INTEGER NULL,
	CONSTRAINT 'FK_Speciality_Department' FOREIGN KEY ('DepID') REFERENCES 'Department' ('DepID') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Speciality_Faculty' FOREIGN KEY ('FacID') REFERENCES 'Faculty' ('FacID') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Speciality_FormOfEducation' FOREIGN KEY ('FormID') REFERENCES 'FormOfEducation' ('FormID') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Subject'
(
	'SubjID' INTEGER NOT NULL PRIMARY KEY,
	'PassingScore' NUMERIC NOT NULL,
	'Year' INTEGER NOT NULL
)
;

CREATE TABLE 'TypeOfUser'
(
	'TypeID' INTEGER NOT NULL PRIMARY KEY,
	'Admin' TEXT NOT NULL,
	'Aplicant' TEXT NOT NULL,
	'UnversityWorker' TEXT NOT NULL
)
;

CREATE TABLE 'User'
(
	'UserId' INTEGER NOT NULL PRIMARY KEY,
	'Login' TEXT NOT NULL,
	'Password' TEXT NOT NULL,
	'TypeID' INTEGER NOT NULL,
	CONSTRAINT 'FK_User_TypeOfUser' FOREIGN KEY ('TypeID') REFERENCES 'TypeOfUser' ('TypeID') ON DELETE No Action ON UPDATE No Action
)
;

/* Create Indexes and Triggers */

CREATE INDEX 'IXFK_ContactInfo_Speciality'
 ON 'ContactInfo' ('SpecID' ASC)
;

CREATE INDEX 'IXFK_Faculty_Department'
 ON 'Faculty' ('DepID' ASC)
;

CREATE INDEX 'IXFK_FormOfEducation_Subject'
 ON 'FormOfEducation' ('SubjID' ASC)
;

CREATE INDEX 'IXFK_Leader_Department'
 ON 'Leader' ('DepID' ASC)
;

CREATE INDEX 'IXFK_Leader_Faculty'
 ON 'Leader' ('FacID' ASC)
;

CREATE INDEX 'IXFK_Leader_Speciality'
 ON 'Leader' ('SpecID' ASC)
;

CREATE INDEX 'IXFK_Speciality_Department'
 ON 'Speciality' ('DepID' ASC)
;

CREATE INDEX 'IXFK_Speciality_Faculty'
 ON 'Speciality' ('FacID' ASC)
;

CREATE INDEX 'IXFK_Speciality_FormOfEducation'
 ON 'Speciality' ('FormID' ASC)
;

CREATE INDEX 'IXFK_User_TypeOfUser'
 ON 'User' ('TypeID' ASC)
;