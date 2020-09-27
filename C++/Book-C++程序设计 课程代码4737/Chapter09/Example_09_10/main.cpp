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
istream& operator>>(istream& is, list& ob)	//���ء�>>�������
{
	is >> ob.name;
	is >> ob.salary;
	return is;
}
ostream& operator<<(ostream& os, list& ob)	//���ء�<<�������
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
		cout << "û����ȷ�����ļ��������������У�" << endl;
		return;
	}
	for (int i = 0; i < 2; i++)
	{
		out << worker1[i];			//��worker[i]��Ϊ����Դ�
	}
	out.close();
	ifstream in("pay.txt", ios::binary);
	if (!in)
	{
		cout << "û����ȷ�����ļ��������������У�" << endl;
		return;
	}
	for (int i = 0; i < 2; i++)
	{
		in >> worker2[i];			//��worker2[i]�������
		cout << worker2[i] << endl;	//��worker2[i]�������
	}
	in.close();
}