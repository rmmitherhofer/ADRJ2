USE ADRJ2
DROP DATABASE ADRJ2
====================================================================================================================================
/*EXIBIR TABELAS COMPLETAS*/
SELECT * FROM ESTADO_CIVIL ORDER BY ec_descricao_estado_civil
SELECT * FROM ENDERECO
SELECT * FROM ESCOLARIDADE
SELECT * FROM DDD ORDER BY d_estado
SELECT * FROM CATEGORIA ORDER BY cat_descricao

SELECT * FROM CLIENTE
SELECT * FROM FUNCIONARIO
SELECT * FROM FILIAL
SELECT * FROM FORNECEDOR 
SELECT * FROM PRODUTO 
SELECT * FROM VENDA
SELECT * FROM DETALHAMENTO_VENDA
SELECT * FROM FORMA_PAGAMENTO

select fp_cod_pagamento from FORMA_PAGAMENTO where fp_Descricao_pagamento = 


------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*FORMAS DE CONSULTAR DADOS EM EXPECIFICO DAS TABELAS*/

/*CONSULTA DADOS QUE COMECAO COM A LETRA INDICADA*/
SELECT * FROM CLIENTE 
	WHERE Nome like 'e%'
	
/*CONSULTA DADOS QUE TERMINEM COM A LETRA INDICADA*/
SELECT * FROM CLIENTE 
	WHERE cl_Nome like '%R'
	
/*CONSULTA DADOS QUE TENHAM A LETRA INDICADA EM QUALQUER CANTO*/
SELECT * FROM CLIENTE 
	WHERE cl_Nome like '%e%'
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*consulta o menor valor do campo valor da tabela produto*/
	select min (pro_valor) as menor_valor from produto
	
/*consulta o maior valor do campo valor da tabela produto*/
	select max (valor) as maior_valor from produto
	
/*consulta a media (soma de todos os valores divididos pela quantidade de linhas)do campo valor da tabela*/
	select avg (valor) as media_valor from produto
	
	select sum (dv_subtotal) as media_valor from detalhamento_venda where dv_cod_venda = 1
	

====================================================================================================================================

/*DROPAR TABELAS COMPLETAS*/

DROP TABLE ESTADO_CIVIL
DROP TABLE ENDERECO
DROP TABLE ESCOLARIDADE
DROP TABLE DDD
DROP TABLE CATEGORIA
DROP TABLE CLIENTE
DROP TABLE FUNCIONARIOS
DROP TABLE FILIAL
DROP TABLE FORNECEDOR
DROP TABLE PRODUTO
DROP TABLE VENDA
DROP TABLE DETALHAMENTO_VENDA
DROP TABLE FORMA_PAGAMENTO

------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*APAGAR CHAVE ESTRANGEIRA E CHECK DAS TABELAS*/
-- ex: ALTER TABLE <NOME DA TABELA> DROP CONSTRAINT <NOME DA CHAVE OU CHECK>

ALTER TABLE venda alter column vnd_Tipo_Pagamento CHAR (1) CONSTRAINT CK_PAGAMENTO CHECK (fp_Tipo_Pagamento = 'V' or fp_Tipo_Pagamento= 'P') NOT NULL
ALTER TABLE Produto alter column pro_preco_custo varchar  (14)not null 
ALTER TABLE funcionario add fun_localhost Varchar (13) CONSTRAINT CK_localHost CHECK (fun_localhost = 'ADMINISTRADOR' or fun_localhost= 'FUNCIONARIO')
ALTER TABLE FORNECEDOR DROP CONSTRAINT 
ALTER TABLE forma_pagamento DROP CONSTRAINT CK_PAGAMENTO
alter table forma_pagamento drop column fp_Tipo_Pagamento

------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*APAGA TODOS OS DADOS DA TABELA*/

DELETE TABLE ENDERECO

====================================================================================================================================

/*ATUALIZAR DADOS
Ex: UPDATE [NOME DA TABELA] SET  [NOME DA COLUNA] = [DADO]
	WHERE [COLUNA] = [CODIGO PK]*/
	
