/* 演示将美国格式的日期转换为国际格式的例子 */
#include<iostream>
#include<string>
using namespace std;
void main()
{
	cout << "Enter the date in American format"
		<< "(e.g., December 25, 2002): ";
	string Date;
	getline(cin, Date, '\n');
	int i = Date.find(" ");
	string Month = Date.substr(0, i);
	int k = Date.find(",");
	string Day = Date.substr(i + 1, k - i - 1);
	string Year = Date.substr(k + 2, 4);
	string NewDate = Day + " " + Month + " " + Year;
	cout << "Original date: " << Date << endl;
	cout << "Converted date: " << NewDate << endl;
}