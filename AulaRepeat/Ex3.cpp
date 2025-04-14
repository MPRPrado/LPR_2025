#include <iostream>
#include <locale>

using namespace std;

int main()
{
    
    
        int sm=0;
    
        for (int num = 50;num <= 500;num++) {
            if (num % 3 == 0 && num % 2 != 0) {
                sm += num;	
            }	
        }
        cout << sm;
    
        return 0;
    
}
