use MobileBank

create table Client(
	IdClient int identity(1,1) not null primary key,
	ClientLastName nvarchar(50) not null,
	ClientFirstName nvarchar(50) not null,
	ClientMiddleName nvarchar(50) not null,
	ClientGender nvarchar(3) not null,
	ClientPassword nvarchar(256) not null,
	ClientEmail nvarchar(50) not null,
	ClientPhoneNumber nchar(12) not null
)
create table BankCard(
	IdBankCard int identity(1,1) not null primary key,
	BankCardType nvarchar(50) not null,
	BankCardNumber nvarchar(16) not null,
	BankCardCvvCode nvarchar(3) not null,
	BankCardBalance money default 0,
	BankCardCurrency nvarchar(10) not null,
	BankCardPaymentSystem nvarchar(500) not null,
	BankCardDate date not null,
	BankCardPin int not null
)

alter table BankCard add IdClient int
alter table BankCard add foreign key (IdClient) references dbo.Client(IdClient) on delete no action on update cascade

create table Transactions(
	IdTransaction int identity(1,1) not null primary key,
	TransactionType varchar(50) not null,
	TransactionDestination varchar(200) not null,
	TransactionDate date not null,
	TransactionNumber nchar(50),
	TransactionValue money
)

alter table Transactions add IdBankCard int
alter table Transactions add foreign key (IdBankCard) references dbo.BankCard(IdBankCard) on delete no action on update cascade

create table Credits(
	IdCredit int identity(1,1) not null primary key,
	CreditTotalSum money not null,
	CreditDate date not null,
	CreditStatus bit not null default 0,
	RepaymentDate date,
	RepaymentSum money
)

alter table Credits add IdBankCard int
alter table Credits add foreign key (IdBankCard) references dbo.BankCard(IdBankCard) on delete no action on update cascade

create table ClientServices(
	IdService int identity(1,1) not null primary key,
	ServiceName varchar(100) not null,
	ServiceBalance money default 0,
	ServiceType varchar(100) not null
)

create table ClientPersonalAccount(
	IdPersonalAccount int identity(1,1) not null primary key,
	PersonalAccount nvarchar(10) not null
)

alter table ClientPersonalAccount add IdService int
alter table ClientPersonalAccount add foreign key (IdService) references dbo.ClientServices(IdService) on delete no action on update cascade

alter table ClientPersonalAccount add IdClient int
alter table ClientPersonalAccount add foreign key (IdClient) references dbo.Client(IdClient) on delete no action on update cascade
