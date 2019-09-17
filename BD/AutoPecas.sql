create database T_AutoPecas

use T_AutoPecas

create table Pecas
(
	IdPeca int primary key identity
	,CodigoDaPeca varchar (20) not null unique 
	,Descricao varchar (255) not null 
	,Peso decimal 
	,PreçoDoCusto money
	,PreçoDaVenda money
	,IdFornecedor int foreign key references Fornecedores (IdFornecedor) 
);

create table Fornecedores 
(
	IdFornecedor int primary key identity
	,CNPJ varchar (18) not null unique
	,RazaoSocial varchar (255) not null
	,NomeFantasia varchar (255) not null
	,Endereco varchar (255) not null unique
	,IdUsuario int foreign key references Usuarios (IdUsuario)
);

create table Usuarios
(
	IdUsuario int primary key identity
	,Email varchar(255) not null unique
	,Senha varchar (30) not null
	,Permissao varchar (255) not null
);

insert into Usuarios (Email, Senha, Permissao) values ('admin@gmail.com', '123456', 'ADMINISTRADOR')
										      ,('comum@gmail.com', '654321', 'COMUM');
select * from Usuarios

insert into Fornecedores (CNPJ, RazaoSocial, NomeFantasia, Endereco, IdUsuario) values ('58.797.484/0001-21','Homegrown Rise','Homegrown','Rua Dona Olga, 555',1)
																					  ,('12.122.516/0001-98','Kit Planner','Kit','Rua Brejo de São João, 503',2);
select * from Fornecedores

insert into Pecas (CodigoDaPeca, Descricao, Peso, PreçoDoCusto, PreçoDaVenda, IdFornecedor) values ('463-673jY','Feita a mão por um Esquimó da Malaia que tem Malaia','10.27','1.000','1500',2)
																								,('726-941rG','Todas as sextas tem damas da noite','52.00','500','1000',1);
select * from Pecas
