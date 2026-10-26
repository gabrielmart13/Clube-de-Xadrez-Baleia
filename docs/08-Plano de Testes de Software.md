# Plano de Testes de Software

O plano de testes tem como objetivo verificar se o sistema do Clube de Xadrez do Baleia atende aos requisitos funcionais e não funcionais estabelecidos. Os testes serão realizados durante o desenvolvimento e antes da disponibilização da aplicação aos usuários.

Serão utilizados testes unitários para validar regras de negócio isoladas e testes de integração para verificar o comportamento dos componentes em conjunto, especialmente a API e o banco de dados MySQL. Também serão realizados testes manuais para validar os fluxos de utilização da interface.

Os resultados serão registrados após a execução de cada caso de teste.

## Casos de Teste

### CT01 — Realizar login

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-001, RF-016 e RNF-002. |
| Objetivo do Teste | Verificar se um usuário cadastrado consegue realizar login com credenciais válidas e se credenciais incorretas são rejeitadas. |
| Passos | Acessar a aplicação; informar e-mail e senha válidos; realizar login; repetir a operação com uma senha incorreta. |
| Critério de Êxito | O acesso é concedido com credenciais válidas e negado com credenciais incorretas, sem expor informações confidenciais. |

### CT02 — Gerenciar turmas

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-003, RF-004 e RF-005. |
| Objetivo do Teste | Verificar a criação de uma turma e a associação de alunos. |
| Passos | Entrar como administrador; cadastrar uma turma; associar um aluno; consultar os dados da turma; tentar realizar a mesma operação com um usuário sem permissão administrativa. |
| Critério de Êxito | A turma e a associação são salvas corretamente, e as operações administrativas são bloqueadas para usuários não autorizados. |

### CT03 — Criar evento com imagem

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-006 e RF-015. |
| Objetivo do Teste | Verificar se o administrador consegue cadastrar um evento e associar uma imagem. |
| Passos | Entrar como administrador; preencher título, descrição, tipo, data e local; selecionar uma imagem válida; salvar o evento; consultar seus detalhes. |
| Critério de Êxito | O evento é criado com os dados informados e a imagem é exibida corretamente. Arquivos inválidos devem ser rejeitados. |

### CT04 — Realizar inscrição em evento

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-007, RF-008, RF-009 e RF-017. |
| Objetivo do Teste | Verificar o processo de inscrição e o controle de inscrições duplicadas. |
| Passos | Entrar como aluno; consultar os eventos disponíveis; realizar uma inscrição; tentar inscrever-se novamente no mesmo evento; consultar a situação da inscrição. |
| Critério de Êxito | A primeira inscrição é registrada corretamente, e a segunda é impedida sem gerar duplicidade. |

### CT05 — Registrar partida e calcular rating

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-010, RF-011 e RF-012. |
| Objetivo do Teste | Verificar se o resultado de uma partida produz as alterações corretas de rating para os dois jogadores. |
| Passos | Entrar como administrador; selecionar dois jogadores com ratings conhecidos; registrar uma partida com resultado definido; consultar os novos ratings e o histórico. |
| Critério de Êxito | As variações correspondem ao algoritmo Elo e aos parâmetros definidos, e os registros de ambos os jogadores são consistentes. |

### CT06 — Consultar ranking e evolução

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-013 e RF-014. |
| Objetivo do Teste | Verificar a exibição do ranking geral e do histórico individual. |
| Passos | Acessar o ranking; consultar os nomes, ramos e ratings; selecionar um jogador; consultar seu histórico de partidas e a evolução do rating. |
| Critério de Êxito | As informações exibidas correspondem aos registros do banco de dados, e a classificação respeita a ordenação definida pelo sistema. |

### CT07 — Corrigir resultado de partida

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-010, RF-011, RF-012 e RF-018. |
| Objetivo do Teste | Verificar a proteção contra registros duplicados e a consistência de uma correção administrativa. |
| Passos | Registrar uma partida; tentar enviá-la novamente; realizar uma correção utilizando o mecanismo administrativo previsto; consultar o histórico e os ratings afetados. |
| Critério de Êxito | A partida não é contabilizada duas vezes. A correção respeita as regras definidas e não deixa os ratings ou históricos em estado inconsistente. |

### CT08 — Validar controle de acesso

| Campo | Descrição |
|---|---|
| Requisito Associado | RF-016 e RNF-003. |
| Objetivo do Teste | Verificar se um aluno sem privilégios administrativos está impedido de executar operações restritas. |
| Passos | Realizar login como aluno; tentar acessar telas e endpoints administrativos; tentar enviar requisições diretamente à API. |
| Critério de Êxito | As operações restritas são negadas pela API, independentemente de como a requisição foi enviada, e os dados protegidos permanecem inalterados. |

## Estratégia de execução

Os testes serão realizados em ambiente de desenvolvimento, preferencialmente utilizando uma base de dados de teste com registros controlados.

As regras de negócio do rating deverão ser verificadas com resultados previamente calculados. Os testes de integração deverão conferir tanto as respostas da API quanto as alterações persistidas no banco de dados.

Os testes de segurança deverão verificar permissões no backend, e não somente a visibilidade dos elementos da interface.

A execução, o resultado, as falhas identificadas e as evidências de cada caso serão documentados no Registro de Testes de Software.
