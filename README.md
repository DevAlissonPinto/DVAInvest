# FIAP Pós Tech fase 5 Arquitetura de microservices - Visão Geral Projeto - Sistema de Gestão de Investimentos

O Sistema de Gestão de Investimentos é uma plataforma que permite que os usuários gerenciem seus portfólios de investimentos, incluindo ações, títulos e criptomoedas.

## Contribute

[Alisson da Silva Pinto](https://github.com/DevAlissonPinto)
[Diego Ivan Mendes de Oliveira](https://github.com/diegoivanmendes)
[Vinicius Roberto de Oliveira Santos](https://github.com/vroliveira)


## Repositories
* ASP.NET CORE BLAZOR  [link](https://github.com/DevAlissonPinto/DVAInvest)
* Teste de Interações de Lógicas de negócio, camadas de aplicação e banco de dados [link](https://github.com/DevAlissonPinto/DVAInvest/tree/master/DVAInvest.UnitTests)

## Development 

Para executar esse projeto você precisa seguir as etapas abaixo:

* Abrir a solution DVAInvest.sln com o visual studio 2022
* Configurar o projeto DVAInvest.Web para serem executado como startup projects
* Abri Package Manager Console e deixar como Defult project: '4 - Infra\DVAInvest.Infra.Repository' e executar o comando Update-Database
* Executar o projeto pressionando o F5

### DVAInvest.Tests

Este projeto de teste é construído usando xUnit.NET para testar o aplicativo ASP.NET Core DVAInvest, Ele contém testes automatizados para garantir o funcionamento correto do aplicativo.

## Configuração

Certifique-se de ter .NET Core 8 SDK instalado e VS 2022 community.

### Como Executar os Testes

1. Abra o terminal.
2. Navegue até o diretório do projeto de teste (DVAInvest.Tests).
3. Execute o seguinte comando: dotnet test
