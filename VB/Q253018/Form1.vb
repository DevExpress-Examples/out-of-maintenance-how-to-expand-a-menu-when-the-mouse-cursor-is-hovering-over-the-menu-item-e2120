Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace Q253018
	Partial Public Class Form1
		Inherits Form

		Private helper As BarHelper

		Public Sub New()
			InitializeComponent()
			helper = New BarHelper(barManager1)
			helper.ExpandMenuOnMouseHover = True
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			helper.ExpandMenuOnMouseHover = False
		End Sub
	End Class
End Namespace