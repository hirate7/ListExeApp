Public Class frmCListExeApp
    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click

        'ローカルコンピュータ上で実行されているすべてのプロセスを取得
        Dim ps As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcesses()
        '"machinename"という名前のコンピュータで実行されている
        'すべてのプロセスを取得するには次のようにする。
        'Dim ps As System.Diagnostics.Process() = _
        '    System.Diagnostics.Process.GetProcesses("machinename")

        '配列から1つずつ取り出す
        For Each p As System.Diagnostics.Process In ps
            Try
                'プロセス名を出力する
                If p.MainModule.FileName IsNot Nothing Then
                    List1.Items.Add(Trim(System.IO.Path.GetFileName(Trim(p.MainModule.FileName))))
                End If

            Catch ex As Exception

            End Try
        Next

    End Sub
End Class
