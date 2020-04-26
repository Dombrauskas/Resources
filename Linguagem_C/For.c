#include <stdio.h>

/**
 *
 * Maurício Freire
 * Exemplo simple de laço for.
 * Simple example of loop for.
*/

int main(void) {
    int i, n;
    printf("Hello World: ");
    scanf("%d", &n);

    printf("As primeiras %d letras do alfabeto: ", n);
    n += 65;
    for (i = 65; i < n && i < 91; i++) {
        printf("%c ", i);
    }
    return 0;
}

