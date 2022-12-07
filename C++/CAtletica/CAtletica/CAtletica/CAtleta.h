#pragma once
#include<iostream>
#include<string>
using namespace std;
class CAtleta
{
private:
	string nome, nazionalita;
	float tempo;
public:
	CAtleta();
	CAtleta(string,string,float);
	void setNome(string);
	void setNazionalita(string);	
	void setTempo(int);
	string getNome();
	string getNazionalita();
	float getTempo();
	string visTutto();
};

