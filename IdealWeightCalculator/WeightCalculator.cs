using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculator
{
    public class WeightCalculator
    {
        private readonly IDataRepository repository;

        public double Height { get; set; }
        public char Gender { get; set; }

        public WeightCalculator()
        {

        }
        public WeightCalculator(IDataRepository repository)
        {
            this.repository = repository;
        }
        public double GetIdealBodyWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    throw new ArgumentException("The Gender argument is not valid"); ;
            }
        }

        public List<double> GetIdealBodyWeightFromDataSource()
        {
            List<double> results = new List<double>();

            IEnumerable<WeightCalculator> weights = repository.GetWeights();

            foreach (var weight in weights)
            {
                results.Add(weight.GetIdealBodyWeight());
            }

            return results;
        }

        public bool Validate()
        {
           return Gender == 'm' || Gender =='w';
        }
    }
}
