#include"Pilota.h"
void main() {
	Pilota p("coso.txt");
	/*
	p.aggiugniPilota("mario", 10, 40);
	p.aggiugniPilota("peppino", 33, 100);
	p.aggiugniPilota("Dovizioso", 777, 11);
	*/
	cout << p.leggiEVisualizzaFile() << endl;
	cout << p.cercaPunteggioPerNome("dovizioso") << endl;
}