﻿Imports SkyEditor.Core
Imports SkyEditor.Core.UI
Imports SkyEditor.UI.WPF.AvalonHelpers

Public Class WPFIOUIManager
    Inherits IOUIManager

    Public Sub New(manager As PluginManager)
        MyBase.New(manager)
        AvalonDockLayout = New AvalonDockLayoutViewModel(manager)
    End Sub

    Public Property AvalonDockLayout As AvalonDockLayoutViewModel

    Protected Overrides Function CreateViewModel(model As Object) As FileViewModel
        Return New AvalonDockFileWrapper(model)
    End Function
End Class
