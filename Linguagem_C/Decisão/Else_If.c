#include <stdio.h>

/**
 * 
 * Maurício Freire
 * O else if adiciona mais condições a estrutura de decisão do if.
 * The else if adds more conditions to the if decision structure.
*/

int main(void) 
{
    int x, y;
    printf("Digite dois numeros: ");
    scanf("%d %d", &x, &y);

    if (x > y) {
        printf("%d maior que %d\n", x, y);
    }
    else if (x == y) {
        printf("Os dois valores sao iguais.\n");
    }
    else {
        printf("%d menor que %d\n", x, y);
    }
    return 0;
}

