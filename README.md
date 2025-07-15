# ASP.NET-e-migration

## Descrição
Este projeto foi desenvolvido utilizando **ASP.NET Core** para criar uma aplicação web com integração ao banco de dados **MySQL**. Ele utiliza o **Entity Framework Core** para gerenciar as migrações e o acesso ao banco de dados. A aplicação está configurada para realizar operações básicas e foi estruturada com boas práticas de desenvolvimento.

---

## Funcionalidades Implementadas
1. **Configuração do Banco de Dados MySQL**:
   - O serviço de conexão ao banco de dados foi configurado no arquivo `Program.cs` utilizando o `AppDbContext`.
   - A `ConnectionString` foi definida no arquivo `appsettings.json`.

2. **Criação do Contexto de Banco de Dados**:
   - O arquivo `AppDbContext.cs` foi criado para gerenciar as entidades e a conexão com o banco de dados.

3. **Migrações**:
   - O comando `dotnet ef migrations add <NomeDaMigration>` foi utilizado para criar migrações.
   - O comando `dotnet ef database update` foi utilizado para aplicar as migrações e criar o banco de dados.

4. **Exclusão do Banco de Dados**:
   - O comando `dotnet ef database drop` foi configurado para excluir o banco de dados, caso necessário.

---

## Estrutura do Projeto
- **Program.cs**:
  Configuração do serviço para conexão com o banco de dados MySQL utilizando o `AppDbContext`.

- **AppDbContext.cs**:
  Classe responsável por gerenciar o contexto do banco de dados e os `DbSets` das entidades.

- **appsettings.json**:
  Arquivo de configuração contendo a `ConnectionString` para o banco de dados MySQL.

---

## Comandos Utilizados
### Criação do Projeto
```bash
dotnet new web -n MinhaAplicacao

Instalação de Pacotes