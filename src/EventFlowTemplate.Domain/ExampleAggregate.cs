using EventFlow.Aggregates;
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventFlowTemplate.Domain
{
    public class ExampleAggregate :
        AggregateRoot<ExampleAggregate, ExampleId>
    {
        private int? _magicNumber;

        public ExampleAggregate(ExampleId id) : base(id)
        {
        }

        public IExecutionResult SetMagicNumer(int magicNumber)
        {
            if (_magicNumber.HasValue)
                return ExecutionResult.Failed("Magic number already set");

            _magicNumber = magicNumber;

            return ExecutionResult.Success();
        }
    }
}
