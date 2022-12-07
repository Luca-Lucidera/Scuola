#include "CClasse.h"

CClasse::CClasse()
{
	nome = "";
	cognome = "";
	numeroRegistro = 0;
	
}

CClasse::CClasse(string nome, string cognome, int numeroRegistro)
{
	this->nome = nome;
	this->cognome = cognome;
	this->numeroRegistro = numeroRegistro;
}

string CClasse::getNome()
{
	return nome;
}

string CClasse::getCognome()
{
	return cognome;
}

int CClasse::getNumeroRegistro()
{
	return numeroRegistro;
}

