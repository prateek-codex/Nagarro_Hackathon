
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'FlickCart'))
BEGIN
	CREATE DATABASE FlickCart
END

GO

USE FlickCart

GO

BEGIN TRY
	BEGIN TRAN
	
		IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Product')
		BEGIN
				CREATE TABLE [dbo].[Product](
				[ProductId] [int] IDENTITY(1,1) NOT NULL,
				[Name] [varchar](300) NOT NULL,
				[Description] [varchar] (1000) NULL,
				[Price] [decimal] NULL,
				[Manufacturer] [varchar] (100) NULL,
				[CreatedBy] [int] NULL,
				[CreatedDate] [datetime] NULL,
				[ModifiedBy] [int] NULL,
				[ModifiedDate] [datetime] NULL,
			 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
			(
				[ProductId] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
			) ON [PRIMARY]
		END


	COMMIT TRAN
END TRY
BEGIN CATCH
	PRINT('ERROR') 
	DECLARE @ErrorMessage NVARCHAR(4000);
	DECLARE @ErrorSeverity INT;
	DECLARE @ErrorState INT;

	SELECT 
		@ErrorMessage = ERROR_MESSAGE(),
		@ErrorSeverity = ERROR_SEVERITY(),
		@ErrorState = ERROR_STATE();

	RAISERROR (@ErrorMessage, 
			   @ErrorSeverity, 
			   @ErrorState 
			   );
	ROLLBACK TRAN
END
