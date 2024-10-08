<h1 align="center">
  DevJobs - Jornada .NET Direto ao Ponto
</h1>
<p align="center">
  <a href="#tecnologias-e-práticas-utilizadas">Tecnologias e práticas utilizadas</a> •
  <a href="#funcionalidades">Funcionalidades</a> •
  <a href="#comandos">Comandos</a>
</p>

Foi desenvolvida uma API REST completa de gerenciamento de vagas de emprego e aplicação de vagas.

## Tecnologias e práticas utilizadas
- ASP.NET Core com .NET 6
- Entity Framework Core
- In-Memory database
- Swagger (documentação)
- Serilog (log)
- Programação Orientada a Objetos
- Injeção de Dependência
- Padrão Repository
- Clean Code
- Publicação

## Funcionalidades
- Cadastro, Listagem, Detalhes, Atualização de Vaga de Emprego
- Aplicação a Vaga de Emprego

###

![alt text](https://raw.githubusercontent.com/samuel-oldra/DevJobs.API/main/README_IMGS/swagger_ui.png)

## Comandos

### Comandos básicos
```
dotnet new gitignore
dotnet new webapi -o DevJobs.API

dotnet build
dotnet run
dotnet watch run

dotnet publish
```

### Comandos user-secrets
```
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DevJobsCs" "Server=***;Database=***;User ID=***;Password=***;"
dotnet user-secrets remove "ConnectionStrings:DevJobsCs"
dotnet user-secrets clear
dotnet user-secrets list
```

### Tool Entity Framework Core (migrations)
```
dotnet tool install --global dotnet-ef
dotnet tool uninstall --global dotnet-ef
```

### Migrations
```
dotnet ef migrations add InitialMigration -o Persistence/Migrations
dotnet ef database update
```