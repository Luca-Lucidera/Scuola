#pragma once
#include<iostream>
using namespace std;
class CNode
{
private:
	char dato;
	CNode* prossimo;
public:
	CNode(char info);
	~CNode();
	void pushNodo(char info);
	void printNodo();
	char getAtNodo(int pos);
	char popNodo();
	void reversePrintNodo();
	int getLengthNodo(int& c); // restituisce il numero di nodi che compongono la lista
	int findNodo(char info,int& pos); // restituisce la posizione del nodo che contiene l'info 
	void deleteAtNodo(int pos); //cancella il nodo nella posizione specificata
	void insertAtNodo(int pos, char info);
	void sortedInsertNodo(char info);
	char getDato();
	void setDato(char info);
};

