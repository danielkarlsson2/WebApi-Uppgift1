CREATE TABLE CustomerTasks (
	Id int not null identity primary key,
	Headline nvarchar(100) not null,
	Email nvarchar(150) not null,
	CreatedDate datetime not null,
	TextMessage nvarchar(max) not null
)