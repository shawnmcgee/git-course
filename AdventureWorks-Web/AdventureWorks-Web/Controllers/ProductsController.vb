Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductsController
        Inherits Controller

        ' GET: Products
        Function ProductList() As ActionResult
            'The below code won't be defined due to errors in the ProductViewModel code. 
            Dim vm As New ProductViewModel

            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace