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