

using Enums;

namespace Models
{
    public class ExecutionReportContainer
    {
        private readonly Dictionary<string, ExecutionReport> _containerDict;
        public ExecutionReportContainer(ExecutionReport execReport)
        {
            _containerDict = [];
            _containerDict.Add(ExecutionReportContainerKey.Current, execReport);
        }

        public void Add(string key, ExecutionReport execReport)
        {
            if (_containerDict.ContainsKey(key))
            {
                throw new ArgumentException(message: $"Given key {key} already exists in container!");
            }
            _containerDict.Add(key, execReport);
        }

        public ExecutionReport Get(string key)
        {
            return _containerDict[key];
        }



    }

}