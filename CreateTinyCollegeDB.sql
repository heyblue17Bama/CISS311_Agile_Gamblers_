USE master;

 

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;

CREATE DATABASE TinyCollegeDB;

GO

 

USE TinyCollegeDB;

GO

CREATE TABLE student

(

           studentId INT NOT NULL IDENTITY,

           studentName NVARCHAR(100) NOT NULL,

           CONSTRAINT pk_student PRIMARY KEY (studentId)

);

CREATE TABLE course

(

           courseId INT NOT NULL IDENTITY,

           courseTitle NVARCHAR(100) NOT NULL,

           semesterOffered NVARCHAR(100) NOT NULL,

           CONSTRAINT pk_course PRIMARY KEY (courseId),

           
);

CREATE TABLE enrollment

(
       enrollmentId INT NOT NULL IDENTITY,

       courseId INT NOT NULL,

       studentId INT NOT NULL,

       CONSTRAINT pk_enrollment PRIMARY KEY (enrollmentId),

       CONSTRAINT fk_enrollment_course FOREIGN KEY (courseId)

              REFERENCES course(courseId),

       CONSTRAINT fk_enrollment_student FOREIGN KEY (studentId)
              
              REFERENCES student(studentId)
);

INSERT INTO student (studentName) VALUES ('Mark Wehrwein');
INSERT INTO student (studentName) VALUES ('Ryan Furniss');
INSERT INTO student (studentName) VALUES ('Kevin Nguyen');
INSERT INTO student (studentName) VALUES ('Andy Suljic');

INSERT INTO course (courseTitle, semesterOffered) VALUES ('Agile', 'Fall 2024');
INSERT INTO course (courseTitle, semesterOffered) VALUES ('Hard Math', 'Winter 2025');
INSERT INTO course (courseTitle, semesterOffered) VALUES ('Advanced Agile', 'Winter 2025');

INSERT INTO enrollment (courseId, StudentId) VALUES (1, 1);
INSERT INTO enrollment (courseId, StudentId) VALUES (1, 2);
INSERT INTO enrollment (courseId, StudentId) VALUES (2, 3);
INSERT INTO enrollment (courseId, StudentId) VALUES (3, 4);

