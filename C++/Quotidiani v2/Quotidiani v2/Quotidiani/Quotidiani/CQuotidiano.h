/**
* @author Luca Lucidera
* @version 1.0
* @file CQuotidiano.h
* @brief definisce la classe CQuotidiano
*/

#pragma once
#include<iostream>
#include<string>
using namespace std;
class CQuotidiano
{
private:
	/**
	nome del quotidiano
	*/
	string nome;
	/**
	nome del file che si riferisce al quotidiano
	*/
	string nomeFile;
	/**
	giorno mese e anno del rilascio
	*/
	int giorno; 
	int mese ;
	int anno;
	/**
	dice se vero c'è un allegato, se falso non c'è
	*/
	bool allegato;
public:
	/**
	@brief	costruttore
	*/
	CQuotidiano();
	/**
	* @brief costruttore parametrico
	* @param[in] nome tipo stringa parametro formale in ingresso che contiene il nome del quotidiano
	* @param[in] giorno tipo int parametro formale in ingresso che contiene il giorno dell'uscita del quotidiano
	* @param[in] mese tipo parametro formale in ingresso che contiene il mese d'uscita del quotidiano
	* @param[in] anno tipo parametro formale in ingresso che contiene l'anno d'uscita del quotidiano
	* @param[in] nomeFile tipo parametro formale in ingresso che contiene il nome di un allegato
	* @param[in] allegato  tipo parametro formale in ingresso che contiene il valore dell'esistenza di un quotidiano
	*/
	CQuotidiano(string, int, int,int, string,bool);
	
	/**
	* @brief	metodo per ridare il nome
	* @return string ritorna la stringa del nome del quotidiano
	*/
	string getNome();
	
	/**
	* @brief metodo per ridare il giorno
	* @return int ritorna il giorno di uscita del quotidiano
	*/
	int getGiorno();
	
	/**
	* @brief metodo per restituire il mese
	* @return int ritorna il giorno di uscita del quotidiano
	*/
	int getMese();
	
	/**
	* @brief	metodo per ritornare l'anno di uscita
	* @return int ritorna l'anno di uscita
	*/
	int getAnno();
	
	/**
	* @brief restituisce il nome del file 
	* @return string restituisce una stringa contenente il nome del file allegato
	*/
	string getNomeFile();
	
	/**
	* @brief metodo per restituire l'allegato
	* @return bool restituisce un booleano che contiente un vero o false che significa se è presente un allegato
	*/
	bool getAllegato();
	
	/**
	* @brief serve per creare una stringa contenente tutti i parametri 
	* @return string ritorna una stringa con tutti gli attributi concatenati.
	*/
	string visTutto();
};

