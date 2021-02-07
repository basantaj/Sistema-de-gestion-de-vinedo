Public Class FormAlerta
    Private alerta As String
    Dim obs As FormObservadores

    Public Sub New(ByRef ob As FormObservadores)
        InitializeComponent()

        obs = ob
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        obs.alerta = datePicker.Value.ToString("dd/MM/yyyy")
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub ingresoAlerta(ByVal al As String)

    End Sub

   
    Private Sub FormAlerta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class