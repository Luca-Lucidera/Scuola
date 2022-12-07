#include "Spesa.h"

Spesa::Spesa()
{
	posY = 0;
	posX = 0;
	int x = 1;
	for (int y = 0; y < Y; y++)
	{
		for (int x = 0; x < X; x++)
		{
			spese[y][x] = 0;
		}
	}
}

void Spesa::aggiungiSpesa(int spesa)
{
	if (posX < X) {
		spese[posY][posX] = spesa;
		posX++;
	}
	else {
		posX = 0;
		posY++;
		spese[posY][posX] = spesa;
		posX++;
	}
}

string Spesa::visualizza()
{
	string tmp="";
	for (int y = 0; y < Y; y++)
	{
		for (int x = 0; x < X; x++)
		{
			tmp += to_string(spese[y][x]);
		}
		tmp += "\n";
	}
	return tmp;
}

int Spesa::getSpesa(int y,int x)
{
	return spese[y][x];
}
