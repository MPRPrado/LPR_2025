#include <stdio.h>
#include <iostream>
#include <list>
#include <algorithm>
using namespace std;
int main(){
    list <int> lista = {1, 2, 3, 4, 5};
    lista.push_back(4);
    auto it = lista.begin();
    advance(it, 2);
    lista.insert(it,7);
    auto it2 = find(lista.begin(), lista.end(), 8);
    bool contem8 = (it2 != lista.end());
    cout << "Contem 8? " << contem8 << endl;
    int count = 0;
    for (int num : lista) {
        if (num > 4) {
            count++;
        }
    }
    cout << "A lista tem " << count << " elementos maiores que 4." << endl;
    int count2 = 0;
    for (int num3 : lista) {
        if (num3 == 3) {
            count2++;
        }
    }
    cout << "A lista tem " << count2 << " elementos iguais a 3." << endl;
    
    lista.remove(2);
    lista.remove(4);

    cout << "A lista tem " << lista.size() << " elementos." << endl;
    cout << "Os elementos da lista sao: ";
    for (auto num : lista) {
        cout << num << " ";
    }
        cout << endl;

}