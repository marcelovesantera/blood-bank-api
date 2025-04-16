# 🩸 Blood Bank API

Este projeto é uma **API RESTful** desenvolvida com **ASP.NET Core 8.0**, que simula um sistema de gerenciamento de banco de dados de doação de sangue. O objetivo é registrar doadores, controlar o estoque de sangue, registrar doações e gerar relatórios, aplicando boas práticas de programação orientada a objetos e utilizando **Entity Framework Core** com banco de dados **em memória**.


## 🚀 Tecnologias Utilizadas

- [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api/)
- [Entity Framework Core (InMemory)](https://learn.microsoft.com/en-us/ef/core/providers/in-memory/)


## 🧪 Funcionalidades

### ✅ Cadastro de Doador
- Validação de dados.
- Prevenção de cadastros duplicados por e-mail.
- Cadastro de menores de idade permitido, mas sem doação.

### ✅ Registro de Doações
- Doações atualizam o estoque de sangue automaticamente.
- Regras de negócio como peso mínimo e intervalo de tempo entre doações por gênero.

### ✅ Estoque de Sangue
- Quantidade total por tipo sanguíneo.
- Aviso quando estoque atinge mínimo (em desenvolvimento).

### ✅ Relatórios
- Total por tipo sanguíneo.
- Histórico de doações nos últimos 30 dias.
- Histórico individual por doador.

---

## 🧠 Regras de Negócio (Resumo)

- Doador não pode ser cadastrado com e-mail repetido.
- Menores de idade **podem** ser cadastrados, mas **não podem doar**.
- Peso mínimo para doar: **50KG**.
- Mulheres só podem doar a cada **90 dias**.
- Homens só podem doar a cada **60 dias**.
- Quantidade permitida por doação: **entre 420ml e 470ml**.

---

## 🏁 Como executar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/marcelovesantera/blood-bank-api.git
   cd blood-bank-api
2. Restaure os pacotes:
   ```bash
   dotnet restore
2. Execute o projeto:
   ```bash
   dotnet run --project BloodBank.API
2. Acesse a documentação Swagger:
   ```bash
   https://localhost:5001/swagger


## 📌 Observações

- Esta aplicação **não possui persistência de dados** entre execuções, pois utiliza banco de dados **em memória**.
- É ideal para fins **educacionais** ou como **prova de conceito (POC)**.

