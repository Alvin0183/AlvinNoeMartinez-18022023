using TareaSem4.Entidades;
using TareaSem4.Negocio;

//Hola ingeniero

ContadorLetras contadorLetras = new ContadorLetras();
ClsContadorLetras clsContadorLetras = new ClsContadorLetras();


Console.WriteLine("Por favor, ingrese una palabra a continuacion: ");

String pollo = Console.ReadLine();

contadorLetras.palabra = pollo;

int result = clsContadorLetras.contador(contadorLetras);


Console.WriteLine($"La cantidad de letras que se ingresaron es: {result}"); 