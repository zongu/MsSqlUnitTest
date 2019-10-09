-- ����DB���� 
-- �Ȅh��: SP -> UDT -> TABLE
-- ������/��݋: TABLE -> ����/�h����λ -> UDT -> SP
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'NSP_Dictionary_Insert' AND type = 'P') DROP  PROCEDURE NSP_Dictionary_Insert
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Dictionary' AND type = 'U') DROP TABLE Dictionary
GO

CREATE TABLE [dbo].[Dictionary] (
    [DictionaryId] BIGINT        NOT NULL,
    [Value]        NVARCHAR (50) NOT NULL
);
GO

/*
	�½�Dictionary�Y��
	2019-10-17	Carter	Create


	ex:
		exec NSP_Dictionary_Insert
		@DictionaryId = 1,
		@Value = 'Test123'
*/

CREATE PROCEDURE [dbo].[NSP_Dictionary_Insert]
	@DictionaryId BIGINT,
	@Value	NVARCHAR(50)
AS
	INSERT INTO Dictionary 
	OUTPUT inserted.*
	VALUES (@DictionaryId, @Value)
RETURN 0
GO
GRANT EXECUTE
    ON OBJECT::[dbo].[NSP_Dictionary_Insert] TO PUBLIC
    AS [dbo];
GO