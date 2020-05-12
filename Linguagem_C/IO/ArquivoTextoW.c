#include <stdio.h>
#include <stdlib.h>

/**
 * 
 * Maurício Freire
 * Gravando arquivos de texto em C.
 * Creating plain text files in C.
*/

int main()
{
    FILE *fp;
    char txt[50];

    if ((fp = fopen("File.txt", "wb")) == NULL) {
        printf("Erro ao criar o arquivo!");
        exit(0);
    }

    printf("Digite o conteudo do arquivo: ");
    scanf(" %49[^\n]", txt);
    fprintf(fp, "%s", txt);
    
    fclose(fp);
    return 0;
}

