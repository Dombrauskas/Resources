#include <stdio.h>

/**
 * 
 * Maurício Freire
 * O ponteiro salva o endereço de memória de uma variável e quando a variável
 * é atualizada o ponteiro também será, pois ambos compartilham o endereço.
 * The pointer stores the memory address of a variable and when the variable
 * is updated the pointer also will be, because both share the same address.
*/

int main() 
{
    int x, *px;
    scanf("%d", &x);
    px = &x;
    printf("X: %3d\tPonteiro: %3d\n", x, *px);
    x++;
    printf("X: %3d\tPonteiro: %3d\n", x, *px);
    return 0;
}

