#include"CAtleti.h"
void main() {
	CAtleta a1("pippo", "ma io che cazzo ne so scusi", 3.22);
	CAtleta a2("coso", "immagiland", 4.22);
	CAtleta a3("pippo", "tedeschia", 1.22);
	CAtleti g1;
	g1.setAtleta(a1);
	g1.setAtleta(a2);
	g1.setAtleta(a3);
	cout << g1.megaVisTutto() << endl;
	cout << endl;
	cout << g1.ordinaPerTempo() << endl;
	cout << endl;
	cout << g1.visAtletaSpecifico(3);
}