<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboCollection = New System.Windows.Forms.ComboBox()
        Me.cboGamme = New System.Windows.Forms.ComboBox()
        Me.txtProduit = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSelectionnerUneCollection = New System.Windows.Forms.Label()
        Me.txtSelectionnerUneGamme = New System.Windows.Forms.Label()
        Me.txtNomDuProduit = New System.Windows.Forms.Label()
        Me.txtDescriptionDuProduit = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.txtPrixUnitaire = New System.Windows.Forms.Label()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboCollection
        '
        Me.cboCollection.FormattingEnabled = True
        Me.cboCollection.Location = New System.Drawing.Point(209, 12)
        Me.cboCollection.Name = "cboCollection"
        Me.cboCollection.Size = New System.Drawing.Size(121, 21)
        Me.cboCollection.TabIndex = 0
        '
        'cboGamme
        '
        Me.cboGamme.FormattingEnabled = True
        Me.cboGamme.Location = New System.Drawing.Point(209, 51)
        Me.cboGamme.Name = "cboGamme"
        Me.cboGamme.Size = New System.Drawing.Size(121, 21)
        Me.cboGamme.TabIndex = 1
        '
        'txtProduit
        '
        Me.txtProduit.Location = New System.Drawing.Point(209, 91)
        Me.txtProduit.Name = "txtProduit"
        Me.txtProduit.Size = New System.Drawing.Size(100, 20)
        Me.txtProduit.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(179, 164)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(151, 57)
        Me.txtDescription.TabIndex = 3
        '
        'txtSelectionnerUneCollection
        '
        Me.txtSelectionnerUneCollection.AutoSize = True
        Me.txtSelectionnerUneCollection.Location = New System.Drawing.Point(25, 20)
        Me.txtSelectionnerUneCollection.Name = "txtSelectionnerUneCollection"
        Me.txtSelectionnerUneCollection.Size = New System.Drawing.Size(135, 13)
        Me.txtSelectionnerUneCollection.TabIndex = 4
        Me.txtSelectionnerUneCollection.Text = "Selectionner une collection"
        '
        'txtSelectionnerUneGamme
        '
        Me.txtSelectionnerUneGamme.AutoSize = True
        Me.txtSelectionnerUneGamme.Location = New System.Drawing.Point(25, 59)
        Me.txtSelectionnerUneGamme.Name = "txtSelectionnerUneGamme"
        Me.txtSelectionnerUneGamme.Size = New System.Drawing.Size(124, 13)
        Me.txtSelectionnerUneGamme.TabIndex = 5
        Me.txtSelectionnerUneGamme.Text = "Selectionner une gamme"
        '
        'txtNomDuProduit
        '
        Me.txtNomDuProduit.AutoSize = True
        Me.txtNomDuProduit.Location = New System.Drawing.Point(25, 98)
        Me.txtNomDuProduit.Name = "txtNomDuProduit"
        Me.txtNomDuProduit.Size = New System.Drawing.Size(79, 13)
        Me.txtNomDuProduit.TabIndex = 6
        Me.txtNomDuProduit.Text = "Nom du produit"
        '
        'txtDescriptionDuProduit
        '
        Me.txtDescriptionDuProduit.AutoSize = True
        Me.txtDescriptionDuProduit.Location = New System.Drawing.Point(25, 178)
        Me.txtDescriptionDuProduit.Name = "txtDescriptionDuProduit"
        Me.txtDescriptionDuProduit.Size = New System.Drawing.Size(110, 13)
        Me.txtDescriptionDuProduit.TabIndex = 7
        Me.txtDescriptionDuProduit.Text = "Description du produit"
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(12, 238)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(69, 23)
        Me.btnAjouter.TabIndex = 8
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(113, 238)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(89, 23)
        Me.btnModifier.TabIndex = 9
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(230, 238)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(87, 23)
        Me.BtnSupprimer.TabIndex = 10
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'txtPrixUnitaire
        '
        Me.txtPrixUnitaire.AutoSize = True
        Me.txtPrixUnitaire.Location = New System.Drawing.Point(42, 136)
        Me.txtPrixUnitaire.Name = "txtPrixUnitaire"
        Me.txtPrixUnitaire.Size = New System.Drawing.Size(63, 13)
        Me.txtPrixUnitaire.TabIndex = 11
        Me.txtPrixUnitaire.Text = "Prix Unitaire"
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(209, 129)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(100, 20)
        Me.txtPrix.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 273)
        Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.txtPrixUnitaire)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.txtDescriptionDuProduit)
        Me.Controls.Add(Me.txtNomDuProduit)
        Me.Controls.Add(Me.txtSelectionnerUneGamme)
        Me.Controls.Add(Me.txtSelectionnerUneCollection)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtProduit)
        Me.Controls.Add(Me.cboGamme)
        Me.Controls.Add(Me.cboCollection)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCollection As System.Windows.Forms.ComboBox
    Friend WithEvents cboGamme As System.Windows.Forms.ComboBox
    Friend WithEvents txtProduit As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSelectionnerUneCollection As System.Windows.Forms.Label
    Friend WithEvents txtSelectionnerUneGamme As System.Windows.Forms.Label
    Friend WithEvents txtNomDuProduit As System.Windows.Forms.Label
    Friend WithEvents txtDescriptionDuProduit As System.Windows.Forms.Label
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents txtPrixUnitaire As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox

End Class
