#pragma once
#include<iostream>
#include<string>
using namespace std;
class CConto
{
private:
	string nome, cognome, iban;
	int operazioniSvolte;
	float saldo;
public:
	CConto();
	CConto(string, string, string, int, float);
	void deposita(int);
	float preleva(int);
	int calcolaInteressi();
	string toString();
	int bonifico(int,string);
};

