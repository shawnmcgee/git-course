Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        'Hard-Code an entity
        Entity = New Customer() With {.CustomerID = 1, .FirstName = "John", .LastName = "Snow", .CompanyName = "Beach Computer Consultants"}

        Return Entity
    End Function

End Class
