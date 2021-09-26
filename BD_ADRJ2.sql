/*CRIA O BANCO
CREATE DATABASE ADRJ2
ULTILIZA O BANDO DEFINIDO
GO
USE ADRJ2*/

/*CENTRAL DE ARMAZENAMENTOS DE DADOS ADRJ2*/


/*CENTRAL DE ARMAZENAMENTOS DE DADOS ADRJ2*/

/*FAZENDO O BANCO FUNCIONAR
1° SELECIONE AS TABELAS SEM FOREIGN KEY PARA NÃO CAUSAR NENHUM CONFLITO SÃO AS TABELAS (SEGUIR NA SEQUENCIA)
	ENDERECO
	DDD
	ESTADO_CIVIL
	ESCOLARIDADE
	CATEGORIA
	FORMA_PAGAMENTO
	
2°SELECIONE E EXECUTE AS SEGUINTES TABELAS (SEGUIR NA SEQUENCIA)
	FILIAL
	FORNECEDOR
	PRODUTO
	CLIENTE
	FUNCIONARIO
	VENDA 
	DETALHAMENTO_VENDA*/
	
	--====================================================================================================================================

/*CRIAÇÃO DA TABELA ENDERECO*/
CREATE TABLE ENDERECO
(
	end_CEP CHAR (9) PRIMARY KEY NOT NULL,
	end_Logradouro VARCHAR(60)NOT NULL,
	end_Bairro VARCHAR (40)NOT NULL,
	end_Cidade VARCHAR (30)NOT NULL,
	end_UF CHAR (2)NOT NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*Dropa table Endereco inteira*
drop table endereco
*/

--====================================================================================================================================

/*5 CRIAÇÃO DA TABELA DDD*/
CREATE TABLE DDD
(
	d_DDD CHAR (4) PRIMARY KEY,
	d_Cidade VARCHAR (45) NOT NULL,
	d_Estado CHAR(2)NOT NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*dropa tabela DDD inteira*
Drop table DDD
*/

--====================================================================================================================================

/*3 CRIAÇÃO DA TABELA ESTADO_CIVIL*/
CREATE TABLE ESTADO_CIVIL
(
	ec_Cod_Estado_Civil INT PRIMARY KEY IDENTITY,
	ec_Descricao_Estado_Civil VARCHAR (15)NOT NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*dropa tabela ESTADO CIVIL*
drop table ESTADO_CIVIL
*/

--====================================================================================================================================

/*2 CRIA TABELA GRAU DE ESCOLARIDADE*/
CREATE TABLE ESCOLARIDADE
(
	es_Cod_Escolaridade INT PRIMARY KEY IDENTITY,
	es_Escolaridade VARCHAR(45) NOT NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA A TABELA ESCOLARIDADE INTEIRA*
DROP TABLE ESCOLARIDADE
*/

--====================================================================================================================================

/*1 CRIA TABELA CATEGORIA*/
CREATE TABLE CATEGORIA
(
	cat_Cod_categoria INT PRIMARY KEY IDENTITY,
	cat_Descricao VARCHAR (25) NOT NULL,
)
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABELA CATEGORIA INTEIRA*
DROP TABLE CATEGORIA
*/

--====================================================================================================================================

/*CRIA TABELA FORMA DE PAGAMENTO*/
CREATE TABLE FORMA_PAGAMENTO
(
	fp_Cod_Pagamento INT PRIMARY KEY IDENTITY,
	fp_Descricao_pagamento VARCHAR (20) NOT NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABELA FORMA DE PAGAMENTO*
DROP TABLE FORMA_PAGAMENTO
*/

--====================================================================================================================================

/*7 CRIAR TABELA DE FILIAIS*/
CREATE TABLE FILIAL
(
	fil_Cod_filial INT PRIMARY KEY IDENTITY,
	fil_Nome VARCHAR (35) NOT NULL,
	fil_CEP CHAR (9) constraint FK_CEP_FILIAL foreign key (fil_CEP) references ENDERECO NOT NULL,
	fil_Numero CHAR (4) NOT NULL,
	fil_Complemento VARCHAR (45) NULL,
	fil_DDD CHAR(4)CONSTRAINT FK_DDD_FILIAL FOREIGN KEY (fil_DDD) REFERENCES DDD NULL,
	fil_Telefone CHAR (9) NOT NULL,
	fil_Horarios VARCHAR (60) NOT NULL,
	fil_CNPJ VARCHAR (18) NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA A TABELA FLIAIL INTEIRA*
DROP TABLE FILIAL
*/

--====================================================================================================================================

/*8 CRIAR TABELA FORNECEDOR*/
CREATE TABLE FORNECEDOR
(
	forn_Cod_fornecedor INT PRIMARY KEY IDENTITY,
	forn_Nome VARCHAR (45) NOT NULL,
	forn_CNPJ VARCHAR (20) NOT NULL,
	forn_Nome_fantasia VARCHAR (45) NULL,
	forn_Inscricao_estMun VARCHAR (25) NULL,
	forn_CEP CHAR (9) constraint FK_CEP_FORNECEDOR foreign key (forn_CEP) references ENDERECO NOT NULL,
	forn_Numero CHAR (4) NOT NULL,
	forn_Complemento VARCHAR (45) NULL,
	forn_DDD CHAR(4)CONSTRAINT FK_DDD_FORNECEDOR FOREIGN KEY (forn_DDD) REFERENCES DDD NULL,
	forn_Telefone CHAR (9) NOT NULL,
	forn_Data_cadastro VARCHAR (10),
	forn_Email VARCHAR (45) NULL,
	forn_Site VARCHAR (55) NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABELA FORNECEDOR INTEIRA*
DROP TABLE FORNECEDOR
*/

--====================================================================================================================================

/*9 CRIA TABELA PRODUTO*/
CREATE TABLE PRODUTO
(
	pro_Cod_Produto INT PRIMARY KEY IDENTITY,
	pro_Nome_produto VARCHAR (35) NOT NULL,
	pro_Cod_Categoria INT constraint FK_CATEGORIA foreign key (pro_Cod_categoria) references Categoria NOT NULL,
	pro_Cod_Barras VARCHAR (45) NULL,
	pro_Fornecedor INT constraint FK_fornecedor_produto foreign key (pro_fornecedor) references Fornecedor NOT NULL,
	pro_Preco_custo MONEY  NULL,
	pro_Valor MONEY 	NOT NULL,
	pro_Quantidade Varchar (3) NOT NULL,
)
 
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABELA PRODUTO*
DROP TABLE PRODUTO
*/

--====================================================================================================================================

 /*CRIAÇÃO DA TABELA CLIENTES*/ 
CREATE TABLE CLIENTE
(
	cl_Cod_cliente INT PRIMARY KEY IDENTITY,
	cl_Nome VARCHAR (65) NOT NULL,
	cl_RG VARCHAR(19) NOT NULL,
	cl_CPF CHAR(14) NOT NULL,
	cl_Data_nascimento VARCHAR (10) NOT NULL,
	cl_Sexo CHAR (1) CONSTRAINT CK_SEXO_CLIENTE CHECK (cl_SEXO = 'F' OR cl_SEXO = 'M') NOT NULL,
	cl_Nome_mae VARCHAR (50) NULL,
	cl_Estado_civil int  constraint FK_ESTADOCIVIL_CLIENTE foreign key (cl_ESTADO_CIVIL) references ESTADO_CIVIL NULL,
	cl_CEP CHAR (9) constraint FK_CEP_CLIENTE foreign key (cl_CEP) references ENDERECO NOT NULL,
	cl_Numero CHAR(4)NOT NULL,
	cl_Complemento VARCHAR (35)NULL,
	cl_DDD CHAR(4)CONSTRAINT FK_DDD_CLIENTE FOREIGN KEY (cl_DDD) REFERENCES DDD NULL,
	cl_Telefone CHAR(9) NULL,
	cl_DDD2 CHAR(4)CONSTRAINT FK_DDD2_CLIENTE FOREIGN KEY (cl_DDD2) REFERENCES DDD NULL,
	cl_Celular CHAR (9)NULL,
	cl_Data_Cadastro VARCHAR (10) NOT NULL,
	cl_Email VARCHAR	(45) NULL,
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*dropa tabela Cliente inteira*
drop table cliente
*/

--====================================================================================================================================

/*10 CRIACAO DA TABELA FUNCIONARIOS*/
CREATE TABLE FUNCIONARIO
(
	fun_Cod_Funcionario INT PRIMARY KEY IDENTITY,
	fun_Nome VARCHAR (65) NOT NULL,
	fun_RG VARCHAR(19) NOT NULL,
	fun_CPF VARCHAR(14) NOT NULL,
	fun_Data_nascimento VARCHAR (10) NOT NULL,
	fun_Sexo CHAR (1) CONSTRAINT CK_SEXO_FUNC CHECK (fun_SEXO = 'F' OR fun_SEXO = 'M') NOT NULL,
	fun_Nome_mae VARCHAR (50) NULL,
	fun_Estado_civil INT constraint FK_ESTADO_CIVIL_FUNC foreign key (fun_ESTADO_CIVIL) references ESTADO_CIVIL NOT NULL,
	fun_CEP CHAR (9) constraint FK_CEP_FUNC foreign key (fun_CEP) references ENDERECO NOT NULL,
	fun_Numero CHAR(4)NOT NULL,
	fun_Complemento VARCHAR (35)NULL,
	fun_Grau_escolaridade int constraint FK_GRAUESCOLAR_FUNC foreign key (fun_Grau_escolaridade) references escolaridade NOT NULL,
	fun_Situação_escolar VARCHAR (15) NOT NULL,
	fun_Nome_Escola VARCHAR (40) NOT NULL,
	fun_Cursos VARCHAR (250) NULL,
	fun_CTPS VARCHAR (6) NOT NULL,
	fun_Serie VARCHAR (9) NOT NULL,
	fun_DDD CHAR(4)CONSTRAINT FK_DDD_FUNC FOREIGN KEY (fun_DDD) REFERENCES DDD NULL,
	fun_Telefone CHAR(9) NULL,
	fun_DDD2 CHAR(4)CONSTRAINT FK_DDD2_FUNC FOREIGN KEY (fun_DDD) REFERENCES DDD NULL,
	fun_Celular CHAR(9) NULL,
	fun_Cargo VARCHAR (20) NOT NULL,
	fun_Data_admissao VARCHAR (10) NOT NULL,
	fun_Data_Dispensa  VARCHAR (10) NULL,
	fun_Filial INT CONSTRAINT FK_FILIAL_FUNC FOREIGN KEY (fun_FILIAL) REFERENCES FILIAL NOT NULL,
	fun_Salario MONEY NOT NULL,
	fun_Email VARCHAR	(45) NULL,
	fun_Login VARCHAR (22) NOT NULL,
	fun_Senha VARCHAR (8) NOT NULL,
	fun_localhost Varchar (13) CONSTRAINT CK_localHost CHECK (fun_localhost = 'ADMINISTRADOR' or fun_localhost= 'FUNCIONARIO') NOT NULL,
)



------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*dropa a tabela funcionarios inteira*
drop table funcionarios
*/

--====================================================================================================================================

/*11 CRIA TABELA VENDA*/
CREATE TABLE VENDA
(
	vnd_Cod_venda INT PRIMARY KEY IDENTITY,
	vnd_Cod_cliente INT CONSTRAINT FK_CODCLIENTE FOREIGN KEY (vnd_Cod_cliente) REFERENCES cliente NOT NULL,
	vnd_Cod_funcionario INT CONSTRAINT FK_COD_FUNC FOREIGN KEY (vnd_Cod_funcionario) REFERENCES funcionario NOT NULL,
	vnd_Cod_loja INT CONSTRAINT FK_COD_FILIAL FOREIGN KEY (vnd_Cod_loja) REFERENCES Filial NULL,
	vnd_Cod_pagamento INT CONSTRAINT FK_COD_PAGAMENTO_FORMA_PAGAMENTO FOREIGN KEY (vnd_Cod_pagamento) REFERENCES FORMA_PAGAMENTO,
	vnd_Data_Venda Varchar (21),
	vnd_Parcela CHAR (2),
	vnd_Total MONEY,
	vnd_Tipo_Pagamento CHAR (1) CONSTRAINT CK_PAGAMENTO CHECK (vnd_Tipo_Pagamento = 'V' or vnd_Tipo_Pagamento = 'P' or vnd_Tipo_Pagamento = ' '),	
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABELA COMPRA INTEIRA*
DROP TABLE VENDA
*/

--====================================================================================================================================

/*CRIA TABELA DETALHAMENTO_VENDA*/
CREATE TABLE DETALHAMENTO_VENDA
(
	dv_Cupom INT PRIMARY KEY IDENTITY,
	dv_Cod_Produto INT CONSTRAINT FK_PRODUTO_DETALHAMENTO_VENDA FOREIGN KEY (dv_Cod_Produto) REFERENCES PRODUTO NOT NULL,
	dv_Quantidade CHAR (2),
	dv_Subtotal MONEY NOT NULL,
	dv_Cod_Venda INT CONSTRAINT FK_Cod_Venda FOREIGN KEY (dv_Cod_Venda) REFERENCES VENDA,
	
)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*DROPA TABLE DETALHAMENTO DE VENDA*
DROP TABLE DETALHAMENTO_VENDA*/










