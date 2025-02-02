let mutable x = 1
let mutable y = 2
let swap x y = 
    let temp = x
    x <- y
    y <- temp
swap x y
printf "%d %d" x y // Expected: 2 1, Actual: 1 2