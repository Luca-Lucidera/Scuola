/*
Scrivere un programma che chieda in input N numeri interi (con N definito dall'utente) e li memorizzi in un vettore.
Calcolare la somma dei numeri interi inseriti usando unicamente l'aritmetica dei puntatori (non si deve accedere al vettore con v[i]).
Stampare in output il valore della somma degli elementi del vettore.
*/
#include<iostream>
#define maxel 10
using namespace std;
void main() {
	int n;
	int* p;
	int v[maxel]{0,0,0,0,0,0,0,0,0,0};
	do
	{
		cout << "Quanti numeri vuoi inserire?" << endl;
		cin >> n;
		if (n < 1 || n > 10)
			cout << "metti un numero da 1 a 10" << endl;
	} while (n < 1 || n > 10);
	
	//ciclo per fa inseirire in numeri
	
	for (int i = 0; i < n; i++)
	{
		cin >> v[i];
	}
	
	p = &(v[0]);	//punto la variabile p all'inidirizzo della memoria del vettore
	int x=0;		//variabile a per la somma
	cout << "----------" << endl;
	for (int i = 0; i < n; i++)
	{
		x+=*(p + i); //la varibile x è uguale al contenuto di p della cella a cui puntava aumentato dalla variabile i ( non uso + 1 questo perchè  non viene salvato quando l'aumeto )
	}
	cout << x << endl;
}