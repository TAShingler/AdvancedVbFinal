<Serializable()>
Public Class Account
#Region "Fields"
    Private accNumber As String
    Private accBalance As Double
    Private accFirstName As String
    Private accLastName As String
    Private accType As AccountType
#End Region

#Region "Constructors"
    Public Sub New(typeOfAccount As AccountType, number As String, fName As String, lName As String, balance As Double)
        Type = typeOfAccount
        AccountNumber = number
        FirstName = fName
        LastName = lName
        AccountBalance = balance
    End Sub
#End Region

#Region "Properties"
    Property AccountNumber As String
        Get
            Return accNumber
        End Get
        Set(value As String)
            accNumber = value
        End Set
    End Property

    Property AccountBalance As Double
        Get
            Return accBalance
        End Get
        Set(value As Double)
            accBalance = value
        End Set
    End Property

    Property FirstName As String
        Get
            Return accFirstName
        End Get
        Set(value As String)
            accFirstName = value
        End Set
    End Property

    Property LastName As String
        Get
            Return accLastName
        End Get
        Set(value As String)
            accLastName = value
        End Set
    End Property

    Property Type As AccountType
        Get
            Return accType
        End Get
        Set(value As AccountType)
            accType = value
        End Set
    End Property
#End Region

#Region "Other Methods"
    Public Sub DepositFunds(depositAmt As Double)

    End Sub

    Public Sub WithdrawFunds(withdrawalAmt As Double)

    End Sub
#End Region
End Class

'Enumeration of different Savings Account Types
Public Enum SavingsType
    LOW_INTEREST
    MEDIUM_INTEREST
    HIGH_INTEREST
End Enum

'Enumeration of different Savings Account Term Lengths
Public Enum TermLengths
    DAILY
    WEEKLY
    MONTHLY
    YEARLY
End Enum

'Enumeration of different Account Types
Public Enum AccountType
    SAVINGS
    CHECKING
End Enum