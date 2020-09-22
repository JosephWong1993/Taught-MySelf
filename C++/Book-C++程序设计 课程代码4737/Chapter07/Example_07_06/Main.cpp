/* 演示泛型指针和copy函数的例子例子 */
#include<iostream>
#include<algorithm>
#include<vector>
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 };
	vector<double> va(a, a + 4), vb(4);									//定义并初始化向量va
	typedef vector<double>::iterator iterator;							//自定义一个正向泛型指针标识符iterator
	iterator first = va.begin();										//定义正向泛型指针first并指向va的首元素
	for (first; first < va.end(); first++)								//循环正向输出va
	{
		cout << *first << " ";
	}
	for (--first; first > va.begin(); first--) {						//循环逆向输出va
		cout << *first << " ";
	}
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));	//整体正向输出va
	cout << endl;
	typedef vector<double>::reverse_iterator reverse_iterator;			//自定义一个逆向泛型指针标识符
	reverse_iterator last = va.rbegin();								//定义逆向泛型指针last并指向va的尾元素
	for (last; last < va.rend(); last++) {								//使用逆向指针循环从尾到首输出va
		cout << *last << " ";
	}
	for (--last; last > va.rbegin(); last--) {							//使用逆向指针循环从首到位输出va
		cout << *last << " ";
	}
	copy(va.rbegin(), va.rend(), ostream_iterator<double>(cout, " "));	//整体从尾到首输出va
}