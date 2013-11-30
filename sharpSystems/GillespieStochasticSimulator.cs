using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpSystems
{
    public sealed class GillespieStochasticSimulator : StochasticSimulator
    {

        // CLASS VARIABLES
        private ReactionList reactions;
        private Random random;
        private double r1, r2;
        private double currentTime;
        private int step;
        private double a0;
       
        private bool isRunning;

        public override bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        // PROPERTIES
        public override double TimeElapsed
        {
            get { return currentTime; }
        }

        // CONSTRUCTOR DECLARATIONS
        public GillespieStochasticSimulator(ReactionList reactions)
        {
            this.reactions = reactions;
            this.random = new Random();
            
        }

        // METHOD DECLARATIONS
        private void Initialize()
        {
            step = 0;
            currentTime = 0;
            a0 = CalculateA0();
            this.IsInitialized = true;
        }

        private StochasticReactionWrapper WrapReaction(Reaction reaction)
        {
            return new StochasticReactionWrapper(reaction);
        }

        private double GetReactionProbability(StochasticReactionWrapper reaction)
        {
            return reaction.Propensity;
        }

        private double CalculateTao(double a0, double rand)
        {
            return (1.0/a0) * Math.Log(1.0/rand);
        }

        private void GenerateRandomDoublePair(out double rand1, out double rand2)
        {
            rand1 = random.NextDouble();
            rand2 = random.NextDouble();
        }


        private double CalculateA0() 
        {
            a0 = 0;
            ReactionIterator iter = new ReactionIterator(reactions);

            while (!iter.IsDone())
            {
                StochasticReactionWrapper wrap = WrapReaction(iter.Next());
                a0 += GetReactionProbability(wrap);
                

            }

            return a0;
        }

        private StochasticReactionWrapper DetermineMu(double a0, double r2)
        {
            double sum = 0;
            double a0r2 = a0*r2;

            ReactionIterator iter = new ReactionIterator(reactions);

            while (!iter.IsDone())
            {
                StochasticReactionWrapper reaction = WrapReaction(iter.Next());

                sum += reaction.Propensity;

                if (sum >= a0r2)
                {
                    return reaction;
                }
            }

            throw new Exception("No mu could be determined.");
        }

        private void Step()
        {
            GenerateRandomDoublePair(out r1, out r2);
            //Console.WriteLine("R1: {0} R2: {1}", r1, r2);
            
            double tau = CalculateTao(a0, r1);
            currentTime += tau;

            StochasticReactionWrapper activeReaction = DetermineMu(a0, r2);
            activeReaction.FireReaction();
            

            step++;
            a0 = CalculateA0();
        }

        

        public override void Simulate()
        {
            IsRunning = true;
            Initialize();

            while (IsRunning)
            {
                Step();
            }
        }
      

    }
}
