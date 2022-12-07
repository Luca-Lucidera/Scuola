
/**
* @author Luca Lucidera
* @version 1.0
* @file CQuotidiani.h
* @brief definisce la classe CQuotidiani che ha un inseme di tipo CQuotidiano
*/
#pragma once
#include"CQuotidiano.h"
#define maxel 10

/**
* @class CQuotidiani
* @brief gestisce un collezione di oggetti di classe CQuotidiano
* gestisce un vettore di CQuotidiano permettendo l'inserimento, ricerca, modifica, eliminazione e visualizzazione degli oggetti.
*/
class CQuotidiani
{
private:
	/** collezione di CQutodiani */
	CQuotidiano v[maxel];
	/** numero elementi presenti nel vettore */
	int pos;
public:
	/**
	* @brief costruttore
	*
	*  inizializza la collezione di CQuotidiano a 0 e pos a 0
	*/
	CQuotidiani();
	/**
	* @brief inserisco un oggetto quotidiano nel vettore di oggetti quotidiani
	*
	*  controllo se ho spazio per un nuovo quotidiano, lo inserisco nell'ultima posizione libera del vettore e incremento la pos.
	* @param[in] quotidiano CQuotidiano formale da inserire
	*/
	void mettiQuotidiano(CQuotidiano quotidiano);
	/**	
	* @brief metodo per cercare un quotidiano data la data
	* @param[in] giorno int parametro formale in ingresso che contiene il giorno
	* @param[in] mese int parametro formale che contiene il mese
	* @param[in] anno int parametro formale che contiene il l'anno
	* @return string ritorna una stringa descrittiva di un quotidiano cercato
	   se non viene trovato un quotidiano restituisce una stringa con errore.
	*/
	string cercaPerData(int giorno,int mese,int anno);
	
	/**
	* @brief	chiedo quale quotidiano eliminare dando la posizione del vettore come parametro
	* @param[in] posizione int parametro formale che contiene la poszione del vettore da eliminare
	* @return string ritorna una stringa se eliminato correttamente oppure ritorna un'altra stringa di errore se non lo trova
	*/
	string eliminaQuotidiano(int posizione);
	
	/**
	* @brief	vado a modificare un oggetto quotidiano presente nel vettore di quotidiani passando per parametro i dati del nuovo quotidiano e la posizione del vettore di quello da modificare
	* @param[in] posizione int parametro formale che contiene la poszione del vettore da cambiare
	* @param[in] nome string parametro formale che contiene il nome del nuovo quotidiano da cambiare
	* @param[in] giorno int parametro formale che contiene il giorno del nuovo quotidiano da cambiare
	
	*/
	void modificaQuotidiano(int posizione, string nome,int giorno,int mese,int anno,string pdf,bool allegato);
	
	/**
	* @brief	visualizzo tutto l'array
	* @return string restituisce un stringa che contiene tutti gli elemnti presenti nell'array
	*/
	string megaVisTutto();
};

