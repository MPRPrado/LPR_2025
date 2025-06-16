#include <iostream>
#include <vector>
#include <stdio.h>
using namespace std;
struct alunos{
    string titulo;
    string autor;
    int preco = 0;
    int pags = 0;
    int ano = 0;    
};

int main(){
    vector<alunos> vetorAlunos (16);
    cout << "Digite os dados dos livros " << endl;
    for(int i = 1; i < 4; i++ ){
        cout << "Digite o titulo do livro " << i << endl;
        cin >> vetorAlunos[i-1].titulo;
        cout << "Digite o autor do livro " << i << endl;
        cin >> vetorAlunos[i-1].autor;
        cout << "Digite o preco do livro " << i << endl;
        cin >> vetorAlunos[i-1].preco;
        cout << "Digite o numero de paginas do livro " << i << endl;
        cin >> vetorAlunos[i-1].pags;
        cout << "Digite o ano de publicacao do livro " << i << endl;
        cin >> vetorAlunos[i-1].ano;
    }
    int soma = 0;
    int media = 0;
    for(alunos x : vetorAlunos){
        soma += x.preco;
        media += x.pags / 3;
    }
    cout << "A soma dos precos dos livros e: " << soma  << endl;
    cout << "A media de paginas dos livros e: " << media << endl;





}