# FintechBank - Sistema Bancário com Testes em xUnit

Projeto desenvolvido para a disciplina de **Garantia da Qualidade de Software / Gestão e Qualidade de Software**, ministrada pelo **Prof. Daniel Henrique Matos de Paiva**.

---

## 👥 Equipe e Divisão de Responsabilidades (4 Integrantes)

Para atender à execução da atividade com **4 integrantes** e garantir contribuições ativas no repositório GitHub de todos os membros, a divisão foi estruturada da seguinte forma:

| Integrante | GitHub | Função Principal | Responsabilidades |
| :--- | :--- | :--- | :--- |
| **Gabriel Ferreira de Souza 325140970** | [@1Gapril](https://github.com/1Gapril) | **Dev Backend Core (Serviço 1) & Owner** | Criação do repositório remoto, configuração inicial da solução .NET e implementação do `ContaCorrenteService.cs` (cálculo de taxas de manutenção e validação de saque). |
| **Caio Vasconcelos 325132875** | [@caiovas28-dotcom](https://github.com/caiovas28-dotcom) | **Dev Backend Core (Serviço 2)** | Implementação do `EmprestimoService.cs` (cálculo de juros por score de crédito e validação de margem consignável). |
| **Lucas H. Miranda 325131396** | [@LucasHMiranda](https://github.com) | **QA Engineer & Testes xUnit** | Implementação das suítes de testes parametrizados com xUnit (`ContaCorrenteServiceTests.cs` e `EmprestimoServiceTests.cs` usando `[Theory]` e `[InlineData]`). |
| **Fernando Almeida de Oliveira Braga 326132695** | Contribuidor Local / Git | **DevOps, CI/CD & Documentação** | Configuração do `.gitignore`, `LICENSE` (MIT), documentação técnica no `README.md`, revisão de código e validação de execução (`dotnet test`). |

> 📌 **Guia Passo a Passo por Integrante:** Consulte o arquivo PASSO_A_PASSO_INTEGRANTES.md](PASSO_A_PASSO_INTEGRANTES.md) para ver as instruções detalhadas e comandos Git individuais para cada membro.

---

## 📋 Visão Geral da Aplicação
O **FintechBank** é uma aplicação desenvolvida no ecossistema .NET para simular operações bancárias essenciais, como controle de taxas de manutenção, validações de saques em contas correntes e análise e cálculo de parcelas de empréstimos com base no score de crédito do cliente. 

O foco principal do projeto é demonstrar a aplicação prática de **Garantia de Qualidade de Software** através de testes unitários parametrizados e robustos utilizando o framework **xUnit**.

---

## 🛠️ Requisitos Técnicos
* **Linguagem:** C#
* **Framework:** .NET 8 / .NET 10
* **Framework de Testes:** xUnit
* **Test Runner:** Microsoft.NET.Test.Sdk e Visual Studio Test Runner

---

## 🧠 Regras de Negócio Implementadas

### 1. `ContaCorrenteService`
Responsável pelas regras e validações de conta corrente:
* **`CalcularTaxaManutencao(decimal saldo, bool clienteEspecial)`**:
  * Saldo ≥ R$ 5.000,00 **OU** Cliente Especial (`true`): **Isento (R$ 0,00)**.
  * Saldo entre R$ 1.000,00 e R$ 4.999,99 (e não especial): **R$ 12,50**.
  * Saldo menor que R$ 1.000,00 (e não especial): **R$ 25,00**.
* **`PodeRealizarSaque(decimal saldo, decimal limiteChequeEspecial, decimal valorSaque)`**:
  * Permite o saque (`true`) apenas se `valorSaque <= (saldo + limiteChequeEspecial)`.

### 2. `EmprestimoService`
Gerencia a simulação e concessão de linhas de crédito:
* **`CalcularValorParcela(decimal valorTotal, int parcelas, int scoreCredito)`**:
  * Score ≥ 700: taxa total de juros de **5%** (`valorTotal * 1.05m`).
  * Score entre 500 e 699: taxa total de juros de **12%** (`valorTotal * 1.12m`).
  * Score < 500: taxa total de juros de **20%** (`valorTotal * 1.20m`).
  * Retorno da parcela mensal: `valorComJuros / parcelas`.
* **`AprovarEmprestimo(decimal rendaMensal, decimal valorParcela)`**:
  * O empréstimo só é aprovado (`true`) se o `valorParcela` comprometer no máximo **30% da renda mensal** (`valorParcela <= rendaMensal * 0.30m`).

---

## 🧪 Estrutura de Testes Parametrizados (`[Theory]` / `[InlineData]`)
Para garantir a cobertura completa de múltiplos cenários sem duplicação de código, utilizamos os recursos de testes orientados a dados do **xUnit**:
* **`[Theory]`**: Define que o método é um teste que aceita múltiplos conjuntos de argumentos.
* **`[InlineData(...)]`**: Injeta os parâmetros de entrada e o resultado esperado em cada iteração de teste.

### Matriz de Testes Coberta:
1. **`ContaCorrenteServiceTests`**:
   - `CalcularTaxaManutencao`:
     - `6000.00, false -> 0.00` (Saldo alto: Isento)
     - `500.00, true -> 0.00` (Cliente Especial: Isento)
     - `2500.00, false -> 12.50` (Saldo intermediário: R$ 12,50)
     - `300.00, false -> 25.00` (Saldo baixo: R$ 25,00)
   - `PodeRealizarSaque`:
     - `1000.00, 500.00, 1200.00 -> true` (Dentro do limite total)
     - `1000.00, 500.00, 1600.00 -> false` (Excede saldo + limite)
2. **`EmprestimoServiceTests`**:
   - `CalcularValorParcela`:
     - `10000.00, 10, 800 -> 1050.00` (Score alto: 5%)
     - `10000.00, 10, 600 -> 1120.00` (Score médio: 12%)
     - `10000.00, 10, 400 -> 1200.00` (Score baixo: 20%)
   - `AprovarEmprestimo`:
     - `5000.00, 1500.00 -> true` (Parcela = 30% da renda: Aprovado)
     - `5000.00, 1600.00 -> false` (Parcela > 30% da renda: Recusado)

---

## 🚀 Como Executar o Projeto Localmente

### 1. Clonar o Repositório
```bash
git clone https://github.com/1Gapril/fintech-bank-xunit-no-GitHub.git
cd fintech-bank-xunit-no-GitHub
```

### 2. Compilar a Solução
```bash
dotnet build
```

### 3. Executar a Aplicação Console
```bash
dotnet run --project FintechBank.App/FintechBank.App.csproj
```

### 4. Executar os Testes Unitários
```bash
dotnet test
```

---

## 📄 Licença
Este projeto está sob a licença [MIT](LICENSE).
