#include<iostream>
#include<fstream>
using namespace std;
struct list
{
	double salary;
	char name[20];
	friend ostream& operator<<(ostream& os, list& ob);
	friend istream& operator>>(istream& is, list& ob);
};
istream& operator>>(istream& is, list& ob)	//重载“>>”运算符
{
	is >> ob.name;
	is >> ob.salary;
	return is;
}
ostream& operator<<(ostream& os, list& ob)	//重载“<<”运算符
{
	os << ob.name << ' ';
	os << ob.salary << ' ';
	return os;
}
void main()
{
	list worker1[2] = {
		{1256,"LiMing"},
		{3467,"ZhangHong"}
	};
	list worker2[2];
	ofstream out("pay.txt", ios::binary);
	if (!out)
	{
		cout << "没有正确建立文件，结束程序运行！" << endl;
		return;
	}
	for (int i = 0; i < 2; i++)
	{
		out << worker1[i];			//将worker[i]作为整体对待
	}
	out.close();
	ifstream in("pay.txt", ios::binary);
	if (!in)
	{
		cout << "没有正确建立文件，结束程序运行！" << endl;
		return;
	}
	for (int i = 0; i < 2; i++)
	{
		in >> worker2[i];			//将worker2[i]整体读入
		cout << worker2[i] << endl;	//将worker2[i]整体输出
	}
	in.close();
}