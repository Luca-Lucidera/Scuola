#include "Tuffatori.h"

Tuffatori::Tuffatori()
{
	for (int i = 0; i < maxel; i++)
	{
		v[i] = 0;
	}
	pos = 0;
}

bool Tuffatori::carica(int voto)
{
	if (voto < 0 || voto > 10)
		return false;
	else {
		v[pos] = voto;
		pos++;
		return true;
	}
}

int Tuffatori::votoGiudice(int x)
{
	if (x <= 0 || x > 7)
		return 0;
	else return v[x - 1];
}

int Tuffatori::giudiceBuono()
{
	int tmp = 0;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] > v[tmp])
			tmp = i;
	}
	return tmp + 1;
}

int Tuffatori::giudiceCattivo()
{
	int tmp = 11;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] < v[tmp])
			tmp = i;
	}
	return tmp + 1;
}

int Tuffatori::punteggio()
{
	int votoBello = v[giudiceBuono() - 1];
	int votoBrutto = v[giudiceCattivo() - 1];
	int somma = 0;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] != votoBello && v[i] != votoBrutto)
			somma += v[i];
	}
	return somma;
}

int Tuffatori::giudicePiuBuono(Tuffatori x)
{
	if (v[giudiceBuono() - 1] > x.votoPiuAlto())
		return 1;
	else if (v[giudiceBuono() - 1] < x.votoPiuAlto())
		return 2;
	else return 0;
}

int Tuffatori::giudicePiuCattivo(Tuffatori x)
{
	if (v[giudiceCattivo() - 1] > x.votoPiuBasso())
		return 2;
	else if (v[giudiceCattivo() - 1] < x.votoPiuBasso())
		return 1;
	else return 0;
}

int Tuffatori::tuffatoreVincente(Tuffatori x)
{
	int tmp = punteggio();
	int tmp2 = x.punteggio();
	if (tmp > tmp2)
		return 1;
	else if (tmp2 > tmp)
		return 2;
	else return 0;
}

int Tuffatori::votoPiuAlto()
{
	int tmp = 0;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] > tmp)
			tmp = v[i];
	}
	return tmp;
}

int Tuffatori::votoPiuBasso()
{
	int tmp = 11;
	for (int i = 0; i < pos; i++)
	{
		if (v[i] < tmp)
			tmp = v[i];
	}
	return tmp;
}

string Tuffatori::visTutto()
{
	string tmp;
	for (int i = 0; i < pos; i++)
	{
		tmp += to_string(v[i]) + " ";
	}
	return tmp;
}

