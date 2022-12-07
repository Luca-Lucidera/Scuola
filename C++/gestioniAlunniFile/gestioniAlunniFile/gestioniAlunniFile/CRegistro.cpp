#include "CRegistro.h"
CRegistro::CRegistro()
{
	for (int i = 0; i < maxEl; i++)
	{
		v[i] = CClasse();
	}
	pos = 0;
	file.open("D:\\tmp\\prova.txt", ios::out);
	file.close();
}

void CRegistro::addAlunno(CClasse x)
{
	if (pos < maxEl)
	{
		v[pos] = x;
		pos++;
	}
}

void CRegistro::scriviIlFile()
{
	for (int i = 0; i < pos; i++)
	{
		if (i < pos - 1) {
			file.open("D:\\tmp\\prova.txt", ios::app);
			file << v[i].getNome() << ";" << v[i].getCognome() << ";" << v[i].getNumeroRegistro() << endl;
			file.close();
		}
		else {
			file.open("D:\\tmp\\prova.txt", ios::app);
			file << v[i].getNome() << ";" << v[i].getCognome() << ";" << v[i].getNumeroRegistro();
			file.close();
		}
	}
}

string CRegistro::leggiIlFile()
{
	string s = "";
	file.open("D:\\tmp\\prova.txt", ios::in);
	getline(file, s); //LETTURA DAL FILE di una riga intera, fino al carattere '\n'
	while (!file.eof()) {
		cout << s << endl;
		getline(file, s); //LETTURA dal file di una riga intera, fino al carattere '\n'
	}
	return s;
}
