#include<iostream>
#include<iomanip>
using namespace std;
const double PI = 3.141592;
void main() {
	cout << PI << endl
		<< setprecision(0) << PI << endl
		<< setprecision(1) << PI << endl
		<< setprecision(2) << PI << endl
		<< setprecision(3) << PI << endl
		<< setprecision(7) << PI << endl;
	int b = 100;
	cout << "Dec:" << dec << b << endl
		<< "Hex:" << hex << b << endl
		<< "Oct:" << oct << b << endl;
	cout << b << endl
		<< 100 << endl
		<< "Input b = ";
	cin >> b;
	cout << b << endl;
	cout << dec << setiosflags(ios_base::showpos) << b << endl;
	cout << "Input b = ";
	cin >> b;
	cout << b << endl;
	cout << resetiosflags(ios_base::showpos);
	cout << b << endl;
}