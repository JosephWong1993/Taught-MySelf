/* 演示访问向量容量信息及对象实例 */
#include<iostream>
#include<algorithm>
#include<functional>
#include<vector>
using namespace std;
void main() {
	vector<char> a(10), b(10);														//产生向量a,元素内容均为0
	cout << a.empty() << "," << sizeof(a) << ",";									//内容不空时输出0,sizeof(a)为16
	char j;
	for (char i = 'a', j = 0; j < 10; j++)											//改变内容为：abcdefghij
	{
		a[j] = i + j;
	}
	cout << a.max_size() << "," << a.capacity() << "," << a.size() << endl;			//比较三种容量大小
	for (j = 0; j < 10; j++)														//输出向量内容
	{
		cout << a[j] << " ";
	}
	cout << endl;
	copy(a.begin(), a.end(), b.begin());											//复制a向量的内容到b
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));					//输出向量a的内容
	cout << endl;
	reverse_copy(b.begin(), b.end(), ostream_iterator<char>(cout, " "));			//逆向输出b
	cout << endl << a.front() << "," << a.back() << "," << a.operator[](5) << endl;	//输出对象
	sort(b.begin(), b.end(), greater<char>());										//降幂排序
	copy(b.begin(), b.end(), ostream_iterator<char>(cout, " "));					//输出向量b的内容
}