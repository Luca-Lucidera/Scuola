#include "CPagella.h"

CPagella::CPagella()
{
	for (int i = 0; i < maxel; i++)
	{
		v[i] = 0;
	}
	pos = 0;
}

void CPagella::setVoto(int x)
{
	if (pos < maxel)
	{
		v[pos] = x;
		pos++;
	}
	
}

int CPagella::getVoto(int x)
{
	if (x <= 0 || x >= 6)
		return NULL;
	return v[x-1];
}

float CPagella::mediaVoti()
{
	float tmp=0;
	for (int i = 0; i < pos; i++)
	{
		tmp += v[i];
	}
	return tmp /= pos;
}

string CPagella::risultato()
{
	int c=0;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] < 6)
			c++;
		if (c == 3)
			return "Boccciato!";
	}
	if (c >= 1)
		return "Rimandato!";
	return "Promosso!";
}

int CPagella::NumVotiSupMedia()
{
	int tmp=0;
	int tmp2 = mediaVoti();
	for (int i = 0; i < pos; i++)
	{
		if (v[i] >= tmp2)
			tmp++;
	}
	return tmp;
}

string CPagella::StampaPagella()
{
	string tmp = "";
	for (int i = 0; i < pos; i++)
	{
		tmp += to_string(v[i]) + " ";
	}
	return tmp;
}
