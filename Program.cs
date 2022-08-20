using App20220820;
using App20220820.Exercises;

var exercises = new List<Exercise>{
   new SumOfArrays(),
   new AverageOfAnArray(),
   new FillInArray(),
   new ArrayFinder(),
   new MaxNumber(),
    new MinNumber(),
    new MaxNumberFinder(),
    new MinNumberFinder(),
    new Countries()
};

while (true){
    var seleccion = InputUtils.GetOption("Ingrsa el ejercicio a ejecutar: ", exercises, x => $"{x.Name}: \n\t * {x.Description}", true);
    if (seleccion == null) break;
    Console.Clear();
    var initialTime = DateTime.Now.Ticks;
    seleccion.Execute();
    var finalTime = DateTime.Now.Ticks;
    var time = (finalTime - initialTime) / TimeSpan.TicksPerMillisecond;
    Console.WriteLine();
    Console.WriteLine($"Tiempo de ejecución: {time/1000}s");
    InputUtils.PressToContinue();
    Console.Clear();
}

InputUtils.PressToContinue();