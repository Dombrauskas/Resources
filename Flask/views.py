from flask import render_template, request, redirect, session, flash, Response, url_for, send_from_directory
from models import Musica
from ki import app, db


@app.route("/")
def index() -> str:
	musicas = Musica.query.order_by(Musica.id)
	return render_template("home.html", title="Discoteca", musicas=musicas)


@app.route("/login")
def login() -> str:
	proxima = request.args.get("proxima")
	return render_template("login.html", proxima=proxima)


@app.route("/logout")
def logout() -> Response:
	del session["usuario"]
	flash("Logout realizado com sucesso.")
	return redirect(url_for("index"))


@app.route("/autenticar", methods=["POST",])
def autenticar():
	pass


@app.route("/nova_musica")
def nova_musica():
	if "usuario" not in session:
		return redirect(url_for("login", proxima=url_for("nova_musica")))
	return render_template("nova_musica.html", title="Nova Música")



def criar():
	pass



def editar():
	pass



def atualizar():
	pass



def excluir():
	pass


