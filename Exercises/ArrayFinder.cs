namespace App20220820.Exercises; 

public class ArrayFinder : Exercise {

    public override string Name => "Buscador de matrices";
    public override string Description => "Indicar si una posición (fila y columna) esta dentro de una matriz.";
    
    public override void Execute() {
        var rows = InputUtils.GetNumber("Ingresa el número de filas: ", x => x > 0);
        var columns = InputUtils.GetNumber("Ingresa el número de columnas: ", x => x > 0);
        
        var array = new int[rows, columns];
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < columns; j++) {
                array[i, j] = InputUtils.GetNumber($"Ingresa el valor de la posición [{i}, {j}] del arreglo: ");
            }
        }
        
        Console.WriteLine();

        while(true) {
            var searchRow = InputUtils.GetNumber("Ingresa la fila a buscar: ");
            var searchColumn = InputUtils.GetNumber("Ingresa la columna a buscar: ");

            var isValid = true;
            if(!(searchRow >= 0 && searchRow < rows)) {
                Console.WriteLine("La fila no existe.");
                isValid = false;
            }
            if(!(searchColumn >= 0 && searchColumn < columns)) {
                Console.WriteLine("La columna no existe.");
                isValid = false;
            }
            Console.WriteLine();
            if(!isValid) continue;
            var value = array[searchRow, searchColumn];
            Console.WriteLine($"El valor de la posición [{searchRow}, {searchColumn}] es: {value}");
            Console.WriteLine();
            var option = InputUtils.GetText("Ingresa q para salir o cualquier otra tecla para seguir buscando: ");
            if (option.ToLower().Trim() == "q") break;
        }
        
     
        
        
        
    }
}