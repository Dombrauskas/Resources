#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Dentro de um laço o continue pula uma iteração se uma condição for atendida.
 * Within a loop the continue skips an iteration if a centain condition is true.
*/

int main() 
{
    int i, num, soma = 0;

    for(i = 0; i < 10; i++) {
        printf("Digite um numero: ");
        scanf("%d", &num);

        if(num > 5) 
            continue;
        
        // Se o número digitado for maior que 5 esta mensagem não será exibida.
        // If the inputed number is greater than 5 this message won't be shown.
        printf("Voce digitou: %d\n", num);
    }

    return 0;
}

