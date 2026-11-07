**Biblioteca - Sistema de Gerenciamento de Biblioteca**

Aplicação desktop desenvolvida em C# e Windows Forms para o gerenciamento de livros, usuários e empréstimos.

<img width="984" height="561" alt="image" src="https://github.com/user-attachments/assets/80f9a410-2a0b-4b13-a13e-99a3b8357cf3" />


**Tecnologias utilizadas**

- C#
- .NET 8
- Windows Forms
- Entity Framework Core
- SQL Server
- LINQ
- Git e GitHub

**Funcionalidades**

*Livros*

- Cadastro de livros
- Listagem e pesquisa
- Edição de informações
- Controle de disponibilidade
- Arquivamento de livros

*Usuários*

- Cadastro de usuários
- Listagem e pesquisa
- Edição de informações

*Empréstimos*

- Registro de empréstimos
- Associação entre livros e usuários
- Registro de devoluções
- Acompanhamento da situação dos empréstimos
- Filtros de pesquisa

**Estrutura do projeto**

Biblioteca: entidades, contexto do banco de dados e regras de negócio.

Biblioteca.WinForms: interface gráfica desenvolvida com Windows Forms.

**Download**

https://github.com/cami-ferr/Biblioteca/releases/tag/v1.0.0

O aplicativo está disponível em formato .zip na seção Releases.

**Requisito:** 
Windows 64 bits com SQL Server Express LocalDB instalado. O aplicativo cria o banco de dados automaticamente na primeira execução.

**Como utilizar o aplicativo**

1. Baixe o arquivo "Aplicativo.zip" na seção [Releases](https://github.com/cami-ferr/Biblioteca/releases/tag/v1.0.0).
2. Extraia o conteúdo do arquivo ZIP.
3. Certifique-se de que o SQL Server Express LocalDB esteja instalado.
4. Execute "Biblioteca-v1.0.0-x64.exe".

O banco de dados e suas tabelas serão criados automaticamente na primeira execução.

**Como executar**

1. Clone este repositório:

git clone https://github.com/cami-ferr/Biblioteca.git

2. Abra o arquivo Biblioteca.sln no Visual Studio.

3. Certifique-se de ter o .NET 8 e o SQL Server LocalDB instalados.

4. Confira a configuração da conexão com o banco de dados em appsettings.json.

5. Aplique as migrações do Entity Framework Core para criar a estrutura do banco de dados.

6. Defina Biblioteca.WinForms como projeto de inicialização e execute a aplicação.
