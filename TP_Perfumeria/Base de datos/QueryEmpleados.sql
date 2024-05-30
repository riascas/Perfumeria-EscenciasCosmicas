insert into Domicilios (Calle,Altura,Localidad,Distrito,Cod_Postal,Provincia,Pais)
values ('Saavedra', 789, 'Monte Grande', 'Esteban Echeverria', 'mg1756', 'Buenos Aires', 'Argentina')

select * from Domicilios

insert into Usuarios (Nombre,Apellido,DNI,Email,Celular,FK_Domicilio)
values ('Enzo', 'Garcia', 37895621, 'egarcia@pefumeria.com.ar', 1154563211,6)

select * from Usuarios
select * from Cargos

insert into Empleados (Num_Legajo,NombreUsuario,Clave,Perfil,FK_Usuario,FK_Cargo)
values (0006, 'egarcia', '123456', 'encargado', 7,4)

select * from Empleados

