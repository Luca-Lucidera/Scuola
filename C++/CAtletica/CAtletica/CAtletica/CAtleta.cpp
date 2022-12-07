#include "CAtleta.h"

CAtleta::CAtleta()
{
	nome = "";
	nazionalita = "";
	tempo = 0;
}

CAtleta::CAtleta(string n, string nz, float t)
{
	nome = n;
	nazionalita = nz;
	tempo = t;
}

void CAtleta::setNome(string n)
{
	nome = n;
}

void CAtleta::setNazionalita(string n)
{
	nazionalita = n;
}

void CAtleta::setTempo(int t)
{
	tempo = t;
}

string CAtleta::getNome()
{
	return nome;
}

string CAtleta::getNazionalita()
{
	return nazionalita;
}

float CAtleta::getTempo()
{
	return tempo;
}

string CAtleta::visTutto()
{
	string tmp = "Nome: " + nome + " nazionalita " + nazionalita + " tempo " + to_string(tempo);
	return tmp;
}
