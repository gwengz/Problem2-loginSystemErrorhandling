﻿Public Class EmptyFieldException
    Inherits ApplicationException

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class