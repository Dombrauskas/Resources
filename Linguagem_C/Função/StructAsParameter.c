#include <stdio.h>
#include <stdbool.h>

typedef struct {
    char rua[30];
    int num;
    char bairro[15];
} Home;

bool equal(Home, Home);

int main() 
{
    Home home, address;

    printf("Rua: ");
    scanf(" %29[^\n]", home.rua);
    printf("Num: ");
    scanf(" %d", &home.num);
    printf("Bairro: ");
    scanf(" %14[^\n]", home.bairro);

    printf("\n");

    printf("Rua: ");
    scanf(" %29[^\n]", address.rua);
    printf("Num: ");
    scanf(" %d", &address.num);
    printf("Bairro: ");
    scanf(" %14[^\n]", address.bairro);

    bool eq = equal(home, address);
    if (eq)
        printf("Iguais\n");
    else
        printf("Diferentes\n");

    return 0;
}


bool equal(Home s1, Home s2)
{
    bool equality = true;
    while (equality) {
        equality = s1.rua == s2.rua;
        equality = s1.num == s2.num;
        equality = s1.bairro == s2.bairro;
    }
    
    return equality;
}

