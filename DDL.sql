CREATE DATABASE LoanCalculator
USE LoanCalculator

CREATE TABLE AVAILABILITY_MONTHS
(
	ID int primary key identity,
	SPAN int unique,
	SPAN_DESCRIPTION varchar(30)
)

CREATE TABLE AGE_RATE
(
	ID int primary key identity,
	AGE int unique,
	RATE DECIMAL(5,2)
)

CREATE TABLE QUERY_LOG
(
	ID int primary key identity,
	QUERY_DATE datetime,
	AGE int,
	AMOUNT decimal(20,2),
	MONTHS int,
	MONTHLY_PAYMENT decimal(12,2),
	QUERY_IP VARCHAR(50) unique
)
