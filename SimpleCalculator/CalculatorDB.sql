
CREATE TABLE [dbo].[Calculator](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SummationOfNumberValue] [nvarchar](255) NOT NULL,
	[Result] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Calculator] PRIMARY KEY CLUSTERED 
(
	[Result] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SPGetCalculatorData]    Script Date: 12/2/2022 2:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGetCalculatorData]
AS
BEGIN
    SELECT [Id]
          ,[SummationOfNumberValue]
         ,[Result]
    FROM [dbo].[Calculator]
	ORDER BY Id DESC
END
  
GO
/****** Object:  StoredProcedure [dbo].[SPSaveCalculatorData]    Script Date: 12/2/2022 2:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPSaveCalculatorData]
 @SummationOfNumberValue nvarchar(255),
 @Result Decimal(18,2)
AS
BEGIN
	INSERT INTO [dbo].[Calculator]
           ([SummationOfNumberValue]
           ,[Result])
     VALUES
           (@SummationOfNumberValue + ' ='
           ,@Result)
END
  
GO
/****** Object:  StoredProcedure [dbo].[SPTruncateCalculatorTable]    Script Date: 12/2/2022 2:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SPTruncateCalculatorTable]
	
AS
BEGIN
	truncate table Calculator;
END
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateCalculatorData]    Script Date: 12/2/2022 2:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUpdateCalculatorData]
 @Id Int,
 @SummationOfNumberValue nvarchar(255),
 @Result Decimal(18,2)
AS
BEGIN
	UPDATE [dbo].[Calculator]
       SET [SummationOfNumberValue] = @SummationOfNumberValue
      ,[Result] = @Result
     WHERE id = @Id
END
  
GO
