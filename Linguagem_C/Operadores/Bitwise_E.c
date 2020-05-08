#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador binário & faz a operação de bits E entre dois operandos.
 * Binary operator & does the bits operation AND between two operands.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    
    // Se os bits dos dois operandos forem iguais é 1, se não 0.
    // If the bits of both operands are equal it is 1, if not 0.
    int c = a & b;

    // c <- 16 | bin 10000
    printf("Valor de c: %d\n", c);
    return 0;
}

