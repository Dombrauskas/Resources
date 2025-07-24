# Imagem base do contêiner.
# Container's base image.
FROM ubuntu

# Nome do responsável (opcional).
# Maintainer's name (opcional).
MAINTAINER Dombrauskas

# Pasta de trabalho inicial do contêiner.
# Container's start working diretory.
WORKDIR /app

# Copia arquivos para o contêiner.
# Copies files to the contêiner.
COPY . .

# Executa comandos durante a construção da imagem.
# Executes commands during the image build process.
RUN apt-get update && apt-get install nano

# Executa comandos com contêiner iniciado.
# Executes commands in the started container.
CMD nano arquivos.txt