#include "CConto.h"

CConto::CConto()
{
	nome = "";
	cognome = "";
	operazioniSvolte = 0;
	saldo = 0;
}

CConto::CConto(string n, string c, string i, int o, float s)
{
	nome = n;
	cognome = c;
	iban = i;
	operazioniSvolte = o;
	saldo = s;
}

void CConto::deposita(int x)
{
	if (operazioniSvolte >= 20) {
		saldo += x - 2;
		operazioniSvolte++;
	}
	else {
		saldo += x;
		operazioniSvolte++;
	}
}

float CConto::preleva(int x)
{
	if (operazioniSvolte >= 20) { saldo -= x - 2; operazioniSvolte++; }
	else { saldo -= x; operazioniSvolte++; };
	return saldo;
}

int CConto::calcolaInteressi()
{
	operazioniSvolte = 0;
	if (saldo >= 500){
		saldo+=(saldo * 3) / 100;
	}else if (saldo >= 50){
		saldo += (saldo * 2) / 100;
	}
	return saldo;
}

string CConto::toString()
{
	string tmp = "Nome -> " + nome + " Cognome -> " + cognome + " Iban -> " + iban + " Operazioni svolte -> " + to_string(operazioniSvolte) + " Saldo -> " + to_string(saldo);
	return tmp;
}

int CConto::bonifico(int s, string i)
{
	saldo -= s;
	return saldo;
}
