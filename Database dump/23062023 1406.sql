CREATE DATABASE db_caoamigo;

USE db_caoamigo;		

CREATE TABLE if not exists tb_tutor(
	cd_tutor INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	cd_cpf CHAR(11) NOT NULL,
    cd_telefone CHAR(11) NOT NULL,
    nm_tutor VARCHAR(80) NOT NULL
)
engine innoDB;

CREATE TABLE if not exists tb_pet(
	cd_pet INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    cd_tutor INT NOT NULL,
    nm_pet VARCHAR(30) NOT NULL,
	tp_raca VARCHAR(80) NOT NULL,
    tp_porte VARCHAR(10) NOT NULL,
	FOREIGN KEY (cd_tutor)
		REFERENCES tb_tutor(cd_tutor)
)
engine innoDB;

CREATE TABLE if not exists tb_agenda(
	cd_agenda INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	cd_pet INT NOT NULL,
	tp_servico VARCHAR(10) NOT NULL,
    dt_servico DATE NOT NULL,
    vl_servico DECIMAL(5, 2) NOT NULL,
    hr_servico TIME NOT NULL,
    FOREIGN KEY (cd_pet)
		REFERENCES tb_pet(cd_pet)
)
engine innoDB;
