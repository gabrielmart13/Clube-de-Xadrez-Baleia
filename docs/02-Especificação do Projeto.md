# Especificações do Projeto

Este documento apresenta a especificação do sistema do Clube de Xadrez do Baleia a partir das necessidades de seus usuários. São definidos os perfis de usuários, as histórias de usuário, os requisitos funcionais e não funcionais, as restrições e os casos de uso previstos para a solução.

A especificação será utilizada como referência para o desenvolvimento da aplicação, a elaboração dos diagramas e a validação das funcionalidades.

## Personas

As personas a seguir representam perfis fictícios que poderão utilizar a plataforma. Suas características foram definidas a partir das necessidades previstas para o clube.

### Persona 1 — Aluno iniciante

**Nome:** Lucas Oliveira  
**Idade fictícia:** 13 anos  
**Perfil:** Escoteiro que está começando a aprender xadrez.

**Objetivos:** Aprender xadrez, participar de atividades do clube e acompanhar seu desenvolvimento.

**Dores e frustrações:** Tem dificuldade para saber quais eventos estão disponíveis e para perceber sua evolução ao longo do tempo.

**Expectativas:** Encontrar facilmente informações sobre aulas, torneios, inscrições e seu próprio rating.

### Persona 2 — Aluno competitivo

**Nome:** Marina Costa  
**Idade fictícia:** 17 anos  
**Perfil:** Jogadora que participa regularmente de partidas e busca melhorar seu desempenho.

**Objetivos:** Acompanhar o rating, analisar os resultados anteriores e participar de torneios.

**Dores e frustrações:** Não ter acesso rápido ao histórico das partidas e precisar consultar diferentes registros para entender sua evolução.

**Expectativas:** Visualizar seu rating atualizado, consultar seu desempenho e acompanhar sua posição no ranking.

### Persona 3 — Administrador do clube

**Nome:** Rafael Mendes  
**Idade fictícia:** 28 anos  
**Perfil:** Responsável pela organização administrativa do clube.

**Objetivos:** Organizar turmas, gerenciar eventos, manter os cadastros atualizados e registrar resultados.

**Dores e frustrações:** Gastar tempo atualizando informações manualmente e correr o risco de cometer erros nos cálculos ou registros.

**Expectativas:** Administrar as principais atividades em um só lugar, com operações rápidas e informações consistentes.

### Persona 4 — Instrutor de xadrez

**Nome:** André Ferreira  
**Idade fictícia:** 35 anos  
**Perfil:** Instrutor responsável por acompanhar as aulas e o desenvolvimento dos alunos.

**Objetivos:** Organizar as turmas, acompanhar os participantes e estimular a evolução técnica dos jogadores.

**Dores e frustrações:** Ter dificuldade para identificar o histórico dos alunos e manter as informações das atividades organizadas.

**Expectativas:** Consultar rapidamente as informações das turmas e dos participantes e facilitar o acompanhamento do clube.

### Persona 5 — Responsável por um participante

**Nome:** Patrícia Almeida  
**Idade fictícia:** 42 anos  
**Perfil:** Responsável por um jovem integrante do clube, interessada em acompanhar sua participação nas atividades.

**Objetivos:** Conhecer os eventos oferecidos, acompanhar informações públicas sobre as atividades e entender o desenvolvimento do participante.

**Dores e frustrações:** Ter dificuldade para encontrar informações atualizadas sobre eventos e atividades.

**Expectativas:** Encontrar informações claras sobre as atividades e facilitar a participação do jovem no clube.

## Histórias de Usuários

Com base nas personas identificadas, foram definidas as seguintes histórias de usuário.

### Gerenciamento de usuários e turmas

| EU COMO... | QUERO/PRECISO... | PARA... |
|---|---|---|
| Administrador | Cadastrar e gerenciar usuários | Manter os participantes registrados e suas informações atualizadas. |
| Administrador | Criar, editar e desativar turmas | Organizar as atividades de ensino do clube. |
| Administrador | Vincular alunos às turmas | Controlar a participação dos alunos nas aulas. |
| Instrutor | Consultar as turmas e seus participantes | Acompanhar as atividades sob minha responsabilidade. |
| Aluno | Consultar as informações das turmas disponíveis | Conhecer as atividades oferecidas pelo clube. |

