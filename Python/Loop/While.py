"""
 "
 " Maurício Freire
 " Laço while.
 " Loop while.
"""

x = 0
t = 0
while (x != 42 and t < 5):
    x = int(input("Digite um número entre 1 e 100: "))
    if (x > 42):
        print("Menor que", x)
    else:
        print("Maior que", x)

    t += 1

