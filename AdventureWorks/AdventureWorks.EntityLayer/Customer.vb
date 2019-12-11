Imports Common.Library

Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String


End Class
