<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacts
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
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

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contacts))
      Dim AddressIDLabel As System.Windows.Forms.Label
      Dim EmailLabel As System.Windows.Forms.Label
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Dim PhoneNumberLabel As System.Windows.Forms.Label
      Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.AddressBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.AddressBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.AddressIDTextBox = New System.Windows.Forms.TextBox()
      Me.EmailTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
      Me.browseAllButton = New System.Windows.Forms.Button()
      Me.findGroupBox = New System.Windows.Forms.GroupBox()
      Me.findButton = New System.Windows.Forms.Button()
      Me.findLabel = New System.Windows.Forms.Label()
      Me.findTextBox = New System.Windows.Forms.TextBox()
      AddressIDLabel = New System.Windows.Forms.Label()
      EmailLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      PhoneNumberLabel = New System.Windows.Forms.Label()
      CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.AddressBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.AddressBindingNavigator.SuspendLayout()
      Me.findGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      'AddressBindingSource
      '
      Me.AddressBindingSource.DataSource = GetType(AddressExample.Address)
      '
      'AddressBindingNavigator
      '
      Me.AddressBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.AddressBindingNavigator.BindingSource = Me.AddressBindingSource
      Me.AddressBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.AddressBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.AddressBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AddressBindingNavigatorSaveItem})
      Me.AddressBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.AddressBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.AddressBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.AddressBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.AddressBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.AddressBindingNavigator.Name = "AddressBindingNavigator"
      Me.AddressBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.AddressBindingNavigator.Size = New System.Drawing.Size(295, 25)
      Me.AddressBindingNavigator.TabIndex = 0
      Me.AddressBindingNavigator.Text = "BindingNavigator1"
      '
      'BindingNavigatorMoveFirstItem
      '
      Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
      Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveFirstItem.Text = "Move first"
      '
      'BindingNavigatorMovePreviousItem
      '
      Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
      Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
      '
      'BindingNavigatorSeparator
      '
      Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorPositionItem
      '
      Me.BindingNavigatorPositionItem.AccessibleName = "Position"
      Me.BindingNavigatorPositionItem.AutoSize = False
      Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
      Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
      Me.BindingNavigatorPositionItem.Text = "0"
      Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveNextItem.Text = "Move next"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveLastItem.Text = "Move last"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorAddNewItem
      '
      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Add new"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
      '
      'AddressBindingNavigatorSaveItem
      '
      Me.AddressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.AddressBindingNavigatorSaveItem.Image = CType(resources.GetObject("AddressBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.AddressBindingNavigatorSaveItem.Name = "AddressBindingNavigatorSaveItem"
      Me.AddressBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.AddressBindingNavigatorSaveItem.Text = "Save Data"
      '
      'AddressIDLabel
      '
      AddressIDLabel.AutoSize = True
      AddressIDLabel.Location = New System.Drawing.Point(12, 39)
      AddressIDLabel.Name = "AddressIDLabel"
      AddressIDLabel.Size = New System.Drawing.Size(66, 15)
      AddressIDLabel.TabIndex = 0
      AddressIDLabel.Text = "Address ID:"
      '
      'AddressIDTextBox
      '
      Me.AddressIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "AddressID", True))
      Me.AddressIDTextBox.Location = New System.Drawing.Point(109, 36)
      Me.AddressIDTextBox.Name = "AddressIDTextBox"
      Me.AddressIDTextBox.ReadOnly = True
      Me.AddressIDTextBox.Size = New System.Drawing.Size(174, 23)
      Me.AddressIDTextBox.TabIndex = 1
      '
      'EmailLabel
      '
      EmailLabel.AutoSize = True
      EmailLabel.Location = New System.Drawing.Point(12, 126)
      EmailLabel.Name = "EmailLabel"
      EmailLabel.Size = New System.Drawing.Size(39, 15)
      EmailLabel.TabIndex = 6
      EmailLabel.Text = "Email:"
      '
      'EmailTextBox
      '
      Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "Email", True))
      Me.EmailTextBox.Location = New System.Drawing.Point(109, 123)
      Me.EmailTextBox.Name = "EmailTextBox"
      Me.EmailTextBox.Size = New System.Drawing.Size(174, 23)
      Me.EmailTextBox.TabIndex = 7
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(12, 68)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(67, 15)
      FirstNameLabel.TabIndex = 2
      FirstNameLabel.Text = "First Name:"
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(109, 65)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(174, 23)
      Me.FirstNameTextBox.TabIndex = 3
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(12, 97)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(66, 15)
      LastNameLabel.TabIndex = 4
      LastNameLabel.Text = "Last Name:"
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(109, 94)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(174, 23)
      Me.LastNameTextBox.TabIndex = 5
      '
      'PhoneNumberLabel
      '
      PhoneNumberLabel.AutoSize = True
      PhoneNumberLabel.Location = New System.Drawing.Point(12, 155)
      PhoneNumberLabel.Name = "PhoneNumberLabel"
      PhoneNumberLabel.Size = New System.Drawing.Size(91, 15)
      PhoneNumberLabel.TabIndex = 8
      PhoneNumberLabel.Text = "Phone Number:"
      '
      'PhoneNumberTextBox
      '
      Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "PhoneNumber", True))
      Me.PhoneNumberTextBox.Location = New System.Drawing.Point(109, 152)
      Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
      Me.PhoneNumberTextBox.Size = New System.Drawing.Size(174, 23)
      Me.PhoneNumberTextBox.TabIndex = 9
      '
      'browseAllButton
      '
      Me.browseAllButton.Location = New System.Drawing.Point(89, 248)
      Me.browseAllButton.Name = "browseAllButton"
      Me.browseAllButton.Size = New System.Drawing.Size(114, 23)
      Me.browseAllButton.TabIndex = 11
      Me.browseAllButton.Text = "Browse All Entries"
      Me.browseAllButton.UseVisualStyleBackColor = True
      '
      'findGroupBox
      '
      Me.findGroupBox.Controls.Add(Me.findButton)
      Me.findGroupBox.Controls.Add(Me.findLabel)
      Me.findGroupBox.Controls.Add(Me.findTextBox)
      Me.findGroupBox.Location = New System.Drawing.Point(11, 191)
      Me.findGroupBox.Name = "findGroupBox"
      Me.findGroupBox.Size = New System.Drawing.Size(272, 51)
      Me.findGroupBox.TabIndex = 10
      Me.findGroupBox.TabStop = False
      Me.findGroupBox.Text = "Find an entry by last name"
      '
      'findButton
      '
      Me.findButton.Location = New System.Drawing.Point(188, 19)
      Me.findButton.Name = "findButton"
      Me.findButton.Size = New System.Drawing.Size(75, 23)
      Me.findButton.TabIndex = 2
      Me.findButton.Text = "Find"
      Me.findButton.UseVisualStyleBackColor = True
      '
      'findLabel
      '
      Me.findLabel.AutoSize = True
      Me.findLabel.Location = New System.Drawing.Point(6, 22)
      Me.findLabel.Name = "findLabel"
      Me.findLabel.Size = New System.Drawing.Size(66, 15)
      Me.findLabel.TabIndex = 0
      Me.findLabel.Text = "Last Name:"
      '
      'findTextBox
      '
      Me.findTextBox.Location = New System.Drawing.Point(78, 19)
      Me.findTextBox.Name = "findTextBox"
      Me.findTextBox.Size = New System.Drawing.Size(104, 23)
      Me.findTextBox.TabIndex = 1
      '
      'Contacts
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(295, 283)
      Me.Controls.Add(Me.browseAllButton)
      Me.Controls.Add(Me.findGroupBox)
      Me.Controls.Add(AddressIDLabel)
      Me.Controls.Add(Me.AddressIDTextBox)
      Me.Controls.Add(EmailLabel)
      Me.Controls.Add(Me.EmailTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(PhoneNumberLabel)
      Me.Controls.Add(Me.PhoneNumberTextBox)
      Me.Controls.Add(Me.AddressBindingNavigator)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Contacts"
      Me.Text = "Address Book"
      CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.AddressBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.AddressBindingNavigator.ResumeLayout(False)
      Me.AddressBindingNavigator.PerformLayout()
      Me.findGroupBox.ResumeLayout(False)
      Me.findGroupBox.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents AddressBindingNavigator As System.Windows.Forms.BindingNavigator
   Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
   Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents AddressBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents AddressIDTextBox As System.Windows.Forms.TextBox
   Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents browseAllButton As System.Windows.Forms.Button
   Friend WithEvents findGroupBox As System.Windows.Forms.GroupBox
   Friend WithEvents findButton As System.Windows.Forms.Button
   Friend WithEvents findLabel As System.Windows.Forms.Label
   Friend WithEvents findTextBox As System.Windows.Forms.TextBox

End Class
