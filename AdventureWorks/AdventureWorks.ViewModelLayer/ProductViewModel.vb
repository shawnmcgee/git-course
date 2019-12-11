Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library


Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProducts()
    End Sub

    Public Property Products As ObservableCollection(Of Product)
    Public Property Entity As Product

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        'Create a new instance of the product manager class

        'The below code was commented out due to missing information for the DataLayer solution. We don't have XML files that were used in the course. 
        'Dim mgr = New ProductManager

        'Hard-code an entity
        'Entity = New Product() With {.ProductID = 680, .Name = "HL Road Frame - Black, 58", .ProductNumber = "FR-R92B-58", .Color = "Black", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 69.99D}

        'The below code was commented out due to the issue on line 24.
        'Products = mgr.LoadProducts(startingFilePath)

        Return Products
    End Function

End Class


