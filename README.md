# Projeto Urgência – API em C# com Docker e PostgreSQL

Este projeto tem como objetivo a construção de uma API RESTful utilizando ASP.NET Core 8 e Entity Framework Core, com persistência de dados em um banco PostgreSQL, e orquestração completa via Docker e Docker Compose.

---

## 🔧 Tecnologias Utilizadas

### Backend (C#)
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL via EF Core (Npgsql)

### DevOps
- Docker
- Docker Compose
- Container com usuário não-root
- Volume nomeado para persistência de dados
- Configurações via variáveis de ambiente

---

## 📁 Estrutura do Projeto



---

## 🚀 Como Rodar o Projeto (Ambiente Docker)

### 1. **Pré-requisitos**
- Docker instalado
- Docker Compose instalado
- .NET SDK 8 (caso queira rodar localmente fora do Docker)

---

### 2. **Build e execução via Docker Compose**

```bash
docker-compose up --build


