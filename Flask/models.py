from projeto_flask import db

# Classe que representa a tabela do banco.
# Class representing the database table.
class Musica(db.Model):
	id = db.Column(db.Integer, primary_key=True)
	musica = db.Column(db.String(50), nullable=False)
	artista = db.Column(db.String(30), nullable=False)
	album = db.Column(db.String(50))


	def __repr__(self):
		return "<Música %r>" % self.musica


