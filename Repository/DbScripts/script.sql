create table Comum(
  Cod_Comum integer not null primary key identity,
  Nome varchar(60),
  Cidade varchar(40),
  Estado varchar(2),
  Endereco varchar(400),
  Capacidade int,
  DiasCultro varchar(200),
  DiasRJM varchar(200),
  DiasGEM varchar(200)
);

create table Categoria(
    Cod_Categoria  integer not null primary key identity,
    Nome varchar(40)
);

insert into Categoria (Nome) values('Cordas');
insert into Categoria (Nome) values('Madeiras');
insert into Categoria (Nome) values('Metais');

create table Instrumento(
    Cod_Instrumento  integer not null primary key identity,
    Nome varchar(60),
    Afinacao varchar(20),
    Principal varchar(20),
    Alternativa varchar(20),
    Cod_Categoria integer,
    constraint fk_Instrumento_Categoria foreign key (Cod_Categoria) references Categoria(Cod_Categoria)
);

insert into Instrumento (Nome, Cod_Categoria) values ('Violino', 1);
insert into Instrumento (Nome, Cod_Categoria) values ('Viola', 1);
insert into Instrumento (Nome, Cod_Categoria) values ('Violoncelo', 1);

insert into Instrumento (Nome, Cod_Categoria) values ('Flauta', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Oboe', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Oboe D'' Amore', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Corne Inglês', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Fagote', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Clarinete', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Clarinete Alto', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Clarinete Baixo', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Sax Soprano', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Sax Alto', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Sax Tenor', 2);
insert into Instrumento (Nome, Cod_Categoria) values ('Sax Barítono', 2);

insert into Instrumento (Nome, Cod_Categoria) values ('Trompete', 3);
insert into Instrumento (Nome, Cod_Categoria) values ('Flugelhorn', 3);
insert into Instrumento (Nome, Cod_Categoria) values ('Trompa', 3);
insert into Instrumento (Nome, Cod_Categoria) values ('Trombone', 3);
insert into Instrumento (Nome, Cod_Categoria) values ('Eufônio', 3);
insert into Instrumento (Nome, Cod_Categoria) values ('Tuba', 3);

create table Grupo(
  Cod_Grupo integer not null primary key identity,
  Nome varchar(60),
  Cod_Comum integer,
  constraint fk_Grupo_Comum foreign key (Cod_Comum) references Comum(Cod_Comum)
);

create table Usuario(
    Cod_Usuario integer not null primary key identity,
    Nome varchar(60),
    Email varchar(200),
    Senha varchar(60),
    Telefone varchar(20),
    Endereco varchar(400),
    Aluno bit,
    Instrutor bit,
    Oficializado bit,
    Admin bit,
    Dev bit,
    RJM bit,
    Ativo bit,
    Cod_Instrumento integer,
    Cod_Grupo integer,
    Cod_Comum integer,
    RecuperarSenha varchar(60),
    Token varchar(60),
    AvisoLido integer,
    Observacao varchar(400),
    constraint fk_Usuario_Comum foreign key (Cod_Comum) references Comum(Cod_Comum),
    constraint fk_Usuario_Instrumento foreign key (Cod_Instrumento) references Instrumento(Cod_Instrumento)
);

create table Presenca(
    Cod_Presenca integer not null primary key identity,
    Cod_Usuario integer,
    Data DateTime,
    Instrutor integer,
    constraint fk_Presenca_Usuario foreign key (Cod_Usuario) references Usuario(Cod_Usuario),
    constraint fk_Presenca_Instrutor foreign key (Instrutor) references Usuario(Cod_Usuario)
);

create table TipoEstudo(
    Cod_Tipo integer not null primary key identity,
    Nome varchar(40),
    Controle varchar(20)
);

insert into TipoEstudo(Nome) values('MTS');
insert into TipoEstudo(Nome) values('Metodo');
insert into TipoEstudo(Nome) values('Hinos');
insert into TipoEstudo(Nome) values('Prova');

create table Estudo(
    Cod_Estudo integer not null primary key identity,
    Cod_Presenca integer,
    Cod_Tipo integer,
    Numero integer,
    Observacao varchar(200),
    Instrutor integer,
    constraint fk_Estudo_Tipo foreign key (Cod_Tipo) references TipoEstudo(Cod_Tipo),
    constraint fk_Estudo_Presenca foreign key (Cod_Presenca) references Presenca(Cod_Presenca),
    constraint fk_Estudo_Instrutor foreign key (Instrutor) references Usuario(Cod_Usuario)
);

create table FaltaJustificada(
  Cod_Justificativa integer not null primary key identity,
  Cod_Usuario integer,
  Instrutor integer,
  Data datetime,
  Justificativa varchar(200),
  constraint fk_Falta_Usuario foreign key (Cod_Usuario) references Usuario (Cod_Usuario),  
  constraint fk_Falta_Instrutor foreign key (Instrutor) references Usuario (Cod_Usuario)
);

create table Aviso(
    Cod_Aviso integer not null primary key identity,
    Cod_Usuario integer,
    Cod_Comum int,
    Nome Varchar(60),
    Mensagem text,
    Aluno bit,
    Instrutor bit,
    Oficializado bit,
    RJM bit,
    constraint fk_Aviso_Usuario foreign key (Cod_Usuario) references Usuario (Cod_Usuario),
    constraint fk_Aviso_Comum foreign key(Cod_Comum) references Comum (Cod_Comum)  
);

create table Arquivo(
    Cod_Arquivo integer not null primary key identity,
    Cod_Usuario integer,
    Cod_Comum int,
    Nome Varchar(60),
    Url varchar(400),
    Aluno bit,
    Instrutor bit,
    Oficializado bit,
    RJM bit,
    constraint fk_Arquivo_Usuario foreign key (Cod_Usuario) references Usuario (Cod_Usuario),
    constraint fk_Arquivo_Comum foreign key(Cod_Comum) references Comum (Cod_Comum)
);

create table Escala(
    Cod_Escala integer not null primary key identity,
    Cod_Usuario integer,
    Cod_Comum int,
    Usuarios text,
    Inicio datetime,
    Fim datetime,
    Dias varchar(200),
    Dupla bit,
    DiaSequencial bit,
    constraint fk_Escala_Usuario foreign key (Cod_Usuario) references Usuario (Cod_Usuario),
    constraint fk_Escala_Comum foreign key(Cod_Comum) references Comum (Cod_Comum)
);

create table Monitor(
  Id integer not null primary key identity,
  Data datetime,
  Cod_Usuario integer,
  Operacao char(1),
  Tabela varchar(20),
  Descricao varchar(200),
  Cod_Comum integer,
  constraint fk_Monitor_Usuario foreign key (Cod_Usuario) references Usuario (Cod_Usuario),
  constraint fk_Monitor_Comum foreign key (Cod_Comum) references Comum (Cod_Comum)
);

create table UsuarioGrupo(
  Id integer not null primary key identity,
  Cod_Usuario integer,
  Cod_Grupo integer,
  constraint fk_UsuarioGrupo_Usuario foreign key (Cod_Usuario) references Usuario(Cod_Usuario),
  constraint fk_UsuarioGrupo_Grupo foreign key (Cod_Grupo) references Grupo(Cod_Grupo)
);

/*
delete from UsuarioGrupo;
insert into UsuarioGrupo(Cod_Usuario, Cod_Grupo)
select Cod_Usuario, Cod_Grupo from Usuario
where Cod_Grupo is not null;
*/