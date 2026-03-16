# ConsumerPokeApi

Aplicação Console em C# desenvolvida para consumir a API pública de Pokémon e exibir algumas informações de um personagem.

## Descrição

A aplicação solicita ao usuário o nome de um Pokémon e realiza uma requisição para a API da PokéAPI. Após receber a resposta, o programa exibe no console os seguintes dados do Pokémon informado:

* Id
* Nome
* Altura
* Peso

A API utilizada foi a **PokéAPI**.

## Tecnologias utilizadas

* C#
* .NET
* HttpClient
* JSON (System.Text.Json)

## Como executar o projeto

1. Clone o repositório

```
git clone https://github.com/seu-usuario/una-sdm-lista-06.git
```

2. Acesse a pasta do projeto

```
cd ConsumerPokeApi
```

3. Execute a aplicação

```
dotnet run
```

## Exemplo de uso

```
Digite o nome do Pokemon: pikachu

Dados do Pokemon:
Id: 25
Nome: pikachu
Altura: 4
Peso: 60
```

## Autor

Bernardo Araújo Silva
