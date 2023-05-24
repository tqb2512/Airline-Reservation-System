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

create table year_report
(
	year_report_id int primary key identity(1,1),
	year int not null,
	total int not null,
)

create table month_report
(
	month_report_id int primary key identity(1,1),
	month int not null,
	year_report_id int not null,
	total int not null,
	foreign key (year_report_id) references year_report(year_report_id),
)

create table detail_month_report
(
	detail_month_report_id int primary key identity(1,1),
	month_report_id int not null,
	flight_id int not null,
	total int not null,
	foreign key (month_report_id) references month_report(month_report_id),
	foreign key (flight_id) references flight(flight_id),
)

go

Insert into seat_info values ('A1')
Insert into seat_info values ('A2')

Insert into airport values (N'Sân bay quốc tế Nội Bài', N'Hà Nội')
Insert into airport values (N'Sân bay quốc tế Tân Sơn Nhất', N'Hồ Chí Minh')
Insert into airport values (N'Sân bay quốc tế Đà Nẵng', N'Đà Nẵng')
Insert into airport values (N'Cảng hàng không quốc tế Cam Ranh', N'Khánh Hòa')
Insert into airport values (N'Cảng hàng không quốc tế Phú Quốc', N'Kiên Giang')





select c.flight_id, start, arrive, departure, flight_time, class1_empty, empty_amount as class2_empty 
from 
	(
	select b.flight_id, route_id, departure, start, arrive, flight_time, empty_amount as class1_empty, reserved_amount as class1_reserved 
	from 
		(
		select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time 
		from 
			(
				select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time 
				from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id
			) 
		as a inner join airport on airport_arrive_id = airport_id
		) 
	as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1
	) 
as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2


select b.flight_id, start, arrive, departure, flight_time, empty_amount from
	(
		select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time 
		from 
			(
				select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time 
				from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id
			) 
		as a inner join airport on airport_arrive_id = airport_id
	) as b inner join seat_detail on b.flight_id = seat_detail.flight_id


select c.flight_id, start, arrive, departure, flight_time, class1_empty, empty_amount as class2_empty 
from 
	(
	select b.flight_id, route_id, departure, start, arrive, flight_time, empty_amount as class1_empty, reserved_amount as class1_reserved 
	from 
		(
			select flight_id, route_id, departure, start, airport_location as arrive, flight_time 
			from 
				(
					select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time 
					from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id
				) as a inner join airport on airport_arrive_id = airport_id
		) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1
	)as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2

select route_id, airport.airport_name as start, airport.airport_location as start_location, b.airport_name as arrive, b.airport_location as arrive_location from route inner join airport on airport_start_id = airport_id inner join airport as b on airport_arrive_id = b.airport_id

select c.flight_id, departure, start, arrive, flight_time, class_1_amount, class1_reserved, class_2_amount, reserved_amount as class2_reserved from (select b.flight_id, route_id, departure, start, arrive, flight_time, reserved_amount as class1_reserved, class_1_amount, class_2_amount from (select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time, class_1_amount, class_2_amount from (select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time, class_1_amount, class_2_amount from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id) as a inner join airport on airport_arrive_id = airport_id) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1) as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2

select airport_name, airport_location from (select stopover from flight inner join flight_detail on flight.flight_id = flight_detail.flight_id) as a inner join airport on a.stopover = airport_id

select class1_empty, empty_amount as class2_empty from (select flight_id, empty_amount as class1_empty from seat_detail where flight_id = " + flightId.Text + " and seat_id = 1) as a inner join seat_detail on a.flight_id = seat_detail.flight_id where seat_id = 2
	


/*get profit from year*/

select sum(sum) as profit from 
(select class1reserved, price, class1reserved * price as sum from 
(
select reserved_amount as class1reserved, route_id
from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id
where year(departure) = 2023 and seat_id = 1
) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1) as b
union all
select sum(sum) as class2profit from
(select class2reserved, price, class2reserved * price as sum from 
(
select reserved_amount as class2reserved, route_id
from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id
where year(departure) = 2023 and seat_id = 2
) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 2) as b


/*end of get profit from year*/

/*select profit per month in year*/

select sum(sum) as profit, month from
(
	select month(departure) as month 
	from flight
	where year(departure) = 2023
	group by month(departure)
) as a 

select month, sum(total) as total from (select month, sum * price as total from (select month(departure) as month, route_id, sum(reserved_amount) as sum from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = 2023 and seat_id = 1 group by month(departure), route_id) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1) as b group by month

/*end of select profit per month in year*/


/*select profit per flight in month*/

select flight_id, route_id
from flight
where year(departure) = 2023 and month(departure) = 5

select flight_id, sum * price as total from (select flight.flight_id, route_id, sum(reserved_amount) as sum from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = " + monthPick.Value.Year + " and month(departure) = " + monthPick.Value.Month + " and seat_id = 1 group by flight.flight_id, route_id)as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1

/*end of select profit per flight in month*/

select * from (select price as class1price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = 1 and seat_id = 1) as a inner join (select price as class2price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = 1 and seat_id = 2) as b on 1 = 1