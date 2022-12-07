#include "CNode.h"

CNode::CNode(char info)
{
	dato = info;
	prossimo = NULL; //Sono l'ultimo nodo
}

CNode::~CNode()
{
	if (prossimo) delete prossimo;
}

void CNode::pushNodo(char info)
{
	if (prossimo != NULL) //next!=NULL //Se esiste un altro nodo passo la richiesta a lui
		prossimo->pushNodo(info);
	else
		prossimo = new CNode(info); //altrimenti (io sono l'ultimo!) creo il nuovo nodo
}

void CNode::printNodo()
{
	cout << dato;
	if (prossimo) prossimo->printNodo();
}

char CNode::getAtNodo(int pos)
{
	
	char res = ' ';
	if (pos == 0)
		res = dato;
	else if (prossimo)
		res = prossimo->getAtNodo(pos - 1); //Chiamata ricorsiva con decremento di pos
	return res;
}

char CNode::popNodo()
{
	CNode* tmp = prossimo;
	tmp = prossimo->prossimo;
	if (tmp != NULL) 
	{
		prossimo->popNodo();
	}
	else 
	{
		char tmp;
		tmp = prossimo->getDato();
		prossimo=NULL;
		return tmp;
	}
}

void CNode::reversePrintNodo()
{
	if (prossimo != NULL) {
		prossimo->reversePrintNodo();
	}
	cout << dato;

}

int CNode::getLengthNodo(int &c)
{
	if (prossimo != NULL)
	{
		prossimo->getLengthNodo(++c); //aumeto il valore del contatore e poi glie lo ripasso per parametro per riferimento
	}
	return c;
}

int CNode::findNodo(char info, int& x)
{
	
	if (info != dato) {
		if (prossimo != NULL) {
			x++;
			prossimo->findNodo(info,x);
		}
		else return -1;
		
	}
	else if (dato == info)
	{
		return x;
	}
}

void CNode::deleteAtNodo(int pos)
{

	if (pos != 1){ 
		pos--;
		prossimo->deleteAtNodo(pos);
	}
	else
	{
		
		prossimo = prossimo->prossimo;
	}
}

void CNode::insertAtNodo(int pos, char info)
{
	if (pos != 0)
	{
		pos--;	
		prossimo->insertAtNodo(pos, info);
	}
	else
	{
		dato = info;
	}
}

void CNode::sortedInsertNodo(char info)
{
	
	int tmp1 = 0,c;
	c = prossimo->getLengthNodo(tmp1);
	for (int i = 0; i < c; i++)
	{
		if (info < prossimo->getDato());
		{
			char tmp;
			tmp = info;
			info =  prossimo->getDato();
			prossimo->setDato(tmp);
		}
	}

	
}

char CNode::getDato()
{
	return dato;
}

void CNode::setDato(char info)
{
	dato = info;
}
