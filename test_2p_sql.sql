create database calculadora4;
use calculadora4;

create table resultadoOperacion (
	id_operacion int identity(1,1) primary key,
	dato1 int not null,
	dato2 int not null,
	operacion varchar(50),
	resultado int not null
);

