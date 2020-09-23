/* 演示使用泛型指针进行插入和删除实例 */
#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);									//不复制标识位“\0”
	vector<char>::iterator p;										//定义泛型指针p
	p = a.begin();													//p指向第1个元素的地址
	a.insert(p + 3, 'X');											//a[3]='X'
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//输出向量 a 的内容
	cout << endl;
	p = a.begin();													//p返回首位值
	a.insert(p, 3, 'A');											//在a[0]前插入3个A
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//输出增加 A A A 后的内容
	cout << endl;
	p = a.begin();
	a.erase(p + 8);													//删除a[8]，即第9个元素e
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//输出删除e之后的内容
	cout << endl;
}