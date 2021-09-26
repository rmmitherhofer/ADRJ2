Imports System.Data.SqlClient
Public Class cldBancoDados
    Private StringConexao As String = "Server=RAPSERV; Database=ADRJ2;user id= sa;pwd=1234"
    ' Private StringConexao As String = "Server=P3L2M13; Database=ADRJ2;user id= sa;pwd=123456"

    Public Function RetornaDataSet(ByVal strQuery As String) As System.Data.DataSet 'ou As DataSet
        'Cria Conexão
        Dim Conn As New SqlConnection 'Cria obj do tipo conexão com o SQL
        Try
            Conn = AbreBanco() 'Chama função do AbreBanco utilizando a StringConexao
            Dim cmdComando As New SqlCommand 'Cria obj do SqlComand
            With cmdComando
                .CommandText = strQuery 'Passa a consulta do SQL\   
                .CommandType = CommandType.Text 'Tipo de consulta via texto
                .Connection = Conn 'Executa consulta pela conexão
            End With
            'Cria um DataAdapter
            Dim daAdaptador As New SqlDataAdapter 'Cria obj Adaptador de Dados
            Dim dsDataSet As New DataSet 'Cria obj DataSet
            daAdaptador.SelectCommand = cmdComando 'Adaptador recebe a consulta do SQL
            daAdaptador.Fill(dsDataSet) 'Adaptador preenche o DataSet
            Return dsDataSet 'Retorna resultado via DataSet (tabela memória RAM)
        Catch ex As Exception
            Throw ex
            'Throw New Exception("Erro na Camada1: " & ex.Message) 'Menssagem adicional
        Finally
            FechaBanco(Conn) 'Sempre executa esta linha para fechar o BD
        End Try
    End Function

    Private Function AbreBanco() As System.Data.SqlClient.SqlConnection 'ou As SqlConnection
        Dim Conn As New SqlConnection 'Cria obj do tipo conexão com o SQL
        With Conn
            .ConnectionString = StringConexao 'Informa a String para Conexão
            .Open() 'Abre o BD
        End With
        Return Conn 'Retorna o BD aberto
    End Function

    Private Sub FechaBanco(ByVal Conn As SqlConnection)
        If Conn.State = ConnectionState.Open Then 'Verifica se o BD está aberto
            Conn.Close()
        End If
    End Sub

    Public Function RetornaDataReader(ByVal strQuery As String) As SqlDataReader
        Dim Conn As New SqlConnection
        Try
            Conn = AbreBanco()
            Dim cmdComando As New SqlCommand
            With cmdComando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
            End With
            Return cmdComando.ExecuteReader 'Retorna a consulta, pelas informações informadas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ExecutaComando(ByVal strQuery As String)
        'Cria objeto de conexão
        Dim Conn As New SqlConnection
        Try
            'Abre bd
            Conn = AbreBanco()
            'Cria obj de comando
            Dim cmdComando As New SqlCommand
            With cmdComando
                'Passa os valores da Query SQL, tipo do comando, conexao e executa o comando
                .CommandText = strQuery 'Query que entrou
                .CommandType = CommandType.Text 'comandos em sql
                .Connection = Conn
                .ExecuteNonQuery() 'Executa a Query
            End With
            'Excecões
        Catch ex As Exception
            Throw ex
        Finally
            'Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            FechaBanco(Conn)
        End Try
    End Sub
End Class