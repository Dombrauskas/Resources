#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Membros de uma estrutura podem ser acessados de duas formas ou por ponto
 * (.), se for acessado por uma variável do tipo da estrutura, ou por seta
 * (->) se for acessado por um ponteiro.
 * Members of a struct can be acessed by two different operator the dot (.)
 * whether it is accessed by a struct type variable, or by the arrow (->)
 * whether it is accessed by a pointer.
*/


typedef struct {
    char rua[30];
    int num;
    char bairro[15];
} Home;

int main() 
{
    Home home, address, *phome;

    printf("Rua: ");
    scanf(" %29[^\n]", home.rua);
    printf("Num: ");
    scanf(" %d", &home.num);
    printf("Bairro: ");
    scanf(" %14[^\n]", home.bairro);
    phome = &home;

    printf("\n");

    printf("Rua: ");
    scanf(" %29[^\n]", address.rua);
    printf("Num: ");
    scanf(" %d", &address.num);
    printf("Bairro: ");
    scanf(" %14[^\n]", address.bairro);

    printf("Ponteiro mora em %s %d, %s\n", home.rua, home.num, home.bairro);
    printf("Voce mora em %s %d, %s\n", address.rua, address.num, address.bairro);
    return 0;
}

