#include <iostream>
#include <stdio.h>
#include <list>
#include <algorithm>
#include <map>
using namespace std;

int main()
{
    list<int> lista; 
    for (int i = 0; i < 100; i++) {
        lista.push_back(rand());
    }
    auto it = lista.begin();
    lista.sort();
    for (auto num : lista) {
        cout << num << " ";
    }
	cout << endl;
    for (auto it = lista.begin(); it != lista.end(); ) {
        if (*it % 2 == 0) {
            it = lista.erase(it);
        }
        else {
            ++it;
        }
    }
	cout << endl;
	for (auto num : lista) {
		cout << num << " ";
	}
	cout << endl;
    map<int, int> contagem;
    for (auto num : lista) {
        contagem[num]++;
    }

    bool repetido = false;
    cout << "Numeros repetidos: ";
    for (const auto& par : contagem) {
        if (par.second > 1) {
            cout << par.first << " ";
            repetido = true;
        }
    }
    if (!repetido) {
        cout << "Nenhum numero repetido.";
    }
    cout << endl;



	return 0;
}