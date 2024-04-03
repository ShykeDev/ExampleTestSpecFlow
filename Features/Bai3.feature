Feature: Bài 3

@DataSource:../data/data_Bai3.csv
Scenario: Xếp loại học sinh
	Given Điểm học sinh: <Diem>
	Then Xếp loại: <XepLoai>
