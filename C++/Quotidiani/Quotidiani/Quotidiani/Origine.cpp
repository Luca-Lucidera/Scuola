#include"CQuotidiani.h"
void main() {
	CQuotidiano q1("pippo", 10, 11, 2000, "pippo.pdf", false);
	CQuotidiano q2("pluto", 20, 2, 2015, "pluto.pdf", true);
	CQuotidiano q3("idk", 7, 7, 777, "idk.pdf", true);
	CQuotidiani bo;
	bo.mettiQuotidiano(q1);
	bo.mettiQuotidiano(q2);
	bo.mettiQuotidiano(q3);
	cout << bo.megaVisTutto() << endl;
	cout << bo.eliminaQuotidiano(3) << endl;
	cout << bo.cercaPerData(20, 2, 2015) << endl;
	bo.modificaQuotidiano(2, "VedaLei", 7, 7, 777, "dark.pdf", true);
	cout << bo.megaVisTutto() << endl;
}