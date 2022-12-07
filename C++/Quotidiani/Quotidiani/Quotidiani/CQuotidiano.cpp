#include "CQuotidiano.h"

CQuotidiano::CQuotidiano()
{
	nome = "";
	giorno = 00;
	mese = 00;
	anno = 00;
	nomeFile = ".pdf";
	allegato = false;
}

CQuotidiano::CQuotidiano(string n, int g, int m, int an, string nF, bool a)
{
	if ((n != "") && (g >= 1 && g <= 31)&& (nF.find(".pdf", 0) != -1) && (m >= 1 && m<=12)&& (nF.find(" ",0)==-1)) {
		nome = n;
		giorno = g;
		mese = m;
		anno = an;
		nomeFile = nF;
		allegato = a;
	}
}

string CQuotidiano::getNome()
{
	return nome;
}

int CQuotidiano::getGiorno()
{
	return giorno;
}

int CQuotidiano::getMese()
{
	return mese;
}

int CQuotidiano::getAnno()
{
	return anno;
}

string CQuotidiano::getNomeFile()
{
	return nomeFile;
}

bool CQuotidiano::getAllegato()
{
	return allegato;
}

string CQuotidiano::visTutto()
{
	string tmp = nome + " " + to_string(giorno) + "/" + to_string(mese) + "/" + to_string(anno) + " " + nomeFile+ " "+  to_string(allegato) +"\n";
	return tmp;
}
