#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Estruturas permitem agrupar variáveis relacionadas e, diferentemente dos
 * vetores as estruturas podem ter dados de diferentes tipos. 
 * Structures allow grouping related variables and unlikely arrays structures 
 * allow having different data types.
*/


struct Home {
    char rua[30];
    int num;
    char bairro[15];
};

int main() 
{
    struct Home home;

    printf("Rua: ");
    scanf(" %29[^\n]", home.rua);
    printf("Num: ");
    scanf(" %d", &home.num);
    printf("Bairro: ");
    scanf(" %14[^\n]", home.bairro);


    printf("Voce mora em %s %d, %s\n", home.rua, home.num, home.bairro);
    return 0;
}

