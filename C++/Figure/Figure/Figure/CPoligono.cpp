#include "CPoligono.h"

CPoligono::CPoligono()
{
	l = 0;
	nl = 0;
	a = 0;
}

void CPoligono::setTutto(int x , int z)
{
	l = x;
	nl = z;
}

int CPoligono::getLato()
{
	return l;
}

int CPoligono::getNlati()
{
	return nl;
}

int CPoligono::calcolaArea()
{
	float a = 0, a2 = 0;
	if (nl == 3)
	{
		a2 = l * 0.289;

	}
	if (nl == 4)
	{
		a2 = l * 0.5;

	}
	if (nl == 5)
	{
		a2 = l * 0.688;

	}
	if (nl == 6)
	{
		a2 = l * 1.038;

	}
	if (nl	 == 7)
	{
		a2 = l * 1.207;

	}	
	return a = (calcolaPerimetro() * a2) / 2;;
}

int CPoligono::calcolaPerimetro()
{
	float p = l * nl;
	return p;
}
