#include <stdio.h>

void func(int *);

/**
 * 
 * Maurício Freire
 * É possível usar operadores aritmético nos ponteiros.
 * It is possible to use arithmetc operators in the pointers.
*/

int main()
{
    int x, *px;
    x = 10;
    px = &x;

    for (;;) {
        func(px);
        printf("%d\n", x);
        if (x == 23) {
            break;
        }
    }
    return 0;
}


void func(int * pp)
{
    (*pp)++;
}

