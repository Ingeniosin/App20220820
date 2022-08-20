namespace App20220820.Exercises; 

public class SumOfArrays : Exercise{

    public override string Name => "Suma de arreglos";
    public override string Description => "Crea una función que devuelva la suma de un array.";
    
    public override void Execute() {
        
        var rows = InputUtils.GetNumber("Ingresa el número de filas: ", x => x > 0);
        var columns = InputUtils.GetNumber("Ingresa el número de columnas: ", x => x > 0);
        var quantity = InputUtils.GetNumber("Ingresa la cantidad de arreglos a sumar: ", x => x > 1);
        Console.WriteLine();
        var arrays = new int[quantity][,];
        
        for(var i = 0; i < quantity; i++) {
            var array = new int[rows, columns];
            for(var j = 0; j < rows; j++) {
                for(var k = 0; k < columns; k++) {
                    array[j, k] = InputUtils.GetNumber($"Ingresa el valor de la posición [{j}, {k}] del arreglo [{i + 1}]: ", x => x > 0);
                }
            }
            arrays[i] = array;
            Console.WriteLine();
        }

        var resultArray = arrays[0];
        for(var i = 1; i < quantity; i++) {
            var sumArray = arrays[i];
            for(var j = 0; j < rows; j++) {
                for(var k = 0; k < columns; k++) {
                    resultArray[j, k] += sumArray[j, k];
                }
            }
        }
        
        Console.WriteLine("La suma de los arreglos es: ");
        Console.WriteLine();
        InputUtils.PrintArray(resultArray);

    }
}