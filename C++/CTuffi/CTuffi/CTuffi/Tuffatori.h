#pragma once
#include<iostream>
#include<string>
using namespace std;
#define maxel 7
class Tuffatori
{
private:
	int v[maxel];
	int pos;
public:
	Tuffatori();
	bool carica(int);
	int votoGiudice(int);
	int giudiceBuono();
	int giudiceCattivo();
	int punteggio();
	int giudicePiuBuono(Tuffatori);
	int giudicePiuCattivo(Tuffatori);
	int tuffatoreVincente(Tuffatori);
	int votoPiuAlto();
	int votoPiuBasso();
	string visTutto();
};

