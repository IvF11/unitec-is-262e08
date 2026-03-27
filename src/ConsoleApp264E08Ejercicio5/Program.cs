double radio = 5;
double altura = 10;
double perimetro = Figura264E08Ejercicio5.Perimetro(radio);
double area = Figura264E08Ejercicio5.Area(radio);
double volumen= Figura264E08Ejercicio5.volumen(area, altura);

Console.WriteLine($"El perimetro de un circulo de {radio}cm por pi por 2 es {perimetro}cm");
Console.WriteLine($"El area de un circulo es {radio}cm por radio por pi es {area}cm2");
Console.WriteLine($"El volumen de un cilindro con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");