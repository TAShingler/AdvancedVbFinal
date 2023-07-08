<Serializable()>
Public Class SavingsAccount
    Inherits Account

#Region "Fields"
    Private savType As SavingsType
    Private termLengthFrequency As TermLengths
    Private termLengthAmount As Integer
    Private intRate As Double
    Private minBalance As Double
    'Private projCounter As Integer = 0 'maybe don't include?
    'Private projectionsArr() As Double 'maybe don't include?
#End Region

#Region "Constructors"
    Sub New(number As String, fName As String, lName As String, balance As Double)
        MyBase.New(AccountType.SAVINGS, number, fName, lName, balance)
    End Sub

    Sub New(number As String, fName As String, lName As String, balance As Double, sType As SavingsType, length As TermLengths)
        MyBase.New(AccountType.SAVINGS, number, fName, lName, balance)

        SavingType = sType
        TermLengthType = length

        SetInterestRate(sType)
    End Sub
#End Region

#Region "Properties"
    Property SavingType As SavingsType
        Get
            Return savType
        End Get
        Set(value As SavingsType)
            savType = value
        End Set
    End Property

    Property TermLengthType As TermLengths
        Get
            Return termLengthFrequency
        End Get
        Set(value As TermLengths)
            termLengthFrequency = value

            Select Case value
                Case TermLengths.DAILY
                    TermLength = 365
                Case TermLengths.WEEKLY
                    TermLength = 52
                Case TermLengths.MONTHLY
                    TermLength = 12
                Case TermLengths.YEARLY
                    TermLength = 1
            End Select
        End Set
    End Property

    Property TermLength As Integer
        Get
            Return termLengthAmount
        End Get
        Set(value As Integer)
            termLengthAmount = value
        End Set
    End Property

    Property InterestRate As Double
        Get
            Return intRate
        End Get
        Set(value As Double)
            intRate = value
        End Set
    End Property

    Property MinimumBalance As Double
        Get
            Return minBalance
        End Get
        Set(value As Double)
            minBalance = value
        End Set
    End Property
#End Region

#Region "Other Methods"
    Private Sub SetInterestRate(type As SavingsType)
        Select Case type
            Case SavingsType.HIGH_INTEREST
                InterestRate = 0.015
                MinimumBalance = 100000.0
            Case SavingsType.MEDIUM_INTEREST
                InterestRate = 0.012
                MinimumBalance = 10000.0
            Case SavingsType.LOW_INTEREST
                InterestRate = 0.009
                MinimumBalance = 1000.0
        End Select
    End Sub
#End Region
End Class
