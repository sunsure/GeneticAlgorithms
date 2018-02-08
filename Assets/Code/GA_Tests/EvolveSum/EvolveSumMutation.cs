using GA.Gene;
using GA.Genome;
using System;

namespace GA.GenerationGenerator.Mutation
{
    public class EvolveSumMutation : MutationBase<int>
    {
        public int MutationRange { get; set; }

        public EvolveSumMutation(Random random, double geneMutChance, int mutRange)
            : base(random, geneMutChance)
        {
            MutationRange = mutRange;
        }

        public override void MutateGene(Gene<int> targetGene)
        {
            targetGene.Val += RandomInst.Next(-MutationRange, MutationRange);
        }
    }
}