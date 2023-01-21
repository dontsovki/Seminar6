// Программа с функциями и методами, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void checkTriangle(int [] array){  //Функция сравнения сторон треугольника

    if( array[0] < array[1]+array[2] && 
        array[1] < array[0]+array[2] &&
        array[2] < array[0]+array[1])
        Console.WriteLine("Такой триугольник существует");
    else
        Console.WriteLine("Такой триугольник не существует");

}

int [] array = CreateArray();

checkTriangle (array);

