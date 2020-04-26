#include <stdio.h>

/**
 *
 * Maurício Freire
 * Demonstração de switch para uma calculadora básica.
 * Demonstrate the switch usage for a basic calculator.
*/

int main()
{
	float a,b;
	char op;
	printf("Digite uma operacao matematica: ");
	scanf("%f %c %f", &a, &op, &b);

	switch (op){
		case '+':
		printf("Resultado = %.2f\n", a+b);
		break;
		case '-':
		printf("Resutado = %.2f\n", a-b);
		break;
		case '*':
		printf("Resutado = %.2f\n", a*b);
		break;
		case '/':
		printf("Resutado = %.2f\n", a/b);
		break;
		default:
		printf("operacao Invalida\n");
		return 0;
	}
	return 0;
}

