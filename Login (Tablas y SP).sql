---Login y contrase�a
Create Table Usuarios
(
    usuario varchar(50),
    nombre varchar(50),
	email varchar(50),
	contrase�a varchar(400)
	constraint pk_usuario primary key (usuario)
)

--Con este procedimiento almacenado se hacen los insert
--Exec  SP_NUEVO_USUARIO 'Pedro Gomez', 'pepe.g@hotmail.com', 'PGomez', 'contra.pepe'
Create Procedure SP_NUEVO_USUARIO
  @nombre varchar(50),
  @email varchar(50),
  @usuario varchar(50), 
  @contrase�a varchar(50)
As
Begin
    Insert Into Usuarios
    (
        nombre,
		email,
		usuario,
        contrase�a
    )
    Values
    (
        @nombre,
		@email,
		@usuario,
        ENCRYPTBYPASSPHRASE('password', @contrase�a)
    )
End
--Verificar usuario en el login
Create Procedure SP_LOGIN_USUARIO
    
	@usuario varchar(50),  
    @contrase�a varchar(50),
    @resultado bit Output
As
    Declare @PassEncode As varchar(300)
    Declare @PassDecode As varchar(50)
Begin
    Select @PassEncode = contrase�a From Usuarios Where usuario = @usuario
    Set @PassDecode = DECRYPTBYPASSPHRASE('password', @PassEncode)
End
 
Begin
    If @PassDecode = @contrase�a
        Set @resultado = 1
    Else
        Set @resultado = 0
End


