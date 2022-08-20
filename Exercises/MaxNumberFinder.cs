namespace App20220820.Exercises; 

public class MaxNumberFinder  : Exercise{

    public override string Name => "Buscar numero mayor de un array";
    public override string Description => "Crea una función que devuelva la posición del número mayor de un array.";
    
    public override void Execute() {
        var rows = InputUtils.GetNumber("Ingresa el número de filas: ", x => x > 0);
        var columns = InputUtils.GetNumber("Ingresa el número de columnas: ", x => x > 0);
        Console.WriteLine();
        var array = new int[rows, columns];
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < columns; j++) {
                array[i, j] = InputUtils.GetNumber($"Ingresa el valor de la posición [{i}, {j}] del arreglo: ");
            }
        }
        
        var maxNumber = int.MinValue;
        var iPosition = 0;
        var jPosition = 0;
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < columns; j++) {
                if(array[i, j] <= maxNumber) continue;
                maxNumber = array[i, j];
                iPosition = i;
                jPosition = j;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"El número mayor es: {maxNumber}");
        Console.WriteLine($"Su posición es: [{iPosition}, {jPosition}]");
        
    }
}