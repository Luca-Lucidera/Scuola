#pragma once
#include<iostream>
#include<string>
#include<fstream>
using namespace std;
class Pilota
{
private:
	string percorso;
	string nome;
	int punteggio, numero;
	fstream file;
public:
	Pilota();
	Pilota(string);
	void aggiugniPilota(string nome, int numero, int punteggio);
	string leggiEVisualizzaFile();
	string cercaPunteggioPerNome(string nome);
};

