create database Airline_Reservation_System
go
use Airline_Reservation_System
go

create table seat_info
(
	seat_id int primary key identity(1,1),
	seat_name varchar(50) not null,
)

create table airport
(
	airport_id int primary key identity(1,1),
	airport_name varchar(50) not null,
	airport_location varchar(50) not null,
)

create table route
(
	route_id int primary key identity(1,1),
	airport_start_id int not null,
	airport_arrive_id int not null,
	flight_time int not null,
	foreign key (airport_start_id) references airport(airport_id),
	foreign key (airport_arrive_id) references airport(airport_id),
)

create table flight
(
	flight_id int primary key identity(1,1),
	route_id int not null,
	departure datetime not null,
	class_1_amount int not null,
	class_2_amount int not null,
	foreign key (route_id) references route(route_id),
)

create table flight_detail
(
	flight_detail_id int primary key identity(1,1),
	flight_id int not null,
	stopover int,
	note varchar(100) not null,
	foreign key (flight_id) references flight(flight_id),
	foreign key (stopover) references airport(airport_id),
)

create table seat_detail
(
	seat_detail_id int primary key identity(1,1),
	flight_id int not null,
	seat_id int not null,
	empty_amount int not null,
	reserved_amount int not null,
	foreign key (flight_id) references flight(flight_id),
	foreign key (seat_id) references seat_info(seat_id),
)

create table ticket_price
(
	ticket_price_id int primary key identity(1,1),
	route_id int not null,
	seat_id int not null,
	price int not null,
	foreign key (route_id) references route(route_id),
	foreign key (seat_id) references seat_info(seat_id),
)

create table passenger
(
	passenger_id int primary key identity(1,1),
	passenger_name varchar(50) not null,
	passenger_phone varchar(50) not null,
	passenger_id_number varchar(50) not null,
)

create table ticket
(
	ticket_id int primary key identity(1,1),
	flight_id int not null,
	ticket_price_id int not null,
	passenger_id int not null,
	foreign key (flight_id) references flight(flight_id),
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
	foreign key (flight_id) references flight(flight_id),
	foreign key (ticket_price_id) references ticket_price(ticket_price_id),
	foreign key (passenger_id) references passenger(passenger_id),
)
go

Insert into airport values ('Tan Son Nhat', 'Ho Chi Minh City')
Insert into airport values ('Noi Bai', 'Ha Noi')
Insert into airport values ('Da Nang', 'Da Nang')
Insert into airport values ('Cam Ranh', 'Khanh Hoa')

Insert into route values (1, 2, 120)
Insert into route values (1, 3, 80)
Insert into route values (1, 4, 60)
Insert into route values (2, 1, 120)
Insert into route values (2, 3, 100)

Insert into flight values (1, '2019-12-01 08:00:00', 100, 100)
Insert into flight values (2, '2019-12-01 08:00:00', 100, 100)
Insert into flight values (3, '2019-12-01 08:00:00', 100, 100)

Insert into flight_detail values (1, null, 'Direct flight')
Insert into flight_detail values (2, null, 'Direct flight')
Insert into flight_detail values (3, null, 'Direct flight')