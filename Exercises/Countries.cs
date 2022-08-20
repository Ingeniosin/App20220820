namespace App20220820.Exercises; 

public class Countries : Exercise{

    public override string Name => "Paises";
    public override string Description => "Crea un programa que pida por pantalla cuatro países y a continuación tres ciudades de cada uno de estos países. Los nombres de ciudades deben almacenarse en un array multidimensional cuyo primer índice sea el número asignado a cada país y el segundo índice el número asignado a cada ciudad.";
    
    public override void Execute() {
        var countries = new string[4];
        var cities = new string[4, 3];
        for (var i = 0; i < countries.Length; i++) {
            countries[i] = InputUtils.GetText($"Introduce el nombre del país {i + 1}: ");
            for (var j = 0; j < cities.GetLength(1); j++) {
                cities[i, j] = InputUtils.GetText($"Introduce el nombre de la ciudad {j + 1}: ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Los países son:");
        foreach (var country in countries) {
            Console.WriteLine(country);
        }
        
        Console.WriteLine("Las ciudades son:");
        for (var i = 0; i < cities.GetLength(0); i++) {
            for (var j = 0; j < cities.GetLength(1); j++) {
                Console.WriteLine($"{cities[i, j]}");
            }
        }
    }
}