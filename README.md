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

--

# 🧮 Modelo Strategy + Factory para Cálculo de Parcelas

![Diagrama de Classes](./strategy%2Bfactory/InstallmentCalculator.png)

---

## 🧭 Single Responsibility Principle (SRP)

Aplicação do SRP no design das classes:

---

### 📦 Classes de Modelagem

| Classe                         | Responsabilidade                                                                 |
|-------------------------------|-----------------------------------------------------------------------------------|
| `Contract`                    | Representa a entidade Contrato.                                                   |
| `Installment`                 | Representa a entidade Parcela.                                                    |
| `ContractType` (enum)         | Enumera os tipos de contrato.                                                    |
| `CalculationContext`          | Agrupa `Contract` e `Installment` para serem usados como contexto nos cálculos.  |
| `InstallmentCalculationResult`| Armazena os resultados dos cálculos realizados sobre cada parcela.               |

---

### ⚙️ Classes de Regras de Cálculo

| Classe              | Responsabilidade                                                                 |
|---------------------|-----------------------------------------------------------------------------------|
| `ICalculationRule`  | Interface base para qualquer regra de cálculo implementar o método `Apply`.       |
| `MoraRule`          | Aplica a regra de **mora** com base na taxa contratual.                          |
| `MultaRule`         | Aplica a regra de **multa** com base na taxa contratual.                         |
| `ResidualRule`      | Aplica a regra de **resíduo**, caso o contrato tenha esse valor.                 |
| `InflactionCorrectionRule` | Aplica a correção por **inflação/deflação** com base no índice.      |
| `DiscountRule`      | Aplica a regra de **desconto** com base na taxa contratual.                      |

---

### 🏭 Classes Factory para Sequenciamento das Regras

| Classe                     | Responsabilidade                                                                 |
|----------------------------|-----------------------------------------------------------------------------------|
| `ICalculationRuleFactory` | Interface para criar uma sequência de regras de cálculo.                         |
| `CalculationRuleFactory`  | Implementa a interface, instanciando as regras (`ICalculationRule`) conforme o contrato. |

---

### 🧰 Classe de Serviço

| Classe             | Responsabilidade                                                                                   |
|--------------------|-----------------------------------------------------------------------------------------------------|
| `CalculationService` | Serviço que executa o cálculo das parcelas: recebe um contrato (via requisição ou processo cron), cria as regras com a factory e aplica os cálculos para cada parcela. |

---

## 📌 Observações

- Cada classe tem **uma única responsabilidade clara**, respeitando o **Single Responsibility Principle (SRP)**.
- O uso do padrão **Strategy** permite que cada regra de cálculo seja isolada, testável e intercambiável.
- A **Factory** centraliza a criação e ordenação das regras, facilitando a manutenção e extensão do sistema.

---

