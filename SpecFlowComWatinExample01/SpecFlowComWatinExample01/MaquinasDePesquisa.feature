#language: pt-br

Funcionalidade: Utilizar máquinas de pesquisa
	Como um usuário da internete, eu gostaria de pesquisar por resultados
	do nome da minha empresa nos principais mecanismos de busca, obtendo
	os links mais relevantes.

Cenário: Pesquisar no Bing
	Dado que estou na página home do Bing
	Quando eu digito 'Logical Docs' na caixa de texto
	E clico no botão 'Pesquisar'
	Então a tela me mostra os links que contém a expressão 'Logical Docs'