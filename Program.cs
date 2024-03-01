
using System;
using System.Collections.Generic;

public class CoinChangeCalculator {
    public static HashSet<int[]> MakeChange(int n) {
        // Inicializa o conjunto vazio para guardar os centavos
        var resultSet = new HashSet<int[]>();

        // Loop para centavos (25 cents)
        for (int quarters = 0; quarters <= n / 25; quarters++) {
            // Loop para dimes (10 cents)
            for (int dimes = 0; dimes <= (n - 25 * quarters) / 10; dimes++) {
                // Loop para nickels (5 cents)
                for (int nickels = 0; nickels <= (n - 25 * quarters - 10 * dimes) / 5; nickels++) {
                    // Calcula os pennies (1 cent) restantes
                    int pennies = n - 25 * quarters - 10 * dimes - 5 * nickels;

                    // Adiciona a combinação de resultados
                    resultSet.Add(new int[] { quarters, dimes, nickels, pennies });
                }
            }
        }

        // Retorno
        return resultSet;
    }

    public static void Main(string[] args) {
        // Exemplo de uso: n = 12
        int n = int.Parse(Console.ReadLine());
        var result = MakeChange(n);
        Console.WriteLine($"Representações de {n} centavos:");
        foreach (var entry in result) {
            Console.WriteLine($"[{entry[0]}, {entry[1]}, {entry[2]}, {entry[3]}]");
        }
    }
}
