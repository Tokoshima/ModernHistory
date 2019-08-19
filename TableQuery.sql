CREATE TABLE EMPLOYEE(
Employee_ID int NOT NULL PRIMARY KEY,
Employee_LName nvarchar(50),
Employee_FName nvarchar(40),
Employee_Email nvarchar(75),
Employee_Cell Varchar(10));

CREATE TABLE EXHIBIT(
Exhibit_ID int NOT NULL PRIMARY KEY,
Exhibit_Description nvarchar(100),
Employee_ID int FOREIGN KEY REFERENCES EMPLOYEE(Employee_ID));

CREATE TABLE PROP(
Prop_ID int NOT NULL PRIMARY KEY,
Prop_Description nvarchar(100),
Exhibit_ID int FOREIGN KEY REFERENCES EXHIBIT(Exhibit_ID));

CREATE TABLE EVENT(
Event_ID int NOT NULL PRIMARY KEY,
Event_Description nvarchar(100),
Event_Date Date,
Employee_ID int FOREIGN KEY REFERENCES EMPLOYEE(Employee_ID));

CREATE TABLE CUSTOMER(
Customer_ID int NOT NULL PRIMARY KEY,
Customer_LName nvarchar(50),
Customer_FName nvarchar(25),
Customer_Email nvarchar(75),
Customer_Cell Varchar(10),
Event_ID int FOREIGN KEY REFERENCES EVENT(Event_ID));

CREATE TABLE VISIT(
Visit_ID int NOT NULL PRIMARY KEY,
Visit_Date Date,
Visit_Amount_Paid decimal,
Customer_ID int FOREIGN KEY REFERENCES CUSTOMER(Customer_ID));

CREATE TABLE Criteria(
Criteria_ID int NOT NULL PRIMARY KEY,
Criteria_Description nvarchar(100));

CREATE TABLE FEEDBACK(
Feedback_ID int NOT NULL PRIMARY KEY,
Feedback_Date Date,
Feedback_Rating smallint,
Customer_ID int FOREIGN KEY REFERENCES CUSTOMER(Customer_ID),
Criteria_ID int FOREIGN KEY REFERENCES Criteria(Criteria_ID));


