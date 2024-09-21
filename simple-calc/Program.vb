Imports System

Module Program
    
    dim fNumber,sNumber as integer
    dim action as string
    dim mAction as string
    dim fresult as String
    
    
    Sub Main
        
        
        
        Console.WriteLine("Welcome to the calculator!")
        Console.writeline("Please enter your first number")
        fNumber = console.ReadLine()
        
        Console.WriteLine("And what would you like to do with that number?
1-Add
2-Subtract
3-Multiply
4-Divide")
        
        action = console.ReadLine
        
        if action = "1" then 
            mAction = "add"
            
        else if action = "2" then 
            mAction = "Subtract"
        
       else if action = "3" Then
           mAction = "Multiply"
           
       else if action = "4" Then
           mAction = "Divide"
           
            
        End If
        
        dim id as string
        
        Console.writeline("Please enter second number")
        sNumber = console.readline()
        
        if mAction = "add" Then
            fresult = fnumber + sNumber
            id = "+"
        else if mAction = "Subtract" then
            fresult = fnumber - sNumber
            id = "-"
         else if mAction = "Multiply" then 
             fresult = fnumber * sNumber
             id = "*"
             
        else if mAction = "Divide" then 
            fresult = fnumber / sNumber
            id = "/"
            
            
        End If
        
        Console.WriteLine("Your equation was " & fnumber & id & sNumber)
        Console.WriteLine("Output is " & fresult)
        Console.ReadLine()
        
        
        
        
        
        
        
        
    End Sub
End Module
