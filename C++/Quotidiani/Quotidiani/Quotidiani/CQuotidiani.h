#pragma once
#include"CQuotidiano.h"
#define maxel 5
class CQuotidiani
{
private:
	CQuotidiano v[maxel];
	int pos;
public:
	CQuotidiani();
	void mettiQuotidiano(CQuotidiano);
	string cercaPerData(int,int,int);
	string eliminaQuotidiano(int); //chiedo quale quotidiano eliminare
	void modificaQuotidiano(int, string,int,int,int,string,bool);
	string megaVisTutto();
};

