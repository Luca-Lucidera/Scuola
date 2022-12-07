#include<iostream>
#include<string>
using namespace std;
#define maxel 5
#pragma once
class CPagella
{
private:
	int v[maxel];
	int pos;
public:
	CPagella();
	void setVoto(int);
	int getVoto(int);
	float mediaVoti();
	string risultato();
	int NumVotiSupMedia();
	string StampaPagella();
};

