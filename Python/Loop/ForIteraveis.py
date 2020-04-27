"""
 "
 " Maurício Freire
 " O for também podem percorrer itens iteráveis como listas.
 " It is also possible a for iterate objects, such as lists. 
"""

vet = [ 1, 2, 4, 8, 16, 32, 64, 128, 256 ]
text = "String é um objeto iterável."

for i in text:
    print(i, end="")

print()

for i in vet:
    print(i, end=" ")

