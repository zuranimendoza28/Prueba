-- Active: 1717619463978@@bbjpv6oz0aqykhrqldka-mysql.services.clever-cloud.com@3306
   
   CREATE TABLE Student (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Names VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE,
    Address VARCHAR(255) ,
    BirthDate DATE
);
INSERT INTO Student (Names, Email, Address, BirthDate)
VALUES('sara', 'sara@gmail.com', 'carrera 104', '2024-03-01'),
      ('caro', 'caro@gmail.com', 'carrera 105', '2021-04-01'),
      ('isa', 'isa@gmail.com', 'carrera 106', '2009-03-01'),
      ('zura', 'zuramendozavillada@gmail.com', 'carrera 105', '2004-01-01')

   CREATE TABLE Teacher (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Names VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE,
    Specialty VARCHAR(255) ,
    Phone VARCHAR(255),
    YearsExperience INTEGER
);
INSERT INTO Teacher (Names, Email, Specialty, Phone, YearsExperience)
VALUES('vivi', 'vivi@gmail.com', 'ingles ', '12345','2'),
      ('aleja', 'aleja@gmail.com', 'habilidades ', '214556', '3'),
      ('robi', 'robi@gmail.com', 'desarrolo ', '20090301', '5'),
      ('lili', 'lili@gmail.com', 'habilidades ', '20040101', '3');


CREATE TABLE Course (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Description TEXT,
    Duration VARCHAR(255),
    Capacity INT,
    TeacherId INT,
    FOREIGN KEY (TeacherId) REFERENCES Teacher(Id)
);
INSERT INTO Course (Name, Description, Duration,Capacity, TeacherId)
VALUES('ingles', 'mmmmmm', '8 meses', '10 ','1'),
      ('hebilidades', 'mmmmm', '8 meses', '10 ',  '2'),
      ('desarrollo', 'mmmmm', '8 meses','10 ', '3'),
      ('etica', 'mmmmmmm', '8 meses','10 ', '4')


CREATE TABLE Enrollment (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Date DATE,
    Status ENUM ('Activo', 'Inactivo'),
    StudentId INT,
    CourseId INT,
    FOREIGN KEY (StudentId) REFERENCES Student(Id),
    FOREIGN KEY (CourseId) REFERENCES Course(Id)
);
INSERT INTO Enrollment (Date, Status, StudentId, CourseId)
VALUES('2009-04-01', 'Activo', '1 ', '2'),
      ('2009-03-01', 'Activo', '2 ', '3'),
      ('2009-05-01', 'Activo', '3 ', '4'),
      ('2009-07-01', 'Activo', '4 ', '1');




DROP TABLE Courses;
DROP TABLE Enrollments;
DROP TABLE Teachers;
DROP Table Students;
