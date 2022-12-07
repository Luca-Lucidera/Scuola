#include <iostream>
using namespace std;
void scambio(float *a, float*b) {
	float tmp; //scambio i contenuti e non devo ritornare niente
	tmp = *a;
	*a = *b;
	*b = tmp;
}
void main() {
	float X = 100.50;
	float Y = 200.75;
	int Z = 50;
	float* Punt1;
	float* Punt2;
	int* Punt3;
	Punt1 = &X;
	Punt2 = &Y;
	Punt3 = &Z;
	cout <<"cella memoria -> " <<Punt1 << endl;
	cout <<"contenuto -> " <<*Punt1 << endl;
	cout << "cella memoria + 1 -> " << Punt1 + 1 << endl;
	cout << "contenuto + 1 -> " << *Punt1 + 1 << endl;
	cout << "Prima scambio: Punt 1 -> " << *Punt1 << " Punt 2 -> " << *Punt2 << endl;
	scambio(Punt1, Punt2); //gli passo le indirizzi della memoria
	cout << "Dopo scambio: Punt 1 -> " << *Punt1 << " Punt 2 -> " << *Punt2 << endl;
	int v[5]{10,20,30,40,50};
	int* p;
	p = v;
	cout << "contenuto di p " << *p << endl;
	p = p + 2;
	cout << "contenuto di p spostato di 2 posizioni del vettore " << *p << endl;
	int bo;
	bo = *(p + 1); // bo è uguale al contenuto di p + 1 ovvero v[3]
	cout << "Contenuto di bo -> " << bo << endl;
	v[4] = *(p + 2) + 100; // p + 2 = 50 |
	cout << v[4] << endl;
}