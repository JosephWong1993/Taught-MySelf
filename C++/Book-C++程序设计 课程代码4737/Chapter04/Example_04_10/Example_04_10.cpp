/* 构造一个求4个正整数中最大值的类Max，并用主程序验证它的功能 */
#include<iostream>
using namespace std;

class Max {
private:
	int a, b, c, d;
	int Maxi(int, int);
public:
	void Set(int, int, int, int);
	int Maxi();
} A[3];
//类中成员函数的实现
int Max::Maxi(int x, int y) {	//求两个数的最大值
	return (x > y) ? x : y;
}
void Max::Set(int x1, int x2, int x3 = 0, int x4 = 0) {	//使用两个默认参数
	a = x1;
	b = x2;
	c = x3;
	d = x4;
}
int Max::Maxi() {
	int x = Maxi(a, b);
	int y = Maxi(c, d);
	return Maxi(x, y);
}

//主程序
void main() {
	A[0].Set(12, 45, 76, 89);	//为数组对象A[0]置初值
	A[1].Set(12, 45, 76);		//为数组对象A[1]置初值
	A[2].Set(12, 45);			//为数组对象A[2]置初值
	for (int i = 0; i < 3; i++)	//输出对象求值结果
	{
		cout << A[i].Maxi() << " ";
	}
}