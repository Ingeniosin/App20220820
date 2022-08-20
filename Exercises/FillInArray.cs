namespace App20220820.Exercises; 

public class FillInArray : Exercise {

    public override string Name => "Rellenar arreglo.";
    public override string Description => "Rellenar una matriz pasada por parámetro con un valor dado.";
    public override void Execute() {
        var rows = InputUtils.GetNumber("Ingresa el número de filas: ", x => x > 0);
        var columns = InputUtils.GetNumber("Ingresa el número de columnas: ", x => x > 0);
        var quantity = InputUtils.GetNumber("Ingresa la cantidad de arreglos a ingresar: ", x => x > 1);
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

        for(var i = 0; i < quantity; i++) {
            var array = arrays[i];
            Console.WriteLine("Arreglo [{0}]:", i + 1);
            InputUtils.PrintArray(array);
            Console.WriteLine();
        }
        
    }
}