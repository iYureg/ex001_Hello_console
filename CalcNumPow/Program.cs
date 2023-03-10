// вычислить a в степени n


// через for
int PowerFor(int a, int n){
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// рекурсия

int PowerRec(int a, int n){
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    // if(n == 0) return 1;
    // else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));