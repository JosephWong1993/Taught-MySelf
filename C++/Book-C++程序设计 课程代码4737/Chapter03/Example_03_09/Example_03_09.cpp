#include<iostream>
using namespace std;
float* input(int&);						//声明返回指针的函数
void main() {
	int num;
	float* data;						//声明与input类型一致的指针
	data = input(num);					//调用函数，返回指针给data
	if (data) {							//data不空，输出所指内容
		for (int i = 0; i < num; i++) {	//使用指针的下标形式
			cout << data[i] << " ";		//循环输出
		}
		delete data;					//释放内存空间+
	}
}
float* input(int& n) {					//定义返回指针的函数
	cout << "Input number:";			//询问输入数据数量
	cin >> n;
	if (n < 0) return NULL;				//输入个数不合理则退出
	float* buf = new float[n];			//根据输入数量申请空间
	if (buf == 0) return NULL;			//没申请到则退出
	for (int i = 0; i < n; i++)			//接受输入数据
	{
		cin >> buf[i];
	}
	return buf;							//返回指针
}