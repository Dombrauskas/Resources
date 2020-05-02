#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Vetores são dados de um mesmo tipo salvos próximos uns dos outros na memória
 * Arrays are same data type stored next to each other in the memory.
*/

int main()
{
    int vetInt[10];
    float vetF[10];
    char vetCh[10];

    int i;
    for (i = 0; i < 10; i++) {
        vetInt[i] = i;
        vetF[i] = (float) vetInt[i] / i;
        vetCh[i] = i + 97;
    }

    for (i = 0; i < 10; i++) {
        printf("%d\n%.2f\n%c\n", vetInt[i], vetF[i], vetCh[i]);
    }

}

