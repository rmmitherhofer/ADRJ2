/*Ultilizar Banco ADRJ2*
USE ADRJ2*/

--====================================================================================================================================
/*INSERIR DADOS NA TABELA SITUACAO FAMILIAR*/
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('SOLTEIRO (A)')
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('CASADO (A)')
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('DIVORCIADO (A)')
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('CONCUBINADO (A)')
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('VIUVO (A)')
INSERT ESTADO_CIVIL (ec_Descricao_Estado_Civil)
	VALUES ('SEPARADO (A)')
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA SITUACAO_FAMILIAR*
SELECT * FROM ESTADO_CIVIL*/


--====================================================================================================================================

/*INSERIR DADOS NA TABELA ENDERECO*/
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Carlos Gomes','Jardim Belval','06420-270','Barueri','SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Travessa Espinosa', 'Mondumbim', '60711-570', 'Fortaleza', 'CE') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Betari', 'Penha de Franca', '03634-040', 'São Paulo', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Rafael Adorno', 'Jardim Miriam', '04419-060', 'São Paulo', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Jeni Davi Bacha', 'Conjunto Residencial Elmano Veloso', '12234-560', 'São José dos Campos', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Dos Tupis', 'Barnabe', '94150-430', 'Gravatai', 'RS') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Angela Franchini', 'Conjunto Habitaciona Franchini', '09720-550', 'São Bernardo do Campo', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Adanilo Graciano Pimentel', 'Jardim Itapema', '15045-339', 'São José do Rio Preto', 'SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Quadra 2', 'Candangolandia', '71725-200', 'Candangolandia', 'DF')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Escorpião', 'Cidade Satélite', '08330-570', 'São Paulo', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Gabriela', 'Parque dos Camargos', '06436-280', 'Barueri', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Raimundo Zosimo De Carvalho', 'Mangabeira', '58057-060', 'João Pessoa', 'PB') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua João Sipolatti', 'São Conrado', '29141-152', 'Cariacica', 'ES') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Biguazinho',  'Vila Sabrina', '02140-010', 'São Paulo', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Capitão Jacinto Pereira de Barros', 'Centro', '12010-770', 'Taubaté', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Francisca Maria de Souza', 'Vila Rangel', '12211-461', 'São José dos Campos', 'SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Guatambus', 'Eldorado', '09973-270', 'Diadema', 'SP') 
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Ipitangas', 'Magalhães Bastos', '1745-400', 'Rio de janeiro', 'RJ')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Avenida Major Leo Lerro', 'Vila São Judas Tadeu', '15075-230', 'São José do Rio Preto', 'SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Adoniram Barbosa', 'Parque Imperial', '06462-000', 'Barueri', 'SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Francisco Tomaz', 'Estella mares', '06624-300', 'Jandira', 'SP')
INSERT ENDERECO (end_LOGRADOURO,end_BAIRRO,end_CEP,end_CIDADE,end_UF)
	VALUES ('Rua Carajas', 'Jardim São Silvestre', '06417-120', 'Barueri', 'SP')
	
	GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA ENDERECO*
SELECT * FROM ENDERECO*/


--====================================================================================================================================

/*INSERIR DADOS NA TABELA ESCOLARIDADE*/
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Ensino Fundamental')
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Ensino Médio')
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Ensino Superior')
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Pós graduação')
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Doutorado')
INSERT ESCOLARIDADE(es_Escolaridade)
	VALUES ('Técnico')
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA ESCOLARIDADE*
SELECT * FROM ESCOLARIDADE*/


--====================================================================================================================================

