#pragma once
class CPoligono
{
private:
	int l,nl,a;//lato|nlati|apotema
public:
	CPoligono();
	void setTutto(int,int);
	int getLato();
	int getNlati();
	int calcolaArea();
	int calcolaPerimetro();
};

