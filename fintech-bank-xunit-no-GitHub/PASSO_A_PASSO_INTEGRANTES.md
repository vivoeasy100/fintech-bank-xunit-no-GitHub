# 🚀 Guia Passo a Passo por Integrante - FintechBank

Este guia contém as instruções individuais para cada um dos **4 integrantes** da equipe executarem suas tarefas, comitarem no GitHub e garantirem que seus nomes apareçam como **Contributors** na entrega final da disciplina de **Garantia da Qualidade de Software**.

---

## 📌 Checklist Geral Obrigatório Antes de Começar

Para que o GitHub contabilize as contribuições de todos e exiba os 4 na aba **Contributors**:
1. O dono do repositório (**Gabriel Ferreira / @1Gapril**) deve adicionar os outros 3 membros como colaboradores em:
   * **GitHub** ➔ Repositório `fintech-bank-xunit-no-GitHub` ➔ **Settings** ➔ **Collaborators** ➔ **Add people**.
2. Cada integrante deve aceitar o convite recebido no e-mail ou na notificação do GitHub.
3. No terminal do seu computador, cada membro deve configurar seu Git com **o mesmo e-mail cadastrado na sua conta do GitHub**.

---

## 👤 1. Gabriel Ferreira de Souza (`@1Gapril`)
**Papel:** *Dev 1 - Backend Core (Conta Corrente) & Repositório Owner*

### Tarefas:
- [x] Configuração inicial do repositório no GitHub.
- [x] Convidar os outros 3 integrantes como colaboradores.
- [ ] Criar a estrutura base da solução e implementar as regras de **Conta Corrente**.

### Passo a Passo no Terminal:
```bash
# 1. No repositório local, configure seu autor do Git
git config user.name "Gabriel Ferreira"
git config user.email "seu-email-github@exemplo.com"

# 2. Crie a branch da sua tarefa
git checkout -b feature/conta-corrente-service

# 3. Arquivos sob sua responsabilidade:
# - FintechBank.sln
# - FintechBank.App/FintechBank.App.csproj
# - FintechBank.App/ContaCorrenteService.cs

# 4. Verifique o status das alterações
git status

# 5. Adicione e faça o commit
git add FintechBank.sln FintechBank.App/FintechBank.App.csproj FintechBank.App/ContaCorrenteService.cs
git commit -m "feat(core): implementa solucao base e regras de negocio do ContaCorrenteService"

# 6. Envie para o GitHub
git push origin feature/conta-corrente-service
```
*Após o push, abra o GitHub e realize o Merge do Pull Request para a branch `main`.*

---

## 👤 2. Caio Vasconcelos (`@caiovas28-dotcom`)
**Papel:** *Dev 2 - Backend Core (Empréstimos & Console App)*

### Tarefas:
- [ ] Implementar as regras de negócio de **Empréstimos** (`EmprestimoService.cs`).
- [ ] Integrar as chamadas e demonstração no `Program.cs`.

### Passo a Passo no Terminal:
```bash
# 1. Clone o repositório ou atualize sua main
git clone https://github.com/1Gapril/fintech-bank-xunit-no-GitHub.git
cd fintech-bank-xunit-no-GitHub
git checkout main
git pull origin main

# 2. Configure seu nome e e-mail do GitHub
git config user.name "Caio Vasconcelos"
git config user.email "seu-email-github@exemplo.com"

# 3. Crie a branch da sua tarefa
git checkout -b feature/emprestimo-service

# 4. Arquivos sob sua responsabilidade:
# - FintechBank.App/EmprestimoService.cs
# - FintechBank.App/Program.cs

# 5. Teste a compilação e execute a aplicação console
dotnet build
dotnet run --project FintechBank.App/FintechBank.App.csproj

# 6. Adicione e comite suas alterações
git add FintechBank.App/EmprestimoService.cs FintechBank.App/Program.cs
git commit -m "feat(core): implementa EmprestimoService e integracao de simulacao no Program.cs"

# 7. Envie para o GitHub
git push origin feature/emprestimo-service
```
*Abra um Pull Request no GitHub solicitando o merge para `main`.*

---

## 👤 3. Lucas H. Miranda (`Lucas H. Miranda`)
**Papel:** *Dev 3 - QA Engineer & Testes Unitários com xUnit*

