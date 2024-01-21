using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class NumberPicker
    {
        private List<int> numbers;
        private Random random;

        public NumberPicker(List<int> usedNumbers)
        {
            // Initialize the list with numbers 1-9
            numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers.RemoveAll(n=> usedNumbers.Contains(n));

            // Initialize the random number generator
            random = new Random();
        }

        public int PickNumber()
        {
            if (numbers.Count == 0)
            {
                throw new InvalidOperationException("No numbers left to pick.");
            }

            // Generate a random index
            int index = random.Next(numbers.Count);

            // Select the number at the random index
            int selectedNumber = numbers[index];

            // Remove the selected number from the list
            numbers.RemoveAt(index);

            return selectedNumber;
        }
    }

    // Usage
    
}
