﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace global

namespace NSPC
    // Generated by F# CodeDom
    #nowarn "49" // uppercase argument names
    #nowarn "67" // this type test or downcast will always hold
    #nowarn "66" // this upcast is unnecessary - the types are identical
    #nowarn "58" // possible incorrect indentation..
    #nowarn "57" // do not use create_DelegateEvent
    #nowarn "51" // address-of operator can occur in the code
    #nowarn "1183" // unused 'this' reference
    
    exception ReturnException2eee2e34e2f14d4dbbb9b0a83da362e7 of obj
    exception ReturnNoneException2eee2e34e2f14d4dbbb9b0a83da362e7
    [<AutoOpen>]
    module FuncConvertFinalOverload2eee2e34e2f14d4dbbb9b0a83da362e7 =
      // This extension member adds to the FuncConvert type and is the last resort member in the method overloading rules. 
      type global.Microsoft.FSharp.Core.FuncConvert with
          /// A utility function to convert function values from tupled to curried form
          static member FuncFromTupled (f:'T -> 'Res) = f
    
    type
        
        ClassWithField = class
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            static val mutable private InternalField:int
            new() as this =
                {
                }
        end
    
    and
        
        ClassToTest = class
            new() as this =
                {
                }
            abstract CallingWork : int -> int
            default this.CallingWork  (a:int) =
                let mutable a = a
                a <- 10
                let mutable (b:int) = 0
                ClassToTest.Work(&a, &b) |> ignore
                (a + b)
            
            static member Work  (i:int byref, j:int byref) =
                i <- (i + 4)
                j <- 5
            
            abstract MoreArrayTests : int -> int
            default this.MoreArrayTests  (i:int) =
                let mutable i = i
                let mutable (arrayOfArrays:int[][]) = ([| ([| 3; 4 |] : int[]); (Array.zeroCreate (1):int[]); (Array.zeroCreate 0:int[]) |] : int[][])
                (arrayOfArrays.[0].[1] + i)
            
            static member UseInternalField  (i:int) =
                let mutable i = i
                ClassWithField.InternalField <- i
                ClassWithField.InternalField
        end