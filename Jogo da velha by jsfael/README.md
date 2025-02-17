# Jogo da Velha

Este é um projeto de um jogo da velha (tic-tac-toe) desenvolvido em C#. Eu criei este projeto há algum tempo, quando estava começando a aprender a programar com C#, e achei interessante compartilhar este código.

## Como Funciona

O jogo da velha é um jogo simples para dois jogadores, onde cada jogador escolhe uma marca (X ou O) e tenta ser o primeiro a conseguir três de suas marcas em uma linha horizontal, vertical ou diagonal em um tabuleiro 3x3.

## Estrutura do Projeto

### Program.cs

O arquivo `Program.cs` contém a classe `Program` com o método `Main`, que é o ponto de entrada do aplicativo. Ele chama o método `Show` da classe `Menu` para iniciar o menu do jogo.

### Menu.cs

O arquivo `Menu.cs` contém a classe `Menu`, que é responsável por exibir o menu inicial do jogo. Ele permite ao usuário iniciar o jogo ou sair. A classe possui métodos para desenhar a tela, escrever as opções e lidar com a escolha do usuário.

### JogoDaVelha.cs

O arquivo `JogoDaVelha.cs` contém a classe `JogoDaVelha`, que implementa a lógica principal do jogo da velha. Ele gerencia o estado do jogo, verifica as condições de vitória ou empate, e controla a vez dos jogadores. A classe também possui métodos para renderizar o tabuleiro, ler a escolha do usuário e reiniciar o jogo.

### Regras do Jogo

1. O jogo é jogado em um tabuleiro 3x3.
2. Dois jogadores se revezam para marcar os espaços no tabuleiro com X ou O.
3. O primeiro jogador a conseguir três de suas marcas em uma linha (horizontal, vertical ou diagonal) vence.
4. Se todos os nove espaços estiverem marcados e nenhum jogador tiver três marcas em linha, o jogo termina em empate.

## Como Executar

Para executar este projeto, você precisará do .NET 6 instalado em sua máquina. Siga os passos abaixo para rodar o jogo:

1. Clone este repositório para sua máquina local.
2. Abra o projeto em seu editor de código preferido (recomendado: Visual Studio).
3. Compile e execute o projeto.

Divirta-se jogando!

