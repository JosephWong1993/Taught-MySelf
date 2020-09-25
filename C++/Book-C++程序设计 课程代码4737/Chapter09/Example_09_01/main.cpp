#include "str.h"
#include<string>
void main() {
	str s1("we"), s2("They"), s3(s1);
	s1.print();
	s2.print();
	s3.print();
	s2=s1=s3;
	s3="Go home!";
	s3=s3;
	s1.print();
	s2.print();
	s3.print();
}