/*INSERIR DADOS NA TABELA DDD*/
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(68)','Rio Branco','AC')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(82)','Maceió','AL')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(96)','Amapá','AP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(92)','Manaus','AM')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(71)','Salvador','BA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(73)','Ilheus','BA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(74)','Juazeiro','BA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(75)','Feira de Santana','BA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(77)','Barreiras','BA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(85)','Fortaleza','CE')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(88)','Juazeiro do Norte','CE')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(27)','Vila Velha/Vitória','ES')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(28)','Cachoeiro do Itapemirim','ES')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(62)','Goiânia','GO')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(64)','Rio Verde','GO')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(98)','São Luiz','MR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(99)','Imperatriz','MR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(67)','Campo Grande','MS')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(65)','Cuiabá','MT')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(66)','Rondonópolis','MT')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(31)','Belo Horizonte','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(32)','Juiz de Fora','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(33)','Governador Valadares','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(34)','Uberlândia','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(35)','Poços de Calda','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(37)','Divinópolis','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(38)','Montes Claros','MG')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(91)','Belém','PA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(93)','Santarém','PA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(94)','Marabá','PA')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(83)','João Pessoa','PB')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(41)','Rio Branco','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(42)','Ponta Grossa','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(43)','Londrina','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(44)','Maringá','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(45)','Foz do iguaçú','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(46)','Pato Branco','PR')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(81)','Recife','PE')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(86)','Teresina','PI')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(89)','Picos','PI')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(21)','Rio de Janeiro','RJ')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(22)','Campo do Goytacazes','RJ')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(24)','Volta Redonda','RJ')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(84)','Natal','RN')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(51)','Rio Branco','RS')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(53)','Porto Alegre','RS')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(54)','Caxias do Sul','RS')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(55)','Santa Maria','RS')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(69)','Porto Velho','RO')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(47)','Joinvile ','SC')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(48)','Florianópolis','SC')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(49)','Chapecó','SC')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(11)','São Paulo','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(12)','São José dos Campos','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(13)','Santos','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(14)','Baurú','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(15)','Sorocaba','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(16)','Ribeirão Preto','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(17)','São José do Rio Preto','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(18)','Presidente ','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(19)','Campinass','SP')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(79)','Sergipe','SE')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(63)','Palmas','AC')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(61)','Brasília','DF')
INSERT DDD (d_DDD,d_Cidade,d_Estado)
	VALUES ('(  )','N/D','ND')

	
------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*EXIBE TABELA DDD*
SELECT * FROM DDD*/


--====================================================================================================================================
GO
/*INSERIR DADOS NA TABELA Categoria*/
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Guitarra')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Bateria')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Violão')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Percusão')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Pedais')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Cavacos')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Acessorios para Guitarras')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Acessorios para Bateria')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Pratos')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('CD')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('DVD')
INSERT CATEGORIA (cat_Descricao)
		VALUES ('Sopro')
INSERT CATEGORIA (cat_Descricao)
		VALUES ('Piano')
INSERT CATEGORIA (cat_Descricao)
		VALUES ('Microfones')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Amplificadores Guitarra')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Amplificadores Bass')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Bass')
INSERT CATEGORIA (cat_Descricao)
	VALUES ('Teclado')
	
	GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA CATEGORIA*
SELECT * FROM CATEGORIA*/

--====================================================================================================================================

/*INSERIR DADOS NA TABELA CLIENTE*/
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(51)','3982-8447','(51)','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Marcos Silva','84.887.998-x','001.002.117-00','22/05/2975','M','Juscimara Silva',1,'04419-060','03','Casa','(11)','6603-1905','(  )','    -    ','19/05/2008', 'silva.marcos@hotmail.com')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('José Maria Pinto','088447-DF','002.884.788-02','01/02/1953','M','Silvana Braga Pinto',5,'15045-339','22','Edf das Orquideas BL 44 AP 320','(17)','4668-0687','(17)','8868-0775','25/15/2003', ' ')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Renata Silvestre Camargo','48.788.988.0','000.022.002-11','19/08/1984','F','Maria do Carmo Carmargo',1,'1745-400','4879','Fundos','(21)','3997-3874','(21)','8554-2218','14/07/2007', 'renatahtinha@gmail.com')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Renato Matos dos Santos','47.638.455-2','393.295.118-21','23/07/1990','M','Tania M Matos dos Santos',2,'06420-270','298','Casa','(  )','    -    ','(11)','7295-3428','14/05/1998', 'renato.story@hotmail.co.uk')

GO
/*tem que altera os dados*/
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')
INSERT CLIENTE (cl_Nome, cl_RG, cl_CPF, cl_Data_nascimento, cl_Sexo, cl_Nome_mae, cl_Estado_civil, cl_CEP, cl_Numero, cl_Complemento, cl_DDD, cl_Telefone, cl_DDD2, cl_Celular, cl_Data_Cadastro, cl_Email)
	VALUES ('Regiane Pereira Silva','486.357.884-2','393.485.118-44','15/02/1990','F','Rosana Vieira Silva',2,'94150-430','448','AP 03 BL 15','(  )','3982-8447','(  )','9946-5566','20/02/2001', 'regiane.01@yahoo.com.br')

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA CLIENTE
SELECT * FROM CLIENTE*/

--====================================================================================================================================

/*INSERIR DADOS NA TABELA FILIAL*/
INSERT FILIAL (fil_Nome, fil_CEP, fil_Numero, fil_Complemento, fil_DDD, fil_Telefone, fil_Horarios, fil_CNPJ)
	VALUES ('ADRJ2 Matriz','03634-040','1253','Centro Empresarial Manases','(11)','3996-0126','08:00hrs as 17:15hrs Seg. a sex.', '  ')

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA FILIAL*
SELECT * FROM FILIAL*/

