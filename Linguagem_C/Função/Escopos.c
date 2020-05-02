#include <stdio.h>

void func();

/**
 * 
 * Maurício Freire
 * Cada bloco tem regras diferente, por isso é posível ter em blocos
 * distintos variáveis com o mesmo nome e, ainda assim não serem iguais.
 * Each scope has different rules, therefore is possible each block
 * store variables with the same name and be different from the others.
*/

int main()
{
    int var = 10;

    printf("Valor de var em main: %d\n", var);
    printf("Endereco de var da main: %p\n", &var);

    func();
    
}

void func()
{
    int var = 10;
    
    
    // var tem o mesmo nome e valor da sua similar na main, mas é salva em
    // outra parte da memória e não tem relação com a homônima.
    // var has the same name and value of its similar from main, though it
    // is stored apart and has no relation with its homonym.
    printf("Valor de var em func: %d\n", var);
    printf("Endereco de var da func: %p\n", &var);
}

