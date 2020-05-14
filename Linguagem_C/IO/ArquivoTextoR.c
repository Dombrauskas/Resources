#include <stdio.h>
#include <stdlib.h>

/**
 * 
 * Maurício Freire
 * Lendo arquivos de texto em C.
 * Reading plain text files in C.
*/

int main()
{
    FILE *fp;
    int eof;
    char ch;

    if ((fp = fopen("File.txt", "r")) == NULL) {
        printf("Erro ao abrir o arquivo!");
        exit(0);
    }

    while ((ch = fgetc(fp)) != EOF) 
        printf("%c", ch);
    
    fclose(fp);
    return 0;
}

