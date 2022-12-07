#include "CFile.h"

CFile::CFile()
{
}

void CFile::aggiungiTutteLeSpese(Spesa spesa)
{
	f.open("C:\\Users\\lucid\\Desktop\\Matrici_di_spese\\spese.dat", ios::app, ios::binary);
	for (int y = 0; y < Y; y++)
	{
		for (int x = 0; x < X; x++)
		{
			f.write((char*)spesa.getSpesa(y,x), sizeof(int));
		}
	}
	f.close();
}
