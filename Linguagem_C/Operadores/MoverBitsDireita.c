#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador >> desloca uma certa quantidade de bits de uma variável 
 * para a direita.
 * Operator >> moves a certain amount of bits to the right of a variable.
*/

int main()
{
    int a = 42; // 101010
    int b = 4;  // 000100
    
    // Move os bits de 42 quatro casas para a esquerda.
    // Moves the bits of 42 four steps to the right.
    int c = a >> b;

    // c <- 2 | bin 000010
    printf("Valor de c: %d\n", c);
    return 0;
}

