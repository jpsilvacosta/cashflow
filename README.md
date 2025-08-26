# 📊 CashFlow API - Gerenciamento de Despesas

## 📌 Descrição

A **CashFlow API**, desenvolvida em **.NET 8** e orientada pelos princípios de **Domain-Driven Design (DDD)**, tem como objetivo oferecer uma solução estruturada e segura para o gerenciamento de **despesas pessoais**.

Os usuários podem registrar informações detalhadas de suas despesas, como:

- **Título**
- **Data e Hora**
- **Descrição**
- **Valor**
- **Tipo de Pagamento**

Os dados são armazenados de forma segura em um **banco de dados MySQL**.

A arquitetura segue o padrão **REST**, utilizando métodos **HTTP** para comunicação simples e eficiente.  
Além disso, conta com **Swagger** para documentação interativa e exploração dos endpoints.

---

## ⚙️ Tecnologias Utilizadas

- **.NET 8**
- **MySQL**
- **Entity Framework Core**
- **Swagger**

---

## 📦 Principais Pacotes NuGet

- **Entity Framework Core** → ORM para manipulação de dados via objetos .NET, sem a necessidade de consultas SQL manuais.  
- **AutoMapper** → Mapeamento automático entre objetos de domínio e DTOs, reduzindo código repetitivo.  
- **FluentValidation** → Implementação de regras de validação de forma clara e intuitiva.  
- **FluentAssertions** → Escrita de testes de unidade mais legíveis e compreensíveis.  
- **Swagger** → Documentação interativa da API, facilitando testes e integração.  

---

## 🚀 Como Executar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
