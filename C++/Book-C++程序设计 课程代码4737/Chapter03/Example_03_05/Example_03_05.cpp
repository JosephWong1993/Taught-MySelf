/* 求10个学生成绩的平均值，并统计其中不及格的人数。要求用一个函数实现，并返回这两个数据给调用函数，并且函数的形参使用引用来实现 */
#include<iostream>
using namespace std;
typedef double _array[12];			//自定义数组标识符array
void avecount(_array& b, int n) {	//一个参数使用引用，一个参数使用对象
	double ave(0);
	int count(0);					//累加器初始化0
	for (int j = 0; j < n - 2; j++)
	{
		ave = ave + b[j];
		if (b[j] < 60) {
			count++;
		}
	}
	b[n - 2] = ave / (n - 2);		//填入平均成绩
	b[n - 1] = count;				//填入不及格人数
}
void main() {
	_array b = { 12,34,56,78,90,98,76,85,64,43 };
	_array& a = b;					//间接引用数组
	avecount(a, 12);				//调用函数计算统计
	cout << "平均成绩为" << a[10] << "分，不及格人数有" << int(a[11]) << "人。" << endl;
}