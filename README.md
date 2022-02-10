# DevJobs - Jornada .NET Direto ao Ponto

Foi desenvolvida uma API REST completa de gerenciamento de vagas de emprego e aplicação de vagas.

## Tecnologias e práticas utilizadas
- ASP.NET Core com .NET 6
- Entity Framework Core
- SQL Server
- Swagger
- Injeção de Dependência
- Programação Orientada a Objetos
- Padrão Repository
- Logs com Serilog
- Publicação na nuvem com Azure App Service

## Funcionalidades
- Cadastro, Listagem, Detalhes, Atualização de Vaga de Emprego
- Aplicação a Vaga de Emprego

###

![alt text](https://raw.githubusercontent.com/samuel-oldra/dev-jobs/master/README_IMGS/swagger_ui.png)

## Comandos básicos:
```
dotnet new webapi -o DevJobs.API
dotnet build
dotnet run
```

## Comandos user-secrets
```
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DevJobsCs" "Server=localhost;Database=DevJobs;User ID=sa;Password=senha;"
dotnet user-secrets list
```

## Tool Entity Framework Core (migrations)
```
dotnet tool install --global dotnet-ef
```

## Migrations
```
dotnet ef migrations add InitialMigration -o Persistence/Migrations
dotnet ef database update
```
