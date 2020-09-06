//演示使用 new 和 delete 的例子。
#include<iostream>
using namespace std;
void main() {
	double* p;						//声明double型指针
	p = new double[3];				//分配3个double型数据的存储空间
	for (int i = 0; i < 3; i++)		//定义对象i的初值为0
		cin >> *(p + i);			//将输入数据存入指定地址
	for (int i = 0; i < 3; i++)
		cout << *(p + i) << endl;	//将地址里的内容输出
	delete p;
}