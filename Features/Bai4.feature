Feature: Bài 4
//string id, string ten, string tenCaSi, int doDai, string tenNhacSi
@DataSource:../data/data_Bai4.csv
Scenario: Thêm bài hát
	Given Thêm dữ liệu bài hát:
	| id   | ten   | tenCaSi     | doDai   | tenNhacSi   |
	| <id> | <ten> | <tenCaSi>	 | <doDai> | <tenNhacSi> |
	Then Kết quả mong muốn: <ketQua>

Scenario: Xóa bài hát, có tồn tại id
	Given Xóa bài hát có id: BH001
	Then Kết quả xóa muốn: Thành công

Scenario: Xóa bài hát, id không tồn tại
	Given Xóa bài hát có id: BH002
	Then Kết quả xóa muốn: Thất bại

Scenario: Xóa bài hát ID ký tự đặc biệt
	Given Xóa bài hát có id: @@@
	Then Kết quả xóa muốn: Thất bại

Scenario: Xóa 2 lần
	Given Xóa bài hát có id: BH001
	Then Kết quả xóa muốn: Thành công
	Then Kết quả xóa muốn: Thất bại

Scenario: Xóa khi id là null
	Then Kết quả xóa muốn: Thất bại