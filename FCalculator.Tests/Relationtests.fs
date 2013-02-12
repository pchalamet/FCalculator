module FCalculator.Tests.Relation

open NUnit.Framework
open FsUnit
open FCalculator.Main

[<TestFixture>]
type ``Given EvaluateString is given a valid relation expression`` ()=

    [<Test>] member x.
        ``when expression is 1 <= 1 answer is 1.0`` ()=
            EvaluateString "1 <= 1" |> should equal 1.0
    
    [<Test>] member x.
        ``when expression is 1 >= 1 answer is 1.0`` ()=
            EvaluateString "1 >= 1" |> should equal 1.0
     
    [<Test>] member x.
        ``when expression is 1 <= 2 answer is 1.0`` ()=
            EvaluateString "1 <= 2" |> should equal 1.0
            
    [<Test>] member x.
        ``when expression is 2 >= 1 answer is 1.0`` ()=
            EvaluateString "2 >= 1" |> should equal 1.0
            
    [<Test>] member x.
        ``when expression is 1 >= 2 answer is 0.0`` ()=
            EvaluateString "1 >= 2" |> should equal 0.0 
            
    [<Test>] member x.
        ``when expression is 2 <= 1 answer is 0.0`` ()=
            EvaluateString "2 <= 1" |> should equal 0.0
            
    
    
    
    [<Test>] member x.
        ``when expression is 1 < 1 answer is 0.0`` ()=
            EvaluateString "1 < 1" |> should equal 0.0
    
    [<Test>] member x.
        ``when expression is 1 > 1 answer is 0.0`` ()=
            EvaluateString "1 > 1" |> should equal 0.0
     
    [<Test>] member x.
        ``when expression is 1 < 2 answer is 1.0`` ()=
            EvaluateString "1 < 2" |> should equal 1.0
            
    [<Test>] member x.
        ``when expression is 2 > 1 answer is 1.0`` ()=
            EvaluateString "2 > 1" |> should equal 1.0
            
    [<Test>] member x.
        ``when expression is 1 > 2 answer is 0.0`` ()=
            EvaluateString "1 > 2" |> should equal 0.0 
            
    [<Test>] member x.
        ``when expression is 2 < 1 answer is 0.0`` ()=
            EvaluateString "2 < 1" |> should equal 0.0
            
   