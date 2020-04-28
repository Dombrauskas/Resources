#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Vetor de ponteiros.
 * Array of pointers.
*/

int main()
{
    int i, *px[3], arr[3];

    for (i = 0; i < 3; i++) {
        arr[i] = i;
        px[i] = &arr[i];
    }

    for (i = 0; i < 3; i++) {
        printf("%p\n", px[i]);
    }
    return 0;
}

