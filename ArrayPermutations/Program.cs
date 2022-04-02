Console.WriteLine("Array Permutations");
var array = new List<int> { 1, 2 };
var output = Algorithm.Permutations(array);

foreach(var permutation in output)
    Console.WriteLine(String.Join(",", permutation));

class Algorithm {
    public static List<List<int>> Permutations(
        List<int> numbers,
        List<int>? currentPermutation = null,
        List<List<int>>? permutations = null
    )
    {
        if(currentPermutation is null) 
            currentPermutation = new List<int>();
        if(permutations is null)
            permutations = new List<List<int>>();

        if(numbers.Count() == 0)
            permutations.Add(currentPermutation);
        else {
            foreach(var number in numbers)
            {
                var newArrayNumbers = numbers.Select(x => x).ToList();
                newArrayNumbers.Remove(number);
                var newPermutation = currentPermutation.Select(x => x).ToList();
                newPermutation.Add(number);
                Permutations(newArrayNumbers, newPermutation, permutations);
            }
        }

        return permutations;
    }
}