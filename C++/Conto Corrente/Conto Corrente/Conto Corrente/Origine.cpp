#include"CConto.h"
using namespace std;
int main() {
	CConto c1("Mario","Rossi","IT46U0300203280456464191474", 18,200);//nome,cognome,iban,cosi svolti,saldo
	c1.deposita(800);
	c1.preleva(200);
	cout << c1.calcolaInteressi() << endl;
	cout << c1.toString() << endl; //non so cosa ho sbagliato ma mi esce 824
	c1.bonifico(93,"IT80D0300203280581341694758");
	return 0;
}