--====================================================================================================================================

/*INSERIR DADOS NA TABELA FUNCIONARIO*/
INSERT FUNCIONARIO (fun_Nome, fun_RG, fun_CPF, fun_Data_nascimento, fun_Sexo, fun_Nome_mae,fun_Estado_civil, fun_CEP, fun_Numero, fun_Complemento, fun_Grau_escolaridade, fun_situação_escolar, fun_Nome_Escola, fun_Cursos, fun_CTPS, fun_Serie,
fun_DDD,fun_Telefone, fun_DDD2, fun_Celular, fun_Cargo, fun_Data_admissao, fun_Filial, fun_Salario, fun_Email, fun_Login, fun_Data_Dispensa, fun_Senha, fun_localhost)
	VALUES('Renato Matos dos Santos','47.638.455-2','393.295.118-21','23/07/1990','M','Tania Maria Matos',1,'06420-270','298','CASA',2,'Completo','Prof° José Wilson Padinha','T.I.','80535','00311-SP','(11)','4198-0000','(11)','7453-8922','Programador Jr.',  '01/01/1995', 1,  5000.00, 'renato.story@hotmail.co.uk', 'renato.admin', '  /  /','12523', 'ADMINISTRADOR')
INSERT FUNCIONARIO (fun_Nome, fun_RG, fun_CPF, fun_Data_nascimento, fun_Sexo, fun_Nome_mae,fun_Estado_civil, fun_CEP, fun_Numero, fun_Complemento, fun_Grau_escolaridade, fun_situação_escolar, fun_Nome_Escola, fun_Cursos, fun_CTPS, fun_Serie,
fun_DDD,fun_Telefone, fun_DDD2, fun_Celular, fun_Cargo, fun_Data_admissao, fun_Filial, fun_Salario, fun_Email, fun_Login, fun_Data_Dispensa, fun_Senha, fun_localhost)
	VALUES('Anaiara','00.000.000-0','000.000.000-00','00/00/0000','F','Nome da mae',1,'06462-000','0000','Complemento',2,'Completo','Nome da escola','T.I.','00000','00000-SP','(  )','    -    ','(  )','    -    ','Ajundante Geral',  '01/01/2010', 1, 450.00, 'e-mail', 'anaiara.002', '  /  /','12345', 'FUNCIONARIO')
INSERT FUNCIONARIO (fun_Nome, fun_RG, fun_CPF, fun_Data_nascimento, fun_Sexo, fun_Nome_mae,fun_Estado_civil, fun_CEP, fun_Numero, fun_Complemento, fun_Grau_escolaridade, fun_situação_escolar, fun_Nome_Escola, fun_Cursos, fun_CTPS, fun_Serie,
fun_DDD,fun_Telefone, fun_DDD2, fun_Celular, fun_Cargo, fun_Data_admissao, fun_Filial, fun_Salario, fun_Email, fun_Login, fun_Data_Dispensa, fun_Senha, fun_localhost)
	VALUES('Josielma Farias de Lima','00.000.000-0','062.754.824-51','01/07/1986','F','Irene de Almeida Farias',1,'06417-120','477','Casa 3',2,'Completo','Sem nome','T.I.','00000','00000-SP','(  )','   -    ','(11)','8969-9083','Financeiro',  '11/09/2004', 1, 1200.00, 'josyfharias@hotmail.com', 'jose.admin', '  /  /','123456', 'ADMINISTRADOR')
INSERT FUNCIONARIO (fun_Nome, fun_RG, fun_CPF, fun_Data_nascimento, fun_Sexo, fun_Nome_mae,fun_Estado_civil, fun_CEP, fun_Numero, fun_Complemento, fun_Grau_escolaridade, fun_situação_escolar, fun_Nome_Escola, fun_Cursos, fun_CTPS, fun_Serie,
fun_DDD,fun_Telefone, fun_DDD2, fun_Celular, fun_Cargo, fun_Data_admissao, fun_Filial, fun_Salario, fun_Email, fun_Login, fun_Data_Dispensa, fun_Senha, fun_localhost)
	VALUES('Jesner','00.000.000.00','000.000.000-02','  /  /','M','Nome da mae',1,'06462-000','0000','Complemento',2,'Completo','Nome da escola','T.I.','00000','00000-SP','(  )','    -    ','(  )','    -    ','Repositor',  '15/11/2002', 1,  800.00, '  ', 'Jesner.004', '  /  /','123456', 'FUNCIONARIO')


