<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitleQueries
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TitleQueries))
      Me.TitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TitleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.TitleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.TitleDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.queriesComboBox = New System.Windows.Forms.ComboBox()
      CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TitleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TitleBindingNavigator.SuspendLayout()
      CType(Me.TitleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TitleBindingSource
      '
      Me.TitleBindingSource.DataSource = GetType(BooksExamples.Title)
      '
      'TitleBindingNavigator
      '
      Me.TitleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.TitleBindingNavigator.BindingSource = Me.TitleBindingSource
      Me.TitleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.TitleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.TitleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TitleBindingNavigatorSaveItem})
      Me.TitleBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.TitleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.TitleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.TitleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.TitleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.TitleBindingNavigator.Name = "TitleBindingNavigator"
      Me.TitleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.TitleBindingNavigator.Size = New System.Drawing.Size(496, 25)
      Me.TitleBindingNavigator.TabIndex = 0
      Me.TitleBindingNavigator.Text = "BindingNavigator1"
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
      Me.BindingNavigatorAddNewItem.Enabled = False
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Add new"
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
      'TitleBindingNavigatorSaveItem
      '
      Me.TitleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.TitleBindingNavigatorSaveItem.Enabled = False
      Me.TitleBindingNavigatorSaveItem.Image = CType(resources.GetObject("TitleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.TitleBindingNavigatorSaveItem.Name = "TitleBindingNavigatorSaveItem"
      Me.TitleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.TitleBindingNavigatorSaveItem.Text = "Save Data"
      '
      'TitleDataGridView
      '
      Me.TitleDataGridView.AutoGenerateColumns = False
      Me.TitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.TitleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
      Me.TitleDataGridView.DataSource = Me.TitleBindingSource
      Me.TitleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TitleDataGridView.Location = New System.Drawing.Point(0, 25)
      Me.TitleDataGridView.Name = "TitleDataGridView"
      Me.TitleDataGridView.Size = New System.Drawing.Size(496, 260)
      Me.TitleDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "ISBN"
      Me.DataGridViewTextBoxColumn1.HeaderText = "ISBN"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title1"
      Me.DataGridViewTextBoxColumn2.HeaderText = "Title1"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "EditionNumber"
      Me.DataGridViewTextBoxColumn3.HeaderText = "EditionNumber"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "Copyright"
      Me.DataGridViewTextBoxColumn4.HeaderText = "Copyright"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      '
      'queriesComboBox
      '
      Me.queriesComboBox.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.queriesComboBox.FormattingEnabled = True
      Me.queriesComboBox.Items.AddRange(New Object() {"All titles", "Titles with 2014 copyright", "Titles ending with ""How to Program"""})
      Me.queriesComboBox.Location = New System.Drawing.Point(0, 264)
      Me.queriesComboBox.Name = "queriesComboBox"
      Me.queriesComboBox.Size = New System.Drawing.Size(496, 21)
      Me.queriesComboBox.TabIndex = 3
      '
      'TitleQueries
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(496, 285)
      Me.Controls.Add(Me.queriesComboBox)
      Me.Controls.Add(Me.TitleDataGridView)
      Me.Controls.Add(Me.TitleBindingNavigator)
      Me.Name = "TitleQueries"
      Me.Text = "Display Query Results"
      CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TitleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TitleBindingNavigator.ResumeLayout(False)
      Me.TitleBindingNavigator.PerformLayout()
      CType(Me.TitleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TitleBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TitleBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents TitleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents TitleDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents queriesComboBox As System.Windows.Forms.ComboBox

End Class
