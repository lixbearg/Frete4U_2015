create table tb_cd_prestador
(
 cod_prestador int identity primary key,
 Id nvarchar (128) NOT NULL,
 nome varchar(255),
 nomeEmpresa varchar(255),
 CPF numeric(11),
 CNPJ numeric(14),
 logradouro varchar(255),
 numeroEndereco numeric(15),
 bairro varchar(255),
 complemento varchar(255),
 cod_cidade numeric(10),
 cod_estado numeric(2),
 constraint fk_prestador_aspuser foreign key(Id) references AspNetUsers
)

create table tb_cd_tipo_entrega
(
	 cod_entrega int identity primary key,
	 descricao varchar(100),
)

create table tb_cd_transporte
(
   cod_transporte int identity,
   descricao varchar(100),
   cod_entrega int,
   constraint pk_transporte primary key(cod_transporte,cod_entrega),
   constraint fk_transporte_entrega foreign key(cod_entrega) references tb_cd_tipo_entrega(cod_entrega),
)

create table tb_cd_prestador_transporte
(
  cod_prestador int,
  cod_entrega int,
  constraint pk_prestador_transporte primary key(cod_prestador,cod_entrega),
  constraint fk_prestador_transporte_prestador foreign key(cod_prestador) references tb_cd_prestador(cod_prestador),
   constraint fk_prestador_transporte_entrega foreign key(cod_entrega) references tb_cd_tipo_entrega(cod_entrega)
)

create table tb_cd_estados
(
	 cod_estado numeric(2) identity primary key,
	 nom_estado varchar(100),
	 uf char(2)
)

create table tb_cd_cidades
(
	 cod_cidade numeric(10) identity primary key,
	 nom_cidade varchar(100),
	 cod_estado numeric(2),
	 constraint fk_cd_cidades foreign key(cod_estado) references tb_cd_estados(cod_estado),
)

create table tb_atendimento_prestador
(
  cod_prestador int,
  cod_cidade numeric(10),
  constraint pk_atendimento_prestador primary key(cod_prestador,cod_cidade),
  constraint fk_atendimento_prestador foreign key(cod_prestador) references tb_cd_prestador(cod_prestador),
  constraint fk_atendimento_cod_cidade foreign key(cod_cidade) references tb_cd_cidades(cod_cidade)
)