namespace LibFS
open System
// open System.Collections.Generic

module Library =
    let hello (name: string) =
        Console.WriteLine("Hello {0} from F#!", name)
        // printfn "Hello %s from F#!" name // this is still WIP (crashing)

    let sqr x = x * x

    let fastFib (n: int) : int =
      let sqrt5 = sqrt 5.0
      let a = (1.0 + sqrt5) / 2.0
      let b = (1.0 - sqrt5) / 2.0
      let power = float n
      let result = ((a ** power) - (b ** power)) / sqrt5
      int (round result)

    // let rec slowFib n =
    //     match n with
    //     | 0 -> 1
    //     | 1 -> 1
    //     | _ -> slowFib (n - 1) + slowFib (n - 2)

    // let memoizedFib =
    //     let dict = new Dictionary<int, int>()
    //     fun n ->
    //       if dict.ContainsKey n then dict.[n]
    //       else
    //         let result = slowFib n
    //         dict.Add(n, result)
    //         result

    // let rec sequenceFib = seq {
    //   yield! [0; 1]
    //   yield! sequenceFib
    //          |> Seq.pairwise
    //          |> Seq.map (fun (prev, next) -> prev + next)
    // }
