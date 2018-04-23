Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxTreeView
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Const FileImageUrl As String = "~/Images/file.png"
	Private Const DirImageUrl As String = "~/Images/directory.png"

	Protected Sub treeView_VirtualModeCreateChildren(ByVal source As Object, ByVal e As TreeViewVirtualModeCreateChildrenEventArgs)
		Dim parentNodePath As String
		If String.IsNullOrEmpty(e.NodeName) Then
			parentNodePath = Page.MapPath("~/")
		Else
			parentNodePath = e.NodeName
		End If
		Dim children As New List(Of TreeViewVirtualNode)()
		If Directory.Exists(parentNodePath) Then
			For Each childPath As String In Directory.GetDirectories(parentNodePath)
				Dim childDirName As String = Path.GetFileName(childPath)
				If IsSystemName(childDirName) Then
					Continue For
				End If
				Dim childNode As New TreeViewVirtualNode(childPath, childDirName)
				childNode.Image.Url = DirImageUrl
				children.Add(childNode)
			Next childPath
			For Each childPath As String In Directory.GetFiles(parentNodePath)
				Dim childFileName As String = Path.GetFileName(childPath)
				If IsSystemName(childFileName) Then
					Continue For
				End If
				Dim childNode As New TreeViewVirtualNode(childPath, childFileName)
				childNode.IsLeaf = True
				childNode.Image.Url = FileImageUrl
				children.Add(childNode)
			Next childPath
		End If
		e.Children = children
	End Sub

	Private Function IsSystemName(ByVal name As String) As Boolean
		name = name.ToLower()
		Return name.StartsWith("app_") OrElse name = "bin" OrElse name.EndsWith(".aspx.cs") OrElse name.EndsWith(".aspx.vb")
	End Function
End Class
