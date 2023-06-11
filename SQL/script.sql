create database Airline_Reservation_System
go
use Airline_Reservation_System
go

create table seat_info
(
	seat_id int primary key identity(1,1),
	seat_name nvarchar(50) not null,
)

create table airport
(
	airport_id int primary key identity(1,1),
	airport_name nvarchar(50) not null,
	airport_location nvarchar(50) not null,
)

create table route
(
	route_id int primary key identity(1,1),
	airport_start_id int not null,
	airport_arrive_id int not null,
	flight_time int not null,
	foreign key (airport_start_id) references airport(airport_id) on delete cascade,
	foreign key (airport_arrive_id) references airport(airport_id),
)

create table flight
(
	flight_id int primary key identity(1,1),
	route_id int not null,
	departure datetime not null,
	class_1_amount int not null,
	class_2_amount int not null,
	foreign key (route_id) references route(route_id) on delete cascade,
)

create table flight_detail
(
	flight_detail_id int primary key identity(1,1),
	flight_id int not null,
	stopover int,
	stopover_time int,
	note varchar(100) not null,
	foreign key (flight_id) references flight(flight_id) on delete cascade,
	foreign key (stopover) references airport(airport_id),
)

create table seat_detail
(
	seat_detail_id int primary key identity(1,1),
	flight_id int not null,
	seat_id int not null,
	empty_amount int not null,
	reserved_amount int not null,
	foreign key (flight_id) references flight(flight_id) on delete cascade,
	foreign key (seat_id) references seat_info(seat_id),
)

create table ticket_price
(
	ticket_price_id int primary key identity(1,1),
	route_id int not null,
	seat_id int not null,
	price int not null,
	foreign key (route_id) references route(route_id) on delete cascade,
	foreign key (seat_id) references seat_info(seat_id),
)

create table passenger
(
	passenger_id int primary key identity(1,1),
	passenger_name nvarchar(50) not null,
	passenger_phone nvarchar(50) not null,
	passenger_id_number nvarchar(50) not null,
)

create table ticket
(
	ticket_id int primary key identity(1,1),
	flight_id int not null,
	ticket_price_id int not null,
	passenger_id int not null,
	foreign key (flight_id) references flight(flight_id) on delete cascade,
	foreign key (ticket_price_id) references ticket_price(ticket_price_id),
	foreign key (passenger_id) references passenger(passenger_id),
)

create table reserve_ticket
(
	reserve_ticket_id int primary key identity(1,1),
	flight_id int not null,
	ticket_price_id int not null,
	passenger_id int not null,
	date datetime not null,
	status int not null,
	foreign key (flight_id) references flight(flight_id) on delete cascade,
	foreign key (ticket_price_id) references ticket_price(ticket_price_id),
	foreign key (passenger_id) references passenger(passenger_id),
)

create table attribute
(
	max_stop_over int not null,
	min_stop_over_time int not null,
	max_stop_over_time int not null,
	min_flight_time float not null,
	booking_deadline int not null,
)

go

Insert into attribute values (2, 10, 20, 30, 24)

Insert into seat_info values ('A1')
Insert into seat_info values ('A2')

Insert into airport values (N'Sân bay quốc tế Nội Bài', N'Hà Nội')
Insert into airport values (N'Sân bay quốc tế Tân Sơn Nhất', N'Hồ Chí Minh')
Insert into airport values (N'Sân bay quốc tế Đà Nẵng', N'Đà Nẵng')
Insert into airport values (N'Cảng hàng không quốc tế Cam Ranh', N'Khánh Hòa')
Insert into airport values (N'Cảng hàng không quốc tế Phú Quốc', N'Kiên Giang')