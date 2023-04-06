#language: pt-br

Funcionalidade: Pesquisa do Google
	Para verificar se existe alguma página sobre o conteúdo "Hello World",
	devo receber uma lista com os itens relacionados assim que pesquisar
	por estas palavras chave.

Cenário: Pesquisa por Hello World
	Dado que estou na home page do Google
	Quando digito 'Hello World' na caixa de pesquisa
	E clico no botão de pesquisa
	Então recebo uma lista de links relacionados com Hello World