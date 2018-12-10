Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ResultadoLabel.Content &= CType(sender, Button).Tag
    End Sub
End Class
