/**
 * 
 * Maurício Freire
 * A Função strtok() divide um string em partes com base em um delimitador.
 * The function strtok() divides a string into pieces based on a delimiter.
*/

#include <stdio.h>
#include <string.h>

int main() {
    char string[50];
    char *token; // Recebe as partes | Receive the pieces
  
    printf("Texto: ");
    scanf("%49[^\n]", string);

    token = strtok(string, ",");
    while (token != NULL) {
        printf("%s\n", token);
        token = strtok(NULL, ",");
    }
    
    return 0;
}

