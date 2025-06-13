#include <stdio.h>
#include <iostream>

using namespace std;
int main(){
   int fatorial = 0;
   cout << "Digite um numero: ";
   cin >> fatorial;
    for(int i = fatorial - 1; i > 0; i--){
        fatorial *= i;
    }
    cout << "Fatorial: " << fatorial << endl;
    
}