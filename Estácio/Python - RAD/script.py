import os


arquivo = open("teste.txt")

print(os.path.realpath(arquivo.name))
print(os.path.abspath(arquivo.name))

print(arquivo)
print("Arquivo aberto com sucesso")