#include<iostream>
#include<string>
using namespace std;
template <typename f>
void  cambio(f& a, f& b) {
	f tmp;
	tmp = a;
	a = b;
	b = tmp;
}
void main() {
	int a = 10;
	int b = 30;
	cout << "a: " << a << endl;
	cout << "b: " << b << endl;
	cambio(a, b);
	cout << "a: " << a << endl;
	cout << "b: " << b << endl;

	double a_double = 40.40, b_double = 50.50;
	cout << "a_double: " << a_double << endl;
	cout << "b_double: " << b_double << endl;
	cambio(a_double,b_double);
	cout << "a_double: " << a_double << endl;
	cout << "b_double: " << b_double << endl;

}