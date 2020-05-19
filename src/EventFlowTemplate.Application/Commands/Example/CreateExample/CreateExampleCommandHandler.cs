using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using EventFlow.Logs;
using EventFlowTemplate.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventFlowTemplate.Application.Commands.Example.CreateExample
{
    public class CreateExampleCommandHandler :
        CommandHandler<ExampleAggregate, ExampleId, IExecutionResult, CreateExampleCommand>
    {
        private readonly ILog _log;
        public CreateExampleCommandHandler(ILog log)
        {
            _log = log;
        }

        public override Task<IExecutionResult> ExecuteCommandAsync(ExampleAggregate aggregate, CreateExampleCommand command, CancellationToken cancellationToken)
        {
            _log.Debug($"Create example command handler!");
            
            var executionResult = aggregate.SetMagicNumer(command.MagicNumber);
            return Task.FromResult(executionResult);
        }
    }
}
