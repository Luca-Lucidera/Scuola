#pragma once
class CQuadrato
{
private:
	int l;
public:
	CQuadrato();
	void setLato(int);
	int getLato();
	int calcolaArea();
	int calcolaPerimetro();
	int calcolaDiagonale();
};

