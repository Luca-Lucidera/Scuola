#include "CQuotidiani.h"

CQuotidiani::CQuotidiani()
{
	pos = 0;
	for (int i = 0; i < maxel; i++)
	{
		v[i] = CQuotidiano();
	}
}

void CQuotidiani::mettiQuotidiano(CQuotidiano x)
{
	if (pos < maxel) {
		v[pos] = x;
		pos++;
	}
	
}

string CQuotidiani::cercaPerData(int g, int m, int a)
{
	for (int i = 0; i < pos; i++)
	{
		if (v[i].getGiorno() == g && v[i].getMese() == m && v[i].getAnno() == a)
			return v[i].visTutto();
	}
	return "Nessun quotidiano trovato";
}

string CQuotidiani::eliminaQuotidiano(int x)
{
	if (x > maxel || x <= 0)
		return "Quotidiano non trovato";
	v[x - 1] = CQuotidiano();
	for (int i = x-1; i < pos-1; i++)
	{
		v[i] = v[i + 1];
	}
	pos--;
	return "ELIMINATO";
}

void CQuotidiani::modificaQuotidiano(int posizione, string n, int g, int m, int an, string nF, bool a)
{
	if (posizione > maxel || posizione <= 0) {

	}
	else {
		v[posizione - 1] = CQuotidiano(n, g, m, a, nF, a);
	}
	
}

string CQuotidiani::megaVisTutto()
{
	string tmp = "";
	for (int i = 0; i < pos; i++)
	{
		tmp += v[i].visTutto() + "\n";
	}
	return tmp;
}
