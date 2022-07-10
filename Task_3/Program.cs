//Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n_inv =n*-1;
while (n_inv<=n) {
    if (n_inv!=n){
        Console.Write(n_inv);
        Console.Write(", ");
    }
    else{
        Console.Write(n_inv);
        Console.Write(".");
    }
    n_inv++;
}
