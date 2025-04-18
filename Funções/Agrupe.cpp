#include <iostream>
#include <locale>

using namespace std;

void agrupe()
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
            pares++;
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
}

void somaImpares()
{
    int sm = 0;

    for (int num = 50; num <= 500; num++)
    {
        if (num % 3 == 0 && num % 2 != 0)
        {
            sm += num;
        }
    }
    cout << sm;
}

void quadrado()
{

    int num, qdd;
    int sm = 0;

    cout << "insira um numero:\n";
    cin >> num;

    qdd = num * num;

    while (qdd > 0)
    {
        sm += qdd % 10;
        qdd /= 10;
    }

    cout << "a soma dos digitos e igual a:" << sm;
}

int main()
{
    setlocale(LC_ALL, "Portuguese");
    int opcao;

    do {
        cout << "1. Media dos numeros pares \n";
        cout << "2. Soma de impares multiplos de 3 \n";
        cout << "3. Soma dos digitos do quadrado de um numero\n";
        cout << "0. Sair\n";
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                agrupe();
                break;
            case 2:
                somaImpares();
                break;
            case 3:
                quadrado();
                break;
            case 0:
                cout << "Encerrando o programa.\n";
                break;
            default:
                cout << "Opção inválida. Tente novamente.\n";
        }
    } while (opcao != 0);
    return 0;
}
