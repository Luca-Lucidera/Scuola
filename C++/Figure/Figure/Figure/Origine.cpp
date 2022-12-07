//lo so che non faccio parte del recupero, però avevo voglia di farlo lo stesso
#include"CCerchio.h"
#include"CPoligono.h"
#include"CQuadrato.h"
#include"CRettangolo.h"
//cerchio
int sceltaC(int r,int x) {
	CCerchio c1;
	c1.setRaggio(r);
	if (x == 1)
	{
		return c1.calcolaArea();
	}
	else
	{
		return c1.calcolaPerimetro();
	}
}
//quadrato
int sceltaQ(int l,int x) {
	CQuadrato q1;
	q1.setLato(l);
	if (x == 1)
	{
		return q1.calcolaPerimetro();
	}
	else if (x == 2) 
	{
		return q1.calcolaArea();
	}
	else if (x == 3)
	{
		return q1.calcolaDiagonale();
	}
}
//rettangolo
int sceltaR(int c,int e,int x) {
	CRettangolo c1;
	c1.setlati(c, e);//base, altezza
	if (x == 1)
	{
		return c1.calcolaPerimetro();
	}
	else if (x == 2)
	{
		return c1.calcolaArea();
	}
	else if (x == 3)
	{
		return c1.calcolaDiagonale();
	}
}
//poligono
int sceltaP(int x, int z,int h) {
	
	CPoligono p1;
	p1.setTutto(x, z);
	if (x == 1)
	{
		return p1.calcolaPerimetro();
	}
	else
	{
		return p1.calcolaArea();
	}
}

int main() {
	int fine = false;
	do
	{
		int scelta = 0;
		int scelta2 = 0;
		cout << "scegli la figura" << endl;
		cout << "1. cerchio " << endl;
		cout << "2. quadrato" << endl;
		cout << "3. rettangolo" << endl;
		cout << "4. poligono" << endl;
		cin >> scelta;
		if (scelta == 1) //scegli cerchio
		{
			int raggio;
			cout << "inserire il raggio" << endl;
			do
			{
				cin >> raggio;
			} while (raggio <= 0);
			cout << "cosa vuoi calcolare?" << endl;
			cout << "1. perimetro" << endl;
			cout << "2. area" << endl;
			do
			{
				cin >> scelta2;
			} while (scelta2 <= 0 || scelta2 >= 3);
			cout << sceltaC(raggio, scelta2);
			
		}
		else if (scelta == 2) //scegli quadrato
		{
			int lato;
			cout << "inserire il lato (> 0)" << endl;
			do {
				cin >> lato;
			} while (lato <= 0);
			cout << "cosa vuoi calcolare?" << endl;
			cout << "1. perimetro" << endl;
			cout << "2. area" << endl;
			cout << "3. diagonale" << endl;
			do {
				cin >> scelta2;
			} while (scelta2 <= 0 || scelta2 >=4);
			cout << sceltaQ(lato,scelta2) << endl;
		}
		else if (scelta == 3)
		{
			int b=0, a=0;
			do {
				cout << "inserire base" << endl;
				cin >> b;
				cout << "inserire altezza" << endl;
				cin >> a;
			} while (b <= 0 || a <= 0);
			cout << "cosa vuoi calcolare?" << endl;
			cout << "1. perimetro" << endl;
			cout << "2. area" << endl;
			cout << "3. diagonale" << endl;
			do {
				cin >> scelta2;
			} while (scelta2 <= 0 || scelta2 >= 4);
			cout << sceltaR(b, a, scelta2) << endl;

		}
		else 
		{
			int nl,l;
			cout << "quanti lati ha il poligono?" << endl;
			do
			{
				cin >> nl;
			} while (nl<=2 || nl>=8);
			cout << "inserire misura del lato" << endl;
			cin >> l;
			cout << "cosa vuoi calcolare?" << endl;
			cout << "1. perimetro" << endl;
			cout << "2. area" << endl;
			do {
				cin >> scelta2;
			} while (scelta2 <= 0 || scelta2 >= 4);
			cout << sceltaR(l, nl, scelta2) << endl;
		}
		cout << "altre operazioni? (0 si | 1 no)" << endl;
		cin >> fine;

	} while (fine == false);
	
	system("pause");
	return 0;

	
}