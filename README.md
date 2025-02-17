# Jogo da Velha

Este � um projeto de um jogo da velha (tic-tac-toe) desenvolvido em C#. Eu criei este projeto h� algum tempo, quando estava come�ando a aprender a programar com C#, e achei interessante compartilhar este c�digo.

## Como Funciona

O jogo da velha � um jogo simples para dois jogadores, onde cada jogador escolhe uma marca (X ou O) e tenta ser o primeiro a conseguir tr�s de suas marcas em uma linha horizontal, vertical ou diagonal em um tabuleiro 3x3.

## Estrutura do Projeto

### Program.cs

O arquivo `Program.cs` cont�m a classe `Program` com o m�todo `Main`, que � o ponto de entrada do aplicativo. Ele chama o m�todo `Show` da classe `Menu` para iniciar o menu do jogo.

### Menu.cs

O arquivo `Menu.cs` cont�m a classe `Menu`, que � respons�vel por exibir o menu inicial do jogo. Ele permite ao usu�rio iniciar o jogo ou sair. A classe possui m�todos para desenhar a tela, escrever as op��es e lidar com a escolha do usu�rio.

### JogoDaVelha.cs

O arquivo `JogoDaVelha.cs` cont�m a classe `JogoDaVelha`, que implementa a l�gica principal do jogo da velha. Ele gerencia o estado do jogo, verifica as condi��es de vit�ria ou empate, e controla a vez dos jogadores. A classe tamb�m possui m�todos para renderizar o tabuleiro, ler a escolha do usu�rio e reiniciar o jogo.

### Regras do Jogo

1. O jogo � jogado em um tabuleiro 3x3.
2. Dois jogadores se revezam para marcar os espa�os no tabuleiro com X ou O.
3. O primeiro jogador a conseguir tr�s de suas marcas em uma linha (horizontal, vertical ou diagonal) vence.
4. Se todos os nove espa�os estiverem marcados e nenhum jogador tiver tr�s marcas em linha, o jogo termina em empate.

## Como Executar

Para executar este projeto, voc� precisar� do .NET 6 instalado em sua m�quina. Siga os passos abaixo para rodar o jogo:

1. Clone este reposit�rio para sua m�quina local.
2. Abra o projeto em seu editor de c�digo preferido (recomendado: Visual Studio).
3. Compile e execute o projeto.

Divirta-se jogando!

