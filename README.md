# Jogo da Velha

Este é um projeto de um jogo da velha (tic-tac-toe) desenvolvido em C#. Eu criei este projeto há algum tempo, quando estava começando a aprender a programar com C#, e achei interessante compartilhar este código.

## Como Funciona

O jogo da velha é um jogo simples para dois jogadores, onde cada jogador escolhe uma marca (X ou O) e tenta ser o primeiro a conseguir trás de suas marcas em uma linha horizontal, vertical ou diagonal em um tabuleiro 3x3.

## Estrutura do Projeto

### Program.cs

O arquivo `Program.cs` contém a classe `Program` com o método `Main`, que é o ponto de entrada do aplicativo. Ele chama o método `Show` da classe `Menu` para iniciar o menu do jogo.

### Menu.cs

O arquivo `Menu.cs` cont�m a classe `Menu`, que é responsável por exibir o menu inicial do jogo. Ele permite ao usu�rio iniciar o jogo ou sair. A classe possui métodos para desenhar a tela, escrever as opções e lidar com a escolha do usuário.

### JogoDaVelha.cs

O arquivo `JogoDaVelha.cs` contém a classe `JogoDaVelha`, que implementa a lógica principal do jogo da velha. Ele gerencia o estado do jogo, verifica as condições de vitória ou empate, e controla a vez dos jogadores. A classe também possui métodos para renderizar o tabuleiro, ler a escolha do usuário e reiniciar o jogo.

### Regras do Jogo

1. O jogo é jogado em um tabuleiro 3x3.
2. Dois jogadores se revezam para marcar os espaços no tabuleiro com X ou O.
3. O primeiro jogador a conseguir trás de suas marcas em uma linha (horizontal, vertical ou diagonal) vence.
4. Se todos os nove espaços estiverem marcados e nenhum jogador tiver trás marcas em linha, o jogo termina em empate.

## Como Executar

Para executar este projeto, você precisará do .NET 6 instalado em sua máquina. Siga os passos abaixo para rodar o jogo:

1. Clone este repositório para sua máquina local.
2. Abra o projeto em seu editor de código preferido (recomendado: Visual Studio).
3. Compile e execute o projeto.

Divirta-se jogando!


# Tic-Tac-Toe Game

This is a Tic-Tac-Toe (noughts and crosses) project developed in C#. I created this project some time ago when I was beginning to learn programming with C#, and I thought it would be interesting to share this code.

## How It Works

Tic-Tac-Toe is a simple two-player game where each player chooses a mark (X or O) and tries to be the first to get three of their marks in a horizontal, vertical, or diagonal line on a 3x3 board.

## Project Structure

### Program.cs

The `Program.cs` file contains the `Program` class with the `Main` method, which is the application's entry point. It calls the `Show` method from the `Menu` class to start the game menu.

### Menu.cs

The `Menu.cs` file contains the `Menu` class, which is responsible for displaying the game's main menu. It allows the user to start the game or exit. The class includes methods to draw the screen, display the options, and handle user selection.

### JogoDaVelha.cs

The `JogoDaVelha.cs` file contains the `JogoDaVelha` class, which implements the core logic of the Tic-Tac-Toe game. It manages the game's state, checks for win or draw conditions, and controls player turns. The class also includes methods to render the board, read user input, and restart the game.

### Game Rules

1. The game is played on a 3x3 board.
2. Two players take turns marking spaces on the board with X or O.
3. The first player to get three of their marks in a row (horizontally, vertically, or diagonally) wins.
4. If all nine spaces are filled and no player has three marks in a row, the game ends in a draw.

## How to Run

To run this project, you need to have .NET 6 installed on your machine. Follow these steps to run the game:

1. Clone this repository to your local machine.
2. Open the project in your preferred code editor (recommended: Visual Studio).
3. Compile and run the project.

Enjoy playing!



