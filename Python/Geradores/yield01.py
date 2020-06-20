"""
 " 
 " Maurício Freire
 " Geradores são funções que retornam um objeto por vez, de forma a ser possível 
 " iterá-los. Usar yield no lugar de return faz com que o método returne sem que
 " ele seja encerrado.
 " Generators are functions that return an object per time, thus it is possible 
 " to iterate them. Using yield instead of return does the method return without
 " finalizing it. 
"""

def func(s):
    x = s // 2 
    print("Primeiro returno. O método continuará no próximo loop.")
    print("First return. The method will continue in the next loop.")
    x *= 3
    yield 3 * s
    print("Segundo returno.")
    print("Second return.")
    s -= x
    yield s
    print("Terceiro returno.")
    print("Third return.")
    yield s ** 2


n = int(input("Informe um número: "))
for i in func(n):
    print(i)
    d = input("\ntype ENTER to continue ")
    
  
  
