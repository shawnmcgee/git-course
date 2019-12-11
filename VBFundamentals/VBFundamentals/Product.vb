Public Class Product
    Inherits CommonBase

    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now

    End Sub

    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime
    'Shared Function CalculateTheProfit(ByVal cost As Decimal, ByVal )
End Class
