#language: pt-br

Funcionalidade: Geração de Frases aleatórias
	Nosso cliente necessita de um gerador de frases para seu site de humor.
	Para isso, ele solicitou que fosse criado um gerador de frases que poderia 
	tanto indicar um índice para retornar uma frase fixa, quanto um gerador que retornasse
	frases aleatoriamente.

Cenário: Gerar frase por índice
	Dado que tenho o índice 2
	Quando chamo o método com o índice
	Então deve ser exibida a frase 'Eu gosto de picanha.'

Cenário: Gerar frase aleatória
	Dado que não tenho índice
	Quando chamo o método sem índice
	Então deve ser exibida qualquer frase