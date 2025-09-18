## 📊 CashFlow API - Gerenciamento de Despesas

### 📌 Sobre o Projeto

A **CashFlow API**, desenvolvida em **.NET 8** e orientada pelos princípios de **Domain-Driven Design (DDD)**, tem como objetivo oferecer uma solução estruturada e segura para o gerenciamento de **despesas pessoais**.

Os usuários podem registrar informações detalhadas de suas despesas, como:

- **Título**
- **Data e Hora**
- **Descrição**
- **Valor**
- **Tipo de Pagamento**
- **Tags**

Os dados são armazenados de forma segura em um **banco de dados MySQL**.

A arquitetura segue o padrão **REST**, utilizando métodos **HTTP** para comunicação simples e eficiente.  
Além disso, conta com **Swagger** para documentação interativa e exploração dos endpoints.

![my-image]

---

### ⚙️ Tecnologias Utilizadas

- **.NET 8**
- **MySQL**
- **Entity Framework Core**
- **Swagger**
a
---

### 📦 Principais Pacotes NuGet

- **Entity Framework Core** → ORM para manipulação de dados via objetos .NET, sem a necessidade de consultas SQL manuais.  
- **AutoMapper** → Mapeamento automático entre objetos de domínio e DTOs, reduzindo código repetitivo.  
- **FluentValidation** → Implementação de regras de validação de forma clara e intuitiva.  
- **FluentAssertions** → Escrita de testes de unidade mais legíveis e compreensíveis. 

### ✨ Features

🧩 Domain-Driven Design (DDD): Estrutura modular que facilita o entendimento e a manutenção do domínio da aplicação.

📊 Tratamento de Erros: Implementação de ErrorHandlingMiddleware para capturar e retornar erros estruturados em JSON.

🗄️ Migrations com EF Core: Controle de versão do banco de dados com atualizações automáticas via migrations.

🔐 Autenticação JWT: Proteção de endpoints sensíveis com geração e validação de tokens JWT.

🧪 Testes de Unidade: Cobertura das principais regras de negócio para garantir confiabilidade.

🔗 Testes de Integração: Validação ponta a ponta dos endpoints, simulando cenários reais de uso da API.

📑 Swagger Documentado: Integração com Swagger para documentação clara e testável dos endpoints da aplicação.


---

## 🚀 Getting Started  

Para obter uma cópia local funcionando, siga estes passos simples.  

### Requisitos  
* Visual Studio versão 2022+ ou Visual Studio Code  
* Windows 10+ ou Linux/MacOS com [.NET SDK][dot-net-sdk] instalado  
* MySQL Server  

### Instalação  
1. Clone o repositório:  
   ```bash
   git clone https://github.com/jpsilvacosta/CashFlow.git
2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)

<!--Links-->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!--Images-->
[my-image]: image/myimage.jpeg