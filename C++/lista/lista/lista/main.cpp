#include"CList.h"
void main()
{
	CList* l = new CList();
	l->pushLista('a');
	l->pushLista('b');
	l->pushLista('c');
	l->pushLista('d');
	l->pushLista('e');
	l->pushLista('f');
	cout << "lista: ";
	l->printLista();
	cout << endl;
	cout << "pop -> " << l->popLista() << endl;
	l->printLista(); cout << endl;
	/*
	cout << "lista al contrario: ";  l->reversePrintLista(); cout << endl;
	cout << "lunghezza lista: " << l->getLengthLista() << endl;
	cout << "Posizione b: " << l->findLista('c') << endl;
	cout << "DELETE" << endl;
	l->deleteAtLista(2);
	l->printLista(); cout << endl;
	/*
	l->insertAtLista(2, 'x');
	l->printLista(); cout << endl;
	l->sortedInsertLista('j'); 
	cout << "dopo il sortedInsert" << endl;
	l->printLista();
	*/
}