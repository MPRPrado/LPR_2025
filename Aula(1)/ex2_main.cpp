#include <iomanip>
#include <iostream>

using namespace std;

int main(){
float raio;
float n = 3.14159;
cout<< "Entre com um valor de raio" << endl;
cin >> raio;
float area = n * (raio*raio);
cout << "Aqui sua area:"<< area << endl;
  return 0;
}