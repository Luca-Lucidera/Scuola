#pragma once
#include<iostream>
using namespace std;
#define pigreco 3.1415
class CCerchio
{
private:
	int raggio;
public:
	CCerchio();
	void setRaggio(int);
	int getRaggio();
	int calcolaPerimetro();
	int calcolaArea();
};

