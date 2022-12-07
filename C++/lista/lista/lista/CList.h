#pragma once
#include"CNode.h"
class CList
{
private:
	CNode* testa;
public:
	CList();
	~CList();
	void pushLista(char info);
	void printLista();
	char getAtLista(int pos);
	char popLista();
	void reversePrintLista();
	int getLengthLista();
	int findLista(char info); // restituisce la posizione del nodo che contiene l'info 
	void deleteAtLista(int pos); // cancella il nodo nella posizione specificata
	void insertAtLista(int pos, char info);
	void sortedInsertLista(char info);
};

