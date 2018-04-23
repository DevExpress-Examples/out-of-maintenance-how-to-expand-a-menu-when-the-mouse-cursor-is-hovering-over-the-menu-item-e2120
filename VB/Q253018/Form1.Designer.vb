Imports Microsoft.VisualBasic
Imports System
Namespace Q253018
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem3 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem4 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem5 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barSubItem2, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barSubItem3, Me.barButtonItem9, Me.barButtonItem10, Me.barSubItem4, Me.barButtonItem11, Me.barButtonItem12, Me.barSubItem5, Me.barButtonItem1, Me.barButtonItem13})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 20

			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem4)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "&File"
			Me.barSubItem1.Id = 0
			Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4)})
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "&Open"
			Me.barButtonItem2.Id = 2
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "&Add"
			Me.barButtonItem3.Id = 3
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "&Close"
			Me.barButtonItem4.Id = 4
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barSubItem2
			' 
			Me.barSubItem2.Caption = "&Edit"
			Me.barSubItem2.Id = 5
			Me.barSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8)})
			Me.barSubItem2.Name = "barSubItem2"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "&Cut"
			Me.barButtonItem5.Id = 6
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' barButtonItem6
			' 
			Me.barButtonItem6.Caption = "&Copy"
			Me.barButtonItem6.Id = 7
			Me.barButtonItem6.Name = "barButtonItem6"
			' 
			' barButtonItem7
			' 
			Me.barButtonItem7.Caption = "&Paste"
			Me.barButtonItem7.Id = 8
			Me.barButtonItem7.Name = "barButtonItem7"
			' 
			' barButtonItem8
			' 
			Me.barButtonItem8.Caption = "&Delete"
			Me.barButtonItem8.Id = 9
			Me.barButtonItem8.Name = "barButtonItem8"
			' 
			' barSubItem3
			' 
			Me.barSubItem3.Caption = "&View"
			Me.barSubItem3.Id = 10
			Me.barSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10)})
			Me.barSubItem3.Name = "barSubItem3"
			' 
			' barButtonItem9
			' 
			Me.barButtonItem9.Caption = "&Code"
			Me.barButtonItem9.Id = 11
			Me.barButtonItem9.Name = "barButtonItem9"
			' 
			' barButtonItem10
			' 
			Me.barButtonItem10.Caption = "&Designer"
			Me.barButtonItem10.Id = 12
			Me.barButtonItem10.Name = "barButtonItem10"
			' 
			' barSubItem4
			' 
			Me.barSubItem4.Caption = "&Help"
			Me.barSubItem4.Id = 13
			Me.barSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem12)})
			Me.barSubItem4.Name = "barSubItem4"
			' 
			' barButtonItem11
			' 
			Me.barButtonItem11.Caption = "&Contents"
			Me.barButtonItem11.Id = 14
			Me.barButtonItem11.Name = "barButtonItem11"
			' 
			' barButtonItem12
			' 
			Me.barButtonItem12.Caption = "&About"
			Me.barButtonItem12.Id = 15
			Me.barButtonItem12.Name = "barButtonItem12"
			' 
			' barSubItem5
			' 
			Me.barSubItem5.Caption = "&New"
			Me.barSubItem5.Id = 17
			Me.barSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem13)})
			Me.barSubItem5.Name = "barSubItem5"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "&Project"
			Me.barButtonItem1.Id = 18
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem13
			' 
			Me.barButtonItem13.Caption = "&File"
			Me.barButtonItem13.Id = 19
			Me.barButtonItem13.Name = "barButtonItem13"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 268)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "DX Sample"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar2 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem2 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem3 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem10 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem4 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem11 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem12 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem5 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem13 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

