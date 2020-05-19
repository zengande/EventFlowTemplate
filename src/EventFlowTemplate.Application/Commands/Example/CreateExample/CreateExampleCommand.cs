using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using EventFlowTemplate.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventFlowTemplate.Application.Commands.Example.CreateExample
{
    public class CreateExampleCommand :
        Command<ExampleAggregate, ExampleId, IExecutionResult>
    {
        public int MagicNumber { get; }

        public CreateExampleCommand(ExampleId aggregateId, int magicNumber) :
            base(aggregateId)
        {
            MagicNumber = magicNumber;
        }
    }
}
