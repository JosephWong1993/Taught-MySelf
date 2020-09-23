#include<iostream>
#include<vector>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);								//不复制字符串数组的结束标志\0
	int j;
	for (j = 0; j < 10; j++) {									//输出向量内容a b c d e f g h i j
		cout << a[j] << " ";
	}
	cout << endl << a.capacity() << "," << a.size() << endl;	//用完a的容量，capacity等于size
	a.pop_back();												//删除元素 j ，size变为9
	a.push_back('W'); a.push_back('P');							//在尾部增加元素 W 和 P,size变为 11
	for (j = 0; j < a.size(); j++)								//输出现在内容 a b c d e f g h i W P
	{
		cout << a[j] << " ";
	}
	cout << endl << a.capacity() << "," << a.size() << ",";		//size由10变为11,capacity由10变为20（在VS2019中变为15）
	a.clear();													//删除a的所有元素
	cout << a.empty() << endl;									//a内没有元素，输出1
}