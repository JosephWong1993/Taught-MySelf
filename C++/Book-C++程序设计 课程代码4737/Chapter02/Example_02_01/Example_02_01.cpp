#include<iostream>;
using namespace std;

struct Point{
	void Setxy(double a,double b){
		x=a;y=b;
	}
	void Display(){
		cout<<x<<"\t"<<y<<endl;
	}
	double x,y;
};

void main(){
	Point a;
	a.Setxy(10.6,18.5);
	a.Display();
	cout<<a.x<<"\t"<<a.y<<endl;
}