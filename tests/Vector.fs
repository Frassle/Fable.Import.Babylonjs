module Tests.Vector

open System
open Fable.Core
open Fable.Core.JsInterop
open Babylonjs

let inline equal (expected: 'T) (actual: 'T): unit =
    Testing.Assert.AreEqual(expected, actual)

[<Global>]
let it (msg: string) (f: unit->unit): unit = jsNative

[<Global>]
let describe (msg: string) (f: unit->unit): unit = jsNative

describe "tests" <| fun _ ->
  
  describe "vector.add" <| fun _ ->
    let a = babylon.Vector3.Create (1.0, 2.0, 3.0)
    let b = babylon.Vector3.Create (4.0, 5.0, 6.0)
    let c = a.add(b)
    equal true (c.equals (babylon.Vector3.Create (5.0, 7.0, 9.0)))