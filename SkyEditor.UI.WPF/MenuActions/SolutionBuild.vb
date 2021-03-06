﻿Imports System.Reflection
Imports System.Threading.Tasks
Imports SkyEditor.Core.IO
Imports SkyEditor.Core.UI

Namespace MenuActions
    Public Class SolutionBuild
        Inherits MenuAction

        Public Overrides Function SupportedTypes() As IEnumerable(Of TypeInfo)
            Return {GetType(Solution).GetTypeInfo}
        End Function


        Public Overrides Async Sub DoAction(Targets As IEnumerable(Of Object))
            For Each item As Solution In Targets
                Await item.Build()
            Next
        End Sub

        Public Sub New()
            MyBase.New({My.Resources.Language.MenuSolution, My.Resources.Language.MenuSolutionBuild})
            SortOrder = 2.1
        End Sub
    End Class
End Namespace

