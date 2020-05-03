#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Vetor multidimensional é um grupo de vetores unidimensionais.
 * Multi-dimensional Array is a grouping of one-dimensional arrays. 
*/

int main() 
{
    int lin, col;
    double matriz[10][8];

    for (lin = 0; lin < 10; lin++) {
        for (col = 0; col < 8; col++) {
            matriz[lin][col] = (double) lin * 7 / 3 * col;
        }
    }

    for (lin = 0; lin < 10; lin++) {
        for (col = 0; col < 8; col++) {
            printf("%.2lf\t", matriz[lin][col]);
        }
        printf("\n");
    }

    return 0;
}


