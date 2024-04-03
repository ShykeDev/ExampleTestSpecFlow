Feature: Bài 4
//string id, string ten, string tenCaSi, int doDai, string tenNhacSi
@DataSource:../data/data_Bai4.csv
Scenario: Thêm bài hát
	Given Thêm dữ liệu bài hát:
	| id   | ten   | tenCaSi     | doDai   | tenNhacSi   |
	| <id> | <ten> | <tenCaSi>	 | <doDai> | <tenNhacSi> |
	Then Kết quả mong muốn: <ketQua>
