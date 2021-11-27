// See https://aka.ms/new-console-template for more information
 int inicio, fim;

Console.Write("Início: ");
inicio = Convert.ToInt32(Console.ReadLine());
Console.Write("Fim: ");
fim = Convert.ToInt32(Console.ReadLine());
if(inicio<fim){
        while(inicio<=fim){
            Console.Write($"{inicio}.. ");
            inicio += 1;
        }
}else{
    Console.Write("Erro, o final é menor que o começo.");
}