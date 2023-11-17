// 
// let cube x:int=x* x* x
// let passx f=f 2
// printfn"%A"(passx cube)




// //
// let curriedADD x y=x + y
// let addTen = curriedADD 10
// printfn "%d" (addTen 5)

// let curriedADD1 x y z=x+y+z
// let addTen1 = curriedADD1 10 11 12
// printfn "%d" (addTen1)
// //


// let incrementone x=x+2
// let double x=x*2
// let callthefunction=incrementone >> double
// printfn "%A" (callthefunction 5)




// let calculateKineticEnergy m v =
//     let kineticEnergy = 0.5 * m * v * v
//     kineticEnergy

// // Example usage
// // velocity in meters per second

// let result = calculateKineticEnergy 
// printfn  "%f" (result 5.00 6.00)


// let rec fact x=
//         if x<1 then 1
//         else x*(fact (x-1))
// let cal=fact 6
// printfn "%A" cal

// let rec Power baseValue exponent =
//     // Base case: exponent is 0, return 1
//     if exponent = 0 then
// //         1
// //     else
// //         baseValue * Power baseValue (exponent - 1)

// // // Example usage
// // let baseValue = 3
// // let exponent = 3

// // let result1 = Power  baseValue exponent
// // printfn "%d^%d = %d" baseValue exponent result1

// //let rec power x y=
//   //  if y=0 then
//     //else x * power x (y-1)
// //let  cal = power 3 3
// //printfn "The answer is %d" cal




// let f = fun n-> n%2 =1
// let evens = [4;5;6] |> List.filter f
// evens |> List.iter (printfn "%d")
// 

// open System

// // List of numbers
// let numbers = [17; 29; 5; 3; 99; 107; 315]

// // Filter multiples of 6 and print them
// let multiplesOf6 = numbers |> List.filter (fun x -> x % 6 = 0)
// printfn "Multiples of 6: %A" multiplesOf6

// // Find product using fold
// let productFold = numbers |> List.fold (*) 1
// printfn "Product using fold: %d" productFold

// // Find product using Seq.reduce
// let productReduce = numbers |> Seq.reduce (*)
// printfn "Product using reduce: %d" productReduce

// // Map: Increment by 5 and print using Iter function
// let incrementedIter = List.map (fun x -> x + 5) numbers
// printfn "Incremented by 5 using Iter: %A" incrementedIter

// // Map: Increment by 5 and find sum
// let incrementedBy5 = List.map (fun x -> x + 5) numbers
// let sumIncremented = incrementedBy5 |> List.sum
// printfn "Sum of elements incremented by 5: %d" sumIncremented

// // Multiply by 3, filter, and find sum
// let multipliedBy3 = List.map (fun x -> x * 3) numbers
// let filteredGreaterThan100 = multipliedBy3 |> List.filter (fun x -> x % 3 <> 0 || x <= 100)
// let sumFiltered = filteredGreaterThan100 |> List.sum
// printfn "Sum of elements multiplied by 3, then filtered: %d" sumFiltered

// //question no 2 answers

// // Generate a sequence from 1 to 70 with a step of 3
// let sequence = seq {1 .. 3 .. 70}

// // Filter odd numbers from the sequence
// let oddNumbers = sequence |> Seq.filter (fun x -> x % 2 <> 0)

// // Print odd numbers
// printfn "Odd Numbers: %A" oddNumbers

// // Multiply all odd numbers by 2 and find the sum
// let multipliedAndSummed =
//     oddNumbers
//     |> Seq.map (fun x -> x * 2)
//     |> Seq.sum

// // Print sum of the resulting numbers after multiplying by 2
// printfn "Sum of odd numbers multiplied by 2: %d" multipliedAndSummed

// //question no 3 answer

// // List of strings
// let strings = ["Python"; "Fsharp"; "Java"; "Rick"; "Apple"; "Scientology"; "Nihilism"; "Plymouth"]

// // Map function to find the length of each element and print it
// let lengths = strings |> List.map (fun x -> x.Length)
// printfn "Length of each element: %A" lengths

// // Filter elements that have an "i" and print them
// let containsI = strings |> List.filter (fun x -> x.Contains("i"))
// printfn "Elements containing 'i': %A" containsI

// // Filter elements that have an "s" and further filter elements that have an "i" or "e" and print them
// let containsS = strings |> List.filter (fun x -> x.Contains("s"))
// let filteredSE = containsS |> List.filter (fun x -> x.Contains("i") || x.Contains("e"))
// printfn "Elements containing 's' and either 'i' or 'e': %A" filteredSE

// // Check if all elements have an "i"
// let allHaveI = strings |> List.map (fun x -> x.Contains("i")) |> List.fold (&&) true
// printfn "Do all elements have 'i'? %b" allHaveI




//test one-Question-2
let sum_of_multiples n =
    let rec result total first =
        if first >= n then
            total
        else
            result (total + first) (first + 3)
    
    result 0 3

let result = sum_of_multiples 27
printfn "The sum of multiples of 3 up to 27 is: %d" result


//test one-Question-1
open System

// salaries list
let deepak = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let printHighIncomeSalaries (salaries: int list) =
    salaries
    |> List.filter (fun salary -> salary > 100000)
    |> List.iteri (fun i salary -> printfn "Employee who have high income %d: $%d" (i + 1) salary)

printHighIncomeSalaries deepak

// Calculate tax based on the provided tax rates
let deepak2 = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let calculateTax salary =
    let Float = float salary
    match salary with
    | _ when salary <= 49020 -> Float * 0.15
    | _ when salary <= 98040 -> Float * 0.205
    | _ when salary <= 151978 -> Float * 0.26
    | _ when salary <= 216511 -> Float * 0.29
    | _ -> Float * 0.33

let taxes = deepak2 |> List.map calculateTax

taxes |> List.iteri (fun i tax -> printfn "Employee salary tax %d: $%f" (i + 1) tax)



// Filter salaries less than $49,020 and add $20,000 to these salary using map
let deepak1 = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let incrementSalary salary = salary + 20000

let updatedSalaries = 
    deepak1 
    |> List.filter (fun salary -> salary < 49020)
    |> List.map (fun salary -> (salary, incrementSalary salary))

updatedSalaries |> List.iter (fun (original, updated) ->
    printfn "Original salary is: $%d, Updated salary is: $%d" original updated)

// Filter salaries between $50,000 and $100,000 and sum them using fold function

let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

printfn "Original Salaries is: %A" salaries

let sumOfFilteredSalaries =
    let isBetween50kAnd100k salary = salary >= 50000 && salary <= 100000
    let sumFunction acc salary = if isBetween50kAnd100k salary then acc + salary else acc

    List.fold sumFunction 0 salaries

printfn "Total sum of Salary between $50,000 and $100,000: %d" sumOfFilteredSalaries