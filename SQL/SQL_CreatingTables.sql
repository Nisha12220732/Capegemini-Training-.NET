Create database TopBrains_Question
use TopBrains_Question

create table ZIPCODE_INFO
(ZIP_CODE varchar(5), 
CITY varchar(10))

sp_help ZIPCODE_INFO


create table INSTRUCTOR_INFO
(INSTRUCTOR_ID int, 
INSTRUCTOR_FIRST_NAME varchar(15),
INSTRUCTOR_LAST_NAME varchar(15))

sp_help INSTRUCTOR_INFO


create table COURSE_INFO
(COURSE_NO int, 
 COST int )

sp_help COURSE_INFO


create table STUDENT_INFO
(STUDENT_ID int, 
STUDENT_FIRST_NAME varchar(15),
STUDENT_LAST_NAME varchar(15))

sp_help STUDENT_INFO


CREATE table SECTION_INFO
( SECTION_ID int,
  COURSE_NO int,
  SECITON_NO int,
  INSTRUCTOR_ID int
 )
sp_help SECTION_INFO


create table ENROLLMENT_INFO
( STUDENT_ID int,
SECTION_ID int
)
sp_help ENROLLMENT_INFO

create table GRADE_INFO
(STUDENT_ID int,
SECTION_ID int,
GRADE_TYPE_CODE char,
GRADE_CODE_OCCURANCE int
)
sp_help GRADE_INFO