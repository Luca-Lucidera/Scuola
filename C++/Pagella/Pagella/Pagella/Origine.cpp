#include"CPagella.h"
int main() {
	CPagella p1;
	p1.setVoto(6);
	p1.setVoto(7);
	p1.setVoto(8);
	p1.setVoto(4);
	cout << p1.StampaPagella() << endl;
	cout << p1.risultato() << endl;
	cout << " media -> " << p1.mediaVoti() << endl;
	cout << " numero voti superiore alla media -> " << p1.NumVotiSupMedia() << endl;
	cout << "Richiedo il primo voto inserito -> " << p1.getVoto(1) << endl;
}