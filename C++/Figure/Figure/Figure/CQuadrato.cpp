#include "CQuadrato.h"
#include<math.h>
CQuadrato::CQuadrato()
{
	l = 0;
}

void CQuadrato::setLato(int x)
{
	l = x;
}

int CQuadrato::getLato()
{
	return l;
}

int CQuadrato::calcolaArea()
{
	return l*l;
}

int CQuadrato::calcolaPerimetro()
{
	return l*4;
}

int CQuadrato::calcolaDiagonale()
{
	return l*sqrt(2);
}
