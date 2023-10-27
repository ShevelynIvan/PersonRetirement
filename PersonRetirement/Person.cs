namespace PersonRetirement
{
    public class Person
    {
        private int _age;
        private int _experience;

        public string Name { get; set; }

        /// <summary>
        /// Age. Can't be more than 120.
        /// </summary>
        public int Age 
        {
            get => _age;
            set => _age = Validation(value, 120);
        }

        /// <summary>
        /// Number of years of work experience. Can't be more than (age - 16).
        /// </summary>
        public int Experience 
        {
            get => _experience;
            set => _experience = Validation(value, _age - 16);
        }

        /// <summary>
        /// Constructor to create the person
        /// </summary>
        /// <param name="name">Name of person</param>
        /// <param name="age">Age of person</param>
        /// <param name="experience">Work experience (number of years)</param>
        public Person(string name, int age, int experience)
        {
            Name = name;
            Age = age;
            Experience = experience;
        }

        /// <summary>
        /// Calculates retirement value in other ways
        /// </summary>
        /// <param name="func">Func delegate to calculate retirement value</param>
        /// <returns>Retirement value</returns>
        public double GetRetirementValue(Func<int, int, double> func)
        {
            return func(Age, Experience);
        }

        /// <summary>
        /// Validation method to set age and experience in right way
        /// </summary>
        /// <param name="value">Value to set</param>
        /// <param name="maxPossibleValue">Max possible value to set</param>
        /// <returns></returns>
        private int Validation(int value, int maxPossibleValue)
        {
            if (value < 0)
                return 0;
            if (value > maxPossibleValue)
                return maxPossibleValue;

            return value;
        }
    }
}
