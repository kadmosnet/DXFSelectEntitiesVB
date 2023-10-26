
Imports DXFReaderNET
Imports DXFReaderNET.Entities

Public Class Form1

    Friend Enum FunctionsEnum
        None
        ZoomWindow1
        ZoomWindow2
        GetEntity
        GetEntities1
        GetEntities2
    End Enum

    Private CurrentFunction As FunctionsEnum = FunctionsEnum.None
    Private p1 As Vector2 = Vector2.Zero
    Private p2 As Vector2 = Vector2.Zero


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.Bounds.Width - 40
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 80
        Me.Left = 20
        Me.Top = 20

        dxfReaderNETControl1.NewDrawing()
        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair
        toolStripStatusLabel1.Text = ""
        dxfReaderNETControl1.Dock = DockStyle.Fill
    End Sub

    Private Sub newDrawingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newDrawingToolStripMenuItem.Click
        dxfReaderNETControl1.NewDrawing()
    End Sub

    Private Sub loadDXFFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loadDXFFileToolStripMenuItem.Click

        openFileDialog1.DefaultExt = "DXF"
        openFileDialog1.Filter = "DXF|*.dxf"
        openFileDialog1.FileName = ""

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            dxfReaderNETControl1.ReadDXF(openFileDialog1.FileName)
        End If

    End Sub

    Private Sub saveDXFFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles saveDXFFileToolStripMenuItem.Click

        saveFileDialog1.DefaultExt = "dxf"
        saveFileDialog1.Filter = "DXF|*.dxf"
        saveFileDialog1.FileName = "drawing.dxf"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName)
        End If
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        End
    End Sub

    Private Sub zoomExtentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles zoomExtentsToolStripMenuItem.Click
        dxfReaderNETControl1.ZoomExtents()
    End Sub

    Private Sub zoomWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles zoomWindowToolStripMenuItem.Click
        CurrentFunction = FunctionsEnum.ZoomWindow1
        toolStripStatusLabel1.Text = "Select start point of the window"
    End Sub

    Private Sub dxfReaderNETControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles dxfReaderNETControl1.MouseMove
        Select Case CurrentFunction
            Case FunctionsEnum.ZoomWindow2, FunctionsEnum.GetEntities2

                dxfReaderNETControl1.ShowRubberBandBox(p1, dxfReaderNETControl1.CurrentWCSpoint)
        End Select
    End Sub

    Private Sub dxfReaderNETControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles dxfReaderNETControl1.MouseUp
        If e.Button = MouseButtons.Left Then

            Select Case CurrentFunction
                Case FunctionsEnum.ZoomWindow2
                    CurrentFunction = FunctionsEnum.None
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair
                    toolStripStatusLabel1.Text = ""
                    dxfReaderNETControl1.ZoomWindow(p1, dxfReaderNETControl1.CurrentWCSpoint)
                Case FunctionsEnum.ZoomWindow1
                    CurrentFunction = FunctionsEnum.ZoomWindow2
                    toolStripStatusLabel1.Text = "Select end point of the window"
                    p1 = dxfReaderNETControl1.CurrentWCSpoint
                Case FunctionsEnum.GetEntity
                    toolStripStatusLabel1.Text = ""
                    CurrentFunction = FunctionsEnum.None
                    Dim ent As EntityObject = dxfReaderNETControl1.GetEntity(dxfReaderNETControl1.CurrentWCSpoint)

                    If ent IsNot Nothing Then
                        toolStripStatusLabel1.Text = EntityInfo(dxfReaderNETControl1, ent)

                        If Not dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent) Then
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(ent)
                            dxfReaderNETControl1.HighLight(ent)
                        End If
                    Else
                        toolStripStatusLabel1.Text = "No entity found"
                    End If

                Case FunctionsEnum.GetEntities2
                    CurrentFunction = FunctionsEnum.None
                    toolStripStatusLabel1.Text = ""
                    p2 = dxfReaderNETControl1.CurrentWCSpoint

                    For Each entity As EntityObject In dxfReaderNETControl1.GetEntities(p1, p2)

                        If Not dxfReaderNETControl1.DXF.SelectedEntities.Contains(entity) Then
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(entity)
                        End If
                    Next

                    toolStripStatusLabel1.Text = "Selected " & dxfReaderNETControl1.DXF.SelectedEntities.Count.ToString() & " entities"
                    dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities)
                Case FunctionsEnum.GetEntities1
                    CurrentFunction = FunctionsEnum.GetEntities2
                    toolStripStatusLabel1.Text = "Select end point of selection rectangle"
                    p1 = dxfReaderNETControl1.CurrentWCSpoint
            End Select
        End If
    End Sub

    Private Sub aboutDXFReaderNETComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutDXFReaderNETComponentToolStripMenuItem.Click
        dxfReaderNETControl1.About()
    End Sub

    Private Sub SelectEntityWithAMouseClickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectEntityWithAMouseClickToolStripMenuItem.Click
        CurrentFunction = FunctionsEnum.GetEntity
        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare
        toolStripStatusLabel1.Text = "Select entity"
    End Sub

    Private Sub SelectEntitiesWithRectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectEntitiesWithRectangleToolStripMenuItem.Click
        CurrentFunction = FunctionsEnum.GetEntities1

        toolStripStatusLabel1.Text = "Select start point of selection rectangle"
    End Sub
    Private Shared Function EntityInfo(ByVal myDXF As DXFReaderNETControl, ByVal ent As EntityObject) As String
        Dim s As String = ""
        Dim colorE As String = ent.Color.ToString()
        If colorE = "ByLayer" Then colorE = myDXF.DXF.Layers(ent.Layer.Name).Color.ToString()

        Select Case colorE
            Case "1"
                colorE = "Red"
            Case "2"
                colorE = "Yellow"
            Case "3"
                colorE = "Green"
            Case "4"
                colorE = "Cyan"
            Case "5"
                colorE = "Blue"
            Case "6"
                colorE = "Magenta"
            Case "7"
                colorE = "White"
        End Select

        Dim ltE As String = ent.Linetype.Name
        If ltE = "ByLayer" Then ltE = myDXF.DXF.Layers(ent.Layer.Name).Linetype.Name
        s = ent.Type.ToString() & " " + ent.Handle & " - Color: " & colorE & " - Layer: " + ent.Layer.Name & " - Linetype: " & ltE

        Select Case ent.Type
            Case EntityType.Line
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, Line)).Lenght)
                s += " - Start point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Line)).StartPoint.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Line)).StartPoint.Y) & ")"
                s += " - End point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Line)).EndPoint.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Line)).EndPoint.Y) & ")"
            Case EntityType.XLine
                s += " - Origin: (" & myDXF.DXF.ToFormattedUnit((CType(ent, XLine)).Origin.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, XLine)).Origin.Y) & ")"
                s += " - Direction: (" & myDXF.DXF.ToFormattedUnit((CType(ent, XLine)).Direction.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, XLine)).Direction.Y) & ")"
            Case EntityType.Ray
                s += " - Origin: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Ray)).Origin.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Ray)).Origin.Y) & ")"
                s += " - Direction: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Ray)).Direction.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Ray)).Direction.Y) & ")"
            Case EntityType.Arc
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).Lenght)
                s += " - Start point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).StartPoint.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).StartPoint.Y) & ")"
                s += " - End point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).EndPoint.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).EndPoint.Y) & ")"
                s += " - Start angle: " & myDXF.DXF.ToFormattedAngle((CType(ent, Arc)).StartAngle * MathHelper.DegToRad)
                s += " - End angle: " & myDXF.DXF.ToFormattedAngle((CType(ent, Arc)).EndAngle * MathHelper.DegToRad)
                s += " - Radius: " & myDXF.DXF.ToFormattedUnit((CType(ent, Arc)).Radius)
            Case EntityType.Circle
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, Circle)).Lenght)
                s += " - Area: " & myDXF.DXF.ToFormattedUnit((CType(ent, Circle)).Area)
                s += " - Center point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Circle)).Center.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Circle)).Center.Y) & ")"
                s += " - Radius: " & myDXF.DXF.ToFormattedUnit((CType(ent, Circle)).Radius)
            Case EntityType.Ellipse
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).Lenght)
                s += " - Area: " & myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).Area)
                s += " - Center point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).Center.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).Center.Y) & ")"
                s += " - MajorAxis: " & myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).MajorAxis)
                s += " - MinorAxis: " & myDXF.DXF.ToFormattedUnit((CType(ent, Ellipse)).MinorAxis)
                s += " - Rotation: " & myDXF.DXF.ToFormattedAngle((CType(ent, Ellipse)).Rotation * MathHelper.DegToRad)
            Case EntityType.LightWeightPolyline
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, LwPolyline)).Lenght)
                If (CType(ent, LwPolyline)).IsClosed Then s += " - Area: " & myDXF.DXF.ToFormattedUnit((CType(ent, LwPolyline)).Area)
                s += " - Vertexes #: " & (CType(ent, LwPolyline)).Vertexes.Count.ToString()
            Case EntityType.Polyline
                s += " - Length: " & myDXF.DXF.ToFormattedUnit((CType(ent, Polyline)).Lenght)
                If (CType(ent, Polyline)).IsClosed Then s += " - Area: " & myDXF.DXF.ToFormattedUnit((CType(ent, Polyline)).Area)
                s += " - Vertexes #: " & (CType(ent, Polyline)).Vertexes.Count.ToString()
            Case EntityType.Insert
                s += " - Insert point: (" & myDXF.DXF.ToFormattedUnit((CType(ent, Insert)).Position.X) & ";" + myDXF.DXF.ToFormattedUnit((CType(ent, Insert)).Position.Y) & ")"
                s += " - Block name: " & (CType(ent, Insert)).Block.Name
        End Select

        For Each _group As DXFReaderNET.Objects.Group In myDXF.DXF.Groups

            If _group.Entities.Contains(ent) Then
                s += " Group: " & _group.Name
                Exit For
            End If
        Next

        Return s
    End Function
End Class
