﻿Imports LateBindingApi.Core

Imports Access = NetOffice.AccessApi
Imports NetOffice.AccessApi.Enums
Imports NetOffice.AccessApi.Constants

Imports DAO = NetOffice.DAOApi
Imports NetOffice.DAOApi.Enums
Imports NetOffice.DAOApi.Constants

Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        'Initialize Api COMObject Support
        LateBindingApi.Core.Factory.Initialize()

        ' start access 
        Dim accessApplication As New Access.Application()

        'create database name 
        Dim fileExtension As String = GetDefaultExtension(accessApplication)
        Dim documentFile As String = String.Format("{0}\\Example01{1}", Environment.CurrentDirectory, fileExtension)

        'delete old database if exists
        If (System.IO.File.Exists(documentFile)) Then
            System.IO.File.Delete(documentFile)
        End If

        ' create database 
        Dim newDatabase As DAO.Database = accessApplication.DBEngine.Workspaces(0).CreateDatabase(documentFile, LanguageConstants.dbLangGeneral)

        'close power point and dispose reference
        accessApplication.Quit(AcQuitOption.acQuitSaveAll)
        accessApplication.Dispose()

        Dim fDialog As New FinishDialog("Database saved.", documentFile)
        fDialog.ShowDialog(Me)

    End Sub

    ''' <summary>
    ''' returns the valid file extension for the instance. for example ".mdb" or ".mdbx"
    ''' </summary>
    ''' <param name="application">the instance</param>
    ''' <returns>the extension</returns>
    ''' <remarks></remarks>
    Private Function GetDefaultExtension(ByVal application As Access.Application) As String

        Dim version As Double = application.Version
        If (version >= 120.0) Then
            Return ".xlsx"
        Else
            Return ".xls"
        End If

    End Function

End Class


