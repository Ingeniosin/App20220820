namespace App20220820.Exercises; 

public class MaxNumber  : Exercise{

    public override string Name => "Numero mayor de un array";
    public override string Description => "Crea una función que devuelva el número mayor de un array.";
    
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
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < columns; j++) {
                if (array[i, j] > maxNumber) {
                    maxNumber = array[i, j];
                }
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"El número mayor es: {maxNumber}");
        
    }
}