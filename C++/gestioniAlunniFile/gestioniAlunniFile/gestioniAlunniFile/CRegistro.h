#pragma once
#include"CClasse.h"
#define maxEl 10
class CRegistro
{
private:
	CClasse v[maxEl];
	int pos;
	fstream file;
public:
	CRegistro();
	void addAlunno(CClasse);
	void scriviIlFile();
	string leggiIlFile();
};

