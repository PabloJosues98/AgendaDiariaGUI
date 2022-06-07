<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarTarea
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
        Me.cmdIngresarTarea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblprioridad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.cboPrioridad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbSi = New System.Windows.Forms.RadioButton()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtMinuto = New System.Windows.Forms.TextBox()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblMinuto = New System.Windows.Forms.Label()
        Me.lblTipoPersonalizado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdIngresarTarea
        '
        Me.cmdIngresarTarea.Location = New System.Drawing.Point(195, 429)
        Me.cmdIngresarTarea.Name = "cmdIngresarTarea"
        Me.cmdIngresarTarea.Size = New System.Drawing.Size(75, 23)
        Me.cmdIngresarTarea.TabIndex = 8
        Me.cmdIngresarTarea.Text = "Añadir"
        Me.cmdIngresarTarea.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(187, 167)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(121, 83)
        Me.txtDescripcion.TabIndex = 2
        '
        'lblprioridad
        '
        Me.lblprioridad.AutoSize = True
        Me.lblprioridad.Location = New System.Drawing.Point(67, 272)
        Me.lblprioridad.Name = "lblprioridad"
        Me.lblprioridad.Size = New System.Drawing.Size(55, 15)
        Me.lblprioridad.TabIndex = 12
        Me.lblprioridad.Text = "Prioridad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hora Limite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Crear Tarea"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Tarea", "Proyecto", "Pasa Tiempo", "Personalizado"})
        Me.cboTipo.Location = New System.Drawing.Point(187, 73)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 23)
        Me.cboTipo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 12
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(187, 119)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(121, 23)
        Me.txtTipo.TabIndex = 1
        Me.txtTipo.Visible = False
        '
        'cboPrioridad
        '
        Me.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"Ninguna", "Alta", "Alta/Media", "Media", "Media/Baja", "Baja"})
        Me.cboPrioridad.Location = New System.Drawing.Point(187, 272)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(121, 23)
        Me.cboPrioridad.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbNo)
        Me.GroupBox1.Controls.Add(Me.rdbSi)
        Me.GroupBox1.Location = New System.Drawing.Point(187, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 43)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(59, 18)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(41, 19)
        Me.rdbNo.TabIndex = 5
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbSi
        '
        Me.rdbSi.AutoSize = True
        Me.rdbSi.Location = New System.Drawing.Point(6, 18)
        Me.rdbSi.Name = "rdbSi"
        Me.rdbSi.Size = New System.Drawing.Size(34, 19)
        Me.rdbSi.TabIndex = 4
        Me.rdbSi.TabStop = True
        Me.rdbSi.Text = "Si"
        Me.rdbSi.UseVisualStyleBackColor = True
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(187, 381)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(40, 23)
        Me.txtHora.TabIndex = 6
        Me.txtHora.Visible = False
        '
        'txtMinuto
        '
        Me.txtMinuto.Location = New System.Drawing.Point(255, 381)
        Me.txtMinuto.Name = "txtMinuto"
        Me.txtMinuto.Size = New System.Drawing.Size(40, 23)
        Me.txtMinuto.TabIndex = 7
        Me.txtMinuto.Visible = False
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPuntos.Location = New System.Drawing.Point(233, 376)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(16, 28)
        Me.lblPuntos.TabIndex = 17
        Me.lblPuntos.Text = ":"
        Me.lblPuntos.Visible = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.Location = New System.Drawing.Point(188, 359)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 19)
        Me.lblHora.TabIndex = 18
        Me.lblHora.Text = "Hora"
        Me.lblHora.Visible = False
        '
        'lblMinuto
        '
        Me.lblMinuto.AutoSize = True
        Me.lblMinuto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMinuto.Location = New System.Drawing.Point(247, 360)
        Me.lblMinuto.Name = "lblMinuto"
        Me.lblMinuto.Size = New System.Drawing.Size(54, 19)
        Me.lblMinuto.TabIndex = 19
        Me.lblMinuto.Text = "Minuto"
        Me.lblMinuto.Visible = False
        '
        'lblTipoPersonalizado
        '
        Me.lblTipoPersonalizado.AutoSize = True
        Me.lblTipoPersonalizado.Location = New System.Drawing.Point(67, 122)
        Me.lblTipoPersonalizado.Name = "lblTipoPersonalizado"
        Me.lblTipoPersonalizado.Size = New System.Drawing.Size(106, 15)
        Me.lblTipoPersonalizado.TabIndex = 20
        Me.lblTipoPersonalizado.Text = "Tipo personalizado"
        Me.lblTipoPersonalizado.Visible = False
        '
        'IngresarTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 517)
        Me.Controls.Add(Me.lblTipoPersonalizado)
        Me.Controls.Add(Me.lblMinuto)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.txtMinuto)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboPrioridad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblprioridad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdIngresarTarea)
        Me.Name = "IngresarTarea"
        Me.Text = "Ingresar Tarea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdIngresarTarea As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblprioridad As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents cboPrioridad As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbSi As RadioButton
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtMinuto As TextBox
    Friend WithEvents lblPuntos As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblMinuto As Label
    Friend WithEvents lblTipoPersonalizado As Label
End Class
