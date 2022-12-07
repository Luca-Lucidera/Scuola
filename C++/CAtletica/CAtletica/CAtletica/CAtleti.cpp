#include "CAtleti.h"

CAtleti::CAtleti()
{
	for (int i = 0; i < maxel; i++)
	{
		v[i] = CAtleta();
	}
	pos = 0;
}

void CAtleti::setAtleta(CAtleta x)
{
	v[pos] = x;
	pos++;
}

string CAtleti::visAtletaSpecifico(int x)
{
	if (x <= 0 || x > pos)
		return "Coso non trovato";
	return v[x - 1].visTutto();
}

string CAtleti::ordinaPerTempo()
{
	for (int i = 0; i < pos-1; i++)
	{
		for (int k = 0;  k < pos-1;  k++)
		{
			if (v[k].getTempo() > v[k + 1].getTempo())
				swap(v[k], v[k + 1]);
		}
	}
	return megaVisTutto();
}

string CAtleti::megaVisTutto()
{
	string tmp = "";
	for (int i = 0; i < pos; i++)
	{
		tmp += v[i].visTutto() + "\n";
	}
	return tmp;
}
