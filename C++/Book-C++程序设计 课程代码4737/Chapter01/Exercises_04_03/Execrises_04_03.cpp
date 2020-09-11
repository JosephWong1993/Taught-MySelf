#include<iostream>
using namespace std;

void main()
{
	float* ary = new float[15];
	float sum = 0;
	float minValue;
	for (size_t i = 0; i < 15; i++)
	{
		cin >> *(ary + i);
		float cur = *(ary + i);
		sum += cur;
		if (i == 0)
		{
			minValue = cur;
		}
		else
		{
			minValue = minValue < cur ? minValue : cur;
		}
	}
	cout << sum << endl;
	cout << minValue << endl;
}