#include <stdio.h>
#include <iostream>
#include <vector>
using namespace std;
int main(){
    int matriz[4][4] = {
        0,524,521,882,
        524,0,434,586,
        521,434,0,429,
        882,586,429,0
    };
    string cidades[4] = {"Vitoria", "BeloHorizonte", "RiodeJaneiro", "SaoPaulo"};
    string origem, destino;
    while(true){
        cout << "Digite a cidade de origem: ";
        cin >> origem;
        cout << "Digite a cidade de destino: ";
        cin >> destino;

        int origemFinal = -1, destinoFinal = -1;
        for(int i = 0; i < 4; i++){
            if(cidades[i] == origem) origemFinal = i;
            if(cidades[i] == destino) destinoFinal = i;
        }

        if(origemFinal == -1 || destinoFinal == -1){
            cout << "Cidade invalida. Tente novamente." << endl;
            continue;
        }

        if(origemFinal == destinoFinal){
            cout << "Voce escolheu a mesma cidade como origem e destino. Encerrando o programa." << endl;
            break;
        }

        cout << "A distancia entre " << origem << " e " << destino << " e de " 
             << matriz[origemFinal][destinoFinal] << " km." << endl;
    }

}

