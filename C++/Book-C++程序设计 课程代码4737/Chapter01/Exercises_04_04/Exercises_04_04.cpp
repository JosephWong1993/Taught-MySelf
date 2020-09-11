#include<iostream>
#include<algorithm>
#include<functional>
using namespace std;
void main() {
	int a[] = { 1,2,3,4,5,6,7,8 };
	int* x = find(a, a + 8, 4);
	if (x == a + 8)
	{
		cout << "没有找到";
	}
	else
	{
		cout << x;
	}
	cout << endl;
	int b[8];
	copy(a, a + 8, b);
	reverse(a, a + 8);
	x = find(a, a + 8, 4);
	if (x == a + 8)
	{
		cout << "没有找到";
	}
	else
	{
		cout << x;
	}
	cout << endl;
	for (size_t i = 0; i < 8; i++)
	{
		cout << *(a + i);
	}
	cout << endl;
	for (size_t i = 0; i < 8; i++)
	{
		cout << *(b + i);
	}
	cout << endl;
}