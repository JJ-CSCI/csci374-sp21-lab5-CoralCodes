module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int
    |sidesTree of Node(Leaf,Leaf)

let rec prod (t:Tree) :int =
  match t with
  // You need to define a constuctor for union
  // subtype first
  | Node (lLeaf, rLeaf)-> lLeaf * rLeaf
  | Leaf
  

let rec map (f:int->int) (t:Tree) :Tree =
    t

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
