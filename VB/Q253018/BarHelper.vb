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
	Public Class BarHelper
		Private manager As BarManager

		Public Sub New(ByVal manager As BarManager)
			Me.manager = manager
		End Sub


		Public WriteOnly Property ExpandMenuOnMouseHover() As Boolean
			Set(ByVal value As Boolean)
				RemoveHandler manager.HighlightedLinkChanged, AddressOf OnBarManagerHighlightedLinkChanged
				If value Then
					AddHandler manager.HighlightedLinkChanged, AddressOf OnBarManagerHighlightedLinkChanged
				End If
			End Set
		End Property

		Private Sub OnBarManagerHighlightedLinkChanged(ByVal sender As Object, ByVal e As HighlightedLinkChangedEventArgs)
			Dim mousePosition As Point = manager.Form.PointToClient(Control.MousePosition)
			Dim link As BarCustomContainerItemLink = TryCast(e.Link, BarCustomContainerItemLink)
			If link IsNot Nothing AndAlso link.Bounds.Contains(mousePosition) Then
				link.OpenMenu()
			End If
		End Sub

	End Class
End Namespace
