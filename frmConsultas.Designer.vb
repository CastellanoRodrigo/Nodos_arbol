<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultas
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(16, 18)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(334, 564)
        Me.TreeView1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(396, 18)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(968, 564)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1102, 594)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(260, 56)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1379, 666)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmConsultas"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnSalir As Button
End Class
