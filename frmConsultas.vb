Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Public Class frmConsultas
    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        Dim Raiz As TreeNode
        Dim NodoEmpleado As TreeNode
        Dim Nombre As TreeNode
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()


        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "PERFILES"
        DRPerfiles = Comando.ExecuteReader

        Raiz = TreeView1.Nodes.Add("PERFILES", "Descripcion")
        Try
            If DRPerfiles.HasRows Then
                While DRPerfiles.Read
                    NodoEmpleado = Raiz.Nodes.Add(DRPerfiles("Id_Perfil"), DRPerfiles("Descripcion"))
                    Conexion1.ConnectionString = CadenaDeConexion
                    Conexion1.Open()
                    Comando1.Connection = Conexion1
                    Comando1.CommandType = CommandType.TableDirect
                    Comando1.CommandText = "EMPLEADOS"
                    DREmpleado = Comando1.ExecuteReader
                    If DREmpleado.HasRows Then
                        While DREmpleado.Read
                            If DREmpleado("Id_Perfil") = DRPerfiles("Id_Perfil") Then

                                Nombre = NodoEmpleado.Nodes.Add(DREmpleado("Id"), DREmpleado("Nombre_Apellido"))
                                Nombre.Tag = DREmpleado("Id")
                            End If
                        End While
                    End If

                    Conexion1.Close()
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.Source & vbCrLf & vbCrLf & ex.StackTrace)
        End Try

        Conexion.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        ListView1.Clear()

        Conexion1.ConnectionString = CadenaDeConexion
        Conexion1.Open()

        Comando1.Connection = Conexion1
        Comando1.CommandType = CommandType.TableDirect
        Comando1.CommandText = "EMPLEADOS"
        DREmpleado = Comando1.ExecuteReader

        If DREmpleado.HasRows Then

            While DREmpleado.Read
                If DREmpleado("Id") = TreeView1.SelectedNode.Tag Then
                    ListView1.View = View.Details
                    ListView1.Columns.Add(DREmpleado("Id"), 28, HorizontalAlignment.Left)
                    ListView1.Columns.Add(DREmpleado("Nombre_Apellido"), 180, HorizontalAlignment.Left)
                    ListView1.Columns.Add(DREmpleado("fechaNacimiento"), 100, HorizontalAlignment.Left)
                    ListView1.Columns.Add(DREmpleado("dni"), 100, HorizontalAlignment.Left)
                    ListView1.Columns.Add(DREmpleado("sexo"), 28, HorizontalAlignment.Left)
                    ListView1.Columns.Add(DREmpleado("id_Perfil"), 28, HorizontalAlignment.Left)
                End If
            End While
        End If

        Conexion1.Close()

    End Sub

End Class