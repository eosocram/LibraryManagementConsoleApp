# 📚 Library Management Console App

## Missão 1 — Book

### Objetivo

Modelar a entidade Book.

### Conceitos aprendidos

- Modelagem de domínio
- Responsabilidade da entidade
- Construtor
- Enum
- Estado válido do objeto

### Dificuldades

- Diferença entre tipo, propriedade e parâmetro
- Ordem de inicialização

### Checklist

- [x] Criar Book
- [x] Criar construtor
- [x] Criar enum
- [x] Definir regras iniciais
- [ ] Criar objetos de teste

### Descoberta: Enum

Eu não entendia como relacionar o `enum` com a classe `Book`. Achava que criar o `enum` já fazia parte da entidade e não compreendia por que precisava de uma propriedade para armazenar a categoria.

O `enum` não armazena informações do objeto.

**O que entendi**

O `enum` apenas cria um novo tipo.

Ele não armazena informações do objeto.

Para que um `Book` possua uma categoria, é necessário criar uma propriedade desse tipo (`BookCategory`).
Ele apenas cria um novo tipo que limita os valores possíveis.

Exemplo:

- Tipo: `Category`
- Propriedade: `BookCategory`
- Parâmetro: `category`


## Missão 2 — Testando Objetos

### Objetivo

Validar se a entidade `Book` nasce em um estado válido ao ser instanciada.

### Conceitos aprendidos

- Instanciação de objetos
- Uso do construtor
- Criação de objetos no `Program.cs`
- Acesso às propriedades de um objeto
- Validação de regras de negócio

### Dificuldades

- Entender como visualizar um objeto no terminal
- Compreender que não existe, neste momento dos estudos, um comando que exiba automaticamente todas as propriedades de um objeto criado por mim

### Checklist

- [x] Criar um objeto `Book`
- [x] Instanciar utilizando o construtor
- [x] Exibir propriedades no terminal
- [x] Validar o uso do `enum`
- [x] Confirmar que `QuantityAvailable` recebe o mesmo valor de `QuantityTotal`

### Descoberta: Exibição de objetos

Durante os testes da entidade `Book`, imaginei que existisse um comando próprio do C# para exibir automaticamente todas as informações de um objeto criado por mim.

Minha dúvida não era como acessar uma propriedade específica, pois eu já sabia utilizar a sintaxe `objeto.Propriedade`.

A dúvida era se existia uma forma de visualizar o objeto inteiro de uma única vez.

O que aprendi foi que, neste momento dos meus estudos, sou eu quem escolho quais propriedades serão exibidas no terminal. Mais adiante, estudarei formas de definir como um objeto pode ser representado quando for exibido.

### Validação da regra de negócio

Criei um objeto `Book` e verifiquei, através do terminal, que a propriedade `QuantityAvailable` recebeu automaticamente o mesmo valor de `QuantityTotal`.

Esse teste confirmou que a regra implementada no construtor está funcionando corretamente e que o objeto nasce em um estado válido.