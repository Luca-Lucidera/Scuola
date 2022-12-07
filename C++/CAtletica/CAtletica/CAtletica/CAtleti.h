#pragma once
#include"CAtleta.h"
#define maxel 5
class CAtleti
{
private:
	CAtleta v[maxel];
	int pos;
public:
	CAtleti();
	void setAtleta(CAtleta);
	string visAtletaSpecifico(int);
	string ordinaPerTempo();
	string megaVisTutto();
};

