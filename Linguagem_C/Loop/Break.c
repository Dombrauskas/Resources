#include <stdio.h>
#include <stdbool.h>

/**
 * 
 * Maurício Freire
 * Laço while com interrupção de um break.
 * While loop with interruption of a break.
*/

int main(void) {
    int i = 1, x;
    printf("Ponto de interrupcao: ");
    scanf("%d", &x);

    printf("Contagem infinita: \n");
    while (true) {
        printf("%d\n", i++);
        if (i >= x) {
            break;
        }
    }
    return 0;
}

