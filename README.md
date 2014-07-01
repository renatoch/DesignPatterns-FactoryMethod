Roteiro
-------
	- Implementa��o sem factory method
	- Mudar o tipo de jogo - onde que muda c�digo (cliente e dll)
	- Implementar factory method
	- Mudar tipo do jogo  no config
	- Criar classe nova JogoDeBasquete, e mostrar onde muda c�digo
	- Defini��o, e que outros tipos tem
		? Define uma interface para cria��o de objeto, por�m deixa as sub-classes decidirem qual classe instanciar. Permite adiar instanciamento para sub-classes.
			� Definir tipo de objeto a criar em tempo de execu��o
			� Abstract Factory - Mudar Factory para quando est� em testes ou em prod
		? Exemplo que dei � de parametrizada
		? Outra factory: Abstract Factory
		? Sugest�es de refactor
		? Sugest�es de outras implementa��es de factory method 
			� Create abstrato, e sub-classe que implementa instanciamento
	
	
Refer�ncias
-------
	Simple Factory vs. Factory Method vs. Abstract Factory
		http://corey.quickshiftconsulting.com/blog/first-post
	Refactor step by step para passar a usar factory method
		http://sourcemaking.com/refactoring/replace-constructor-with-factory-method
