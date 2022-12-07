#include "CCerchio.h"

CCerchio::CCerchio()
{
	raggio = 0;
}

void CCerchio::setRaggio(int x)
{
	raggio = x;
}

int CCerchio::getRaggio()
{
	return raggio;
}

int CCerchio::calcolaPerimetro()
{
	int r = pigreco * 2 * raggio;
	return r;
}

int CCerchio::calcolaArea()
{
	int r = pigreco * (2 * raggio / 2);
	return r;
}
