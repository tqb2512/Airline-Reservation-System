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
Insert into airport values (N'Cảng hàng không quốc tế Phú Quốc', N'Kiên Giang')Insert into airport values (N'Sân bay quốc tế Cát Bi', N'Hải Phòng')
Insert into airport values (N'Sân bay quốc tế Vinh', N'Nghệ An')
Insert into airport values (N'Sân bay quốc tế Phú Bài', N'Thừa Thiên Huế')
Insert into airport values (N'Sân bay quốc tế Phù Cát', N'Bình Định')
Insert into airport values (N'Sân bay quốc tế Chu Lai', N'Quảng Nam')
Insert into airport values (N'Sân bay quốc tế Đồng Hới', N'Quảng Bình')

insert into route values (1, 2, 180)
insert into route values (2, 1, 180)
insert into route values (2, 3, 140)
insert into route values (2, 5, 60)
insert into route values (3, 4, 120)
insert into route values (3, 1, 75)
insert into route values (5, 2, 60)
insert into route values (5, 4, 50)
insert into route values (3, 2, 140)
insert into route values (1, 5, 340)
insert into route values (4, 1, 120)
insert into route values (4, 2, 50)
insert into route values (4, 3, 120)
insert into route values (4, 5, 50)

insert into flight values (1, '11/11/2022', 80, 20)
insert into flight values (2, '7/1/2023', 90, 25)
insert into flight values (3, '9/7/2023', 80, 20)
insert into flight values (4, '12/15/2023', 09, 25)
insert into flight values (5, '09/23/2023', 80, 20)
insert into flight values (6, '8/13/2023', 80, 20)
insert into flight values (7, '11/22/2023', 80, 20)
insert into flight values (8, '7/2/2023', 80, 20)
insert into flight values (9, '6/5/2023', 90, 22)
insert into flight values (10, '3/3/2023', 80, 20)
insert into flight values (11, '2/2/2023', 80, 20)
insert into flight values (12, '1/1/2023', 80, 20)



insert into flight_detail values (1, 2, 45,	'')
insert into flight_detail values (2, 1, 30,	'')
insert into flight_detail values (3, 4, 15,	'')
insert into flight_detail values (4, 3, 15,	'')
insert into flight_detail values (5, 5, 0,	'')
insert into flight_detail values (6, 2, 0,	'')
insert into flight_detail values (7, 3, 15,	'')
insert into flight_detail values (8, 2, 0,	'')
insert into flight_detail values (9, 5, 40,	'')
insert into flight_detail values (10, 5, 0,	'')
insert into flight_detail values (11, 4, 0,	'')
insert into flight_detail values (12, 3, 0,	'')


insert into seat_detail values (1, 1, 0, 0)
insert into seat_detail values (1, 2, 0, 0)
insert into seat_detail values (2, 1, 0, 0)
insert into seat_detail values (2, 2, 0, 0)
insert into seat_detail values (3, 1, 0, 0)
insert into seat_detail values (3, 2, 0, 0)
insert into seat_detail values (4, 1, 0, 0)
insert into seat_detail values (4, 2, 0, 0)
insert into seat_detail values (5, 1, 0, 0)
insert into seat_detail values (5, 2, 0, 0)
insert into seat_detail values (6, 1, 0, 0)
insert into seat_detail values (6, 2, 0, 0)
insert into seat_detail values (7, 1, 0, 0)
insert into seat_detail values (7, 2, 0, 0)
insert into seat_detail values (8, 1, 0, 0)
insert into seat_detail values (8, 2, 0, 0)
insert into seat_detail values (9, 1, 0, 0)
insert into seat_detail values (9, 2, 0, 0)
insert into seat_detail values (10, 1, 0, 0)
insert into seat_detail values (10, 2, 0, 0)
insert into seat_detail values (11, 1, 0, 0)
insert into seat_detail values (11, 2, 0, 0)
insert into seat_detail values (12, 1, 0, 0)
insert into seat_detail values (12, 2, 0, 0)

insert into ticket_price values (1, 1, 350)
insert into ticket_price values (1, 2, 450)
insert into ticket_price values (2, 1, 350)
insert into ticket_price values (2, 2, 450)
insert into ticket_price values (3, 1, 350)
insert into ticket_price values (3, 2, 450)
insert into ticket_price values (4, 1, 300)
insert into ticket_price values (4, 2, 450)
insert into ticket_price values (5, 1, 300)
insert into ticket_price values (5, 2, 450)
insert into ticket_price values (6, 1, 300)
insert into ticket_price values (6, 2, 450)
insert into ticket_price values (7, 1, 300)
insert into ticket_price values (7, 2, 350)
insert into ticket_price values (8, 1, 300)
insert into ticket_price values (8, 2, 350)
insert into ticket_price values (9, 1, 300)
insert into ticket_price values (9, 2, 250)
insert into ticket_price values (10, 1, 300)
insert into ticket_price values (10, 2, 250)
insert into ticket_price values (11, 1, 300)
insert into ticket_price values (11, 2, 250)
insert into ticket_price values (12, 1, 300)
insert into ticket_price values (12, 2, 450)



insert into passenger values ('Lee Sang Hyeok', '0912345678', '000001')
insert into passenger values ('Do Duy Khanh', '0912345678', '000002')
insert into passenger values ('Tran Van Cuong', '0912345678', '000003')
insert into passenger values ('Nguyen Tien Nam', '0912345678', '000004')
insert into passenger values ('Lionel Messi', '0912345678', '000005')
insert into passenger values ('Nghiem Vu Hoang Long', '0912345678', '000006')
insert into passenger values ('Trang Vu Ai My', '0912345678', '000007')
insert into passenger values ('Tran Tri Duc', '0912345678', '000008')
insert into passenger values ('Nguyen Thanh Tung', '0912345678', '000009')
insert into passenger values ('Nguyen Viet Hoang', '0912345678', '000010')
insert into passenger values ('Nguyen Van A', '0912345678', '000011')
insert into passenger values ('Nguyen Van B', '0912345678', '000012')
insert into passenger values ('Nguyen Van C', '0912345678', '000013')
insert into passenger values ('Nguyen Van D', '0912345678', '000014')
insert into passenger values ('Nguyen Van E', '0912345678', '000015')

select month, sum(total) as total 
from 
	(
	select month, sum(total) as total 
	from 
		(
		select month, sum * price as total 
		from 
			(
			select month(departure) as month, route_id, sum(reserved_amount) as sum 
			from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id 
			where year(departure) = 2023 and seat_id = 1 group by month(departure), route_id
			) as a 
		inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1
		) as b 
	group by month 
	union 
	select month, sum(total) as total 
	from 
		(
		select month, sum * price as total 
		from 
			(
			select month(departure) as month, route_id, sum(reserved_amount) as sum 
			from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id 
			where year(departure) = 2023 and seat_id = 2 
			group by month(departure), route_id
			) as a 
		inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 2
		) as b 
	group by month
) as b group by month