### Eventos e inscrições

| EU COMO... | QUERO/PRECISO... | PARA... |
|---|---|---|
| Administrador | Criar eventos, como torneios e simultâneas | Organizar as atividades esportivas do clube. |
| Administrador | Adicionar imagens aos eventos | Divulgar as atividades de forma mais atrativa. |
| Administrador | Consultar os inscritos em cada evento | Organizar a participação dos jogadores. |
| Aluno | Consultar os eventos disponíveis | Escolher as atividades das quais desejo participar. |
| Aluno | Inscrever-me e cancelar minha inscrição em eventos | Gerenciar minha participação nas atividades. |

### Partidas, rating e ranking

| EU COMO... | QUERO/PRECISO... | PARA... |
|---|---|---|
| Administrador | Registrar o resultado de uma partida entre dois jogadores | Manter o histórico de resultados atualizado. |
| Administrador | Obter o cálculo automático das variações de rating | Evitar cálculos manuais e reduzir erros. |
| Aluno | Consultar meu rating e o histórico de partidas | Acompanhar minha evolução no xadrez. |
| Aluno | Consultar o ranking geral | Conhecer minha posição em relação aos demais jogadores. |
| Aluno | Visualizar o nome, o ramo e o rating dos participantes no ranking | Comparar as classificações dos jogadores. |

## Requisitos

Os requisitos funcionais descrevem as ações que a aplicação deverá executar. Os requisitos não funcionais estabelecem as características técnicas e as condições de qualidade da solução.

### Requisitos Funcionais

| ID | Descrição do Requisito | Prioridade |
|---|---|---|
| RF-001 | A aplicação deve permitir que usuários cadastrados realizem login. | ALTA |
| RF-002 | A aplicação deve permitir que os usuarios se cadastrem no sistema. | ALTA |
| RF-003 | A aplicação deve permitir que os administradores criem, editem e desativem turmas. | ALTA |
| RF-004 | A aplicação deve permitir que os administradores vinculem e removam alunos das turmas. | ALTA |
| RF-005 | A aplicação deve permitir que os usuários consultem as informações das turmas disponíveis. | MÉDIA |
| RF-006 | A aplicação deve permitir que os administradores criem, editem e cancelem eventos. | ALTA |
| RF-007 | A aplicação deve permitir que os usuários consultem a lista e os detalhes dos eventos. | ALTA |
| RF-008 | A aplicação deve permitir que alunos realizem e cancelem suas inscrições em eventos. | ALTA |
| RF-009 | A aplicação deve permitir que os administradores consultem os inscritos em cada evento. | MÉDIA |
| RF-010 | A aplicação deve permitir que os administradores registrem os resultados das partidas entre dois jogadores. | ALTA |
| RF-011 | A aplicação deve calcular automaticamente as variações de rating dos jogadores após o registro válido de uma partida. | ALTA |
| RF-012 | A aplicação deve manter o histórico dos resultados e das alterações de rating de cada jogador. | ALTA |
| RF-013 | A aplicação deve disponibilizar um ranking geral dos jogadores, contendo nome, ramo e rating atual. | ALTA |
| RF-014 | A aplicação deve permitir que os alunos consultem seu próprio histórico de partidas e sua evolução de rating. | ALTA |
| RF-015 | A aplicação deve permitir o envio de imagens para divulgação dos eventos. | MÉDIA |
| RF-016 | A aplicação deve restringir as funcionalidades administrativas a usuários autorizados. | ALTA |
| RF-017 | A aplicação deve impedir inscrições duplicadas do mesmo usuário no mesmo evento. | ALTA |
| RF-018 | A aplicação deve impedir que partidas inválidas ou já registradas sejam contabilizadas novamente sem uma correção administrativa explícita. | ALTA |
| RF-019 | A aplicação deve utilizar um sistema de fila para controlar a prioridade de entrada de alunos nas turmas. | MÉDIA |
### Requisitos Não Funcionais

