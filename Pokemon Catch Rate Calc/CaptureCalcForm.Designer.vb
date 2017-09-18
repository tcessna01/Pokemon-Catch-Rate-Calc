<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PokemonCatchCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PokemonCatchCalc))
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnGen6 = New System.Windows.Forms.RadioButton()
        Me.rbtnGen5 = New System.Windows.Forms.RadioButton()
        Me.rbtnGen4 = New System.Windows.Forms.RadioButton()
        Me.rbtnGen3 = New System.Windows.Forms.RadioButton()
        Me.rbtnGen2 = New System.Windows.Forms.RadioButton()
        Me.rbtnGen1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnBurn = New System.Windows.Forms.RadioButton()
        Me.rbtnNoStatus = New System.Windows.Forms.RadioButton()
        Me.rbtnFrz = New System.Windows.Forms.RadioButton()
        Me.rbtnPsn = New System.Windows.Forms.RadioButton()
        Me.rbtnSlp = New System.Windows.Forms.RadioButton()
        Me.rbtnPrz = New System.Windows.Forms.RadioButton()
        Me.cBoxPokeType = New System.Windows.Forms.ComboBox()
        Me.cboxPokesCaught1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ballPic = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbtnAskCalcCrit = New System.Windows.Forms.CheckBox()
        Me.lblCritChance = New System.Windows.Forms.Label()
        Me.lblCritCapPer = New System.Windows.Forms.Label()
        Me.lblPokeObt1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbtnNoCapPow = New System.Windows.Forms.RadioButton()
        Me.lblPokeObt2 = New System.Windows.Forms.Label()
        Me.rbtnCapPow3 = New System.Windows.Forms.RadioButton()
        Me.rbtnCapPow2 = New System.Windows.Forms.RadioButton()
        Me.rbtnCapPow1 = New System.Windows.Forms.RadioButton()
        Me.cboxPokesCaught2 = New System.Windows.Forms.ComboBox()
        Me.cbtnDarkGrass = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblSelGen = New System.Windows.Forms.Label()
        Me.cboxSelGenNum = New System.Windows.Forms.ComboBox()
        Me.cbtnManualRate = New System.Windows.Forms.CheckBox()
        Me.cboxSelectPoke = New System.Windows.Forms.ComboBox()
        Me.txtBoxMaxHP = New System.Windows.Forms.TextBox()
        Me.lblMaxHP = New System.Windows.Forms.Label()
        Me.lblCatchRate = New System.Windows.Forms.Label()
        Me.lblRemainHP = New System.Windows.Forms.Label()
        Me.txtBoxRemainHP = New System.Windows.Forms.TextBox()
        Me.txtBoxCatchRate = New System.Windows.Forms.TextBox()
        Me.txtBoxTurnsPast = New System.Windows.Forms.TextBox()
        Me.lblTurnsPast = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.txtBoxFactor2 = New System.Windows.Forms.TextBox()
        Me.txtBoxFactor1 = New System.Windows.Forms.TextBox()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.cbtnFactorCheck = New System.Windows.Forms.CheckBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblEstPercent = New System.Windows.Forms.Label()
        Me.lblCapture = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ballPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(218, 352)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(103, 42)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "C&alculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnGen6)
        Me.GroupBox1.Controls.Add(Me.rbtnGen5)
        Me.GroupBox1.Controls.Add(Me.rbtnGen4)
        Me.GroupBox1.Controls.Add(Me.rbtnGen3)
        Me.GroupBox1.Controls.Add(Me.rbtnGen2)
        Me.GroupBox1.Controls.Add(Me.rbtnGen1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generation"
        '
        'rbtnGen6
        '
        Me.rbtnGen6.AutoSize = True
        Me.rbtnGen6.Location = New System.Drawing.Point(103, 126)
        Me.rbtnGen6.Name = "rbtnGen6"
        Me.rbtnGen6.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen6.TabIndex = 5
        Me.rbtnGen6.TabStop = True
        Me.rbtnGen6.Text = "Gen 6"
        Me.rbtnGen6.UseVisualStyleBackColor = True
        '
        'rbtnGen5
        '
        Me.rbtnGen5.AutoSize = True
        Me.rbtnGen5.Location = New System.Drawing.Point(103, 73)
        Me.rbtnGen5.Name = "rbtnGen5"
        Me.rbtnGen5.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen5.TabIndex = 4
        Me.rbtnGen5.TabStop = True
        Me.rbtnGen5.Text = "Gen 5"
        Me.rbtnGen5.UseVisualStyleBackColor = True
        '
        'rbtnGen4
        '
        Me.rbtnGen4.AutoSize = True
        Me.rbtnGen4.Location = New System.Drawing.Point(103, 20)
        Me.rbtnGen4.Name = "rbtnGen4"
        Me.rbtnGen4.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen4.TabIndex = 3
        Me.rbtnGen4.TabStop = True
        Me.rbtnGen4.Text = "Gen 4"
        Me.rbtnGen4.UseVisualStyleBackColor = True
        '
        'rbtnGen3
        '
        Me.rbtnGen3.AutoSize = True
        Me.rbtnGen3.Location = New System.Drawing.Point(6, 127)
        Me.rbtnGen3.Name = "rbtnGen3"
        Me.rbtnGen3.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen3.TabIndex = 2
        Me.rbtnGen3.TabStop = True
        Me.rbtnGen3.Text = "Gen 3"
        Me.rbtnGen3.UseVisualStyleBackColor = True
        '
        'rbtnGen2
        '
        Me.rbtnGen2.AutoSize = True
        Me.rbtnGen2.Location = New System.Drawing.Point(7, 73)
        Me.rbtnGen2.Name = "rbtnGen2"
        Me.rbtnGen2.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen2.TabIndex = 1
        Me.rbtnGen2.TabStop = True
        Me.rbtnGen2.Text = "Gen 2"
        Me.rbtnGen2.UseVisualStyleBackColor = True
        '
        'rbtnGen1
        '
        Me.rbtnGen1.AutoSize = True
        Me.rbtnGen1.Location = New System.Drawing.Point(7, 19)
        Me.rbtnGen1.Name = "rbtnGen1"
        Me.rbtnGen1.Size = New System.Drawing.Size(54, 17)
        Me.rbtnGen1.TabIndex = 0
        Me.rbtnGen1.TabStop = True
        Me.rbtnGen1.Text = "Gen 1"
        Me.rbtnGen1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnBurn)
        Me.GroupBox2.Controls.Add(Me.rbtnNoStatus)
        Me.GroupBox2.Controls.Add(Me.rbtnFrz)
        Me.GroupBox2.Controls.Add(Me.rbtnPsn)
        Me.GroupBox2.Controls.Add(Me.rbtnSlp)
        Me.GroupBox2.Controls.Add(Me.rbtnPrz)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 104)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'rbtnBurn
        '
        Me.rbtnBurn.AutoSize = True
        Me.rbtnBurn.Location = New System.Drawing.Point(114, 51)
        Me.rbtnBurn.Name = "rbtnBurn"
        Me.rbtnBurn.Size = New System.Drawing.Size(59, 17)
        Me.rbtnBurn.TabIndex = 5
        Me.rbtnBurn.TabStop = True
        Me.rbtnBurn.Text = "Burned"
        Me.rbtnBurn.UseVisualStyleBackColor = True
        '
        'rbtnNoStatus
        '
        Me.rbtnNoStatus.AutoSize = True
        Me.rbtnNoStatus.Location = New System.Drawing.Point(6, 22)
        Me.rbtnNoStatus.Name = "rbtnNoStatus"
        Me.rbtnNoStatus.Size = New System.Drawing.Size(51, 17)
        Me.rbtnNoStatus.TabIndex = 4
        Me.rbtnNoStatus.TabStop = True
        Me.rbtnNoStatus.Text = "None"
        Me.rbtnNoStatus.UseVisualStyleBackColor = True
        '
        'rbtnFrz
        '
        Me.rbtnFrz.AutoSize = True
        Me.rbtnFrz.Location = New System.Drawing.Point(114, 80)
        Me.rbtnFrz.Name = "rbtnFrz"
        Me.rbtnFrz.Size = New System.Drawing.Size(57, 17)
        Me.rbtnFrz.TabIndex = 3
        Me.rbtnFrz.TabStop = True
        Me.rbtnFrz.Text = "Frozen"
        Me.rbtnFrz.UseVisualStyleBackColor = True
        '
        'rbtnPsn
        '
        Me.rbtnPsn.AutoSize = True
        Me.rbtnPsn.Location = New System.Drawing.Point(6, 51)
        Me.rbtnPsn.Name = "rbtnPsn"
        Me.rbtnPsn.Size = New System.Drawing.Size(69, 17)
        Me.rbtnPsn.TabIndex = 2
        Me.rbtnPsn.TabStop = True
        Me.rbtnPsn.Text = "Poisoned"
        Me.rbtnPsn.UseVisualStyleBackColor = True
        '
        'rbtnSlp
        '
        Me.rbtnSlp.AutoSize = True
        Me.rbtnSlp.Location = New System.Drawing.Point(6, 80)
        Me.rbtnSlp.Name = "rbtnSlp"
        Me.rbtnSlp.Size = New System.Drawing.Size(52, 17)
        Me.rbtnSlp.TabIndex = 1
        Me.rbtnSlp.TabStop = True
        Me.rbtnSlp.Text = "Sleep"
        Me.rbtnSlp.UseVisualStyleBackColor = True
        '
        'rbtnPrz
        '
        Me.rbtnPrz.AutoSize = True
        Me.rbtnPrz.Location = New System.Drawing.Point(114, 22)
        Me.rbtnPrz.Name = "rbtnPrz"
        Me.rbtnPrz.Size = New System.Drawing.Size(71, 17)
        Me.rbtnPrz.TabIndex = 0
        Me.rbtnPrz.TabStop = True
        Me.rbtnPrz.Text = "Paralyzed"
        Me.rbtnPrz.UseVisualStyleBackColor = True
        '
        'cBoxPokeType
        '
        Me.cBoxPokeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxPokeType.FormattingEnabled = True
        Me.cBoxPokeType.Items.AddRange(New Object() {"Poke Ball", "Great Ball", "Ultra Ball", "Master Ball", "Safari Ball", "Fast Ball", "Friend Ball", "Heavy Ball", "Level Ball", "Love Ball", "Lure Ball", "Moon Ball", "Dive Ball", "Luxury Ball", "Net Ball", "Nest Ball", "Premier Ball", "Repeat Ball", "Timer Ball", "Dusk Ball", "Heal Ball", "Park / Sport Ball", "Quick Ball"})
        Me.cBoxPokeType.Location = New System.Drawing.Point(7, 25)
        Me.cBoxPokeType.Name = "cBoxPokeType"
        Me.cBoxPokeType.Size = New System.Drawing.Size(121, 21)
        Me.cBoxPokeType.TabIndex = 6
        '
        'cboxPokesCaught1
        '
        Me.cboxPokesCaught1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPokesCaught1.FormattingEnabled = True
        Me.cboxPokesCaught1.Items.AddRange(New Object() {"0 - 30", "31 - 150", "151 - 300", "301 - 450", "451 - 600", "600+"})
        Me.cboxPokesCaught1.Location = New System.Drawing.Point(6, 52)
        Me.cboxPokesCaught1.Name = "cboxPokesCaught1"
        Me.cboxPokesCaught1.Size = New System.Drawing.Size(127, 21)
        Me.cboxPokesCaught1.TabIndex = 4
        Me.cboxPokesCaught1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ballPic)
        Me.GroupBox3.Controls.Add(Me.cBoxPokeType)
        Me.GroupBox3.Location = New System.Drawing.Point(221, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 63)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pokéball Type"
        '
        'ballPic
        '
        Me.ballPic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ballPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ballPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ballPic.Image = Global.Pokemon_Catch_Rate_Calc.My.Resources.Resources.Bag_Poké_Ball_Sprite
        Me.ballPic.InitialImage = CType(resources.GetObject("ballPic.InitialImage"), System.Drawing.Image)
        Me.ballPic.Location = New System.Drawing.Point(151, 19)
        Me.ballPic.Name = "ballPic"
        Me.ballPic.Size = New System.Drawing.Size(35, 34)
        Me.ballPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ballPic.TabIndex = 4
        Me.ballPic.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbtnAskCalcCrit)
        Me.GroupBox4.Controls.Add(Me.lblCritChance)
        Me.GroupBox4.Controls.Add(Me.lblCritCapPer)
        Me.GroupBox4.Controls.Add(Me.lblPokeObt1)
        Me.GroupBox4.Controls.Add(Me.cboxPokesCaught1)
        Me.GroupBox4.Location = New System.Drawing.Point(446, 206)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(139, 139)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Critical Capture Chance"
        '
        'cbtnAskCalcCrit
        '
        Me.cbtnAskCalcCrit.AutoSize = True
        Me.cbtnAskCalcCrit.Location = New System.Drawing.Point(9, 15)
        Me.cbtnAskCalcCrit.Name = "cbtnAskCalcCrit"
        Me.cbtnAskCalcCrit.Size = New System.Drawing.Size(76, 17)
        Me.cbtnAskCalcCrit.TabIndex = 8
        Me.cbtnAskCalcCrit.Text = "Calculate?"
        Me.cbtnAskCalcCrit.UseVisualStyleBackColor = True
        '
        'lblCritChance
        '
        Me.lblCritChance.AutoSize = True
        Me.lblCritChance.Location = New System.Drawing.Point(3, 88)
        Me.lblCritChance.Name = "lblCritChance"
        Me.lblCritChance.Size = New System.Drawing.Size(132, 13)
        Me.lblCritChance.TabIndex = 7
        Me.lblCritChance.Text = "Critical Capture Probability:"
        Me.lblCritChance.Visible = False
        '
        'lblCritCapPer
        '
        Me.lblCritCapPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCritCapPer.Location = New System.Drawing.Point(6, 104)
        Me.lblCritCapPer.Name = "lblCritCapPer"
        Me.lblCritCapPer.Size = New System.Drawing.Size(127, 23)
        Me.lblCritCapPer.TabIndex = 6
        Me.lblCritCapPer.Visible = False
        '
        'lblPokeObt1
        '
        Me.lblPokeObt1.AutoSize = True
        Me.lblPokeObt1.Location = New System.Drawing.Point(6, 36)
        Me.lblPokeObt1.Name = "lblPokeObt1"
        Me.lblPokeObt1.Size = New System.Drawing.Size(101, 13)
        Me.lblPokeObt1.TabIndex = 5
        Me.lblPokeObt1.Text = "Pokémon Obtained:"
        Me.lblPokeObt1.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbtnNoCapPow)
        Me.GroupBox5.Controls.Add(Me.lblPokeObt2)
        Me.GroupBox5.Controls.Add(Me.rbtnCapPow3)
        Me.GroupBox5.Controls.Add(Me.rbtnCapPow2)
        Me.GroupBox5.Controls.Add(Me.rbtnCapPow1)
        Me.GroupBox5.Controls.Add(Me.cboxPokesCaught2)
        Me.GroupBox5.Controls.Add(Me.cbtnDarkGrass)
        Me.GroupBox5.Location = New System.Drawing.Point(446, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 173)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gen 5 / 6 Factors"
        '
        'rbtnNoCapPow
        '
        Me.rbtnNoCapPow.AutoSize = True
        Me.rbtnNoCapPow.Location = New System.Drawing.Point(9, 18)
        Me.rbtnNoCapPow.Name = "rbtnNoCapPow"
        Me.rbtnNoCapPow.Size = New System.Drawing.Size(112, 17)
        Me.rbtnNoCapPow.TabIndex = 6
        Me.rbtnNoCapPow.TabStop = True
        Me.rbtnNoCapPow.Text = "No Capture Power"
        Me.rbtnNoCapPow.UseVisualStyleBackColor = True
        '
        'lblPokeObt2
        '
        Me.lblPokeObt2.AutoSize = True
        Me.lblPokeObt2.Location = New System.Drawing.Point(6, 130)
        Me.lblPokeObt2.Name = "lblPokeObt2"
        Me.lblPokeObt2.Size = New System.Drawing.Size(101, 13)
        Me.lblPokeObt2.TabIndex = 5
        Me.lblPokeObt2.Text = "Pokémon Obtained:"
        Me.lblPokeObt2.Visible = False
        '
        'rbtnCapPow3
        '
        Me.rbtnCapPow3.AutoSize = True
        Me.rbtnCapPow3.Location = New System.Drawing.Point(9, 87)
        Me.rbtnCapPow3.Name = "rbtnCapPow3"
        Me.rbtnCapPow3.Size = New System.Drawing.Size(104, 17)
        Me.rbtnCapPow3.TabIndex = 4
        Me.rbtnCapPow3.TabStop = True
        Me.rbtnCapPow3.Text = "Capture Power 3"
        Me.rbtnCapPow3.UseVisualStyleBackColor = True
        Me.rbtnCapPow3.Visible = False
        '
        'rbtnCapPow2
        '
        Me.rbtnCapPow2.AutoSize = True
        Me.rbtnCapPow2.Location = New System.Drawing.Point(9, 64)
        Me.rbtnCapPow2.Name = "rbtnCapPow2"
        Me.rbtnCapPow2.Size = New System.Drawing.Size(104, 17)
        Me.rbtnCapPow2.TabIndex = 3
        Me.rbtnCapPow2.TabStop = True
        Me.rbtnCapPow2.Text = "Capture Power 2"
        Me.rbtnCapPow2.UseVisualStyleBackColor = True
        Me.rbtnCapPow2.Visible = False
        '
        'rbtnCapPow1
        '
        Me.rbtnCapPow1.AutoSize = True
        Me.rbtnCapPow1.Location = New System.Drawing.Point(9, 41)
        Me.rbtnCapPow1.Name = "rbtnCapPow1"
        Me.rbtnCapPow1.Size = New System.Drawing.Size(104, 17)
        Me.rbtnCapPow1.TabIndex = 2
        Me.rbtnCapPow1.TabStop = True
        Me.rbtnCapPow1.Text = "Capture Power 1"
        Me.rbtnCapPow1.UseVisualStyleBackColor = True
        Me.rbtnCapPow1.Visible = False
        '
        'cboxPokesCaught2
        '
        Me.cboxPokesCaught2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPokesCaught2.FormattingEnabled = True
        Me.cboxPokesCaught2.Items.AddRange(New Object() {"0 - 30", "31 - 150", "151 - 300", "301 - 450", "451 - 600", "600+"})
        Me.cboxPokesCaught2.Location = New System.Drawing.Point(9, 146)
        Me.cboxPokesCaught2.Name = "cboxPokesCaught2"
        Me.cboxPokesCaught2.Size = New System.Drawing.Size(124, 21)
        Me.cboxPokesCaught2.TabIndex = 1
        Me.cboxPokesCaught2.Visible = False
        '
        'cbtnDarkGrass
        '
        Me.cbtnDarkGrass.AutoSize = True
        Me.cbtnDarkGrass.Location = New System.Drawing.Point(9, 110)
        Me.cbtnDarkGrass.Name = "cbtnDarkGrass"
        Me.cbtnDarkGrass.Size = New System.Drawing.Size(85, 17)
        Me.cbtnDarkGrass.TabIndex = 0
        Me.cbtnDarkGrass.Text = "Dark Grass?"
        Me.cbtnDarkGrass.UseVisualStyleBackColor = True
        Me.cbtnDarkGrass.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblSelGen)
        Me.GroupBox6.Controls.Add(Me.cboxSelGenNum)
        Me.GroupBox6.Controls.Add(Me.cbtnManualRate)
        Me.GroupBox6.Controls.Add(Me.cboxSelectPoke)
        Me.GroupBox6.Controls.Add(Me.txtBoxMaxHP)
        Me.GroupBox6.Controls.Add(Me.lblMaxHP)
        Me.GroupBox6.Controls.Add(Me.lblCatchRate)
        Me.GroupBox6.Controls.Add(Me.lblRemainHP)
        Me.GroupBox6.Controls.Add(Me.txtBoxRemainHP)
        Me.GroupBox6.Controls.Add(Me.txtBoxCatchRate)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(428, 70)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Normal Factors"
        '
        'lblSelGen
        '
        Me.lblSelGen.AutoSize = True
        Me.lblSelGen.Location = New System.Drawing.Point(292, 47)
        Me.lblSelGen.Name = "lblSelGen"
        Me.lblSelGen.Size = New System.Drawing.Size(87, 13)
        Me.lblSelGen.TabIndex = 10
        Me.lblSelGen.Text = "Filter Generation:"
        '
        'cboxSelGenNum
        '
        Me.cboxSelGenNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSelGenNum.FormattingEnabled = True
        Me.cboxSelGenNum.Items.AddRange(New Object() {"All", "1", "2", "3", "4", "5", "6"})
        Me.cboxSelGenNum.Location = New System.Drawing.Point(385, 44)
        Me.cboxSelGenNum.Name = "cboxSelGenNum"
        Me.cboxSelGenNum.Size = New System.Drawing.Size(37, 21)
        Me.cboxSelGenNum.TabIndex = 9
        '
        'cbtnManualRate
        '
        Me.cbtnManualRate.AutoSize = True
        Me.cbtnManualRate.Location = New System.Drawing.Point(199, 46)
        Me.cbtnManualRate.Name = "cbtnManualRate"
        Me.cbtnManualRate.Size = New System.Drawing.Size(67, 17)
        Me.cbtnManualRate.TabIndex = 8
        Me.cbtnManualRate.Text = "Manual?"
        Me.cbtnManualRate.UseVisualStyleBackColor = True
        '
        'cboxSelectPoke
        '
        Me.cboxSelectPoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSelectPoke.FormattingEnabled = True
        Me.cboxSelectPoke.Items.AddRange(New Object() {"Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "NidoranF", "Nidorina", "Nidoqueen", "NidoranM", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetails", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacreul", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaffy", "Ampharos", "Bellosom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillary", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrouge", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manetric", "Plusle", "Minum", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Wishcash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyorge", "Groudon", "Rayquaza", "Jirachi", "Deoxys", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Inferape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy", "Wormadam", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicy", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkledurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Swak", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scoliopede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan", "Maractus", "Dwebble", "Crustle", "Scraggly", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alommola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundurus", "Reshiram", "Zekrom", "Landarous", "Kyurem", "Keldeo", "Meloetta", "Genesect", "Chespin", "Quilladin", "Chestnaught", "Fennekin", "Braxien", "Delphox", "Froakie", "Frogadier", "Greninja", "Bunnelby", "Diggersby", "Fletchling", "Fletchlinder", "Talonflame", "Scatterbug", "Spewpa", "Vivillon", "Litleo", "Pyroar", "Flabebe", "Floette", "Florges", "Skiddo", "Gogoat", "Pancham", "Pangoro", "Furfrou", "Espurr", "Meowstic", "Honedge", "Doublade", "Aegislash", "Spritzee", "Aromatisse", "Swirlix", "Slurpuff", "Inkay", "Malamar", "Binacle", "Barbaracle", "Skrelp", "Dragalge", "Clauncher", "Clawitzer", "Heloptile", "Heliolisk", "Tyrunt", "Tyrantrum", "Amaura", "Aurorus", "Sylveon", "Hawlucha", "Dedenne", "Carbink", "Goomy", "Sliggoo", "Goodra", "Klefki", "Phantump", "Trevenant", "Pumpkaboo", "Gourgiest", "Bergmite", "Avalugg", "Noibat", "Noivern", "Xerneas", "Yvaltal", "Zygarde", "Diancie", "Hoopa", "Volcanion"})
        Me.cboxSelectPoke.Location = New System.Drawing.Point(324, 16)
        Me.cboxSelectPoke.MaxDropDownItems = 5
        Me.cboxSelectPoke.Name = "cboxSelectPoke"
        Me.cboxSelectPoke.Size = New System.Drawing.Size(98, 21)
        Me.cboxSelectPoke.TabIndex = 7
        '
        'txtBoxMaxHP
        '
        Me.txtBoxMaxHP.Location = New System.Drawing.Point(111, 18)
        Me.txtBoxMaxHP.MaxLength = 3
        Me.txtBoxMaxHP.Name = "txtBoxMaxHP"
        Me.txtBoxMaxHP.Size = New System.Drawing.Size(73, 20)
        Me.txtBoxMaxHP.TabIndex = 0
        '
        'lblMaxHP
        '
        Me.lblMaxHP.AutoSize = True
        Me.lblMaxHP.Location = New System.Drawing.Point(6, 20)
        Me.lblMaxHP.Name = "lblMaxHP"
        Me.lblMaxHP.Size = New System.Drawing.Size(69, 13)
        Me.lblMaxHP.TabIndex = 4
        Me.lblMaxHP.Text = "Est. Max HP:"
        '
        'lblCatchRate
        '
        Me.lblCatchRate.AutoSize = True
        Me.lblCatchRate.Location = New System.Drawing.Point(196, 21)
        Me.lblCatchRate.Name = "lblCatchRate"
        Me.lblCatchRate.Size = New System.Drawing.Size(64, 13)
        Me.lblCatchRate.TabIndex = 3
        Me.lblCatchRate.Text = "Catch Rate:"
        '
        'lblRemainHP
        '
        Me.lblRemainHP.AutoSize = True
        Me.lblRemainHP.Location = New System.Drawing.Point(6, 47)
        Me.lblRemainHP.Name = "lblRemainHP"
        Me.lblRemainHP.Size = New System.Drawing.Size(99, 13)
        Me.lblRemainHP.TabIndex = 2
        Me.lblRemainHP.Text = "Est. HP Remaining:"
        '
        'txtBoxRemainHP
        '
        Me.txtBoxRemainHP.Location = New System.Drawing.Point(111, 44)
        Me.txtBoxRemainHP.MaxLength = 3
        Me.txtBoxRemainHP.Name = "txtBoxRemainHP"
        Me.txtBoxRemainHP.Size = New System.Drawing.Size(73, 20)
        Me.txtBoxRemainHP.TabIndex = 1
        '
        'txtBoxCatchRate
        '
        Me.txtBoxCatchRate.Enabled = False
        Me.txtBoxCatchRate.Location = New System.Drawing.Point(276, 18)
        Me.txtBoxCatchRate.MaxLength = 3
        Me.txtBoxCatchRate.Name = "txtBoxCatchRate"
        Me.txtBoxCatchRate.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxCatchRate.TabIndex = 2
        '
        'txtBoxTurnsPast
        '
        Me.txtBoxTurnsPast.Location = New System.Drawing.Point(73, 56)
        Me.txtBoxTurnsPast.MaxLength = 5
        Me.txtBoxTurnsPast.Name = "txtBoxTurnsPast"
        Me.txtBoxTurnsPast.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxTurnsPast.TabIndex = 3
        '
        'lblTurnsPast
        '
        Me.lblTurnsPast.AutoSize = True
        Me.lblTurnsPast.Location = New System.Drawing.Point(6, 63)
        Me.lblTurnsPast.Name = "lblTurnsPast"
        Me.lblTurnsPast.Size = New System.Drawing.Size(61, 13)
        Me.lblTurnsPast.TabIndex = 6
        Me.lblTurnsPast.Text = "Turns Past:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblFactor2)
        Me.GroupBox7.Controls.Add(Me.txtBoxFactor2)
        Me.GroupBox7.Controls.Add(Me.txtBoxTurnsPast)
        Me.GroupBox7.Controls.Add(Me.txtBoxFactor1)
        Me.GroupBox7.Controls.Add(Me.lblTurnsPast)
        Me.GroupBox7.Controls.Add(Me.lblFactor1)
        Me.GroupBox7.Controls.Add(Me.cbtnFactorCheck)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Bonus Factors"
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.Location = New System.Drawing.Point(100, 16)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(46, 13)
        Me.lblFactor2.TabIndex = 6
        Me.lblFactor2.Text = "Factor 2"
        Me.lblFactor2.Visible = False
        '
        'txtBoxFactor2
        '
        Me.txtBoxFactor2.Location = New System.Drawing.Point(103, 32)
        Me.txtBoxFactor2.Name = "txtBoxFactor2"
        Me.txtBoxFactor2.Size = New System.Drawing.Size(46, 20)
        Me.txtBoxFactor2.TabIndex = 5
        Me.txtBoxFactor2.Visible = False
        '
        'txtBoxFactor1
        '
        Me.txtBoxFactor1.Location = New System.Drawing.Point(9, 32)
        Me.txtBoxFactor1.Name = "txtBoxFactor1"
        Me.txtBoxFactor1.Size = New System.Drawing.Size(46, 20)
        Me.txtBoxFactor1.TabIndex = 4
        Me.txtBoxFactor1.Visible = False
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.Location = New System.Drawing.Point(6, 16)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(46, 13)
        Me.lblFactor1.TabIndex = 3
        Me.lblFactor1.Text = "Factor 1"
        Me.lblFactor1.Visible = False
        '
        'cbtnFactorCheck
        '
        Me.cbtnFactorCheck.AutoSize = True
        Me.cbtnFactorCheck.Location = New System.Drawing.Point(9, 83)
        Me.cbtnFactorCheck.Name = "cbtnFactorCheck"
        Me.cbtnFactorCheck.Size = New System.Drawing.Size(90, 17)
        Me.cbtnFactorCheck.TabIndex = 0
        Me.cbtnFactorCheck.Text = "Factor Check"
        Me.cbtnFactorCheck.UseVisualStyleBackColor = True
        Me.cbtnFactorCheck.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(482, 351)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(103, 42)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblEstPercent)
        Me.GroupBox8.Controls.Add(Me.lblCapture)
        Me.GroupBox8.Location = New System.Drawing.Point(218, 283)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(222, 62)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Capture Chance"
        '
        'lblEstPercent
        '
        Me.lblEstPercent.AutoSize = True
        Me.lblEstPercent.Location = New System.Drawing.Point(11, 28)
        Me.lblEstPercent.Name = "lblEstPercent"
        Me.lblEstPercent.Size = New System.Drawing.Size(90, 13)
        Me.lblEstPercent.TabIndex = 1
        Me.lblEstPercent.Text = "Est. Percent:     ~"
        '
        'lblCapture
        '
        Me.lblCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCapture.Location = New System.Drawing.Point(102, 24)
        Me.lblCapture.Name = "lblCapture"
        Me.lblCapture.Size = New System.Drawing.Size(100, 23)
        Me.lblCapture.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(350, 352)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 42)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClearToolStripMenuItem.Text = "Reset Values"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PokemonCatchCalc
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(596, 404)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "PokemonCatchCalc"
        Me.Text = "Pokémon Capture Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ballPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnGen6 As RadioButton
    Friend WithEvents rbtnGen5 As RadioButton
    Friend WithEvents rbtnGen4 As RadioButton
    Friend WithEvents rbtnGen3 As RadioButton
    Friend WithEvents rbtnGen2 As RadioButton
    Friend WithEvents rbtnGen1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnFrz As RadioButton
    Friend WithEvents rbtnPsn As RadioButton
    Friend WithEvents rbtnSlp As RadioButton
    Friend WithEvents rbtnPrz As RadioButton
    Friend WithEvents cBoxPokeType As ComboBox
    Friend WithEvents cboxPokesCaught1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblCritChance As Label
    Friend WithEvents lblCritCapPer As Label
    Friend WithEvents lblPokeObt1 As Label
    Friend WithEvents ballPic As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbtnCapPow3 As RadioButton
    Friend WithEvents rbtnCapPow2 As RadioButton
    Friend WithEvents rbtnCapPow1 As RadioButton
    Friend WithEvents cboxPokesCaught2 As ComboBox
    Friend WithEvents cbtnDarkGrass As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtBoxTurnsPast As TextBox
    Friend WithEvents lblTurnsPast As Label
    Friend WithEvents txtBoxMaxHP As TextBox
    Friend WithEvents lblMaxHP As Label
    Friend WithEvents lblCatchRate As Label
    Friend WithEvents lblRemainHP As Label
    Friend WithEvents txtBoxRemainHP As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents txtBoxFactor2 As TextBox
    Friend WithEvents txtBoxFactor1 As TextBox
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents cbtnFactorCheck As CheckBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblEstPercent As Label
    Friend WithEvents lblCapture As Label
    Friend WithEvents rbtnBurn As RadioButton
    Friend WithEvents rbtnNoStatus As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPokeObt2 As Label
    Friend WithEvents rbtnNoCapPow As RadioButton
    Friend WithEvents cbtnAskCalcCrit As CheckBox
    Friend WithEvents cboxSelectPoke As ComboBox
    Public WithEvents txtBoxCatchRate As TextBox
    Friend WithEvents lblSelGen As Label
    Friend WithEvents cboxSelGenNum As ComboBox
    Friend WithEvents cbtnManualRate As CheckBox
End Class
