#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador << desloca uma certa quantidade de bits de uma variável 
 * para a esquerda.
 * Operator << moves a certain amount of bits to the left of a variable.
*/

int main()
{
    int a = 6; // 00110
    int b = 2; // 00010
    
    // Move os bits de 6 duas casa para a esquerda.
    // Moves the bits of 6 two steps to the left.
    int c = a << b;

    // c <- 24 | bin 11000
    printf("Valor de c: %d\n", c);
    return 0;
}

