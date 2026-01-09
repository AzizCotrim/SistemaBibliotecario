---

# 📚 Sistema de Biblioteca – Windows Forms (.NET / C#)

## 🇧🇷 Português (PT-BR)

Este projeto é um **Sistema de Biblioteca** desenvolvido em **C# com Windows Forms**, com foco em **boas práticas de arquitetura, organização de código e separação de responsabilidades**, simulando um cenário real de aplicação desktop com acesso a banco de dados.

O projeto foi criado tanto para **aprendizado prático** quanto para servir como **projeto de portfólio**.

---

## 🎯 Objetivo do Sistema

O sistema tem como objetivo:

* Gerenciar **usuários**, **livros** e **categorias**
* Controlar **cadastros**, **consultas** e **estoque**
* Permitir **pesquisas flexíveis** por diferentes critérios
* Centralizar regras de negócio
* Manter um código limpo, organizado e escalável

---

## 🧱 Arquitetura do Projeto

O projeto segue uma **arquitetura em camadas**, separando claramente as responsabilidades:

### 🔹 Camada de Apresentação (Forms)

* Contém apenas a interface gráfica (Windows Forms)
* Responsável por interação com o usuário
* Não contém regras de negócio nem SQL

### 🔹 Camada de Serviço (Services)

* Centraliza todas as **regras de negócio**
* Realiza validações
* Decide quando lançar exceções
* Orquestra chamadas ao repositório

### 🔹 Camada de Dados (Repositories)

* Responsável exclusivamente pelo acesso ao **SQL Server**
* Executa consultas e comandos
* Retorna apenas dados
* Não contém validações de negócio

### 🔹 Modelos / Entidades

* Representam o domínio da aplicação:

  * `Usuario`
  * `Livro`
  * `Categoria`

---

## 🔐 Segurança

* Senhas não são armazenadas em texto puro
* Uso de **Salt + Hash (SHA-256)**
* No login, o hash da senha informada é recalculado e comparado com o banco

---

## 👤 Módulo de Usuários

Funcionalidades:

* Cadastro de usuários
* Validação de login:

  * Tamanho mínimo
  * Formato permitido
  * Verificação de duplicidade
* Login com validação segura
* Associação com permissões/cargos

---

## 📘 Módulo de Livros

Funcionalidades:

* Cadastro de livros
* Associação com categorias existentes
* Separação entre:

  * Cadastro do livro
  * Controle de estoque
* Verificação de duplicidade antes do cadastro

---

## 🗂️ Módulo de Categorias

* Cadastro e listagem de categorias
* Pesquisa por múltiplas categorias
* Uso de **Table-Valued Parameter (TVP)** no SQL Server
* Integração via `DataTable` no C#

---

## 🔎 Sistema de Busca

* Pesquisa por:

  * Título
  * Autor
  * Data de lançamento
  * Categoria
* Uso de objetos de filtro
* Parâmetros opcionais (`string?`, `int?`)
* SQL preparado para filtros dinâmicos

---

## 🖥️ Interface

* Tela principal (`MainForm`) com:

  * Menu lateral
  * Painel de conteúdo dinâmico
* Forms carregados dentro do painel principal
* Login em janela separada
* Uso de `FlatStyle` e formulários sem borda

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET (Windows Forms)
* SQL Server
* ADO.NET
* SHA-256
* Visual Studio

---

## 🚀 Status

🟡 Em desenvolvimento

---

## 👨‍💻 Autor

**Aziz Cotrim**
GitHub: [https://github.com/AzizCotrim](https://github.com/AzizCotrim)


---


# 📚 Library Management System – Windows Forms (.NET / C#)

## 🇺🇸 English Version

This project is a **Library Management System** developed in **C# using Windows Forms**, focused on **clean architecture, separation of concerns, and best practices**, simulating a real-world desktop application with database integration.

It was created both for **practical learning** and as a **portfolio project**.

---

## 🎯 Project Goal

The system aims to:

* Manage **users**, **books**, and **categories**
* Handle **registrations**, **queries**, and **inventory**
* Provide **flexible search functionality**
* Centralize business rules
* Maintain clean, maintainable, and scalable code

---

## 🧱 Project Architecture

The application follows a **layered architecture**, clearly separating responsibilities:

### 🔹 Presentation Layer (Forms)

* Contains only the user interface
* Handles user interaction
* No business logic or database access

### 🔹 Service Layer

* Centralizes **business rules**
* Performs validations
* Decides when to throw exceptions
* Coordinates repository calls

### 🔹 Data Access Layer (Repositories)

* Responsible for **SQL Server access**
* Executes queries and commands
* Returns data only
* No business validation logic

### 🔹 Models / Entities

* Represent the domain:

  * `User`
  * `Book`
  * `Category`

---

## 🔐 Security

* Passwords are not stored in plain text
* Uses **Salt + Hash (SHA-256)**
* During login, the password hash is recalculated and compared

---

## 👤 User Module

Features:

* User registration
* Login validation:

  * Minimum length
  * Valid format
  * Duplicate check
* Secure authentication
* User permission handling

---

## 📘 Book Module

Features:

* Book registration
* Association with existing categories
* Separation between:

  * Book registration
  * Inventory control
* Duplicate verification before insertion

---

## 🗂️ Category Module

* Category registration and listing
* Search by multiple categories
* Use of **Table-Valued Parameters (TVP)** in SQL Server
* Integration via `DataTable` in C#

---

## 🔎 Search System

* Search by:

  * Title
  * Author
  * Release year
  * Category
* Filter objects
* Optional parameters (`string?`, `int?`)
* Dynamic and safe SQL queries

---

## 🖥️ User Interface

* Main screen (`MainForm`) with:

  * Sidebar menu
  * Dynamic content panel
* Forms loaded inside the main panel
* Login as a separate window
* Flat-style buttons and borderless internal forms

---

## 🛠️ Technologies Used

* C#
* .NET (Windows Forms)
* SQL Server
* ADO.NET
* SHA-256
* Visual Studio

---

## 🚀 Status

🟡 In development

---

## 👨‍💻 Author

**Aziz Cotrim**
GitHub: [https://github.com/AzizCotrim](https://github.com/AzizCotrim)

---
