#pragma once
#include<iostream>
#include<string>
#include <fstream>
using namespace std;
class CClasse
{
private:
	string nome, cognome;
	int numeroRegistro;
public:
	CClasse();
	CClasse(string, string, int);
	string getNome();
	string getCognome();
	int getNumeroRegistro();
};

