/* 演示数组升幂排序、复制、逆向和输出等操作的例子。 */
#include<iostream>
#include<algorithm>	//头文件
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 }, b[4];
	copy(a, a + 4, ostream_iterator<double>(cout, " "));			//正向输出数组a，以空格隔开
	cout << endl;
	reverse_copy(a, a + 4, ostream_iterator<double>(cout, " "));	//逆向输出数组a，以空格隔开
	cout << endl;
	copy(a, a + 4, b);
	copy(b, b + 4, ostream_iterator<double>(cout, " "));
	cout << endl;
	sort(a, a + 4);													//对数组a进行升幂排序
	copy(a, a + 4, ostream_iterator<double>(cout, " "));			//输出数组a
	cout << endl;
	reverse_copy(a, a + 4, b);										//将a的内容按逆向复制给数组b
	copy(b, b + 4, ostream_iterator<double>(cout, " "));			//输出数组b
	cout << endl;
}