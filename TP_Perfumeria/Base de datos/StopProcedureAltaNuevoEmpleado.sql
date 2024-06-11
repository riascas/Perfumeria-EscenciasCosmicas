create procedure AltaNuevoEmpleado
@Calle nvarchar(50),
@Altura int,
@Localidad nvarchar(50),
@Distrito nvarchar(50),
@Cod_Postal nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@DNI int,
@Email nvarchar(50),
@Celular int,
@Num_Legajo int,
@NombreUsuario nvarchar(50),
@Clave nvarchar(50),
@Perfil nvarchar(50),
@FK_Cargo int

as
Begin

declare @ID_Domicilio int
declare @ID_Usuario int

insert into Domicilios (Calle, Altura, Localidad, Distrito, Cod_Postal, Provincia, Pais)
values (@Calle, @Altura, @Localidad, @Distrito, @Cod_Postal, @Provincia, @Pais)
set @ID_Domicilio = SCOPE_IDENTITY()

insert into Usuarios (Nombre, Apellido, DNI, Email, Celular, FK_Domicilio)
values (@Nombre, @Apellido, @DNI, @Email, @Celular, @ID_Domicilio)
set @ID_Usuario = SCOPE_IDENTITY()

insert into Empleados (Num_Legajo, NombreUsuario, Clave, Perfil, FK_Usuario, FK_Cargo)
values (@Num_Legajo, @NombreUsuario, @Clave, @Perfil, @ID_Usuario, @FK_Cargo)
end