| ID | Descrição do Requisito | Prioridade |
|---|---|---|
| RNF-001 | A aplicação deve possuir uma interface responsiva, adaptada a computadores e dispositivos móveis. | ALTA |
| RNF-002 | As senhas dos usuários devem ser armazenadas utilizando um mecanismo seguro de hash, nunca em texto puro. | ALTA |
| RNF-003 | O sistema deve implementar autenticação e autorização para proteger os recursos restritos. | ALTA |
| RNF-004 | A aplicação deve ser dimensionada para até 200 usuários cadastrados e aproximadamente 30 usuários simultâneos. | ALTA |
| RNF-005 | As operações comuns devem apresentar resposta em até 3 segundos em condições normais de funcionamento, dentro da capacidade prevista para o sistema. | MÉDIA |
| RNF-006 | O backend deve seguir os princípios SOLID e utilizar uma organização modular que facilite a manutenção. | ALTA |
| RNF-007 | A aplicação e o banco de dados devem poder ser executados em contêineres Docker. | ALTA |
| RNF-008 | O sistema deve validar o formato e o tamanho dos arquivos de imagem enviados. | ALTA |
| RNF-009 | As alterações relacionadas ao rating e ao histórico de partidas devem preservar a integridade dos dados, inclusive em caso de falhas durante uma operação. | ALTA |
| RNF-010 | A aplicação deve permitir a realização de cópias de segurança do banco de dados. | MÉDIA |
| RNF-011 | A aplicação deve armazenar somente os dados pessoais necessários para seu funcionamento. | ALTA |
| RNF-012 | O sistema deve admitir períodos curtos de indisponibilidade, sem exigir disponibilidade ininterrupta. | MÉDIA |

### Restrições

| ID | Restrição |
|---|---|
| R-001 | A solução deverá utilizar arquitetura monolítica, sem a divisão do sistema em microsserviços. |
| R-002 | O banco de dados utilizado deverá ser MySQL. |
| R-003 | A aplicação e o banco de dados deverão ser conteinerizados utilizando Docker. |
| R-004 | O envio de arquivos será limitado a imagens, sem suporte ao envio de vídeos. |
| R-005 | A solução será dimensionada para um ambiente de pequeno porte, com até 200 usuários cadastrados e cerca de 30 usuários simultâneos. |
| R-006 | O sistema deverá implementar medidas básicas de segurança, sem a necessidade de uma infraestrutura complexa de alta disponibilidade. |
| R-007 | O algoritmo de rating deverá seguir uma regra definida e documentada, garantindo consistência dos cálculos e rastreabilidade das alterações. |
| R-008 | O sistema deverá manter um escopo compatível com as necessidades do clube, evitando funcionalidades que não sejam essenciais ao seu funcionamento. |

## Endpoints da API (v1)

A tabela apresenta os 38 endpoints inicialmente previstos para a API do Clube de Xadrez dos Escoteiros do Baleia, organizados por módulo, perfil de acesso, método HTTP e finalidade.

