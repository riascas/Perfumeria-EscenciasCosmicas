insert into Domicilios (Calle,Altura,Localidad,Distrito,Cod_Postal,Provincia,Pais)
values ('9 de Julio', 2548, 'Capital Federal', 'CABA', 'cp1258', 'Buenos Aires', 'Argentina')

select * from Domicilios

insert into Usuarios (Nombre,Apellido,DNI,Email,Celular,FK_Domicilio)
values ('Marcelo', 'Tinelli', 18563245, 'cabe_casla@mail.com', 1159874521,8)

select * from Usuarios
select * from Estados

insert into Clientes (Activo,FK_Usuario,FK_Estado)
values ('Activo', 9, 3)

select * from Clientes