------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA FUNCIONARIO*
SELECT * FROM FUNCIONARIO*/




--====================================================================================================================================

/*INSERIR DADOS NA TABELA FORNECEDOR*/

INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Tagima', '005544888/448', 'Tagima', '0544887/4411', '06420-270','888','2° andar','(11)','4004-6588','05/08/2005', 'tagima@tagima.com', 'www.tagima.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Strinberg', '045894888/465', 'Strinberg', '0544887/4411', '03634-040','000','Frente Unesco','(11)','4006-8774','09/12/2008', 'strinberg@strinberg.com', 'www.strinberg.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Dijiorgio', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Fender', '78411887/487', 'Fender', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'fender@fender.com', 'www.fender.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Meteoro', '78411887/487', 'Meteoro', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'meteoro@meteoro.com.br', 'www.meteoro.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Golden', '78411887/487', 'Golden', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'golden@golden.com.br', 'www.golden.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Gibson', '78411887/487', 'Gibson', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'gibson@gibson.com', 'www.gibson.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Marshall', '005544888/448', 'Marshall', '0544887/4411', '06420-270','888','2° andar','(11)','4004-6588','05/08/2005', 'marshall@marshall.com', 'www.marshall.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Orion', '045894888/465', 'Orion', '0544887/4411', '03634-040','000','Frente Unesco','(11)','4006-8774','09/12/2008', 'orion@orion.com', 'www.orion.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Zildjan', '78411887/487', 'Zildjan', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'zildjan@zildjan.com', 'www.zildjan.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Giannini', '78411887/487', 'Giannini', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'giannini@giannini.com.br', 'www.giannini.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Epiphone', '78411887/487', 'Epiphone', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'epiphone@epiphone.com.br', 'www.epiphone.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Eagle', '78411887/487', 'Eagle', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'eagle@eagle.com.br', 'www.eagle.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Pearl', '78411887/487', 'Pearl', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'pearl@pearl.com.br', 'www.pearl.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Mapex', '005544888/448', 'Mapex', '0544887/4411', '06420-270','888','2° andar','(11)','4004-6588','05/08/2005', 'mapex@mapex.com', 'www.mapex.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Shelter', '045894888/465', 'Shelter', '0544887/4411', '03634-040','000','Frente Unesco','(11)','4006-8774','09/12/2008', 'shelter@shelter.com', 'www.shelter.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Machael', '78411887/487', 'Machael', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'machael@machael.com.br', 'www.machael.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Laney', '78411887/487', 'Laney', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'laney@laney.com.br', 'www.laney.com.br')
	
	
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Santo Angelo', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Warm Music', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Monner', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Digitech', '005544888/448', 'Tagima', '0544887/4411', '06420-270','888','2° andar','(11)','4004-6588','05/08/2005', 'tagima@tagima.com', 'www.tagima.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Nig', '045894888/465', 'Strinberg', '0544887/4411', '03634-040','000','Frente Unesco','(11)','4006-8774','09/12/2008', 'strinberg@strinberg.com', 'www.strinberg.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Cherub', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('NUX', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Condor', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Yamaha', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Boss', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')	
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Line 6', '005544888/448', 'Tagima', '0544887/4411', '06420-270','888','2° andar','(11)','4004-6588','05/08/2005', 'tagima@tagima.com', 'www.tagima.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('VOX', '045894888/465', 'Strinberg', '0544887/4411', '03634-040','000','Frente Unesco','(11)','4006-8774','09/12/2008', 'strinberg@strinberg.com', 'www.strinberg.com')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Gotoh', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('ESP', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('RMV', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Shure', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')
INSERT FORNECEDOR (forn_Nome, forn_CNPJ, forn_Nome_fantasia, forn_Inscricao_estMun, forn_CEP, forn_Numero, forn_Complemento, forn_DDD, forn_Telefone, forn_Data_cadastro, forn_Email, forn_Site)
	VALUES ('Ibanez', '78411887/487', 'Digiorgio', '0544887/4411', '03634-040', '000', '3° Andar', '(11)', '4008-8447', '03/01/2003', 'digiorgio@digiorgio.com.br', 'www.digiorgio.com.br')	
	
	
	
	
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA FORNECEDOR
SELECT * FROM FORNECEDOR*/

--====================================================================================================================================

/*iNSERIR DADOS NA TABELA PRODUTO*/

