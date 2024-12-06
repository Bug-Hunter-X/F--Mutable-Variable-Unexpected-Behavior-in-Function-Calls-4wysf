let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let addResult = add x y
printf "%d\n" addResult // This will print 30

x <- 15
y <- 25

printf "%d\n" addResult // This will still print 30, not 40 as expected