Console.WriteLine("Ingrese las tres notas parciales:");
int CP1 = int.Parse(Console.ReadLine());
int CP2 = int.Parse(Console.ReadLine());
int CP3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su nota de examen final");
int CEF = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su nota de trabajo final");
int CTF = int.Parse(Console.ReadLine());

double NF = 0.55 * (CP1 + CP2 + CP3) / 3 + 0.30 * CEF + 0.15 * CTF;

Console.WriteLine("Su nota final es " + NF);