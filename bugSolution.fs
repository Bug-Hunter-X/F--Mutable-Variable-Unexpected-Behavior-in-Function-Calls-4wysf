let x = ref 10
let y = ref 20

let add x y = 
    !x + !y

let addResult = add x y
printf "%d\n" addResult // This will print 30

x := 15
y := 25

printf "%d\n" (add x y) // This will now print 40