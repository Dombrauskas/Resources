from os import path


# Uma palavra para basear a encriptação do flask.
# A word to base the flask encryption on.
SECRET_KEY = "secret_word"

# Configuração para acessar o banco de dados.
# Configuration to access the database.
SQLALCHEMY_DATABASE_URI = \
	"{SGBD}://{usuario}:{senha}@{servidor}/{database}".format(
		SGBD="mysql+mysqlconnector",
		usuario="root",
		senha="password",
		servidor="localhost",
		database="database"
	)

# Configura o caminho para o diretório uploads a partir do caminho absoluto deste arquivo no SO.
# Sets the path to the uploads directory based on this file absolute path on the OS.
UPLOAD_PATH = path.dirname(path.abspath(__file__)) + "/uploads"

