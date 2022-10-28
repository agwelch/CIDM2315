CREATE TABLE Student(  
    studentID INT,
    studentName VARCHAR(50) NOT NULL,
    PRIMARY KEY (studentID)
) ;



CREATE TABLE Course(  
    courseID INT,
    courseName VARCHAR(50) NOT NULL,
    courseCredit INT NOT NULL,
    PRIMARY KEY (courseID)
) ;

CREATE Table Enrollment (
    studentID INT NOT NULL,
    courseID INT NOT NULL,
    semester VARCHAR(20) NOT NULL,
    PRIMARY KEY(studentID, courseID),
    Foreign Key (studentID) REFERENCES Student(studentID),
    Foreign Key (courseID) REFERENCES Course(courseID)
);


INSERT INTO Course(courseID, courseName, courseCredit) VALUES(2315, 'C#',3);
INSERT INTO Course VALUES (4360, 'OOAD', 3);
INSERT INTO Student VALUES (111,'Alice'), (222, 'Bob');
INSERT INTO Enrollment VALUES (111,2315,'Fall2022',3),(222,4360,'Fall2022',3);


SELECT * FROM Course, Student, Enrollment
WHERE
    Course.courseID = Enrollment.courseID
    AND
    Student.studentID = Enrollment.studentID;


CREATE VIEW StudentCourse
AS
SELECT studentName, courseName FROM Course, Student, Enrollment
WHERE
    Course.courseID = Enrollment.courseID
    AND
    Student.studentID = Enrollment.studentID;

SELECT * FROM StudentCourse;
