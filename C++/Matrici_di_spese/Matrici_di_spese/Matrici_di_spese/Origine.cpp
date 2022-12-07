#include<iostream>
#include"Spesa.h"
#include"CFile.h"
using namespace std;
void main() {
	Spesa s;
	CFile f;
	int c = 0;
	for (int y = 0; y < Y; y++) //
	{
		for (int x = 0; x < X; x++)
		{
			s.aggiungiSpesa(c);
			c++;
		}
		c = 0;
	}
	cout << s.visualizza();
	f.aggiungiTutteLeSpese(s);
}
/*
	COME FUNZIONA UNA MATRICE
				Y  X
	int matrice[5][10];
	int c = 0;
	for (int y = 0; y < 5; y++) //asse X
	{
		for (int x = 0; x < 10; x++) //asse Y
		{
			matrice[y][x] = c;
		}
		c++;
	}

	for (int y = 0; y < 5; y++)
	{
		for (int x = 0; x < 10; x++)
		{
			cout << matrice[y][x];
		}
		cout << endl;
	}
	*/