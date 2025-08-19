#include <iostream>
#include <map>
#include <vector>
#include <string>
#include <limits>

using namespace std;

int main() {
    map<string, int> habitantesPorCidade;

    cout << "Quantas cidades deseja digitar? ";
    int quant;
    cin >> quant;
    cin.ignore();

    for (int i = 0; i < quant; i++) {
        cout << "Digite o nome da cidade: ";
        string cidade;
        getline(cin, cidade);

        cout << "Digite o numero de habitantes de " << cidade << ": ";
        int habitantes;
        cin >> habitantes;
        cin.ignore();

        habitantesPorCidade[cidade] = habitantes;
    }

    string cidadeMaisPopulosa = "";
    int maiorPopulacao = numeric_limits<int>::min();
    string cidadeMenosPopulosa = "";
    int menorPopulacao = numeric_limits<int>::max();

    for (const auto& par : habitantesPorCidade) {
        if (par.second > 17000) {
            cout << par.first << " tem " << par.second << " habitantes. Ou seja, eh uma cidade grande.\n";
        }
        if (par.second < menorPopulacao) {
            menorPopulacao = par.second;
            cidadeMenosPopulosa = par.first;
        }
        if (par.second > maiorPopulacao) {
            maiorPopulacao = par.second;
            cidadeMaisPopulosa = par.first;
        }
    }

    cout << cidadeMaisPopulosa << " eh a cidade mais populosa.\n";
    cout << cidadeMenosPopulosa << " eh a cidade menos populosa.\n";

    cout << "Digite o numero de habitantes para remover as cidades com essa populacao: ";
    int habitantesRemover;
    cin >> habitantesRemover;

    vector<string> cidadesParaRemover;

    for (const auto& par : habitantesPorCidade) {
        if (par.second == habitantesRemover) {
            cidadesParaRemover.push_back(par.first);
        }
    }

    for (const auto& cidade : cidadesParaRemover) {
        habitantesPorCidade.erase(cidade);
    }

    cout << "Mapa atualizado:\n";
    for (const auto& par : habitantesPorCidade) {
        cout << par.first << " - " << par.second << " habitantes\n";
    }

    return 0;
}