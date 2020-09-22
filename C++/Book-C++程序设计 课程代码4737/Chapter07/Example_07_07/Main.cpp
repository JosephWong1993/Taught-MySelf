/* 演示向量使用实数类型的例子 */
#include<iostream>
#include<algorithm>
#include<functional>
#include<vector>
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 };
	vector<double> va(a, a + 4), vb(4);											//定义实数向量va
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));			//正向输出va
	cout << endl;
	reverse_copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));	//逆向输出va
	cout << endl;
	reverse_copy(va.begin(), va.end(), vb.begin());								//va逆向复制给vb
	copy(vb.begin(), vb.end(), ostream_iterator<double>(cout, " "));			//正向输出vb
	cout << endl;
	sort(va.begin(), va.end());													//va升幂排序
	sort(vb.begin(), vb.end(), greater<double>());								//vb降幂排序
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));			//正向输出va
	cout << endl;
	copy(vb.begin(), vb.end(), ostream_iterator<double>(cout, " "));			//正向输出vb
	cout << endl;
	cout << *find(va.begin(), va.end(), 4.4);									//在va中查找4.4
}