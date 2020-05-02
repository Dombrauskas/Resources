#include <stdio.h>

int * ordena(int []);

/**
 * 
 * Maurício Freire
 * Função que retorna um vetor.
 * Function that returns an array.
*/

int main()
{
    int vet[] = { 88, 15, 44, 73, 42 }, i, *pv;

    printf("Vetor original: ");
    for (i = 0; i < 5; i++) {
        printf("%d ", vet[i]);
    }
    
    pv = ordena(vet);
    printf("\n");

    printf("Vetor ordenado: ");
    for (i = 0; i < 5; i++) {
        printf("%d ", *pv++);
    }
}

int * ordena(int * vetor)
{
    int menor, i, j;
    for (i = 0; i < 5; i++) {
        menor = vetor[i];
        for (j = i + 1; j < 5; j++) {
            if (vetor[j] < menor) {
                menor = vetor[j];
                vetor[j] = vetor[i];
                vetor[i] = menor;
            }
        }
    }

    return vetor;
}

