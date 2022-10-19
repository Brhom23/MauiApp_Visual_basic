Imports System.Runtime.CompilerServices

Module My_Tools
    <Extension>
    Function Slf(Of T)(Obj As T) As T
        Return Obj
    End Function

End Module
