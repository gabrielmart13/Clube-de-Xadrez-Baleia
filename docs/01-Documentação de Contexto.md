# Introdução

O Clube de Xadrez do Baleia tem como objetivo promover o aprendizado, a prática e o desenvolvimento dos participantes por meio do xadrez. Para organizar essas atividades, é necessário acompanhar os alunos, administrar turmas, divulgar eventos e manter os registros das partidas e dos ratings dos jogadores.

O projeto propõe o desenvolvimento de um sistema web para centralizar essas informações e facilitar a gestão do clube. A plataforma permitirá que os administradores organizem as atividades e registrem os resultados das partidas, enquanto os alunos poderão consultar o ranking, acompanhar sua evolução e realizar inscrições em eventos.

A solução será desenvolvida utilizando uma arquitetura monolítica, com banco de dados MySQL e aplicação conteinerizada com Docker. O sistema será dimensionado para um cenário de pequeno porte, considerando até 200 usuários cadastrados e aproximadamente 30 usuários conectados simultaneamente.

O público-alvo compreende os alunos do clube, os instrutores e os responsáveis pela organização das atividades, que utilizarão a plataforma de acordo com suas necessidades.

## Problema

A organização de um clube de xadrez envolve diferentes atividades, como o gerenciamento de turmas, o controle de participantes, a realização de eventos e o acompanhamento dos resultados dos jogadores. Essas atividades precisam manter informações consistentes e acessíveis para que o clube funcione de maneira organizada.

Quando essas informações são mantidas em registros separados ou dependem de atualizações manuais, pode haver dificuldade para consultar o histórico dos participantes, acompanhar a evolução dos jogadores e manter o ranking atualizado. A organização das inscrições e dos resultados também pode demandar trabalho adicional dos responsáveis pelo clube.

Dessa forma, o problema central consiste na necessidade de organizar e manter atualizadas as informações administrativas e esportivas do clube, facilitando o acesso aos dados e reduzindo o esforço necessário para gerenciar suas atividades.

## Objetivos

### Objetivo geral

Desenvolver um sistema web para facilitar a organização das atividades do Clube de Xadrez do Baleia, centralizando o gerenciamento de turmas, eventos, jogadores, partidas e ratings.

### Objetivos específicos

- Permitir o cadastro e o gerenciamento de turmas e eventos, incluindo torneios e simultâneas.
- Disponibilizar aos alunos recursos para consultar o ranking, acompanhar seu histórico de partidas e realizar inscrições em eventos.
- Implementar um sistema de rating que calcule automaticamente as alterações de pontuação a partir dos resultados das partidas registradas.
- Manter um ranking geral atualizado, com nome, ramo e rating dos jogadores.
- Aplicar princípios de segurança, organização do código e integridade dos dados durante o desenvolvimento.
- Utilizar Docker para facilitar a configuração e a execução dos componentes da aplicação.

## Justificativa

A proposta busca reduzir o esforço operacional necessário para organizar as atividades do clube e melhorar a disponibilidade das informações para administradores e alunos. A centralização dos registros permitirá consultar os resultados das partidas, acompanhar a evolução dos participantes e manter o ranking atualizado sem depender de cálculos manuais a cada novo resultado.

O sistema foi planejado para atender a um público de até 200 usuários cadastrados e cerca de 30 acessos simultâneos, justificando a adoção de uma arquitetura monolítica e de um banco de dados relacional MySQL. Essas características permitem manter uma estrutura técnica adequada ao porte do projeto, sem introduzir complexidade desnecessária.

O projeto também se relaciona ao **Objetivo de Desenvolvimento Sustentável 4 (ODS 4) — Educação de Qualidade**, especialmente às metas 4.5, relacionada à igualdade de acesso à educação, e 4.7, que contempla uma educação orientada à promoção da paz, da diversidade e da cidadania (NAÇÕES UNIDAS BRASIL, s.d.). A contribuição do sistema ocorrerá de forma indireta, ao facilitar a organização de atividades de aprendizagem e a participação dos integrantes do clube.

Como ainda não existem indicadores levantados sobre o tempo gasto na administração ou a frequência de erros nos registros, o impacto deverá ser avaliado após a implantação. Serão considerados indicadores como o tempo necessário para registrar resultados, a quantidade de inconsistências no ranking, o tempo para localizar informações e a taxa de conclusão das inscrições em eventos.

## Público-Alvo

O público-alvo é composto por integrantes do Clube de Xadrez do Baleia que participam das atividades de aprendizagem, treinamento e competição, além das pessoas responsáveis pela organização do clube.

Os alunos poderão apresentar diferentes níveis de conhecimento enxadrístico e de familiaridade com sistemas digitais. Por isso, a plataforma deverá oferecer uma interface intuitiva, com informações claras e acesso simples às principais funcionalidades.

Os administradores e instrutores utilizarão o sistema para organizar as atividades, atualizar informações e acompanhar o desenvolvimento dos participantes. Espera-se que esses usuários tenham maior necessidade de acessar funcionalidades de gerenciamento e consultar registros com frequência.

A aplicação será direcionada principalmente ao uso em computadores e dispositivos móveis, permitindo que os participantes consultem suas informações e acompanhem as atividades do clube com facilidade.

## Referência

[1] NAÇÕES UNIDAS BRASIL. **Objetivo de Desenvolvimento Sustentável 4: Educação de qualidade**. Disponível em: https://brasil.un.org/pt-br/sdgs/4. Acesso em: 25 out. 2026.
