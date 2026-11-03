# Arquitetura da Solução

## Usuarios

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada usuário (PK). |
| NomeCompleto | VARCHAR(150) | Armazenar o nome completo do usuário. |
| Email | VARCHAR(180) | Armazenar o e-mail do usuário (único). |
| SenhaHash | VARCHAR(255) | Armazenar a senha do usuário em formato de hash. |
| RegistroEscoteiro | VARCHAR(50) | Armazenar o número de registro escoteiro. |
| Ramo | VARCHAR(50) | Identificar o ramo escoteiro do usuário. |
| Rating | INT | Armazenar a pontuação atual do usuário no sistema Elo. |
| Papel | VARCHAR(20) | Identificar o tipo de usuário (Aluno ou Administrador). |
| DataCadastro | DATETIME | Registrar a data e hora de criação da conta. |
| Ativo | BOOLEAN | Indicar se a conta está ativa. |

## Classes

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada turma (PK). |
| Nome | VARCHAR(100) | Armazenar o nome da turma. |
| Descricao | VARCHAR(500) | Armazenar uma descrição da turma. |
| CapacidadeMaxima | INT | Definir a quantidade máxima de alunos matriculados. |
| DiaDaSemana | VARCHAR(20) | Informar o dia da semana em que a turma acontece. |
| HorarioInicio | TIME | Armazenar o horário de início das aulas. |
| HorarioTermino | TIME | Armazenar o horário de término das aulas. |
| InstrutorId | INT | Identificar o instrutor responsável pela turma (FK Users). |
| Ativa | BOOLEAN | Indicar se a turma está ativa. |

## ClassEnrollments

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada matrícula (PK). |
| UsuarioId | INT | Identificar o aluno vinculado à matrícula (FK Users). |
| TurmaId | INT | Identificar a turma na qual o aluno deseja ingressar (FK Classes). |
| Status | VARCHAR(20) | Indicar a situação da matrícula (Matriculado, Aguardando ou Cancelado). |
| DataSolicitacao | DATETIME | Registrar a data e hora da solicitação de matrícula. |
| DataAtualizacao | DATETIME | Registrar a data e hora da última atualização da matrícula. |

## Eventos

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada evento (PK). |
| Titulo | VARCHAR(150) | Armazenar o título do evento. |
| Descricao | VARCHAR(1000) | Armazenar a descrição e informações do evento. |
| Tipo | VARCHAR(30) | Identificar o tipo de evento (Torneio, Simultânea, Estudo ou Outro). |
| DataHoraInicio | DATETIME | Armazenar a data e hora de início do evento. |
| DataHoraTermino | DATETIME | Armazenar a data e hora de término do evento. |
| Local | VARCHAR(200) | Informar o local onde o evento será realizado. |
| LimiteParticipantes | INT | Definir a quantidade máxima de participantes. |
| PrazoInscricao | DATETIME | Definir a data e hora limite para inscrições. |
| Status | VARCHAR(20) | Indicar a situação do evento (Agendado, Cancelado ou Encerrado). |
| ContabilizaRating | BOOLEAN | Indicar se as partidas do evento contabilizam para o rating Elo. |
| RitmoDeJogo | VARCHAR(50) | Armazenar o ritmo de jogo utilizado, quando aplicável. |
| NumeroDeRodadas | INT | Armazenar a quantidade de rodadas, quando aplicável. |
| SistemaEmparceiramento | VARCHAR(50) | Armazenar o sistema de emparceiramento, quando aplicável. |
| CriadoPorId | INT | Identificar o administrador que criou o evento (FK Users). |
| DataCriacao | DATETIME | Registrar a data e hora de criação do evento. |

## EventRegistros

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada inscrição (PK). |
| UsuarioId | INT | Identificar o usuário inscrito no evento (FK Users). |
| EventoId | INT | Identificar o evento no qual o usuário se inscreveu (FK Events). |
| Status | VARCHAR(20) | Indicar a situação da inscrição (Inscrito ou Cancelado). |
| DataInscricao | DATETIME | Registrar a data e hora da inscrição. |
| DataAtualizacao | DATETIME | Registrar a data e hora da última atualização da inscrição. |

## Partidas

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada partida (PK). |
| JogadorBrancasId | INT | Identificar o jogador que utiliza as peças brancas (FK Users). |
| JogadorPretasId | INT | Identificar o jogador que utiliza as peças pretas (FK Users). |
| EventoId | INT | Identificar o evento relacionado à partida (FK Events, opcional). |
| DataPartida | DATETIME | Registrar a data e hora em que a partida aconteceu. |
| Resultado | VARCHAR(20) | Armazenar o resultado da partida (Vitória das Brancas, Vitória das Pretas ou Empate). |
| RegistradoPorId | INT | Identificar o administrador responsável pelo registro da partida (FK Users). |
| ContabilizadaNoRating | BOOLEAN | Indicar se a partida já foi contabilizada no rating dos jogadores. |