UPDATE Estado_civil SET ec_Descricao_estado_civil = 'DIVORCIADO(A)'
	where ec_Cod_Estado_civil = 3
UPDATE CLIENTE SET NOME = 'Fabiana'
	where Cod_cliente = 4
UPDATE CLIENTE SET NOME = 'Jurema'
	where Cod_cliente = 9
UPDATE CLIENTE SET NOME = 'Maria'
	where Cod_cliente = 77
UPDATE CLIENTE SET NOME = 'Rubia'
	where Cod_cliente = 8
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*ATUALIZA COLUNA INTEIRA COM DADO SUJERIDO*/
--UPDATE [NOME DA TABELA] SET [NOME DA COLUNA] = [DADO DESEJADO]

UPDATE DDD SET DDD = '11'


 SELECT cl_Cod_cliente, cl_CPF fROM CLIENTE
 WHERE cl_CPF like '% strDescricao %'
 
 /*Endereco*/
 select endereco.*, cliente.cl_CEP from cliente inner join endereco on cliente.cl_CEP = endereco.end_Cep where endereco.end_CEP ='06420-270'
 
/* EstadoCivil Cliente*/
 select Estado_Civil.EC_DESCRICAO_ESTADO_CIVIL, CLIENTE.cl_estado_civil from CLIENTE inner join ESTADO_CIVIL ON CLIENTE.cl_Estado_civil = ESTADO_CIVIL.ec_Cod_estado_Civil where ec_Descricao_Estado_civil = 'SOLTEIRO(A)'

--Categoria Produto
select Categoria.cat_Descricao, Produto.pro_Cod_categoria from produto inner join categoria on produto.pro_cod_categoria = categoria.cat_cod_categoria where cat_descricao ='guitarra'
  
  
  --fORNECEDOR/PRODUTO
select fornecedor.forn_Nome, Produto.pro_Fornecedor from produto inner join fornecedor on produto.pro_fornecedor = fornecedor.forn_cod_fornecedor where forn_Nome_fantasia = 'tagima'
 
 --PRODUTO/CATEGORIA/FORNECEDOR
 
 SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO 
  inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria 
  inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor 
  WHERE CATEGORIA.cat_Descricao like	'%%' 
  
  
  --
  SELECT	VENDA.vnd_Cod_venda, detalhamento_venda.dv_Cod_Produto, Detalhamento_venda.dv_Quantidade,  Detalhamento_venda.dv_Subtotal, venda.vnd_Data_venda, forma_pagamento.fp_descricao_pagamento, venda.vnd_Parcela, venda.vnd_total, venda.vnd_Cod_cliente from venda  
  inner join Detalhamento_venda on venda.vnd_Cod_Cupom  = detalhamento_venda.dv_Cupom
  inner join forma_pagamento on venda.vnd_Cod_Pagamento = forma_pagamento.fp_Cod_pagamento
  where  venda.vnd_Data_venda = '19/04/2009'
  
  -- inner join produto on detalhamento_venda.dv_Cod_produto = Produto.pro_cod_produto
  
  select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda,  vnd_cod_loja, venda.vnd_cod_funcionario, venda.vnd_Cod_venda from detalhamento_venda
  inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto
  inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda
  where  venda.vnd_Data_venda like '%%'
  
  
  ---somar tabela 
  select sum (dv_subtotal) as Total from Detalhamento_venda
  inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda
  where venda.vnd_cod_cliente = 1
  
  select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, venda.vnd_Tipo_Pagamento, venda.vnd_parcela, Detalhamento_venda.dv_Quantidade, detalhamento_venda.dv_Valor_Parcela, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda, vnd_cod_loja, venda.vnd_cod_funcionario, venda.vnd_Cod_venda, venda.vnd_Cod_funcionario from venda, detalhamento venda 
  inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto
  inner join Detalhamento_venda on venda.vnd_Cod_Cupom = Detalhamento_venda.dv_cupom
  where  venda.vnd_Data_venda like '%19/04/2009%'
  
  
  
  select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal from detalhamento_venda 
  inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto
  inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda
 Where Dv_cod_venda = 1
 
 select fun_cod_funcionario, fun_senha, fun_localHost, fun_login from funcionario where fun_login = 'renato.admin'
 
 
 select pro_quantidade from produto where pro_cod_produto = 2
  
