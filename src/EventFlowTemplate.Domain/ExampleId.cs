using EventFlow.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventFlowTemplate.Domain
{
    /// <summary>
    /// 聚合根标识
    /// </summary>
    public class ExampleId :
        Identity<ExampleId>
    {
        public ExampleId(string value) : base(value) { }
    }
}
