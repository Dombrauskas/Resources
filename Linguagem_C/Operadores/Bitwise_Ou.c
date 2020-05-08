#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador binário | faz a operaao de bits OU entre dois operandos.
 * Binary operator | does the bits operation OR between two operands.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    
    // Se um dos bits for 1 resultará em 1, se não 0.
    // If an operand bit is 1 it results 1, if not 0.
    int c = a | b;

    // c <- 63 | bin 111111
    printf("Valor de c: %d\n", c);
    return 0;
}

