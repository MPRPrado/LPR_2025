#include <iostream>
#include <stdio.h>
#include <vector>
using namespace std;
struct Alunos{
    string Nome;
    int idade;
};
int main(){
    cout << "insira os dasos dos aluno" << endl;
    vector<Alunos> vetorAlunos(5);
    for (int i = 1; i<6 ; i++){
        cout << "Insira o nome do aluno" << i << endl;
        cin >> vetorAlunos[i-1].Nome;
        cout << "Insira a idade do aluno" << i << endl;
        cin >> vetorAlunos[i-1].idade;
    }
    int soma = 0;
    for (Alunos x : vetorAlunos){
        soma += x.idade;
    }
    cout << "A media das idades dos alunos e: " << soma / 5 << endl;


}