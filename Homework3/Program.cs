﻿/*Программа рандомно генерирует число, пользователь должен угадать это число. При каждом вводе числа программа пишет больше или меньше отгадываемого. Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.
В отчёте написать, что именно сделано по каждому принципу.
Приложить ссылку на проект и написать, сколько времени ушло на выполнение задачи.*/

// Принцип единственной ответственности;
using Homework3;

internal class Program
{
    private static void Main(string[] args)
    {
        Game game = new Game();
        game.Start(); 
    }
}