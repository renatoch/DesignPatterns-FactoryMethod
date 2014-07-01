Roteiro
-------
	- Implementação sem factory method
	- Mudar o tipo de jogo - onde que muda código (cliente e dll)
	- Implementar factory method
	- Mudar tipo do jogo  no config
	- Criar classe nova JogoDeBasquete, e mostrar onde muda código
	- Definição, e que outros tipos tem
		? Define uma interface para criação de objeto, porém deixa as sub-classes decidirem qual classe instanciar. Permite adiar instanciamento para sub-classes.
			§ Definir tipo de objeto a criar em tempo de execução
			§ Abstract Factory - Mudar Factory para quando está em testes ou em prod
		? Exemplo que dei é de parametrizada
		? Outra factory: Abstract Factory
		? Sugestões de refactor
		? Sugestões de outras implementações de factory method 
			§ Create abstrato, e sub-classe que implementa instanciamento
	
	
Referências
-------
	Simple Factory vs. Factory Method vs. Abstract Factory
		http://corey.quickshiftconsulting.com/blog/first-post
	Refactor step by step para passar a usar factory method
		http://sourcemaking.com/refactoring/replace-constructor-with-factory-method
