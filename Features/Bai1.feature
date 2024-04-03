Feature: Bài 1

@DataSource:../data/data_Bai1.csv
Scenario Outline: Chia 2 số nguyên
	Given Số bị chia = <number1>
	And Số chia = <number2>
	Then Giá trị trả về <result>