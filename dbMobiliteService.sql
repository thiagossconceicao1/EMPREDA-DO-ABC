drop database dbMobiliteService;

create database dbMobiliteService;

use dbMobiliteService;

create table tbFuncionarios(
codfunc int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10) default 'Feminino' check(sexo in('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
primary key(codFunc));

create table tbusuarios(
codUsu int not null auto_increment,
nomeUsu varchar(20) not null,
senhaUsu varchar(20) not null,
codfunc int not null,
primary key(codUsu),
foreign key(codfunc) references tbfuncionarios(codfunc));


create table tbClientes(
codCli int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10) default 'Feminino' check(sexo in('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
codUsu int not null,
primary key(codCli),
foreign key(codUsu) references tbusuarios(codusu));



insert into tbusuarios(nomeUsu, senhaUsu, codfunc)values('admin','admin@admin',1);

select * from tbusuarios where nomeUsu = '' and senhaUsu = '';






-- insert into tbClientes (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)
-- values(nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado);


-- busca por codigo

select * from tbClientes where codCli = 1;

-- busca por nome

select * from tbClientes where nome like '%s%';

select * from tbClientes where nome = 'Senac Largo Treze';

-- alterar tbclientes

-- update tbClientes set nome = '',email = '',cpf = '',telefone = '', sexo = '', endereco = '', numero = '',cep = '', bairro = '', cidade = '', estado = '' where codCli = 1;

-- excluir clientes

delete from tbClientes where codCli = 1;


insert into tbFuncionarios (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)" +
                "values(@nome,@email,@cpf,@telefone,@sexo,@endereco,@numero,@cep,@bairro,@cidade,@estado);


select codfunc as 'Código',nome as 'Nome',email as 'E-mail',
    cpf as 'CPF',telefone as 'Telefone',sexo as 'Sexo',
    endereco as 'Endereço',numero as 'Número',cep as 'CEP',
        bairro as 'Bairro',cidade as 'Cidade',estado as 'Estado'
    from tbfuncionarios;
