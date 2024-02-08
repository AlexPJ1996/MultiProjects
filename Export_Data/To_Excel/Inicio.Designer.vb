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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBxTabla = New System.Windows.Forms.ComboBox()
        Me.LabTabla = New System.Windows.Forms.Label()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.ButExpor = New System.Windows.Forms.Button()
        Me.ButTabla = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButClear)
        Me.Panel1.Controls.Add(Me.ButExpor)
        Me.Panel1.Controls.Add(Me.ButTabla)
        Me.Panel1.Controls.Add(Me.CBxTabla)
        Me.Panel1.Controls.Add(Me.LabTabla)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 75)
        Me.Panel1.TabIndex = 0
        '
        'CBxTabla
        '
        Me.CBxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBxTabla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBxTabla.FormattingEnabled = True
        Me.CBxTabla.Location = New System.Drawing.Point(15, 32)
        Me.CBxTabla.Name = "CBxTabla"
        Me.CBxTabla.Size = New System.Drawing.Size(200, 29)
        Me.CBxTabla.TabIndex = 1
        '
        'LabTabla
        '
        Me.LabTabla.AutoSize = True
        Me.LabTabla.Location = New System.Drawing.Point(11, 8)
        Me.LabTabla.Name = "LabTabla"
        Me.LabTabla.Size = New System.Drawing.Size(52, 21)
        Me.LabTabla.TabIndex = 0
        Me.LabTabla.Text = "Tablas"
        '
        'DGVDatos
        '
        Me.DGVDatos.AllowUserToAddRows = False
        Me.DGVDatos.AllowUserToDeleteRows = False
        Me.DGVDatos.AllowUserToOrderColumns = True
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDatos.Location = New System.Drawing.Point(0, 75)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.ReadOnly = True
        Me.DGVDatos.Size = New System.Drawing.Size(684, 386)
        Me.DGVDatos.TabIndex = 1
        '
        'ButClear
        '
        Me.ButClear.BackgroundImage = Global.To_Excel.My.Resources.Resources.Clear
        Me.ButClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButClear.Location = New System.Drawing.Point(325, 11)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(50, 50)
        Me.ButClear.TabIndex = 4
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'ButExpor
        '
        Me.ButExpor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButExpor.BackgroundImage = Global.To_Excel.My.Resources.Resources.ToExcel
        Me.ButExpor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButExpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButExpor.Location = New System.Drawing.Point(621, 11)
        Me.ButExpor.Name = "ButExpor"
        Me.ButExpor.Size = New System.Drawing.Size(50, 50)
        Me.ButExpor.TabIndex = 5
        Me.ButExpor.UseVisualStyleBackColor = True
        '
        'ButTabla
        '
        Me.ButTabla.BackgroundImage = Global.To_Excel.My.Resources.Resources.Load
        Me.ButTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButTabla.Location = New System.Drawing.Point(221, 11)
        Me.ButTabla.Name = "ButTabla"
        Me.ButTabla.Size = New System.Drawing.Size(50, 50)
        Me.ButTabla.TabIndex = 3
        Me.ButTabla.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.DGVDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButClear As Button
    Friend WithEvents ButExpor As Button
    Friend WithEvents ButTabla As Button
    Friend WithEvents CBxTabla As ComboBox
    Friend WithEvents LabTabla As Label
    Friend WithEvents DGVDatos As DataGridView
End Class
