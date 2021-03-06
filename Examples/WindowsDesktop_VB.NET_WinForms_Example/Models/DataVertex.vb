﻿Imports GraphX
Imports YAXLib

Namespace Models

    Public Class DataVertex
        Inherits VertexBase
        ''' <summary>
        ''' Some string property for example purposes
        ''' </summary>
        Public Property Text() As String
            Get
                Return _mText
            End Get
            Set(value As String)
                _mText = value
            End Set
        End Property
        Private _mText As String

#Region "Calculated or static props"
        <YAXDontSerialize> _
        Public ReadOnly Property Self() As DataVertex
            Get
                Return Me
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return Text
        End Function


#End Region

        ''' <summary>
        ''' Default parameterless constructor for this class
        ''' (required for YAXLib serialization)
        ''' </summary>
        Public Sub New()
            Me.New("")
        End Sub

        Public Sub New(Optional text1 As String = "")
            Text = text1
        End Sub
    End Class
End Namespace