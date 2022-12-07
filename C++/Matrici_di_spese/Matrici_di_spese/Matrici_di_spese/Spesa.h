#pragma once
#include<iostream>
#include<string>
using namespace std;
#define X 3  //valore della spesa
#define Y 24 //ore del giorno
class Spesa
{
private:
	int spese[Y][X];
	int posY;
	int posX;
public:
	Spesa();
	void aggiungiSpesa(int spesa);
	string visualizza();
	int getSpesa(int y,int x);
};

