Imports System
Imports System.IO
Imports System.Math

Public Class Form2
    'Declare arrays where the values will be saved after input.
    'Declare an array to serve for identifying what cluster the values belong to.
    'Then declare a counter so the program is aware of how many values were entered.
    'Finally declare a variable used to concatenate and present the values in the list box.
    Dim firstArr(49) As Double
    Dim secArr(49) As Double
    Dim clustArr(49) As Double
    Dim Counter As Integer = 0
    Dim inputCheck As Boolean = False
    Dim SSEtotal As Double = 0
    Dim finalClusters(5, 1) As Double
    Dim clusterAmt As Integer




    Private Sub ReturntoForm1_Click(sender As Object, e As EventArgs) Handles ReturntoForm1.Click
        'Hides the current form and shows the first form
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub InsertObject_Click(sender As Object, e As EventArgs) Handles InsertObject.Click
        'If the counter is 50 then exit the sub, otherwise
        'Add attributes to holding arrays, increase counter, and display counter & values of attributes
        If Counter > 49 Then
            MsgBox("Entered maximum of 50 numbers")
            Exit Sub
        End If

        firstArr(Counter) = Attribute1TextBox.Text
        secArr(Counter) = Attribute2TextBox.Text
        ListBox1.Items.Add(CStr(firstArr(Counter)) + "  " + CStr(secArr(Counter)))
        Counter += 1
        AmtEnteredShow.Text = CStr(Counter)

        Attribute1TextBox.Clear()
        Attribute1TextBox.Focus()
        Attribute2TextBox.Clear()

        Dim dummyCheck As Integer = clusterAmtUpDown.Value
        'Must have at least this many counted in
        If ListBox1.Items.Count > dummyCheck + 2 Then
            KmeansButton.Enabled = True
            KmediodButton.Enabled = True
        End If
        InsRandButton.Enabled = False
        FileInsertButton.Enabled = False
    End Sub

    Private Sub InsRandButton_Click(sender As Object, e As EventArgs) Handles InsRandButton.Click
        Dim i As Integer
        Dim rnd As New Random()
        Dim rnd2 As New Random()
        'Generate number between one and 99.999999999999978.
        'Put it into the arrays and the listbox
        For i = 0 To 49
            firstArr(i) = rnd.NextDouble() * 100
            secArr(i) = rnd2.NextDouble() * 50
            ListBox1.Items.Add(firstArr(i).ToString("n2") + "  " + CStr(secArr(i).ToString("n2")))
        Next

        'Set global counter automatically to 50
        Counter = 50
        'Arbitrary value to make sure you cannot add values manually.
        inputCheck = True
        'Enable buttons to run tests.
        KmeansButton.Enabled = True
        KmediodButton.Enabled = True
        InsRandButton.Enabled = False
        FileInsertButton.Enabled = False

        AmtEnteredShow.Text = 50

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Attribute1TextBox.Clear()
        Attribute2TextBox.Clear()
        AmtEnteredShow.Text = 0
        AccessButton.Enabled = False
    End Sub
    Private Sub Attribute1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Attribute1TextBox.TextChanged
        'Calling TextBox2 Sub since they both check the same thing.
        Call Attribute2TextBox_TextChanged(sender, e)
    End Sub

    Private Sub Attribute2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Attribute2TextBox.TextChanged
        'Check that values haven't been entered from a text file
        If (inputCheck = True) Then
            MsgBox("You must reset the form before attempting the iterative method after inserting values from a file.")
            Exit Sub
        End If
        'Check if the textboxes for the attributes are filled, and that the input is numberic for both. If so,
        'then enable the submit button.
        If (Attribute1TextBox.Text <> String.Empty And Attribute2TextBox.Text <> String.Empty) Then
            If (IsNumeric(Attribute1TextBox.Text) And IsNumeric(Attribute2TextBox.Text)) Then
                InsertObject.Enabled = True
            Else
                InsertObject.Enabled = False
            End If
        Else
            InsertObject.Enabled = False
        End If
    End Sub

    Private Sub FileInsertButton_Click(sender As Object, e As EventArgs) Handles FileInsertButton.Click
        'Create array for the text values, a dummy counter to cycle through, clear global arrays for the attribute values
        'and clear the listbox, and a dummy counter j to cycle through the arrays
        Dim txtValuesArr() As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        Array.Clear(firstArr, 0, secArr.Length)
        Array.Clear(secArr, 0, secArr.Length)
        ListBox1.Items.Clear()

        AmtEnteredShow.Text = 50
        'Insert Values from File
        'Will insert the values, text file to be edited is saved under /debug/bin in order to account for different file locations
        Dim fileReader As String
        Dim path As String = Directory.GetCurrentDirectory()
        fileReader = My.Computer.FileSystem.ReadAllText(path & "\Numbers.txt")
        txtValuesArr = fileReader.Split(" ")


        'Check that each text value in the array from the file is a number,
        'Add the number to an attribute array depending on the counter i,
        'Increase the value of the counters
        'If the counter j reaches 50 reset it for the second attribute array.
        'Display all the values within the listbox one complete!!
        While (i < txtValuesArr.Length)
            If (IsNumeric(txtValuesArr(i)) = 0) Then
                MsgBox("Error found in file at entry" & CStr(i))
                Exit Sub
            End If

            Select Case i
                Case 0 To 49
                    firstArr(j) = txtValuesArr(i)
                Case Else
                    secArr(j) = txtValuesArr(i)
            End Select
            i += 1
            j += 1

            If (j = 50) Then
                j = 0
            End If

        End While

        For i = 0 To 49
            ListBox1.Items.Add(firstArr(i).ToString("n2") + "  " + CStr(secArr(i).ToString("n2")))
        Next


        'Set global counter automatically to 50
        Counter = 50
        'Arbitrary value to make sure you cannot add values manually.
        inputCheck = True
        'Enable buttons to run tests.
        KmeansButton.Enabled = True
        KmediodButton.Enabled = True
        InsRandButton.Enabled = False
        FileInsertButton.Enabled = False
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Array.Clear(firstArr, 0, secArr.Length)
        Array.Clear(secArr, 0, secArr.Length)
        ListBox1.Items.Clear()
        Counter = 0
        AmountEntered.Text = ""
        inputCheck = False
        KmeansButton.Enabled = False
        KmediodButton.Enabled = False
        centroid1ListBox.Items.Clear()
        Attribute1TextBox.Clear()
        Attribute2TextBox.Clear()
        centroid2ListBox.Items.Clear()
        InsRandButton.Enabled = True
        FileInsertButton.Enabled = True
        medoidStartLabel.Text = "Starting x Medoids:"
        centroidStartLabel.Text = "Starting x Centroids:"
        centroidEndLabel.Text = "Ending x Centroids:"
        MedoidEndLabel.Text = "Final x Medoids:"
        Medoid1ListBox.Items.Clear()
        Medoid2ListBox.Items.Clear()
        AmtEnteredShow.Text = 0
        SSEtotal = 0
        Array.Clear(finalClusters, 0, finalClusters.Length)
        clusterAmt = 0
        AccessButton.Enabled = False
    End Sub

    'Calculate K-Means
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles KmeansButton.Click
        AccessButton.Enabled = True
        centroid1ListBox.Items.Clear()
        centroid2ListBox.Items.Clear()
        KmediodButton.Enabled = False
        KmeansButton.Enabled = False
        'Declare a var to show the amt of clusters
        'Declare an array to hold the value of each Centroid
        'an array to temporarily hold the distance from a value to each cluster 'pointDist'
        'an array holding the index of each random seed, and the random Seed variable
        '2 by 3 array to hold the x, y attribute totals and the data point count for each cluster
        clusterAmt = (clusterAmtUpDown.Value - 1)
        Dim Centroids(clusterAmt, 1) As Double
        Dim pointDist(clusterAmt) As Double
        Dim clusterIndex(49) As Integer
        Dim randSeed As Integer
        Dim totClusterVal(clusterAmt, 2) As Double

        'Variable used to end the loop once the final centroids are found
        Dim Switchvar As Boolean

        'Resize the arrays to their actual sizes
        ReDim Preserve firstArr(Counter - 1)
        ReDim Preserve secArr(Counter - 1)
        ReDim Preserve clustArr(Counter - 1)

        'Get the random indexes of starting seeds
        'Make sure no seed appears twice.
        For i As Integer = 0 To (clusterAmt)
            randSeed = New Random().Next(0, firstArr.Length - 1)

            For j As Integer = 0 To i
                If randSeed = clusterIndex(j) And i <> 0 Then
                    i -= 1
                    Exit For
                End If
                'If j reaches i the random seed does not exist.
                If j = i Then
                    clusterIndex(i) = randSeed
                End If
            Next
            clusterIndex(i) = randSeed
        Next


        'Show the clusters chosen by the user and create our starting centroids.
        centroidStartLabel.Text = "Starting" & CStr(clusterAmt + 1) & "Centroids:"
        For i = 0 To clusterAmt
            Centroids(i, 0) = firstArr(clusterIndex(i))
            Centroids(i, 1) = secArr(clusterIndex(i))
            centroid1ListBox.Items.Add(Centroids(i, 0).ToString("n2") + ", " + Centroids(i, 1).ToString("n2"))

        Next


        Do
            'Clear the total checker variable
            Array.Clear(totClusterVal, 0, totClusterVal.Length)
            'Reset the switch variable. If any centroids don't match it will turn false
            Switchvar = True


            'Loop through every data point, creating the clusters
            For i = 0 To (Counter - 1)

                'Pythagoreas theorem, distance between two points from each point to every seeded 'centroid'.
                For j = 0 To clusterAmt
                    pointDist(j) = Sqrt((firstArr(i) - Centroids(j, 0)) ^ 2 + (secArr(i) - Centroids(j, 1)) ^ 2)
                Next
                'Find the minimum distance point from those calculated above and save that index in the cluster global array
                'We do not need to save the value, just what cluster that index belongs to.
                clustArr(i) = minFinder(pointDist, clusterAmt)
            Next

            'Loop through each cluster Find the new Centroids
            For j = 0 To clusterAmt
                'Loop through each element. If the element's cluster value is the one currently being looped through,
                'add the attributes to the total variable for that cluster and increase the counter.
                For i = 0 To (Counter - 1)
                    If clustArr(i) = j Then
                        totClusterVal(j, 0) += firstArr(i)
                        totClusterVal(j, 1) += secArr(i)
                        totClusterVal(j, 2) += 1
                    End If
                Next
            Next

            'Now find the new centroid by getting the central point of each cluster
            For j = 0 To clusterAmt
                'Find the Centroid
                totClusterVal(j, 0) = totClusterVal(j, 0) / totClusterVal(j, 2)
                totClusterVal(j, 1) = totClusterVal(j, 1) / totClusterVal(j, 2)

                'Compare with previous centroid, if not the same, Looooop
                If totClusterVal(j, 0) <> Centroids(j, 0) Then
                    Switchvar = False
                    Centroids(j, 0) = totClusterVal(j, 0)
                    Exit For
                End If

                If totClusterVal(j, 1) <> Centroids(j, 1) Then
                    Switchvar = False
                    Centroids(j, 1) = totClusterVal(j, 1)
                    Exit For
                End If

            Next

        Loop Until Switchvar = True

        For i = 0 To clusterAmt
            centroidEndLabel.Text = "Final" & CStr(clusterAmt + 1) & "Centroids:"
            centroid2ListBox.Items.Add(Centroids(i, 0).ToString("n2") + ", " + Centroids(i, 1).ToString("n2"))

            'Data for access database
            finalClusters(i, 0) = Centroids(i, 0)
            finalClusters(i, 1) = Centroids(i, 1)
        Next


        'Calculate the SSE
        'Calculate the SSE
        For j = 0 To (Counter - 1)
            SSEtotal += Sqrt((firstArr(j) - Centroids(clustArr(j), 0)) ^ 2 + (secArr(j) - Centroids(clustArr(j), 1)) ^ 2)
        Next




        SSECLabel.Text = SSEtotal.ToString("n2")

    End Sub


    'Calculate the K-Mediod
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles KmediodButton.Click
        AccessButton.Enabled = True
        KmediodButton.Enabled = False
        KmeansButton.Enabled = False
        Medoid1ListBox.Items.Clear()
        Medoid2ListBox.Items.Clear()
        clusterAmt = (clusterAmtUpDown.Value - 1)
        'First value represents the total cost of the current medoid, second represents the index 
        'of the data point that is the medoid.
        Dim MtotClusterVal(clusterAmt, 1) As Double
        'Var for comparing the values of each point in a cluster as a centroid 
        Dim totClusterCompare As Double
        Dim Medoids(clusterAmt, 1) As Double
        Dim randSeed As Integer
        Dim clusterIndex(49) As Integer
        Dim pointDist(clusterAmt) As Double
        'Variable used to end the loop once the final centroids are found
        Dim Switchvar As Boolean
        Dim fd As Integer = 0
        'Resize the arrays to their actual sizes
        ReDim Preserve firstArr(Counter - 1)
        ReDim Preserve secArr(Counter - 1)
        ReDim Preserve clustArr(Counter - 1)

        'Get the random indexes of starting seeds
        'Make sure no seed appears twice.
        For i As Integer = 0 To (clusterAmt)
            randSeed = New Random().Next(0, firstArr.Length - 1)
            For j As Integer = 0 To i
                If randSeed = clusterIndex(j) And i <> 0 Then
                    i -= 1
                    Exit For
                End If
                'If j reaches i the random seed does not exist.
                If j = i Then
                    clusterIndex(i) = randSeed
                End If
            Next
            clusterIndex(i) = randSeed
        Next

        'Show the clusters chosen by the user and create our starting Medoids.
        medoidStartLabel.Text = "Starting " & CStr(clusterAmt + 1) & " Medoids:"
        For i = 0 To clusterAmt
            Medoids(i, 0) = firstArr(clusterIndex(i))
            Medoids(i, 1) = secArr(clusterIndex(i))
            Medoid1ListBox.Items.Add(Medoids(i, 0).ToString("n2") + ", " + Medoids(i, 1).ToString("n2"))

        Next




        Do
            Array.Clear(MtotClusterVal, 0, MtotClusterVal.Length)
            Switchvar = True
            fd += 1
            If fd > 10000 Then Exit Do
            'Loop through every data point, creating the clusters
            For i = 0 To (Counter - 1)
                'Manhattan distance between two points from each point to every seeded 'medoid'.
                For j = 0 To clusterAmt
                    pointDist(j) = Abs(firstArr(i) - Medoids(j, 0)) + Abs(secArr(i) - Medoids(j, 1))
                Next
                'Find the minimum distance point from those calculated above and save that index in the cluster global array
                'We do not need to save the value, just what cluster that index belongs to.
                clustArr(i) = minFinder(pointDist, clusterAmt)
            Next


            'Loop through each cluster. Sum up the cost of the current configuration
            For j = 0 To clusterAmt
                'Loop through each element. If the element's cluster value is the one currently being looped through,
                'add the distance cost to the total variable for that cluster and increase the counter.
                For i = 0 To (Counter - 1)
                    'If the current data point's cluster index is equal to the current cluster
                    'Add the value to the total cluster value.
                    If clustArr(i) = j Then
                        MtotClusterVal(j, 0) += Abs(firstArr(i) - Medoids(j, 0)) + Abs(secArr(i) - Medoids(j, 1))
                    End If
                Next
            Next


            'For each cluster, switch every data point i with the medoid j and calculate the distance from 
            'every point in the clusterto that point 
            For j = 0 To clusterAmt
                For i = 0 To (Counter - 1)
                    totClusterCompare = 0
                    'If the current value belongs to the cluster we perform the iterations on that var with index i
                    If clustArr(i) = j Then
                        'From 0 to the amount of total values
                        For k = 0 To (Counter - 1)
                            If clustArr(k) = j Then
                                'calculate the distance from every other point in the cluster k to the current point i
                                totClusterCompare += Abs(firstArr(k) - firstArr(i)) + Abs(secArr(k) - secArr(i))
                            End If
                        Next
                        'If the current configuration has a lower cost, make it the total
                        'The j value indicates the cluster, the value saved in the second column represents the index 
                        'corresponding to the data point that is now the medoid
                        If MtotClusterVal(j, 0) > totClusterCompare Then
                            MtotClusterVal(j, 0) = totClusterCompare
                            MtotClusterVal(j, 1) = i

                        End If
                    End If
                Next



                'Assign medoids to the data point in the given cluster with the lowest total cost.
                If CInt(Medoids(j, 0)) <> CInt(firstArr(MtotClusterVal(j, 1))) Then
                    Medoids(j, 0) = firstArr(MtotClusterVal(j, 1))
                    Switchvar = False
                End If

                If Medoids(j, 1) <> secArr(MtotClusterVal(j, 1)) Then
                    Medoids(j, 1) = secArr(MtotClusterVal(j, 1))
                    Switchvar = False
                End If
            Next




        Loop Until Switchvar = True

        For i = 0 To clusterAmt
            MedoidEndLabel.Text = "Final " & CStr(clusterAmt + 1) & " Medoids:"
            Medoid2ListBox.Items.Add(Medoids(i, 0).ToString("n2") + ", " + Medoids(i, 1).ToString("n2"))
        Next



        'Calculate the SSE
        For j = 0 To (Counter - 1)
            SSEtotal += Sqrt((firstArr(j) - Medoids(clustArr(j), 0)) ^ 2 + (secArr(j) - Medoids(clustArr(j), 1)) ^ 2)
        Next
        SSEMLabel.Text = SSEtotal.ToString("n2")
    End Sub



    'Function to extract index of the minimum distance
    Function minFinder(Arr() As Double, Count As Integer)
        Dim Smallest As Integer = 0
        Dim i As Integer
        For i = 1 To Count
            If Arr(Smallest) > Arr(i) Then
                Smallest = i
            End If
        Next

        Return Smallest
    End Function


    Private Sub AccesButton_Click(sender As Object, e As EventArgs) Handles AccessButton.Click
        'Declare variables
        Dim connStr As String 'Stores DB connection string
        Dim dbRecordCount As Integer 'Gets number of records in a table
        Dim i As Integer 'Counter variable
        'Declare DB objects
        Dim dbConn As New OleDb.OleDbConnection
        Dim adapter As OleDb.OleDbDataAdapter
        Dim dataSet As DataSet
        'Declare database query variable
        Dim mySQL As String
        'String used to display all centroids
        Dim centroidStr As String = ""
        'Declare and find the path to the access DB
        Dim path As String = My.Application.Info.DirectoryPath
        Dim path2() As String = path.Split("bin")
        MsgBox("If this is the only message displayed, you have succesfully saved your data")
        'Define the provider and startup path to set connection string
        connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & path2(0) & "Database1.accdb"
        'connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" &
        '          "Data Source=D:\Program Files(D)\VisStud2015Projects\IE411(VisualBasic)\TermProject_Predovic\Database1.accdb"

        'Assign connStr string to ConnecString property of dbConn object
        dbConn.ConnectionString = connStr

        'Attempt connection to DB
        Try
            'Create new instance of database connection
            dbConn.Open()
        Catch ex As Exception
            'Display an error message
            MessageBox.Show("Cannot connect to DB!" & vbNewLine & ex.Message)
            Exit Sub
        End Try


        'Define SQL statement
        mySQL = "SELECT * " &
                "FROM TBL_ClusterResults"

        'Issue query to database
        Try
            'Create object instances for adapter and dataset (from classes)
            dataSet = New System.Data.DataSet
            adapter = New OleDb.OleDbDataAdapter(mySQL, dbConn)
            'Fill dataset from adapter
            dbRecordCount = adapter.Fill(dataSet, "FillComboBox")
        Catch ex As Exception
            MessageBox.Show("Table Access Error" & vbNewLine & ex.Message)
            Exit Sub
        End Try
        Dim outputStr As String
        'If dataset contains records, add them to ComboBox
        'If dbRecordCount <> 0 Then
        '    For i = 0 To dbRecordCount - 1
        '        outputStr = cbRecords.Items.Add(dataSet.Tables("FillComboBox").Rows(i).Item(1) &
        '                            " -- " &
        '                            dataSet.Tables("FillComboBox").Rows(i).Item(2) &
        '                            " clusters")
        '    Next
        'Else
        '    MessageBox.Show("No records exist in DB!", "No Data")
        '    Exit Sub
        'End If

        'txtHistory.Text = outputStr




        'Global var for moving data into access database
        'ReDim Preserve finalClusters(clusterAmt, 1)  REDIM CAN ONLY CHANGE RIGHTMOST DIMENSION.

        mySQL = "SELECT * " & "FROM TBL_ClusterResults"

        Try
            'Create object instance for adapter and dataset classes
            dataSet = New System.Data.DataSet
            adapter = New OleDb.OleDbDataAdapter(mySQL, dbConn)

            'Fill dataSet
            adapter.Fill(dataSet, "SaveData")

            Dim cmdBuilder As New OleDb.OleDbCommandBuilder(adapter)
            Dim newRow As DataRow

            'Create a new row in dataset
            newRow = dataSet.Tables("SaveData").NewRow

            'Add values to the new record
            For i = 0 To (clusterAmt)
                centroidStr &= "(" + finalClusters(i, 0).ToString("n2") + ", " + finalClusters(i, 1).ToString("n2") + ") "
            Next
            newRow.Item("Run_Date") = DateAndTime.DateString
            newRow.Item("No_Clusters") = CStr(clusterAmt + 1)
            newRow.Item("Centroids_Medoids") = centroidStr
            newRow.Item("Error_Sum_of_Squares") = SSEtotal.ToString("n5")
            'Add new row to dataset

            dataSet.Tables("SaveData").Rows.Add(newRow)


            'Update the dtabase
            adapter.Update(dataSet, "SaveData")

        Catch ex As Exception
            MessageBox.Show("Issue adding values to DB" & vbNewLine & ex.Message)
        End Try


    End Sub

























    'STDEV FUNCTION!!!
    Function StdDev(k As Integer, Arr() As Double)
        Dim i As Integer
        Dim avg As Single, SumSq As Single

        avg = Arr.Average
        For i = 1 To k
            SumSq = SumSq + (Arr(i) - avg) ^ 2
        Next i

        StdDev = Sqrt(SumSq / (k - 1))
        Return StdDev
    End Function





    'Code that went wrong..................................................

    'Dim clusterValuesX(5), clusterValuesY(5) As Double
    'Dim clusterIterX, clusterIterY As Double
    ''Calculate the K-Means using 'rule of thumb' method
    ''Then find the range where we will arbitrarilty place each cluster.
    'Dim clusterAmt As Integer = clusterAmtUpDown.Value
    'Dim clusterRangeMinX, clusterRangeMinY, clusterRangeMaxX, clusterRangeMaxY, AvgX, AvgY As Double
    ''Here we shorten the size of the array to the amount of units in order to use the averaging function provided
    ''
    'ReDim Preserve firstArr(Counter)
    'ReDim Preserve secArr(Counter)
    '    AvgX = firstArr.Average
    '    AvgY = secArr.Average
    '    'Now in order to initialize central cluster points find the range, I used 1.5 stdev from the mean,
    '    ' Seperate this range into 
    '    clusterRangeMinX = AvgX - (1.25) * StdDev(Counter, firstArr)
    '    clusterRangeMinY = AvgY - (1.25) * StdDev(Counter, secArr)
    '    clusterRangeMaxX = AvgX + (1.25) * StdDev(Counter, firstArr)
    '    clusterRangeMaxY = AvgY + (1.25) * StdDev(Counter, secArr)

    '    clusterIterX = (clusterRangeMaxX - clusterRangeMinX) / CDbl(clusterAmt)
    '    clusterIterY = (clusterRangeMaxY - clusterRangeMinY) / CDbl(clusterAmt)

    '    'Find cluster values in X and Y dimension
    '    For i As Integer = 0 To 4
    '        clusterValuesX(i) = clusterRangeMinX + clusterIterX * i
    '        clusterValuesY(i) = clusterRangeMinY + clusterIterY * i
    '    Next

    '    ClusterLabel.Text = "Starting Cluster Points:"
    '    For i = 4 To clusterAmt - 1
    '        clusterListBox.Items.Add(clusterValuesX(i).ToString("n2") + ", " + clusterValuesY(i).ToString("n2"))
    '    Next

    '....................................................................................................
End Class