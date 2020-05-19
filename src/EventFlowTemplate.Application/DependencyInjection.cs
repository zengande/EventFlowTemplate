using EventFlow;
using EventFlow.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventFlowTemplate.Application
{
    public static class DependencyInjection
    {
        public static IEventFlowOptions AddCommandsAndCommandHandlers(this IEventFlowOptions options)
        {
            var assambly = typeof(DependencyInjection).Assembly;
            options.AddCommands(assambly)
                .AddCommandHandlers(assambly);
            return options;
        }
    }
}
