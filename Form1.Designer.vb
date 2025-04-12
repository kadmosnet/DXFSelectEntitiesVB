<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DxfDocument1 As DXFReaderNET.DxfDocument = New DXFReaderNET.DxfDocument()
        Dim AciColor1 As DXFReaderNET.AciColor = New DXFReaderNET.AciColor()
        Dim RasterVariables1 As DXFReaderNET.Objects.RasterVariables = New DXFReaderNET.Objects.RasterVariables()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dxfReaderNETControl1 = New DXFReaderNET.DXFReaderNETControl()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.loadDXFFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveDXFFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomExtentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutDXFReaderNETComponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectEntityWithAMouseClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectEntitiesWithRectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dxfReaderNETControl1
        '
        Me.dxfReaderNETControl1.AutoSize = True
        Me.dxfReaderNETControl1.ContinuousHighlight = False
        Me.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None
        Me.dxfReaderNETControl1.DistributionCode = ""
        DxfDocument1.ActiveLayout = "Model"
        DxfDocument1.Comments = Nothing
        AciColor1.Index = CType(256, Short)
        AciColor1.IsByBlock = False
        AciColor1.IsByLayer = True
        AciColor1.UseTrueColor = False
        DxfDocument1.CurrentColor = AciColor1
        DxfDocument1.CurrentElevation = 0R
        DxfDocument1.CurrentLayer = "0"
        DxfDocument1.CurrentLineTypeName = "ByLayer"
        DxfDocument1.CurrentLineTypeScale = 1.0R
        DxfDocument1.CurrentTextSize = 2.5R
        DxfDocument1.CurrentTextStyle = "STANDARD"
        DxfDocument1.CurrentThickness = 0R
        DxfDocument1.DateCreated = New Date(2020, 4, 24, 8, 56, 22, 681)
        DxfDocument1.DateLastEdited = New Date(2020, 4, 24, 8, 56, 22, 681)
        DxfDocument1.Handle = "0"
        DxfDocument1.IsBinary = False
        DxfDocument1.Modified = False
        DxfDocument1.Name = Nothing
        DxfDocument1.Owner = Nothing
        RasterVariables1.DisplayFrame = True
        RasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High
        RasterVariables1.Handle = "2D"
        RasterVariables1.Owner = Nothing
        RasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless
        DxfDocument1.RasterVariables = RasterVariables1
        DxfDocument1.ThumbnailImage = Nothing
        DxfDocument1.TotalEditTime = New Date(2020, 4, 24, 0, 0, 0, 0)
        DxfDocument1.TotalEditTimeDays = 0
        DxfDocument1.UserTimer = New Date(2020, 4, 24, 0, 0, 0, 0)
        DxfDocument1.UserTimerDays = 0
        Me.dxfReaderNETControl1.DXF = DxfDocument1
        Me.dxfReaderNETControl1.FileName = Nothing
        Me.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta
        Me.dxfReaderNETControl1.HighlightNotContinuous = False
        Me.dxfReaderNETControl1.Location = New System.Drawing.Point(91, 34)
        Me.dxfReaderNETControl1.Name = "dxfReaderNETControl1"
        Me.dxfReaderNETControl1.ShowAxes = False
        Me.dxfReaderNETControl1.ShowGrid = True
        Me.dxfReaderNETControl1.ShowGridRuler = False
        Me.dxfReaderNETControl1.Size = New System.Drawing.Size(818, 467)
        Me.dxfReaderNETControl1.TabIndex = 11
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 546)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(1059, 22)
        Me.statusStrip1.TabIndex = 12
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(118, 17)
        Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.ToolStripMenuItem2, Me.viewToolStripMenuItem, Me.toolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1059, 24)
        Me.menuStrip1.TabIndex = 13
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newDrawingToolStripMenuItem, Me.toolStripSeparator3, Me.loadDXFFileToolStripMenuItem, Me.saveDXFFileToolStripMenuItem, Me.toolStripSeparator2, Me.toolStripSeparator1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'newDrawingToolStripMenuItem
        '
        Me.newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem"
        Me.newDrawingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.newDrawingToolStripMenuItem.Text = "New drawing"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'loadDXFFileToolStripMenuItem
        '
        Me.loadDXFFileToolStripMenuItem.Name = "loadDXFFileToolStripMenuItem"
        Me.loadDXFFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.loadDXFFileToolStripMenuItem.Text = "Load DXF file..."
        '
        'saveDXFFileToolStripMenuItem
        '
        Me.saveDXFFileToolStripMenuItem.Name = "saveDXFFileToolStripMenuItem"
        Me.saveDXFFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.saveDXFFileToolStripMenuItem.Text = "Save DXF file..."
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomExtentsToolStripMenuItem, Me.zoomWindowToolStripMenuItem})
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.viewToolStripMenuItem.Text = "View"
        '
        'zoomExtentsToolStripMenuItem
        '
        Me.zoomExtentsToolStripMenuItem.Name = "zoomExtentsToolStripMenuItem"
        Me.zoomExtentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.zoomExtentsToolStripMenuItem.Text = "Zoom extents"
        '
        'zoomWindowToolStripMenuItem
        '
        Me.zoomWindowToolStripMenuItem.Name = "zoomWindowToolStripMenuItem"
        Me.zoomWindowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.zoomWindowToolStripMenuItem.Text = "Zoom window"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutDXFReaderNETComponentToolStripMenuItem})
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.toolStripMenuItem1.Text = "?"
        '
        'aboutDXFReaderNETComponentToolStripMenuItem
        '
        Me.aboutDXFReaderNETComponentToolStripMenuItem.Name = "aboutDXFReaderNETComponentToolStripMenuItem"
        Me.aboutDXFReaderNETComponentToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.aboutDXFReaderNETComponentToolStripMenuItem.Text = "About DXFReader.NET Component..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectEntityWithAMouseClickToolStripMenuItem, Me.SelectEntitiesWithRectangleToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(57, 20)
        Me.ToolStripMenuItem2.Text = "Modify"
        '
        'SelectEntityWithAMouseClickToolStripMenuItem
        '
        Me.SelectEntityWithAMouseClickToolStripMenuItem.Name = "SelectEntityWithAMouseClickToolStripMenuItem"
        Me.SelectEntityWithAMouseClickToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SelectEntityWithAMouseClickToolStripMenuItem.Text = "Select entity with a mouse click"
        '
        'SelectEntitiesWithRectangleToolStripMenuItem
        '
        Me.SelectEntitiesWithRectangleToolStripMenuItem.Name = "SelectEntitiesWithRectangleToolStripMenuItem"
        Me.SelectEntitiesWithRectangleToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SelectEntitiesWithRectangleToolStripMenuItem.Text = "Select entities with rectangle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 568)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.dxfReaderNETControl1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DXFReader.NET - Template"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dxfReaderNETControl1 As DXFReaderNET.DXFReaderNETControl
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents saveFileDialog1 As SaveFileDialog
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents newDrawingToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents loadDXFFileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents saveDXFFileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As ToolStripSeparator
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomExtentsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomWindowToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents aboutDXFReaderNETComponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SelectEntityWithAMouseClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectEntitiesWithRectangleToolStripMenuItem As ToolStripMenuItem
End Class
