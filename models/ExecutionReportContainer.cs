

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
            if(!allowedKeys.Contains(key)){
                throw new ArgumentException(message: $"Given key {key} is not allowed in ExecutionReportContainer!");
            }

            if (_containerDict.ContainsKey(key))
            {
                throw new ArgumentException(message: $"Given key {key} already exists in ExecutionReportContainer!");
            }
            _containerDict.Add(key, execReport);
        }

        public ExecutionReport Get(string key)
        {
            return _containerDict[key];
        }



    }

}