create table Departamentos(
id_departamento int identity Primary key,
Nombre_dep varchar(70)
);

create table Generos(
id_genero int identity Primary key,
genero varchar(30)
);

create table CasosReportados(
id int identity Primary key,
departamento_id
confirmados int,
recuperados int,
fallecidos int
);

insert into Departamentos(Nombre_dep)
Values('Santa Ana');

insert into Generos(genero)
Values('Masculino');

insert into CasosReportados(num_casos_confirm,num_casos_rec,num_casos_fall)
Values(5,3,1);
