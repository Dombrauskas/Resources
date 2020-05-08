#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador binário & faz a lógica matemática E entre dois operandos.
 * Binary operator & does the mathematical logic AND between two operands.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    int c = a & b;

    // c <- 16 | bin 10000
    printf("Valor de c: %d\n", c);
    return 0;
}

