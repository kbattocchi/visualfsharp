// #Warnings
//<Expects status="Error" id="FS0039">The value or constructor 'MyCase1' is not defined. Maybe you want one of the following: MyUnion.MyCase1$</Expects>

[<RequireQualifiedAccess>]
type MyUnion =
| MyCase1
| MyCase2 of string

let x : MyUnion = MyCase1 
    
exit 0