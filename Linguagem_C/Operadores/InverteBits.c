#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador unário ~ troca bits de uma variável.
 * Unary operator ~ flips the bits of a variable.
*/

int main()
{
    int a = 56; // 111000
    int b = 23; //  10111
    int c = ~a;

    // c <- -57 | bin 111001
    printf("Valor de c: %d\n", c);
    return 0;
}

