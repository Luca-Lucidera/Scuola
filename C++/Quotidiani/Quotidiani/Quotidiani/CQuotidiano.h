#pragma once
#include<iostream>
#include<string>
using namespace std;
class CQuotidiano
{
private:
	string nome,nomeFile;
	int giorno, mese, anno;
	bool allegato;
public:
	CQuotidiano();
	CQuotidiano(string, int, int,int, string,bool);
	string getNome();
	int getGiorno();
	int getMese();
	int getAnno();
	string getNomeFile();
	bool getAllegato();
	string visTutto();
};

