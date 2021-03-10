create table Funcionario(
	Id					integer			identity(1,1),
	Nome				nvarchar(150)	not null,
	Cpf					nvarchar(15)	not null,
	DataAdmissao		date			not null,
	TipoContratacao		integer			not null,
	primary key(Id),
	check(TipoContratacao in(1,2,3))

)