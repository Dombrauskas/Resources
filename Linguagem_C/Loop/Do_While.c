#include <stdio.h>
#include <string.h>

/**
 * 
 * Maurício Freire
 * O laço do -- while, diferentemente do while, executa o laço primeiro e depois
 * faz a verificação da condição, assim este laço executará ao menos uma vez.
 * The do -- while loop, differently from the while, it runs the block and then
 * verifies the loop condition, thus this loop always runs at least once.
*/

int main(void)
{
    int i = 0;
    char ch[51];

    scanf(" %50[^\n]", ch);
    do {
        printf("%c", ch[i]);
        i++;
    } while (ch[i] != '.' && i < strlen(ch));
    return 0;
}

