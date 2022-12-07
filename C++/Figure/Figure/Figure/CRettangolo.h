#pragma once
class CRettangolo
{
private:
	int b, a; //lato piccolo, lato grosso
public:
	CRettangolo();
	void setlati(int, int);
	int getB();
	int getA();
	int calcolaArea();
	int calcolaPerimetro();
	int calcolaDiagonale();
};

