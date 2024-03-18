

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using Enums;

namespace Models
{
    public class ExecutionReportContainer
    {
        private static readonly List<string> allowedKeys = [ExecutionReportContainerKey.Current, ExecutionReportContainerKey.Original];
        private readonly Dictionary<string, ExecutionReport> _containerDict;
        public ExecutionReportContainer(ExecutionReport execReport)
        {
            AssertIsNotNull(execReport);
            _containerDict = [];
            _containerDict.Add(ExecutionReportContainerKey.Current, execReport);
        }

        public void Add(string key, ExecutionReport execReport)
        {
            AssertIsNotNull(execReport);
            AssertOnlyAllowed(key);
            AssertUnique(key);
            _containerDict.Add(key, execReport);
        }

        private void AssertUnique(string key)
        {
            if (_containerDict.ContainsKey(key))
            {
                throw new ArgumentException(message: $"Given key {key} already exists in ExecutionReportContainer!");
            }
        }

        private void AssertOnlyAllowed(string key)
        {
            if (!allowedKeys.Contains(key))
            {
                throw new ArgumentException(message: $"Given key {key} is not allowed in ExecutionReportContainer!");
            }
        }

        public ExecutionReport Get(string key)
        {
            if (!allowedKeys.Contains(key))
            {
                throw new ArgumentException(message: $"Given key {key} is not allowed in ExecutionReportContainer!");
            }
            return _containerDict[key];
        }

        private void AssertIsNotNull([NotNull] object? nullableReference)
        {
            if (nullableReference == null)
            {
                throw new ArgumentNullException(paramName:"executionReport");
            }
        }

        public ReadOnlyCollection<ExecutionReport> GetAll(){
            return new ReadOnlyCollection<ExecutionReport>(_containerDict.Values.ToList());
        }

    }

}