| Módulo | Acesso | Método e endpoint | Finalidade |
|---|---|---|---|
| Autenticação | Público | `POST /api/auth/register` | Cadastrar um novo aluno no sistema. |
| Autenticação | Público | `POST /api/auth/login` | Realizar login e obter autenticação. |
| Autenticação | Usuário autenticado | `GET /api/auth/me` | Consultar os dados do usuário autenticado e seu nível de acesso. |
| Usuários | Administrador | `GET /api/users` | Listar os usuários cadastrados. |
| Usuários | Usuário autenticado | `GET /api/users/me` | Consultar as próprias informações de perfil. |
| Usuários | Usuário autenticado | `PUT /api/users/me` | Atualizar as próprias informações de perfil. |
| Ranking e desempenho | Usuário autenticado | `GET /api/rankings` | Consultar o ranking geral dos jogadores. |
| Ranking e desempenho | Usuário autenticado | `GET /api/rankings/{userId}` | Consultar a posição de um jogador no ranking. |
| Ranking e desempenho | Usuário autenticado | `GET /api/performance/me` | Consultar o próprio desempenho, rating e estatísticas. |
| Ranking e desempenho | Usuário autenticado | `GET /api/performance/me/history` | Consultar o histórico de partidas e a evolução do rating. |
| Turmas | Usuário autenticado | `GET /api/classes` | Listar as turmas disponíveis. |
| Turmas | Usuário autenticado | `GET /api/classes/{id}` | Consultar os detalhes de uma turma. |
| Turmas | Administrador | `POST /api/classes` | Criar uma nova turma. |
| Turmas | Administrador | `PUT /api/classes/{id}` | Editar as informações de uma turma. |
| Turmas | Administrador | `DELETE /api/classes/{id}` | Desativar uma turma. |
| Turmas | Administrador | `GET /api/classes/{id}/students` | Consultar os alunos matriculados e a fila de espera da turma. |
| Turmas | Aluno | `POST /api/classes/{id}/enroll` | Solicitar ingresso em uma turma ou entrar na fila de espera. |
| Turmas | Aluno | `DELETE /api/classes/{id}/enroll` | Cancelar a matrícula ou desistir da fila de espera. |
| Turmas | Aluno | `GET /api/classes/{id}/queue/me` | Consultar a própria posição na fila de espera. |
| Turmas | Administrador | `DELETE /api/classes/{id}/students/{userId}` | Remover um aluno de uma turma. |
| Eventos | Usuário autenticado | `GET /api/events` | Listar os eventos disponíveis. |
| Eventos | Usuário autenticado | `GET /api/events/{id}` | Consultar os detalhes de um evento. |
| Eventos | Administrador | `POST /api/events` | Criar um novo evento. |
| Eventos | Administrador | `PUT /api/events/{id}` | Editar as informações de um evento. |
| Eventos | Administrador | `DELETE /api/events/{id}` | Cancelar um evento. |
| Eventos | Aluno | `POST /api/events/{id}/registrations` | Realizar inscrição em um evento. |
| Eventos | Aluno | `DELETE /api/events/{id}/registrations/me` | Cancelar a própria inscrição em um evento. |
| Eventos | Administrador | `GET /api/events/{id}/registrations` | Consultar os inscritos em um evento. |
| Eventos | Usuário autenticado | `GET /api/events/me/registrations` | Consultar os eventos nos quais está inscrito. |
| Partidas e resultados | Administrador | `POST /api/matches` | Registrar uma partida entre dois jogadores e calcular as variações de rating. |
| Partidas e resultados | Administrador | `GET /api/matches` | Consultar as partidas registradas. |
| Partidas e resultados | Administrador | `PUT /api/matches/{id}` | Corrigir uma partida registrada e recalcular os ratings afetados. |
| Administradores | Administrador | `GET /api/admins` | Listar os administradores cadastrados. |
| Administradores | Administrador | `GET /api/admins/{id}` | Consultar um administrador específico. |
| Administradores | Administrador | `POST /api/admins` | Cadastrar um novo administrador. |
| Administradores | Administrador | `PUT /api/admins/{id}` | Editar as informações de um administrador. |
| Administradores | Administrador | `PATCH /api/admins/{id}/status` | Ativar ou desativar um administrador. |
| Envio de imagens | Administrador | `POST /api/uploads/images` | Enviar imagens para utilização nos eventos. |

**Total: 38 endpoints.**

## Diagrama de Casos de Uso

O diagrama deverá representar os atores e suas interações com a aplicação, delimitando as funcionalidades disponíveis para cada perfil.

**Atores previstos:**

- **Administrador:** gerencia usuários, turmas, eventos, inscrições e registros de partidas.
- **Aluno:** consulta turmas, acompanha o ranking e a própria evolução, e administra suas inscrições em eventos.

**Casos de uso previstos:**

| Ator | Casos de Uso |
|---|---|
| Administrador | Realizar login; gerenciar usuários; gerenciar turmas; vincular alunos; gerenciar eventos; consultar inscritos; registrar partidas; atualizar ratings; consultar ranking. |
| Aluno | Realizar login; consultar turmas; consultar eventos; inscrever-se em eventos; cancelar inscrição; consultar ranking; consultar histórico e evolução de rating. |

**Imagem do diagrama:** [Inserir diagrama UML de casos de uso na próxima etapa]
