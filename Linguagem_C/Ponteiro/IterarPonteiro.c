#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Vetores tem os endereços de memória próximos, então ao salvar um vetor em
 * um pointeiro salvaremos o endereço do primeiro elemento.
 * Arrays have close memory addresses, so when saving a array in a pointer 
 * it will store the address of the first element.
*/

int main()
{
    char arr[] = { 'A', 'B', 'C'}, *ptr;
    int  i;

    ptr = arr;

    for ( i = 0; i < 3; i++) {
        // O operador ++ pula para o próximo endereço no vetor.
        // The operator ++ skips to the next array address.
        printf("%c\n", *ptr++);
    }

    return 0;
}

