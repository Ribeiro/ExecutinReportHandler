

using Enums;

namespace Models
{
    public class ExecutionReportContainer
    {
        private readonly List<string> allowedKeys = new List<string>{ExecutionReportContainerKey.Current, ExecutionReportContainerKey.Original};
        private readonly Dictionary<string, ExecutionReport> _containerDict;
        public ExecutionReportContainer(ExecutionReport execReport)
        {
            _containerDict = [];
            _containerDict.Add(ExecutionReportContainerKey.Current, execReport);
        }

        public void Add(string key, ExecutionReport execReport)
        {
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
            return _containerDict[key];
        }



    }

}