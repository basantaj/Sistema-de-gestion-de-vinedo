Public Class Resultados
    Dim ds As New DataSet
    Dim nom As String
    Private Sub cerrar() Handles Me.FormClosing
        ds.Tables(nom).Clear()
    End Sub

    Public Sub New(ByRef dset As DataSet, ByVal nombre As String)
        InitializeComponent()
        ds = dset
        nom = nombre
        dGrid.DataSource = ds.Tables(nom)
        Show()
    End Sub

    Private Sub dGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGrid.CellClick
        Try
            Clipboard.SetText(dGrid.Item(e.ColumnIndex, e.RowIndex).Value)
            Me.Text = "'" + Clipboard.GetText + "' Copiado al portapapeles"
            Timer1.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "Resultados"
        Timer1.Stop()
    End Sub

    Private Sub Resultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
End Class