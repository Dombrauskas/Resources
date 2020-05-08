#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador binário ^ faz a lógica matemática XOR entre dois operandos.
 * Binary operator ^ does the mathematical logic XOR between two operands.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    int c = a ^ b;

    // c <- 47 | bin 101111
    printf("Valor de c: %d\n", c);
    return 0;
}

