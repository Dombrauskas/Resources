#include <stdio.h>

/**
 *
 * Maurício Freire
 * Demonstração de if.
 * Demonstrate the if.
*/

int main()
{
	int e;
	scanf("%d", &e);
	
	if (e >= 18) {
		printf("Maior de idade");
	}
	else {
		printf("Menor de idade");
	}
	return 0;
}

