#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Um vetor de caracteres é um String.
 * An array of characters is a String.
*/

int main()
{
    char nome[11];

    printf("Digite seu nome: ");
    scanf(" %10[^\n]", nome);
    fflush(stdin);

    printf("Seu nome: %s\n", nome);
}