### Tarefas:
- [ ] Configurar o projeto de testes `FintechBank.Tests`.
- [ ] Implementar os testes parametrizados com `[Theory]` e `[InlineData]` para `ContaCorrenteServiceTests.cs`.
- [ ] Implementar os testes parametrizados com `[Theory]` e `[InlineData]` para `EmprestimoServiceTests.cs`.
- [ ] Validar que 100% dos testes passam com `dotnet test`.

### Passo a Passo no Terminal:
```bash
# 1. Clone o repositório ou atualize sua main
git clone https://github.com/1Gapril/fintech-bank-xunit-no-GitHub.git
cd fintech-bank-xunit-no-GitHub
git checkout main
git pull origin main

# 2. Configure seu nome e e-mail do GitHub
git config user.name "Lucas H. Miranda"
git config user.email "seu-email-github@exemplo.com"

# 3. Crie a branch da sua tarefa
git checkout -b feature/testes-xunit

# 4. Arquivos sob sua responsabilidade:
# - FintechBank.Tests/FintechBank.Tests.csproj
# - FintechBank.Tests/ContaCorrenteServiceTests.cs
# - FintechBank.Tests/EmprestimoServiceTests.cs

# 5. Execute os testes para garantir 100% de sucesso
dotnet test

# 6. Adicione e faça o commit
git add FintechBank.Tests/FintechBank.Tests.csproj FintechBank.Tests/ContaCorrenteServiceTests.cs FintechBank.Tests/EmprestimoServiceTests.cs
git commit -m "test(qa): implementa suítes de testes parametrizados xUnit com Theory e InlineData"

# 7. Envie para o GitHub
git push origin feature/testes-xunit
```
*Abra um Pull Request no GitHub solicitando o merge para `main`.*

---

## 👤 4. Fernando Almeida de Oliveira Braga (`Fernando Braga`)
**Papel:** *Dev 4 - DevOps, Documentação & Garantia de Qualidade*

### Tarefas:
- [ ] Configuração do `.gitignore` para projetos .NET.
- [ ] Configuração da licença MIT (`LICENSE`).
- [ ] Documentação completa do projeto no `README.md` e guias da equipe.
- [ ] Revisão de código, validação de build/testes e aprovação de merges.

### Passo a Passo no Terminal:
```bash
# 1. No repositório local, atualize a branch main
git checkout main
git pull origin main

# 2. Configure seu nome e e-mail do GitHub
git config user.name "Fernando Almeida de Oliveira Braga"
git config user.email "326132695@ulife.com.br"

# 3. Crie a branch da sua tarefa
git checkout -b feature/devops-documentacao

# 4. Arquivos sob sua responsabilidade:
# - .gitignore
# - LICENSE
# - README.md
# - PASSO_A_PASSO_INTEGRANTES.md

# 5. Validação da solução completa
dotnet build
dotnet test

# 6. Adicione e comite as alterações
git add .gitignore LICENSE README.md PASSO_A_PASSO_INTEGRANTES.md
git commit -m "docs(devops): adiciona documentacao completa, licenca MIT e guia de tarefas da equipe"

# 7. Envie para o GitHub
git push origin feature/devops-documentacao
```
*Abra o Pull Request ou faça o merge na `main`.*

---

## 📊 Matriz Rápida de Comandos para Todos

| Objetivo | Comando |
| :--- | :--- |
| **Clonar repositório** | `git clone https://github.com/1Gapril/fintech-bank-xunit-no-GitHub.git` |
| **Restaurar e compilar** | `dotnet build` |
| **Rodar aplicação** | `dotnet run --project FintechBank.App/FintechBank.App.csproj` |
| **Rodar todos os testes** | `dotnet test` |
| **Verificar status do Git** | `git status` |
| **Atualizar branch main** | `git pull origin main` |

---

## ✅ Como Validar a Entrega Final

1. Acesse `https://github.com/1Gapril/fintech-bank-xunit-no-GitHub`.
2. Vá até a seção lateral direita **Contributors** e confira se aparecem os 4 avatares/nomes:
   - **1Gapril**
   - **caiovas28-dotcom**
   - **Lucas H. Miranda**
   - **Fernando Almeida de Oliveira Braga**
3. Confirme que o comando `dotnet test` passa com 100% de sucesso (8 testes no total: 4 para taxa, 2 para saque, 3 para parcelas por score e 2 para aprovação por margem).
