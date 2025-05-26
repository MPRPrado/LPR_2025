#include <stdio.h>
#include <iostream>
#include <vector>
using namespace std;
int main(){
    vector<int> numeros(10);
    // digite 10 numeros e de pois indentifica e criar uma vetor para par e um para impar apos ler
    vector<int> pares;
    vector<int> impares;
    for(int i = 0; i < numeros.size(); i++){
        cout << "Digite o numero " << i + 1 << ": ";
        cin >> numeros[i];
    }
     for(int n : numeros){
        if(n % 2 == 0){
            pares.push_back(n);
        } else {
            impares.push_back(n);
        }
    }
    cout << "Pares: ";
    for(int p : pares){
        cout << p << " ";
    }
    cout << endl;
    cout << "Impares: ";
    for(int imp : impares){
        cout << imp << " ";
    }
    cout << endl;
    return 0;
}