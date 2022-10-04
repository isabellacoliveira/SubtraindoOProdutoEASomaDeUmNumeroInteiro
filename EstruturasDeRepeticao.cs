using exercicios_js.Models;
// fazer tabuada de determinado numero 
let numero = 5; 
// declaração da variavel, condição e incremento
for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
}
// contador :  auxilia o laço 
// até que número 

// para usar, temos que garantir que não caia num laço infinito de repetição
int numero = 5; 
int contador = 1; 
// int auxiliar = 0;

// desse jeito ele ficará executando infinitamente pois essa condição pois contador é sempre igual a 0 
while (contador <= 10)
{
    Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
    contador++; 
    // auxiliar++; // vai executar pra sempre 
    if(contador == 6) {
        break; 
    } // vai parar mesmo que a condição ainda seja verdadeira 
}
// podemos interromper o loop antes dele acabar colocando break

// Do while : sua verificação é executada no final do código 
// vamos executar o código independente da sua condição 
// posso declarar várias variáveis do mesmo tipo numa única linha
int soma = 0, numero = 0; 
// normalmente ele nem entraria no laço , porém ele vai entrar por causa do "do"

do // vai continuar enquanto o número for diferente de 0 
{

    Console.WriteLine("Digite um número (0 para parar a condição)"); 
    numero = Convert.ToInt32(Console.ReadLine()); // queremos pegar no input do usuário, o readline vai retornar uma string 
    // o read line não funciona no visual studio 
    // ir no arquivo json e alterar o console: internalConsole para integratedTerminal + salvar (terminal)
    soma += numero; 

} while (numero != 0); 

Console.WriteLine($"Total da soma de números digitados é {soma}"); 

// construindo um menu interativo 
string opcao; 
bool exibirMenu = true; 

while(exibirMenu) { // infinito até a opção encerrar 
    Console.Clear() // para limpar o console
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
// obter comando do usuario pelo terminal 
    opcao =  Console.ReadLine(); // pegar o que ele está digitando 

        switch(opcao) {
            case "1"; 
                Console.WriteLine("Cadastro do cliente");
            break; 
            case "2"; 
                Console.WriteLine("Busca do cliente");
            break; 
            case "3"; 
                Console.WriteLine("Apagar cliente");
            break; 
            case "4"; 
                Console.WriteLine("Encerrar");
                exibirMenu = false; // assim ele não executa 
                // Environment.Exit(0); // para que ele saia do progama caso seja essa opção , não executa + nd
                // não executa nada dos códigos depois
            break; 
           
            default; 
                Console.WriteLine("Opção inválida");
            break; 
        }

}
Console.WriteLine("O progama se encerrou");
// se quisermos que ele execute essa linha 



















