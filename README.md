# 🔐 Controle de Acesso — C#

Sistema de controle de acesso desenvolvido em **C#**, utilizando uma aplicação de console. O projeto foi criado para praticar lógica de programação, estruturas condicionais, estruturas de repetição e manipulação de listas, como parte dos meus estudos de Back-end com .NET e Cibersegurança.

## 🚀 Funcionalidades

* **Autenticação:** login com senha e limite de três tentativas.
* **Cadastro de usuários:** adição de novos usuários com validação de nomes.
* **Listagem de usuários:** exibição de todos os usuários cadastrados.
* **Consulta de permissões:** submenu com os perfis Administrador, Moderador e Usuário.
* **Relatório:** listagem de usuários, quantidade de cadastrados e identificação das permissões do perfil atual.
* **Validação de entradas:** tratamento de opções inválidas nos menus.

## 🛠️ Tecnologias utilizadas

* C#
* .NET — aplicação de console
* `List<string>` para armazenamento dos usuários em memória

## 📚 Conceitos praticados

* Variáveis, tipos de dados e operadores
* Estruturas condicionais: `if`, `else if`, `else` e `switch`
* Estruturas de repetição: `while`, `do while`, `for` e `foreach`
* Manipulação de listas com `Add()` e `Count`
* Validação com `int.TryParse()` e `string.IsNullOrWhiteSpace()`

## ▶️ Como executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou no VS Code com o SDK do .NET instalado.
3. Execute a aplicação pelo ambiente de desenvolvimento ou utilize o comando abaixo na pasta que contém o arquivo `.csproj`:

```bash
dotnet run
```

4. Faça login e utilize o menu interativo para acessar as funcionalidades.

## 🔒 Observações de segurança

Este é um projeto educacional. A autenticação utiliza uma senha fixa definida no código, e os usuários são armazenados apenas em memória. O sistema não deve ser utilizado como solução de autenticação em produção.

---

**Desenvolvido por Ana Beatriz** como parte dos estudos de Back-end C#/.NET + Cibersegurança.
