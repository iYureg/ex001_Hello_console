﻿//выводим таблицу умножения используя цикл в цикле

for (int i = 2; i <= 10; i++){
    for (int j = 2; j <= 10; j++){

    Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}