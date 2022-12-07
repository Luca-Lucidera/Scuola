#include "Pilota.h"

Pilota::Pilota()
{
	nome = "";
	percorso = "";
	punteggio = 0;
	numero = 0;
}

Pilota::Pilota(string percorso)
{
	nome = "";
	this->percorso = percorso;
	punteggio = 0;
	numero = 0;
}

void Pilota::aggiugniPilota(string nome, int numero, int punteggio)
{
	this->nome = nome;
	this->numero = numero;
	this->punteggio = punteggio;
	string tmp = this->nome + ";" + to_string(this->numero) + ";" + to_string(this->punteggio);
	file.open(percorso, ios::app);
	file << tmp << endl;
	file.close();
}

string Pilota::leggiEVisualizzaFile()
{
	
	file.open(percorso, ios::in);
	string n, p, num, tutto, riga ;
	string v[20];
	int c = 0;
	
	while (!file.eof())
	{
		getline(file, riga);
		int pos = riga.find(";", 0);
		n = riga.substr(0, pos);  //posizione iniziale | quanto togliere
		int pos2 = riga.find(";", pos + 1);
		num = riga.substr(pos + 1, pos2 - pos - 1);
		int pos3 = riga.find("\n");
		p = riga.substr(pos2 + 1, pos3);
		tutto = n + " " +num + " " + p;
		v[c] = tutto;
		c++;
	}
	string tmp;
	for (int i = 0; i < c; i++)
	{
		tmp += v[i] + "\n";
	}
	file.close();
	return tmp;
}

string Pilota::cercaPunteggioPerNome(string nome)
{
	file.open(percorso, ios::in);
	string punteggio;
	string riga;
	while (!file.eof()) {
		getline(file, riga);
		int pos = riga.find(";", 0);
		if (riga.substr(0, pos) == nome) {
			int pos2 = riga.find(";", pos + 1);
			string num = riga.substr(pos + 1, pos2 - pos - 1);
			int pos3 = riga.find("\n");
			string p = riga.substr(pos2 + 1, pos3);
			return p;
		}
	}
	return "PUNTEGGIO NON TROVATO!";
}
