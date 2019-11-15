<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
      Dim AuthorIDLabel As System.Windows.Forms.Label
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
      Me.AuthorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.AuthorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TitlesDataGridView = New System.Windows.Forms.DataGridView()
      Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Title1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.EditionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CopyrightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      AuthorIDLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.AuthorBindingNavigator.SuspendLayout()
      CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'AuthorIDLabel
      '
      AuthorIDLabel.AutoSize = True
      AuthorIDLabel.Location = New System.Drawing.Point(12, 37)
      AuthorIDLabel.Name = "AuthorIDLabel"
      AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
      AuthorIDLabel.TabIndex = 1
      AuthorIDLabel.Text = "Author ID:"
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(179, 37)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(60, 13)
      FirstNameLabel.TabIndex = 3
      FirstNameLabel.Text = "First Name:"
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(351, 37)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(61, 13)
      LastNameLabel.TabIndex = 5
      LastNameLabel.Text = "Last Name:"
      '
      'AuthorBindingNavigator
      '
      Me.AuthorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.AuthorBindingNavigator.BindingSource = Me.AuthorBindingSource
      Me.AuthorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.AuthorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.AuthorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuthorBindingNavigatorSaveItem})
      Me.AuthorBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.AuthorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.AuthorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.AuthorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.AuthorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.AuthorBindingNavigator.Name = "AuthorBindingNavigator"
      Me.AuthorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.AuthorBindingNavigator.Size = New System.Drawing.Size(534, 25)
      Me.AuthorBindingNavigator.TabIndex = 0
      Me.AuthorBindingNavigator.Text = "BindingNavigator1"
      '
      'BindingNavigatorAddNewItem
      '
      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorAddNewItem.Enabled = False
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Add new"
      '
      'AuthorBindingSource
      '
      Me.AuthorBindingSource.DataSource = GetType(BooksExamples.Author)
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Enabled = False
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
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
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'AuthorBindingNavigatorSaveItem
      '
      Me.AuthorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.AuthorBindingNavigatorSaveItem.Enabled = False
      Me.AuthorBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuthorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.AuthorBindingNavigatorSaveItem.Name = "AuthorBindingNavigatorSaveItem"
      Me.AuthorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.AuthorBindingNavigatorSaveItem.Text = "Save Data"
      '
      'AuthorIDTextBox
      '
      Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "AuthorID", True))
      Me.AuthorIDTextBox.Location = New System.Drawing.Point(73, 34)
      Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
      Me.AuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
      Me.AuthorIDTextBox.TabIndex = 2
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(245, 34)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.FirstNameTextBox.TabIndex = 4
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(418, 34)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.LastNameTextBox.TabIndex = 6
      '
      'TitlesBindingSource
      '
      Me.TitlesBindingSource.DataMember = "Titles"
      Me.TitlesBindingSource.DataSource = Me.AuthorBindingSource
      '
      'TitlesDataGridView
      '
      Me.TitlesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TitlesDataGridView.AutoGenerateColumns = False
      Me.TitlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.TitlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.Title1DataGridViewTextBoxColumn, Me.EditionNumberDataGridViewTextBoxColumn, Me.CopyrightDataGridViewTextBoxColumn})
      Me.TitlesDataGridView.DataSource = Me.TitlesBindingSource
      Me.TitlesDataGridView.Location = New System.Drawing.Point(15, 60)
      Me.TitlesDataGridView.Name = "TitlesDataGridView"
      Me.TitlesDataGridView.ReadOnly = True
      Me.TitlesDataGridView.Size = New System.Drawing.Size(504, 187)
      Me.TitlesDataGridView.TabIndex = 7
      '
      'ISBNDataGridViewTextBoxColumn
      '
      Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
      Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
      Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
      Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
      '
      'Title1DataGridViewTextBoxColumn
      '
      Me.Title1DataGridViewTextBoxColumn.DataPropertyName = "Title1"
      Me.Title1DataGridViewTextBoxColumn.HeaderText = "Title"
      Me.Title1DataGridViewTextBoxColumn.Name = "Title1DataGridViewTextBoxColumn"
      Me.Title1DataGridViewTextBoxColumn.ReadOnly = True
      '
      'EditionNumberDataGridViewTextBoxColumn
      '
      Me.EditionNumberDataGridViewTextBoxColumn.DataPropertyName = "EditionNumber"
      Me.EditionNumberDataGridViewTextBoxColumn.HeaderText = "EditionNumber"
      Me.EditionNumberDataGridViewTextBoxColumn.Name = "EditionNumberDataGridViewTextBoxColumn"
      Me.EditionNumberDataGridViewTextBoxColumn.ReadOnly = True
      '
      'CopyrightDataGridViewTextBoxColumn
      '
      Me.CopyrightDataGridViewTextBoxColumn.DataPropertyName = "Copyright"
      Me.CopyrightDataGridViewTextBoxColumn.HeaderText = "Copyright"
      Me.CopyrightDataGridViewTextBoxColumn.Name = "CopyrightDataGridViewTextBoxColumn"
      Me.CopyrightDataGridViewTextBoxColumn.ReadOnly = True
      '
      'Details
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(534, 262)
      Me.Controls.Add(Me.TitlesDataGridView)
      Me.Controls.Add(AuthorIDLabel)
      Me.Controls.Add(Me.AuthorIDTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(Me.AuthorBindingNavigator)
      Me.MinimumSize = New System.Drawing.Size(550, 300)
      Me.Name = "Details"
      Me.Text = "Master/Detail"
      CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.AuthorBindingNavigator.ResumeLayout(False)
      Me.AuthorBindingNavigator.PerformLayout()
      CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents AuthorBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents AuthorBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents AuthorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents AuthorIDTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents TitlesBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TitlesDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Title1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents EditionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CopyrightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
