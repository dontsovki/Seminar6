// Программа с функциями и методами, которая будет преобразовывать десятичное число в двоичное.

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Revers(int [] array){
    
    int temp = 0;
    
    for (int i=0; i < array.Length/2; i++){
        temp = array[i];
        array[i] = array[(array.Length - 1) - i];
        array[(array.Length - 1) - i] = temp;
    }

    return array;
}

int [] intToBin(int num){
    
    int temp = num;
    int count = 0;

    while(Convert.ToBoolean(temp)){
        temp /= 2;
        count++;
    }


    int [] array = new int [count];

    for (int i=0; i < array.Length; i++){
        array[i] = num%2; 
        num /= 2;
    }
        
    Revers(array);

    return array;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
int [] array = intToBin(num);

ShowArray(array);


//Еще прискп кода
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string accumulator = "";

// while (number > 0)
// {
//     accumulator += number % 2;
//     number /= 2;
// }
   
 
// Console.Write(accumulator);

