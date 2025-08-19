#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;


int main() {

	int num,qdd;
	int sm = 0;

	cout << "insira um numero:\n";
	cin >> num;

	qdd = num * num;

	while (qdd > 0) {
		sm += qdd % 10;
		qdd /= 10;
	}

	cout << "a soma dos digitos e igual a:" << sm;


	return 0;
}