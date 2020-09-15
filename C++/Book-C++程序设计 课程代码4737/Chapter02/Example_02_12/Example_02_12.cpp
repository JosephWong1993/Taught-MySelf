/* 演示string对象使用成员函数表示存储区间的例子. */
#include<iostream>
#include<string>
#include<algorithm>
#include<functional>
using namespace std;
void main() {
	string str1 = "wearehere!", str2(str1);									//使用str1初始化str2
	reverse(str1.begin(), str1.end());										//字符串元素逆向
	cout << str1 << endl;
	copy(str1.begin(), str1.end(), str2.begin());							//原样复制到str2,str2应能容下str1
	sort(str1.begin(), str1.end());											//默认升幂排序
	cout << str1 << endl;													//输出排序结果
	cout << str2 << endl;													//输出字符串str2的内容
	reverse_copy(str1.begin(), str1.end(), str2.begin());					//逆向复制到字符串str2
	cout << str2 << endl;													//输出逆向后的str2的内容

	reverse(str2.begin() + 2, str2.begin() + 8);							//字符串str2部分逆向
	copy(str2.begin() + 2, str2.begin() + 8, ostream_iterator<char>(cout));	//输出逆向后的部分内容
	cout << endl;

	sort(str1.begin(), str1.end(), greater<char>());						//降幂排序
	cout << str1 << endl;													//输出排序后的字串str1
	str1.swap(str2);														//互相交换内容
	cout << str1 << " " << str2 << endl;
	cout << (*find(str1.begin(), str1.end() - 1, 'e') == 'e') << " "			//注意不是成员函数find
		<< (*find(str1.begin(), str1.end() - 1, 'O') == 'O') << endl;
}