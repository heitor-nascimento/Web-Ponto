# DROP se existir o database
DROP DATABASE IF EXISTS db_webponto;

# Criando Database
create database db_webponto;

# Usando Database
use db_webponto;

# Criando Tabelas

DROP TABLE IF EXISTS tb_colaborador;

CREATE TABLE tb_colaborador (
	cd_colaborador INT(11),
    nm_colaborador VARCHAR(100),
    email_colaborador VARCHAR(255),
    CPF INT(11),
    cd_telefone INT(11),
    ds_endereco VARCHAR(45),
    administrador TINYINT
);

DROP TABLE IF EXISTS tb_ponto;

CREATE TABLE tb_ponto (
	cd_ponto INT(11),
    hr_entrada DATETIME,
    hr_saida DATETIME,
    cd_colaborador INT(11)
);
