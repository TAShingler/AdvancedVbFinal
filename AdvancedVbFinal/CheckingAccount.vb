<Serializable()>
Public Class CheckingAccount
    Inherits Account

#Region "Fields"

#End Region

#Region "Constructors"
    Public Sub New(number As String, fName As String, lName As String, balance As Double)
        MyBase.New(AccountType.CHECKING, number, fName, lName, balance)
    End Sub
#End Region

#Region "Properties"

#End Region

#Region "Other Methods"

#End Region
End Class
