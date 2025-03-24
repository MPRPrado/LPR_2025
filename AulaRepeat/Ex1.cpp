#include <iostream>
#include <locale>

using namespace std;

int main()
{
    int quantidade = 0;
    int numeros = 0;
    int contador = 0;
    int soma = 0;
    double media = 0;
    int pares = 0;
    cout << "Insira a quantidade de numeros: ";
    cin >> quantidade;
    while (contador < quantidade)
    {
        cout << "Insira um numero: ";
        cin >> numeros;
        if (numeros % 2 == 0)
        {
            cout << "O numero " << numeros << " e par" << endl;
            soma += numeros;
            pares ++;
        }
        else
        {
            cout << "O numero " << numeros << " e impar" << endl;
        }

        contador++;
    }
    if (contador >= quantidade)
    {
        media = (double)soma / pares;
        cout << "A media dos numeros pares e: " << media << endl;
    }

    return 0;
}
