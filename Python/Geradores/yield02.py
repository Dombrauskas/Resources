"""
 " 
 " Maurício Freire
"""

# Método retorna um caracter por vez.
# Method returns a character per loop.
def func(t):
    for i in t:
        yield i


txt = input("Informe um texto: ")
for ch in func(txt):
    print(ch)


