from flask import Flask
from flask_sqlalchemy import SQLAlchemy


# Inicia o aplicativo flask e carrega as configurações e banco de dados.
# Starts the flask application and loads the configurations and database.
app = Flask(__name__)
app.config.from_pyfile("config.py")
db = SQLAlchemy(app)

from views import *


# debug=True permite re-executar automaticamente o servidor flask após salvar alterações.
# debig=True allows to automatically rerun the flask server after saving changes. 
if __name__ == "__main__":
	app.run(debug=True)


