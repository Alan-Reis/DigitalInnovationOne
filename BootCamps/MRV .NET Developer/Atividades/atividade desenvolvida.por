programa
{
	
	funcao inicio ()
	{
		escreva("Qual operação deseja realizar? soma = 1, subtração = 2, multiplicação = 3, divisão = 4, sair = 5\n")
	     inteiro valor = 0
		real v1, v2, res
		logico sair
		sair = falso
		
		escreva ("Digite a operação necessária: ")
		leia (valor)

		//escreva("Deseja sair ? verdadeiro = sim e falso = não")	
		//leia(sair)

faca{

					
		escolha (valor) {
			caso 1:
			escreva ("Digite o valor: ")
			leia (v1)
			escreva ("Digite o valor: ")
			leia (v2)
			res = v1 + v2
			escreva("O resultado da soma é: " + res + "\n")	
			escreva("Qual operação deseja realizar? soma = 1, subtração = 2, multiplicação = 3, divisão = 4, sair = 5\n")
			leia(valor)
			pare

			caso 2:
			escreva ("Digite o valor: ")
			leia (v1)
			escreva ("Digite o valor: ")
			leia (v2)
			res = v1 - v2
			escreva("O resultado da subtração é: " + res + "\n")
			escreva("Qual operação deseja realizar? soma = 1, subtração = 2, multiplicação = 3, divisão = 4, sair = 5\n")
			leia(valor)
			pare

			caso 3:
			escreva ("Digite o valor: ")
			leia (v1)
			escreva ("Digite o valor: ")
			leia (v2)
			res = v1 * v2
			escreva("O resultado da multiplicação é: " + res + "\n")
			escreva("Qual operação deseja realizar? soma = 1, subtração = 2, multiplicação = 3, divisão = 4, sair = 5\n")
			leia(valor)
			pare

			caso 4:
			escreva ("Digite o valor: ")
			leia (v1)
			escreva ("Digite o valor: ")
			leia (v2)
			res = v1 / v2
			escreva("O resultado da divisão é: " + res + "\n")
			escreva("Qual operação deseja realizar? soma = 1, subtração = 2, multiplicação = 3, divisão = 4, sair = 5\n")
			leia(valor)
			pare

			caso 5:
			sair = verdadeiro
			pare
				
			}
} enquanto(sair == falso)
			
		}
		
	}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1665; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */