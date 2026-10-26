# Plano de Testes de Usabilidade

Os testes de usabilidade terão como objetivo avaliar se os usuários conseguem utilizar o sistema do Clube de Xadrez do Baleia de forma simples, eficiente e intuitiva. A avaliação buscará identificar dificuldades de navegação, problemas de compreensão das informações e obstáculos na execução das principais tarefas.

## Definição dos Objetivos

Os testes deverão verificar se os usuários conseguem encontrar eventos, realizar inscrições, consultar o ranking e acompanhar a evolução dos jogadores. Também será avaliada a facilidade com que os administradores realizam operações como criar turmas, cadastrar eventos e registrar partidas.

Serão observados o tempo de execução, a quantidade de cliques, os erros cometidos, a necessidade de ajuda e a percepção dos usuários sobre a interface.

## Seleção dos Participantes

A avaliação contará com pelo menos cinco participantes, buscando representar os principais perfis de usuários da aplicação.

A composição sugerida é:

- Três alunos com diferentes níveis de conhecimento em xadrez e familiaridade com tecnologia.
- Um administrador responsável pela organização do clube.
- Um instrutor ou monitor que acompanhe as atividades dos alunos.

Os participantes serão identificados por códigos, como P1, P2 e P3, para preservar sua privacidade. Não serão registrados nomes completos ou outras informações pessoais desnecessárias. Caso menores de idade participem, deverão ser observadas as autorizações e medidas de proteção pertinentes.

## Definição dos Cenários de Teste

### Cenário 1 — Encontrar um evento e realizar inscrição

**Objetivo:** avaliar a facilidade para localizar eventos e concluir uma inscrição.

**Contexto:** um aluno deseja participar de um torneio organizado pelo clube.

**Tarefa:** acessar a lista de eventos, consultar os detalhes de um torneio disponível e realizar sua inscrição.

**Critérios de sucesso:**
- O participante localiza o evento sem ajuda.
- Conclui a inscrição corretamente.
- Consegue identificar a confirmação da inscrição.
- Conclui a tarefa em até 2 minutos, sem erros que impeçam sua conclusão.

### Cenário 2 — Consultar o rating e a evolução

**Objetivo:** avaliar a facilidade para consultar o próprio desempenho.

**Contexto:** um aluno deseja verificar seu rating atual e conferir os resultados de partidas anteriores.

**Tarefa:** acessar o ranking, localizar seu nome e abrir as informações de sua evolução.

**Critérios de sucesso:**
- O participante encontra seu rating atual.
- Identifica sua posição no ranking.
- Localiza o histórico de partidas e as variações de rating.
- Conclui a tarefa em até 2 minutos, sem ajuda.

### Cenário 3 — Cadastrar um evento com imagem

**Objetivo:** avaliar a facilidade de gerenciamento de eventos.

**Contexto:** um administrador precisa divulgar uma nova simultânea do clube.

**Tarefa:** cadastrar um evento com título, descrição, data, local e imagem.

**Critérios de sucesso:**
- O participante preenche os campos necessários.
- Consegue enviar a imagem válida.
- Salva o evento e verifica se as informações aparecem corretamente.
- Conclui a tarefa em até 4 minutos, sem ajuda.

### Cenário 4 — Registrar uma partida e verificar o rating

**Objetivo:** avaliar a clareza e a eficiência do processo de registro de partidas.

**Contexto:** um administrador precisa lançar o resultado de uma partida já realizada.

**Tarefa:** selecionar os dois jogadores, informar o resultado e consultar os ratings atualizados.

**Critérios de sucesso:**
- O participante registra corretamente os jogadores e o resultado.
- O sistema confirma o registro.
- O participante consegue identificar as alterações de rating.
- Conclui a tarefa em até 3 minutos, sem erros que comprometam os dados.

### Cenário 5 — Criar uma turma e associar um aluno

**Objetivo:** avaliar a facilidade para organizar as aulas do clube.

**Contexto:** um administrador precisa criar uma nova turma e adicionar um aluno.

**Tarefa:** cadastrar uma turma, preencher suas informações e associar um participante.

**Critérios de sucesso:**
- A turma é criada corretamente.
- O aluno é associado à turma.
- O participante consegue consultar as informações registradas.
- Conclui a tarefa em até 4 minutos, sem ajuda.

Os tempos estabelecidos são metas iniciais para avaliação, podendo ser ajustados após os primeiros testes.

## Métodos de Coleta de Dados

A coleta será realizada por observação direta durante a execução das tarefas e por um questionário aplicado ao final de cada sessão.

Serão registrados os seguintes indicadores:

| Indicador | Método |
|---|---|
| Tempo de execução | Cronometrar o tempo entre o início e a conclusão da tarefa. |
| Quantidade de cliques | Contabilizar os cliques necessários para concluir o cenário. |
| Taxa de conclusão | Verificar se a tarefa foi concluída corretamente. |
| Erros cometidos | Registrar ações incorretas, tentativas inválidas e dificuldades. |
| Necessidade de ajuda | Anotar quando o participante precisar de orientação. |
| Feedback qualitativo | Registrar comentários sobre clareza, facilidade e dificuldades. |

Após os testes, os participantes responderão a perguntas como: a interface foi fácil de entender? Você encontrou dificuldades? As informações estavam organizadas? O que poderia ser melhorado?

Os resultados serão analisados de forma agregada, sem exposição de dados pessoais dos participantes, e utilizados para orientar melhorias na interface e na navegação.
