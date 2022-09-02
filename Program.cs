Console.WriteLine ("Escriba su nombre");
string nombre = Console.ReadLine ();

Console.WriteLine ("Ingrese su cc");
int cc = Convert.ToInt32( Console.ReadLine ());

Console.WriteLine ("Ingrese la cantidad de su saldo");
int saldo = Convert.ToInt32( Console.ReadLine ());

if (saldo >= 2500000) {
   Console.WriteLine (" 1 Mercedez benz S560");
   Console.WriteLine (" 2 Audi A142");
   Console.WriteLine (" 3 Tezla D231");
} else {
    Console.WriteLine (" 4 Chevrolet F2");
    Console.WriteLine (" 5 Renaul 211");
    Console.WriteLine (" 6 Mazda R1");
}

Console.WriteLine ("Que aunto desea comprar");
int comprar = Convert.ToInt32(Console.ReadLine ());

switch (comprar) {

case 1: 
   Console.WriteLine("usted compro el auto Mercedez Benz");
   break;

case 2:
   Console.WriteLine(" usted compro el auto Audi A142");
   break;

case 3: 
   Console.WriteLine("usted compro el auto Tezla D231");
   break;

   default:  

case 4:
   Console.WriteLine("usted compro el auto chevrolet F2");
   break;

case 5:
   Console.WriteLine("usted compro el auto Renaul 211");
   break;

case 6:
   Console.WriteLine("usted compro el auto Mazda R1");
    break;

}
Console.WriteLine("felicitaciones compra exitosa");





