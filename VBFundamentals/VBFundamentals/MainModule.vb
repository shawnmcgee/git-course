Module MainModule

    Sub Main()
        Dim products = LoadProducts()

        'Display the sum of all list prices
        Console.WriteLine(
            products.Sum(Function(p)
                             Return p.Value.ListPrice
                         End Function).ToString("c"))

        'Display the average of all list prices
        Console.WriteLine(
            products.Average(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the minimum of all list prices
        Console.WriteLine(
            products.Min(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the maximum of all list prices
        Console.WriteLine(
            products.Max(Function(p) p.Value.ListPrice).ToString("c"))

        Console.ReadKey()

    End Sub
End Module
