# Api-Produtos-Com-CSharp
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/ArtDevRodrigues/Api-Produtos-Com-CSharp/blob/main/LICENSE) 

# Sobre o Projeto

Api simulando a Criação, Leitura, Alteração e Deleção de produtos fictícios usando C# asp.net core com conexão ao sql server.
    
## Tecnologias Utilizadas 

- C#
- .NET 5
- ASP.NET Core
- Entity Framework Core
- SQL Server(Local ou Remoto)

Mais informações Acesse: 
https://docs.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0

Tutorial de criação da Api Web: https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio

# Pré-Requisitos
## As versões mais recentes de:

- Dotnet
- ASP.NET_Core
- Entity Framework: dotnet tool install --global dotnet-ef  (Para instalar é necessário intalar o Dotnet antes.)
- SQL Server

# Como Rodar o Projeto
```bash
# clonar repositório
git clone https://github.com/ArtDevRodrigues/Api-Produtos-Com-CSharp.git

# entrar na pasta do projeto
cd apiProdutosCRUD

# executar o projeto
dotnet run
```
## Observação (Antes de execultar, atualize o seguinte arquivo)

- acesse o arquivo 'appsettings.json' 

- Altere a linha de conexão para seu usuario e senha do sql server;

- Crie um novo banco de dados sql Server com o nome "api_produto"

    Exemplo: Server=SeuLocalHostouConexaoremota;Initial Catalog=api_produto;Persist Security Info=False;User ID=SeuIDdeUsuario;Password=ASuaSenha;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;(Copie esse codigo e cole no arquivo).

### Acessando e Utilizando o Sistema

Acesse o navegado com o seguinte link para ver a listagem em sua maquina local: https://localhost:5001/produto/api

Acesse o navegado com o seguinte link para utilizar o CRUD caso não queira instalar um Cliente em sua maquina: https://localhost:5001/swagger/index.html

## Contatos do Autor

- Email: artdevrodrigues@gmail.com
- Linkdin: https://www.linkedin.com/in/arthur-h-rodrigues-2baab6208/
