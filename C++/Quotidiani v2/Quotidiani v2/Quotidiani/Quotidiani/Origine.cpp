/** @mainpage Edicola
* questo progetto permette di gestire una collezione di quotidiani \n
* nello specifico permette di inserire, cancellare, modificare, una collezione di CQuotidiani
* @section _utilizzo utilizzo
* @subsection chiamata_ai_metodi Chiamata ai metodi
* @ref Termini_e_condizioni_di_utilizzo
* @subpage Prova_pagina_2
*/

/** @page Prova_pagina_2 Prova pagina 2
* @section _Prova2 Prova2
* testo della prova 2
* @subsection _sProva2 Sottosezione pagina 2
* testo sottosezione pagina 2
*/


/** @page Termini_e_condizioni_di_utilizzo Termini e condizioni di utilizzo
* @section _termini termini
* testo dei termini
* @subsection _condizioni condizioni
* testo condizioni
*/


/**
* @author Luca Lucidera
* @version 1.0
* @file Origine.cpp
* @brief gestisce una serie di quotidiani pre caricati e ne permette la visualizzazione/cancellazione/cercarne uno per data/modificarne uno/
*/

#include"CQuotidiani.h"
void main() {
	/**
	* inizializzazione di oggetto q1 di classe CQuotidiano con l'oggetto lib della classe CQuotidiani
	*/
	CQuotidiani lib;
	CQuotidiano q1("LaStampa", 10, 11, 2000, "LaStampa.pdf", false);
	lib.mettiQuotidiano(q1);
	q1 = CQuotidiano ("QuattroRuote", 20, 2, 2015, "QuattroRuote.pdf", true);
	lib.mettiQuotidiano(q1);
	q1 = CQuotidiano("LaProvincia", 15, 6, 2020, "LaProvincia.pdf", true);
	lib.mettiQuotidiano(q1);
	/**
	* utilizzo tutti i metodi della classe CQuotidiani tramite l'oggetto lib
	*/
	//richiamo metodo megaVisTutto per vedere tutti i quotidiani
	cout << lib.megaVisTutto() << endl;
	//richiamo metodo eliminaQuotidiano per eliminari un quotidiano specifico
	cout << lib.eliminaQuotidiano(3) << endl;
	//richiamo metodo cercaPerData per cercare un quotidiano per data
	cout <<"Quotidiano cercato per data: " <<lib.cercaPerData(20, 2, 2015) << endl;
	//richiamo metodo modificaQuotidiano per modificare un quotidiano
	lib.modificaQuotidiano(2, "IlQuotidaino", 1, 2, 2003, "IlQuotidaino.pdf", true);
	cout << lib.megaVisTutto() << endl;
}