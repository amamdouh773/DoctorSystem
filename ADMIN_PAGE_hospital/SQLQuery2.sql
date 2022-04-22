
CREATE PROCEDURE dbo.DOCTORadd_or_edit
@mode nvarchar(10),
@user_name nvarchar(50),
@phone int,
@adress nvarchar(250)
	
AS
if @mode='add'
begin 
INSERT INTO dbo.DOCTOR
(
user_name,
phone,
Doctor_adress
)
VALUES 
(
@user_name,
@phone,
@adress
)
end

