namespace App20220820.Exercises; 

public class AverageOfAnArray : Exercise {

    public override string Name => "Media de un arreglo";
    public override string Description => "Crea una función que devuelva la media de un array.";
    
    public override void Execute() {
        
        var size = InputUtils.GetNumber("Ingresa el tamaño del arreglo: ", x => x > 0);
        var array = new int[size];
        for (var i = 0; i < size; i++) {
            array[i] = InputUtils.GetNumber($"Ingresa el valor para la posicion [{i + 1}]: ");
        }
        
        var sum = 0;
        foreach (var item in array) {
            sum += item;
        }
        
        var average = sum / array.Length;
        Console.WriteLine();
        Console.Write($"La media para: [");
        InputUtils.PrintArray(array, false);
        Console.WriteLine($"], es: {average}");
        
    }
}