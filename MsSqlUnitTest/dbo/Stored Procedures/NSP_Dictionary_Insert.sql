/*
	新建Dictionary資料
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