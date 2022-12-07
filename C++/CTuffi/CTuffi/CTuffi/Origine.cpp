#include"Tuffatori.h"
int main() {
	Tuffatori t1; 
	t1.carica(7);
	t1.carica(6);
	t1.carica(5);
	t1.carica(10);
	t1.carica(6);
	t1.carica(7);
	t1.carica(6);
	cout << "i voti sono del tuffatore 1 sono -> " << t1.visTutto() << endl;
	cout << t1.votoGiudice(4) << endl; //inserisce il numero del giudice del voto (giudice 4 corrisponde al voto 10)
	cout << "Giudice piu' buono " << t1.giudiceBuono() << endl;
	cout <<"Giudice piu' cattivo " <<  t1.giudiceCattivo() << endl;
	cout << "Somma dei punteggi " << t1.punteggio() << endl;
	Tuffatori t2; 
	t2.carica(7);
	t2.carica(4);
	t2.carica(9);
	t2.carica(7);
	t2.carica(7);
	t2.carica(6);
	t2.carica(6);
	cout << "giudice piu' buono " << t1.giudicePiuBuono(t2) << endl;
	cout << "giudice piu' cattivo " << t1.giudicePiuCattivo(t2) << endl;
	cout << "Tuffatore vincente -> " << t1.tuffatoreVincente(t2) << endl;
	return 0;
}