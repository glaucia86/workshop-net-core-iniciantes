# Workshop - ASP.NET CORE para Iniciantes

<p align="center">
  <img src="https://i.imgsafe.org/4d/4de4b63490.jpeg"/>  
</p>

Repositório responsável pelo workshop desenvolvido durante o evento: [.NET Conference 2018 - Goiânia](https://ev.congressy.com/dotnetconf-workshop-net-core/).
O intuito desse workshop é ensinar, de maneira prática, a como desenvolver uma aplicação em .NET Core de uma maneira: simples, rápida e fácil.


## Recursos Utilizados: :computer:

Se faz necessário realizar a instalação das aplicações/frameworks abaixo:

* Visual Studio Code

    - **[Visual Studio Code](https://code.visualstudio.com/?WT.mc_id=javascript-0000-gllemos)**
    - **[.NET Core SDK](https://www.microsoft.com/net/download?WT.mc_id=javascript-0000-gllemos)**

* Visual Studio

    - **[Visual Studio](https://visualstudio.microsoft.com/downloads/?WT.mc_id=javascript-0000-gllemos)**
    - **[.NET Core 2.x](https://dotnet.microsoft.com/download?WT.mc_id=javascript-0000-gllemos)**

Caso resolva usar o Visual Studio como IDE, durante a sua instalação procure instalar os seguintes itens:
    -  ASP.NET & Web Development;
    - .NET Core Cross-Platform Development;

* Cadastrar uma Conta no Azure:

    - **[Portal Azure](https://azure.microsoft.com/?WT.mc_id=javascript-0000-gllemos)**
    
* Baixar o Git:
    
    - **[Git](https://git-scm.com/downloads)**

## O que vou aprender?! :blue_book:

Nesse workshop você será capaz de desenvolver a sua primeira aplicação Web em .NET Core 2.x Razor Pages.
A aplicação constitui num CRUD (Create, Read, Update e Delete).

## Ementa do Workshop: :pencil2:

- Parte 1: Criando Razor Pages usando o dotnet CLI & VS Code;
- Parte 2: Adicionando um modelo para a aplicaçao ASP.NET Core Razor Pages;
- Parte 3: Atualizando e gerando páginas;
- Parte 4: Adicionando busca para a aplicação Razor Pages;
- Parte 5: Build & Deploy da Aplicação no Azure App Service;

## Vídeos do Workshop: :movie_camera:

- [Aula 01 - Introdução](https://youtu.be/njlmcXxSHE4)
- [Aula 02 - Criando aplicação .NET Core](https://youtu.be/QobTy9hMUsA)
- [Aula 03 - Instalando Importantes Plugins HD](https://youtu.be/QobTy9hMUsA)
- [Aula 04 - Adicionando Modelo & Criando a BD com EF Core](https://youtu.be/2UpKRHgE79I)
- [Aula 05 - Uso de Data Annotations na Classe Modelo](https://youtu.be/3rOydR0HVEk)
- **Aula 6 - Melhorias de Front-End no Projeto**
    - [Aula 6.1 - Melhorias de Front-End no Projeto: Parte I](https://youtu.be/NJ9PIn1iRSI)
    - [Aula 6.2 - Melhorias de Front-End no Projeto: Parte II](https://youtu.be/drXNN8vrG8o)
    - [Aula 6.3 - Melhorias de Front-End no Projeto: Parte III](https://youtu.be/YuB4AThdHkI)
    - [Aula 6.4 - Melhorias de Front-End no Projeto: Parte IV](https://youtu.be/47tG0qH6a_M)
    - [Aula 6.5 - Melhorias de Front-End no Projeto: Parte V](https://youtu.be/qiaqJplpNV0)
- [Aula 07 - Adicionando Busca no Index.html](https://youtu.be/2PJ5JZ5MTTo)
- **Aula 08 - Build & Deploy da Aplicação para o Azure**
    - [Aula 8.1 - Build & Deploy da Aplicação para o Azure: Parte I](https://youtu.be/dyyYCPHDRTk)
    - [Aula 8.2 - Build & Deploy da Aplicação para o Azure: Parte II](https://youtu.be/Jvx3LrCURK0)
    - [Aula 8.3 - Build & Deploy da Aplicação para o Azure: Parte III](https://youtu.be/Or2meipfoj4)

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

## Screen Shots da Aplicação Feita:

Caso queiram dar uma olhada como ficou a aplicação final, bastam acessar o site: [https://filmes-app-crud.azurewebsites.net/](https://filmes-app-crud.azurewebsites.net/)

Abaixo segue alguns screen shots da Aplicação desenvolvida:

### Página Principal:

<p align="center">
  <img src="https://i.imgsafe.org/df/df6212b0bd.png"/>  
</p>

### Sobre Mim:

<p align="center">
  <img src="https://i.imgsafe.org/df/df67151204.png"/>  
</p>

### Entre em Contato:

<p align="center">
  <img src="https://i.imgsafe.org/df/df68e874b4.png"/>  
</p>


### Listar Filmes:

<p align="center">
  <img src="https://i.imgsafe.org/df/df69218a60.png"/>  
</p>


## Tenho Dúvidas... O que Faço?! :triangular_flag_on_post:

Caso tenha dúvidas ao código desenvolvido durante o workshop, sinta-se a vontade em abrir uma [ISSUE AQUI](https://github.com/glaucia86/workshop-net-core-iniciantes/issues) no repositório com a sua dúvida. Assim que possível, estarei respondendo as todas as dúvidas que tiverem! 