## HistoricoRating

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada registro de histórico de rating (PK). |
| UsuarioId | INT | Identificar o usuário cujo rating foi alterado (FK Users). |
| PartidaId | INT | Identificar a partida responsável pela alteração do rating (FK Matches). |
| RatingAnterior | INT | Armazenar a pontuação do usuário antes da partida. |
| Variacao | INT | Armazenar a quantidade de pontos ganhos ou perdidos. |
| RatingPosterior | INT | Armazenar a pontuação do usuário após a partida. |
| DataRegistro | DATETIME | Registrar a data e hora da alteração do rating. |

##EventImagens

| Nome | Tipo | Para |
|---|---|---|
| Id | INT | Identificar unicamente cada imagem (PK). |
| EventoId | INT | Identificar o evento ao qual a imagem pertence (FK Events). |
| NomeArquivo | VARCHAR(255) | Armazenar o nome do arquivo da imagem. |
| CaminhoArquivo | VARCHAR(500) | Armazenar o caminho ou endereço onde a imagem está salva. |
| TipoArquivo | VARCHAR(100) | Armazenar o formato da imagem (JPEG, PNG etc.). |
| TamanhoBytes | BIGINT | Armazenar o tamanho do arquivo em bytes. |
| EnviadoPorId | INT | Identificar o usuário responsável pelo envio da imagem (FK Users). |
| DataEnvio | DATETIME | Registrar a data e hora do envio da imagem. |

## Tecnologias Utilizadas

O sistema será desenvolvido utilizando tecnologias modernas para construção de aplicações web, priorizando organização, segurança, manutenção e facilidade de expansão.

### Backend
- **C#**: Linguagem utilizada no desenvolvimento da API.
- **ASP.NET Core**: Framework responsável pela construção da API REST.
- **Entity Framework Core**: ORM utilizado para comunicação com o banco de dados e gerenciamento das migrations.
- **MySQL**: Sistema gerenciador de banco de dados relacional.
- **JWT (JSON Web Token)**: Tecnologia utilizada para autenticação e autorização dos usuários.
- **Swagger / OpenAPI**: Ferramenta para documentação e testes dos endpoints da API.
- **xUnit**: Framework utilizado para desenvolvimento de testes automatizados.

### Frontend
- **JavaScript**: Linguagem utilizada no desenvolvimento da interface.
- **React**: Biblioteca utilizada para construção da interface e gerenciamento dos componentes.
- **HTML5 e CSS3**: Tecnologias utilizadas para estruturação e estilização das páginas.

### Infraestrutura e ferramentas
- **Docker**: Utilizado para containerização e padronização do ambiente de desenvolvimento e execução.
- **Git**: Ferramenta de controle de versão.
- **GitHub**: Plataforma utilizada para hospedagem do código-fonte e gerenciamento do repositório.
- **Visual Studio**: IDE utilizada no desenvolvimento do backend.
- **Visual Studio Code**: Editor utilizado no desenvolvimento do frontend.

### Comunicação entre as tecnologias

A aplicação seguirá uma arquitetura cliente-servidor. O frontend será responsável pela interação com os usuários, enquanto o backend processará as requisições, aplicará as regras de negócio e realizará a comunicação com o banco de dados.

O fluxo de comunicação ocorrerá da seguinte maneira:

1. O usuário acessa a aplicação pelo navegador.
2. O frontend desenvolvido em React apresenta a interface e recebe as ações do usuário.
3. O frontend envia requisições HTTP para a API REST desenvolvida em ASP.NET Core.
4. A API valida a requisição, autentica o usuário quando necessário e executa as regras de negócio.
5. O Entity Framework Core realiza as operações necessárias no banco de dados MySQL.
6. A API retorna uma resposta HTTP, geralmente em formato JSON.
7. O frontend recebe a resposta e atualiza as informações apresentadas ao usuário.

## Hospedagem

A hospedagem da plataforma será realizada em ambiente de nuvem, permitindo que os usuários acessem o sistema pela internet, sem a necessidade de instalação local.

A aplicação será organizada em serviços independentes de execução:

- **Frontend:** Hospedado em um serviço de hospedagem de aplicações web, responsável por disponibilizar a interface React.
- **Backend:** Hospedado em um servidor ou serviço de nuvem com suporte à execução de aplicações .NET e containers Docker.
- **Banco de dados:** MySQL hospedado em um serviço de banco de dados, responsável pelo armazenamento persistente das informações.

O Docker será utilizado para padronizar o ambiente de execução e facilitar a implantação da aplicação.

O código-fonte será mantido em um repositório GitHub, permitindo o controle de versões e facilitando futuras atualizações.

Após a configuração dos serviços de hospedagem, a aplicação será disponibilizada por meio de um endereço web, com comunicação segura utilizando HTTPS.
