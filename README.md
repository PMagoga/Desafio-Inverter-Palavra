# Desafio-Inverter-Palavra

### Neste desafio do curso de C# da Microsoft devíamos escrever o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado.

Em outras palavras, não basta inverter todas as letras na variável pangram. Em vez disso, você precisará inverter apenas as letras de cada palavra, mas imprimir a palavra invertida em sua posição original na mensagem.

##### Para resolver o desafio, foi feito:

1. Dividir a cadeia de caracteres *pangram* no caractere de espaço para criar a matriz de cadeia de caracteres *message*.
1. Criar uma nova *newMessagematriz* que armazenará uma cópia invertida das cadeias de caracteres da “palavra" da matriz *message*.
1. Passar o loop por cada elemento na matriz *message*, revertê-lo e armazenar esse elemento na matriz *newMessage*.
1. Unir cadeias de caracteres "palavra" da matriz *newMessage*, usando novamente um espaço, para criar a cadeia de caracteres simples desejada a ser gravada no console.
