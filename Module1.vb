Module Module1


    Dim notas As Int32()
        Dim alumnos As String()

        Dim indice As Int32

    Sub Main()


        Console.WriteLine("Cantidad de alumnos")
        indice = Console.ReadLine

        ReDim notas(indice - 1)
        ReDim alumnos(indice - 1)

        ingreso()
        Console.Clear()
        Console.WriteLine("==================")

        listado()

        Console.WriteLine("==================")

        estadistica()
    End Sub

    Sub ingreso()

        'Ingreso
        For i = 0 To indice - 1

            Console.WriteLine("Ingrese Alumno: ")
            alumnos(i) = Console.ReadLine
            Console.WriteLine("Ingrese Notas: ")
            notas(i) = Console.ReadLine


        Next

    End Sub

    Sub listado()

        'listado
        For i = 0 To indice - 1

            Console.WriteLine("Nombre: " & alumnos(i) & " Nota: " & notas(i))

        Next

    End Sub

    Sub estadistica()
        Dim contPromocionados As Int32
        Dim contAprobados As Int32
        Dim contDesaprobados As Int32

        For i = 0 To indice - 1
            If (notas(i) > 7) Then

                contPromocionados = contPromocionados + 1

            ElseIf (notas(i) > 4 And notas(i) < 8) Then

                contAprobados = contAprobados + 1
            ElseIf (notas(i) < 4) Then
                contDesaprobados = contDesaprobados + 1
            End If

        Next

        Console.WriteLine("Promocionado: " & contPromocionados)
        Console.WriteLine("Aprobados: " & contAprobados)
        Console.WriteLine("Desaprobados: " & contDesaprobados)
        Console.WriteLine("==================")
        Console.ReadKey()


    End Sub



End Module
