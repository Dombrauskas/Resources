#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Função é um bloco de código, um escopo separado com um proposito específico.
 * Function is a block of code, a separate scope with a specific purpose.
*/

int MDC(int, int);

int main() 
{
    int x, y;
    printf("Digite: ");
    scanf("%d %d", &x, &y);

    if (x > y) {
        printf("Maximo Divisor Comum entre %d e %d: %d\n", x, y, MDC(x, y));
    } else {
        printf("Maximo Divisor Comum entre %d e %d: %d\n", y, x, MDC(y, x));
    }

    return 0;
}

int MDC(int M, int m)
{
    int c = -1;
    
    while (c != 0) {
        c = (int) M / m;
        c = M - (m * c);
        M = m;
        m = c;
    }

    return M;
}

