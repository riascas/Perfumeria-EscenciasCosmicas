USE [Perfumeria_2.0]
GO

CREATE PROCEDURE SPAltaCliente
    @Calle NVARCHAR(50),
    @Altura INT,
    @Localidad NVARCHAR(50),
    @Distrito NVARCHAR(50),
    @Cod_Postal NVARCHAR(50),
    @Provincia NVARCHAR(50),
    @Pais NVARCHAR(50),
    @Nombre NVARCHAR(50),
    @Apellido NVARCHAR(50),
    @DNI INT,
    @Email NVARCHAR(50),
    @Celular INT,
    @Activo NVARCHAR(50),
    @FK_Estado INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @ID_Domicilio INT;
        DECLARE @ID_Usuario INT;

        INSERT INTO Domicilios (Calle, Altura, Localidad, Distrito, Cod_Postal, Provincia, Pais)
        VALUES (@Calle, @Altura, @Localidad, @Distrito, @Cod_Postal, @Provincia, @Pais);

        SET @ID_Domicilio = SCOPE_IDENTITY();

        INSERT INTO Usuarios (Nombre, Apellido, DNI, Email, Celular, FK_Domicilio)
        VALUES (@Nombre, @Apellido, @DNI, @Email, @Celular, @ID_Domicilio);

        SET @ID_Usuario = SCOPE_IDENTITY();

        INSERT INTO Clientes (Activo, FK_Usuario, FK_Estado)
        VALUES (@Activo, @ID_Usuario, @FK_Estado);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END;

        -- Puedes agregar código para manejar el error aquí, como registrar el error en una tabla de errores o devolver un código de error al usuario.
        THROW;
    END CATCH;
END