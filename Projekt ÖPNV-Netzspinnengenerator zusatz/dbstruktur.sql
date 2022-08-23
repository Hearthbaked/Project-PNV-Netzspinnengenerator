create database netzspinnengenerator;

create table staedte(
	idStaedte int not null auto_increment primary key,
	staedtename varchar (30) not null
);

create table linien(
    idLinien int not null auto_increment primary key,
	linienname varchar(30) not null,
	linienart enum('Bus','Tram','U-Bahn','Regionalbahn','Fähre', 'S-Bahn') not null,
	idStaedte int, foreign key (idStaedte) references staedte (idStaedte)
);

create table haltestellen(
	idHaltestellen int not null auto_increment primary key,
	haltestellenname varchar(30) not null,
	haltestellenkuerzel varchar(30) not null,
	streckenkilometer float not null,
	koordX int not null,
	koordY int not null,
	idLinien int, foreign key (idLinien) references linien (idLinien)
);