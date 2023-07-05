Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions

Public Class frmRecords
    Private accountsList As New List(Of Account)    'List of Accounts for Write operations
    Private formatter As New BinaryFormatter()      'BinaryFormatter to write data in accountsList to file
    Private stream As FileStream                    'Opens file to read from or write to
    Private reader As New BinaryFormatter()         'BinaryReader to read from file
    Private fp As String                            'File path - set from Form frmEntryPoint
    Public isNewFile As Boolean = False             'Boolean for formatting when creating a new File

    'Property to set and get file path for read and write operations
    Public Property FilePath As String
        Get
            Return fp
        End Get
        Set(value As String)
            fp = value
        End Set
    End Property

    'Handles Form.Load operation
    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate comboBox for savings type
        comboAccType.Items.Add(SavingsType.LOW_INTEREST)
        comboAccType.Items.Add(SavingsType.MEDIUM_INTEREST)
        comboAccType.Items.Add(SavingsType.HIGH_INTEREST)

        'Populate comboBox for term length
        comboTermLength.Items.Add(TermLengths.DAILY)
        comboTermLength.Items.Add(TermLengths.WEEKLY)
        comboTermLength.Items.Add(TermLengths.MONTHLY)
        comboTermLength.Items.Add(TermLengths.YEARLY)

        'When opening existing File, read from File and populate both DataGridView Controls and set which fields from CheckingAccount and SavingsAccount are visible to the user
        If isNewFile = False Then
            'Populate DataGridView Controls with CheckingAccount and SavingsAccount data from File
            PopulateDataGrid(FilePath)
            'Set which fields are displayed in DataGridView Controls
            SetGridViewColumns()
        End If
    End Sub

    'Clears all TextBoxes in groupBoxCheckingDetails
    Private Sub btnCheckingClear_Click(sender As Object, e As EventArgs) Handles btnCheckingClear.Click
        ClearTextBoxes("Checking")
    End Sub

    'Clears all TextBoxes and ComboBoxes in groupBoxSavingsDetails
    Private Sub btnSavingsClear_Click(sender As Object, e As EventArgs) Handles btnSavingsClear.Click
        ClearTextBoxes("Savings")
    End Sub

    'Adds Record to accountsList based on data in TextBoxes in groupBoxCheckingDetails if no file of the Type CheckingAccount with the entered account number exists in the accountsList
    Private Sub btnAddCheckingRecord_Click(sender As Object, e As EventArgs) Handles btnAddCheckingRecord.Click
        Dim accNum As String = txtBoxCheckingAccNum.Text            'Get entered Account Number
        Dim fName As String = txtBoxCheckingFName.Text              'Get entered First Name
        Dim lName As String = txtBoxCheckingLName.Text              'Get entered Last Name
        Dim accBalString As String = txtBoxCheckingAccBal.Text      'Get entered Account Balance 
        Dim accBal As Double = 0                                    'Holds parsed Account Balance
        Dim isValidAcc As Boolean = False                           'Used to determine whether entered Account Number refers to an existing Account in accountsList

        'Add all empty CheckingAccount TextBoxes that are empty to IEnumerable object
        Dim emptyBoxes =
            From control In groupBoxCheckingDetails.Controls
            Where TypeOf control Is TextBox
            Let box As TextBox = CType(control, TextBox)
            Where String.IsNullOrEmpty(box.Text)
            Order By box.TabIndex
            Select box

        If emptyBoxes.Count > 0 Then
            MessageBox.Show("Not all fields for Checking Account are filled.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            emptyBoxes.First().Focus()  'Set focus to first TextBox in emptyBoxes object
            Exit Sub
        Else
            'Search for CheckingAccount that has an Account Number that matches the user-entered Account Number
            For i As Integer = 0 To accountsList.Count - 1 Step 1
                If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.CheckingAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                    isValidAcc = True   'Set to true if CheckingAccount with user-entered Account Number exists
                End If
            Next

            If isValidAcc = False Then
                'Validate user input for Account Number, First Name, and Last Name
                Select Case False
                    Case ValidateInput(accNum, "^[0-9]+$", "Invalid Account number. Account numbers must contain only digits 0-9.")    'account number
                        txtBoxCheckingAccNum.Focus()    'Set focus to TextBox txtBoxCheckingAccNum
                        Exit Sub
                    Case ValidateInput(fName, "^[a-zA-Z]+$", "Invalid first name. First name must contain only letters.")     'first name
                        txtBoxCheckingFName.Focus()     'Set focus to TextBox txtBoxCheckingFName
                        Exit Sub
                    Case ValidateInput(lName, "^[a-zA-Z]+$", "Invalid last name. Last name must contain only letters.")    'last name
                        txtBoxCheckingLName.Focus()     'Set focus to TextBox txtBoxCheckingLName
                        Exit Sub
                End Select

                Try 'to parse to double
                    accBal = Double.Parse(accBalString)
                Catch ex As FormatException
                    MessageBox.Show("Invalid Account Balance. Account balance cannot contain letters or special characters, except ',' and '.'", "Account Balance Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBoxCheckingAccBal.Focus()    'Set focus to Textbox txtBoxCheckingAccBal
                    Exit Sub
                End Try

                'Create CheckingAccount to add to accountsList
                Dim acc As New CheckingAccount(accNum, fName, lName, accBal)
                accountsList.Add(acc)

                'Write accountsList to File
                WriteToFile("Checking")

                'Update DataGridView Controls
                PopulateDataGrid(FilePath)
            Else
                MessageBox.Show($"Account with nunmber {accNum} already exists. Enter an account number that is not currently in use.", "Account Exist Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtBoxCheckingAccNum.Focus()    'Set focus to TextBox txtBoxCheckingAccNum
            End If
        End If
    End Sub

    'Adds Record to accountsList based on data in TextBoxes in groupBoxSavingsDetails if no file of the Type SavingsAccount with the entered account number exists in the accountsList
    Private Sub btnAddSavingsRecord_Click(sender As Object, e As EventArgs) Handles btnAddSavingsRecord.Click
        Dim accNum As String = txtBoxSavingsAccNum.Text             'Get entered Account Number
        Dim fName As String = txtBoxSavingsFName.Text               'Get entered First Name
        Dim lName As String = txtBoxSavingsLName.Text               'Get entered Last Name
        Dim accBalString As String = txtBoxSavingsAccBal.Text       'Get entered AccountBalance
        Dim savType As SavingsType                                  'Holds user-selected SavingsType
        Dim termLength As TermLengths                               'Holds user-selected TermLength
        Dim accBal As Double = 0                                    'Holds parsed Account Balance
        Dim isValidAcc As Boolean = False                           'Used to determine whether entered Account Number refers to an existing Account in accountsList

        'Add all empty SavingsAccount TextBoxes that are empty to IEnumerable object
        Dim emptyBoxes =
            From control In groupBoxSavingsDetails.Controls
            Where TypeOf control Is TextBox
            Let box As TextBox = CType(control, TextBox)
            Where String.IsNullOrEmpty(box.Text)
            Order By box.TabIndex
            Select box

        If emptyBoxes.Count > 0 Then
            MessageBox.Show("Not all fields for Savings Account are filled.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            emptyBoxes.First().Focus()  'Set focus to first TextBox in emptyBoxes object
            Exit Sub
        Else
            'Search for SavingsAccount that has an Account Number that matches the user-entered Account Number
            For i As Integer = 0 To accountsList.Count - 1 Step 1
                If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.SavingsAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                    isValidAcc = True   'Set to true if SavingsAccount with user-entered Account Number exists
                End If
            Next

            If isValidAcc = False Then
                'Validate user input for Account Number, First Name, and Last Name
                Select Case False
                    Case ValidateInput(accNum, "^[0-9]+$", "Invalid Account number. Account numbers must contain only digits 0-9.")    'account number
                        txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
                        Exit Sub
                    Case ValidateInput(fName, "^[a-zA-Z]+$", "Invalid first name. First name must contain only letters.")     'first name
                        txtBoxSavingsFName.Focus()     'Set focus to TextBox txtBoxSavingsFName
                        Exit Sub
                    Case ValidateInput(lName, "^[a-zA-Z]+$", "Invalid last name. Last name must contain only letters.")    'last name
                        txtBoxSavingsLName.Focus()     'Set focus to TextBox txtBoxSavingsLName
                        Exit Sub
                End Select

                Try 'to parse to double
                    accBal = Double.Parse(accBalString)
                Catch ex As FormatException
                    MessageBox.Show("Invalid Account Balance. Account balance cannot contain letters or special characters, except ',' and '.'", "Account Balance Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBoxSavingsAccBal.Focus()    'Set focus to Textbox txtBoxSavingsAccBal
                    Exit Sub
                End Try

                'Check SavingsAccount ComboBoxes have selection made
                'comboAccType
                If comboAccType.SelectedIndex > -1 Then
                    savType = comboAccType.SelectedItem
                Else
                    MessageBox.Show("No Savings Account type selected. Please choose a Savings Account type.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                'comboTermLength
                If comboTermLength.SelectedIndex > -1 Then
                    termLength = comboTermLength.SelectedItem
                Else
                    MessageBox.Show("No Term Length selected. Please choose a term length.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                'Create SavingsAccount to add to accountsList
                Dim acc As New SavingsAccount(accNum, fName, lName, accBal, savType, termLength)
                accountsList.Add(acc)

                'Write accountsList to File
                WriteToFile("Savings")

                'Update DataGridView Controls
                PopulateDataGrid(FilePath)
            Else
                MessageBox.Show($"Account with nunmber {accNum} already exists. Enter an account number that is not currently in use.", "Account Exists Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
            End If
        End If


    End Sub

    'Updates information for existing CheckingAccount in accountsList with data entered into TextBoxes in GroupBox groupBoxCheckingDetails
    Private Sub btnUpdateCheckingRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateCheckingRecord.Click
        Dim accNum As String = txtBoxCheckingAccNum.Text            'Get entered Account Number
        Dim fName As String = txtBoxCheckingFName.Text              'Get entered First Name
        Dim lName As String = txtBoxCheckingLName.Text              'Get entered Last Name
        Dim accBalString As String = txtBoxCheckingAccBal.Text      'Get entered Account Balance 
        Dim accBal As Double = 0                                    'Holds parsed Account Balance
        Dim isValidAcc As Boolean = False                           'Used to determine whether entered Account Number refers to an existing Account in accountsList
        Dim accIndex As Integer                                     'Holds index where Account with user-entered account number is located in accountsList

        'Search for CheckingAccount that has an Account Number that matches the user-entered Account Number
        For i As Integer = 0 To accountsList.Count - 1 Step 1
            If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.CheckingAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                isValidAcc = True   'Set to true if CheckingAccount with user-entered Account Number exists
                accIndex = i        'Store location in accountsList of existing account 
            End If
        Next

        If isValidAcc = True Then
            'Add all empty CheckingAccount TextBoxes that are empty to IEnumerable object
            Dim emptyBoxes =
                    From control In groupBoxCheckingDetails.Controls
                    Where TypeOf control Is TextBox
                    Let box As TextBox = CType(control, TextBox)
                    Where String.IsNullOrEmpty(box.Text)
                    Order By box.TabIndex
                    Select box

            If emptyBoxes.Count > 0 Then
                MessageBox.Show("Not all fields for Checking Account are filled.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                emptyBoxes.First().Focus()  'Set focus to first TextBox in emptyBoxes object
                Exit Sub
            Else
                'Validate user input for Account Number, First Name, and Last Name
                Select Case False
                    Case ValidateInput(accNum, "^[0-9]+$", "Invalid Account number. Account numbers must contain only digits 0-9.")    'account number
                        txtBoxCheckingAccNum.Focus()    'Set focus to TextBox txtBoxCheckingAccNum
                        Exit Sub
                    Case ValidateInput(fName, "^[a-zA-Z]+$", "Invalid first name. First name must contain only letters.")     'first name
                        txtBoxCheckingFName.Focus()     'Set focus to TextBox txtBoxCheckingFName
                        Exit Sub
                    Case ValidateInput(lName, "^[a-zA-Z]+$", "Invalid last name. Last name must contain only letters.")    'last name
                        txtBoxCheckingLName.Focus()     'Set focus to TextBox txtBoxCheckingLName
                        Exit Sub
                End Select

                Try 'to parse to double
                    accBal = Double.Parse(accBalString)
                Catch ex As FormatException
                    MessageBox.Show("Invalid Account Balance. Account balance cannot contain letters or special characters, except ',' and '.'", "Account Balance Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBoxCheckingAccBal.Focus()    'Set focus to Textbox txtBoxCheckingAccBal
                    Exit Sub
                End Try

                'Create CheckingAccount to replace CheckingAccount at specified index in accountsList
                Dim acc As New CheckingAccount(accNum, fName, lName, accBal)
                accountsList(accIndex) = acc

                'Write accountsList to File
                WriteToFile("Checking")

                'Update DataGridView Controls
                PopulateDataGrid(FilePath)
            End If
        Else
            MessageBox.Show($"Account with nunmber {accNum} does not exist. Enter an account number that is currently in use to update fields data.", "Account Exist Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBoxCheckingAccNum.Focus()    'Set focus to TextBox txtBoxCheckingAccNum
        End If
    End Sub

    'Updates information for existing SavingsAccount in accountsList with data entered into TextBoxes in GroupBox groupBoxSavingsDetails
    Private Sub btnUpdateSavingsRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateSavingsRecord.Click
        Dim accNum As String = txtBoxSavingsAccNum.Text             'Get entered Account Number
        Dim fName As String = txtBoxSavingsFName.Text               'Get entered First Name
        Dim lName As String = txtBoxSavingsLName.Text               'Get entered Last Name
        Dim accBalString As String = txtBoxSavingsAccBal.Text       'Get entered AccountBalance
        Dim savType As SavingsType                                  'Holds user-selected SavingsType
        Dim termLength As TermLengths                               'Holds user-selected TermLength
        Dim accBal As Double = 0                                    'Holds parsed Account Balance
        Dim isValidAcc As Boolean = False                           'Used to determine whether entered Account Number refers to an existing Account in accountsList
        Dim accIndex As Integer                                     'Holds index where Account with user-entered account number is located in accountsList

        'Search for SAvingsAccount that has an Account Number that matches the user-entered Account Number
        For i As Integer = 0 To accountsList.Count - 1 Step 1
            If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.SavingsAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                isValidAcc = True   'Set to true if SavingsAccount with user-entered Account Number exists
                accIndex = i        'Store location in accountsList of existing account 
            End If
        Next

        If isValidAcc = True Then
            'Add all empty SavingsAccount TextBoxes that are empty to IEnumerable object
            Dim emptyBoxes =
                    From control In groupBoxSavingsDetails.Controls
                    Where TypeOf control Is TextBox
                    Let box As TextBox = CType(control, TextBox)
                    Where String.IsNullOrEmpty(box.Text)
                    Order By box.TabIndex
                    Select box

            If emptyBoxes.Count > 0 Then
                MessageBox.Show("Not all fields for Savings Account are filled.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                emptyBoxes.First().Focus()  'Set focus to first TextBox in emptyBoxes object
                Exit Sub
            Else
                'Validate user input for Account Number, First Name, and Last Name
                Select Case False
                    Case ValidateInput(accNum, "^[0-9]+$", "Invalid Account number. Account numbers must contain only digits 0-9.")    'account number
                        txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
                        Exit Sub
                    Case ValidateInput(fName, "^[a-zA-Z]+$", "Invalid first name. First name must contain only letters.")     'first name
                        txtBoxSavingsFName.Focus()     'Set focus to TextBox txtBoxSavingsFName
                        Exit Sub
                    Case ValidateInput(lName, "^[a-zA-Z]+$", "Invalid last name. Last name must contain only letters.")    'last name
                        txtBoxSavingsLName.Focus()     'Set focus to TextBox txtBoxSavingsLName
                        Exit Sub
                End Select

                Try 'to parse to double
                    accBal = Double.Parse(accBalString)
                Catch ex As FormatException
                    MessageBox.Show("Invalid Account Balance. Account balance cannot contain letters or special characters, except ',' and '.'", "Account Balance Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBoxSavingsAccBal.Focus()    'Set focus to Textbox txtBoxSavingsAccBal
                    Exit Sub
                End Try

                'Check SavingsAccount ComboBoxes have selection made
                'comboAccType
                If comboAccType.SelectedIndex > -1 Then
                    savType = comboAccType.SelectedItem
                Else
                    MessageBox.Show("No Savings Account type selected. Please choose a Savings Account type.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                'comboTermLength
                If comboTermLength.SelectedIndex > -1 Then
                    termLength = comboTermLength.SelectedItem
                Else
                    MessageBox.Show("No Term Length selected. Please choose a term length.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                'Create SavingsAccount to add to accountsList
                Dim acc As New SavingsAccount(accNum, fName, lName, accBal, savType, termLength)
                accountsList(accIndex) = acc

                'Write accountsList to File
                WriteToFile("Savings")

                'Update DataGridView Controls
                PopulateDataGrid(FilePath)
            End If
        Else
            MessageBox.Show($"Account with nunmber {accNum} already exists. Enter an account number that is not currently in use.", "Account Exist Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
        End If
    End Sub

    'Deletes existing CheckingAccount in accountsList with account number matching account number entered into TextBox txtBoxCheckingAccNum
    Private Sub btnDeleteCheckingRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteCheckingRecord.Click
        Dim accNum As String = txtBoxCheckingAccNum.Text            'Get entered Account Number
        Dim result As DialogResult                                  'Holds user decision after interacting with confirmation MessageBox
        Dim isValidAcc As Boolean = False                           'Used to determine whether entered Account Number refers to an existing Account in accountsList
        Dim accIndex As Integer                                     'Holds index where Account with user-entered account number is located in accountsList

        'Search for CheckingAccount that has an Account Number that matches the user-entered Account Number
        For i As Integer = 0 To accountsList.Count - 1 Step 1
            If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.CheckingAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                isValidAcc = True   'Set to true if CheckingAccount with user-entered Account Number exists
                accIndex = i        'Store location in accountsList of existing account 
            End If
        Next

        If isValidAcc = True Then
            'Ask user to confirm decision to remove record, save decision as DialogResult
            result = MessageBox.Show($"Are you sure you want to delete the record for account with number: {accNum}?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            'Remove CheckingAccount from accountsList if user chooses OK
            If result = DialogResult.OK Then
                'Remove CheckingAccount from accountsList
                accountsList.RemoveAt(accIndex)

                'Write accountsList to File
                WriteToFile("Checking")

                'Repopulate DataGridView Controls with updated Accounts
                PopulateDataGrid(FilePath)
            End If
        Else
            MessageBox.Show($"Account with nunmber {accNum} does not exist. Enter an account number that is currently in use.", "Non-Existant Account Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
        End If
    End Sub

    'Deletes existing SavingsAccount in accountsList with account number matching account number entered into TextBox txtBoxSavingsAccNum
    Private Sub btnDeleteSavingsRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteSavingsRecord.Click
        Dim accNum As String = txtBoxSavingsAccNum.Text         'Get entered Account Number
        Dim result As DialogResult                              'Holds user decision after interacting with confirmation MessageBox
        Dim isValidAcc As Boolean = False                       'Used to determine whether entered Account Number refers to an existing Account in accountsList
        Dim accIndex As Integer                                 'Holds index where Account with user-entered account number is located in accountsList

        'Search for SavingsAccount that has an Account Number that matches the user-entered Account Number
        For i As Integer = 0 To accountsList.Count - 1 Step 1
            If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.SavingsAccount") And accountsList(i).AccountNumber.Equals(accNum) Then
                isValidAcc = True   'Set to true if SavingsAccount with user-entered Account Number exists
                accIndex = i        'Store location in accountsList of existing account 
            End If
        Next

        If isValidAcc = True Then
            'Ask user to confirm decision to remove record, save decision as DialogResult
            result = MessageBox.Show($"Are you sure you want to delete the record for account with number: {accNum}?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            'Remove SavingsAccount from accountsList if user chooses OK
            If result = DialogResult.OK Then
                'Remove SavingsAccount from accountsList
                accountsList.RemoveAt(accIndex)

                'Write accountsList to File
                WriteToFile("Savings")

                'Repopulate DataGridView Controls with updated Accounts
                PopulateDataGrid(FilePath)
            End If
        Else
            MessageBox.Show($"Account with nunmber {accNum} does not exist. Enter an account number that is currently in use.", "Account Exist Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBoxSavingsAccNum.Focus()    'Set focus to TextBox txtBoxSavingsAccNum
        End If
    End Sub

    'Displays frmAbout to the user
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

        Enabled = False
    End Sub

    'Closes the current Form and re-enables Form frmEntryPoint to Create New File, Open Existing File, or Exit Application
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        frmEntryPoint.Enabled = True

        Me.Dispose()
    End Sub

    'Sets which Properties from CheckingAccount and SavingsAccount are visible to the user and in what order they are arranged
    Private Sub SetGridViewColumns()
        'CheckingAccount Columns
        DataGridViewChecking.Columns("AccountNumber").DisplayIndex = 0
        DataGridViewChecking.Columns("FirstName").DisplayIndex = 1
        DataGridViewChecking.Columns("LastName").DisplayIndex = 2
        DataGridViewChecking.Columns("AccountBalance").DisplayIndex = 3
        DataGridViewChecking.Columns("Type").Visible = False

        'SavingsAccount Columns
        DataGridViewSavings.Columns("SavingType").Visible = False
        DataGridViewSavings.Columns("TermLengthType").Visible = False
        DataGridViewSavings.Columns("Type").Visible = False
        DataGridViewSavings.Columns("AccountNumber").DisplayIndex = 0
        DataGridViewSavings.Columns("FirstName").DisplayIndex = 1
        DataGridViewSavings.Columns("LastName").DisplayIndex = 2
        DataGridViewSavings.Columns("AccountBalance").DisplayIndex = 3
        DataGridViewSavings.Columns("MinimumBalance").DisplayIndex = 4
        DataGridViewSavings.Columns("InterestRate").DisplayIndex = 5
        DataGridViewSavings.Columns("TermLength").DisplayIndex = 6

        isNewFile = False
    End Sub

    'Separates SavingsAccounts and CheckingAccounts into two separate Lists then adds the Lists to their corresponding DataGridView Controls
    Private Sub PopulateDataGrid(path As String)
        Dim record As Account   'Object to hold Accounts from File

        'Try to open and read from File
        Try
            'Open FileStream to read from file
            stream = New FileStream(FilePath, FileMode.Open, FileAccess.Read)

            accountsList.Clear()    'Clear accountsList to avoid duplicate records

            'Read from FileStream until end of Stream
            Do Until stream.Position = stream.Length
                'Read record from file and store in record variable
                record = CType(reader.Deserialize(stream), Account)

                accountsList.Add(record)    'Add record to accountsList
            Loop

            'Dispose FileStream
            stream.Dispose()
        Catch ex As IOException
            MessageBox.Show("Unable to open file. Please ensure selected file exists, then click the ""Open File..."" button to try again.")
            Exit Sub    'Exits PopulateDataGrid()
        End Try

        Dim savingsList As New List(Of SavingsAccount)      'List for SavingsAccounts
        Dim checkingList As New List(Of CheckingAccount)    'List for CheckingAccounts

        'Loop to sort Accounts by Type
        For i As Integer = 0 To accountsList.Count - 1 Step 1
            If accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.SavingsAccount") Then
                savingsList.Add(accountsList(i))    'Add element in accountsList with type SavingsAccount to savingsList
            ElseIf accountsList(i).GetType().ToString().Equals("AdvancedVbFinal.CheckingAccount") Then
                checkingList.Add(accountsList(i))   'Add element in accountsList with type CheckingAccount to checkingList
            End If
        Next

        DataGridViewSavings.DataSource = savingsList        'Set DataSource for DataGridViewSavings
        DataGridViewChecking.DataSource = checkingList      'Set DataSource for DataGridViewChecking

        'Set GridView Columns if the File being read from is was created using "New File..." Button
        If isNewFile = True Then
            SetGridViewColumns()
        End If
    End Sub

    'Writes contents of the accountsList to the selected storage location as serialized data
    Private Sub WriteToFile(type As String)
        'Write to serialized file
        Try
            'Open FileStream to truncate and write to existing File, or create and append to new File
            Dim stream As New FileStream(FilePath, FileMode.Create)

            'Write all Accounts in accountsList to File as serialized data
            For i As Integer = 0 To accountsList.Count - 1 Step 1
                formatter.Serialize(stream, accountsList(i))
            Next

            stream.Dispose()    'Dispose of FileStream  

            ClearTextBoxes(type)    'Clear all TextBoxes of any text

            'Inform user of successful write operation
            MessageBox.Show("Record successfully written ot file.", "Successful Write Operation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show("Unable to write to file. Please choose a new location to save to.", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Clears all TextBoxes on the Form
    Private Sub ClearTextBoxes(type As String)
        If type.Equals("Checking") Then
            'Clear Text from TextBoxes in CheckingAccounts GroupBox
            txtBoxCheckingAccNum.ResetText()
            txtBoxCheckingFName.ResetText()
            txtBoxCheckingLName.ResetText()
            txtBoxCheckingAccBal.ResetText()
        Else
            'Clear Text from TextBoxes in SavingsAccount GroupBox
            txtBoxSavingsAccNum.ResetText()
            txtBoxSavingsFName.ResetText()
            txtBoxSavingsLName.ResetText()
            txtBoxSavingsAccBal.ResetText()
            comboAccType.SelectedIndex = -1     'Reset selected item
            comboTermLength.SelectedIndex = -1  'Reset selected item
        End If
    End Sub

    'Using Regular Expressions, checks that entered data is formatted correctly
    Private Function ValidateInput(input As String, expression As String, message As String) As Boolean
        Dim valid As Boolean = Regex.Match(input, expression).Success   'Holds true if user input matches the expression passed to the method, false otherwise

        'Display error message if the input from TextBox does not match the expression passed to the method
        If Not valid Then
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Returns true or false
        Return valid
    End Function

    'Re-enables Form frmEntryPoint and disposes of this Form
    Private Sub frmRecords_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        frmEntryPoint.Enabled = True

        Me.Dispose()
    End Sub
End Class