# desing-patterns-csharp

Creational  Desing Patterns

Factory Method: criação de objetos diferentes que implementam o mesmo método. 

No código está um exemplo de navio (Ship) e caminhão (Truck). Ambos são meios de transporte e implementam o método (Deliver) através da interface (Transport). 
Para instanciar o objeto utiliza-se a classe abstrata Creator e suas implementações para cada tipo de transporte ConcreteCreatorShip e ConcreteCreatorTruck. No Program, ao criar um objeto do tipo da interface Transport é possível escolher entre Navio e Caminhão, e chamar o método de entrega retornando o que é devido para cada classe de transporte.

---

Abstract Factory: criação de famílias de objetos

No código está um exemplo de objetos para cães: pote de água, coleira e pote de comida. A criação dos objetos alterna de acordo com o porte do animal: pequeno ou médio.
Ao criar um objeto pela interface IAbstractDogFoodPot, os métodos das outras interfaces IAbstractDogWaterPot e IAbstractDogCollar podem ser chamados, pois na interface IAbstractDogFoodPot são passadas "Interfaces colaboradoras" que são interfaces da mesma família.

---

Builder: criação de objetos em partes

No código está um exemplo de parcela (Installment) que pode ser criada com ou sem juros (taxes and fees). Dependendo do método chamado na classe "Director" um tipo de Installment será retornado. Completo (Full) ou sem taxas e juros (WithoutTaxesAndFees).

---
MonoState: criação de objetos que retornam sempre os mesmo valores

No código um exemplo de configuração do APP criada. Independente de quantas vezes e onde a configuração for criada, e posteriormente chamar a função GET para puxar um atributo irá recuperar sempre o valor do último SET. O padrão Singleton é considerado um anti-pattern, uma vez que fere os princípios do SOLID, e o MonoState é uma possível solução.
