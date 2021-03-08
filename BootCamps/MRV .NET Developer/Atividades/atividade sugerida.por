programa
{
	
	funcao inicio()
	{
		cadeia vendedor
		real Jan, Fev, Mar, Abr, Mai, Jun, Jul, Ago, Set, Out, Nov, Dez, media
		inteiro Ano

		escreva("-------------------------\n")
		escreva("-----Média de venda------\n")
		escreva("-------------------------\n")
		escreva("Digite o nome do vendedor: ")
		leia(vendedor)
		escreva("Digite o ano de venda: ")
		leia(Ano)
		escreva("Digite os valores correspondente a cada mês\n")
		escreva("Janeiro de " + Ano + " : ")
		leia(Jan)
		escreva("Fevereiro de " + Ano + " : ")
		leia(Fev)
		escreva("Março de " + Ano + " : ")
		leia(Mar)
		escreva("Abril de " + Ano + " : ")
		leia(Abr)
		escreva("Maio de " + Ano + " : ")
		leia(Mai)
		escreva("Junho " + Ano + " : ")
		leia(Jun)
		escreva("Julho de " + Ano + " : ")
		leia(Jul)
		escreva("Agosto de " + Ano + " : ")
		leia(Ago)
		escreva("Setembro de " + Ano + " : ")
		leia(Set)
		escreva("Outubro de " + Ano + " : ")
		leia(Out)
		escreva("Novembro de " + Ano + " : ")
		leia(Nov)
		escreva("Dezembro de " + Ano + " : ")
		leia(Dez)
		media =  (Jan + Fev + Mar + Abr + Mai + Jun + Jul + Ago + Set + Out + Nov + Dez)/12
		escreva("A média de venda de " + vendedor + " no ano de " + Ano + " foi de " + media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 122; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */