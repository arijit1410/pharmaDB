create table pharmacist(pharmacist_id varchar(20),
first_name varchar(20),
last_name varchar(20),
postal_address varchar(100),
phone int,
email varchar(20),
username varchar(20),
password varchar(20));

insert into pharmacist values('P135', 'Radhesh','Sharma','20 Ipwing Street Bombay',9711050457,'radhesh@gmail.com','radrox','radrox123');
insert into pharmacist values('P138', 'Mukesh','Kumar','50 Happy Place Thane',9711050789,'mukesh@gmail.com','muks123','muks123');
insert into pharmacist values('P140', 'Champak','Chaturvedi','201 Super Apartments Bhopal',9899050789,'champs@gmail.com','champs','champs123');
insert into pharmacist values('P144', 'Chaman','Tiwari','200 Hello Apartments Manipal',9899050777,'chaman@gmail.com','chomu','chomu123');
insert into pharmacist values('P145', 'Manish','Sisodia','210 Music Apartments Noida',9897750789,'manish@gmail.com','manish','manish123');

###
create table cashier(cashier_id varchar(20),
first_name varchar(20),
last_name varchar(20),
postal_address varchar(100),
phone int,
email varchar(20),
username varchar(20),
password varchar(20));

insert into cashier values('C135', 'Supriya','Batra','20 Ipwing Street Bombay',9711050457,'supriya@gmail.com','supriya','supriya123');
insert into cashier values('C138', 'Karuna','Dhingra','50 Happy Place Thane',9711050789,'karunaa@gmail.com','karuna','karuna123');
insert into cashier values('C140', 'Sarita','Joshi','201 Super Apartments Bhopal',9899050789,'Sarita@gmail.com','sarita','sarita123');
insert into cashier values('C144', 'Krishna','Sehgal','200 Hello Apartments Manipal',9899050777,'Krishna@gmail.com','krisha','krishna123');
insert into cashier values('C145', 'Laila','Kapoor','210 Music Apartments Noida',9897750789,'Laila@gmail.com','laila','laila123');
insert into cashier values('C146', 'Sunny','Singh','204 Ipwing Street Bombay',9711050457,'Sunny@gmail.com','sunny','sunny123');
insert into cashier values('C147', 'Lovepreet','Chaddha','507 Happy Place Thane',9711050789,'Lovepreet@gmail.com','lovepreet','lovepreet123');
insert into cashier values('C148', 'Gurkiran','Kaur','2016 Super Apartments Bhopal',9899050789,'Gurkiran@gmail.com','gurkiran','gurkiran123');
insert into cashier values('C149', 'Harman','Baweja','2008 Hello Apartments Manipal',9899050777,'Harman@gmail.com','harman','harkaran123');
insert into cashier values('C156', 'Lalu','Jonas','2109 Music Apartments Noida',9897750789,'Lalu@gmail.com','lalu','lalu123');

###
create table manager(manager_id varchar(20),
first_name varchar(20),
last_name varchar(20),
postal_address varchar(100),
phone int,
email varchar(20),
username varchar(20),
password varchar(20));

insert into manager values('M135', 'Mihir','Surti','20 Ipwing Street Bombay',9711050457,'mihir@gmail.com','mihir','mihir123');
insert into manager values('M138', 'Arijit','Ghosh',' Happy Place Thane',9711050789,'arijit@gmail.com','arijit','arijit123');
insert into manager values('M140', 'Ayush','Dwivedi','201 Super Apartments Bhopal',9899050789,'ayush@gmail.com','ayush','ayush123');
insert into manager values('M144', 'Shubham','Rayar','200 Hello Apartments Manipal',9899050777,'shubham@gmail.com','shubham','shubham123');
insert into manager values('M145', 'Anvita','Goyal','210 Music Apartments Noida',9897750789,'anvita@gmail.com','anvita','anvita123');

###
create table prescription_details( id varchar(20),
pres_id varchar(20),
drug_name varchar(20),
strength varchar(20),
dose varchar(20),
quantity varchar(20));

###





