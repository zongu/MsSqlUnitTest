# MsSqlUnitTest
## 1. DB First 建立測試用的庫跟表<br>
<img src="Img/001.jpg" width="300">
<img src="Img/002.jpg" width="300">

## 2. 建立VisualStudio專案<br>
<img src="Img/003.jpg" width="300">

## 3. 匯入建立好的庫<br>
<img src="Img/004.jpg" width="300">
<img src="Img/005.jpg" width="300">
<img src="Img/006.jpg" width="300">

## 4. 新建SP<br>
<img src="Img/007.jpg" width="300">
<img src="Img/008.jpg" width="300">
<img src="Img/009.jpg" width="300">

```
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
```

## 5. 發行資料庫專案<br>
<img src="Img/010.jpg" width="300">
<img src="Img/011.jpg" width="300">

## 6. 利用LinqPad取得強行別<br>
<img src="Img/012.jpg" width="300">

## 7. 建立類別<br>
<img src="Img/013.jpg" width="300">

## 8. 建立介面並定義行為<br>
<img src="Img/014.jpg" width="300">

## 8. 建立實作<br>
<img src="Img/015.jpg" width="300">

## 9. 新增單元測試專案<br>
<img src="Img/016.jpg" width="300">
<img src="Img/017.jpg" width="300">

---
<br>
<br>
<br>
<br>

# 進階版本(DB佈署工具)
## 1. 建立Migration專案<br>
<img src="Img/018.jpg" width="300">

## 2. Nuget加入dbup(強烈建議用3.3.2版本，不然會有編碼問題),dbup-consolescripts參考<br>
<img src="Img/019.jpg" width="300">

## 3. 透過套件管理工具建立Migration腳本<br>
<img src="Img/020.jpg" width="300">

## 4. 撰寫Migration腳本<br>
<img src="Img/021.jpg" width="300">

## 5. 執行結果<br>
<img src="Img/022.jpg" width="300">

## 5. 庫裡會多一張SchemaVersions表紀錄每個Migration更新時間<br>
<img src="Img/023.jpg" width="300">