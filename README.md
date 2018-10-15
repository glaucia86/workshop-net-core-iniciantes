# Workshop - ASP.NET Core para Iniciantes

Repositório responsável pelo workshop desenvolvido durante o evento: [.NET Conference 2018 - Goiânia](https://ev.congressy.com/dotnetconf-workshop-net-core/).
O intuito desse workshop é ensinar, de maneira prática, a como desenvolver uma aplicação em .NET Core de uma maneira: simples, rápida e fácil.

## Recursos Utilizados: :computer:

Se faz necessário realizar a instalação das aplicações/frameworks abaixo:

* Visual Studio Code

    - [Visual Studio Code](https://code.visualstudio.com/)
    - [.NET Core SDK](https://www.microsoft.com/net/download)

* Visual Studio

    - [Visual Studio](https://bit.ly/2zBXxF8)
    - [.NET Core 2.x](https://www.microsoft.com/net/download)

Caso resolva usar o Visual Studio como IDE, durante a sua instalação procure instalar os seguintes itens:
    - ASP.NET & Web Development;
    - .NET Core Cross-Platform Development;

## O que vou aprender?! :blue_book:

Nesse workshop você será capaz de desenvolver a sua primeira aplicação Web em .NET Core 2.x Razor Pages.
A aplicação constitui num CRUD (Create, Read, Update e Delete).

## Ementa do Workshop: :pencil2:

- Parte 1: Criando Razor Pages usando o dotnet CLI & VS Code;
- Parte 2: Adicionando um modelo para a aplicaçao ASP.NET Core Razor Pages;
- Parte 3: Atualizando e gerando páginas;
- Parte 4: Adicionando busca para a aplicação Razor Pages;

## Vídeos do Workshop: :movie_camera:

- [Aula 01 - Introdução](https://youtu.be/njlmcXxSHE4)
- [Aula 02 - Criando aplicação .NET Core](https://youtu.be/QobTy9hMUsA)
- [Aula 03 - Instalando Importantes Plugins HD](https://youtu.be/QobTy9hMUsA)
- [Aula 04 - Adicionando Modelo & Criando a BD com EF Core](https://youtu.be/2UpKRHgE79I)
- [Aula 05 - Uso de Data Annotations na Classe Modelo](https://youtu.be/3rOydR0HVEk)
- [Aula 6 - Melhorias de Front-End no Projeto]
    - [Aula 6.1 - Melhorias de Front-End no Projeto: Parte I](https://youtu.be/NJ9PIn1iRSI)
    - [Aula 6.2 - Melhorias de Front-End no Projeto: Parte II](https://youtu.be/drXNN8vrG8o)
    - [Aula 6.3 - Melhorias de Front-End no Projeto: Parte III]()
    - [Aula 6.4 - Melhorias de Front-End no Projeto: Parte IV]()
- [Aula 07 - ]()
- [Aula 08 - ]()

## Executando o Projeto Localmente :fire:

Caso queira executar o projeto de maneira local, basta executar os comandos abaixo:

```
> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> dotnet restore
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

Feito isso irá criar a base de dados para que possa ser testada na hora de executar a aplicação ao dar: **dotnet run** na raiz do projeto.

## Tenho Dúvidas... O que faço?! :triangular_flag_on_post:

Caso tenha dúvidas ao código desenvolvido durante o workshop, sinta-se a vontade em abrir uma [ISSUE Aqui](https://github.com/glaucia86/workshop-net-core-iniciantes/issues) no repositório com a sua dúvida. Assim que possível, estarei respondendo as todas as dúvidas que tiverem! 
