Feature: Bài 2

@DataSource:../data/data_Bai2.csv
Scenario: Test bài 2
	Given a = <number1>
	And b = <number2>
	When Phép tính <PhepTinh>
	Then Giá trị trả về phép tính <result>
