#include<iostream>
#include <fstream> 
#include <string>
#include"CClasse.h"
#include"CRegistro.h"
using namespace std;
void main() {
    CClasse c("Luca", "Lucidera", 15);
    CRegistro r;
    r.addAlunno(c);
    c = CClasse("marco", "soggiu", 26);
    r.addAlunno(c);
    c = CClasse("baccaglini", "christian", 2);
    r.addAlunno(c);
    r.scriviIlFile();
    cout << r.leggiIlFile() << endl;
    system("PAUSE");
}