select fun_senha from funcionario where fun_senha = 12523
select detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, venda.vnd_Tipo_Pagamento, venda.vnd_parcela, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda,  vnd_cod_loja, venda.vnd_Cod_venda, venda.vnd_Cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda 
where venda.vnd_cOD_vENDA = 3
  

  
  select vnd_cod_cliente from venda
  where vnd_Cod_cliente,  = 3
 
 select produto.c
 SELECT * FROM PRODUTO WHERE PRODUTO.pro_Nome_produto like '%%'
 
 
 select * from cliente where cl_numero ='298'
 select * from cliente where cl_nome like '%re%'
 select * from funcionario
 select * from detalhamento_venda
 select * from venda
 
 select * from forma_pagamento
 select vnd_Cod_venda from Venda where vnd_Data_Venda = '16/06/2010 19:14:08'
 
 
 select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda
 where Detalhamento_venda.dv_Cod_Venda = 3
        strQuery.Append(" ORDER BY dv_cupom ")
        
          select PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, dv_cod_venda, vnd_data_venda, vnd_Parcela, vnd_total, vnd_tipo_pagamento, vnd_cod_loja, vnd_cod_funcionario from detalhamento_venda 
  inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto
  inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda
 Where Dv_cupom = 1
        
select Produto.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, Detalhamento_venda.dv_cod_venda, venda.vnd_data_venda, venda.vnd_Parcela, venda.vnd_total, venda.vnd_tipo_pagamento, venda.vnd_cod_loja, venda.vnd_cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda Where dv_Cupom = 2
 
 select PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, dv_cod_venda, vnd_data_venda, vnd_Parcela, vnd_total, vnd_tipo_pagamento, vnd_cod_loja, vnd_cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda Where dv_Cupom = 1  



CREATE DATABASE TESTE
USE TESTE
CREATE TABLE TESTE
(
VALOR double (5)
)
INSERT TESTE
VALUES (22544.58) 
SELECT * FROM TESTE
drop table teste





select Produto.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, Detalhamento_venda.dv_cod_venda, venda.vnd_data_venda, venda.vnd_Parcela, venda.vnd_total, venda.vnd_tipo_pagamento, venda.vnd_cod_loja, venda.vnd_cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda Where dv_Cupom = 2
select fun_nome, fil_nome, fp_descricao_pagamento from venda inner join funcionario on vnd_cod_funcionario = fun_cod_funcionario inner join filial on vnd_cod_loja = fil_cod_filial inner join forma_pagamento on  vnd_cod_pagamento = fp_cod_pagamento where vnd_cod_venda =2


select categoria.cat_descricao, categoria.cat_cod_categoria, fornecedor.forn_cod_fornecedor, fornecedor.forn_nome from Produto
inner join categoria on produto.pro_cod_categoria = categoria.cat_cod_categoria
inner join fornecedor on produto.pro_fornecedor = fornecedor.forn_cod_fornecedor
where produto.pro_nome_produto = 'LesPaul'

select cat_cod_categoria from categoria where cat_descricao = 'guitarra'

select forn_cod_fornecedor from fornecedor where forn_nome = 'tagima'


select * from filial
select es_cod_Escolaridade from escolaridade where es_escolaridade = 

select es_escolaridade from escolaridade where es_cod_Escolaridade  = 

select ec_cod_estado_civil from fornecedor where ec_descricao_estado_civil = 

select ec_descricao_estado_civil from fornecedor where ec_cod_estado_civil  = 

select fil_cod_filial from filial where fil_nome =

