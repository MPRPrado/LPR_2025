#include <iostream>
#include <map>
#include <vector>
#include <string>
#include <limits>

using namespace std;

int main() {
    map<string, int> mapaCidadesHabitantes;

    cout << "Quantas cidades deseja digitar? ";
    int numeroCidades;
    cin >> numeroCidades;
    cin.ignore();

    for (int i = 0; i < numeroCidades; i++) {
        cout << "Digite o nome da cidade: ";
        string nomeCidade;
        getline(cin, nomeCidade);

        cout << "Digite o numero de habitantes de " << nomeCidade << ": ";
        int qtdHabitantes;
        cin >> qtdHabitantes;
        cin.ignore();

        mapaCidadesHabitantes[nomeCidade] = qtdHabitantes;
    }

    string cidadeMaxPopulacao = "";
    int maxPopulacao = numeric_limits<int>::min();
    string cidadeMinPopulacao = "";
    int minPopulacao = numeric_limits<int>::max();

    for (const auto& cidadeDados : mapaCidadesHabitantes) {
        if (cidadeDados.second > 17000) {
            cout << cidadeDados.first << " tem " << cidadeDados.second << " habitantes. Ou seja, eh uma cidade grande.\n";
        }
        if (cidadeDados.second < minPopulacao) {
            minPopulacao = cidadeDados.second;
            cidadeMinPopulacao = cidadeDados.first;
        }
        if (cidadeDados.second > maxPopulacao) {
            maxPopulacao = cidadeDados.second;
            cidadeMaxPopulacao = cidadeDados.first;
        }
    }

    cout << cidadeMaxPopulacao << " eh a cidade mais populosa.\n";
    cout << cidadeMinPopulacao << " eh a cidade menos populosa.\n";

    cout << "Digite o numero de habitantes para remover as cidades com essa populacao: ";
    int populacaoRemover;
    cin >> populacaoRemover;

    vector<string> listaCidadesRemover;

    for (const auto& cidadeDados : mapaCidadesHabitantes) {
        if (cidadeDados.second == populacaoRemover) {
            listaCidadesRemover.push_back(cidadeDados.first);
        }
    }

    for (const auto& nomeCidade : listaCidadesRemover) {
        mapaCidadesHabitantes.erase(nomeCidade);
    }

    cout << "Mapa atualizado:\n";
    for (const auto& cidadeDados : mapaCidadesHabitantes) {
        cout << cidadeDados.first << " - " << cidadeDados.second << " habitantes\n";
    }

    return 0;
