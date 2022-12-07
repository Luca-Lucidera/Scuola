#include "CRettangolo.h"
#include<math.h>
CRettangolo::CRettangolo()
{
	b = 0;
	a = 0;
}

void CRettangolo::setlati(int x, int y)
{
	b = x;
	a = y;
}

int CRettangolo::getB()
{
	return b;
}

int CRettangolo::getA()
{
	return a;
}

int CRettangolo::calcolaArea()
{
	return b*a;
}

int CRettangolo::calcolaPerimetro()
{
	return (b+a)*2;
}

int CRettangolo::calcolaDiagonale()
{
	return sqrt((b*b)+(a*a));
}
