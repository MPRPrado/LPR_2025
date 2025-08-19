#include <iostream>
#include <locale>

using namespace std;
void contraio(int x){
    int y = 0;
    while (x > 0) {
        y = y * 10 + x % 10;
        x /= 10;
    }
    cout << y << endl;

}
int main()
{
    setlocale(LC_ALL, "Portuguese");
    int x;
    cout << "Digite um numero: ";
    cin >> x;
    contraio(x);
    return 0;

}
