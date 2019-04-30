create table [dbo].[Users](
    Id uniqueidentifier not null primary key,
	Login nvarchar(50) not null,
	Password nvarchar(50) not null
);
create table [dbo].[News](
    Id uniqueidentifier not null primary key,
	Title nvarchar(100) not null,
	Description nvarchar(Max) not null,
	UserLogin nvarchar(50) not null
);
create table [dbo].[Comments](
    Id uniqueidentifier not null primary key,
	Content nvarchar(300) not null,
	NewsId uniqueidentifier not null,
	UserLogin nvarchar(50) not null
);