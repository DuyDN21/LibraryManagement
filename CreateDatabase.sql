Create database LibraryManagement
use LibraryManagement

create table Admin(
	AID int primary key,
	[Name] nvarchar(20),
	[Password] nvarchar(20)
)

create table Student(
	StudentID nvarchar(20) primary key,
	StudentName nvarchar(50),
	Phone varchar(10),
	DOB Datetime,
	[Address] nvarchar(50)
)

create table Authors(
	AuthorID nvarchar(20) primary key,
	AuthorName nvarchar(50)
)

create table Publisher(
	PublisherID nvarchar(20) primary key,
	PublisherName nvarchar(50)
)

create table BookCategories(
	CategoryID int identity(1,1) primary key,
	CategoryName nvarchar(50)
)

create table Books(
	BookID nvarchar(20) primary key,
	BookName nvarchar(50),
	Amount int,
	CategoryID int REFERENCES BookCategories(CategoryID),
	AuthorID nvarchar(20) REFERENCES Authors(AuthorID),
	PublisherID nvarchar(20) REFERENCES Publisher(PublisherID)
)

create table BorrowBook(
	BookID nvarchar(20) REFERENCES Books(BookID),
	StudentID nvarchar(20) REFERENCES Student(StudentID),
	Primary key(BookID, StudentID),
	BorrowedDate Datetime,
	ReturnDate Datetime
)
