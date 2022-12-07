#include<iostream>
using namespace std;
void main() {
	int v1,v2;
	int* v3, *v4;
	v1 = 10;
	v2 = 20;
	v3 = &v1;
	v4 = &v2;
	cout << &v1 << endl; //indirizzo
	cout << &v2 << endl; //indirizzo
	cout << v1 << endl; //cont
	cout << v2 << endl;//cont
	cout << v3 << endl;//indirizzo
	cout << v4 << endl;//indirizzo
	cout << *v3 << endl;//cont
	cout << *v4 << endl;//cont
	char v5 = 1;
	long v6 = 1;
	double v7 = 1;
	cout << "Dimensione char " << sizeof(v5) << endl;//vedo dimensione in byte di un char
	cout << "Dimensione long " << sizeof(v6) << endl;//vedo dimensione in byte di un long
	cout << "Dimensione double " << sizeof(v7) << endl;//vedo dimensione in byte di un double
}