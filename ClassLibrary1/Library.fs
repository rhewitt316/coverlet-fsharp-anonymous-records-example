module Module1

// Coverlet fails to instrument the DLL produced by this project due to the anonymous record Option2 below.
// Comment out Option2, and instrumentation will succeed.
type Type1 =
  | Option1
  | Option2 of {| x: string |}
