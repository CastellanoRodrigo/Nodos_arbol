Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Module Datos_Globales

    Public Conexion As New OleDbConnection
    Public Conexion1 As New OleDbConnection

    Public Comando As New OleDb.OleDbCommand
    Public Comando1 As New OleDb.OleDbCommand

    Public Adaptador As New OleDbDataAdapter
    Public Adaptador1 As New OleDbDataAdapter

    Public DS As New DataSet
    Public DR As OleDbDataReader
    Public DRPerfiles As OleDbDataReader
    Public DREmpleado As OleDbDataReader

    Public CadenaDeConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LP3-FINAL MODIFICADO.mdb"


End Module