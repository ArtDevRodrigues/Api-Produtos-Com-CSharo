# Api-Produtos-Com-CSharp
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/ArtDevRodrigues/Api-Produtos-Com-CSharp/blob/main/LICENSE) 

# Sobre o Projeto

Api simulando a Criação, Leitura, Alteração e Deleção de produtos fictícios usando C# asp.net core.
    
## Tecnologias Utilizadas 

- C#
- .NET
- ASP.NET Core
- Entity Framework Core
- SQL Server(o mysql já vem com ele integrado)

Mais informações Acesse: 
https://docs.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0

# Pré-Requisitos
## As versoes mais recentes de:

- Dotnet: https://dotnet.microsoft.com/
- ASP.NET_Core: https://dotnet.microsoft.com/apps/aspnet
- Entity Framework: dotnet tool install --global dotnet-ef  (Para instalar é necessário intalar o Dotnet antes.)
- SQL Server: https://dev.mysql.com/downloads/file/?id=506567

# Como Rodar o Projeto
```bash
# clonar repositório
git clone https://github.com/ArtDevRodrigues/Api-Produtos-Com-CSharp.git

# entrar na pasta do projeto
cd apiProdutosCRUD

# acesse o arquivo 'appsettings.json' 
Altere a linha de conexão para seu usuario e senha do sql server;
crie um novo banco de dados com o nome "api_produto"

# executar o projeto
dotnet run
```
Acesse o navegado com o seguinte link para ver a listagem em sua maquina local: https://localhost:5001/produto/api

Ou acesse ele em um servidor online: 

### COntatos do Autor

- Email: artdevrodrigues@gmail.com
- Linkdin: https://www.linkedin.com/in/arthur-h-rodrigues-2baab6208/
