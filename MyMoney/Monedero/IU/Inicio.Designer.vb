<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PanIngre = New System.Windows.Forms.Panel()
        Me.ButRemoI = New System.Windows.Forms.Button()
        Me.ChBHoraI = New System.Windows.Forms.CheckBox()
        Me.ChBFechI = New System.Windows.Forms.CheckBox()
        Me.ButAgreI = New System.Windows.Forms.Button()
        Me.DTPHoraI = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechI = New System.Windows.Forms.DateTimePicker()
        Me.PanRazoI = New System.Windows.Forms.Panel()
        Me.RTBRazoI = New System.Windows.Forms.RichTextBox()
        Me.LabRazoI = New System.Windows.Forms.Label()
        Me.TxBCantI = New System.Windows.Forms.TextBox()
        Me.LabCantI = New System.Windows.Forms.Label()
        Me.LabEgres = New System.Windows.Forms.Label()
        Me.LabIngre = New System.Windows.Forms.Label()
        Me.PanEgres = New System.Windows.Forms.Panel()
        Me.ButRemoE = New System.Windows.Forms.Button()
        Me.ChBHoraE = New System.Windows.Forms.CheckBox()
        Me.ChBFechE = New System.Windows.Forms.CheckBox()
        Me.ButAgreE = New System.Windows.Forms.Button()
        Me.DTPHoraE = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechE = New System.Windows.Forms.DateTimePicker()
        Me.PanRazoE = New System.Windows.Forms.Panel()
        Me.RTBRazoE = New System.Windows.Forms.RichTextBox()
        Me.LabRazoE = New System.Windows.Forms.Label()
        Me.TxBCantE = New System.Windows.Forms.TextBox()
        Me.LabCantE = New System.Windows.Forms.Label()
        Me.PanLimpT = New System.Windows.Forms.Panel()
        Me.ButLimpT = New System.Windows.Forms.Button()
        Me.TStBaS = New System.Windows.Forms.ToolStrip()
        Me.LabTotl = New System.Windows.Forms.ToolStripLabel()
        Me.TSBSSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButVacio = New System.Windows.Forms.ToolStripButton()
        Me.TSBSSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TaCIngre = New System.Windows.Forms.TabControl()
        Me.TaPIngre = New System.Windows.Forms.TabPage()
        Me.TxBSumaI = New System.Windows.Forms.TextBox()
        Me.TxBIdenI = New System.Windows.Forms.TextBox()
        Me.DGVSumaI = New System.Windows.Forms.DataGridView()
        Me.DGVDatoI = New System.Windows.Forms.DataGridView()
        Me.TaCEgres = New System.Windows.Forms.TabControl()
        Me.TaPEgres = New System.Windows.Forms.TabPage()
        Me.TxBSumaE = New System.Windows.Forms.TextBox()
        Me.TxBIdenE = New System.Windows.Forms.TextBox()
        Me.DGVSumaE = New System.Windows.Forms.DataGridView()
        Me.DGVDatoE = New System.Windows.Forms.DataGridView()
        Me.TimeReal = New System.Windows.Forms.Timer(Me.components)
        Me.PanIngre.SuspendLayout()
        Me.PanRazoI.SuspendLayout()
        Me.PanEgres.SuspendLayout()
        Me.PanRazoE.SuspendLayout()
        Me.PanLimpT.SuspendLayout()
        Me.TStBaS.SuspendLayout()
        Me.TaCIngre.SuspendLayout()
        Me.TaPIngre.SuspendLayout()
        CType(Me.DGVSumaI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDatoI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaCEgres.SuspendLayout()
        Me.TaPEgres.SuspendLayout()
        CType(Me.DGVSumaE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDatoE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanIngre
        '
        Me.PanIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanIngre.Controls.Add(Me.ButRemoI)
        Me.PanIngre.Controls.Add(Me.ChBHoraI)
        Me.PanIngre.Controls.Add(Me.ChBFechI)
        Me.PanIngre.Controls.Add(Me.ButAgreI)
        Me.PanIngre.Controls.Add(Me.DTPHoraI)
        Me.PanIngre.Controls.Add(Me.DTPFechI)
        Me.PanIngre.Controls.Add(Me.PanRazoI)
        Me.PanIngre.Controls.Add(Me.LabRazoI)
        Me.PanIngre.Controls.Add(Me.TxBCantI)
        Me.PanIngre.Controls.Add(Me.LabCantI)
        Me.PanIngre.Location = New System.Drawing.Point(12, 42)
        Me.PanIngre.Name = "PanIngre"
        Me.PanIngre.Size = New System.Drawing.Size(375, 260)
        Me.PanIngre.TabIndex = 1
        '
        'ButRemoI
        '
        Me.ButRemoI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButRemoI.Location = New System.Drawing.Point(237, 225)
        Me.ButRemoI.Name = "ButRemoI"
        Me.ButRemoI.Size = New System.Drawing.Size(100, 30)
        Me.ButRemoI.TabIndex = 9
        Me.ButRemoI.Text = "Remover"
        Me.ButRemoI.UseVisualStyleBackColor = True
        '
        'ChBHoraI
        '
        Me.ChBHoraI.AutoSize = True
        Me.ChBHoraI.Location = New System.Drawing.Point(14, 182)
        Me.ChBHoraI.Name = "ChBHoraI"
        Me.ChBHoraI.Size = New System.Drawing.Size(63, 23)
        Me.ChBHoraI.TabIndex = 6
        Me.ChBHoraI.Text = "Hora"
        Me.ChBHoraI.UseVisualStyleBackColor = True
        '
        'ChBFechI
        '
        Me.ChBFechI.AutoSize = True
        Me.ChBFechI.Location = New System.Drawing.Point(14, 150)
        Me.ChBFechI.Name = "ChBFechI"
        Me.ChBFechI.Size = New System.Drawing.Size(68, 23)
        Me.ChBFechI.TabIndex = 4
        Me.ChBFechI.Text = "Fecha"
        Me.ChBFechI.UseVisualStyleBackColor = True
        '
        'ButAgreI
        '
        Me.ButAgreI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButAgreI.Location = New System.Drawing.Point(14, 225)
        Me.ButAgreI.Name = "ButAgreI"
        Me.ButAgreI.Size = New System.Drawing.Size(100, 30)
        Me.ButAgreI.TabIndex = 8
        Me.ButAgreI.Text = "Agregar"
        Me.ButAgreI.UseVisualStyleBackColor = True
        '
        'DTPHoraI
        '
        Me.DTPHoraI.Location = New System.Drawing.Point(88, 179)
        Me.DTPHoraI.Name = "DTPHoraI"
        Me.DTPHoraI.Size = New System.Drawing.Size(150, 26)
        Me.DTPHoraI.TabIndex = 7
        '
        'DTPFechI
        '
        Me.DTPFechI.Location = New System.Drawing.Point(88, 147)
        Me.DTPFechI.Name = "DTPFechI"
        Me.DTPFechI.Size = New System.Drawing.Size(150, 26)
        Me.DTPFechI.TabIndex = 5
        '
        'PanRazoI
        '
        Me.PanRazoI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanRazoI.Controls.Add(Me.RTBRazoI)
        Me.PanRazoI.Location = New System.Drawing.Point(88, 41)
        Me.PanRazoI.Name = "PanRazoI"
        Me.PanRazoI.Size = New System.Drawing.Size(250, 100)
        Me.PanRazoI.TabIndex = 3
        '
        'RTBRazoI
        '
        Me.RTBRazoI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBRazoI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBRazoI.Location = New System.Drawing.Point(0, 0)
        Me.RTBRazoI.Name = "RTBRazoI"
        Me.RTBRazoI.Size = New System.Drawing.Size(248, 98)
        Me.RTBRazoI.TabIndex = 0
        Me.RTBRazoI.Text = ""
        '
        'LabRazoI
        '
        Me.LabRazoI.AutoSize = True
        Me.LabRazoI.Location = New System.Drawing.Point(10, 49)
        Me.LabRazoI.Name = "LabRazoI"
        Me.LabRazoI.Size = New System.Drawing.Size(52, 19)
        Me.LabRazoI.TabIndex = 2
        Me.LabRazoI.Text = "Razón"
        '
        'TxBCantI
        '
        Me.TxBCantI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxBCantI.Location = New System.Drawing.Point(88, 9)
        Me.TxBCantI.Name = "TxBCantI"
        Me.TxBCantI.Size = New System.Drawing.Size(150, 26)
        Me.TxBCantI.TabIndex = 1
        '
        'LabCantI
        '
        Me.LabCantI.AutoSize = True
        Me.LabCantI.Location = New System.Drawing.Point(10, 17)
        Me.LabCantI.Name = "LabCantI"
        Me.LabCantI.Size = New System.Drawing.Size(70, 19)
        Me.LabCantI.TabIndex = 0
        Me.LabCantI.Text = "Cantidad"
        '
        'LabEgres
        '
        Me.LabEgres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabEgres.Location = New System.Drawing.Point(393, 9)
        Me.LabEgres.Name = "LabEgres"
        Me.LabEgres.Size = New System.Drawing.Size(375, 30)
        Me.LabEgres.TabIndex = 2
        Me.LabEgres.Text = "Egresos"
        Me.LabEgres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabIngre
        '
        Me.LabIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabIngre.Location = New System.Drawing.Point(12, 9)
        Me.LabIngre.Name = "LabIngre"
        Me.LabIngre.Size = New System.Drawing.Size(375, 30)
        Me.LabIngre.TabIndex = 0
        Me.LabIngre.Text = "Ingresos"
        Me.LabIngre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanEgres
        '
        Me.PanEgres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanEgres.Controls.Add(Me.ButRemoE)
        Me.PanEgres.Controls.Add(Me.ChBHoraE)
        Me.PanEgres.Controls.Add(Me.ChBFechE)
        Me.PanEgres.Controls.Add(Me.ButAgreE)
        Me.PanEgres.Controls.Add(Me.DTPHoraE)
        Me.PanEgres.Controls.Add(Me.DTPFechE)
        Me.PanEgres.Controls.Add(Me.PanRazoE)
        Me.PanEgres.Controls.Add(Me.LabRazoE)
        Me.PanEgres.Controls.Add(Me.TxBCantE)
        Me.PanEgres.Controls.Add(Me.LabCantE)
        Me.PanEgres.Location = New System.Drawing.Point(393, 42)
        Me.PanEgres.Name = "PanEgres"
        Me.PanEgres.Size = New System.Drawing.Size(375, 260)
        Me.PanEgres.TabIndex = 3
        '
        'ButRemoE
        '
        Me.ButRemoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButRemoE.Location = New System.Drawing.Point(238, 225)
        Me.ButRemoE.Name = "ButRemoE"
        Me.ButRemoE.Size = New System.Drawing.Size(100, 30)
        Me.ButRemoE.TabIndex = 9
        Me.ButRemoE.Text = "Remover"
        Me.ButRemoE.UseVisualStyleBackColor = True
        '
        'ChBHoraE
        '
        Me.ChBHoraE.AutoSize = True
        Me.ChBHoraE.Location = New System.Drawing.Point(14, 182)
        Me.ChBHoraE.Name = "ChBHoraE"
        Me.ChBHoraE.Size = New System.Drawing.Size(63, 23)
        Me.ChBHoraE.TabIndex = 6
        Me.ChBHoraE.Text = "Hora"
        Me.ChBHoraE.UseVisualStyleBackColor = True
        '
        'ChBFechE
        '
        Me.ChBFechE.AutoSize = True
        Me.ChBFechE.Location = New System.Drawing.Point(14, 150)
        Me.ChBFechE.Name = "ChBFechE"
        Me.ChBFechE.Size = New System.Drawing.Size(68, 23)
        Me.ChBFechE.TabIndex = 4
        Me.ChBFechE.Text = "Fecha"
        Me.ChBFechE.UseVisualStyleBackColor = True
        '
        'ButAgreE
        '
        Me.ButAgreE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButAgreE.Location = New System.Drawing.Point(14, 225)
        Me.ButAgreE.Name = "ButAgreE"
        Me.ButAgreE.Size = New System.Drawing.Size(100, 30)
        Me.ButAgreE.TabIndex = 8
        Me.ButAgreE.Text = "Agregar"
        Me.ButAgreE.UseVisualStyleBackColor = True
        '
        'DTPHoraE
        '
        Me.DTPHoraE.Location = New System.Drawing.Point(88, 179)
        Me.DTPHoraE.Name = "DTPHoraE"
        Me.DTPHoraE.Size = New System.Drawing.Size(150, 26)
        Me.DTPHoraE.TabIndex = 7
        '
        'DTPFechE
        '
        Me.DTPFechE.Location = New System.Drawing.Point(88, 147)
        Me.DTPFechE.Name = "DTPFechE"
        Me.DTPFechE.Size = New System.Drawing.Size(150, 26)
        Me.DTPFechE.TabIndex = 5
        '
        'PanRazoE
        '
        Me.PanRazoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanRazoE.Controls.Add(Me.RTBRazoE)
        Me.PanRazoE.Location = New System.Drawing.Point(88, 41)
        Me.PanRazoE.Name = "PanRazoE"
        Me.PanRazoE.Size = New System.Drawing.Size(250, 100)
        Me.PanRazoE.TabIndex = 3
        '
        'RTBRazoE
        '
        Me.RTBRazoE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBRazoE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBRazoE.Location = New System.Drawing.Point(0, 0)
        Me.RTBRazoE.Name = "RTBRazoE"
        Me.RTBRazoE.Size = New System.Drawing.Size(248, 98)
        Me.RTBRazoE.TabIndex = 0
        Me.RTBRazoE.Text = ""
        '
        'LabRazoE
        '
        Me.LabRazoE.AutoSize = True
        Me.LabRazoE.Location = New System.Drawing.Point(10, 49)
        Me.LabRazoE.Name = "LabRazoE"
        Me.LabRazoE.Size = New System.Drawing.Size(52, 19)
        Me.LabRazoE.TabIndex = 2
        Me.LabRazoE.Text = "Razón"
        '
        'TxBCantE
        '
        Me.TxBCantE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxBCantE.Location = New System.Drawing.Point(88, 9)
        Me.TxBCantE.Name = "TxBCantE"
        Me.TxBCantE.Size = New System.Drawing.Size(150, 26)
        Me.TxBCantE.TabIndex = 1
        '
        'LabCantE
        '
        Me.LabCantE.AutoSize = True
        Me.LabCantE.Location = New System.Drawing.Point(10, 17)
        Me.LabCantE.Name = "LabCantE"
        Me.LabCantE.Size = New System.Drawing.Size(70, 19)
        Me.LabCantE.TabIndex = 0
        Me.LabCantE.Text = "Cantidad"
        '
        'PanLimpT
        '
        Me.PanLimpT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanLimpT.Controls.Add(Me.ButLimpT)
        Me.PanLimpT.Location = New System.Drawing.Point(12, 308)
        Me.PanLimpT.Name = "PanLimpT"
        Me.PanLimpT.Size = New System.Drawing.Size(756, 52)
        Me.PanLimpT.TabIndex = 4
        '
        'ButLimpT
        '
        Me.ButLimpT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButLimpT.Location = New System.Drawing.Point(619, 10)
        Me.ButLimpT.Name = "ButLimpT"
        Me.ButLimpT.Size = New System.Drawing.Size(100, 30)
        Me.ButLimpT.TabIndex = 9
        Me.ButLimpT.Text = "Limpiar"
        Me.ButLimpT.UseVisualStyleBackColor = True
        '
        'TStBaS
        '
        Me.TStBaS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TStBaS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStBaS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabTotl, Me.TSBSSep1, Me.ButVacio, Me.TSBSSep2})
        Me.TStBaS.Location = New System.Drawing.Point(0, 652)
        Me.TStBaS.Name = "TStBaS"
        Me.TStBaS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TStBaS.Size = New System.Drawing.Size(780, 25)
        Me.TStBaS.TabIndex = 7
        Me.TStBaS.Text = "ToolStrip1"
        '
        'LabTotl
        '
        Me.LabTotl.Name = "LabTotl"
        Me.LabTotl.Size = New System.Drawing.Size(32, 22)
        Me.LabTotl.Text = "Total"
        '
        'TSBSSep1
        '
        Me.TSBSSep1.Name = "TSBSSep1"
        Me.TSBSSep1.Size = New System.Drawing.Size(6, 25)
        '
        'ButVacio
        '
        Me.ButVacio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButVacio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButVacio.Image = CType(resources.GetObject("ButVacio.Image"), System.Drawing.Image)
        Me.ButVacio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButVacio.Name = "ButVacio"
        Me.ButVacio.Size = New System.Drawing.Size(70, 22)
        Me.ButVacio.Text = "Vaciar todo"
        '
        'TSBSSep2
        '
        Me.TSBSSep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSBSSep2.Name = "TSBSSep2"
        Me.TSBSSep2.Size = New System.Drawing.Size(6, 25)
        '
        'TaCIngre
        '
        Me.TaCIngre.Controls.Add(Me.TaPIngre)
        Me.TaCIngre.Location = New System.Drawing.Point(12, 366)
        Me.TaCIngre.Name = "TaCIngre"
        Me.TaCIngre.SelectedIndex = 0
        Me.TaCIngre.Size = New System.Drawing.Size(375, 283)
        Me.TaCIngre.TabIndex = 5
        '
        'TaPIngre
        '
        Me.TaPIngre.Controls.Add(Me.DGVDatoI)
        Me.TaPIngre.Controls.Add(Me.TxBSumaI)
        Me.TaPIngre.Controls.Add(Me.TxBIdenI)
        Me.TaPIngre.Controls.Add(Me.DGVSumaI)
        Me.TaPIngre.Location = New System.Drawing.Point(4, 28)
        Me.TaPIngre.Name = "TaPIngre"
        Me.TaPIngre.Padding = New System.Windows.Forms.Padding(3)
        Me.TaPIngre.Size = New System.Drawing.Size(367, 251)
        Me.TaPIngre.TabIndex = 0
        Me.TaPIngre.Text = "Ingresos"
        Me.TaPIngre.UseVisualStyleBackColor = True
        '
        'TxBSumaI
        '
        Me.TxBSumaI.Location = New System.Drawing.Point(241, 132)
        Me.TxBSumaI.Name = "TxBSumaI"
        Me.TxBSumaI.Size = New System.Drawing.Size(100, 26)
        Me.TxBSumaI.TabIndex = 3
        '
        'TxBIdenI
        '
        Me.TxBIdenI.Location = New System.Drawing.Point(241, 100)
        Me.TxBIdenI.Name = "TxBIdenI"
        Me.TxBIdenI.Size = New System.Drawing.Size(100, 26)
        Me.TxBIdenI.TabIndex = 2
        '
        'DGVSumaI
        '
        Me.DGVSumaI.AllowUserToAddRows = False
        Me.DGVSumaI.AllowUserToDeleteRows = False
        Me.DGVSumaI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSumaI.Location = New System.Drawing.Point(85, 100)
        Me.DGVSumaI.Name = "DGVSumaI"
        Me.DGVSumaI.ReadOnly = True
        Me.DGVSumaI.Size = New System.Drawing.Size(150, 58)
        Me.DGVSumaI.TabIndex = 1
        '
        'DGVDatoI
        '
        Me.DGVDatoI.AllowUserToAddRows = False
        Me.DGVDatoI.AllowUserToDeleteRows = False
        Me.DGVDatoI.AllowUserToOrderColumns = True
        Me.DGVDatoI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatoI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDatoI.Location = New System.Drawing.Point(3, 3)
        Me.DGVDatoI.Name = "DGVDatoI"
        Me.DGVDatoI.ReadOnly = True
        Me.DGVDatoI.Size = New System.Drawing.Size(361, 245)
        Me.DGVDatoI.TabIndex = 0
        '
        'TaCEgres
        '
        Me.TaCEgres.Controls.Add(Me.TaPEgres)
        Me.TaCEgres.Location = New System.Drawing.Point(393, 366)
        Me.TaCEgres.Name = "TaCEgres"
        Me.TaCEgres.SelectedIndex = 0
        Me.TaCEgres.Size = New System.Drawing.Size(375, 283)
        Me.TaCEgres.TabIndex = 6
        '
        'TaPEgres
        '
        Me.TaPEgres.Controls.Add(Me.DGVDatoE)
        Me.TaPEgres.Controls.Add(Me.TxBSumaE)
        Me.TaPEgres.Controls.Add(Me.TxBIdenE)
        Me.TaPEgres.Controls.Add(Me.DGVSumaE)
        Me.TaPEgres.Location = New System.Drawing.Point(4, 28)
        Me.TaPEgres.Name = "TaPEgres"
        Me.TaPEgres.Padding = New System.Windows.Forms.Padding(3)
        Me.TaPEgres.Size = New System.Drawing.Size(367, 251)
        Me.TaPEgres.TabIndex = 0
        Me.TaPEgres.Text = "Egresos"
        Me.TaPEgres.UseVisualStyleBackColor = True
        '
        'TxBSumaE
        '
        Me.TxBSumaE.Location = New System.Drawing.Point(241, 132)
        Me.TxBSumaE.Name = "TxBSumaE"
        Me.TxBSumaE.Size = New System.Drawing.Size(100, 26)
        Me.TxBSumaE.TabIndex = 3
        '
        'TxBIdenE
        '
        Me.TxBIdenE.Location = New System.Drawing.Point(241, 100)
        Me.TxBIdenE.Name = "TxBIdenE"
        Me.TxBIdenE.Size = New System.Drawing.Size(100, 26)
        Me.TxBIdenE.TabIndex = 2
        '
        'DGVSumaE
        '
        Me.DGVSumaE.AllowUserToAddRows = False
        Me.DGVSumaE.AllowUserToDeleteRows = False
        Me.DGVSumaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSumaE.Location = New System.Drawing.Point(85, 100)
        Me.DGVSumaE.Name = "DGVSumaE"
        Me.DGVSumaE.ReadOnly = True
        Me.DGVSumaE.Size = New System.Drawing.Size(150, 58)
        Me.DGVSumaE.TabIndex = 1
        '
        'DGVDatoE
        '
        Me.DGVDatoE.AllowUserToAddRows = False
        Me.DGVDatoE.AllowUserToDeleteRows = False
        Me.DGVDatoE.AllowUserToOrderColumns = True
        Me.DGVDatoE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatoE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDatoE.Location = New System.Drawing.Point(3, 3)
        Me.DGVDatoE.Name = "DGVDatoE"
        Me.DGVDatoE.ReadOnly = True
        Me.DGVDatoE.Size = New System.Drawing.Size(361, 245)
        Me.DGVDatoE.TabIndex = 0
        '
        'TimeReal
        '
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 677)
        Me.Controls.Add(Me.TaCEgres)
        Me.Controls.Add(Me.TaCIngre)
        Me.Controls.Add(Me.TStBaS)
        Me.Controls.Add(Me.PanLimpT)
        Me.Controls.Add(Me.PanEgres)
        Me.Controls.Add(Me.LabEgres)
        Me.Controls.Add(Me.PanIngre)
        Me.Controls.Add(Me.LabIngre)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PanIngre.ResumeLayout(False)
        Me.PanIngre.PerformLayout()
        Me.PanRazoI.ResumeLayout(False)
        Me.PanEgres.ResumeLayout(False)
        Me.PanEgres.PerformLayout()
        Me.PanRazoE.ResumeLayout(False)
        Me.PanLimpT.ResumeLayout(False)
        Me.TStBaS.ResumeLayout(False)
        Me.TStBaS.PerformLayout()
        Me.TaCIngre.ResumeLayout(False)
        Me.TaPIngre.ResumeLayout(False)
        Me.TaPIngre.PerformLayout()
        CType(Me.DGVSumaI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDatoI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaCEgres.ResumeLayout(False)
        Me.TaPEgres.ResumeLayout(False)
        Me.TaPEgres.PerformLayout()
        CType(Me.DGVSumaE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDatoE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanIngre As Panel
    Friend WithEvents LabEgres As Label
    Friend WithEvents LabIngre As Label
    Friend WithEvents TxBCantI As TextBox
    Friend WithEvents LabCantI As Label
    Friend WithEvents RTBRazoI As RichTextBox
    Friend WithEvents LabRazoI As Label
    Friend WithEvents PanRazoI As Panel
    Friend WithEvents DTPHoraI As DateTimePicker
    Friend WithEvents DTPFechI As DateTimePicker
    Friend WithEvents ButAgreI As Button
    Friend WithEvents ButRemoI As Button
    Friend WithEvents ChBHoraI As CheckBox
    Friend WithEvents ChBFechI As CheckBox
    Friend WithEvents PanEgres As Panel
    Friend WithEvents ButRemoE As Button
    Friend WithEvents ChBHoraE As CheckBox
    Friend WithEvents ChBFechE As CheckBox
    Friend WithEvents ButAgreE As Button
    Friend WithEvents DTPHoraE As DateTimePicker
    Friend WithEvents DTPFechE As DateTimePicker
    Friend WithEvents PanRazoE As Panel
    Friend WithEvents RTBRazoE As RichTextBox
    Friend WithEvents LabRazoE As Label
    Friend WithEvents TxBCantE As TextBox
    Friend WithEvents LabCantE As Label
    Friend WithEvents PanLimpT As Panel
    Friend WithEvents ButLimpT As Button
    Friend WithEvents TStBaS As ToolStrip
    Friend WithEvents LabTotl As ToolStripLabel
    Friend WithEvents TSBSSep1 As ToolStripSeparator
    Friend WithEvents ButVacio As ToolStripButton
    Friend WithEvents TSBSSep2 As ToolStripSeparator
    Friend WithEvents TaCIngre As TabControl
    Friend WithEvents TaPIngre As TabPage
    Friend WithEvents TaCEgres As TabControl
    Friend WithEvents TaPEgres As TabPage
    Friend WithEvents DGVDatoI As DataGridView
    Friend WithEvents DGVDatoE As DataGridView
    Friend WithEvents DGVSumaI As DataGridView
    Friend WithEvents DGVSumaE As DataGridView
    Friend WithEvents TxBSumaI As TextBox
    Friend WithEvents TxBIdenI As TextBox
    Friend WithEvents TxBSumaE As TextBox
    Friend WithEvents TxBIdenE As TextBox
    Friend WithEvents TimeReal As Timer
End Class
