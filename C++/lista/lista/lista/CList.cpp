#include "CList.h"

CList::CList()
{
	testa = NULL;
}

CList::~CList()
{
	if (testa) delete testa;
}

void CList::pushLista(char info)
{
	if (testa) //head!=NULL //Esiste già il primo nodo
		testa->pushNodo(info); //Passo a lui l'info da memorizzare
	else
		testa = new CNode(info); //Creo il primo nodo
}

void CList::printLista()
{
	if (testa)
		testa->printNodo();
}

char CList::getAtLista(int pos)
{
	char res = ' ';
	if (testa) res = testa->getAtNodo(pos);
	return res;//ATTENZIONE: se la lista è vuota viene comunque ritornato il carattere ''
}

char CList::popLista()
{
	char tmp;
	if (testa != NULL)
		tmp = testa->popNodo();
	return tmp;

}

void CList::reversePrintLista()
{
	if (testa != NULL) {
		testa->reversePrintNodo();
	}
}

int CList::getLengthLista()
{
	int tmp = 1;
	if (testa != NULL) {
		testa->getLengthNodo(tmp);
	}
	return tmp;
}

int CList::findLista(char info)
{
	int pos = 1;
	if (testa != NULL) {
		pos =  testa->findNodo(info,pos);
	}
	return pos;
}

void CList::deleteAtLista(int pos)
{
	if (testa != NULL) {
		testa->deleteAtNodo(pos);
	}
}

void CList::insertAtLista(int pos, char info)
{
	if (testa != NULL)
	{
		testa->insertAtNodo(pos, info);
	}
}

void CList::sortedInsertLista(char info)
{
	if (testa != NULL)
	{
		testa->pushNodo(info);
		testa->sortedInsertNodo(info);
	}
}
