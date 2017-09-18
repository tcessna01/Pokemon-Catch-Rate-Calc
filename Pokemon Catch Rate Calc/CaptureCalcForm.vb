''' <summary>
''' Pokemon Capture Calculator v1.0
''' By: Thomas Cessna (Pudge)
''' 
''' Description: Calculates any potential pokemon's catch rate
''' from any generation. Includes all possible factors,
''' Critical Capture Mechanic, and Dark Grass.
''' </summary>



Public Class PokemonCatchCalc

    Dim lastIndexNum As Integer
    'lastIndexNum = 0

    Dim getLastSelPokeIndex As Integer = 0

    Const GENERATION1 As Byte = 1
    Const GENERATION2 As Byte = 2
    Const GENERATION3 As Byte = 3
    Const GENERATION4 As Byte = 4
    Const GENERATION5 As Byte = 5
    Const GENERATION6 As Byte = 6

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBoxFactor2_TextChanged(sender As Object, e As EventArgs) Handles txtBoxFactor2.TextChanged

    End Sub

    Private Sub cbtnFactorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnFactorCheck.CheckedChanged

    End Sub

    Private Sub cbtnDarkGrass_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnDarkGrass.CheckedChanged
        If cbtnDarkGrass.Checked = True Then
            cboxPokesCaught2.Visible = True
            lblPokeObt2.Visible = True
        Else
            cboxPokesCaught2.Visible = False
            lblPokeObt2.Visible = False
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearAll()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub PokemonCatchCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnGen6.Checked = True
        rbtnNoStatus.Checked = True
        rbtnNoCapPow.Checked = True
        cBoxPokeType.SelectedIndex = 0
        cboxPokesCaught1.SelectedIndex = 0
        cboxPokesCaught2.SelectedIndex = 0
        cboxSelGenNum.SelectedIndex = 0
        'cboxSelectPoke.SelectedIndex = 0
    End Sub

    Private Sub rbtnGen1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen1.CheckedChanged
        presetGen1234(getLastSelPokeIndex)
        cboxSelGenNum.Items.Add("1")
        If cboxSelGenNum.SelectedIndex > 150 Then
            cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
        Else
            cboxSelGenNum.SelectedIndex = 0
        End If
    End Sub

    Private Sub rbtnGen2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen2.CheckedChanged
        presetGen1234(getLastSelPokeIndex)
        changeGenFilter(GENERATION2)
        If cboxSelGenNum.SelectedIndex > 250 Then
            cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
        Else
            cboxSelGenNum.SelectedIndex = 0
        End If
    End Sub

    Private Sub rbtnGen3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen3.CheckedChanged
        presetGen1234(getLastSelPokeIndex)
        changeGenFilter(GENERATION3)
        If cboxSelGenNum.SelectedIndex > 385 Then
            cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
        Else
            cboxSelGenNum.SelectedIndex = 0
        End If
    End Sub

    Private Sub rbtnGen4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen4.CheckedChanged
        presetGen1234(getLastSelPokeIndex)
        changeGenFilter(GENERATION4)
        If cboxSelGenNum.SelectedIndex > 492 Then
            cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
        Else
            cboxSelGenNum.SelectedIndex = 0
        End If
    End Sub

    Private Sub rbtnGen5_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen5.CheckedChanged
        presetGen56(getLastSelPokeIndex)
        changeGenFilter(GENERATION5)
        If cboxSelGenNum.SelectedIndex > 648 Then
            cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
        Else
            cboxSelGenNum.SelectedIndex = 0
        End If
    End Sub

    Private Sub rbtnGen6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGen6.CheckedChanged
        presetGen56(getLastSelPokeIndex)
        changeGenFilter(GENERATION6)
        cboxSelGenNum.SelectedIndex = getLastSelPokeIndex
    End Sub

    Private Sub presetGen1234(ByRef lastSelPokeIndex)
        cbtnDarkGrass.Visible = False
        rbtnCapPow1.Visible = False
        rbtnCapPow2.Visible = False
        rbtnCapPow3.Visible = False
        cboxPokesCaught2.Visible = False
        lblPokeObt1.Visible = False
        cboxPokesCaught1.Visible = False
        lblCritChance.Visible = False
        lblCritCapPer.Visible = False
        cbtnAskCalcCrit.Visible = False
        getLastSelPokeIndex = cboxSelectPoke.SelectedIndex
        cboxSelGenNum.Items.Clear()
    End Sub

    Private Sub presetGen56(ByRef lastSelPokeIndex)
        cbtnDarkGrass.Visible = True
        rbtnCapPow1.Visible = True
        rbtnCapPow2.Visible = True
        rbtnCapPow3.Visible = True
        lblPokeObt1.Visible = True
        cboxPokesCaught1.Visible = True
        lblCritChance.Visible = True
        lblCritCapPer.Visible = True
        cbtnAskCalcCrit.Visible = True
        'getLastSelPokeIndex = cboxSelectPoke.SelectedIndex
        cboxSelGenNum.Items.Clear()
    End Sub

    Private Sub changeGenFilter(ByVal selectedGen)
        cboxSelGenNum.Items.Add("All")

        For index = 0 To selectedGen - 1
            cboxSelGenNum.Items.Add((index + 1).ToString())
        Next

    End Sub

    Private Sub cBoxPokeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxPokeType.SelectedIndexChanged
        'Order is true to this list
        'Poké Ball
        'Great Ball
        'Ultra Ball
        'Master Ball
        'Safari Ball
        'Fast Ball
        'Friend Ball
        'Heavy Ball
        'Level Ball
        'Love Ball
        'Lure Ball
        'Moon Ball
        'Dive Ball
        'Luxury Ball
        'Net Ball
        'Nest Ball
        'Premier Ball
        'Repeat Ball
        'Timer Ball
        'Dusk Ball
        'Heal Ball
        'Park / Sport Ball
        'Quick Ball



        If getGen() = 1 Then
            If checkBallAvailible() = True Then
                showBallType()
                lastIndexNum = cBoxPokeType.SelectedIndex
            Else
                goToLastIndex(lastIndexNum)
                MessageBox.Show("Sorry, that ball isn't availible in this Generation")
            End If

        ElseIf getGen() = 2 Then
            If checkBallAvailible() = True Then
                showBallType()
                lastIndexNum = cBoxPokeType.SelectedIndex
            Else
                goToLastIndex(lastIndexNum)
                MessageBox.Show("Sorry, that ball isn't availible in this Generation")
            End If

        ElseIf getGen() = 3 Then
            If checkBallAvailible() = True Then
                showBallType()
                lastIndexNum = cBoxPokeType.SelectedIndex
            Else
                goToLastIndex(lastIndexNum)
                MessageBox.Show("Sorry, that ball isn't availible in this Generation")
            End If

        ElseIf getGen() = 4 Then
            showBallType()
            lastIndexNum = cBoxPokeType.SelectedIndex

        ElseIf getGen() = 5 Then
            If checkBallAvailible() = True Then
                showBallType()
                lastIndexNum = cBoxPokeType.SelectedIndex
            Else
                goToLastIndex(lastIndexNum)
                MessageBox.Show("Sorry, that ball isn't availible in this Generation")
            End If
        ElseIf getGen() = 6 Then
            If checkBallAvailible() = True Then
                showBallType()
                lastIndexNum = cBoxPokeType.SelectedIndex
            Else
                goToLastIndex(lastIndexNum)
                MessageBox.Show("Sorry, that ball isn't availible in this Generation")
            End If
        End If


    End Sub

    Private Sub goToLastIndex(ByRef lastIndexNum As Integer)
        cBoxPokeType.SelectedIndex = lastIndexNum
    End Sub

    Private Sub showBallType()

        cbtnFactorCheck.Visible = False
        lblFactor1.Visible = False
        txtBoxFactor1.Visible = False
        lblFactor2.Visible = False
        txtBoxFactor2.Visible = False

        If cBoxPokeType.SelectedIndex = 0 Then
            ballPic.Image = My.Resources.Bag_Poké_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 1 Then
            ballPic.Image = My.Resources.Bag_Great_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 2 Then
            ballPic.Image = My.Resources.Bag_Ultra_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 3 Then
            ballPic.Image = My.Resources.Bag_Master_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 4 Then
            ballPic.Image = My.Resources.Bag_Safari_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 5 Then
            ballPic.Image = My.Resources.Bag_Fast_Ball_Sprite
            If getGen() = 4 Then
                cbtnFactorCheck.Text = "Base Speed 100+ ?"
            ElseIf getGen() = 2 Then
                cbtnFactorCheck.Text = "Magnemite, Grimer, or Tangela?"
            End If
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 6 Then
            ballPic.Image = My.Resources.Bag_Friend_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 7 Then
            ballPic.Image = My.Resources.Bag_Heavy_Ball_Sprite

            lblFactor1.Text = "Weight of Pokemon?"

            lblFactor1.Visible = True
            txtBoxFactor1.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 8 Then
            ballPic.Image = My.Resources.Bag_Level_Ball_Sprite
            lblFactor1.Text = "Your Level?"
            lblFactor2.Text = "Their Level?"

            lblFactor1.Visible = True
            txtBoxFactor1.Visible = True
            lblFactor2.Visible = True
            txtBoxFactor2.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 9 Then
            ballPic.Image = My.Resources.Bag_Love_Ball_Sprite
            If getGen() = 4 Then
                cbtnFactorCheck.Text = "Same Pokemon, Opposite Gender?"
            ElseIf getGen() = 2 Then
                cbtnFactorCheck.Text = "Same Pokemon, Same Gender?"
            End If
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 10 Then
            ballPic.Image = My.Resources.Bag_Lure_Ball_Sprite
            cbtnFactorCheck.Text = "Fishing?"
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 11 Then
            ballPic.Image = My.Resources.Bag_Moon_Ball_Sprite
            If getGen() = 4 Then
                cbtnFactorCheck.Text = "Moon Stone evolution family?"
            ElseIf getGen() = 2 Then
                cbtnFactorCheck.Text = "No Pokemon evolves with Burn Heal :("
            End If
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 12 Then
            ballPic.Image = My.Resources.Bag_Dive_Ball_Sprite
            If getGen() = 3 Then
                cbtnFactorCheck.Text = "Underwater?"
            Else
                cbtnFactorCheck.Text = "Fishing / Surfing?"
            End If
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 13 Then
            ballPic.Image = My.Resources.Bag_Luxury_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 14 Then
            ballPic.Image = My.Resources.Bag_Net_Ball_Sprite
            cbtnFactorCheck.Text = "Bug or Water Type?"
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 15 Then
            ballPic.Image = My.Resources.Bag_Nest_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 16 Then
            ballPic.Image = My.Resources.Bag_Premier_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 17 Then
            ballPic.Image = My.Resources.Bag_Repeat_Ball_Sprite
            cbtnFactorCheck.Text = "Previously caught?"
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 18 Then
            ballPic.Image = My.Resources.Bag_Timer_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 19 Then
            ballPic.Image = My.Resources.Bag_Dusk_Ball_Sprite
            cbtnFactorCheck.Text = "At night / In a cave?"
            cbtnFactorCheck.Visible = True
        End If
        If cBoxPokeType.SelectedIndex = 20 Then
            ballPic.Image = My.Resources.Bag_Heal_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 21 Then
            ballPic.Image = My.Resources.Bag_Sport_Ball_Sprite
        End If
        If cBoxPokeType.SelectedIndex = 22 Then
            ballPic.Image = My.Resources.Bag_Quick_Ball_Sprite
            cbtnFactorCheck.Text = "Turn 1?"
            cbtnFactorCheck.Visible = True
        End If

    End Sub

    Private Sub setCatchRate()

    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim errorCheck As Integer ' makes sure HP and catch fields are filled out
        ' This fixes a dividing by zero overflow error. 
        ' Invaild casting in getMaxHP or user input 0 returns 0 to cause equation to be 0. 
        ' Now if return = 0, this variable will equal an arbitrary number
        ' Also will cause no further code to be executed
        If getMaxHp() <= 0 Then
            errorCheck = 1
        ElseIf getRemainingHp() <= 0 Then
            errorCheck = 2
        ElseIf getCatchRate() <= 0 Then
            errorCheck = 3
        ElseIf cBoxPokeType.SelectedIndex = 3 Then
            lblCapture.Text = "100%"
        ElseIf getMaxHp() < getRemainingHp() Then
            MsgBox("Max HP must be higher than Remaining HP!")
        Else
            If getGen() = 1 Then
                calcGen1Catch()
            ElseIf getGen() = 2 Then
                calcGen2Catch()
            ElseIf getGen() = 3 Then
                calcGen3and4Catch()
            ElseIf getGen() = 4 Then
                calcGen3and4Catch()
            ElseIf getGen() = 5 Then
                calcGen5Catch()
            ElseIf getGen() = 6 Then
                calcGen6Catch()
            End If
        End If
    End Sub

    Function checkBallAvailible() As Boolean

        If getGen() = 1 And (cBoxPokeType.SelectedIndex = 0 Or cBoxPokeType.SelectedIndex = 1 Or cBoxPokeType.SelectedIndex = 2 Or cBoxPokeType.SelectedIndex = 4) Then
            Return True
        ElseIf getGen() = 2 And cBoxPokeType.SelectedIndex <= 11 Or cBoxPokeType.SelectedIndex = 21 Then
            Return True
        ElseIf getGen() = 3 And (cBoxPokeType.SelectedIndex <= 4 Or cBoxPokeType.SelectedIndex >= 12) And cBoxPokeType.SelectedIndex <= 18 Then
            Return True
        ElseIf getGen() = 5 And (cBoxPokeType.SelectedIndex <= 4 Or cBoxPokeType.SelectedIndex >= 12) Then
            Return True
        ElseIf getGen() = 6 And (cBoxPokeType.SelectedIndex <= 4 Or cBoxPokeType.SelectedIndex >= 12) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub calcGen1Catch()
        Dim pSub0 As Double
        Dim pSub1 As Double
        Dim probOfCapture As Double

        'If calculateF() = 0 Then
        'lblCapture.Text = "0"
        'Else
        pSub0 = getStatus() / (getBallType() + 1)
        pSub1 = ((getCatchRate() + 1) / (getBallType() + 1)) * ((calculateF() + 1) / 256)

        probOfCapture = pSub0 + pSub1

        lblCapture.Text = probOfCapture.ToString("p")
        'End If

    End Sub

    Private Sub calcGen2Catch()
        Dim a As Byte ' As defined in the actual equation
        Dim modCatchRate As Integer ' For all balls in gen 2
        Dim probOfCapture As Double

        If cBoxPokeType.SelectedIndex = 7 Then
            modCatchRate = getCatchRate() + getBallType()
        Else
            modCatchRate = getCatchRate() * getBallType()
        End If

        If modCatchRate > 255 Then
            modCatchRate = 255
        End If

        Try

            a = ((3 * getMaxHp() - 2 * getRemainingHp()) * modCatchRate) / (3 * getMaxHp()) + getStatus()

            probOfCapture = (a + 1) / 256

            lblCapture.Text = probOfCapture.ToString("p")

        Catch Exc As System.OverflowException ' All other errors would be caught by the other Try Catch statements
            lblCapture.Text = "100%" ' An overflow byte error is acceptable, would be 100% anyway
        End Try

    End Sub

    Private Sub calcGen3and4Catch()
        Dim a As Byte ' As defined in the actual equation
        Dim Y As Double
        Dim modCatchRate As Integer 'For specialty balls only ; developer quirk ; throw back to gen 2
        Dim probOfCapture As Double

        Try
            If cBoxPokeType.SelectedIndex >= 5 And cBoxPokeType.SelectedIndex <= 11 Then

                If cBoxPokeType.SelectedIndex = 7 Then ' Heavy Ball is the only "add" all else are "mult"
                    modCatchRate = getCatchRate() + getBallType()
                Else
                    modCatchRate = getCatchRate() * getBallType()
                End If

                If modCatchRate > 255 Then
                    modCatchRate = 255
                End If

                a = (((3 * getMaxHp() - 2 * getRemainingHp()) * modCatchRate) / (3 * getMaxHp())) * getStatus()
            Else
                a = (((3 * getMaxHp() - 2 * getRemainingHp()) * getCatchRate() * getBallType()) / (3 * getMaxHp())) * getStatus()
            End If

            Y = 65535 / (Math.Sqrt(Math.Sqrt(255 / a)))

            probOfCapture = Math.Pow(Y / 65536, 4)

            lblCapture.Text = probOfCapture.ToString("p") ' Automatically puts in percentage

        Catch Exc As System.OverflowException ' All other errors would be caught by the other Try Catch statements
            lblCapture.Text = "100%" ' An overflow byte error is acceptable, would be 100% anyway
        End Try

    End Sub

    Private Sub calcGen5Catch()
        Dim a As Byte ' As defined in the actual equation
        Dim Y As Double
        Dim probOfCapture As Double

        Try
            a = (((3 * getMaxHp() - 2 * getRemainingHp()) * getDarkGrass() * getCatchRate() * getBallType()) / (3 * getMaxHp())) * getStatus() * getCapturePower()

            Y = 65535 / (Math.Sqrt(Math.Sqrt(255 / a)))

            probOfCapture = Math.Pow(Y / 65536, 4)

            lblCapture.Text = probOfCapture.ToString("p")

            If getCriticalCaptureState() = True Then
                calcCritCap(a)
            End If

        Catch Exc As System.OverflowException ' All other errors would be caught by the other Try Catch statements
            lblCapture.Text = "100%" ' An overflow byte error is acceptable, would be 100% anyway

        End Try

    End Sub

    Private Sub calcGen6Catch()
        Dim a As Byte ' As defined in the actual equation
        Dim Y As Double
        Dim probOfCapture As Double

        Try
            a = (((3 * getMaxHp() - 2 * getRemainingHp()) * getDarkGrass() * getCatchRate() * getBallType()) / (3 * getMaxHp())) * getStatus() * getCapturePower()

            Y = 65535 / (Math.Pow((255 / a), (3 / 16)))

            probOfCapture = Math.Pow(Y / 65536, 4)

            lblCapture.Text = probOfCapture.ToString("p")

            If getCriticalCaptureState() = True Then
                calcCritCap(a)
            End If

        Catch Exc As System.OverflowException ' All other errors would be caught by the other Try Catch statements
            lblCapture.Text = "100%" ' An overflow byte error is acceptable, would be 100% anyway
        End Try

    End Sub


    'Start Always are called
    Function getGen() As Byte ' To specify the equation used ; Called for multiple checks
        If rbtnGen1.Checked = True Then
            Return 1
        ElseIf rbtnGen2.Checked = True Then
            Return 2
        ElseIf rbtnGen3.Checked = True Then
            Return 3
        ElseIf rbtnGen4.Checked = True Then
            Return 4
        ElseIf rbtnGen5.Checked = True Then
            Return 5
        ElseIf rbtnGen6.Checked = True Then
            Return 6
        End If
        Return 1
    End Function

    Function getStatus() As Double ' To specify the status multiplier
        If getGen() = 1 Then
            If rbtnBurn.Checked = True Or rbtnPrz.Checked = True Or rbtnPsn.Checked = True Then
                Return 12
            ElseIf rbtnSlp.Checked = True Or rbtnFrz.Checked = True Then
                Return 25
            Else
                Return 0
            End If
        End If

        If getGen() = 2 Then
            If rbtnBurn.Checked = True Or rbtnPrz.Checked = True Or rbtnPsn.Checked = True Then
                Return 0
            ElseIf rbtnSlp.Checked = True Or rbtnFrz.Checked = True Then
                Return 10
            Else
                Return 0
            End If
        End If

        If getGen() = 3 Or getGen() = 4 Then
            If rbtnBurn.Checked = True Or rbtnPrz.Checked = True Or rbtnPsn.Checked = True Then
                Return 1.5
            ElseIf rbtnSlp.Checked = True Or rbtnFrz.Checked = True Then
                Return 2
            Else
                Return 1
            End If
        End If

        If getGen() = 5 Or getGen() = 6 Then
            If rbtnBurn.Checked = True Or rbtnPrz.Checked = True Or rbtnPsn.Checked = True Then
                Return 1.5
            ElseIf rbtnSlp.Checked = True Or rbtnFrz.Checked = True Then
                Return 2.5
            Else
                Return 1
            End If
        End If

        Return 1

    End Function

    Function getBallType() As Double ' To specify the ball multiplier (Past Gen 1) ; Gen 1 uses 3 values
        If getGen() = 1 Then
            If cBoxPokeType.SelectedIndex = 0 Then ' Poke Ball
                Return 255
            ElseIf cBoxPokeType.SelectedIndex = 1 Then ' Great Ball
                Return 200
            Else
                Return 150 ' Any other ball type
            End If
        Else
            If cBoxPokeType.SelectedIndex = 0 Then ' Poke Ball
                Return 1
            ElseIf cBoxPokeType.SelectedIndex = 1 Then ' Great Ball
                Return 1.5
            ElseIf cBoxPokeType.SelectedIndex = 2 Then ' Ultra Ball
                Return 2
            ElseIf cBoxPokeType.SelectedIndex = 4 Then ' Skip Master Ball ;;; Safari Ball
                Return 1.5
            ElseIf cBoxPokeType.SelectedIndex = 5 Then ' Fast Ball
                If getBonusFactorTF() = True Then
                    Return 4
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 6 Then ' Friend Ball
                Return 1
            ElseIf cBoxPokeType.SelectedIndex = 7 Then ' Heavy Ball NOT COMPLETE
                Dim weightNum As Double

                Try
                    If (CInt(txtBoxFactor1.Text) >= 0 And CInt(txtBoxFactor1.Text) < 10000) Then
                        weightNum = CDbl(txtBoxFactor1.Text)
                        If weightNum < 225.8 Then
                            Return -20
                        ElseIf weightNum >= 255.8 And weightNum < 451.5 Then  '255.8 - 451.5
                            Return 0
                        ElseIf weightNum >= 451.5 And weightNum < 677.3 Then  '451.5 - 677.3
                            Return 20
                        ElseIf weightNum >= 677.3 And weightNum < 903.0 Then  '677.3 - 903.0
                            Return 30
                        Else
                            Return 40
                        End If

                    Else
                        MsgBox("Please enter a reasonable number")
                        Return 0
                    End If
                Catch Exc As System.InvalidCastException
                    MsgBox("Please enter a reasonable number")
                    Return 0
                End Try

            ElseIf cBoxPokeType.SelectedIndex = 8 Then ' Level Ball
                Dim levelNum1 As Byte
                Dim levelNum2 As Byte

                Try
                    If (CInt(txtBoxFactor1.Text) >= 0 And CInt(txtBoxFactor1.Text) < 100) And (CInt(txtBoxFactor2.Text) >= 0 And CInt(txtBoxFactor2.Text) < 100) Then
                        levelNum1 = CInt(txtBoxFactor1.Text)
                        levelNum2 = CInt(txtBoxFactor2.Text)
                        If levelNum1 <= levelNum2 Then
                            Return 1
                        ElseIf levelNum1 > levelNum2 * 2 Then
                            Return 2
                        ElseIf levelNum1 > levelNum2 * 4 Then
                            Return 4
                        Else
                            Return 8
                        End If

                    Else
                        MsgBox("Please enter a number between 1 and 100")
                        Return 0
                    End If
                Catch Exc As System.InvalidCastException
                    MsgBox("Please enter a number between 1 and 100")
                    Return 0
                End Try
            ElseIf cBoxPokeType.SelectedIndex = 9 Then ' Love Ball
                If getBonusFactorTF() = True Then
                    Return 8
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 10 Then ' Lure Ball
                If getBonusFactorTF() = True Then
                    Return 3
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 11 Then ' Moon Ball
                If getBonusFactorTF() And getGen() = 4 Then
                    Return 4
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 12 Then ' Dive Ball
                If getBonusFactorTF() = True Then
                    Return 3.5
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 13 Then ' Luxury Ball
                Return 1
            ElseIf cBoxPokeType.SelectedIndex = 14 Then ' Net Ball
                If getBonusFactorTF() = True Then
                    Return 3
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 15 Then ' Nest Ball
                Dim nestNum As Byte

                Try
                    If CInt(txtBoxFactor1.Text) >= 0 And CInt(txtBoxFactor1.Text) < 100 Then
                        nestNum = CInt(txtBoxFactor1.Text)
                        If getGen() = 3 Or getGen() = 4 Then
                            If nestNum < 30 Then
                                Return ((40 - nestNum) / 10)
                            Else
                                Return 1
                            End If
                        Else
                            If nestNum < 31 Then
                                Return ((41 - nestNum) / 10)
                            Else
                                Return 1
                            End If
                        End If

                    Else
                        MsgBox("Please enter a value between 1 and 100")
                        Return 0
                    End If
                Catch Exc As System.InvalidCastException
                    MsgBox("Please enter a value between 1 and 100")
                    Return 0
                End Try
            ElseIf cBoxPokeType.SelectedIndex = 16 Then ' Premier Ball
                Return 1
            ElseIf cBoxPokeType.SelectedIndex = 17 Then ' Repeat Ball
                If getBonusFactorTF() = True Then
                    Return 3
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 18 Then ' Timer Ball
                Dim turnsPast As Byte

                Try
                    If CInt(txtBoxTurnsPast.Text) >= 0 And CInt(txtBoxTurnsPast.Text) < 100 Then
                        turnsPast = CInt(txtBoxTurnsPast.Text)
                        If getGen() = 3 Or getGen() = 4 Then
                            If turnsPast < 30 Then
                                Return ((turnsPast + 10) / 10)
                            Else
                                Return 4
                            End If
                        Else
                            If turnsPast < 10 Then
                                Return (1 + turnsPast * (1229 / 4096))
                            Else
                                Return 4
                            End If
                        End If

                    Else
                        MsgBox("Please enter a value between 1 and 100")
                        Return 0
                    End If
                Catch Exc As System.InvalidCastException
                    MsgBox("Please enter a value between 1 and 100")
                    Return 0
                End Try
            ElseIf cBoxPokeType.SelectedIndex = 19 Then ' Dusk Ball
                If getBonusFactorTF() = True Then
                    Return 3.5
                Else
                    Return 1
                End If
            ElseIf cBoxPokeType.SelectedIndex = 20 Then ' Heal Ball
                Return 1
            ElseIf cBoxPokeType.SelectedIndex = 21 Then ' Park / Sport Ball
                Return 1.5
            ElseIf cBoxPokeType.SelectedIndex = 22 Then ' Quick Ball
                If getBonusFactorTF() = True Then
                    Return 4
                Else
                    Return 1
                End If
            End If
        End If

        Return 1

    End Function

    Function getMaxHp() As Integer ' Linked to remaining HP ; Always positive
        Try
            If CInt(txtBoxMaxHP.Text) >= 0 Then
                Return CInt(txtBoxMaxHP.Text)
            Else
                MsgBox("Please enter a positive nonzero number")
                Return 0
            End If
        Catch Exc As System.InvalidCastException
            MsgBox("Please enter a number for Max HP")
            Return 0
        End Try

    End Function

    Function getRemainingHp() As Integer ' Linked to max HP ; Takes the difference ; Always positive
        Try
            If CInt(txtBoxRemainHP.Text) >= 0 Then
                Return CInt(txtBoxRemainHP.Text)
            Else
                MsgBox("Please enter a positive nonzero number")
                Return 0
            End If
        Catch Exc As System.InvalidCastException
            MsgBox("Please enter a number for Remaining HP")
            Return 0
        End Try

    End Function

    Function getCatchRate() As Byte ' From 3 - 255 ; 
        Try
            If CInt(txtBoxCatchRate.Text) >= 3 And CInt(txtBoxCatchRate.Text) <= 255 Then
                Return CInt(txtBoxCatchRate.Text)
            Else
                MsgBox("Please enter a number between 3 and 255")
                Return 0
            End If
        Catch Exc As System.InvalidCastException
            MsgBox("Please enter a number between 3 and 255")
            Return 0
        End Try

    End Function
    'End Always Called

    Function getBonusFactorNum() As Double ' Any bonuses from ball types beyond base multiplier
        Return 10
    End Function

    Function getBonusFactorTF() As Boolean 'True if checkbox is checked ; False otherwise.
        Return cbtnFactorCheck.Checked
    End Function

    Function getCapturePower() As Double ' Gen 5 / 6 only ; either 1.1 , 1.2 , or 1.3; or 1.5 , 2 , 2.5 ; Dependant on getGen()
        If getGen() = 5 Then
            If rbtnNoCapPow.Checked = True Then
                Return 1
            ElseIf rbtnCapPow1.Checked = True Then
                Return 1.1
            ElseIf rbtnCapPow2.Checked = True Then
                Return 1.2
            Else
                Return 1.3
            End If
        End If

        If getGen() = 6 Then
            If rbtnNoCapPow.Checked = True Then
                Return 1
            ElseIf rbtnCapPow1.Checked = True Then
                Return 1.5
            ElseIf rbtnCapPow2.Checked = True Then
                Return 2
            Else
                Return 2.5
            End If
        End If

        Return 1
    End Function

    Function getDarkGrass() As Double ' The higher the range, the higher the multiplier
        If cbtnDarkGrass.Checked = True Then
            If cboxPokesCaught2.SelectedIndex = 0 Then
                Return (1229 / 4096)
            ElseIf cboxPokesCaught2.SelectedIndex = 1
                Return (1 / 2)
            ElseIf cboxPokesCaught2.SelectedIndex = 2
                Return (2867 / 4096)
            ElseIf cboxPokesCaught2.SelectedIndex = 3
                Return (3277 / 4096)
            ElseIf cboxPokesCaught2.SelectedIndex = 4
                Return (3686 / 4096)
            Else
                Return 1
            End If
        End If
        Return 1
    End Function

    'Start Critical Capture Only
    Function getCriticalCaptureState() As Boolean ' Only asks if the critical capture chance should be calculated for
        Return cbtnAskCalcCrit.Checked
    End Function

    Private Sub calcCritCap(ByVal P As Double)
        Dim critChance As Double
        Dim CC As Double

        CC = (P * getPokesObtained()) / 6

        critChance = CC / 256

        lblCritCapPer.Text = critChance.ToString("p")
    End Sub

    Function getPokesObtained() As Double ' Essentially the same thing as getDarkGrass()
        If cboxPokesCaught1.SelectedIndex = 0 Then
            Return (1229 / 4096)
        ElseIf cboxPokesCaught1.SelectedIndex = 1
            Return (1 / 2)
        ElseIf cboxPokesCaught1.SelectedIndex = 2
            Return (2867 / 4096)
        ElseIf cboxPokesCaught1.SelectedIndex = 3
            Return (3277 / 4096)
        ElseIf cboxPokesCaught1.SelectedIndex = 4
            Return (3686 / 4096)
        Else
            Return 1
        End If
        Return 1
    End Function
    'End Critical Capture Only

    'Start Extra Equation Calculation calls
    Function calculateF() As Byte ' Result can neither be negative, or greater than 255
        Dim f As Byte

        f = (getMaxHp() * 255 * 4) / (getRemainingHp() * isGen1GreatBall())
        Return f

    End Function

    Function isGen1GreatBall() As Byte ' Change to CONTSTANTS later
        If (cBoxPokeType.SelectedIndex = 1) Then
            Return 8
        Else
            Return 12
        End If
    End Function
    'End Extra Equation Calculation Calls

    Private Sub clearAll()
        rbtnGen6.Checked = True
        rbtnNoStatus.Checked = True
        rbtnNoCapPow.Checked = True
        cBoxPokeType.SelectedIndex = 0
        cboxPokesCaught1.SelectedIndex = 0
        cboxPokesCaught2.SelectedIndex = 0
    End Sub

    Private Sub rbtnCapPow3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCapPow3.CheckedChanged

    End Sub

    Private Sub cbtnAskCalcCrit_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnAskCalcCrit.CheckedChanged

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clearAll()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub cboxSelectPoke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSelectPoke.SelectedIndexChanged
        getArray(cboxSelectPoke.Items.Count, cboxSelectPoke.SelectedIndex, cboxSelGenNum.SelectedIndex, txtBoxCatchRate)
    End Sub

    Private Sub cbtnManualRate_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnManualRate.CheckedChanged
        If txtBoxCatchRate.Enabled = False Then
            txtBoxCatchRate.Enabled = True
        Else
            txtBoxCatchRate.Enabled = False
        End If
    End Sub

    Private Sub cboxSelGenNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSelGenNum.SelectedIndexChanged
        setLimitedPokemon(cboxSelGenNum.SelectedIndex, cboxSelectPoke)
    End Sub
End Class
