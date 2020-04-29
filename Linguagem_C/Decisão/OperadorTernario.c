#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Operador Ternário (?) - Avalia uma condição e ser for True executa a 
 * primeira parte, se for False a segunda parte será executada.
 * Ternary Operator (?) - Evaluates a condition and if it is True the
 * first part is executed, if not the second half will execute.
*/

int main(void) {
    int x;
    printf("Digite um numero: ");
    scanf("%d", &x);
    printf(x % 2 == 0 ? "Par\n" : "Impar\n");
    return 0;
}

