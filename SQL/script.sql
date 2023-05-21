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

Insert into passenger values ('Nguyen Van A', '0123456789', '123456789')
Insert into passenger values ('Nguyen Van B', '0123456789', '123456789')
Insert into passenger values ('Nguyen Van C', '0123456789', '123456789')

Insert into ticket_price values (1, 1, 1000000)
Insert into ticket_price values (1, 2, 2000000)

Insert into seat_info values ('A1')
Insert into seat_info values ('A2')

Insert into seat_detail values (1, 1, 100, 0)
Insert into seat_detail values (1, 2, 100, 0)
Insert into seat_detail values (2, 1, 100, 0)
Insert into seat_detail values (2, 2, 100, 0)

insert into reserve_ticket values (1, 1, 1, '2019-12-01 08:00:00', 0)
insert into reserve_ticket values (1, 1, 2, '2019-12-01 08:00:00', 0)

insert into ticket values (1, 1, 1)
insert into ticket values (1, 1, 2)

insert into flight_detail values (1, 3, 'Direct flight')
insert into flight_detail values (2, 3, 'Direct flight')

select c.flight_id, departure, start, arrive, flight_time, class1_empty, class1_reserved, empty_amount as class2_empty, reserved_amount as class2_reserved from (select b.flight_id, route_id, departure, start, arrive, flight_time, empty_amount as class1_empty, reserved_amount as class1_reserved from (select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time from (select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id) as a inner join airport on airport_arrive_id = airport_id) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1) as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2

select airport_name, airport_location from (select stopover from flight inner join flight_detail on flight.flight_id = flight_detail.flight_id) as a inner join airport on a.stopover = airport_id

select * from (select price as class1price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = 1 and seat_id = 1) as a inner join (select price as class2price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = 1 and seat_id = 2) as b on 1 = 1

insert into ticket values (