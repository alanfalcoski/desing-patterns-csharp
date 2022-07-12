using MonoState;

/* 
   MonoState - Com um atributo static simula o comportamento do Singletom.
   Com 'n' instâncias criadas retornará sempre o último valor setado.   
*/

AppConfig appConfig = new AppConfig();
appConfig.setKey("value");
AppConfig appConfig2 = new AppConfig();

Console.WriteLine(appConfig.getData());
Console.WriteLine(appConfig2.getData());

appConfig2.setKey("value again");
Console.WriteLine(appConfig.getData());
Console.WriteLine(appConfig2.getData());

Console.ReadKey();