#include <stdio.h>

/**
 * 
 * Maurício Freire
 * Ponteiros também pode ter ponteiros: ponteiro de ponteiros.
 * Pointers can also have its pointers: pointer to pointers.
*/

int main()
{
    char x, *px, **ppx;

    x = 67;
    px = &x;
    ppx = &px;

    printf("%c\n", x);
    printf("%c\n", *px);
    printf("%c\n", **ppx);

    return 0;
}

