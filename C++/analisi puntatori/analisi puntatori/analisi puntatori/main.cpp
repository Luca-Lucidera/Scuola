#include<iostream>
using namespace std;
void main() {
	int* p1, a;
	p1 = &a;
	a = 5;
	//cout << *p1++ << endl; //visualizzo il contenuto di p1, ma dopo vado ad aumentare la cella di memoria di 1;

	cout << (*p1)++ << endl; //vado ad aumentare sia il valore di p1 che il valore di  a

	cout << *(p1++) << endl; //auemnto solo il valore di p
	system("PAUSE");
}