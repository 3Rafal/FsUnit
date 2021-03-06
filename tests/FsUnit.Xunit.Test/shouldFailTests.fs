﻿namespace FsUnit.Test
open Xunit
open FsUnit.Xunit

type ``shouldFail tests`` ()=
    [<Fact>] member test.
     ``empty List should fail to contain item`` ()=
        shouldFail (fun () -> [] |> should contain 1)

    [<Fact>] member test.
     ``non-null should fail to be  Null`` ()=
        shouldFail (fun () -> "something" |> should be Null)

    [<Fact>] member test.
     ``shouldFail should fail when everything is OK`` ()=
        shouldFail (fun () -> shouldFail id)

    [<Fact>] member test.
     ``shouldFaild should throw an exception`` ()=
        (fun () -> shouldFail id)
        |> should throw typeof<MatchException>

    [<Fact>] member test.
     ``shouldFaild should not throw an exception when fail`` ()=
        (fun () -> shouldFail (fun () -> [] |> should contain 1))
        |> should not' (throw typeof<MatchException>)
