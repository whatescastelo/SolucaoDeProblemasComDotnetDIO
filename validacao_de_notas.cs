/*
DESAFIO
O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. 
Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa que leia as notas da primeira e da segunda avaliação 
de um aluno. Calcule e imprima a média semestral.

O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja 
ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa
para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

ENTRADA
O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro X . 
O programa deve parar quando o valor lido para este X for igual a 2.

SAÍDA
Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, deve ser impressa a mensagem 
“media = ” seguido do valor do cálculo.

Antes da leitura de X deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada 
padrão para X for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.

A média deve ser impressa com dois dígitos após o ponto decimal.
*/

using System;

class Desafio {
    static void Main() {
        double n1, n2;
        double res = 3;
        n1 = 11;
        n2 = 11;
        
        while(res != 2){
            while((n1<0)||(n1>10)){
                n1=double.Parse(Console.ReadLine());
                if((n1<0)||(n1>10)){
                    Console.WriteLine("nota invalida");
                }
            }
            
            while((n2<0)||(n2>10)){
                n2=double.Parse(Console.ReadLine());
                if((n2<0)||(n2>10)){
                    Console.WriteLine("nota invalida");
                }
            }
            
            double media = (n1+n2)/2;
            Console.Write("media = ");
            Console.WriteLine(media.ToString("N2"));
            
            
            while((res != 1)&&(res != 2)){
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                res = double.Parse(Console.ReadLine());
            }
            
            n1=11;
            n2=11;
            if(res != 2){
                res = 3;
            }
        
        }

    }
}
