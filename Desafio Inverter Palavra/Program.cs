// Este é um simples programa que inverte as palavras de uma frase

string pangram = "Este é um simples programa que inverte as palavras de uma frase";

// passo 1
string[] message = pangram.Split(' ');

// passo 2
string[] newMessage = new string[message.Length];

// passo 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

// passo 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);