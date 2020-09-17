/* 使用“引用形参”作为函数参数的例子 */
#include<iostream>
#include<string>
using namespace std;
void swap(string&, string&);			//使用string类的引用对象作为参数
void main() {
	string str1("现在"), str2("过去");	//定义对象str1和str2
	swap(str1, str2);					//传递对象的名字：str1和str2
	cout << "返回后：str1 = " << str1 << " str2 = " << str2 << endl;
}
void swap(string& s1, string& s2) {		//string类的引用对象s1和s2作为函数参数
	string temp = s1; s1 = s2; s2 = temp;
	cout << "交换为：str1 = " << s1 << " str2 = " << s2 << endl;
}