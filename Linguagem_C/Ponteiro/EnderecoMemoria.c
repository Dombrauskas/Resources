#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Ponteiros guardam o endereço de memória de outras variáveis.
 * Pointers store the memory address of other variables.
*/

int main()
 {
    // Endereços de memória diferentes.
    // Different memory addresses.
    int x, *px;
    printf("Endereco de memoria: %p %p\n", &x, px);
    
    // Endereços de memória iguais.
    // Same memory addresses.
    px = &x;
    printf("Endereco de memoria: %p %p\n", &x, px);
    
    return 0;
}

