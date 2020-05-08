#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador binário ^ faz a lógica bitwise XOR entre dois operandos.
 * Binary operator ^ does the bitwise logic XOR between two operands.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    
    // Se os bits dos dois operandos forem diferentes é 1, se não 0.
    // If the bits of both operands are different it is 1, if not 0.
    int c = a ^ b;

    // c <- 47 | bin 101111
    printf("Valor de c: %d\n", c);
    return 0;
}

