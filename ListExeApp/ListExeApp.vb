Module ListExeApp

    '/// 呼び出し時に渡される ///
    Public Path_KDATA As String = "C:\Mapleo\KDATA\"

    Sub Main()

        If Environment.GetCommandLineArgs.Count = 1 Then
            '手動で実行

            Dim frmListExeApp As New frmCListExeApp
            frmListExeApp.ShowDialog()

            Exit Sub

        End If

        If Environment.GetCommandLineArgs.Count <> 2 Then
            MessageBox.Show("パラメータの数が間違っています")
            Return
        End If

        Dim Res As String = ""

        Path_KDATA = Environment.GetCommandLineArgs(1)

        'ローカルコンピュータ上で実行されているすべてのプロセスを取得
        Dim ps As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcesses()

        Dim sw As New System.IO.StreamWriter(Path_KDATA + "ListExeAppRes.txt", False, System.Text.Encoding.GetEncoding("shift_jis"))

        '配列から1つずつ取り出す
        For Each p As System.Diagnostics.Process In ps
            Try
                'プロセス名を出力する
                If p.MainModule.FileName IsNot Nothing Then
                    sw.WriteLine(Trim(System.IO.Path.GetFileName(Trim(p.MainModule.FileName))))
                End If

            Catch ex As Exception

            End Try
        Next

        sw.Close()

    End Sub

End Module
