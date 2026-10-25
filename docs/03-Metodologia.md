# Metodologia

O desenvolvimento do sistema do Clube de Xadrez do Baleia será conduzido de forma incremental, priorizando inicialmente as funcionalidades essenciais e evoluindo conforme a implementação e os testes.

A metodologia prevê a utilização de controle de versão, gerenciamento de tarefas, organização do código e testes automatizados. O desenvolvimento será dividido em etapas que permitam acompanhar o progresso e verificar a qualidade de cada funcionalidade antes de incorporá-la à versão estável.

## Controle de Versão

A ferramenta de controle de versão adotada será o [Git](https://git-scm.com/), com hospedagem do repositório no [GitHub](https://github.com/).

O projeto utilizará a seguinte convenção para branches:

- `main`: versão estável da aplicação.
- `unstable`: versão integrada que ainda pode apresentar instabilidades.
- `testing`: versão destinada à validação das funcionalidades.
- `dev`: branch principal de desenvolvimento.
- `feature/<nome>`: branch temporária para o desenvolvimento de uma funcionalidade específica.
- `fix/<nome>`: branch temporária destinada à correção de problemas.

As funcionalidades serão desenvolvidas em branches específicas e integradas à `dev` após uma revisão do código. Quando o conjunto de funcionalidades estiver pronto, será encaminhado para testes. Após a validação, a versão poderá ser incorporada à `main`.

Os commits serão escritos de forma objetiva, descrevendo as alterações realizadas. Serão adotados prefixos como `feat` para novas funcionalidades, `fix` para correções, `docs` para documentação, `test` para testes e `refactor` para reorganizações do código sem alteração do comportamento esperado.

As versões estáveis poderão ser identificadas por tags no Git, seguindo uma convenção de versionamento semântico, como `v1.0.0`.

O gerenciamento de problemas e tarefas será realizado por meio das Issues do GitHub, utilizando as seguintes etiquetas:

- `documentation`: alterações na documentação.
- `bug`: correções de defeitos.
- `enhancement`: melhorias em funcionalidades existentes.
- `feature`: desenvolvimento de novas funcionalidades.

Por se tratar de um projeto de pequeno porte, o processo será simplificado, mantendo o histórico de alterações, a separação das funcionalidades e a possibilidade de recuperar versões anteriores.

## Gerenciamento de Projeto

### Divisão de Papéis

O desenvolvimento será conduzido individualmente, com as responsabilidades organizadas da seguinte maneira:

| Papel | Responsabilidades |
|---|---|
| Desenvolvedor | Levantamento de requisitos, modelagem, implementação do backend e da interface, criação do banco de dados, testes, documentação e implantação. |
| Responsável pelo projeto | Definição das prioridades, validação das funcionalidades e acompanhamento das necessidades do Clube de Xadrez do Baleia. |
| Usuários participantes da validação | Utilização das funcionalidades e fornecimento de feedback para identificar problemas e oportunidades de melhoria. |

Os papéis de desenvolvedor e responsável pelo projeto poderão ser exercidos pela mesma pessoa. Os participantes da validação serão envolvidos conforme a disponibilidade e a evolução da aplicação.

### Processo

Será adotado um processo incremental inspirado em práticas ágeis, utilizando um backlog de funcionalidades e ciclos curtos de desenvolvimento.

As atividades serão organizadas nas seguintes etapas:

1. **Planejamento:** definição das funcionalidades prioritárias, critérios de aceitação e tarefas.
2. **Implementação:** desenvolvimento das funcionalidades, seguindo a organização arquitetural e os requisitos definidos.
3. **Testes:** verificação das regras de negócio, das permissões de acesso e da integração com o banco de dados.
4. **Revisão:** análise do código, correção de problemas e atualização da documentação.
5. **Integração:** incorporação das alterações à branch de desenvolvimento.
6. **Implantação:** preparação e publicação de uma versão funcional para validação.

O andamento será acompanhado por meio de GitHub Issues e, quando necessário, GitHub Projects. As tarefas serão consideradas concluídas quando atenderem aos critérios de aceitação definidos e não apresentarem falhas conhecidas que comprometam seu funcionamento.

### Ferramentas

| Ferramenta | Finalidade |
|---|---|
| Visual Studio ou Visual Studio Code | Edição e desenvolvimento do backend e da interface. |
| C# e ASP.NET Core | Implementação das regras de negócio e da API. |
| React e JavaScript | Desenvolvimento da interface web. |
| MySQL | Armazenamento persistente dos dados. |
| Entity Framework Core | Mapeamento objeto-relacional e acesso ao banco de dados. |
| Docker e Docker Compose | Conteinerização e execução dos componentes da aplicação. |
| Git e GitHub | Controle de versão, hospedagem do código e gerenciamento de tarefas. |
| Swagger/OpenAPI | Documentação e exploração dos endpoints da API. |
| Postman | Testes manuais das requisições HTTP. |
| xUnit | Desenvolvimento de testes automatizados para o backend. |

As ferramentas foram selecionadas considerando o porte do projeto, a necessidade de manutenção e a possibilidade de desenvolver, testar e executar a solução com uma infraestrutura simples.
