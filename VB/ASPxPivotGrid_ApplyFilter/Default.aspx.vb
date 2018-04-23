Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxPivotGrid

Namespace ApplyFilter
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				Dim field As PivotGridField = ASPxPivotGrid1.Fields("Country")
				' Locks the control to prevent excessive updates when multiple properties are modified.
				ASPxPivotGrid1.BeginUpdate()
				Try
					' Clears the filter value collection and add two items to it.
					field.FilterValues.Clear()
					field.FilterValues.Add("Brazil")
					field.FilterValues.Add("USA")
					' Specifies that the control should only display the records 
					' which contain the specified values in the Country field.
					field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
				Finally
					' Unlocks the control.
					ASPxPivotGrid1.EndUpdate()
				End Try
			End If
		End Sub
	End Class
End Namespace
