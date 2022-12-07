#pragma once
#include"Spesa.h"
#include<fstream>
class CFile
{
private:
	fstream f;
public:
	CFile();
	void aggiungiTutteLeSpese(Spesa);
};

