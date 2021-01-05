Public Class Form1

    Dim imgOne As Image = My.Resources.attacker
    Dim imgTwo As Image = My.Resources.attacker2
    Dim imgThree As Image = My.Resources.attacker3
    Dim imgFour As Image = My.Resources.Cannon
    Dim imgFive As Image = My.Resources.Cannon
    Dim imgSix As Image = My.Resources.Cannon
    Dim imgSeven As Image = My.Resources.FireballFlipped

    Dim rAttackerOne As Rectangle
    Dim rAttackerTwo As Rectangle
    Dim rAttackerThree As Rectangle
    Dim rCannonOne As Rectangle
    Dim rCannonTwo As Rectangle
    Dim rCannonThree As Rectangle

    Dim count, row, col, totalRows, totalCols, attackOneWidth, attackOneHeight As Integer

    Dim count2, row2, col2, totalRows2, totalCols2, attackTwoWidth, attackTwoHeight As Integer

    Dim count3, row3, col3, totalRows3, totalCols3, attackThreeWidth, attackThreeHeight As Integer

    Dim count4, row4, col4, totalRows4, totalCols4, cannonWidthOne, cannonHeightOne As Integer

    Dim count5, row5, col5, totalRows5, totalCols5, cannonWidthTwo, cannonHeightTwo As Integer

    Dim count6, row6, col6, totalRows6, totalCols6, cannonWidthThree, cannonHeightThree As Integer

    Dim count7, row7, col7, totalRows7, totalCols7, fireballWidth, fireballHeight As Integer

    Dim attackOne, attackTwo, attackThree, attackFour, attackFive, attackSix As Boolean

    Dim finishedOne, finishedTwo, finishedThree, finishedFour, finishedFive, finishedSix As Boolean

    Dim shot, shotOne, shotTwo, shotThree As Boolean

    Dim ccnt As Integer

    Dim fireBallXvel As Integer = 20

    Dim maxCannon = 500

    Dim rFireball(maxCannon) As Rectangle

    Dim createShot As Integer


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If attackOne = True Then

            If count >= ((totalRows * totalCols) - 1) Then
                count = 0
            End If

            row = count \ totalCols
            col = count Mod totalCols

            count += 1

            If count = 10 Then
                finishedOne = True
            End If
        End If

        If finishedOne = True Then
            Timer1.Stop()
            attackOne = False
            finishedOne = False
        End If


        Me.Refresh()

    End Sub

    Private Sub tmrAttackerTwo_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        If attackTwo = True Then


            If count2 >= (totalRows2 * totalCols2) Then
                count2 = 0
            End If

            row2 = count2 \ totalCols2
            col2 = count2 Mod totalCols2

            count2 += 1

            If count2 = 10 Then
                finishedTwo = True
            End If

        End If

        If finishedTwo = True Then
            Timer2.Stop()
            attackTwo = False
            finishedTwo = False
        End If

        Me.Refresh()

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick

        If attackThree = True Then

            If count3 >= (totalRows3 * totalCols3) Then
                count3 = 0
            End If

            row3 = count3 \ totalCols3
            col3 = count3 Mod totalCols3

            count3 += 1

            If count3 = 6 Then
                finishedThree = True
            End If

        End If


        If finishedThree = True Then
            Timer3.Stop()
            attackThree = False
            finishedThree = False
        End If

        Me.Refresh()

    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick

        If attackFour = True Then

            If count4 >= (totalRows4 * totalCols4) Then
                count4 = 0
            End If

            row4 = count4 \ totalCols4
            col4 = count4 Mod totalCols4

            count4 += 1

            If count4 = 5 Then
                finishedFour = True
            End If


        End If


        If finishedFour = True Then
            col4 = 0
            Timer4.Stop()
            attackFour = False
            finishedFour = False
        End If

        Me.Refresh()

    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick

        If attackFive = True Then

            If count5 >= (totalRows5 * totalCols5) Then
                count5 = 0
            End If

            row5 = count5 \ totalCols5
            col5 = count5 Mod totalCols5

            count5 += 1

            If count5 = 5 Then
                finishedFive = True
            End If



        End If

        If finishedFive = True Then
            col5 = 0
            Timer5.Stop()
            attackFive = False
            finishedFive = False
        End If

        Me.Refresh()

    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick

        If attackSix = True Then


            If count6 >= (totalRows6 * totalCols6) Then
                count6 = 0
            End If

            row6 = count6 \ totalCols6
            col6 = count6 Mod totalCols6

            count6 += 1

            If count6 = 5 Then
                finishedSix = True
            End If



        End If

        If finishedSix = True Then
            col6 = 0
            Timer6.Stop()
            attackSix = False
            finishedSix = False
        End If

        Me.Refresh()

    End Sub


    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        e.Graphics.DrawImage(imgOne, rAttackerOne, New RectangleF(col * attackOneWidth, row * attackOneHeight, attackOneWidth, attackOneHeight), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgTwo, rAttackerTwo, New RectangleF(col2 * attackTwoWidth, row2 * attackTwoHeight, attackTwoWidth, attackTwoHeight), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgThree, rAttackerThree, New RectangleF(col3 * attackThreeWidth, row3 * attackThreeHeight, attackThreeWidth, attackThreeHeight), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgFour, rCannonOne, New RectangleF(col4 * cannonWidthOne, row4 * cannonHeightOne, cannonWidthOne, cannonHeightOne), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgFive, rCannonTwo, New RectangleF(col5 * cannonWidthTwo, row5 * cannonHeightTwo, cannonWidthTwo, cannonHeightTwo), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgSix, rCannonThree, New RectangleF(col6 * cannonWidthThree, row6 * cannonHeightThree, cannonWidthTwo, cannonHeightThree), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(imgSeven, rFireball(ccnt), New RectangleF(col7 * fireballWidth, row7 * fireballHeight, fireballWidth, fireballHeight), GraphicsUnit.Pixel)

        For ccnt As Integer = 0 To createShot - 1
            If rFireball(ccnt).Y > Me.Left Then
                e.Graphics.DrawImage(imgSeven, rFireball(ccnt), New RectangleF(col7 * fireballWidth, row7 * fireballHeight, fireballWidth, fireballHeight), GraphicsUnit.Pixel)
            End If
        Next

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' attacker one
        totalCols = 6
        totalRows = 2

        ' attacker two
        totalCols2 = 4
        totalRows2 = 3

        ' attacker three
        totalCols3 = 6
        totalRows3 = 1

        ' attacker four
        totalCols4 = 5
        totalRows4 = 1

        totalCols5 = 5
        totalRows5 = 1

        totalCols6 = 5
        totalRows6 = 1

        totalCols7 = 6
        totalRows7 = 1


        attackOneWidth = imgOne.Width / totalCols
        attackOneHeight = imgOne.Height / totalRows

        attackTwoWidth = imgTwo.Width / totalCols2
        attackTwoHeight = imgTwo.Height / totalRows2

        attackThreeWidth = imgThree.Width / totalCols3
        attackThreeHeight = imgThree.Height / totalRows3

        cannonWidthOne = imgFour.Width / totalCols4
        cannonHeightOne = imgFour.Height / totalRows4

        cannonWidthTwo = imgFive.Width / totalCols5
        cannonHeightTwo = imgFive.Height / totalRows5

        cannonWidthThree = imgSix.Width / totalCols6
        cannonHeightThree = imgSix.Height / totalRows6

        fireballWidth = imgSeven.Width / totalCols7
        fireballHeight = imgSeven.Height / totalRows7

        rAttackerOne = New Rectangle(100, 100, attackOneWidth + 50, attackOneHeight + 50)
        rAttackerTwo = New Rectangle(50, 275, attackTwoWidth, attackTwoHeight)
        rAttackerThree = New Rectangle(100, 500, attackThreeWidth - 150, attackThreeHeight - 150)
        rCannonOne = New Rectangle(1300, 100, cannonWidthOne * 2, cannonHeightOne * 2)
        rCannonTwo = New Rectangle(1300, 275, cannonWidthTwo * 2, cannonHeightTwo * 2)
        rCannonThree = New Rectangle(1300, 500, cannonWidthThree * 2, cannonHeightThree * 2)


    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.Q Then
            attackOne = True
            Timer1.Start()
        End If

        If e.KeyData = Keys.A Then
            attackTwo = True
            Timer2.Start()
        End If

        If e.KeyData = Keys.Z Then
            attackThree = True
            Timer3.Start()
        End If

        If e.KeyData = Keys.P Then
            attackFour = True
            shot = True
            shotOne = True
            Timer4.Start()
        End If

        If e.KeyData = Keys.L Then
            attackFive = True
            shot = True
            shotTwo = True
            Timer5.Start()
        End If

        If e.KeyData = Keys.M Then
            attackSix = True
            shot = True
            shotThree = True
            Timer6.Start()
        End If


    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyData = Keys.P Then
            shotOne = False
        End If

        If e.KeyData = Keys.L Then
            shotTwo = False
        End If

        If e.KeyData = Keys.M Then
            shotThree = False
        End If

    End Sub

    Private Sub shoot()

        If shot = True Then

            If shotOne = True Then
                rFireball(ccnt) = New Rectangle(rCannonOne.X - 20, rCannonOne.Y + 30, fireballWidth - 100, fireballHeight - 100)
            End If
            If shotTwo = True Then
                rFireball(ccnt) = New Rectangle(rCannonTwo.X + 20, rCannonTwo.Y + 30, fireballWidth - 100, fireballHeight - 100)
            End If
            If shotThree = True Then
                rFireball(ccnt) = New Rectangle(rCannonThree.X + 20, rCannonThree.Y + 30, fireballWidth - 100, fireballHeight - 100)
            End If

            ccnt += 1

            shotOne = False
            shotTwo = False
            shotThree = False

            shot = False

            createShot += 1

        End If


        For ccnt As Integer = 0 To createShot - 1

            rFireball(ccnt).X -= fireBallXvel

        Next

    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        shoot()
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick

        If count7 >= (totalRows7 * totalCols7) Then
            count7 = 0
        End If

        row7 = count7 \ totalCols7
        col7 = count7 Mod totalCols7

        count7 += 1

    End Sub

End Class