/*Guitarras*/
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('LesPaul',1,'4488877411189877411448877', 1, '645.89', '900.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('VG Stratocaster',1,'4488877411189877411448877', 4, '2500.99',  '4100.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES(' EGT 61',1,'4488877411189877411448877', 13,  '500.00',  '650.59', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('American Vintage "52 Telecaster',1,'46546546849877868735', 4,  '1249.00', '1957.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Steve Ray Vauglan Stratocaster',1,'4488877411189877411448877', 4,  '3250.50',  '5270.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('NA American Telecaster',1,'4488877411189877411448877', 4, '2000.00', '2700.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('American Vintage "62 Jaguar',1,'4488877411189877411448877', 4, '12000.00', '12200.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('California Standard',1,'4488877411189877411448877', 16, '999.00',  '1200.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('California Flame Maple',1,'4488877411189877411448877', 16, '999.00',  '1350.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('California Surf',1,'4488877411189877411448877', 16, '765.00', '955.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Nashville 301',1,'4488877411189877411448877', 16, '1500.00', '2600.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('California Falcon',1,'4488877411189877411448877', 16, '1372.00', '3890.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('California Special',1,'4488877411189877411448877', 16, '730.00',  '878.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('LesPaul StandardFaded',1,'4488877411189877411448877', 7, '3400.00', '6211.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('LesPaul Classic',1,'4488877411189877411448877', 7, '10000.00', '12000.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('LesPaul Studio Chrome',1,'4488877411189877411448877', 1, '4300.00', '5550.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('LesPaul Standard',1,'4488877411189877411448877', 1, '2250.00', '3800.00', '15')

/*Bass*/
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Marcus Miller Jazz Bass', 17,'4488877411189877411448877', 4, '3100.00', '3900.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Reggle Hamilton Jazz Bass', 17,'4488877411189877411448877', 4, '8100.00', '8500.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Geddy Lee Jazz Bass', 17,'4488877411189877411448877', 4, '8100.00', '8500.00', '15')
	
/*Amplificadores*/
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('"65 Twin Reverb', 15,'4488877411189877411448877', 4, '1500.00', '1800.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Blues Deluxe', 15,'4488877411189877411448877', 4, '800.00', '950.00', '15')	
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('"59 Bassman LTD',16,'4488877411189877411448877', 4, '7590.00', '8250.00', '15')
INSERT	PRODUTO (pro_Nome_produto, pro_Cod_Categoria, pro_Cod_barras, pro_Fornecedor, pro_Preco_custo, pro_Valor, pro_Quantidade)
	VALUES('Hot Rod Deluxe Blonde',15,'4488877411189877411448877', 4, '3990.00', '4200.00', '15')


	
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA PRODUTO
SELECT * FROM PRODUTO*/

--====================================================================================================================================

/*iNSERIR DADOS NA TABELA COMPRA*/
INSERT FORMA_PAGAMENTO (fp_Descricao_pagamento)
	VALUES('Dinheiro')
INSERT FORMA_PAGAMENTO (fp_Descricao_pagamento)
	VALUES('Cheque')
INSERT FORMA_PAGAMENTO (fp_Descricao_pagamento)
	VALUES('Cartão')
INSERT FORMA_PAGAMENTO (fp_Descricao_pagamento)
	VALUES('Carne')
INSERT FORMA_PAGAMENTO (fp_Descricao_pagamento)
	VALUES(' ')

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA VENDA
SELECT * FROM FORMA_PAGAMENTO*/

--====================================================================================================================================

/*iNSERIR DADOS NA TABELA VENDA*/
INSERT VENDA (vnd_Cod_cliente, vnd_Cod_funcionario, vnd_Cod_loja, vnd_Data_Venda, vnd_Parcela, vnd_Total, vnd_Tipo_Pagamento, vnd_Cod_PAGAMENTO)
	VALUES (1, 1, 1, '19/04/2009', '8', '23800.00', 'P', 3)
INSERT VENDA (vnd_Cod_cliente, vnd_Cod_funcionario, vnd_Cod_loja, vnd_Data_Venda, vnd_Parcela, vnd_Total, vnd_Tipo_Pagamento, vnd_Cod_PAGAMENTO)
	VALUES (1, 1, 1, '19/04/2009', '8', 23800.00, 'V', 3)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA VENDA
SELECT * FROM venda*/

--====================================================================================================================================


/*iNSERIR DADOS NA TABELA DETALHAMENTO_VENDA*/
INSERT DETALHAMENTO_VENDA (dv_Cod_Produto, dv_Quantidade, dv_Subtotal, dv_Cod_Venda)
	VALUES (1, '1', '900.00', 1)

------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*EXIBE TABELA DETALHAMENTO_VENDA
SELECT * FROM DETALHAMENTO_VENDA*/



--====================================================================================================================================