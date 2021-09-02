create proc Login_Select
 @user nvarchar(50),
 @pass nvarchar(50)

 as
SELECT [username]
      ,[password]
      ,[Permision]
  FROM [dbo].[Login]
WHERE @user =[username]
and @pass =[password]


