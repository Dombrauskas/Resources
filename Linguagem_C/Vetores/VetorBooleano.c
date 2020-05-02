#include <stdio.h>
#include <stdbool.h>

/**
 * 
 * Maurício Freire
 * Um vetor Booleano.
 * A Boolean array.
*/

int main()
{
    bool vet[3];

    vet[0] = 1 == 1.0;
    vet[1] = 'a' == 'A';
    vet[2] = vet[0] != vet[1];

    int i;
    for (i = 0; i < 3; i++)
        printf("%d: %d\n", i, vet[i]);

}

