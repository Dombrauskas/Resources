class Curso:

    def __init__(self, nome, meses_de_duracao, valor):
        self.__nome = nome
        self.__meses_de_duracao = meses_de_duracao
        self.__valor = valor

    @property
    # Permite ao objeto acessar um atributo como um getter, sem chamar um método.
    # Allows the object to get an attribute as a getter without a method calling.
    def nome(self):
        return self.__nome

    @nome.setter
    # Permite ao objeto atribuir um valor como um setter, sem chamar um método.
    # Allows the object to set a value as a setter without a method calling.
    def nome(self, nome):
        self.__nome = nome

    @staticmethod
    # Permite chamar um método sem instanciar um objeto.
    # Allows to access a method with no object instantiated.
    def escola():
        return 'Dombrauskas'

    # Getter
    def get_meses_de_duracao(self):
        return self.__meses_de_duracao

    # Setter
    def set_meses_de_duracao(self, meses):
        self.__meses_de_duracao = meses


curso = Curso('Python', 12, 433.7)

# Altera o valor do nome pelo setter sem usar () do método.
# Changes the value of name by the setter not using method's ().
curso.nome = 'Python Decoration'

# Exibe o valor de nome pela property sem usar () do método.
# Displays the value of name by property not using method's ().
print(curso.nome)

# Sem o property ao invés de alterar o valor do atributo, um novo será criado.
# Without property instead of changing the attibute value a new one will be created.
curso.meses_de_duracao = 18
print(curso.get_meses_de_duracao())  # prints 12 not 18

# Sem o property para alterar o valor de um atributo é preciso criar um setter.
# Without property in order to change the attribute value one should create a setter.
curso.set_meses_de_duracao(24)

# E um getter para retornar o valor.
# And a getter to return its value.
print(curso.get_meses_de_duracao())

# Método estático usado diretamente pela classe, sem um objeto.
# Static method being used directly by the class, objectless.
print(Curso.escola())
